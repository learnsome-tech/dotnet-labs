# m01l05 · Async and Await: Managing Concurrency

Module 1: C Sharp And .NET Fundamentals · lesson 1.5 · Pro · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l05)

**Goal:** Write async methods that free the request thread, cancel cleanly, overlap independent work and surface their exceptions.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l05-02](m01l05-02/) | The Shape Of Every Async Method You Will Write | Read along |
| [m01l05-04](m01l05-04/) | Three Ways To Get This Wrong | Read along |
| [m01l05-05](m01l05-05/) | Sequential Awaits Versus Task.WhenAll | Graded |
| [m01l05-06](m01l05-06/) | Exceptions Travel Across An await | Graded |
| [m01l05-08](m01l05-08/) | Streaming Results With IAsyncEnumerable | Graded |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Exercise: Make Three Fetches Overlap

1. Fix mistake three: write GetManyAsync(int[] ids, CancellationToken ct).
2. Start every fetch before awaiting anything, then await Task.WhenAll once.
3. Time it against the serial foreach and print both, rounded to whole seconds.
4. Make one fetch throw, and report which exception comes out of the await.

> **Hint:** Task.WhenAll over Task<T> returns Task<T[]>, in the order you passed the tasks in.

## Check yourself

- Why does async raise throughput without making one request faster?
- What does the compiler actually do to a method marked async?
- Why can an exception thrown inside an async void method not be caught?
- When does Task.WhenAll beat awaiting in a loop, and when does it not help?
- If two tasks in a WhenAll both fail, what does await hand you?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
