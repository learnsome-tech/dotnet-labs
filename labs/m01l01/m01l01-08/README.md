# m01l01-08 · Top level statements in Program.cs

**Lesson:** [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) (lesson 1.1, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

In the lesson: Open the file the template wrote and there is no class and no main method in sight. That is top level statements: in the single file that starts a program, C Sharp lets you write statements at the top level and generates the class and the entry point behind your back. It is ordinary C Sharp, not a scripting mode - you can declare variables, call methods and use await right here. Watch the third line of output. The variable holding a boolean prints with a capital letter, because that is the type's own text form, not the lower case spelling some other languages use. The first hint that you are working with a typed runtime. Let us run it and read the panel.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l01/m01l01-08/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1–2: no main method in sight
   - Lines 3–5: declare variables
   - Lines 6–7: Watch the third line of output
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m01l01-08`.

## Expected output

```text
Hello, World!
Target framework: net10.0
Long term support: True
```

## How to check

`./check m01l01-08` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
