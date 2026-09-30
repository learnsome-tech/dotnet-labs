# m01l03 · Classes, Interfaces, and Object-Oriented C#

Module 1: C Sharp And .NET Fundamentals · lesson 1.3 · Free · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l03)

**Goal:** You can model a domain with properties, interfaces and constructor injection, and tell when inheritance is the wrong tool.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l03-02](m01l03-02/) | Properties instead of public fields | Read along |
| [m01l03-03](m01l03-03/) | Constructors, and constructor injection | Read along |
| [m01l03-04](m01l03-04/) | Interfaces: the contract the container resolves | Read along |
| [m01l03-05](m01l03-05/) | Inheritance, sparingly: virtual and override | Graded |
| [m01l03-06](m01l03-06/) | Static classes and extension methods | Read along |
| [m01l03-07](m01l03-07/) | IDisposable and the using declaration | Graded |
| [m01l03-08](m01l03-08/) | Equality: references first, members only if you say so | Graded |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Exercise: one contract, one service, one helper

1. Write IPriceSource: decimal? Find(string sku), plus a default bool Has(string sku).
2. Give PriceCalculator a primary constructor taking IPriceSource; return 0m if Find is null.
3. Add a static class with an extension method WithVat on decimal, rounded to 2 places.
4. Seal PriceCalculator, and comment on why the private readonly field is gone.

> **Hint:** If PriceCalculator mentions any concrete class by name, the seam has closed: it should only ever see IPriceSource.

## Check yourself

- Why do model binding, validation and EF Core find properties but ignore public fields?
- What can `init` do that a private `set` cannot, and vice versa?
- A class overrides `Equals` but not `==`. What does `a == b` print for two equal instances?
- When does a `using` declaration call `Dispose`, and who calls it for a container-built service?
- What makes `AddCatalogPlatform(this IServiceCollection services)` callable as an instance method?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
