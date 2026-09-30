# m01l06 · Records, Pattern Matching, and Modern C#

Module 1: C Sharp And .NET Fundamentals · lesson 1.6 · Pro · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l06)

**Goal:** You can read and write modern C#: records, pattern matching, switch expressions and the everyday syntax the rest of the course relies on.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l06-02](m01l06-02/) | A record: equality, printing and copying, generated | Graded |
| [m01l06-03](m01l06-03/) | Why a DTO wants to be a record | Read along |
| [m01l06-04](m01l06-04/) | Patterns: type, property, relational, logical, list | Graded |
| [m01l06-05](m01l06-05/) | One switch expression instead of an if-chain | Graded |
| [m01l06-06](m01l06-06/) | Exhaustiveness: a warning that is doing you a favour | Read along |
| [m01l06-07](m01l06-07/) | Four pieces of modern syntax, one small class | Read along |
| [m01l06-08](m01l06-08/) | Usings you never type, and a file with no class | Read along |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Exercise: a parcel, a band, and a missing arm

1. Declare a positional record Parcel(int Id, decimal Weight); print two equal parcels.
2. Write a switch expression mapping Weight to a band, with a discard arm at the bottom.
3. Match the middle band with a property pattern joining two relational patterns with and.
4. Delete the discard arm, read the compiler warning, then put it back.

> **Hint:** Relational patterns have no left-hand side: an arm reads `< 1m =>`, and `and` joins two of them.

## Check yourself

- What does a positional record generate that a hand-written class does not?
- Why is a record struct a good fit for a small value like Money?
- Which pattern combinators cannot declare a variable, and why?
- What does the compiler do when a switch expression is not exhaustive, and what happens at run time if an unhandled value arrives?
- When would you still choose a class over a record?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
