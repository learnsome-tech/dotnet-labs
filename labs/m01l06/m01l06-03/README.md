# m01l06-03 · Why a DTO wants to be a record

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Read along

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: A request and a response are data in flight. They arrive, they are checked, they are handed on, and nothing about them changes in place, which is the shape a record fits. In the catalog sample the create product request and the product response are both records, and the type system then stops a handler quietly reassigning a field halfway through. Value equality pays for itself in tests, where a whole expected response is compared with the real one in a single assertion. And when a value is small and has no identity of its own, like money, reach for a record struct: the same generated members, copied by value, with nothing put on the heap.

## Files

- [`starter/Contracts.cs`](starter/Contracts.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Contracts.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: data in flight
   - Lines 4–5: Value equality pays for itself
   - Lines 6–7: reach for a record struct
3. Notes from the lesson:
   - Line 3: A request is data in flight: no identity, no behaviour, no setters
   - Line 7: record struct: a small value copied by value, nothing on the heap

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m01l06-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
