# m01l03-04 · Interfaces: the contract the container resolves

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: An interface is a promise with no state behind it: method signatures, property signatures, and nothing holding a value. The leading capital I is a convention the whole dot net ecosystem keeps, and readers scan for it, so keep it too. Why does the framework resolve interfaces rather than classes? Because the registration is the seam. Module two asks the container for a product repository and gets whichever implementation was registered - a database backed one in production, a fake one in a test - while the service depending on it never changes a character. The exists method is a default interface member: a body on the interface itself, inherited by every implementer. Use it to widen a published contract without breaking the classes that already implement it.

## Files

- [`starter/IProductRepository.cs`](starter/IProductRepository.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/IProductRepository.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: no state behind it
   - Lines 4–8: a default interface member
   - Lines 9–11: without breaking the classes
3. Notes from the lesson:
   - Line 1: The leading I is convention, not syntax - follow it anyway
   - Line 3: Signatures only: an interface can hold no fields
   - Line 7: Default interface member: a body every implementer inherits
   - Line 11: Depend on the interface; name the implementation once

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l03-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
