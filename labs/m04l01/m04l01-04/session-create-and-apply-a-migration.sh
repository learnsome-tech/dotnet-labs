#!/usr/bin/env bash
# Modern .NET Core, C# & Enterprise Microservices — lesson m04l01 — Entity Framework Core: Code First and Migrations
# https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l01
# © LearnSome.tech
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
