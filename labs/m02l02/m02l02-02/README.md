# m02l02-02 · Shared build properties

**Lesson:** [Directory.Build.props, global.json and Central Packages](https://learnsome.tech/learn/dotnet-course/m02l02) (lesson 2.2, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can make a repository use one SDK, one set of shared build properties, and one source of truth for package version.

In the lesson: This shared file applies three policies to every project underneath it. Nullable is enabled everywhere, warnings are promoted to errors so a warning cannot quietly accumulate, and the analysis level selects the recommended Roslyn rules for the compiler in use. The file does not list projects and does not copy source files. Its job is policy. If one project truly needs an exception, put that exception in the project file and make the difference obvious in review. A small shared file is a useful default because it gives new projects the same quality bar on their first build.

## Files

- [`starter/Directory.Build.props`](starter/Directory.Build.props): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Directory.Build.props` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: shared file
   - Lines 2–4: warnings
   - Lines 5: analysis level
   - Lines 6–7: file

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
