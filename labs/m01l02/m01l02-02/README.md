# m01l02-02 · Declared, inferred, and still one fixed type

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: On screen are four locals. Two have their type spelled out, and two lean on the var keyword. Print the runtime type of each one and we can settle the question everybody asks first. The var keyword is not a dynamic box, and not the any type TypeScript hands out. It asks the compiler for the single type the initialiser already has, then fixes it there for good. Run it: the inferred price reports as a double, and the inferred sku as a string. The last line is kept as a comment, because assigning a number there would not compile.

## Files

- [`starter/Types.cs`](starter/Types.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l02/m01l02-02/starter`
2. Read `Types.cs` the way the lesson builds it:
   - Lines 1–4: four locals
   - Lines 5–9: the runtime type of each
   - Lines 10–11: kept as a comment
3. Notes from the lesson:
   - Line 3: unitPrice is a double from here to the end of the method
   - Line 11: sku = 7 is rejected: the inferred type is part of the variable
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l02-02`.

## Expected output

```text
System.Int32
System.Int64
System.Double
System.String
```

## How to check

`./check m01l02-02` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
