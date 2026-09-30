#!/usr/bin/env bash
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet ef migrations add InitialCatalog
#   Build started.
#   Done. To undo this action, use dotnet ef migrations remove.
dotnet ef database update
#   Applying migration InitialCatalog.
#   Done.
