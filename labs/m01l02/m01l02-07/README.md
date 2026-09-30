# m01l02-07 · Turning nullable reference types on

**Lesson:** [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) (lesson 1.2, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

In the lesson: Before the null discussion, look at where it is switched on. A project file carries a property called Nullable, set to enable, and every template since dot net six has shipped with it already there. With it on, the compiler tracks whether each reference could be absent and tells you when your code assumes otherwise. A plain string means a string that is there; a string with a question mark means one that might not be. Notice the target framework as well: net ten point zero, the current long term support release.

## Files

- [`starter/Pricing.csproj`](starter/Pricing.csproj): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Pricing.csproj` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: A project file
   - Lines 2–8: a property called Nullable
   - Lines 9–10: the target framework as well
3. Notes from the lesson:
   - Line 6: enable turns on null flow analysis for every reference here
   - Line 5: net10.0 is the current LTS: shipped Nov 2025, supported to Nov 2028

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l02-07` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
