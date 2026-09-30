# m04l05-04 · The generated mapper has no runtime setup

**Lesson:** [Source-Generated Mapping with Mapperly](https://learnsome.tech/learn/dotnet-course/m04l05) (lesson 4.5, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can use Mapperly for compile-time mapping while keeping the mapping contract and dependencies explicit.

In the lesson: Once generated, the mapper is used like an ordinary C Sharp type. There is no runtime profile to register and no string based member lookup in this call. The build has already produced the method body. This panel is a transcript because the dot net kit is not installed here. In the sample application, the mapper can be injected or instantiated according to the project style, but the important property is the same: a missing mapping is found during the build rather than by a customer request.

## Files

- [`starter/MapperUse.cs`](starter/MapperUse.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/MapperUse.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m04l05-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
