# m01l03-06 · Static classes and extension methods

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: Sometimes there is genuinely no object to be had. A helper turning a net amount into a gross one keeps no state, so it belongs on a static class: one that cannot be instantiated and holds only static members. Extension methods are the interesting case. Mark the first parameter with the this keyword and the method can be called as though it belonged to the type it extends, including a type you neither own nor can edit. Add catalog platform is not a method on the service collection interface; it is a static method in your own project, extending it, returning the collection so the next call can chain. Map product endpoints is the same shape over the endpoint builder. Meet a call with no obvious owner, and go looking for a static class with a this parameter.

## Files

- [`starter/CatalogExtensions.cs`](starter/CatalogExtensions.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CatalogExtensions.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: it belongs on a static class
   - Lines 2–9: Mark the first parameter with the this keyword
   - Lines 10–13: Map product endpoints is the same shape
   - Lines 14–17: a call with no obvious owner
3. Notes from the lesson:
   - Line 1: static class: no instances, no state, only static members
   - Line 4: this on the first parameter is the whole trick
   - Line 8: Returning the collection is what lets calls chain
   - Line 16: The shape of every Add and Map call you will meet later

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l03-06` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
