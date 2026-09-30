# m01l01-02 · Source to IL to machine code

**Lesson:** [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) (lesson 1.1, module 1: C Sharp And .NET Fundamentals) · Free  
**Check:** Read along

## Goal

You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

In the lesson: Follow the path your code takes. The compiler, called Roslyn, does not produce machine code. It produces intermediate language, a compact instruction set for an imaginary stack machine, and writes it into an assembly: a dll file that also carries metadata describing every type inside it. Nothing in that file is tied to a processor or an operating system. When you start the program, the runtime loads the assembly and a just in time compiler translates each method into native instructions for the machine it finds itself on, the first time that method is called. So any language that emits intermediate language - C Sharp, F Sharp, Visual Basic - runs on that one runtime and shares those same libraries, and one assembly runs on Linux, on macOS and on Windows.

## Files

- [`starter/source-to-il-to-machine-code.txt`](starter/source-to-il-to-machine-code.txt): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/source-to-il-to-machine-code.txt` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
