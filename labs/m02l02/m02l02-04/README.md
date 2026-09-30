# m02l02-04 · Central package management

**Lesson:** [Directory.Build.props, global.json and Central Packages](https://learnsome.tech/learn/dotnet-course/m02l02) (lesson 2.2, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can make a repository use one SDK, one set of shared build properties, and one source of truth for package version.

In the lesson: Central package management has two halves. The property turns it on, and the package version item records one approved version for the repository. Individual project files then reference the package by name without repeating a version. A security update changes one line and the restore graph changes consistently. Keep related packages on compatible versions, and use a lock file when reproducible restores matter. This arrangement also makes stale packages easy to find because the version inventory is in one short file instead of scattered through every application and test project.

## Files

- [`starter/Directory.Packages.props`](starter/Directory.Packages.props): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Directory.Packages.props` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: property
   - Lines 4–5: package version
   - Lines 6: package
   - Lines 7–8: file

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l02-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
