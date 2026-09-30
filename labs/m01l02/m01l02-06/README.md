# m01l02-06 · Why money is never a double

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: This is the whole argument for that last bullet, in five lines of output. Add a tenth to two tenths as doubles and print the result: a long tail of digits ending in a four, because neither operand can be written exactly in binary. The same sum in decimal prints the way you would write it on paper. Then the equality checks: the double sum is not equal to three tenths, while the decimal sum is. Look at the last line too. Nineteen point nine multiplied by three keeps its cents, because a decimal remembers the scale you gave it.

## Files

- [`starter/Money.cs`](starter/Money.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l02/m01l02-06/starter`
2. Read `Money.cs` the way the lesson builds it:
   - Lines 1–2: as doubles
   - Lines 3–7: the equality checks
   - Lines 8–10: the last line too
3. Notes from the lesson:
   - Line 1: Neither tenth has an exact binary form: the error is in the literal
   - Line 9: 19.90m keeps scale 2, so 19.90m * 3 prints 59.70, not 59.7
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l02-06`.

## Expected output

```text
0.30000000000000004
0.3
False
True
59.70
```

## How to check

`./check m01l02-06` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
