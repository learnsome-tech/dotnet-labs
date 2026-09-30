<p>
  <a href="https://learnsome.tech/courses/dotnet-course">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset=".github/assets/wordmark-inverse.svg">
      <img src=".github/assets/wordmark.svg" alt="LearnSome.tech" width="260">
    </picture>
  </a>
</p>

# Modern .NET Core, C# & Enterprise Microservices

**Asynchronous Streams, Kestrel Web Server & EF Core**

7 modules, 34 lessons: C Sharp And .NET Fundamentals; Solutions Projects And Configuration; Routing Controllers And Minimal APIs; Data Access And Mapping; Validation Errors And OpenAPI; Authentication Authorization And Resiliency; Testing Telemetry And Publishing. Intermediate level, about 2 hours.

This repository holds the labs of the LearnSome.tech course [Modern .NET Core, C# & Enterprise Microservices](https://learnsome.tech/courses/dotnet-course): each lab's starter files, a README with the goal, the steps and the expected output, and `./check`, which tests your work the way the site does.

## Start

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/learnsome-tech/dotnet-labs?quickstart=1)

- **Codespaces:** the badge opens this repository in a dev container with Python 3.14.7 and the .NET SDK 10.0.401, as in the site's lab sandbox.
- **On your machine:**

  ```sh
  git clone https://github.com/learnsome-tech/dotnet-labs.git
  cd dotnet-labs
  ./check m01l01-08
  ```

  You need Python 3 for `./check`, and for the labs themselves Python 3.14.7 and the .NET SDK 10.0.401. Other versions mostly work, but only the sandbox's versions are sure to print what the site prints. VS Code's Dev Containers extension builds the same container as Codespaces (x86-64).

## Doing a lab

1. Open the lesson on LearnSome.tech and the lab folder beside it: `labs/<lesson>/<lab>/`. The lab README has the goal, the steps and the expected output.
2. Work in the lab's `starter/` folder.
3. From the repository root, run `./check <lab>` (for example `./check m01l01-08`), or `./check <lesson>` for all labs of a lesson, or `./check --all`. `./check --list` shows every lab and how it is checked.

`./check` runs your starter the way the site's lab sandbox does: in a scratch copy that is its working directory and `HOME`, with `LANG=C.UTF-8`, `TZ=UTC`, `input.txt` on standard input, 10 seconds and 256 KiB of output per stream. It then compares the output with the site's own rules, so a pass here is a pass on the site.

| Check | What `./check` does | Labs |
| --- | --- | --- |
| Graded | Runs the program and compares its output with `expected.txt`. | 24 |
| Runs, not graded | Runs the program and shows its output; the site gives no pass or fail, and the lab README says why. | 3 |
| Read along | Nothing to run here: the site shows the listing read-only, and the lab README says honestly what it needs (Docker, a cluster, a cloud account...). | 78 |

## What is published, and what is not

Every lab's starter is the code the lesson shows on screen, which is also what the lab editor on the site opens with. Where that code is the whole program, such as a recorded shell session or a script from the video, it is published as it is: it is the lesson content. Nothing beyond the lesson is published. There are no reference solutions and no answers to the lesson exercises, and nothing the site keeps private.

Pro lessons' labs are here as starters too. LearnSome.tech runs and grades your labs in its sandbox, hosts the videos and keeps your progress; running and grading a Pro lab on the site needs Pro.

## Modules and lessons

