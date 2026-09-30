# m06l02-02 · Define a named write policy

**Lesson:** [Role-Based and Policy-Based Authorization](https://learnsome.tech/learn/dotnet-course/m06l02) (lesson 6.2, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can protect endpoints with roles and named policies based on claims.

In the lesson: The named policy requires a scope claim with the catalog write value. The route opts into that policy by name, so its protection is visible beside its declaration. Add role requirements when a coarse organizational role is the actual rule, and combine requirements when both facts matter. Keep policy names stable and central so a route does not silently spell a different permission from the identity provider.

## Files

- [`starter/Policies.cs`](starter/Policies.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Policies.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m06l02-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
