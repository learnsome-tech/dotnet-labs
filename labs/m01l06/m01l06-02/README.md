# m01l06-02 · A record: equality, printing and copying, generated

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: The record declaration sits at the bottom of this file, because top level statements have to come before any type. One line names a product with an identifier and a name, and the compiler writes the constructor, two read-only properties, value equality and a printable form. Build two kettles with the same values and the equality operator answers true, because a record compares its members, not the addresses they sit at. The reference check answers false: still two separate objects. The with expression copies a record and changes only the member you name, leaving the original alone. Run it and look at the last line, where the generated To String hands you the type name and every member.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l06/m01l06-02/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1–3: Build two kettles
   - Lines 4–8: The with expression
   - Lines 9–10: Run it
3. Notes from the lesson:
   - Line 3: with copies the record and changes only the member you name
   - Line 6: == compares members, so two equal kettles are equal
   - Line 10: One line: constructor, properties, equality, and a printable form
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l06-02`.

## Expected output

```text
Product { Id = 1, Name = Kettle }
True
False
Product { Id = 1, Name = Teapot }
```

## How to check

`./check m01l06-02` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
