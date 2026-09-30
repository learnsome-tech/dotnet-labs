# m01l05-02 · The Shape Of Every Async Method You Will Write

**Lesson:** [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) (lesson 1.5, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Read along

## Goal

Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

In the lesson: Here is the shape you will write a thousand times, so it is worth naming every part of it. The return type is a task of product, which is a promise of a result that is not here yet; the caller can wait on it or hang more work off it. The name ends in Async, which is convention rather than compiler magic, and it earns its keep the moment somebody is reading a call site. And the last parameter is a cancellation token. ASP.NET Core hands you one for every request, taken from the connection itself, and passing it down into Entity Framework Core is how a user who closed the tab stops costing money halfway through a query. Inside the method, each await hands the thread back to the pool and picks one up again when the socket answers.

## Files

- [`starter/CatalogService.cs`](starter/CatalogService.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CatalogService.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: the shape you will write
   - Lines 4–5: The return type
   - Lines 6–9: Inside the method
   - Lines 10–13: the socket answers
3. Notes from the lesson:
   - Line 5: Task<Product?> is a promise of a product, not the product itself
   - Line 5: CancellationToken is the last parameter, by convention
   - Line 7: await returns to the caller; the thread goes back to the pool
   - Line 9: Pass the token down: a cancelled request stops costing money

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l05-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
