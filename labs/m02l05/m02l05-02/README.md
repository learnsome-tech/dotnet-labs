# m02l05-02 · The starting point: a string, or a null

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: Here is the version everybody writes first. A small class takes the configuration interface and exposes three settings from it. Look hard at the first one: the key is misspelled. The compiler is happy, the container is happy, and the property hands back a null that travels a long way before anything visibly breaks. The next two are parsing by hand, so the value arrives as text and becomes a number at the moment of use, and that conversion throws on first read, deep inside a request, on a line that has nothing to do with configuration. Then there is the range that nobody enforces: a default page size and a maximum that must agree with each other, with the rule written in this file, nowhere.

## Files

- [`starter/StringlyTyped.cs`](starter/StringlyTyped.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/StringlyTyped.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–6: Here is the version everybody writes first
   - Lines 7–10: parsing by hand
   - Lines 11–14: the range that nobody enforces
3. Notes from the lesson:
   - Line 6: Currency is misspelled here. You get a null, and no warning at all
   - Line 10: A stray letter in that setting throws a FormatException, mid request
   - Line 13: Two numbers that must agree, with the rule written down in neither

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
