#!/usr/bin/env bash
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet format --verify-no-changes
#   Format verification succeeded.
dotnet build -warnaserror
#   Build succeeded with zero warnings.
