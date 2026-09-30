# m01l02-10 · The switch statement and the switch expression

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: Flow control will feel familiar, with one addition worth meeting early. The top method is the switch statement you know from other languages: labelled cases, and a return out of each one. The bottom method is the switch expression, where the switch itself produces a value that you assign or return. Notice what disappeared: no break keyword to forget, and no braces around each arm. The compiler warns when the arms do not cover every possible input, which is why the underscore arm sits at the end as the catch all. Matching on type and on the parts of an object is pattern matching, which has its own lesson later in this module.

## Files

- [`starter/Bands.cs`](starter/Bands.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Bands.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–11: The top method
   - Lines 12–19: The bottom method
3. Notes from the lesson:
   - Line 13: One expression, one value: assign it or return it directly
   - Line 17: _ is the catch-all arm; leave it out and CS8509 warns you

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l02-10` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
