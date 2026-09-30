# m05l02-02 · Register the built in exception handler

**Lesson:** [Global Exception Handling and Problem Details](https://learnsome.tech/learn/dotnet-course/m05l02) (lesson 5.2, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can turn expected and unexpected failures into consistent problem details without leaking implementation data.

In the lesson: Register problem details before building the host, then put the exception handler early in the pipeline. The handler catches failures from later middleware and endpoints, while status code pages can supply a problem response when an endpoint returns an error without a body. In production, pair this with structured logging and a correlation identifier. The built in handler gives a consistent transport shape, but your application still decides which failures are expected and which details are safe to expose.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m05l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
