# m07l02-02 · A route test through the host

**Lesson:** [Integration Testing with WebApplicationFactory](https://learnsome.tech/learn/dotnet-course/m07l02) (lesson 7.2, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can test routing, serialization, and middleware through an in memory ASP.NET Core host.

In the lesson: The factory starts the application and creates an HTTP client. The test sends the same URL a real caller sends and asserts the not found status. Add a test service replacement when the database would make the result nondeterministic, and seed data when the database behavior itself is the subject. Because the request crosses the full host boundary, this test catches route, serializer, and middleware mistakes that a direct service call cannot see.

## Files

- [`starter/ProductApiTests.cs`](starter/ProductApiTests.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductApiTests.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
