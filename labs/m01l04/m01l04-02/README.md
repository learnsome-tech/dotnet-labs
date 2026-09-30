# m01l04-02 · Generic methods and the constraint clauses

**Lesson:** [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) (lesson 1.4, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

In the lesson: Read the repeat method first. It takes a value of type T and hands back an array of T, and nothing in its body needs to know what T actually is. Compare that with the same idea written against an object parameter: the caller would get an object array and have to cast every element out of it, and one wrong cast fails at run time instead of at compile time. The interface below it adds two constraint clauses. Requiring the key to be notnull rules out a null key in a lookup table, and requiring the item to be a class is what lets the get method hand back a nullable reference.

## Files

- [`starter/Pricing.cs`](starter/Pricing.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Pricing.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–10: the repeat method
   - Lines 11–14: two constraint clauses
   - Lines 15–18: the get method
3. Notes from the lesson:
   - Line 4: T is chosen by the caller: no cast, no boxing, no object
   - Line 13: notnull: no null key, and no nullable value type either
   - Line 16: TItem : class is what permits the nullable return type

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
