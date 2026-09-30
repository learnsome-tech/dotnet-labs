# m02l03-03 · A diagnostic is feedback from the build

**Lesson:** [Code Quality: .editorconfig and Roslyn Analyzers](https://learnsome.tech/learn/dotnet-course/m02l03) (lesson 2.3, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Runs, not graded

## Goal

You can configure formatting and analyzer severity in the repository, then fix the diagnostics that protect an API from avoidable defects.

In the lesson: Imagine the analyzer looking at this two line program. It opens a resource and then lets the scope end without an explicit disposal pattern that the configured rule understands. The build reports a diagnostic with a rule identifier and a short explanation. Read the identifier first, because it takes you to the rule documentation and tells the team why the warning exists. Then fix the lifetime, rather than suppressing the message. A suppression is a debt marker and should include a reason and a narrow scope when a third party API makes the warning unavoidable.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m02l03/m02l03-03/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1: opens a resource
   - Lines 2: build reports
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m02l03-03`.

## What the lesson recorded

Shown for reference; the check does not compare it.

```text
warning CA2000: Dispose objects before losing scope
```

## How to check

`./check m02l03-03` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It runs without a pass or fail: what the listing prints in the lab sandbox differs from the output recorded for the lesson (it depends on the machine, the clock or the network), so the site runs it without a pass or fail. `./check` shows the output and the exit code.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
