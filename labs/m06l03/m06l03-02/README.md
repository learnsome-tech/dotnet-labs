# m06l03-02 · Register a fixed window limiter

**Lesson:** [Built-in Rate Limiting Middleware](https://learnsome.tech/learn/dotnet-course/m06l03) (lesson 6.3, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can define a partitioned rate limit and return a useful response when a client exceeds it.

In the lesson: This policy permits one hundred requests in a one minute window. The middleware is registered after the services and added to the pipeline before endpoints that opt into the named policy. Choose limits from measured capacity, not a guess. A public search route may need a different partition and limit from an administrative write route. Document the policy so clients know how to back off instead of retrying every failure immediately.

## Files

- [`starter/RateLimit.cs`](starter/RateLimit.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/RateLimit.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m06l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
