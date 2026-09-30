# m02l05-07 · A bad setting, seen at start up instead of at teatime

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: Let us break it on purpose. The code does not change and the registration is unchanged; one number out of range goes into the configuration file, a maximum page size of five thousand where the range stops at two hundred. Run it and read the message. The exception type is options validation exception, and its text names the options class, then the member that failed, then the error the attribute produced, which here is the range message word for word. In a terminal that is a single line, wrapped across three here so it fits. Two things matter. The host never finished starting, so the endpoint below is mapped but never served, and nothing ever accepted a request. And the message names the setting, so you fix it without a debugger.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–5: one number out of range
   - Lines 6–9: the registration is unchanged
   - Lines 10–13: mapped but never served
3. Notes from the lesson:
   - Line 5: The only edit: a maximum page size of 5000 against a range of 1 to 200
   - Line 9: This is the line that decides where the failure happens
   - Line 12: Mapped, yes, but the process exits before the server accepts anything

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m02l05-07` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
