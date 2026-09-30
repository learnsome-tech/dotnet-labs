# m01l06-05 · One switch expression instead of an if-chain

**Lesson:** [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) (lesson 1.6, module 1: C Sharp And .NET Fundamentals) · Pro  
**Check:** Graded

## Goal

You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

In the lesson: Here is the shape that replaces a chain of if statements. A switch expression takes a value, tries its arms in order, and produces a result; it is an expression, so it can be returned, assigned or passed as an argument with no temporary variable. Two constants share an arm through the or pattern, which keeps two spellings of one idea on a single line. The underscore at the bottom is the discard arm, matching anything that reached it. Notice what that buys: every input leaves this method with an answer, and no path declares a variable empty and leaves it that way. Print the four labels; the first arm that matches wins, so put specific cases above general ones.

## Files

- [`starter/Program.cs`](starter/Program.cs): the listing from the lesson
- [`starter/snippet.csproj`](starter/snippet.csproj)
- [`expected.txt`](expected.txt): the output the check compares with
- [`check.json`](check.json): how `./check` runs and checks this lab

## Steps

1. Go to the starter: `cd labs/m01l06/m01l06-05/starter`
2. Read `Program.cs` the way the lesson builds it:
   - Lines 1–2: replaces a chain of if statements
   - Lines 3–8: the or pattern
   - Lines 9–10: the discard arm
3. Notes from the lesson:
   - Line 4: A switch expression yields a value; a switch statement runs steps
   - Line 7: One arm, two spellings of the same idea, joined by or
   - Line 9: The discard arm matches anything that got this far
4. Run it: `dotnet run`.
5. Check it from the repository root: `./check m01l06-05`.

## Expected output

```text
Waiting for payment
On its way
Unknown status: lost
No status recorded
```

## How to check

`./check m01l06-05` copies `starter/` into a scratch directory and runs `dotnet run` there, the way the site's lab sandbox does: that directory is the working directory and `HOME`, `LANG=C.UTF-8`, `TZ=UTC`, a limit of 10 seconds and 256 KiB of output per stream.

It passes when the output matches `expected.txt` by the site's rules, within the limits. Standard output and standard error are compared after the .NET SDK's noise is set aside: restore and build banners, test-platform headers, hosting start-up lines, stack-trace frames and blank lines are dropped, and times, paths, GUIDs and timestamps are masked. `./check` builds the project first (the site compiles within its time limit with a warm compiler), then times the run. A pass here is a pass on the site.

---

[Open the lesson on LearnSome.tech](https://learnsome.tech/learn/dotnet-course/m01l06) · [All labs of this lesson](../README.md) · [Course README](../../../README.md)
