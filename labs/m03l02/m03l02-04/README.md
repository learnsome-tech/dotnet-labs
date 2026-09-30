# m03l02-04 · The controller host serves a request

**Lesson:** [Building Routes with Controllers](https://learnsome.tech/learn/dotnet-course/m03l02) (lesson 3.2, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can build a controller route with binding, validation, and explicit HTTP results.

In the lesson: A controller action can be tiny when its contract is simple. This ping action returns an ok result containing the catalog label. Against a running host, a client sees an HTTP success status and the response text. The web host is long lived, so this panel is a transcript. In the real lesson project, use an integration test to send the request and assert both the status and the body. That proves routing and serialization together, rather than trusting a method call that bypasses the framework.

## Files

- [`starter/ProductsController.cs`](starter/ProductsController.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductsController.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m03l02-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
