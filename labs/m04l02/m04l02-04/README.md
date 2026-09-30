# m04l02-04 · A query returns a projected response

**Lesson:** [Querying, Change Tracking, and Saving Data](https://learnsome.tech/learn/dotnet-course/m04l02) (lesson 4.2, module 4: Data Access And Mapping) · Pro  
**Check:** Runs, not graded

## Goal

You can query efficiently, choose tracking deliberately, and save an update through EF Core.

In the lesson: This standalone example mirrors the shape of an Entity Framework query without requiring a database. The where step keeps names longer than three characters, and select projects each remaining value into uppercase. The query does not execute until the loop asks for its values. In EF Core the same deferred shape becomes SQL when the terminal method runs. Keep filters and projections before that terminal call, and inspect generated SQL when a query is more complex than the code suggests.

## Files

- [`starter/Query.cs`](starter/Query.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m04l02/m04l02-04/starter`
2. Read `Query.cs`.
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m04l02-04`.

## What the lesson recorded

Shown for reference; the check does not compare it.

```text
KETTLE
MUG
```

## How to check

`./check m04l02-04` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It runs without a pass or fail: what the listing prints in the lab sandbox differs from the output recorded for the lesson (it depends on the machine, the clock or the network), so the site runs it without a pass or fail. `./check` shows the output and the exit code.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
