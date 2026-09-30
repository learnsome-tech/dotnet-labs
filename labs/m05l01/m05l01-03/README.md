# m05l01-03 · A bad request returns field errors

**Lesson:** [Model Validation and FluentValidation](https://learnsome.tech/learn/dotnet-course/m05l01) (lesson 5.1, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can validate API input at the boundary and return useful field errors without putting validation in handlers.

In the lesson: This small example validates an empty name and a zero price. The result contains one failure for each property, and the loop prints the property names that the client must repair. The SDK is unavailable on this machine, so the panel is an accurate transcript. In the API, format those failures as problem details with a field error dictionary, and keep the rule messages stable enough for humans without making clients parse prose.

## Files

- [`starter/Validation.cs`](starter/Validation.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Validation.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m05l01-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
