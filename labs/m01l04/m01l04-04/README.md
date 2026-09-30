# m01l04-04 · Building the four with square bracket initialisers

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: Notice the square brackets. A collection expression is the modern initialiser: one literal shape builds an array, a list or a hash set, and the compiler picks the cheapest way to fill whichever target type you declared. The dictionary uses indexer syntax for its entries, which reads better than a pile of add calls. Then the two dots spread the tags array into a set, which is where the duplicate quietly disappears. Run it and read the six printed lines in order: a count, an element by index, a decimal that keeps both of its places, a missing key answering False, then a set that collapsed three tags into two.

## Files

- [`starter/Catalog.cs`](starter/Catalog.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l04/m01l04-04/starter`
2. Read `Catalog.cs` the way the lesson builds it:
   - Lines 1–2: square brackets
   - Lines 3–7: indexer syntax
   - Lines 8: the two dots
   - Lines 9–15: Run it
3. Notes from the lesson:
   - Line 2: [ ... ] targets the declared type: no new List<string>() needed
   - Line 5: Indexer syntax per entry, nicer than a pile of Add calls
   - Line 8: Spread: [.. tags] copies the array in and drops the repeat
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l04-04`.

## Expected output

```text
3
Lamp
24.50
False
2
True
```

## How to check

`./check m01l04-04` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
