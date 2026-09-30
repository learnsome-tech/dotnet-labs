#!/usr/bin/env bash
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet --version
#   10.0.100
dotnet restore
#   Restore completed successfully.
dotnet build
#   Build succeeded.
