# m01l06-04 · Patterns: type, property, relational, logical, list

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: A pattern asks about the shape of a value. The type pattern is the one you meet first: it tests the type and names the result in the same breath, so there is no cast on the next line. A property pattern reaches inside and tests a member, and relational patterns for greater than and less than can be joined with and, with or, and with not. List patterns match a sequence position by position, and two dots stand for any run of elements you do not care about. Watch the output: each answer is a plain boolean, so a pattern slots in anywhere a condition already goes.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l06/m01l06-04/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1–3: The type pattern is the one you meet first
   - Lines 4–7: A property pattern reaches inside
   - Lines 8–13: List patterns match a sequence
3. Notes from the lesson:
   - Line 2: Tests the type and names the result: no cast on the following line
   - Line 6: A property pattern, with two relational patterns joined by and
   - Line 10: Two dots is a slice: any run of elements, matched and ignored
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l06-04`.

## Expected output

```text
the type pattern unboxed: 42
True
True
True
1
```

## How to check

`./check m01l06-04` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
