# m06l01-02 · Register bearer validation

**Lesson:** [Authentication: JWTs and Claims](https://learnsome.tech/learn/dotnet-course/m06l01) (lesson 6.1, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can validate a bearer token and read claims from the authenticated user.

In the lesson: The bearer handler receives an authority that publishes signing keys and metadata, and an audience that names this API. In production, validate issuer, audience, lifetime, and signature through the identity provider configuration, and keep authority settings in options rather than source. Adding authorization registers the policy engine. The application then calls authentication before authorization in the pipeline and marks protected endpoints with the appropriate requirement.

## Files

- [`starter/Auth.cs`](starter/Auth.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Auth.cs` alongside the lesson.

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m06l01-02` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
