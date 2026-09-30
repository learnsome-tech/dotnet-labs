# m02l01-02 · The smallest useful web project file

**Lesson:** [Solutions, Projects, and Target Frameworks](https://learnsome.tech/learn/dotnet-course/m02l01) (lesson 2.1, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can explain what a solution and project contain, choose a target framework, and read the important parts of a project file.

In the lesson: Here is the smallest useful web project file. The web software development kit brings in the shared web defaults and the server assemblies. The target framework chooses the platform API surface your code may call. Nullable asks the compiler to point out unsafe reference use, and implicit usings supplies common namespaces so every file does not begin with the same ceremony. The project file is XML, but you rarely need to edit generated item lists because the modern SDK includes source files automatically. Add a package or a property when the project needs one, and let the build system supply the rest.

## Files

- [`starter/Project.csproj`](starter/Project.csproj): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Project.csproj` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: project file
   - Lines 2–3: target framework
   - Lines 4–5: implicit usings
   - Lines 6–7: project

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
