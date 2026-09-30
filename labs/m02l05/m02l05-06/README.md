# m02l05-06 · IOptions, IOptionsSnapshot, IOptionsMonitor

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: Three interfaces hand you the same class, and choosing between them is the part people get wrong. The plain options interface is resolved once, as a singleton, and the value it holds never changes for the life of the process. The snapshot interface is registered scoped, recomputed once per scope, which in a web application means once per request, so an edited file shows up on the next request. The monitor interface is a singleton you may hold anywhere: its current value is read each time you ask for it, and its change callback runs when a provider reloads. Here is the trap. Take the plain options interface into a singleton, edit the file, and nothing happens, ever, and the reload gets the blame. Going the other way, scope validation catches a snapshot pulled into a singleton.

## Files

- [`starter/OptionsConsumers.cs`](starter/OptionsConsumers.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/OptionsConsumers.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–7: The plain options interface
   - Lines 8–14: The snapshot interface
   - Lines 15–22: The monitor interface
3. Notes from the lesson:
   - Line 4: One value for the life of the process: the right default for most code
   - Line 10: Scoped: a snapshot dragged into a singleton is what scope validation stops
   - Line 16: CurrentValue is read on every call; OnChange fires when a provider reloads

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-06` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
