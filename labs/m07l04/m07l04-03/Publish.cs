// Modern .NET Core, C# & Enterprise Microservices — lesson m07l04 — OpenTelemetry, Container Publishing and Trimming
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m07l04
// © LearnSome.tech
dotnet publish -c Release -p:PublishProfile=DefaultContainer

// Optional after trim analysis:
// dotnet publish -c Release -p:PublishTrimmed=true
