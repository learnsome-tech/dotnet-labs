# m02l05-08 · Rules attributes cannot express, and PostConfigure

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: Data annotations run out at the first rule that mentions two members at once. For those, implement the validate options interface. It has one method, which receives the named options key and the bound object, and returns success or a failure. Here the rule is that a default page size above the maximum is nonsense, and no attribute on either property could have said so. A failure result carries a message, and those messages reach the same start up exception you saw a moment ago, in the same format. The validator is registered as a singleton against the interface, and validate on start runs it beside the annotations. One more clause is worth knowing: post configure runs after all binding and every configure call, which makes it the place to fill in a value computed from the others - and it runs before validation.

## Files

- [`starter/CatalogOptionsValidator.cs`](starter/CatalogOptionsValidator.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CatalogOptionsValidator.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–7: implement the validate options interface
   - Lines 8–15: A failure result carries a message
   - Lines 16–19: returns success
   - Lines 20–22: registered as a singleton
3. Notes from the lesson:
   - Line 4: Page size against maximum; key length against algorithm; either against both
   - Line 8: name is the named options key, null or empty for the default instance
   - Line 12: Fail takes one message or many, and all of them reach the same exception
   - Line 21: Ordinary registration against the interface; ValidateOnStart runs it too

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-08` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
