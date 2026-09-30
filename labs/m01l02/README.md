# m01l02 · The C# Language: Types, Variables, and Flow Control

Module 1: C Sharp And .NET Fundamentals · lesson 1.2 · Free · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l02)

**Goal:** Read and write everyday C# declarations, numeric choices, nullability and control flow without guessing what the compiler will do.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l02-02](m01l02-02/) | Declared, inferred, and still one fixed type | Graded |
| [m01l02-04](m01l02-04/) | Proving copy semantics with a struct and a class | Graded |
| [m01l02-06](m01l02-06/) | Why money is never a double | Graded |
| [m01l02-07](m01l02-07/) | Turning nullable reference types on | Read along |
| [m01l02-08](m01l02-08/) | The question mark, the warning, and the escape hatch | Graded |
| [m01l02-09](m01l02-09/) | Strings: immutable, interpolated, raw, and built | Graded |
| [m01l02-10](m01l02-10/) | The switch statement and the switch expression | Read along |
| [m01l02-11](m01l02-11/) | Loops, and early return as the house style | Graded |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Your turn: a price line that cannot drift

1. Write Receipt.cs: a decimal unit price of 19.99m, an int quantity of 3, print the total.
2. Add a struct Line with an Amount field, copy it, change the copy, print both amounts.
3. Write Label(string? sku) returning "unknown" for null or empty, with early returns.
4. Now retype the unit price as a double and note which printed digits change.

> **Hint:** The suffix decides the type: 19.99 is a double, 19.99m is a decimal, 19.99f is a float.

## Check yourself

- Why does var not make C# dynamically typed?
- A method changes a field of a struct it was passed. Does the caller see it?
- Which type holds a price, and what goes wrong if you reach for double?
- What does the compiler report when you dereference a string? without checking?
- When is StringBuilder the right answer instead of interpolation?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
