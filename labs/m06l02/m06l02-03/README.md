# m06l02-03 · Policy failures have different statuses

**Lesson:** [Role-Based and Policy-Based Authorization](https://learnsome.tech/learn/dotnet-course/m06l02) (lesson 6.2, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Graded

## Goal

You can protect endpoints with roles and named policies based on claims.

In the lesson: These transcript lines show the two outcomes clients must distinguish. A missing or invalid identity receives unauthorized, while an authenticated principal without the required policy receives forbidden. The SDK is absent here, so the lines are not executed. In an integration test, send one request without credentials and one with a token missing the scope, then assert both status codes and the problem response shape.

## Files

- [`starter/Authz.cs`](starter/Authz.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m06l02/m06l02-03/starter`
2. Read `Authz.cs`.
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m06l02-03`.

## Expected output

```text
401 Unauthorized
403 Forbidden
```

## How to check

`./check m06l02-03` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
