# m03l03-04 · A minimal endpoint responds

**Lesson:** [Building Routes with Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l03) (lesson 3.3, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can build the catalog route surface with minimal APIs, typed binding, endpoint metadata, and explicit results.

In the lesson: This host maps one minimal endpoint and starts the server. A request to the ping path receives the same success status and catalog body that the controller lesson showed. The host stays alive after startup, so the panel records an accurate request transcript rather than pretending a console program exited. In a real test, use an HTTP client against the in memory host and assert the response. The important comparison is the route surface, not the syntax used to declare it.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m03l03-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
