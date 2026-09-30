# m02l06-02 · Shared and development settings

**Lesson:** [Environment Layering and User Secrets](https://learnsome.tech/learn/dotnet-course/m02l06) (lesson 2.6, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can layer configuration by environment and keep local secrets out of source control.

In the lesson: This shared file contains values that are safe for every environment. A development file with the same section and key names can override the page size or point at a local issuer. Keep the shared file useful but uninteresting: defaults, feature switches, and public endpoints belong here. Connection strings, signing keys, passwords, and tokens do not. The options binder sees the merged result, so the application reads one configuration tree while deployment chooses which providers supply each value.

## Files

- [`starter/appsettings.json`](starter/appsettings.json): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/appsettings.json` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l06-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
