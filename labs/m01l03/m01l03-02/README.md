# m01l03-02 · Properties instead of public fields

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: A property looks like a field from outside and behaves like a pair of methods inside, and that difference is the whole reason for the convention. Model binding, validation, serialisation, change tracking in Entity Framework Core and the debugger all discover properties by reflection and ignore public fields, so a public field quietly opts your type out of the platform. The name here is marked required, so the compiler refuses to let anyone construct a product without supplying one. The identifier uses init rather than set: an object initialiser assigns it once and nothing changes it afterwards. Units keeps a private setter, and in stock is computed on demand, with no stored value behind it at all.

## Files

- [`starter/Product.cs`](starter/Product.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Product.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–4: marked required
   - Lines 5–6: private setter
   - Lines 7–8: computed on demand
   - Lines 9–11: no stored value behind it
3. Notes from the lesson:
   - Line 3: required: no Product can be constructed without a Name
   - Line 5: init: assignable in an initialiser, immutable ever after
   - Line 6: private set: Receive is the only road into Units
   - Line 8: Expression-bodied property: derived, never stored

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