### Module 1: C Sharp And .NET Fundamentals

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 1.1 | [What is .NET? Runtime vs SDK, and LTS vs STS](https://learnsome.tech/learn/dotnet-course/m01l01) | [5 labs](labs/m01l01/) | Free |
| 1.2 | [The C# Language: Types, Variables, and Flow Control](https://learnsome.tech/learn/dotnet-course/m01l02) | [8 labs](labs/m01l02/) | Free |
| 1.3 | [Classes, Interfaces, and Object-Oriented C#](https://learnsome.tech/learn/dotnet-course/m01l03) | [7 labs](labs/m01l03/) | Free |
| 1.4 | [Collections, Generics, and LINQ](https://learnsome.tech/learn/dotnet-course/m01l04) | [6 labs](labs/m01l04/) | Free |
| 1.5 | [Async and Await: Managing Concurrency](https://learnsome.tech/learn/dotnet-course/m01l05) | [5 labs](labs/m01l05/) | Pro |
| 1.6 | [Records, Pattern Matching, and Modern C#](https://learnsome.tech/learn/dotnet-course/m01l06) | [7 labs](labs/m01l06/) | Pro |

### Module 2: Solutions Projects And Configuration

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 2.1 | [Solutions, Projects, and Target Frameworks](https://learnsome.tech/learn/dotnet-course/m02l01) | [2 labs](labs/m02l01/) | Pro |
| 2.2 | [Directory.Build.props, global.json and Central Packages](https://learnsome.tech/learn/dotnet-course/m02l02) | [4 labs](labs/m02l02/) | Pro |
| 2.3 | [Code Quality: .editorconfig and Roslyn Analyzers](https://learnsome.tech/learn/dotnet-course/m02l03) | [3 labs](labs/m02l03/) | Pro |
| 2.4 | [The Dependency Injection Container: Scopes and Lifetimes](https://learnsome.tech/learn/dotnet-course/m02l04) | [3 labs](labs/m02l04/) | Pro |
| 2.5 | [The Options Pattern: Strongly Typed Configuration](https://learnsome.tech/learn/dotnet-course/m02l05) | [7 labs](labs/m02l05/) | Pro |
| 2.6 | [Environment Layering and User Secrets](https://learnsome.tech/learn/dotnet-course/m02l06) | [3 labs](labs/m02l06/) | Pro |

### Module 3: Routing Controllers And Minimal APIs

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 3.1 | [The ASP.NET Core Middleware Pipeline](https://learnsome.tech/learn/dotnet-course/m03l01) | [2 labs](labs/m03l01/) | Pro |
| 3.2 | [Building Routes with Controllers](https://learnsome.tech/learn/dotnet-course/m03l02) | [2 labs](labs/m03l02/) | Pro |
| 3.3 | [Building Routes with Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l03) | [2 labs](labs/m03l03/) | Pro |
| 3.4 | [Comparing Controllers and Minimal APIs](https://learnsome.tech/learn/dotnet-course/m03l04) | [2 labs](labs/m03l04/) | Pro |

### Module 4: Data Access And Mapping

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 4.1 | [Entity Framework Core: Code First and Migrations](https://learnsome.tech/learn/dotnet-course/m04l01) | [2 labs](labs/m04l01/) | Pro |
| 4.2 | [Querying, Change Tracking, and Saving Data](https://learnsome.tech/learn/dotnet-course/m04l02) | [2 labs](labs/m04l02/) | Pro |
| 4.3 | [The Repository Pattern](https://learnsome.tech/learn/dotnet-course/m04l03) | [2 labs](labs/m04l03/) | Pro |
| 4.4 | [Manual Object Mapping](https://learnsome.tech/learn/dotnet-course/m04l04) | [2 labs](labs/m04l04/) | Pro |
| 4.5 | [Source-Generated Mapping with Mapperly](https://learnsome.tech/learn/dotnet-course/m04l05) | [2 labs](labs/m04l05/) | Pro |

### Module 5: Validation Errors And OpenAPI

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 5.1 | [Model Validation and FluentValidation](https://learnsome.tech/learn/dotnet-course/m05l01) | [2 labs](labs/m05l01/) | Pro |
| 5.2 | [Global Exception Handling and Problem Details](https://learnsome.tech/learn/dotnet-course/m05l02) | [2 labs](labs/m05l02/) | Pro |
| 5.3 | [OpenAPI Generation in .NET 9](https://learnsome.tech/learn/dotnet-course/m05l03) | [2 labs](labs/m05l03/) | Pro |
| 5.4 | [API Documentation UI with Scalar](https://learnsome.tech/learn/dotnet-course/m05l04) | [2 labs](labs/m05l04/) | Pro |

### Module 6: Authentication Authorization And Resiliency

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 6.1 | [Authentication: JWTs and Claims](https://learnsome.tech/learn/dotnet-course/m06l01) | [2 labs](labs/m06l01/) | Pro |
| 6.2 | [Role-Based and Policy-Based Authorization](https://learnsome.tech/learn/dotnet-course/m06l02) | [2 labs](labs/m06l02/) | Pro |
| 6.3 | [Built-in Rate Limiting Middleware](https://learnsome.tech/learn/dotnet-course/m06l03) | [2 labs](labs/m06l03/) | Pro |
| 6.4 | [Health Checks](https://learnsome.tech/learn/dotnet-course/m06l04) | [2 labs](labs/m06l04/) | Pro |
| 6.5 | [Retry and Circuit Breaker Policies with Polly](https://learnsome.tech/learn/dotnet-course/m06l05) | [2 labs](labs/m06l05/) | Pro |

### Module 7: Testing Telemetry And Publishing

| # | Lesson | Labs | Access |
| --- | --- | --- | --- |
| 7.1 | [Unit Testing with xUnit and NSubstitute](https://learnsome.tech/learn/dotnet-course/m07l01) | [2 labs](labs/m07l01/) | Pro |
| 7.2 | [Integration Testing with WebApplicationFactory](https://learnsome.tech/learn/dotnet-course/m07l02) | [2 labs](labs/m07l02/) | Pro |
| 7.3 | [Behavior-Driven Development with Reqnroll](https://learnsome.tech/learn/dotnet-course/m07l03) | [2 labs](labs/m07l03/) | Pro |
| 7.4 | [OpenTelemetry, Container Publishing and Trimming](https://learnsome.tech/learn/dotnet-course/m07l04) | [3 labs](labs/m07l04/) | Pro |

**Free** lessons are open to anyone with a free LearnSome.tech account; **Pro** lessons need a Pro membership to watch, run and grade on the site.

## Licence

- **Code** (starter files, `check` and `.learnsome/`, the dev container and the workflows) is under the [MIT licence](LICENSE).
- **Written text** (the READMEs, lab instructions, lesson text, exercises and questions) is under [CC BY-NC-SA 4.0](LICENSE-text.md): share and adapt it with attribution to LearnSome.tech, not commercially, under the same licence.
- The LearnSome.tech name and logo are not covered by either licence.

## Contributing and security

This repository is generated from the course. Report a broken lab or a content error [as an issue](../../issues/new/choose); see [CONTRIBUTING.md](CONTRIBUTING.md). Security reports go to [SECURITY.md](SECURITY.md).

© 2026 LearnSome.tech
