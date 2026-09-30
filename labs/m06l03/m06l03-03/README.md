# m06l03-03 · The limiter rejects excess traffic

**Lesson:** [Built-in Rate Limiting Middleware](https://learnsome.tech/learn/dotnet-course/m06l03) (lesson 6.3, module 6: Authentication Authorization And Resiliency) · Pro  
**Check:** Graded

## Goal

You can define a partitioned rate limit and return a useful response when a client exceeds it.

In the lesson: When a partition exceeds its allowance, the service returns too many requests and can include a retry after hint. These transcript lines are not executed because the SDK is unavailable. Clients should honor the hint with backoff and jitter, while servers should measure rejected requests separately from ordinary failures. A limit that is never observed in metrics is only a hope.

## Files

- [`starter/RateRequest.cs`](starter/RateRequest.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m06l03/m06l03-03/starter`
2. Read `RateRequest.cs`.
3. Run it: `dotnet run`.
4. Check it from the repository root: `./check m06l03-03`.

## Expected output

```text
429 Too Many Requests
Retry-After: 10
```

## How to check

`./check m06l03-03` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m06l03) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
