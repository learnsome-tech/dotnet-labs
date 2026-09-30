# m03l01-04 · A tiny middleware writes the path

**Lesson:** [The ASP.NET Core Middleware Pipeline](https://learnsome.tech/learn/dotnet-course/m03l01) (lesson 3.1, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can describe request flow and place middleware in the order that makes authentication, errors, and endpoints behave correctly.

In the lesson: This host logs the path before it calls the next component. A request for the health route prints the path, then reaches the mapped handler. The example is a long lived web host, so its output is a transcript rather than a one shot console result. In a real service, replace console output with structured logging and include a request identifier. Keep middleware small: it should coordinate a cross cutting concern and then hand the request onward, while business decisions belong in an endpoint or application service.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m03l01-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
