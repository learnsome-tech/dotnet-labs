# m02l04-05 · The container resolves a graph

**Lesson:** [The Dependency Injection Container: Scopes and Lifetimes](https://learnsome.tech/learn/dotnet-course/m02l04) (lesson 2.4, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can register services with the built in container and choose transient, scoped, or singleton lifetime without leaking state across requests.

In the lesson: This standalone example uses the same container without a web host. Create a service collection, register one interface and implementation, build the provider, and ask it for the required service. The last line prints the implementation's text, proving that the container followed the registration. In an ASP dot net application the host builds this provider for you, and endpoint parameters or constructors request the services they need. The required service method throws if registration is missing, which makes a wiring mistake fail early rather than return a null and fail much later.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/Program.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–3: service collection
   - Lines 4–5: build the provider
   - Lines 6–10: prints

## How to check

**Read along.** The listing does not run cleanly in the lab sandbox (it relies on something the sandbox cannot provide), so the site shows it read-only.

There is nothing to check: `./check m02l04-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
