# m05l04-03 · Scalar opens the API contract

**Lesson:** [API Documentation UI with Scalar](https://learnsome.tech/learn/dotnet-course/m05l04) (lesson 5.4, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can add Scalar as a documentation UI over the built in OpenAPI document.

In the lesson: A browser or client requests the Scalar route and receives a successful response when the documentation host is running. This is a web transcript because the server remains alive. From the UI, a learner can inspect the same schemas and responses that the OpenAPI document describes, then send a request with the chosen credentials. The request still travels through the application's normal pipeline, so the UI is a tool for the contract rather than a shortcut around security.

## Files

- [`starter/ScalarRequest.cs`](starter/ScalarRequest.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ScalarRequest.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m05l04-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
