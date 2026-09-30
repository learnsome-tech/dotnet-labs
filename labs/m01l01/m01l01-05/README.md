# m01l01-05 · The csproj: four properties that matter

**Lesson:** [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) (lesson 1.1, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

In the lesson: This file is your project: ten lines of XML, four of which you will care about for the rest of the course. The output type says build an executable rather than a library. The target framework is the interesting one. Net ten point zero is a moniker - a name for one version of the base class library and one set of language features. It is a promise about the API surface you may call, not a statement about the machine you run on. A program built for it wants a ten point something runtime present at start up, and by default it rolls forward to the newest patch it can find, so a security fix in the runtime protects you with no rebuild. Implicit usings adds the common namespaces for you. Nullable turns on the compiler's warnings about references that could be null.

## Files

- [`starter/Hello.csproj`](starter/Hello.csproj): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Hello.csproj` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: This file is your project
   - Lines 4: The output type says
   - Lines 5: the interesting one
   - Lines 6–7: Implicit usings adds
   - Lines 8–10: references that could be null
3. Notes from the lesson:
   - Line 4: Exe -> an app with an entry point; Library -> a .dll to reference
   - Line 5: net10.0 -> rolls forward to the newest 10.0.x patch at startup
   - Line 7: No `using System;` at the top of every file

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l01-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
