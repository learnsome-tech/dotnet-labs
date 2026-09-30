# m03l04-03 · The comparison uses the same requests

**Lesson:** [Comparing Controllers and Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l04) (lesson 3.4, module 3: Routing Controllers And Minimal APIs) · Pro  
**Check:** Read along

## Goal

You can choose between controllers and minimal APIs by comparing the same runnable route surface rather than relying on taste.

In the lesson: The sample solution starts two hosts with the identical route surface, one controller application and one minimal application. Send the same request to each port. Both responses should carry the same status, payload shape, validation behavior, and authorization policy. The ports differ only so both hosts can run together. This segment is a web transcript, and the important proof is the equality of the responses. If a difference appears, treat it as a bug in the implementation or metadata rather than as evidence that one style is inherently more correct.

## Files

- [`starter/compare.sh`](starter/compare.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/compare.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m03l04-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m03l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
