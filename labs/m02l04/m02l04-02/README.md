# m02l04-02 · Register one service at each lifetime

**Lesson:** [The Dependency Injection Container: Scopes and Lifetimes](https://learnsome.tech/learn/dotnet-course/m02l04) (lesson 2.4, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can register services with the built in container and choose transient, scoped, or singleton lifetime without leaking state across requests.

In the lesson: These three registrations differ only in lifetime, but that difference is the part you must design. A transient clock is created each time it is requested. A scoped order reader is shared within one web request and then discarded. A singleton tenant catalog lives for the whole process. Register the abstraction on the left and the implementation on the right, so a handler depends on the contract. The container can resolve declares recursively, which means one registration may itself depend on another. Keep the graph explicit and avoid registrations whose meaning changes with hidden global state.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: transient
   - Lines 2: scoped
   - Lines 3: singleton

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
