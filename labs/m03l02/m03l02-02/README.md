# m03l02-02 · A controller with the catalog route surface

**Lesson:** [Building Routes with Controllers](https://learnsome.tech/learn/dotnet-course/m03l02) (lesson 3.2, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can build a controller route with binding, validation, and explicit HTTP results.

In the lesson: The controller route begins with the shared prefix, and the action adds an integer identifier segment. The framework binds that identifier to the action parameter and calls the service. The property pattern makes the two outcomes easy to read: an existing product becomes an ok response, while no product becomes not found. The response type documents the successful payload, and the controller base supplies the HTTP helper methods. Keep the service behind an interface so this class remains about transport and status codes.

## Files

- [`starter/ProductsController.cs`](starter/ProductsController.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ProductsController.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m03l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
