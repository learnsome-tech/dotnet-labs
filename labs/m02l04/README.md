# m02l04 · The Dependency Injection Container: Scopes and Lifetimes

Module 2: Solutions Projects And Configuration · lesson 2.4 · Pro · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m02l04)

**Goal:** You can register services with the built in container and choose transient, scoped, or singleton lifetime without leaking state across requests.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m02l04-02](m02l04-02/) | Register one service at each lifetime | Read along |
| [m02l04-04](m02l04-04/) | Constructor injection keeps dependencies visible | Read along |
| [m02l04-05](m02l04-05/) | The container resolves a graph | Read along |

## Check yourself

- Why is a database context usually scoped?
- What danger does a singleton capturing a scoped service create?
- What does required service add to a container lookup?
- Which lifetime fits a stateless formatter?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
