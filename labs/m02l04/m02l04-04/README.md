# m02l04-04 · Constructor injection keeps dependencies visible

**Lesson:** [The Dependency Injection Container: Scopes and Lifetimes](https://learnsome.tech/learn/dotnet-course/m02l04) (lesson 2.4, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can register services with the built in container and choose transient, scoped, or singleton lifetime without leaking state across requests.

In the lesson: The endpoint declares its two dependencies beside its type name, so a reader can see the contract without opening another file. The method asks the reader for an order and turns the result into an HTTP response. The clock is not used in this small slice, but the constructor still makes the planned dependency visible and testable. In a real implementation remove unused dependencies rather than keeping them for convenience. Constructor injection also gives a unit test a simple seam: provide a substitute reader and a fixed clock, then exercise the endpoint without starting a server.

## Files

- [`starter/OrderEndpoint.cs`](starter/OrderEndpoint.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/OrderEndpoint.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: declares
   - Lines 2–4: asks the reader
   - Lines 5–8: HTTP response

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l04-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
