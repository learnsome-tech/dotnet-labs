# m02l05-04 · The section it binds to, in appsettings.json

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: And here is the file it binds to, side by side with the class. The application settings file is a JSON document, and each object inside it is a configuration section. The connection strings section at the top is the one the database reads. Below it sits the catalog section, whose name matches the constant on the options class, and whose keys match the property names, key for key. That is the whole binding rule: the names line up, letter case is ignored, and the binder converts the text into the property type, quoted or not. One line there deserves a hard look, the signing key. A secret committed to a repository is a placeholder and never a real key, and the last lesson of this module moves it into user secrets where it belongs.

## Files

- [`starter/SOURCE.md`](starter/SOURCE.md)
- [`starter/appsettings.json`](starter/appsettings.json): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/appsettings.json` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–4: connection strings
   - Lines 5–8: the catalog section
   - Lines 9–13: key for key
3. Notes from the lesson:
   - Line 5: This object name matches the constant on the options class, exactly
   - Line 7: A JSON number binds to an int, and so would the same digits in quotes
   - Line 11: A placeholder, committed on purpose so that nobody mistakes it for a key

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
