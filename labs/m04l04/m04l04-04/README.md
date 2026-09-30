# m04l04-04 · Mapping produces a public record

**Lesson:** [Manual Object Mapping](https://learnsome.tech/learn/dotnet-course/m04l04) (lesson 4.4, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can map persistence entities to request and response records explicitly and safely.

In the lesson: The entity contains persistence state, and the mapping method produces the public response record. Only the identifier, name, and price cross the seam. This short program is a transcript because there is no SDK here, but the output is deterministic. In a test, compare the whole response record or assert the fields that matter. The explicit method gives a reviewer one place to inspect when the API contract changes.

## Files

- [`starter/Mapping.cs`](starter/Mapping.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Mapping.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m04l04-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
