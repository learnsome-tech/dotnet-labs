# m01l03-07 · IDisposable and the using declaration

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: A class owning something the garbage collector knows nothing about - a file handle, a socket, a database connection - implements IDisposable so a caller can say when it is finished with it. The using declaration on the second line is the modern form: no braces, no extra nesting, and the compiler inserts the dispose call at the end of the enclosing scope, even when an exception is unwinding it. Read that output carefully. Saving happens where you wrote it, while disposing happens after the last statement, not where the object was made. That is why the framework's database context is disposable: it owns a connection and a change tracker. Module two finishes the story: the container disposes everything it created when the scope ends, and a web request is a scope.

## Files

- [`starter/Lifetime.cs`](starter/Lifetime.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l03/m01l03-07/starter`
2. Read `Lifetime.cs` the way the lesson builds it:
   - Lines 1–4: The using declaration on the second line
   - Lines 5–11: the framework's database context is disposable
3. Notes from the lesson:
   - Line 2: using declaration: Dispose fires at the end of this scope
   - Line 6: Implementing IDisposable is a promise to release something
   - Line 10: Runs last, after the final statement - not where it was made
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l03-07`.

## Expected output

```text
work starting
saving orders
work finished
disposing orders
```

## How to check

`./check m01l03-07` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
