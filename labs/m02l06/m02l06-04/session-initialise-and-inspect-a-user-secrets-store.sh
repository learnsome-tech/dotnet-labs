#!/usr/bin/env bash
# Modern .NET Core, C# & Enterprise Microservices — lesson m02l06 — Environment Layering and User Secrets
# https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l06
# © LearnSome.tech
# Terminal session from the video, as a script you can run.
# Each command below was typed at the prompt; the commented lines are what
# the tool answered. Run it with:  bash thisfile.sh
set -euo pipefail

dotnet user-secrets init
#   A user secrets ID was added to the project.
dotnet user-secrets set Catalog:SigningKey local-key
#   Successfully saved Catalog:SigningKey.
dotnet user-secrets list
#   Catalog:SigningKey = local-development-key
