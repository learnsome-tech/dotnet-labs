#!/usr/bin/env bash
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet --version
#   10.0.100
dotnet --list-sdks
#   10.0.100 [/usr/local/share/dotnet/sdk]
dotnet --list-runtimes
#   Microsoft.AspNetCore.App 10.0.0 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
#   Microsoft.NETCore.App 10.0.0 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]
