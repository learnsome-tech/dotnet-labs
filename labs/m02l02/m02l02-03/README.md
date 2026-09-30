# m02l02-03 · Pin the SDK and package version

**Lesson:** [Directory.Build.props, global.json and Central Packages](https://learnsome.tech/learn/dotnet-course/m02l02) (lesson 2.2, module 2: Solutions Projects And Configuration) · Pro  
**Check:** Read along

## Goal

You can make a repository use one SDK, one set of shared build properties, and one source of truth for package version.

In the lesson: Global json controls which kit the command line selects. The version pins the feature band, while latest patch permits security and servicing fixes in that band. Disallowing prerelease kits keeps a developer from accidentally compiling production code against an experimental compiler. If the exact kit is not installed, the command fails early with a useful message, which is far better than different machines producing subtly different binaries. Update this file intentionally when the team adopts a new kit, and let continuous integration prove that the declared version is available.

## Files

- [`starter/global.json`](starter/global.json): the listing from the lesson
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Read `starter/global.json` alongside the lesson.
2. Follow it the way the lesson builds it:
   - Lines 1–2: controls
   - Lines 3–4: latest patch
   - Lines 5–6: prerelease
   - Lines 7: file

## How to check

**Read along.** It is a listing to read alongside the lesson, not a program to run.

There is nothing to check: `./check m02l02-03` says so and moves on.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m02l02) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
