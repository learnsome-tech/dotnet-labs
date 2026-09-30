# m01l04 · Collections, Generics, and LINQ

Module 1: C Sharp And .NET Fundamentals · lesson 1.4 · Free · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l04)

**Goal:** You can pick the right collection, write generic and LINQ queries, and keep a query deferred until the moment it should run.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l04-02](m01l04-02/) | Generic methods and the constraint clauses | Read along |
| [m01l04-04](m01l04-04/) | Building the four with square bracket initialisers | Graded |
| [m01l04-05](m01l04-05/) | Deferred execution: nothing runs until you ask | Graded |
| [m01l04-06](m01l04-06/) | The LINQ operators you will actually use | Read along |
| [m01l04-07](m01l04-07/) | Aggregates and grouping over one sequence | Graded |
| [m01l04-09](m01l04-09/) | yield return: your own lazy sequence | Graded |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Query a small catalogue yourself

1. Cheap(IEnumerable<Product>) -> IReadOnlyList<string>: names under 20, ordered by name.
2. Total uses Sum; ByCategory uses GroupBy to give a Dictionary<string, int> of counts.
3. Write an iterator with yield return that yields every other element of an IEnumerable<T>.

> **Hint:** Print a line as the first statement inside the iterator, then watch when it appears.

## Check yourself

- Why does List<T> avoid the cast and the box that an object list needed?
- Which collection answers have I seen this key before in constant time?
- When does the lambda inside Where actually run, and what triggers it?
- What does IQueryable<T> hold that IEnumerable<T> does not, and why does it matter?
- First or FirstOrDefault: how do you choose between them?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
