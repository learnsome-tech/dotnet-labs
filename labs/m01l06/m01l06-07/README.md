# m01l06-07 · Four pieces of modern syntax, one small class

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Read along

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: Four small pieces of syntax in one file, and then the language is done with us. The namespace ends in a semicolon and applies to the whole file, which saves a pair of braces and a level of indentation everywhere you look. The empty pair of square brackets is a collection expression, and the target type decides what it becomes: a list, an array or a span. The word new with empty parentheses is target typed, because the field has already said what it is. The name of operator turns a symbol into its own text, so renaming the parameter renames the string with it. The last one assigns only when the left side is null.

## Files

- [`starter/Cart.cs`](starter/Cart.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Cart.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–7: The namespace ends in a semicolon
   - Lines 8–11: The name of operator
   - Lines 12–16: assigns only when the left side is null
3. Notes from the lesson:
   - Line 1: File-scoped namespace: the whole file, no brace, no extra indent
   - Line 5: An empty collection expression; the target type picks the type
   - Line 6: Target-typed new: the field on the left already said what it is
   - Line 12: ??= writes the value only if what is there now is null

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l06-07` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
