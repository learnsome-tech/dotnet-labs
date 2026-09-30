# m02l06-05 · Deployment values arrive as environment variables

**Lesson:** [Environment Layering and User Secrets](https://learnsome.tech/learn/dotnet-course/m02l06) (lesson 2.6, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can layer configuration by environment and keep local secrets out of source control.

In the lesson: The host composes configuration before the application reads it. This example asks only whether a signing key exists, and prints a safe status instead of printing the key. In deployment, an environment variable named with the configuration path can supply that value, while the source tree remains unchanged. Prefer the typed options class from the previous lesson, validate the value at startup, and make missing or placeholder secrets stop the host before it accepts traffic.

## Files

- [`starter/EnvironmentConfiguration.cs`](starter/EnvironmentConfiguration.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/EnvironmentConfiguration.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l06-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
