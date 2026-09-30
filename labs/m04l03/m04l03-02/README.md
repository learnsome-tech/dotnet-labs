# m04l03-02 · A focused repository contract

**Lesson:** [The Repository Pattern](https://learnsome.tech/learn/dotnet-course/m04l03) (lesson 4.3, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can decide where a repository helps, define a focused interface, and avoid hiding useful query behavior.

In the lesson: This interface exposes three application questions: find one product, search products, and add a product. It does not expose a context, a queryable, or a provider specific option. Every method accepts cancellation because the caller owns the request lifetime. The result types describe what the application needs, not the database table. The implementation can use EF Core today and a test double or another store tomorrow, but that substitution is useful only if the contract remains small and meaningful.

## Files

- [`starter/IProductRepository.cs`](starter/IProductRepository.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/IProductRepository.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
