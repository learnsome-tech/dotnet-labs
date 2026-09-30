# m01l05-06 · Exceptions Travel Across An await

**Lesson:** [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) (lesson 1.5, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

In the lesson: Error handling is where asynchronous code either earns your trust or loses it, and C Sharp gets this right. When a method throws after its first await, the exception does not vanish into a background thread; it faults the task, and the task carries it until somebody awaits. At that moment it is rethrown at the await, with its original stack trace preserved, so an ordinary try and catch wrapped around the await behaves the way you would hope. Task WhenAll is the one case worth reading twice. Both of these methods fail, yet awaiting the combined task rethrows only the first exception. When you need the others, the aggregate exception hanging off the task still holds every failure, and that last line counts them.

## Files

- [`starter/Faults.cs`](starter/Faults.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l05/m01l05-06/starter`
2. Read `Faults.cs` the way the lesson builds it:
   - Lines 1–5: When a method throws
   - Lines 6–12: an ordinary try and catch
   - Lines 13–18: Task WhenAll is the one case
3. Notes from the lesson:
   - Line 4: The throw happens after an await, so it faults the task instead
   - Line 11: await rethrows the first exception, stack trace preserved
   - Line 18: The aggregate on the task still holds every failure
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l05-06`.

## Expected output

```text
await threw: first failed
faults held: 2
```

## How to check

`./check m01l05-06` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
