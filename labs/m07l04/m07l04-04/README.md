# m07l04-04 · The publish gate reports a successful artifact

**Lesson:** [OpenTelemetry, Container Publishing and Trimming](https://learnsome.tech/learn/dotnet-course/m07l04) (lesson 7.4, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can add traces and metrics, publish a container, and choose trimming only after measuring compatibility.

In the lesson: The publish command reports a successful release artifact in this transcript. It is not executed because the SDK is unavailable. When the SDK is present, the verifier builds every project, runs dot net test for the solution, and checks the snippets that are marked executable. Publishing is complete only when the artifact starts, health checks pass, telemetry arrives, and the image can be rebuilt from the committed files.

## Files

- [`starter/PublishRun.txt`](starter/PublishRun.txt): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/PublishRun.txt` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l04-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
