# m04l05-02 · A Mapperly declaration

**Lesson:** [Source-Generated Mapping with Mapperly](https://learnsome.tech/learn/dotnet-course/m04l05) (lesson 4.5, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can use Mapperly for compile-time mapping while keeping the mapping contract and dependencies explicit.

In the lesson: The mapper attribute marks a partial class for generation. Each partial method declares one direction and one contract. Mapperly generates the method bodies and reports a diagnostic when it cannot map a required member. The declaration stays small enough to review, while the generated assignments remain ordinary code that the compiler checks. Do not put authorization, stock checks, or database calls in this class. It is a conversion tool, and keeping that purpose narrow preserves the same boundary as the manual version.

## Files

- [`starter/ProductMapper.cs`](starter/ProductMapper.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductMapper.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l05-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
