# m05l02-03 · A conflict becomes problem details

**Lesson:** [Global Exception Handling and Problem Details](https://learnsome.tech/learn/dotnet-course/m05l02) (lesson 5.2, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can turn expected and unexpected failures into consistent problem details without leaking implementation data.

In the lesson: This transcript shows the stable part of a conflict response: the HTTP status and a human useful title. A real result also carries the problem details content type and any trace identifier added by the host. The SDK is absent here, so the code does not execute. Keep error titles stable and concise, and put diagnostic detail in logs rather than teaching a client about database exceptions or internal class names.

## Files

- [`starter/Problem.cs`](starter/Problem.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Problem.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m05l02-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
