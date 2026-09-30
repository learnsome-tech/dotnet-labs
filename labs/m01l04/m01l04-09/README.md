# m01l04-09 · yield return: your own lazy sequence

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: There is no magic behind LINQ; you can write the same laziness yourself. A method that returns an enumerable and contains a yield return is compiled into a state machine, and calling it runs none of the body. Look at where the word entered appears in the output: after the loop has asked for its first element, not when the countdown method was called. Then the break leaves the loop after the second element, and the third one is never produced at all. That is the payoff of a lazy sequence - an expensive or endless source costs you only the elements you actually consume.

## Files

- [`starter/Lazy.cs`](starter/Lazy.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l04/m01l04-09/starter`
2. Read `Lazy.cs` the way the lesson builds it:
   - Lines 1–9: the same laziness yourself
   - Lines 10–16: a yield return
3. Notes from the lesson:
   - Line 3: Calling Countdown does not execute one line of its body
   - Line 6: break stops pulling, so the third element is never produced
   - Line 13: Runs on the first MoveNext, not when the method was called
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l04-09`.

## Expected output

```text
before
entered
3
2
after
```

## How to check

`./check m01l04-09` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
