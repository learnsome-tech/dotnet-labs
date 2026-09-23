# Exercises — Async and Await: Managing Concurrency

Lesson `m01l05` · [Watch](https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l05)

## Exercise 1: Exercise: Make Three Fetches Overlap

1. Fix mistake three: write GetManyAsync(int[] ids, CancellationToken ct).
2. Start every fetch before awaiting anything, then await Task.WhenAll once.
3. Time it against the serial foreach and print both, rounded to whole seconds.
4. Make one fetch throw, and report which exception comes out of the await.

> **Hint**: Task.WhenAll over Task<T> returns Task<T[]>, in the order you passed the tasks in.


---

© LearnSome.tech · support@iwantto.learnsome.tech
