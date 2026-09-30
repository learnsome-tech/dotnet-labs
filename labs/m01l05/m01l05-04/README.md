# m01l05-04 · Three Ways To Get This Wrong

**Lesson:** [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) (lesson 1.5, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Read along

## Goal

Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

In the lesson: Three mistakes account for nearly every asynchronous bug worth debugging, and here they are in one file. First, the blocking call: reading dot Result, or calling Wait on a task. On a pool thread that takes a second thread hostage while the first one sits there, and under load the pool starves; in older frameworks with a synchronization context it deadlocks outright. Second, async void. A method returning nothing gives its caller no task at all, so an exception inside it has nowhere to surface and it tears down the process instead of reaching your handler. The only defensible use is an event handler. Third, awaiting one at a time over work where no call depends on the answer before it. Three fetches of forty milliseconds ought to cost forty milliseconds; written like this they cost a hundred and twenty.

## Files

- [`starter/Mistakes.cs`](starter/Mistakes.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Mistakes.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–5: the blocking call
   - Lines 6–9: Second, async void
   - Lines 10–20: one at a time
3. Notes from the lesson:
   - Line 5: Result blocks the caller and can deadlock outright
   - Line 8: async void: the throw lands on the pool and takes the process
   - Line 16: These fetches are independent, so serial awaits waste the wait

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l05-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
