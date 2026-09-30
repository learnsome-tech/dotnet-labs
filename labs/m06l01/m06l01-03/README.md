# m06l01-03 · A claim is available after authentication

**Lesson:** [Authentication: JWTs and Claims](https://learnsome.tech/learn/dotnet-course/m06l01) (lesson 6.1, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Read along

## Goal

You can validate a bearer token and read claims from the authenticated user.

In the lesson: This transcript creates an authenticated principal with a bearer identity and prints the authentication flag. A real request gets the principal from the validated token handler rather than constructing one in application code. The SDK is absent here, so the output is not executed. Treat claims as input from a trust boundary: validate the token first, then use stable claim types and avoid trusting arbitrary display names for security decisions.

## Files

- [`starter/Claims.cs`](starter/Claims.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Claims.cs` alongside the lesson.

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m06l01-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l01) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
