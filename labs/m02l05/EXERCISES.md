# Exercises — The Options Pattern: Strongly Typed Configuration

Lesson `m02l05` · [Watch](https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l05)

## Exercise 1: Break the configuration, and make the host refuse

1. Add an int MaxRetries to CatalogOptions with [Range(0, 10)] and a matching appsettings key
2. Set it to 99, start the host, and read the message: which member and which rule?
3. Inject IOptionsSnapshot<CatalogOptions> into one endpoint; edit appsettings while it runs
4. Write an IValidateOptions<CatalogOptions> rule rejecting the placeholder SigningKey

> **Hint**: Only the snapshot and the monitor see an edit while the host is up; the plain interface never will.


---

© LearnSome.tech · support@iwantto.learnsome.tech
