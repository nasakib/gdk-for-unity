using System;
using System.IO;
using NUnit.Framework.Internal;
using UnityEditor;
using UnityEngine;
using Unity.PerformanceTesting;
using Unity.PerformanceTesting.Editor;

namespace Improbable.Gdk.TestUtils.Editor
{
    public class PerfTestMenu
    {
        private const string XmlFileName = "TestResults.xml";
        private const string JsonFileName = "PerformanceTestResults.json";

        //hardcoded in PerformanceTestRunSaver.cs
        private static readonly string XmlPath = Path.Combine(Application.persistentDataPath, XmlFileName);
        private static readonly string JsonPath = Path.Combine(Application.persistentDataPath, JsonFileName);

        private static readonly string ResultsPath = Path.Combine(Application.dataPath, "..", "perftest", "results");

        [MenuItem("SpatialOS/Performance Tests/Export Results")]
        public static void ExportResults()
        {
            var currentTime = DateTime.Now.ToString("s").Replace(":", "_");
            var outputDir = Path.Combine(ResultsPath, currentTime);

            if (!File.Exists(XmlPath) || !File.Exists(JsonPath))
            {
                Debug.LogError("No results to export.");
                return;
            }

            Directory.CreateDirectory(outputDir);
            File.Copy(XmlPath, Path.Combine(outputDir, XmlFileName));
            File.Copy(JsonPath, Path.Combine(outputDir, JsonFileName));
        }

        [MenuItem("SpatialOS/Performance Tests/Clear Results")]
        public static void ClearResults()
        {
            if (Directory.Exists(ResultsPath))
            {
                Directory.Delete(ResultsPath, true);
            }
        }
    }

    public class PerfTestVisualiser
    {
        [MenuItem("SpatialOS/Parse Results")]
        public static void ParseResults()
        {
            var xmlResultsPath =
                "C:\\Users\\paulbalaji\\work\\core\\gdk-for-unity\\test-project\\perftest\\results\\2020-03-10T17_23_20\\TestResults.xml";
            ParseResults(xmlResultsPath);
        }

        private static void ParseResults(string xmlResultsPath)
        {
            var parser = new Unity.PerformanceTesting.Editor.TestResultXmlParser();
            var testRun = parser.GetPerformanceTestRunFromXml(xmlResultsPath);
            if (testRun == null)
            {
                //something has gone wrong, check the logs
                return;
            }

            Debug.Log(testRun.Date);
            Debug.Log(string.Join("\n", testRun.Dependencies));
            Debug.Log(testRun.Editor);
            Debug.Log(testRun.Hardware);
            Debug.Log(testRun.Player);
            Debug.Log(testRun.TestSuite);

            foreach (var result in testRun.Results)
            {
                foreach (var category in result.Categories)
                {
                    Debug.Log(category);
                }
            }
        }
    }
}
