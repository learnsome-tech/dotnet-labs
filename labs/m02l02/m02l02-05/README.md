# m02l02-05 · Build the repository policy

**Lesson:** [Directory.Build.props, global.json and Central Packages](https://learnsome.tech/learn/dotnet-course/m02l02) (lesson 2.2, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can make a repository use one SDK, one set of shared build properties, and one source of truth for package version.

In the lesson: With those files committed, the terminal tells the story in order. Check the selected kit first, restore the dependency graph, and build the solution. On a machine with the kit installed, the first command should agree with global json, and the build should use the same shared properties for every project. The exact restore chatter varies by SDK and cache, so the lesson transcript shows only the stable result. In continuous integration, run the same commands from a clean checkout. That is how repository policy becomes a fact rather than a promise.

## Files

- [`starter/session-build-the-repository-policy.sh`](starter/session-build-the-repository-policy.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/session-build-the-repository-policy.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l02-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
