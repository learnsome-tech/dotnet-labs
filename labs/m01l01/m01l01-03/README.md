# m01l01-03 · Ask the machine: which SDKs, which runtimes?

**Lesson:** [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) (lesson 1.1, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

In the lesson: Interrogate your own machine, because the answer is more interesting than people expect. The version command reports the software development kit that will build your code. Listing the kits shows every one installed and the folder it lives in; several can sit side by side. Listing the runtimes is where the penny drops, because you get two families. The one named Microsoft dot NET Core dot App is the runtime itself. The one named Microsoft dot ASP dot NET Core dot App is that same runtime plus the whole web stack: the server, routing, middleware. That is why a web application needs the second family and a console application never does.

## Files

- [`starter/session-ask-the-machine-which-sdks-which-runtimes.sh`](starter/session-ask-the-machine-which-sdks-which-runtimes.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/session-ask-the-machine-which-sdks-which-runtimes.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l01-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
