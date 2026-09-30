# m02l03-02 · A small editor config with a clear contract

**Lesson:** [Code Quality: .editorconfig and Roslyn Analyzers](https://learnsome.tech/learn/dotnet-course/m02l03) (lesson 2.3, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can configure formatting and analyzer severity in the repository, then fix the diagnostics that protect an API from avoidable defects.

In the lesson: This editor config starts at the repository root, so an editor does not merge in a parent directory by accident. The shared section chooses spaces and four columns. The next two lines set analyzer severity: one warning asks you to dispose a resource correctly, while the other suggestion points out a method that could be static. The final section applies a style preference only to C Sharp files. Notice the distinction. A resource leak deserves attention because it can exhaust a service. A qualification preference is a choice about readability, so it stays a suggestion.

## Files

- [`starter/.editorconfig`](starter/.editorconfig): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/.editorconfig` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1: root
   - Lines 2–5: spaces
   - Lines 6–7: warning
   - Lines 8–10: C Sharp files

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l03-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
