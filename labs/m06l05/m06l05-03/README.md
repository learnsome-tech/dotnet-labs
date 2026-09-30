# m06l05-03 · An exhausted policy fails clearly

**Lesson:** [Retry and Circuit Breaker Policies with Polly](https://learnsome.tech/learn/dotnet-course/m06l05) (lesson 6.5, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Graded

## Goal

You can add bounded retries and circuit breaking to outbound HTTP calls without multiplying an outage.

In the lesson: This transcript shows a bounded policy after the initial call and three retries have failed. The circuit opens so later requests fail quickly rather than adding more pressure to the unhealthy dependency. The SDK is unavailable here, so the output is not executed. Emit metrics for attempts, timeout, circuit state, and final outcome, then alert on sustained open time rather than on one transient failure.

## Files

- [`starter/Resilience.cs`](starter/Resilience.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m06l05/m06l05-03/starter`
2. Read `Resilience.cs`.
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m06l05-03`.

## Expected output

```text
attempts: 4
circuit: open
```

## How to check

`./check m06l05-03` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l05) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
