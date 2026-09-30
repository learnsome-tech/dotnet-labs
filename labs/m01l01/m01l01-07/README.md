# m01l01-07 · Scaffold and run in three commands

**Lesson:** [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) (lesson 1.1, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

In the lesson: With the kit installed, a working program is three commands away. The template command scaffolds a console project into a folder named after it: a project file and one source file, nothing else, no boilerplate class, no configuration. Step into the folder and the run command does everything in sequence - restore whatever packages are needed, compile to intermediate language, then launch the result. Notice what reaches the terminal: only what the program itself wrote. A clean build says nothing as it goes past, which is worth remembering, because the day you do see build chatter it is telling you something real. These same two commands, with a different template, are how the Catalog API you build later in this course begins.

## Files

- [`starter/session-scaffold-and-run-in-three-commands.sh`](starter/session-scaffold-and-run-in-three-commands.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/session-scaffold-and-run-in-three-commands.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l01-07` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
