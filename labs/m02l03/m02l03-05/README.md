# m02l03-05 · Make warnings visible in continuous integration

**Lesson:** [Code Quality: .editorconfig and Roslyn Analyzers](https://learnsome.tech/learn/dotnet-course/m02l03) (lesson 2.3, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can configure formatting and analyzer severity in the repository, then fix the diagnostics that protect an API from avoidable defects.

In the lesson: Two commands make the contract visible in continuous integration. Dot net format in verify mode checks that the files already match the repository style and changes nothing. The build with warnings as errors then refuses code that leaves an enabled diagnostic unresolved. Run both from the solution root, after restore. A developer can use the ordinary format command locally to apply safe formatting, but the server should verify the result rather than rewrite a pull request. That keeps the diff in the author's hands and makes the check repeatable.

## Files

- [`starter/session-make-warnings-visible-in-continuous-integrat.sh`](starter/session-make-warnings-visible-in-continuous-integrat.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/session-make-warnings-visible-in-continuous-integrat.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l03-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
