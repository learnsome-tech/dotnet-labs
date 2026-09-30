# m01l05-05 · Sequential Awaits Versus Task.WhenAll

**Lesson:** [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) (lesson 1.5, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

In the lesson: Numbers argue this better than words do. The delay stands in for a network call costing one second, and the program does three of them, twice over. The first loop awaits one after another, so each call begins only once the previous call has come back, and the stopwatch reads three seconds. The second version invokes the method three times up front, keeps the tasks, and then awaits Task WhenAll across all of them; those tasks were already started before anything was awaited, so the waiting overlaps and identical work reads one second. The printed figures are rounded to whole seconds deliberately - this shows a shape, not a benchmark. Run it and watch the two lines land a long way apart.

## Files

- [`starter/Timing.cs`](starter/Timing.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l05/m01l05-05/starter`
2. Read `Timing.cs` the way the lesson builds it:
   - Lines 1–7: The delay stands in
   - Lines 8–12: The first loop
   - Lines 13–16: The second version
3. Notes from the lesson:
   - Line 11: Each call starts only once the previous one finished: three waits
   - Line 15: All three are running before the first await: one wait
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l05-05`.

## Expected output

```text
sequential: 3s
parallel:   1s
```

## How to check

`./check m01l05-05` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
