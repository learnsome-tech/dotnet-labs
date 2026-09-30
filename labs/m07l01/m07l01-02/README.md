# m07l01-02 · A service test with a substitute

**Lesson:** [Unit Testing with xUnit and NSubstitute](https://learnsome.tech/learn/dotnet-course/m07l01) (lesson 7.1, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can isolate an application service with a substitute and write a focused xUnit test.

In the lesson: The test arranges a repository that cannot find product seven, calls the service, and asserts a null result. The substitute stands in for persistence, so the test exercises the service decision rather than Entity Framework. Add a received assertion when the collaboration itself is part of the contract, but avoid checking every incidental call. A useful unit test survives harmless refactoring while failing when the business behavior changes.

## Files

- [`starter/ProductServiceTests.cs`](starter/ProductServiceTests.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductServiceTests.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
