# m01l02-11 · Loops, and early return as the house style

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: Three loops and one guard cover most of the flow control an API ever needs. The for loop is the one that counts, so keep it for the cases where the index matters. The foreach loop asks the collection for its enumerator and hands you one item at a time. The while loop repeats for as long as its condition holds. Then the price method: notice it answers the awkward cases first and returns immediately, rather than wrapping the real work in a long else branch. That is the house style here, because the happy path stays at the left margin.

## Files

- [`starter/Flow.cs`](starter/Flow.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l02/m01l02-11/starter`
2. Read `Flow.cs` the way the lesson builds it:
   - Lines 1–3: The for loop
   - Lines 4–5: The foreach loop
   - Lines 6–7: The while loop
   - Lines 8–16: the price method
3. Notes from the lesson:
   - Line 1: [3, 0, 1] is a collection expression; int[] supplies the type
   - Line 14: Guard, then return: the real work stays at the left margin
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l02-11`.

## Expected output

```text
3;0;1;
total 4, left 0
price of wid-7
unknown
```

## How to check

`./check m01l02-11` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
