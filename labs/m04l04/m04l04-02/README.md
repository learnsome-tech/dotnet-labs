# m04l04-02 · An explicit response mapping

**Lesson:** [Manual Object Mapping](https://learnsome.tech/learn/dotnet-course/m04l04) (lesson 4.4, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can map persistence entities to request and response records explicitly and safely.

In the lesson: The first method maps an entity to the response record and names every field that leaves the application. The second maps a create request to a new entity and deliberately leaves the database identifier alone. These methods are pure, so a unit test can exercise them without a host or a database. Keep mapping close to the contract or application layer, and use names that say which direction the conversion travels. A mapping method is also a natural place to normalize input when the rule belongs at the boundary.

## Files

- [`starter/ProductMapping.cs`](starter/ProductMapping.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductMapping.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
