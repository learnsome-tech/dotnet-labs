# m03l03-02 · The same product route as a minimal endpoint

**Lesson:** [Building Routes with Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l03) (lesson 3.3, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can build the catalog route surface with minimal APIs, typed binding, endpoint metadata, and explicit results.

In the lesson: The extension method creates a group for the product prefix, then maps the identifier route inside it. The handler receives the route identifier and the service from dependency injection. Its property pattern produces the same two results as the controller: an ok payload for a product and not found when the service returns nothing. The route constraint remains visible in the URL template. A group is a useful boundary for shared metadata, and the extension method keeps endpoint registration out of the top level program file.

## Files

- [`starter/ProductEndpoints.cs`](starter/ProductEndpoints.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductEndpoints.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m03l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
