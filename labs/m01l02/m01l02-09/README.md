# m01l02-09 · Strings: immutable, interpolated, raw, and built

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: Strings in C Sharp are immutable, so every method that looks as though it edits one returns a new one and leaves the original alone. Upper casing the sku does not change the sku. A dollar sign in front of a literal makes it interpolated: braces hold expressions, and the compiler builds an efficient concatenation. Three double quotes open a raw string literal, the cure for escaping a blob of J S O N by hand; the indentation of the closing delimiter is stripped from every line. And because a loop would allocate a fresh string on every pass, that is the job a string builder exists to do.

## Files

- [`starter/Text.cs`](starter/Text.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l02/m01l02-09/starter`
2. Read `Text.cs` the way the lesson builds it:
   - Lines 1–5: Upper casing the sku
   - Lines 6–10: Three double quotes
   - Lines 11–14: a string builder
3. Notes from the lesson:
   - Line 4: ToUpperInvariant hands back a new string; sku is untouched
   - Line 7: Raw literal: inner quotes need no escaping at all
   - Line 13: Append writes into one buffer instead of 3 throwaway strings
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l02-09`.

## Expected output

```text
wid-7 -> WID-7
{ "sku": "wid-7", "price": 19.90 }
1;2;3;
```

## How to check

`./check m01l02-09` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
