# m04l01-04 · Create and apply a migration

**Lesson:** [Entity Framework Core: Code First and Migrations](https://learnsome.tech/learn/dotnet-course/m04l01) (lesson 4.1, module 4: Data Access And Mapping) · Pro  
**Check:** Read along

## Goal

You can model an entity, register a DbContext, and use migrations to evolve a database schema safely.

In the lesson: With the design package installed, the entity model becomes a migration in two commands. The first builds the project and records the initial catalog schema. The second applies that migration to the configured database. These are transcript lines because this machine has no dot net kit. In a team, run migration generation from a controlled environment, commit the files, and let deployment apply them with an explicit connection string. Keep development databases disposable, but keep production schema history deliberate.

## Files

- [`starter/session-create-and-apply-a-migration.sh`](starter/session-create-and-apply-a-migration.sh): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/session-create-and-apply-a-migration.sh` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m04l01-04` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m04l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
