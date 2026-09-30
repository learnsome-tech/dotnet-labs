# m04l03-04 · A repository implementation saves one product

**Lesson:** [The Repository Pattern](https://learnsome.tech/learn/dotnet-course/m04l03) (lesson 4.3, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can decide where a repository helps, define a focused interface, and avoid hiding useful query behavior.

In the lesson: The implementation adds one entity and saves the unit of work. The cancellation token reaches both asynchronous database calls, and the final line stands in for a structured log after the commit succeeds. A real repository would receive its context through dependency injection and would usually leave response shaping to the application service. This code is a transcript because the SDK is unavailable, but the sequence is the important part: add, save, then report success.

## Files

- [`starter/ProductRepository.cs`](starter/ProductRepository.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductRepository.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m04l03-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
