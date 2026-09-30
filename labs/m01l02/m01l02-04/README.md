# m01l02-04 · Proving copy semantics with a struct and a class

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: Rather than take my word for it, let us make the difference print. Take the struct first: create one, assign it to a second name, then change the second one. Below it, the same three moves against a class holding the same field. The output tells the whole story. The struct copy leaves the original at ten while the copy moved to ninety nine. The class pair both read ninety nine, because there was only ever one object with two names pointing at it. The two declarations at the bottom differ by a single keyword.

## Files

- [`starter/Copies.cs`](starter/Copies.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l02/m01l02-04/starter`
2. Read `Copies.cs` the way the lesson builds it:
   - Lines 1–4: the struct first
   - Lines 5–9: the same three moves
   - Lines 10–12: the two declarations at the bottom
3. Notes from the lesson:
   - Line 3: b is an independent copy; this line cannot reach a
   - Line 12: class: x and y are two names for one object on the heap
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l02-04`.

## Expected output

```text
struct Size:  a is 10, b is 99
class Box:    x is 99, y is 99
```

## How to check

`./check m01l02-04` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
