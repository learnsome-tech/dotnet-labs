# m04l01-02 · An entity and its context

**Lesson:** [Entity Framework Core: Code First and Migrations](https://learnsome.tech/learn/dotnet-course/m04l01) (lesson 4.1, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can model an entity, register a DbContext, and use migrations to evolve a database schema safely.

In the lesson: This entity has an integer key, a required name, and a price. The context receives its options from dependency injection and exposes the products set. The primary key follows convention because it is named identifier. The required modifier makes construction honest in C Sharp, while database nullability still comes from the model configuration and migration. Keep entities close to persistence concerns, and expose records or response models at the HTTP boundary so database shape does not become your public contract.

## Files

- [`starter/CatalogContext.cs`](starter/CatalogContext.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CatalogContext.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
