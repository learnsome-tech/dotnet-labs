# m01l01 · What is .NET? Runtime vs SDK, and LTS vs STS

Module 1: C Sharp And .NET Fundamentals · lesson 1.1 · Free · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m01l01)

**Goal:** You can tell the .NET runtime apart from the SDK, read a csproj target framework, and choose between an LTS and an STS release.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m01l01-02](m01l01-02/) | Source to IL to machine code | Read along |
| [m01l01-03](m01l01-03/) | Ask the machine: which SDKs, which runtimes? | Read along |
| [m01l01-05](m01l01-05/) | The csproj: four properties that matter | Read along |
| [m01l01-07](m01l01-07/) | Scaffold and run in three commands | Read along |
| [m01l01-08](m01l01-08/) | Top level statements in Program.cs | Graded |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Audit your own machine

1. List the runtimes on your box; note every version in both App families
2. Scaffold a second console app with a name of your own and run it
3. Open its .csproj and say out loud what each of the four properties does
4. Find the support end date of your TargetFramework and diary it

> **Hint:** A machine can carry many runtimes and many SDKs at once; the lists are meant to have several lines.

## Check yourself

- A colleague installs only the ASP.NET Core runtime on a build server. What breaks?
- Your app targets net10.0 and the box has 10.0.4 installed. Does it start, and why?
- Which release would you pick for a system you must support until 2028, and why?
- What does the JIT do that Roslyn does not, and when does it do it?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
