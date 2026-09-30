# m01l04-07 · Aggregates and grouping over one sequence

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: Now the operators that collapse a sequence into a single answer. Any asks whether at least one element passes and stops at the first one that does, so it is the cheap way to ask a yes or no question - never compare a count with zero. Count with a predicate counts the matches. Sum adds a projected value, and because the price is a decimal the total keeps both of its places instead of drifting the way a double would. Group by turns a flat sequence into groups carrying a key, in the order the keys were first seen, which is why kitchen is printed before home. Each group is itself a sequence, so you can count or sum inside it.

## Files

- [`starter/Report.cs`](starter/Report.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l04/m01l04-07/starter`
2. Read `Report.cs` the way the lesson builds it:
   - Lines 1–6: the operators that collapse a sequence
   - Lines 7–10: Count with a predicate
   - Lines 11–13: Group by turns a flat sequence
   - Lines 14–15: Each group is itself a sequence
3. Notes from the lesson:
   - Line 8: Any stops at the first match: never compare a count with zero
   - Line 10: decimal keeps its scale, so the total prints as 42.75
   - Line 12: GroupBy yields IGrouping<TKey, T>: a key plus its own items
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l04-07`.

## Expected output

```text
True
2
42.75
Kitchen has 2
Home has 1
```

## How to check

`./check m01l04-07` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
