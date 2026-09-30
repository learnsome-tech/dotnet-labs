# m01l03-05 · Inheritance, sparingly: virtual and override

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Graded

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: The four statements at the top of this file make an overnight carrier, hold it in a variable typed as the base class, and ask it for a quote. Carrier itself is abstract: it cannot be constructed, and it demands a name from every carrier while handing down a working quote body. Overnight replaces both members. Ground replaces only the name and inherits the quote unchanged. Watch what happens when we run it: the overnight price comes out although the compiler only ever saw a carrier. That is virtual dispatch - the object's real type picks the method. Abstract means there is no body and you must write one. Virtual means there is a body you may replace. Override is how you declare the replacement, and the compiler insists on it. Notice sealed on both derived classes: make that your default mood.

## Files

- [`starter/Dispatch.cs`](starter/Dispatch.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l03/m01l03-05/starter`
2. Read `Dispatch.cs` the way the lesson builds it:
   - Lines 1–4: The four statements at the top
   - Lines 5–10: Carrier itself is abstract
   - Lines 11–16: Overnight replaces both members
   - Lines 17–21: Ground replaces only the name
3. Notes from the lesson:
   - Line 8: abstract: no body here, and every subclass must supply one
   - Line 9: virtual: a real default a subclass may replace
   - Line 15: override is required, and it is what the runtime calls
   - Line 20: Ground keeps the inherited quote: 4.50 + 3
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l03-05`.

## Expected output

```text
Overnight
18.00
7.50
```

## How to check

`./check m01l03-05` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
