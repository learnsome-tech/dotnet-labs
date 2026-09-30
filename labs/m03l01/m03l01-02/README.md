# m03l01-02 · A pipeline with visible boundaries

**Lesson:** [The ASP.NET Core Middleware Pipeline](https://learnsome.tech/learn/dotnet-course/m03l01) (lesson 3.1, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can describe request flow and place middleware in the order that makes authentication, errors, and endpoints behave correctly.

In the lesson: Read this pipeline from top to bottom. The exception handler is first so it can catch failures from every later component. HTTPS redirection runs before application work. Authentication turns a credential into a user, and authorization then checks whether that user may continue. The controller mapping comes last because it is the destination. The same ordering applies when the destination is a minimal API route. Add a component only after you can state what it must see from the components before it and what it promises to the components after it.

## Files

- [`starter/Pipeline.cs`](starter/Pipeline.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Pipeline.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m03l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
