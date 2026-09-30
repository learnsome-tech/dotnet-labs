# m01l03-03 · Constructors, and constructor injection

**Lesson:** [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) (lesson 1.3, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

In the lesson: A constructor is where a class insists on what it needs before it exists. C Sharp lets you write those parameters straight after the class name - the primary constructor - and each is then in scope for the whole body, with no field to declare and no assignment to write. Notice what the service asks for: not a database, not a static factory, not a connection string, but an interface it can call. Whoever constructs the service supplies one, and that is constructor injection. The container reads this constructor, resolves each parameter and hands back a finished object. Compare the two types on screen: identical behaviour, and the older one spends four extra lines saying so. Module four rebuilds this pair against a real database.

## Files

- [`starter/ProductService.cs`](starter/ProductService.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductService.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: the primary constructor
   - Lines 2–11: Notice what the service asks for
   - Lines 12–20: Compare the two types on screen
3. Notes from the lesson:
   - Line 1: Primary constructor: the parameter is in scope for the whole body
   - Line 3: No field, no assignment - it is used where it is needed
   - Line 14: Identical behaviour, four extra lines of ceremony

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l03-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
