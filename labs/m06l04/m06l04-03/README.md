# m06l04-03 · A healthy probe returns success

**Lesson:** [Health Checks](https://learnsome.tech/learn/dotnet-course/m06l04) (lesson 6.4, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Graded

## Goal

You can expose liveness and readiness checks without making a failing dependency look like a dead process.

In the lesson: A healthy probe returns a success status that the orchestrator can use. This is a transcript because the SDK is not installed. Test the unhealthy case as well, especially for a readiness dependency, and decide whether a degraded result should remove the instance from rotation. Health checks are operational contracts, so keep their paths, statuses, and dependency tags documented with the deployment manifests.

## Files

- [`starter/HealthRequest.cs`](starter/HealthRequest.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m06l04/m06l04-03/starter`
2. Read `HealthRequest.cs`.
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m06l04-03`.

## Expected output

```text
200 Healthy
```

## How to check

`./check m06l04-03` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l04) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
