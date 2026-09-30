# m02l05-05 · Bind, validate, and refuse to start

**Lesson:** [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) (lesson 2.5, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

In the lesson: Registration is four lines, and they read in the order they happen. Inside the shared platform method, the call to add options of catalog options returns an options builder, and every call after it chains off that. Bind configuration names the section by path and subscribes the binding to reloads. There is also a bind method that takes a section object instead, when you are already holding one. Validate data annotations turns those attributes into a real check. And validate on start is the line that changes your life: without it validation is lazy, running the first time something asks for the value, so a bad setting fails at request time, in one endpoint, in production. With it, the host validates while starting and refuses to come up. A deployment that will not start gets rolled back; a half working one becomes an incident.

## Files

- [`starter/SOURCE.md`](starter/SOURCE.md)
- [`starter/ServiceCollectionExtensions.cs`](starter/ServiceCollectionExtensions.cs): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/ServiceCollectionExtensions.cs` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–4: Inside the shared platform method
   - Lines 5–7: Bind configuration
   - Lines 8–9: validate on start
3. Notes from the lesson:
   - Line 6: AddOptions returns an options builder; everything below chains off it
   - Line 7: BindConfiguration takes the section path; Bind takes the section itself
   - Line 9: Without this line the first failure is a request, not a failed deploy

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l05-05` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
