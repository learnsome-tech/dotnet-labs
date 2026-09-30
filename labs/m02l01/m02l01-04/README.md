# m02l01-04 · Create a solution and inspect it

**Lesson:** [Solutions, Projects, and Target Frameworks](https://learnsome.tech/learn/dotnet-course/m02l01) (lesson 2.1, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Runs, not graded

## Goal

You can explain what a solution and project contain, choose a target framework, and read the important parts of a project file.

In the lesson: This tiny program makes the framework visible. The first line is our application label. The second asks the runtime which assembly owns the string type, and the answer is the base runtime library. On a machine with the kit, create a solution, create a web project, and add that project to the solution. Then build the solution and inspect the project file. The commands are ordinary dot net new, dot net sln, and dot net build commands; the important habit is to inspect what the templates created before adding more code.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m02l01/m02l01-04/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1: application label
   - Lines 2: assembly
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m02l01-04`.

## What the lesson recorded

Shown for reference; the check does not compare it.

```text
Catalog API
System.Runtime
```

## How to check

`./check m02l01-04` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It runs without a pass or fail: what the listing prints in the lab sandbox differs from the output recorded for the lesson (it depends on the machine, the clock or the network), so the site runs it without a pass or fail. `./check` shows the output and the exit code.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
