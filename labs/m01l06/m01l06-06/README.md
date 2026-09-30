# m01l06-06 · Exhaustiveness: a warning that is doing you a favour

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Read along

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: Leave a case out and the compiler tells you. This expression covers two of the three statuses, so the build reports that the switch expression is not exhaustive and names the value that no arm handles. Treat that warning as the feature it is. The interesting moment comes months later, when somebody adds a fourth member to the enum: every switch expression that was not updated lights up in the build output, and you are handed the list of places to go and think. A discard arm would silence all of it, which is why you leave it off when the set of values is closed. If an unhandled value does arrive at run time, the call throws a switch expression exception rather than returning something quietly wrong.

## Files

- [`starter/Shipping.cs`](starter/Shipping.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Shipping.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: This expression covers
   - Lines 4–13: not exhaustive
   - Lines 14: Treat that warning
3. Notes from the lesson:
   - Line 9: No arm for Delivered, so the build warns before a user finds out
   - Line 13: No discard arm on purpose: silence here would be the bug

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l06-06` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
