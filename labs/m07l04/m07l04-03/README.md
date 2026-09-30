# m07l04-03 · Publish a trimmed container

**Lesson:** [OpenTelemetry, Container Publishing and Trimming](https://learnsome.tech/learn/dotnet-course/m07l04) (lesson 7.4, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can add traces and metrics, publish a container, and choose trimming only after measuring compatibility.

In the lesson: The first command asks the dot net SDK to publish the application as a container using the release configuration. Trimming is shown as an optional second step, because it should follow analysis rather than be copied blindly into every service. Inspect linker warnings, run the published application, and exercise reflection heavy features before accepting a smaller image. Keep the base image, processor architecture, and runtime patch policy explicit in the deployment files.

## Files

- [`starter/Publish.cs`](starter/Publish.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Publish.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l04-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
