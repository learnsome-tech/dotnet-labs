# m05l04-02 · Map Scalar over the document

**Lesson:** [API Documentation UI with Scalar](https://learnsome.tech/learn/dotnet-course/m05l04) (lesson 5.4, module 5: Validation Errors And OpenAPI) · Pro  
**Check:** Read along

## Goal

You can add Scalar as a documentation UI over the built in OpenAPI document.

In the lesson: The application still registers and maps the built in document. One additional mapping adds Scalar's browser UI, which reads the document route and renders it. The package is a UI dependency, not a replacement for OpenAPI generation. Keep the two routes explicit so operations can protect or disable them independently. In a production service, decide whether an internal network, an authenticated role, or a separate documentation host should be the only audience.

## Files

- [`starter/Scalar.cs`](starter/Scalar.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Scalar.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m05l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m05l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
