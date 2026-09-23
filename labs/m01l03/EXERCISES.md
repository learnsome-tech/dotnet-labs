# Exercises — Classes, Interfaces, and Object-Oriented C#

Lesson `m01l03` · [Watch](https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03)

## Exercise 1: Exercise: one contract, one service, one helper

1. Write IPriceSource: decimal? Find(string sku), plus a default bool Has(string sku).
2. Give PriceCalculator a primary constructor taking IPriceSource; return 0m if Find is null.
3. Add a static class with an extension method WithVat on decimal, rounded to 2 places.
4. Seal PriceCalculator, and comment on why the private readonly field is gone.

> **Hint**: If PriceCalculator mentions any concrete class by name, the seam has closed: it should only ever see IPriceSource.


---

© LearnSome.tech · support@iwantto.learnsome.tech
