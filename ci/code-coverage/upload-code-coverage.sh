#!/usr/bin/env bash

set -e -u -o pipefail

if [[ -n "${DEBUG-}" ]]; then
  set -x
fi

cd "$(dirname "$0")/../.."

mkdir -p logs/coverage-results

buildkite-agent artifact download \
    logs\\coverage-results\\*.xml \
    logs/coverage-results \
    --step ":windows: ~ test"

TOKEN=$(imp-ci secrets read --environment="production" --buildkite-org="improbable" --secret-type="generic-token" --secret-name="gdk-for-unity-bot-sonarcloud-token" --field="token")

args=()
args+=("-Dsonar.buildString=${BUILDKITE_MESSAGE}")
args+=("-Dsonar.log.level=${SONAR_LOG_LEVEL:-"INFO"}")
args+=("-Dsonar.")
if [[ -n "${SONAR_PROJECT_DATE:-}" ]]; then
  # For historical analysis. Note - can only supply a date later than the most recent one in the database.
  args+=("-Dsonar.projectDate=${SONAR_PROJECT_DATE}")
fi
if [[ -n "${SONAR_REVISION:-}" ]]; then
  # Override revision. Useful during historical analysis (i.e. override it to a tag that's being analysed).
  args+=("-Dsonar.scm.revision=${SONAR_REVISION}")
fi
if [[ -n "${BUILDKITE_PULL_REQUEST:-}" && "${BUILDKITE_PULL_REQUEST}" != "false" ]]; then
  # PR analysis, relies on BK building PRs
  # https://docs.sonarqube.org/latest/analysis/pull-request/
  args+=("-Dsonar.pullrequest.key=${BUILDKITE_PULL_REQUEST}")
  args+=("-Dsonar.pullrequest.branch=${BUILDKITE_PULL_REQUEST_BASE_BRANCH}")
  args+=("-Dsonar.pullrequest.base=develop")
fi

pushd ci/code-coverage
  docker build --tag local/sonar-analysis .
popd

docker run \
    -e SONAR_TOKEN="${TOKEN}"
    --user="$(id -u):$(id -g)" \
    -v "$(pwd):/usr/src" \
    -it \
    local/sonar-analysis "${args[@]}"
