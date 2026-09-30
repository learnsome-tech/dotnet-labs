# m04l02-02 · A read query and a tracked update

**Lesson:** [Querying, Change Tracking, and Saving Data](https://learnsome.tech/learn/dotnet-course/m04l02) (lesson 4.2, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can query efficiently, choose tracking deliberately, and save an update through EF Core.

In the lesson: The first query is read only. No tracking tells the context not to retain a snapshot, and projection creates the response directly from the selected columns. The second query intentionally tracks an entity because the next line changes its price. Save changes compares that tracked state with the original snapshot and sends an update for the modified property. Keep the two intentions visible in code. A tracked query for a large list wastes memory, while an untracked entity cannot be updated by directly changing a property and saving.

## Files

- [`starter/ProductQueries.cs`](starter/ProductQueries.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductQueries.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
