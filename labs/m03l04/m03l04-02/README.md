# m03l04-02 · Identical route contracts, two declarations

**Lesson:** [Comparing Controllers and Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l04) (lesson 3.4, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can choose between controllers and minimal APIs by comparing the same runnable route surface rather than relying on taste.

In the lesson: Read the URL templates first. Both declarations serve get product by identifier, with the same integer constraint and the same response contract. The controller places the route on an action inside a class. The minimal version places the route on a group beside its delegate. The service call can be shared between them, so the comparison isolates the transport shape. This is the useful kind of debate: keep the route, request, response, and tests fixed, then compare readability, metadata, filters, and the number of files a change touches.

## Files

- [`starter/RouteComparison.cs`](starter/RouteComparison.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/RouteComparison.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m03l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
