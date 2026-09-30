# m01l04-05 · Deferred execution: nothing runs until you ask

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: This is the most surprising thing about LINQ, so watch the order of the printed lines. The where call filters nothing. It returns an object that remembers the source and the predicate, and that is all it does. The message about the query being built therefore appears first, before a single element has been tested. Only when the foreach loop starts pulling does the predicate run, and it runs one element at a time, interleaved with the loop body rather than in a batch before it. Seven and ninety five are tested at the moment the loop asks for them. Deferred execution is why you can compose a query in one method and decide where it runs in another.

## Files

- [`starter/Deferred.cs`](starter/Deferred.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l04/m01l04-05/starter`
2. Read `Deferred.cs` the way the lesson builds it:
   - Lines 1–7: The where call
   - Lines 8–9: appears first
   - Lines 10–14: the foreach loop
3. Notes from the lesson:
   - Line 3: Where returns an iterator object; the lambda has not run yet
   - Line 5: This print is the proof: it fires per element, during the loop
   - Line 11: Enumeration is the trigger - here, the foreach
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l04-05`.

## Expected output

```text
query built
testing 12
kept 12
testing 40
kept 40
testing 7
testing 95
kept 95
```

## How to check

`./check m01l04-05` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
