# m06l05-02 · Configure an HTTP resilience pipeline

**Lesson:** [Retry and Circuit Breaker Policies with Polly](https://learnsome.tech/learn/dotnet-course/m06l05) (lesson 6.5, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can add bounded retries and circuit breaking to outbound HTTP calls without multiplying an outage.

In the lesson: The HTTP client factory creates a typed inventory client and adds the standard resilience handler. Three retries are bounded, and the total request timeout caps the whole operation rather than each attempt stretching forever. In a real service, tune these values from downstream service behavior and measure retry volume. Do not retry a request that may have committed a non idempotent write unless the API contract makes that safe.

## Files

- [`starter/HttpResilience.cs`](starter/HttpResilience.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/HttpResilience.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m06l05-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
