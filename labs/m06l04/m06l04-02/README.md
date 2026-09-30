# m06l04-02 · Map health endpoints

**Lesson:** [Health Checks](https://learnsome.tech/learn/dotnet-course/m06l04) (lesson 6.4, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can expose liveness and readiness checks without making a failing dependency look like a dead process.

In the lesson: The health check service is registered once, and two routes make the operational distinction visible. The live route can use only process checks. The ready route can add database, cache, or downstream checks through tags and filtering. Keep these routes separate from business authorization only when the platform requires anonymous probes, and restrict their network exposure so they do not become an information endpoint for the world.

## Files

- [`starter/Health.cs`](starter/Health.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Health.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m06l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
