// =====================================================
// DO NOT EDIT - this file is automatically regenerated.
// =====================================================

using Improbable.Gdk.Core;
using Improbable.Worker.CInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Entities;

namespace Improbable.TestSchema
{
    public partial class ExhaustiveRepeated
    {
        public const uint ComponentId = 197717;

        public unsafe struct Component : IComponentData, ISpatialComponentData, ISnapshottable<Snapshot>
        {
            // Bit masks for tracking which component properties were changed locally and need to be synced.
            private fixed UInt32 dirtyBits[1];

            internal uint field1Handle;

            public global::System.Collections.Generic.List<bool> Field1
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field1Provider.Get(field1Handle);
                set
                {
                    MarkDataDirty(0);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field1Provider.Set(field1Handle, value);
                }
            }

            internal uint field2Handle;

            public global::System.Collections.Generic.List<float> Field2
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field2Provider.Get(field2Handle);
                set
                {
                    MarkDataDirty(1);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field2Provider.Set(field2Handle, value);
                }
            }

            internal uint field3Handle;

            public global::System.Collections.Generic.List<byte[]> Field3
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field3Provider.Get(field3Handle);
                set
                {
                    MarkDataDirty(2);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field3Provider.Set(field3Handle, value);
                }
            }

            internal uint field4Handle;

            public global::System.Collections.Generic.List<int> Field4
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field4Provider.Get(field4Handle);
                set
                {
                    MarkDataDirty(3);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field4Provider.Set(field4Handle, value);
                }
            }

            internal uint field5Handle;

            public global::System.Collections.Generic.List<long> Field5
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field5Provider.Get(field5Handle);
                set
                {
                    MarkDataDirty(4);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field5Provider.Set(field5Handle, value);
                }
            }

            internal uint field6Handle;

            public global::System.Collections.Generic.List<double> Field6
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field6Provider.Get(field6Handle);
                set
                {
                    MarkDataDirty(5);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field6Provider.Set(field6Handle, value);
                }
            }

            internal uint field7Handle;

            public global::System.Collections.Generic.List<string> Field7
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field7Provider.Get(field7Handle);
                set
                {
                    MarkDataDirty(6);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field7Provider.Set(field7Handle, value);
                }
            }

            internal uint field8Handle;

            public global::System.Collections.Generic.List<uint> Field8
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field8Provider.Get(field8Handle);
                set
                {
                    MarkDataDirty(7);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field8Provider.Set(field8Handle, value);
                }
            }

            internal uint field9Handle;

            public global::System.Collections.Generic.List<ulong> Field9
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field9Provider.Get(field9Handle);
                set
                {
                    MarkDataDirty(8);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field9Provider.Set(field9Handle, value);
                }
            }

            internal uint field10Handle;

            public global::System.Collections.Generic.List<int> Field10
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field10Provider.Get(field10Handle);
                set
                {
                    MarkDataDirty(9);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field10Provider.Set(field10Handle, value);
                }
            }

            internal uint field11Handle;

            public global::System.Collections.Generic.List<long> Field11
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field11Provider.Get(field11Handle);
                set
                {
                    MarkDataDirty(10);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field11Provider.Set(field11Handle, value);
                }
            }

            internal uint field12Handle;

            public global::System.Collections.Generic.List<uint> Field12
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field12Provider.Get(field12Handle);
                set
                {
                    MarkDataDirty(11);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field12Provider.Set(field12Handle, value);
                }
            }

            internal uint field13Handle;

            public global::System.Collections.Generic.List<ulong> Field13
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field13Provider.Get(field13Handle);
                set
                {
                    MarkDataDirty(12);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field13Provider.Set(field13Handle, value);
                }
            }

            internal uint field14Handle;

            public global::System.Collections.Generic.List<int> Field14
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field14Provider.Get(field14Handle);
                set
                {
                    MarkDataDirty(13);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field14Provider.Set(field14Handle, value);
                }
            }

            internal uint field15Handle;

            public global::System.Collections.Generic.List<long> Field15
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field15Provider.Get(field15Handle);
                set
                {
                    MarkDataDirty(14);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field15Provider.Set(field15Handle, value);
                }
            }

            internal uint field16Handle;

            public global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId> Field16
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field16Provider.Get(field16Handle);
                set
                {
                    MarkDataDirty(15);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field16Provider.Set(field16Handle, value);
                }
            }

            internal uint field17Handle;

            public global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType> Field17
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field17Provider.Get(field17Handle);
                set
                {
                    MarkDataDirty(16);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field17Provider.Set(field17Handle, value);
                }
            }

            internal uint field18Handle;

            public global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum> Field18
            {
                get => global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field18Provider.Get(field18Handle);
                set
                {
                    MarkDataDirty(17);
                    global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field18Provider.Set(field18Handle, value);
                }
            }

            public bool IsDataDirty()
            {
                var isDataDirty = false;

                isDataDirty |= (dirtyBits[0] != 0x0);

                return isDataDirty;
            }

            /*
            The propertyIndex argument counts up from 0 in the order defined in your schema component.
            It is not the schema field number itself. For example:
            component MyComponent
            {
                id = 1337;
                bool val_a = 1;
                bool val_b = 3;
            }
            In that case, val_a corresponds to propertyIndex 0 and val_b corresponds to propertyIndex 1 in this method.
            This method throws an InvalidOperationException in case your component doesn't contain properties.
            */

            public bool IsDataDirty(int propertyIndex)
            {
                ValidateFieldIndex(propertyIndex);

                // Retrieve the dirtyBits[0-n] field that tracks this property.
                var dirtyBitsByteIndex = propertyIndex >> 4;
                return (dirtyBits[dirtyBitsByteIndex] & (0x1 << (propertyIndex & 31))) != 0x0;
            }

            // Like the IsDataDirty() method above, the propertyIndex arguments starts counting from 0.
            // This method throws an InvalidOperationException in case your component doesn't contain properties.
            public void MarkDataDirty(int propertyIndex)
            {
                ValidateFieldIndex(propertyIndex);

                // Retrieve the dirtyBits[0-n] field that tracks this property.
                var dirtyBitsByteIndex = propertyIndex >> 4;
                dirtyBits[dirtyBitsByteIndex] |= (UInt32) (0x1 << (propertyIndex & 31));
            }

            public void MarkDataClean()
            {
                dirtyBits[0] = 0x0;
            }

            [Conditional("DEBUG")]
            private void ValidateFieldIndex(int propertyIndex)
            {
                if (propertyIndex < 0 || propertyIndex >= 18)
                {
                    throw new ArgumentException("\"propertyIndex\" argument out of range. Valid range is [0, 17]. " +
                        "Unless you are using custom component replication code, this is most likely caused by a code generation bug. " +
                        "Please contact SpatialOS support if you encounter this issue.");
                }
            }

            public Snapshot ToComponentSnapshot(global::Unity.Entities.World world)
            {
                var componentDataSchema = new ComponentData(197717, SchemaComponentData.Create());
                Serialization.SerializeComponent(this, componentDataSchema.SchemaData.Value.GetFields(), world);
                var snapshot = Serialization.DeserializeSnapshot(componentDataSchema.SchemaData.Value.GetFields());

                componentDataSchema.SchemaData?.Destroy();
                componentDataSchema.SchemaData = null;

                return snapshot;
            }
        }

        public struct HasAuthority : IComponentData
        {
        }

        [global::System.Serializable]
        public struct Snapshot : ISpatialComponentSnapshot
        {
            public uint ComponentId => 197717;

            public global::System.Collections.Generic.List<bool> Field1;
            public global::System.Collections.Generic.List<float> Field2;
            public global::System.Collections.Generic.List<byte[]> Field3;
            public global::System.Collections.Generic.List<int> Field4;
            public global::System.Collections.Generic.List<long> Field5;
            public global::System.Collections.Generic.List<double> Field6;
            public global::System.Collections.Generic.List<string> Field7;
            public global::System.Collections.Generic.List<uint> Field8;
            public global::System.Collections.Generic.List<ulong> Field9;
            public global::System.Collections.Generic.List<int> Field10;
            public global::System.Collections.Generic.List<long> Field11;
            public global::System.Collections.Generic.List<uint> Field12;
            public global::System.Collections.Generic.List<ulong> Field13;
            public global::System.Collections.Generic.List<int> Field14;
            public global::System.Collections.Generic.List<long> Field15;
            public global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId> Field16;
            public global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType> Field17;
            public global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum> Field18;

            public Snapshot(global::System.Collections.Generic.List<bool> field1, global::System.Collections.Generic.List<float> field2, global::System.Collections.Generic.List<byte[]> field3, global::System.Collections.Generic.List<int> field4, global::System.Collections.Generic.List<long> field5, global::System.Collections.Generic.List<double> field6, global::System.Collections.Generic.List<string> field7, global::System.Collections.Generic.List<uint> field8, global::System.Collections.Generic.List<ulong> field9, global::System.Collections.Generic.List<int> field10, global::System.Collections.Generic.List<long> field11, global::System.Collections.Generic.List<uint> field12, global::System.Collections.Generic.List<ulong> field13, global::System.Collections.Generic.List<int> field14, global::System.Collections.Generic.List<long> field15, global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId> field16, global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType> field17, global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum> field18)
            {
                Field1 = field1;
                Field2 = field2;
                Field3 = field3;
                Field4 = field4;
                Field5 = field5;
                Field6 = field6;
                Field7 = field7;
                Field8 = field8;
                Field9 = field9;
                Field10 = field10;
                Field11 = field11;
                Field12 = field12;
                Field13 = field13;
                Field14 = field14;
                Field15 = field15;
                Field16 = field16;
                Field17 = field17;
                Field18 = field18;
            }
        }

        public static class Serialization
        {
            public static void SerializeComponent(global::Improbable.TestSchema.ExhaustiveRepeated.Component component, global::Improbable.Worker.CInterop.SchemaObject obj, global::Unity.Entities.World world)
            {
                foreach (var value in component.Field1)
                {
                    obj.AddBool(1, value);
                }

                foreach (var value in component.Field2)
                {
                    obj.AddFloat(2, value);
                }

                foreach (var value in component.Field3)
                {
                    obj.AddBytes(3, value);
                }

                foreach (var value in component.Field4)
                {
                    obj.AddInt32(4, value);
                }

                foreach (var value in component.Field5)
                {
                    obj.AddInt64(5, value);
                }

                foreach (var value in component.Field6)
                {
                    obj.AddDouble(6, value);
                }

                foreach (var value in component.Field7)
                {
                    obj.AddString(7, value);
                }

                foreach (var value in component.Field8)
                {
                    obj.AddUint32(8, value);
                }

                foreach (var value in component.Field9)
                {
                    obj.AddUint64(9, value);
                }

                foreach (var value in component.Field10)
                {
                    obj.AddSint32(10, value);
                }

                foreach (var value in component.Field11)
                {
                    obj.AddSint64(11, value);
                }

                foreach (var value in component.Field12)
                {
                    obj.AddFixed32(12, value);
                }

                foreach (var value in component.Field13)
                {
                    obj.AddFixed64(13, value);
                }

                foreach (var value in component.Field14)
                {
                    obj.AddSfixed32(14, value);
                }

                foreach (var value in component.Field15)
                {
                    obj.AddSfixed64(15, value);
                }

                foreach (var value in component.Field16)
                {
                    obj.AddEntityId(16, value);
                }

                foreach (var value in component.Field17)
                {
                    global::Improbable.TestSchema.SomeType.Serialization.Serialize(value, obj.AddObject(17));
                }

                foreach (var value in component.Field18)
                {
                    obj.AddEnum(18, (uint) value);
                }
            }

            public static void SerializeUpdate(global::Improbable.TestSchema.ExhaustiveRepeated.Component component, global::Improbable.Worker.CInterop.SchemaComponentUpdate updateObj)
            {
                var obj = updateObj.GetFields();

                if (component.IsDataDirty(0))
                {
                    foreach (var value in component.Field1)
                    {
                        obj.AddBool(1, value);
                    }

                    if (component.Field1.Count == 0)
                    {
                        updateObj.AddClearedField(1);
                    }
                }

                if (component.IsDataDirty(1))
                {
                    foreach (var value in component.Field2)
                    {
                        obj.AddFloat(2, value);
                    }

                    if (component.Field2.Count == 0)
                    {
                        updateObj.AddClearedField(2);
                    }
                }

                if (component.IsDataDirty(2))
                {
                    foreach (var value in component.Field3)
                    {
                        obj.AddBytes(3, value);
                    }

                    if (component.Field3.Count == 0)
                    {
                        updateObj.AddClearedField(3);
                    }
                }

                if (component.IsDataDirty(3))
                {
                    foreach (var value in component.Field4)
                    {
                        obj.AddInt32(4, value);
                    }

                    if (component.Field4.Count == 0)
                    {
                        updateObj.AddClearedField(4);
                    }
                }

                if (component.IsDataDirty(4))
                {
                    foreach (var value in component.Field5)
                    {
                        obj.AddInt64(5, value);
                    }

                    if (component.Field5.Count == 0)
                    {
                        updateObj.AddClearedField(5);
                    }
                }

                if (component.IsDataDirty(5))
                {
                    foreach (var value in component.Field6)
                    {
                        obj.AddDouble(6, value);
                    }

                    if (component.Field6.Count == 0)
                    {
                        updateObj.AddClearedField(6);
                    }
                }

                if (component.IsDataDirty(6))
                {
                    foreach (var value in component.Field7)
                    {
                        obj.AddString(7, value);
                    }

                    if (component.Field7.Count == 0)
                    {
                        updateObj.AddClearedField(7);
                    }
                }

                if (component.IsDataDirty(7))
                {
                    foreach (var value in component.Field8)
                    {
                        obj.AddUint32(8, value);
                    }

                    if (component.Field8.Count == 0)
                    {
                        updateObj.AddClearedField(8);
                    }
                }

                if (component.IsDataDirty(8))
                {
                    foreach (var value in component.Field9)
                    {
                        obj.AddUint64(9, value);
                    }

                    if (component.Field9.Count == 0)
                    {
                        updateObj.AddClearedField(9);
                    }
                }

                if (component.IsDataDirty(9))
                {
                    foreach (var value in component.Field10)
                    {
                        obj.AddSint32(10, value);
                    }

                    if (component.Field10.Count == 0)
                    {
                        updateObj.AddClearedField(10);
                    }
                }

                if (component.IsDataDirty(10))
                {
                    foreach (var value in component.Field11)
                    {
                        obj.AddSint64(11, value);
                    }

                    if (component.Field11.Count == 0)
                    {
                        updateObj.AddClearedField(11);
                    }
                }

                if (component.IsDataDirty(11))
                {
                    foreach (var value in component.Field12)
                    {
                        obj.AddFixed32(12, value);
                    }

                    if (component.Field12.Count == 0)
                    {
                        updateObj.AddClearedField(12);
                    }
                }

                if (component.IsDataDirty(12))
                {
                    foreach (var value in component.Field13)
                    {
                        obj.AddFixed64(13, value);
                    }

                    if (component.Field13.Count == 0)
                    {
                        updateObj.AddClearedField(13);
                    }
                }

                if (component.IsDataDirty(13))
                {
                    foreach (var value in component.Field14)
                    {
                        obj.AddSfixed32(14, value);
                    }

                    if (component.Field14.Count == 0)
                    {
                        updateObj.AddClearedField(14);
                    }
                }

                if (component.IsDataDirty(14))
                {
                    foreach (var value in component.Field15)
                    {
                        obj.AddSfixed64(15, value);
                    }

                    if (component.Field15.Count == 0)
                    {
                        updateObj.AddClearedField(15);
                    }
                }

                if (component.IsDataDirty(15))
                {
                    foreach (var value in component.Field16)
                    {
                        obj.AddEntityId(16, value);
                    }

                    if (component.Field16.Count == 0)
                    {
                        updateObj.AddClearedField(16);
                    }
                }

                if (component.IsDataDirty(16))
                {
                    foreach (var value in component.Field17)
                    {
                        global::Improbable.TestSchema.SomeType.Serialization.Serialize(value, obj.AddObject(17));
                    }

                    if (component.Field17.Count == 0)
                    {
                        updateObj.AddClearedField(17);
                    }
                }

                if (component.IsDataDirty(17))
                {
                    foreach (var value in component.Field18)
                    {
                        obj.AddEnum(18, (uint) value);
                    }

                    if (component.Field18.Count == 0)
                    {
                        updateObj.AddClearedField(18);
                    }
                }
            }

            public static void SerializeUpdate(global::Improbable.TestSchema.ExhaustiveRepeated.Update update, global::Improbable.Worker.CInterop.SchemaComponentUpdate updateObj)
            {
                var obj = updateObj.GetFields();

                {
                    if (update.Field1.HasValue)
                    {
                        var field = update.Field1.Value;

                        foreach (var value in field)
                        {
                            obj.AddBool(1, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(1);
                        }
                    }
                }

                {
                    if (update.Field2.HasValue)
                    {
                        var field = update.Field2.Value;

                        foreach (var value in field)
                        {
                            obj.AddFloat(2, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(2);
                        }
                    }
                }

                {
                    if (update.Field3.HasValue)
                    {
                        var field = update.Field3.Value;

                        foreach (var value in field)
                        {
                            obj.AddBytes(3, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(3);
                        }
                    }
                }

                {
                    if (update.Field4.HasValue)
                    {
                        var field = update.Field4.Value;

                        foreach (var value in field)
                        {
                            obj.AddInt32(4, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(4);
                        }
                    }
                }

                {
                    if (update.Field5.HasValue)
                    {
                        var field = update.Field5.Value;

                        foreach (var value in field)
                        {
                            obj.AddInt64(5, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(5);
                        }
                    }
                }

                {
                    if (update.Field6.HasValue)
                    {
                        var field = update.Field6.Value;

                        foreach (var value in field)
                        {
                            obj.AddDouble(6, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(6);
                        }
                    }
                }

                {
                    if (update.Field7.HasValue)
                    {
                        var field = update.Field7.Value;

                        foreach (var value in field)
                        {
                            obj.AddString(7, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(7);
                        }
                    }
                }

                {
                    if (update.Field8.HasValue)
                    {
                        var field = update.Field8.Value;

                        foreach (var value in field)
                        {
                            obj.AddUint32(8, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(8);
                        }
                    }
                }

                {
                    if (update.Field9.HasValue)
                    {
                        var field = update.Field9.Value;

                        foreach (var value in field)
                        {
                            obj.AddUint64(9, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(9);
                        }
                    }
                }

                {
                    if (update.Field10.HasValue)
                    {
                        var field = update.Field10.Value;

                        foreach (var value in field)
                        {
                            obj.AddSint32(10, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(10);
                        }
                    }
                }

                {
                    if (update.Field11.HasValue)
                    {
                        var field = update.Field11.Value;

                        foreach (var value in field)
                        {
                            obj.AddSint64(11, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(11);
                        }
                    }
                }

                {
                    if (update.Field12.HasValue)
                    {
                        var field = update.Field12.Value;

                        foreach (var value in field)
                        {
                            obj.AddFixed32(12, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(12);
                        }
                    }
                }

                {
                    if (update.Field13.HasValue)
                    {
                        var field = update.Field13.Value;

                        foreach (var value in field)
                        {
                            obj.AddFixed64(13, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(13);
                        }
                    }
                }

                {
                    if (update.Field14.HasValue)
                    {
                        var field = update.Field14.Value;

                        foreach (var value in field)
                        {
                            obj.AddSfixed32(14, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(14);
                        }
                    }
                }

                {
                    if (update.Field15.HasValue)
                    {
                        var field = update.Field15.Value;

                        foreach (var value in field)
                        {
                            obj.AddSfixed64(15, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(15);
                        }
                    }
                }

                {
                    if (update.Field16.HasValue)
                    {
                        var field = update.Field16.Value;

                        foreach (var value in field)
                        {
                            obj.AddEntityId(16, value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(16);
                        }
                    }
                }

                {
                    if (update.Field17.HasValue)
                    {
                        var field = update.Field17.Value;

                        foreach (var value in field)
                        {
                            global::Improbable.TestSchema.SomeType.Serialization.Serialize(value, obj.AddObject(17));
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(17);
                        }
                    }
                }

                {
                    if (update.Field18.HasValue)
                    {
                        var field = update.Field18.Value;

                        foreach (var value in field)
                        {
                            obj.AddEnum(18, (uint) value);
                        }

                        if (field.Count == 0)
                        {
                            updateObj.AddClearedField(18);
                        }
                    }
                }
            }

            public static void SerializeSnapshot(global::Improbable.TestSchema.ExhaustiveRepeated.Snapshot snapshot, global::Improbable.Worker.CInterop.SchemaObject obj)
            {
                foreach (var value in snapshot.Field1)
                {
                    obj.AddBool(1, value);
                }

                foreach (var value in snapshot.Field2)
                {
                    obj.AddFloat(2, value);
                }

                foreach (var value in snapshot.Field3)
                {
                    obj.AddBytes(3, value);
                }

                foreach (var value in snapshot.Field4)
                {
                    obj.AddInt32(4, value);
                }

                foreach (var value in snapshot.Field5)
                {
                    obj.AddInt64(5, value);
                }

                foreach (var value in snapshot.Field6)
                {
                    obj.AddDouble(6, value);
                }

                foreach (var value in snapshot.Field7)
                {
                    obj.AddString(7, value);
                }

                foreach (var value in snapshot.Field8)
                {
                    obj.AddUint32(8, value);
                }

                foreach (var value in snapshot.Field9)
                {
                    obj.AddUint64(9, value);
                }

                foreach (var value in snapshot.Field10)
                {
                    obj.AddSint32(10, value);
                }

                foreach (var value in snapshot.Field11)
                {
                    obj.AddSint64(11, value);
                }

                foreach (var value in snapshot.Field12)
                {
                    obj.AddFixed32(12, value);
                }

                foreach (var value in snapshot.Field13)
                {
                    obj.AddFixed64(13, value);
                }

                foreach (var value in snapshot.Field14)
                {
                    obj.AddSfixed32(14, value);
                }

                foreach (var value in snapshot.Field15)
                {
                    obj.AddSfixed64(15, value);
                }

                foreach (var value in snapshot.Field16)
                {
                    obj.AddEntityId(16, value);
                }

                foreach (var value in snapshot.Field17)
                {
                    global::Improbable.TestSchema.SomeType.Serialization.Serialize(value, obj.AddObject(17));
                }

                foreach (var value in snapshot.Field18)
                {
                    obj.AddEnum(18, (uint) value);
                }
            }

            public static global::Improbable.TestSchema.ExhaustiveRepeated.Component Deserialize(global::Improbable.Worker.CInterop.SchemaObject obj, global::Unity.Entities.World world)
            {
                var component = new global::Improbable.TestSchema.ExhaustiveRepeated.Component();

                component.field1Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field1Provider.Allocate(world);

                {
                    component.Field1 = new global::System.Collections.Generic.List<bool>();
                    var list = component.Field1;
                    var listLength = obj.GetBoolCount(1);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexBool(1, (uint) i));
                    }
                }

                component.field2Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field2Provider.Allocate(world);

                {
                    component.Field2 = new global::System.Collections.Generic.List<float>();
                    var list = component.Field2;
                    var listLength = obj.GetFloatCount(2);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFloat(2, (uint) i));
                    }
                }

                component.field3Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field3Provider.Allocate(world);

                {
                    component.Field3 = new global::System.Collections.Generic.List<byte[]>();
                    var list = component.Field3;
                    var listLength = obj.GetBytesCount(3);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexBytes(3, (uint) i));
                    }
                }

                component.field4Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field4Provider.Allocate(world);

                {
                    component.Field4 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field4;
                    var listLength = obj.GetInt32Count(4);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexInt32(4, (uint) i));
                    }
                }

                component.field5Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field5Provider.Allocate(world);

                {
                    component.Field5 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field5;
                    var listLength = obj.GetInt64Count(5);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexInt64(5, (uint) i));
                    }
                }

                component.field6Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field6Provider.Allocate(world);

                {
                    component.Field6 = new global::System.Collections.Generic.List<double>();
                    var list = component.Field6;
                    var listLength = obj.GetDoubleCount(6);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexDouble(6, (uint) i));
                    }
                }

                component.field7Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field7Provider.Allocate(world);

                {
                    component.Field7 = new global::System.Collections.Generic.List<string>();
                    var list = component.Field7;
                    var listLength = obj.GetStringCount(7);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexString(7, (uint) i));
                    }
                }

                component.field8Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field8Provider.Allocate(world);

                {
                    component.Field8 = new global::System.Collections.Generic.List<uint>();
                    var list = component.Field8;
                    var listLength = obj.GetUint32Count(8);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexUint32(8, (uint) i));
                    }
                }

                component.field9Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field9Provider.Allocate(world);

                {
                    component.Field9 = new global::System.Collections.Generic.List<ulong>();
                    var list = component.Field9;
                    var listLength = obj.GetUint64Count(9);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexUint64(9, (uint) i));
                    }
                }

                component.field10Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field10Provider.Allocate(world);

                {
                    component.Field10 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field10;
                    var listLength = obj.GetSint32Count(10);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSint32(10, (uint) i));
                    }
                }

                component.field11Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field11Provider.Allocate(world);

                {
                    component.Field11 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field11;
                    var listLength = obj.GetSint64Count(11);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSint64(11, (uint) i));
                    }
                }

                component.field12Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field12Provider.Allocate(world);

                {
                    component.Field12 = new global::System.Collections.Generic.List<uint>();
                    var list = component.Field12;
                    var listLength = obj.GetFixed32Count(12);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFixed32(12, (uint) i));
                    }
                }

                component.field13Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field13Provider.Allocate(world);

                {
                    component.Field13 = new global::System.Collections.Generic.List<ulong>();
                    var list = component.Field13;
                    var listLength = obj.GetFixed64Count(13);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFixed64(13, (uint) i));
                    }
                }

                component.field14Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field14Provider.Allocate(world);

                {
                    component.Field14 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field14;
                    var listLength = obj.GetSfixed32Count(14);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSfixed32(14, (uint) i));
                    }
                }

                component.field15Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field15Provider.Allocate(world);

                {
                    component.Field15 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field15;
                    var listLength = obj.GetSfixed64Count(15);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSfixed64(15, (uint) i));
                    }
                }

                component.field16Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field16Provider.Allocate(world);

                {
                    component.Field16 = new global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>();
                    var list = component.Field16;
                    var listLength = obj.GetEntityIdCount(16);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexEntityIdStruct(16, (uint) i));
                    }
                }

                component.field17Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field17Provider.Allocate(world);

                {
                    component.Field17 = new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>();
                    var list = component.Field17;
                    var listLength = obj.GetObjectCount(17);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i)));
                    }
                }

                component.field18Handle = global::Improbable.TestSchema.ExhaustiveRepeated.ReferenceTypeProviders.Field18Provider.Allocate(world);

                {
                    component.Field18 = new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>();
                    var list = component.Field18;
                    var listLength = obj.GetEnumCount(18);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add((global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i));
                    }
                }

                return component;
            }

            public static global::Improbable.TestSchema.ExhaustiveRepeated.Update DeserializeUpdate(global::Improbable.Worker.CInterop.SchemaComponentUpdate updateObj)
            {
                var update = new global::Improbable.TestSchema.ExhaustiveRepeated.Update();
                var obj = updateObj.GetFields();

                {
                    var listSize = obj.GetBoolCount(1);

                    var isCleared = updateObj.IsFieldCleared(1);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field1 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<bool>>(new global::System.Collections.Generic.List<bool>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBool(1, (uint) i);
                        update.Field1.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFloatCount(2);

                    var isCleared = updateObj.IsFieldCleared(2);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field2 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<float>>(new global::System.Collections.Generic.List<float>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFloat(2, (uint) i);
                        update.Field2.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetBytesCount(3);

                    var isCleared = updateObj.IsFieldCleared(3);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field3 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<byte[]>>(new global::System.Collections.Generic.List<byte[]>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBytes(3, (uint) i);
                        update.Field3.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt32Count(4);

                    var isCleared = updateObj.IsFieldCleared(4);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field4 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt32(4, (uint) i);
                        update.Field4.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt64Count(5);

                    var isCleared = updateObj.IsFieldCleared(5);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field5 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt64(5, (uint) i);
                        update.Field5.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetDoubleCount(6);

                    var isCleared = updateObj.IsFieldCleared(6);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field6 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<double>>(new global::System.Collections.Generic.List<double>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexDouble(6, (uint) i);
                        update.Field6.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetStringCount(7);

                    var isCleared = updateObj.IsFieldCleared(7);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field7 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<string>>(new global::System.Collections.Generic.List<string>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexString(7, (uint) i);
                        update.Field7.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint32Count(8);

                    var isCleared = updateObj.IsFieldCleared(8);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field8 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<uint>>(new global::System.Collections.Generic.List<uint>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint32(8, (uint) i);
                        update.Field8.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint64Count(9);

                    var isCleared = updateObj.IsFieldCleared(9);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field9 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<ulong>>(new global::System.Collections.Generic.List<ulong>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint64(9, (uint) i);
                        update.Field9.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint32Count(10);

                    var isCleared = updateObj.IsFieldCleared(10);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field10 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint32(10, (uint) i);
                        update.Field10.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint64Count(11);

                    var isCleared = updateObj.IsFieldCleared(11);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field11 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint64(11, (uint) i);
                        update.Field11.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed32Count(12);

                    var isCleared = updateObj.IsFieldCleared(12);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field12 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<uint>>(new global::System.Collections.Generic.List<uint>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed32(12, (uint) i);
                        update.Field12.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed64Count(13);

                    var isCleared = updateObj.IsFieldCleared(13);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field13 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<ulong>>(new global::System.Collections.Generic.List<ulong>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed64(13, (uint) i);
                        update.Field13.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed32Count(14);

                    var isCleared = updateObj.IsFieldCleared(14);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field14 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed32(14, (uint) i);
                        update.Field14.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed64Count(15);

                    var isCleared = updateObj.IsFieldCleared(15);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field15 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed64(15, (uint) i);
                        update.Field15.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEntityIdCount(16);

                    var isCleared = updateObj.IsFieldCleared(16);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field16 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>>(new global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexEntityIdStruct(16, (uint) i);
                        update.Field16.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetObjectCount(17);

                    var isCleared = updateObj.IsFieldCleared(17);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field17 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>>(new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i));
                        update.Field17.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEnumCount(18);

                    var isCleared = updateObj.IsFieldCleared(18);

                    if (listSize > 0 || isCleared)
                    {
                        update.Field18 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>>(new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>());
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = (global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i);
                        update.Field18.Value.Add(value);
                    }
                }

                return update;
            }

            public static global::Improbable.TestSchema.ExhaustiveRepeated.Update DeserializeUpdate(global::Improbable.Worker.CInterop.SchemaComponentData data)
            {
                var update = new global::Improbable.TestSchema.ExhaustiveRepeated.Update();
                var obj = data.GetFields();

                {
                    var listSize = obj.GetBoolCount(1);
                    update.Field1 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<bool>>(new global::System.Collections.Generic.List<bool>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBool(1, (uint) i);
                        update.Field1.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFloatCount(2);
                    update.Field2 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<float>>(new global::System.Collections.Generic.List<float>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFloat(2, (uint) i);
                        update.Field2.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetBytesCount(3);
                    update.Field3 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<byte[]>>(new global::System.Collections.Generic.List<byte[]>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBytes(3, (uint) i);
                        update.Field3.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt32Count(4);
                    update.Field4 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt32(4, (uint) i);
                        update.Field4.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt64Count(5);
                    update.Field5 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt64(5, (uint) i);
                        update.Field5.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetDoubleCount(6);
                    update.Field6 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<double>>(new global::System.Collections.Generic.List<double>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexDouble(6, (uint) i);
                        update.Field6.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetStringCount(7);
                    update.Field7 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<string>>(new global::System.Collections.Generic.List<string>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexString(7, (uint) i);
                        update.Field7.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint32Count(8);
                    update.Field8 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<uint>>(new global::System.Collections.Generic.List<uint>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint32(8, (uint) i);
                        update.Field8.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint64Count(9);
                    update.Field9 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<ulong>>(new global::System.Collections.Generic.List<ulong>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint64(9, (uint) i);
                        update.Field9.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint32Count(10);
                    update.Field10 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint32(10, (uint) i);
                        update.Field10.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint64Count(11);
                    update.Field11 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint64(11, (uint) i);
                        update.Field11.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed32Count(12);
                    update.Field12 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<uint>>(new global::System.Collections.Generic.List<uint>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed32(12, (uint) i);
                        update.Field12.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed64Count(13);
                    update.Field13 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<ulong>>(new global::System.Collections.Generic.List<ulong>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed64(13, (uint) i);
                        update.Field13.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed32Count(14);
                    update.Field14 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<int>>(new global::System.Collections.Generic.List<int>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed32(14, (uint) i);
                        update.Field14.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed64Count(15);
                    update.Field15 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<long>>(new global::System.Collections.Generic.List<long>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed64(15, (uint) i);
                        update.Field15.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEntityIdCount(16);
                    update.Field16 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>>(new global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexEntityIdStruct(16, (uint) i);
                        update.Field16.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetObjectCount(17);
                    update.Field17 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>>(new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i));
                        update.Field17.Value.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEnumCount(18);
                    update.Field18 = new global::Improbable.Gdk.Core.Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>>(new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>());

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = (global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i);
                        update.Field18.Value.Add(value);
                    }
                }

                return update;
            }

            public static global::Improbable.TestSchema.ExhaustiveRepeated.Snapshot DeserializeSnapshot(global::Improbable.Worker.CInterop.SchemaObject obj)
            {
                var component = new global::Improbable.TestSchema.ExhaustiveRepeated.Snapshot();

                {
                    component.Field1 = new global::System.Collections.Generic.List<bool>();
                    var list = component.Field1;
                    var listLength = obj.GetBoolCount(1);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexBool(1, (uint) i));
                    }
                }

                {
                    component.Field2 = new global::System.Collections.Generic.List<float>();
                    var list = component.Field2;
                    var listLength = obj.GetFloatCount(2);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFloat(2, (uint) i));
                    }
                }

                {
                    component.Field3 = new global::System.Collections.Generic.List<byte[]>();
                    var list = component.Field3;
                    var listLength = obj.GetBytesCount(3);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexBytes(3, (uint) i));
                    }
                }

                {
                    component.Field4 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field4;
                    var listLength = obj.GetInt32Count(4);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexInt32(4, (uint) i));
                    }
                }

                {
                    component.Field5 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field5;
                    var listLength = obj.GetInt64Count(5);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexInt64(5, (uint) i));
                    }
                }

                {
                    component.Field6 = new global::System.Collections.Generic.List<double>();
                    var list = component.Field6;
                    var listLength = obj.GetDoubleCount(6);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexDouble(6, (uint) i));
                    }
                }

                {
                    component.Field7 = new global::System.Collections.Generic.List<string>();
                    var list = component.Field7;
                    var listLength = obj.GetStringCount(7);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexString(7, (uint) i));
                    }
                }

                {
                    component.Field8 = new global::System.Collections.Generic.List<uint>();
                    var list = component.Field8;
                    var listLength = obj.GetUint32Count(8);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexUint32(8, (uint) i));
                    }
                }

                {
                    component.Field9 = new global::System.Collections.Generic.List<ulong>();
                    var list = component.Field9;
                    var listLength = obj.GetUint64Count(9);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexUint64(9, (uint) i));
                    }
                }

                {
                    component.Field10 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field10;
                    var listLength = obj.GetSint32Count(10);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSint32(10, (uint) i));
                    }
                }

                {
                    component.Field11 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field11;
                    var listLength = obj.GetSint64Count(11);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSint64(11, (uint) i));
                    }
                }

                {
                    component.Field12 = new global::System.Collections.Generic.List<uint>();
                    var list = component.Field12;
                    var listLength = obj.GetFixed32Count(12);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFixed32(12, (uint) i));
                    }
                }

                {
                    component.Field13 = new global::System.Collections.Generic.List<ulong>();
                    var list = component.Field13;
                    var listLength = obj.GetFixed64Count(13);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexFixed64(13, (uint) i));
                    }
                }

                {
                    component.Field14 = new global::System.Collections.Generic.List<int>();
                    var list = component.Field14;
                    var listLength = obj.GetSfixed32Count(14);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSfixed32(14, (uint) i));
                    }
                }

                {
                    component.Field15 = new global::System.Collections.Generic.List<long>();
                    var list = component.Field15;
                    var listLength = obj.GetSfixed64Count(15);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexSfixed64(15, (uint) i));
                    }
                }

                {
                    component.Field16 = new global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>();
                    var list = component.Field16;
                    var listLength = obj.GetEntityIdCount(16);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(obj.IndexEntityIdStruct(16, (uint) i));
                    }
                }

                {
                    component.Field17 = new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>();
                    var list = component.Field17;
                    var listLength = obj.GetObjectCount(17);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add(global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i)));
                    }
                }

                {
                    component.Field18 = new global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>();
                    var list = component.Field18;
                    var listLength = obj.GetEnumCount(18);

                    for (var i = 0; i < listLength; i++)
                    {
                        list.Add((global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i));
                    }
                }

                return component;
            }

            public static void ApplyUpdate(global::Improbable.Worker.CInterop.SchemaComponentUpdate updateObj, ref global::Improbable.TestSchema.ExhaustiveRepeated.Component component)
            {
                var obj = updateObj.GetFields();

                {
                    var listSize = obj.GetBoolCount(1);

                    var isCleared = updateObj.IsFieldCleared(1);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field1.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBool(1, (uint) i);
                        component.Field1.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFloatCount(2);

                    var isCleared = updateObj.IsFieldCleared(2);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field2.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFloat(2, (uint) i);
                        component.Field2.Add(value);
                    }
                }

                {
                    var listSize = obj.GetBytesCount(3);

                    var isCleared = updateObj.IsFieldCleared(3);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field3.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBytes(3, (uint) i);
                        component.Field3.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt32Count(4);

                    var isCleared = updateObj.IsFieldCleared(4);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field4.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt32(4, (uint) i);
                        component.Field4.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt64Count(5);

                    var isCleared = updateObj.IsFieldCleared(5);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field5.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt64(5, (uint) i);
                        component.Field5.Add(value);
                    }
                }

                {
                    var listSize = obj.GetDoubleCount(6);

                    var isCleared = updateObj.IsFieldCleared(6);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field6.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexDouble(6, (uint) i);
                        component.Field6.Add(value);
                    }
                }

                {
                    var listSize = obj.GetStringCount(7);

                    var isCleared = updateObj.IsFieldCleared(7);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field7.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexString(7, (uint) i);
                        component.Field7.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint32Count(8);

                    var isCleared = updateObj.IsFieldCleared(8);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field8.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint32(8, (uint) i);
                        component.Field8.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint64Count(9);

                    var isCleared = updateObj.IsFieldCleared(9);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field9.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint64(9, (uint) i);
                        component.Field9.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint32Count(10);

                    var isCleared = updateObj.IsFieldCleared(10);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field10.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint32(10, (uint) i);
                        component.Field10.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint64Count(11);

                    var isCleared = updateObj.IsFieldCleared(11);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field11.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint64(11, (uint) i);
                        component.Field11.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed32Count(12);

                    var isCleared = updateObj.IsFieldCleared(12);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field12.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed32(12, (uint) i);
                        component.Field12.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed64Count(13);

                    var isCleared = updateObj.IsFieldCleared(13);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field13.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed64(13, (uint) i);
                        component.Field13.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed32Count(14);

                    var isCleared = updateObj.IsFieldCleared(14);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field14.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed32(14, (uint) i);
                        component.Field14.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed64Count(15);

                    var isCleared = updateObj.IsFieldCleared(15);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field15.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed64(15, (uint) i);
                        component.Field15.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEntityIdCount(16);

                    var isCleared = updateObj.IsFieldCleared(16);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field16.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexEntityIdStruct(16, (uint) i);
                        component.Field16.Add(value);
                    }
                }

                {
                    var listSize = obj.GetObjectCount(17);

                    var isCleared = updateObj.IsFieldCleared(17);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field17.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i));
                        component.Field17.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEnumCount(18);

                    var isCleared = updateObj.IsFieldCleared(18);

                    if (listSize > 0 || isCleared)
                    {
                        component.Field18.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = (global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i);
                        component.Field18.Add(value);
                    }
                }
            }

            public static void ApplyUpdate(global::Improbable.Worker.CInterop.SchemaComponentUpdate updateObj, ref global::Improbable.TestSchema.ExhaustiveRepeated.Snapshot snapshot)
            {
                var obj = updateObj.GetFields();

                {
                    var listSize = obj.GetBoolCount(1);

                    var isCleared = updateObj.IsFieldCleared(1);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field1.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBool(1, (uint) i);
                        snapshot.Field1.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFloatCount(2);

                    var isCleared = updateObj.IsFieldCleared(2);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field2.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFloat(2, (uint) i);
                        snapshot.Field2.Add(value);
                    }
                }

                {
                    var listSize = obj.GetBytesCount(3);

                    var isCleared = updateObj.IsFieldCleared(3);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field3.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexBytes(3, (uint) i);
                        snapshot.Field3.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt32Count(4);

                    var isCleared = updateObj.IsFieldCleared(4);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field4.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt32(4, (uint) i);
                        snapshot.Field4.Add(value);
                    }
                }

                {
                    var listSize = obj.GetInt64Count(5);

                    var isCleared = updateObj.IsFieldCleared(5);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field5.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexInt64(5, (uint) i);
                        snapshot.Field5.Add(value);
                    }
                }

                {
                    var listSize = obj.GetDoubleCount(6);

                    var isCleared = updateObj.IsFieldCleared(6);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field6.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexDouble(6, (uint) i);
                        snapshot.Field6.Add(value);
                    }
                }

                {
                    var listSize = obj.GetStringCount(7);

                    var isCleared = updateObj.IsFieldCleared(7);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field7.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexString(7, (uint) i);
                        snapshot.Field7.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint32Count(8);

                    var isCleared = updateObj.IsFieldCleared(8);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field8.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint32(8, (uint) i);
                        snapshot.Field8.Add(value);
                    }
                }

                {
                    var listSize = obj.GetUint64Count(9);

                    var isCleared = updateObj.IsFieldCleared(9);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field9.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexUint64(9, (uint) i);
                        snapshot.Field9.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint32Count(10);

                    var isCleared = updateObj.IsFieldCleared(10);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field10.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint32(10, (uint) i);
                        snapshot.Field10.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSint64Count(11);

                    var isCleared = updateObj.IsFieldCleared(11);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field11.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSint64(11, (uint) i);
                        snapshot.Field11.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed32Count(12);

                    var isCleared = updateObj.IsFieldCleared(12);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field12.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed32(12, (uint) i);
                        snapshot.Field12.Add(value);
                    }
                }

                {
                    var listSize = obj.GetFixed64Count(13);

                    var isCleared = updateObj.IsFieldCleared(13);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field13.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexFixed64(13, (uint) i);
                        snapshot.Field13.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed32Count(14);

                    var isCleared = updateObj.IsFieldCleared(14);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field14.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed32(14, (uint) i);
                        snapshot.Field14.Add(value);
                    }
                }

                {
                    var listSize = obj.GetSfixed64Count(15);

                    var isCleared = updateObj.IsFieldCleared(15);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field15.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexSfixed64(15, (uint) i);
                        snapshot.Field15.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEntityIdCount(16);

                    var isCleared = updateObj.IsFieldCleared(16);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field16.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = obj.IndexEntityIdStruct(16, (uint) i);
                        snapshot.Field16.Add(value);
                    }
                }

                {
                    var listSize = obj.GetObjectCount(17);

                    var isCleared = updateObj.IsFieldCleared(17);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field17.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = global::Improbable.TestSchema.SomeType.Serialization.Deserialize(obj.IndexObject(17, (uint) i));
                        snapshot.Field17.Add(value);
                    }
                }

                {
                    var listSize = obj.GetEnumCount(18);

                    var isCleared = updateObj.IsFieldCleared(18);

                    if (listSize > 0 || isCleared)
                    {
                        snapshot.Field18.Clear();
                    }

                    for (var i = 0; i < listSize; i++)
                    {
                        var value = (global::Improbable.TestSchema.SomeEnum) obj.IndexEnum(18, (uint) i);
                        snapshot.Field18.Add(value);
                    }
                }
            }
        }

        public struct Update : ISpatialComponentUpdate
        {
            public Option<global::System.Collections.Generic.List<bool>> Field1;
            public Option<global::System.Collections.Generic.List<float>> Field2;
            public Option<global::System.Collections.Generic.List<byte[]>> Field3;
            public Option<global::System.Collections.Generic.List<int>> Field4;
            public Option<global::System.Collections.Generic.List<long>> Field5;
            public Option<global::System.Collections.Generic.List<double>> Field6;
            public Option<global::System.Collections.Generic.List<string>> Field7;
            public Option<global::System.Collections.Generic.List<uint>> Field8;
            public Option<global::System.Collections.Generic.List<ulong>> Field9;
            public Option<global::System.Collections.Generic.List<int>> Field10;
            public Option<global::System.Collections.Generic.List<long>> Field11;
            public Option<global::System.Collections.Generic.List<uint>> Field12;
            public Option<global::System.Collections.Generic.List<ulong>> Field13;
            public Option<global::System.Collections.Generic.List<int>> Field14;
            public Option<global::System.Collections.Generic.List<long>> Field15;
            public Option<global::System.Collections.Generic.List<global::Improbable.Gdk.Core.EntityId>> Field16;
            public Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeType>> Field17;
            public Option<global::System.Collections.Generic.List<global::Improbable.TestSchema.SomeEnum>> Field18;
        }

        internal class ExhaustiveRepeatedDynamic : IDynamicInvokable
        {
            public uint ComponentId => ExhaustiveRepeated.ComponentId;

            internal static Dynamic.VTable<Update, Snapshot> VTable = new Dynamic.VTable<Update, Snapshot>
            {
                DeserializeSnapshot = DeserializeSnapshot,
                SerializeSnapshot = SerializeSnapshot,
                DeserializeSnapshotRaw = Serialization.DeserializeSnapshot,
                SerializeSnapshotRaw = Serialization.SerializeSnapshot,
                ConvertSnapshotToUpdate = SnapshotToUpdate
            };

            private static Snapshot DeserializeSnapshot(ComponentData snapshot)
            {
                var schemaDataOpt = snapshot.SchemaData;
                if (!schemaDataOpt.HasValue)
                {
                    throw new ArgumentException($"Can not deserialize an empty {nameof(ComponentData)}");
                }

                return Serialization.DeserializeSnapshot(schemaDataOpt.Value.GetFields());
            }

            private static void SerializeSnapshot(Snapshot snapshot, ComponentData data)
            {
                var schemaDataOpt = data.SchemaData;
                if (!schemaDataOpt.HasValue)
                {
                    throw new ArgumentException($"Can not serialise an empty {nameof(ComponentData)}");
                }

                Serialization.SerializeSnapshot(snapshot, data.SchemaData.Value.GetFields());
            }

            private static Update SnapshotToUpdate(in Snapshot snapshot)
            {
                var update = new Update
                {
                    Field1 = snapshot.Field1,
                    Field2 = snapshot.Field2,
                    Field3 = snapshot.Field3,
                    Field4 = snapshot.Field4,
                    Field5 = snapshot.Field5,
                    Field6 = snapshot.Field6,
                    Field7 = snapshot.Field7,
                    Field8 = snapshot.Field8,
                    Field9 = snapshot.Field9,
                    Field10 = snapshot.Field10,
                    Field11 = snapshot.Field11,
                    Field12 = snapshot.Field12,
                    Field13 = snapshot.Field13,
                    Field14 = snapshot.Field14,
                    Field15 = snapshot.Field15,
                    Field16 = snapshot.Field16,
                    Field17 = snapshot.Field17,
                    Field18 = snapshot.Field18
                };

                return update;
            }

            public void InvokeHandler(Dynamic.IHandler handler)
            {
                handler.Accept<Update, Snapshot>(ComponentId, VTable);
            }
        }
    }
}
