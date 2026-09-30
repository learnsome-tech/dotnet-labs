# m02l05-03 · The options class: plain properties, real attributes

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: This is the same configuration, typed. It is a plain class with properties, sealed because nothing needs to inherit from it, living in the application project beside the code that reads it. There is no base class, no interface and no framework type anywhere in the file. Notice that the section name lives on the class as a constant, not in a string literal retyped at every registration and in every test. Then the data annotations: required, a string length, a range. These are the very attributes you already put on a request model, and they turn a comment about what is allowed into a rule something can check. Each property also carries sensible defaults, and a default matters more than it looks - it is the value you get when the section is silent.

## Files

- [`starter/CatalogOptions.cs`](starter/CatalogOptions.cs): the listing from the lesson
- [`starter/SOURCE.md`](starter/SOURCE.md)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CatalogOptions.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–8: the section name lives on the class
   - Lines 9–12: data annotations
   - Lines 13–18: sensible defaults
3. Notes from the lesson:
   - Line 8: The section name travels with the class it binds, not in a scattered literal
   - Line 11: Three letters exactly: the same attributes you already put on a request model
   - Line 15: A default is what you get when the configuration section says nothing

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
