# m02l05 · The Options Pattern: Strongly Typed Configuration

Module 2: Solutions Projects And Configuration · lesson 2.5 · Pro · [Open the lesson](https://learnsome.tech/learn/dotnet-course/m02l05)

**Goal:** You can turn a configuration section into a validated options class, choose between the three options interfaces, and make a bad setting stop the host at start up rather than at request time.

## Labs

| Lab | What it is | Check |
| --- | --- | --- |
| [m02l05-02](m02l05-02/) | The starting point: a string, or a null | Read along |
| [m02l05-03](m02l05-03/) | The options class: plain properties, real attributes | Read along |
| [m02l05-04](m02l05-04/) | The section it binds to, in appsettings.json | Read along |
| [m02l05-05](m02l05-05/) | Bind, validate, and refuse to start | Read along |
| [m02l05-06](m02l05-06/) | IOptions, IOptionsSnapshot, IOptionsMonitor | Read along |
| [m02l05-07](m02l05-07/) | A bad setting, seen at start up instead of at teatime | Read along |
| [m02l05-08](m02l05-08/) | Rules attributes cannot express, and PostConfigure | Read along |

## Exercises

Open exercises from the lesson, to try on your own. They have no answer files: work them out, and use the labs above as reference.

### Break the configuration, and make the host refuse

1. Add an int MaxRetries to CatalogOptions with [Range(0, 10)] and a matching appsettings key
2. Set it to 99, start the host, and read the message: which member and which rule?
3. Inject IOptionsSnapshot<CatalogOptions> into one endpoint; edit appsettings while it runs
4. Write an IValidateOptions<CatalogOptions> rule rejecting the placeholder SigningKey

> **Hint:** Only the snapshot and the monitor see an edit while the host is up; the plain interface never will.

## Check yourself

- What exactly does IConfiguration return for a key you misspelled, and when do you find out?
- Why is ValidateOnStart the call that matters, and what happens without it?
- You inject IOptions<CatalogOptions> into a singleton and edit appsettings.json. What changes?
- Which validation rules need IValidateOptions<T> rather than data annotations, and why?
- Where does PostConfigure run in relation to binding and validation?

---

[Course README](../../README.md) · [Modern .NET Core, C# & Enterprise Microservices on LearnSome.tech](https://learnsome.tech/courses/dotnet-course)
