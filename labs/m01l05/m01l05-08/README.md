# m01l05-08 · Streaming Results With IAsyncEnumerable

**Lesson:** [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) (lesson 1.5, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

In the lesson: Sometimes the answer is not one value but a stream of them arriving over time: rows from a cursor, chunks from an upstream service, events off a queue. A task of a list cannot express that, because a task completes once and carries one result. The asynchronous enumerable interface can: it is a sequence produced over time, consumed with await foreach, which awaits between items instead of once at the end. In a web API this is how you return ten thousand rows without first buffering ten thousand rows in memory, and Entity Framework Core exposes it through the as async enumerable method. Each item here reaches the consumer as soon as it exists, which is why the three lines appear one after the other rather than together.

## Files

- [`starter/Streaming.cs`](starter/Streaming.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l05/m01l05-08/starter`
2. Read `Streaming.cs` the way the lesson builds it:
   - Lines 1–9: a sequence produced over time
   - Lines 10–14: Each item here
3. Notes from the lesson:
   - Line 1: async plus yield return: a sequence that arrives piece by piece
   - Line 7: The item leaves the producer the instant it exists
   - Line 11: await foreach awaits between items, not once at the end
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l05-08`.

## Expected output

```text
received alpha
received beta
received gamma
```

## How to check

`./check m01l05-08` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
