# m05l01-02 · A request and its validator

**Lesson:** [Model Validation and FluentValidation](https://learnsome.tech/learn/dotnet-course/m05l01) (lesson 5.1, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can validate API input at the boundary and return useful field errors without putting validation in handlers.

In the lesson: The request record describes the data in flight, and the validator describes the rules that make it acceptable. The name must exist and stay within a useful limit. The price must be greater than zero. These rules are separate from the database and from the endpoint, so a background job or another transport can reuse them. Register the validator with dependency injection, and make validation run before the application service is called.

## Files

- [`starter/CreateProductValidator.cs`](starter/CreateProductValidator.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/CreateProductValidator.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m05l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
