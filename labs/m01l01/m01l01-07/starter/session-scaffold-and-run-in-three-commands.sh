#!/usr/bin/env bash
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet new console -n Hello
#   The template "Console App" was created successfully.
cd Hello
dotnet run
#   Hello, World!
