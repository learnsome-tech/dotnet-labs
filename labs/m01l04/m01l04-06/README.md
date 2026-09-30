# m01l04-06 · The LINQ operators you will actually use

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: These three methods carry most of the query work in a real service. Where narrows a sequence, order by sorts it, and select projects each element into something else - here, from a product to its name. To list is the operator that finally does the work and materialises a real list, which is also why it sits at the return type boundary of the method. Then the pair worth memorising: first throws when nothing matches, while first or default hands back null, or the zero of a value type. Choose between them by asking whether a missing row is a bug or an ordinary outcome. Query syntax with from and where keywords exists and compiles to these same calls; method syntax composes better, so this course stays with it.

## Files

- [`starter/Queries.cs`](starter/Queries.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Queries.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–7: Where narrows a sequence
   - Lines 8–10: first throws when nothing matches
   - Lines 11–14: first or default
3. Notes from the lesson:
   - Line 3: IReadOnlyList<T> is the honest return type for a service
   - Line 7: ToList is the moment the sequence is really walked
   - Line 10: First throws InvalidOperationException when nothing matches
   - Line 12: Product? - here a missing row is an ordinary answer, not a bug

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l04-06` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
