# m07l03-02 · A catalog scenario

**Lesson:** [Behavior-Driven Development with Reqnroll](https://learnsome.tech/learn/dotnet-course/m07l03) (lesson 7.3, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can write a readable Reqnroll scenario and connect its steps to the application boundary.

In the lesson: This feature has one focused scenario. It names the behavior, performs an HTTP request through a step definition, and checks the public status. A real feature can use a background step for shared setup and a scenario outline for several examples. Keep nouns and outcomes stable so a product reader can review the contract without learning C Sharp. The step definition remains the bridge to the real host and should reuse the same client setup as ordinary integration tests.

## Files

- [`starter/catalog.feature`](starter/catalog.feature): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/catalog.feature` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
