# m07l04-02 · Register OpenTelemetry signals

**Lesson:** [OpenTelemetry, Container Publishing and Trimming](https://learnsome.tech/learn/dotnet-course/m07l04) (lesson 7.4, module 7: Testing Telemetry And Publishing) · Pro  
**Check:** Read along

## Goal

You can add traces and metrics, publish a container, and choose trimming only after measuring compatibility.

In the lesson: The host registers tracing and metrics, then adds instrumentation for incoming ASP dot net requests and outgoing HTTP calls. An exporter is configured for the environment rather than hard coded into business code. Include service name, deployment version, and environment as resource attributes so a trace can be found across deployments. Avoid putting secrets or personal data into span attributes. Telemetry is part of the application contract with operations, so review its volume and retention cost.

## Files

- [`starter/Telemetry.cs`](starter/Telemetry.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Telemetry.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m07l04-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m07l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
