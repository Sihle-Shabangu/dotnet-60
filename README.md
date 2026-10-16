# dotnet-60: 60-Day Full-Stack .NET Plan

**Window:** Fri 16 Oct 2026 (Day 1) to Mon 14 Dec 2026 (Day 60)
**Outcome:** build, test, secure, containerise and deploy a C# / ASP.NET Core + React app from scratch. Realistic target: a hireable late-junior full-stack developer.
**Side track:** AZ-900 (Azure Fundamentals) and Immersive Labs, every day.

## Repo layout

```
/katas                 Exercism solutions and small experiments
/notes                 concept notebook (http.md, csharp-basics.md, az900.md, ...)
/p1-expense-tracker    Project 1: CLI expense tracker
/p2-booking-engine     Project 2: appointment booking engine
/taskflow              Project 3 + 4: TaskFlow API, TaskFlow Web, docker-compose
/docs                  ER diagram, ADRs, threat model, case study
/sql                   SQL practice and schema scripts
```

## Standing routine

- **Schedule:** 06:30 exercise. 07:45 read yesterday's log, name today's deliverable. 08:00-11:00 Build 1. 11:30-14:30 Build 2. 15:30-17:30 Security / Azure. 17:30-18:30 Job and log.
- **End of every day:** commit and push, tick the day below, write a five-line log (shipped, stuck on, learned, tomorrow's deliverable, hours), add concept-notebook entries (what it is, why it exists, how it fails).
- **Job pattern:** Mon and Wed apply to 2 targeted roles. Tue and Thu message 1 real person. Fri apply to 1-2 roles and count the week (target 5 applications, 3 conversations). Sat message 1 person.
- **Sundays:** rest, faith, one-hour weekly review. No coding.
- **Rules:** concept, then a 20-minute experiment, then the feature. At least 50% of dev hours writing code. One deliverable per day committed to Git. Optional extras never replace the core deliverable.
- **Behind by more than 2 days at a gate?** Use the cut list below. Do not move dates.

## Gates (pass/fail, Saturdays)

| Gate | Date | Must prove |
|---|---|---|
| 1 | Sat 31 Oct | Explain URL-to-response aloud and show it with curl. Write an async HTTP call with error handling and a test. Explain value vs reference types, record vs class, LINQ deferred execution, await, dependency injection. Tests green, README, commits on 12+ distinct days. AZ-900 Learn path complete. |
| 2 | Sat 14 Nov | 50+ SQL exercises. Normalised schema built through EF Core migrations. CRUD for 2+ resources with DTOs, validation, correct status codes, OpenAPI. You caused and fixed an N+1. `docker compose up` works from a clean clone. AZ-900 sat or booked. |
| 3 | Sat 28 Nov | Explain login-to-authorised-request aloud. Authorisation test on every endpoint including a wrong-user case. No secrets in repo history. Integration tests and green CI. Lists are paged with no N+1. Human reviewer read the auth code. Repo is public. |
| 4 | Sat 5 Dec | Full-stack app runs locally from docs. You can explain every request in the browser network tab. Defensible token handling. Component tests plus a Playwright flow. 3-minute recorded walkthrough. |
| 5 | Mon 14 Dec | Live deployed app with CI/CD, auth, tests, monitoring. Cold-build test passed in 4 hours. Case study, READMEs, CV and LinkedIn updated, 2 mock interviews. Honest self-assessment. |

## Cut list (cut from the top first when behind)

1. Managed Azure PostgreSQL (use a container)
2. Playwright beyond one flow
3. Rate limiting and health checks
4. Serilog (use built-in logging)
5. Refresh tokens (access tokens only)

**Never cut:** SQL fundamentals, understanding auth, integration tests, CI, deployment, the concept notebook, the daily log.

**Out of scope:** Angular, SignalR, caching, background jobs, Kubernetes, microservices, Blazor, gRPC.

---

# Week 1 (Days 1-7, Fri 16 - Thu 22 Oct)

Goal: environment working, HTTP understood, C# syntax learned, Project 1 designed and started.

## Day 1 - Fri 16 Oct - Setup and how the web works
Compressed day: starts 11:30.
- [ ] Install .NET SDK (current LTS), VS Code + C# Dev Kit (or Rider), Git, Docker Desktop. Verify with `dotnet --version`, `git --version`, `docker --version`
- [ ] Repo `dotnet-60` created with `/katas` and `/notes`. README pushed with goal and gate dates
- [ ] Exercism account, CLI installed, 5 C# exercises solved and committed
- [ ] Read MDN "An overview of HTTP". Run `curl -i https://example.com` and `curl -i https://api.github.com`
- [ ] `/notes/http.md`: parts of a request, parts of a response, 3 headers you did not understand
- [ ] **Ship:** tools verified, repo pushed, 5 exercises, first HTTP notes
- [ ] Security: Microsoft Learn account, start AZ-900 path (cloud concepts), benefits of cloud, notes in `/notes/az900.md`
- [ ] Job: update CV headline (front-end developer, building C#/.NET skills). Write the log
- [ ] Optional: Exercism 6-10, `.gitignore`, `.editorconfig`

## Day 2 - Sat 17 Oct - HTTP in depth, first C# program
- [ ] 5 more Exercism exercises (10 total)
- [ ] REST Client extension (or curl). Against jsonplaceholder.typicode.com: GET, POST with JSON body, request to a missing route. Save in `/notes/requests.http`
- [ ] Extend `http.md`: methods and idempotency, status codes (200, 201, 204, 400, 401, 403, 404, 409, 500), JSON, Content-Type / Accept / Authorization. A "how it fails" line per status family
- [ ] `dotnet new console` in `/katas/hello`: top-level statements, `using`, console input, a loop. Commit
- [ ] **Ship:** 10 exercises, complete `http.md`, `requests.http`
- [ ] Security: AZ-900 shared responsibility, public/private/hybrid, CapEx vs OpEx, consumption pricing
- [ ] Job: update LinkedIn headline and About
- [ ] Optional: MDN HTTP caching intro, POST with curl and custom headers

## Day 3 - Sun 18 Oct - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, `git log` shows commits on Days 1-2
- [ ] Write Monday's single deliverable

## Day 4 - Mon 19 Oct - C# types, control flow, nullability
- [ ] 10 Exercism exercises: types, strings, conditionals, loops (20 total)
- [ ] Experiment (20 min): value vs reference types with a struct and a class, copy and mutate
- [ ] Nullable reference types on in `.csproj`. 3 warning examples fixed with `?`, `??`, `?.`. Compare with TypeScript `string | undefined`
- [ ] `/notes/csharp-basics.md` with "how it fails" for value vs reference and for null
- [ ] **Ship:** `csharp-basics.md`, 20 exercises
- [ ] Security: AZ-900 IaaS, PaaS, SaaS, serverless. Domain 1 knowledge checks
- [ ] Job: apply to 2 roles, list repeated keywords from the job descriptions
- [ ] Optional: 4 more Exercism exercises

## Day 5 - Tue 20 Oct - Classes, records, collections
- [ ] 10 Exercism exercises: classes and collections (30 total)
- [ ] `Person` as class, record and struct: equality, immutability, `with`
- [ ] Practise `List<T>`, `Dictionary<K,V>`, `HashSet<T>`. CLI word-frequency counter (top 10 words from a text file)
- [ ] `switch` expression with pattern matching in the counter
- [ ] **Ship:** word-frequency CLI committed
- [ ] Security: AZ-900 regions, region pairs, availability zones, datacentres
- [ ] Job: message 1 real person
- [ ] Optional: ignore case and punctuation, 4 more exercises

## Day 6 - Wed 21 Oct - LINQ and generics
- [ ] 10 Exercism exercises (40 total)
- [ ] LINQ: Where, Select, OrderBy, GroupBy, First vs Single, Any, All, Sum, Average. Rewrite the counter with LINQ
- [ ] Experiment: deferred execution (change the source list, then enumerate, compare `.ToList()`). Note the cost of multiple enumeration
- [ ] Generic `Max<T>` with a constraint and a generic `Result<T>`
- [ ] **Ship:** LINQ counter, deferred-execution notes
- [ ] Security: AZ-900 management groups, subscriptions, resource groups, Azure Resource Manager
- [ ] Job: apply to 2 roles
- [ ] Optional: compare loop and LINQ versions for readability

## Day 7 - Thu 22 Oct - OOP and Project 1 core
- [ ] Notes: interface vs abstract class, composition over inheritance, one example each
- [ ] `/p1-expense-tracker`: `record Expense(Guid Id, decimal Amount, string Category, DateOnly Date, string? Note)`, `IExpenseStore`, `InMemoryExpenseStore`. Note why money uses `decimal`
- [ ] `add` and `list` commands. Custom `ValidationException` for zero or negative amounts with a friendly message
- [ ] README sketch: commands, examples, planned persistence
- [ ] Small commits with meaningful messages
- [ ] **Ship:** add and list on the in-memory store
- [ ] Security: AZ-900 VMs, scale sets, availability sets, App Service, containers (ACI, AKS), Functions
- [ ] Job: message 1 person, follow up on earlier messages
- [ ] Optional: 5 Exercism exercises on interfaces and OOP

---

# Week 2 (Days 8-14, Fri 23 - Thu 29 Oct)

Goal: Project 1 finished, first web server, testing and dependency injection understood, Project 2 nearly done.

## Day 8 - Fri 23 Oct - Project 1: persistence and commands
- [ ] `JsonExpenseStore` with System.Text.Json (`expenses.json`). Handle missing file and corrupt JSON with clear exceptions
- [ ] `filter` by category and date range (LINQ), `summary` totals per category
- [ ] CLI argument parsing with a `switch`, usage text on bad input
- [ ] Manually test 10 inputs (valid and invalid), list them in the README
- [ ] **Ship:** add, list, filter, summary persisting to a file
- [ ] Security: AZ-900 virtual networks, subnets, NSGs, VPN Gateway, ExpressRoute, DNS, peering
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: `delete` command, `--month` filter

## Day 9 - Sat 24 Oct - async/await, HttpClient, Project 1 done
- [ ] Read async/await and Task. Experiments: forget an `await` and read the warning, compare sync vs async file read, `Task.WhenAll` on two delays. Note why `async void` is dangerous
- [ ] `summary --currency ZAR` using a free no-key exchange-rate API (for example open.er-api.com, check it still works) with `HttpClient`
- [ ] Handle timeout, non-200, malformed JSON, no network with friendly errors
- [ ] Reuse one `HttpClient` and note why. Cache rates for the run
- [ ] README: how to run, decisions, "what I'd do differently". Tag `p1-complete`
- [ ] **Ship:** Project 1 complete
- [ ] Security: AZ-900 storage accounts, blob tiers, redundancy (LRS, ZRS, GRS), Azure Files, migration tools
- [ ] Job: message 1 person
- [ ] Optional: 5 async Exercism exercises, `--json` flag

## Day 10 - Sun 25 Oct - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, `git log`, Project 1 tagged and pushed
- [ ] Name Monday's deliverable

## Day 11 - Mon 26 Oct - Your first server
- [ ] `dotnet new web` in `/scratch-server`. Endpoints: `GET /health` returning `{"status":"ok"}`, `GET /expenses`, `POST /expenses` returning 201 with a Location header
- [ ] Test each with curl, commit `requests.http`
- [ ] Experiment: invalid JSON, wrong Content-Type, missing route. Record the 400, 415, 404 responses
- [ ] Read what `app.Run()` and Kestrel do. Draw the request path by hand, add a photo to `/notes`
- [ ] **Ship:** server with 3 endpoints and `requests.http`
- [ ] Security: AZ-900 Entra ID, authentication vs authorisation, MFA, passwordless, Conditional Access, external identities
- [ ] Job: apply to 2 roles
- [ ] Optional: `GET /expenses/{id}` returning 404 for a missing id

## Day 12 - Tue 27 Oct - Testing and Project 2 begins
- [ ] `/p2-booking-engine`: `Booking.Domain` (class library), `Booking.Tests` (xUnit), `Booking.Console`
- [ ] Read xUnit basics: `[Fact]`, `[Theory]`, Arrange-Act-Assert
- [ ] Model `Appointment` (Id, Start, End, ClientId, Status) with `DateTimeOffset`. Rule 1: end after start
- [ ] TDD no-double-booking: 5 failing tests first (overlap, adjacent, contained, identical, different clients), then pass. Keep red-then-green history
- [ ] **Ship:** overlap rule with 5+ passing tests
- [ ] Security: AZ-900 RBAC, Zero Trust, defence in depth, Defender for Cloud
- [ ] Job: message 1 person
- [ ] Optional: convert two tests to `[Theory]` with `[InlineData]`

## Day 13 - Wed 28 Oct - Dependency injection, configuration, logging
- [ ] Notes with code: what DI is, constructor injection, what breaks without it
- [ ] `IAppointmentRepository` plus in-memory implementation. `BookingService` takes it via constructor
- [ ] Test `BookingService` with a mock (NSubstitute or Moq). Add rule: no cancellation within 24 hours of start, with tests
- [ ] Generic host in the console app. Register Singleton, Scoped, Transient and log each hash code
- [ ] `appsettings.json` with `IOptions<BookingOptions>` (24-hour window) and `ILogger` output
- [ ] **Ship:** `BookingService` with DI, config, logging, 10+ tests
- [ ] Security: AZ-900 cost factors, Pricing Calculator, TCO Calculator, tags, budgets
- [ ] Job: apply to 2 roles, refresh CV
- [ ] Optional: logging scopes, note why Singleton differs from Transient

## Day 14 - Thu 29 Oct - Project 2 finished
- [ ] Rules: working hours 08:00-18:00, max 3 appointments per client per day, reschedule
- [ ] Edge-case tests: adjacent slots, same start, zero-length, cancellation exactly at the 24-hour boundary, time-zone offsets
- [ ] Console menu: book, cancel, reschedule, list
- [ ] README with a table of domain rules and the test proving each
- [ ] **Ship:** Project 2 functionally complete, 20+ tests
- [ ] Security: AZ-900 Azure Policy, resource locks, Microsoft Purview
- [ ] Job: message 1 person, follow up
- [ ] Optional: coverlet coverage report, note the weakest area

---

# Week 3 (Days 15-21, Fri 30 Oct - Thu 5 Nov)

Goal: pass Gate 1, Postgres in Docker, SQL learned properly.

## Day 15 - Fri 30 Oct - Gate 1 preparation
- [ ] Audit both projects against the Gate 1 rubric, write the gaps
- [ ] Fix the gaps. `git log` shows commits on 12+ distinct days
- [ ] 5-minute voice memo: URL to response, and what DI solves. Note hesitations
- [ ] Polish READMEs of Project 1 and 2
- [ ] **Ship:** Gate 1 submission pack (links and voice memo)
- [ ] Security: AZ-900 portal, CLI, PowerShell, Cloud Shell, Arc, ARM templates, Monitor, Advisor, Service Health
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: 60-second demo of each project

## Day 16 - Sat 31 Oct - GATE 1
- [ ] Send both repos for grading and the "explain aloud" questions
- [ ] Fix every issue from the review
- [ ] Five-line retrospective
- [ ] Pre-read: check Docker, read the pgexercises.com intro
- [ ] **Ship:** Gate 1 passed, or a written list of what is left
- [ ] Security: finish the AZ-900 Learn path. Take Microsoft's free practice assessment once as a baseline, record score per domain
- [ ] Job: message 1 person
- [ ] Optional: first 10 pgexercises questions

## Day 17 - Sun 1 Nov - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, Gate 1 feedback, 3 things to do differently in Phase 2
- [ ] Name Monday's deliverable

## Day 18 - Mon 2 Nov - Docker, Postgres, SQL basics
- [ ] Docker core ideas: image, container, volume, port mapping. Run `hello-world`, write notes
- [ ] `/taskflow/docker-compose.yml` for PostgreSQL with a named volume, env vars, port 5432. `docker compose up -d`
- [ ] Connect with DBeaver or pgAdmin and `psql`. Create `taskflow` database, a table, insert and select
- [ ] First 15 pgexercises questions (SELECT, WHERE, ORDER BY)
- [ ] Note why the volume matters: remove the container and see what survives
- [ ] **Ship:** Postgres via compose, 15 SQL exercises
- [ ] Security: AZ-900 timed practice exam 1, review every wrong answer
- [ ] Job: apply to 2 roles
- [ ] Optional: README for the compose file

## Day 19 - Tue 3 Nov - SQL: joins and aggregation
- [ ] pgexercises joins and aggregates (30 total)
- [ ] `users`, `projects`, `tasks` tables with seed rows. INNER and LEFT JOIN queries, explain the difference
- [ ] `GROUP BY` and `HAVING`: tasks per project, overdue tasks per user. WHERE vs HAVING
- [ ] `/sql/joins.sql`, with "how it fails" notes (NULLs after LEFT JOIN, duplicate rows from a bad join)
- [ ] **Ship:** 30 exercises, `joins.sql`
- [ ] Security: AZ-900 timed practice exam 2 and review
- [ ] Job: message 1 person
- [ ] Optional: 5 more pgexercises questions

## Day 20 - Wed 4 Nov - SQL: subqueries, CTEs, modifying data
- [ ] pgexercises subqueries and modifying data (45 total)
- [ ] A CTE and a `ROW_NUMBER()` window query (latest task per project)
- [ ] NULL behaviour, `COALESCE`, `DISTINCT`, `LIMIT/OFFSET`
- [ ] 10 TaskFlow queries from memory (due this week, busiest assignee, projects with no tasks...), check each
- [ ] **Ship:** 45 exercises, 10 queries from memory
- [ ] Security: AZ-900 timed practice exam 3 and review
- [ ] Job: apply to 2 roles
- [ ] Optional: finish all pgexercises sections

## Day 21 - Thu 5 Nov - Relational design I
- [ ] Read normalisation (1NF-3NF), primary / foreign / composite keys, one-to-many, many-to-many via join table
- [ ] Draft schema: `users`, `projects`, `project_members` (role), `tasks` (status, priority, due date, assignee), `comments`, `tags`, `task_tags`
- [ ] `schema.sql` with `NOT NULL`, `UNIQUE` (email), `CHECK` (statuses), foreign keys with deliberate `ON DELETE`
- [ ] ER diagram (dbdiagram.io or Mermaid) saved in `/docs`
- [ ] Notes: update and delete anomalies in a denormalised table
- [ ] **Ship:** `schema.sql` runs cleanly on the container, plus the ER diagram
- [ ] Security: AZ-900 timed practice exam 4, one hour on your weakest domain
- [ ] Job: message 1 person
- [ ] Optional: `created_at` / `updated_at` columns with defaults

---

# Week 4 (Days 22-28, Fri 6 - Thu 12 Nov)

Goal: finish database design, sit AZ-900, first real ASP.NET Core API and first EF Core migration.

## Day 22 - Fri 6 Nov - Indexes and transactions
- [ ] Seed 10,000 tasks with `generate_series`. `EXPLAIN ANALYZE` a filter query, add an index on `tasks(project_id, status)`, run again, record both timings
- [ ] Transactions: `BEGIN`, `COMMIT`, `ROLLBACK`. Move tasks between projects in one transaction, force a failure halfway
- [ ] Notes: what an index costs and when not to add one
- [ ] Finalise the ER diagram, commit `/docs`
- [ ] **Ship:** index experiment write-up with before and after timings
- [ ] Security: AZ-900 timed practice exam 5. Target 85%+ three in a row. Confirm tomorrow's booking
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: `LIKE '%text%'` search with and without an index

## Day 23 - Sat 7 Nov - AZ-900 exam day
- [ ] Finalise `schema.sql` and a seed script. Commit
- [ ] Open roadmap.sh/aspnet-core and tick topics you can already explain
- [ ] Skim your weakest AZ-900 domain for 30 minutes, then sit the exam in the 15:30-17:30 slot
- [ ] Log the result and surprising topics
- [ ] **Ship:** final schema and seed script, exam result logged
- [ ] If not at 85% on three consecutive practice attempts: move the exam to Sat 14 Nov. Do not sit underprepared
- [ ] Job: message 1 person

## Day 24 - Sun 8 Nov - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, SQL concepts you still cannot explain
- [ ] Name Monday's deliverable

## Day 25 - Mon 9 Nov - ASP.NET Core I: structure, controllers, middleware
- [ ] `dotnet new webapi`, `TaskFlow` solution with `TaskFlow.Api`, folders Controllers, Dtos, Services
- [ ] Custom middleware logging method, path, status, duration. Move it before and after routing
- [ ] `ProjectsController`: GET list, GET by id, POST, PUT, DELETE on an in-memory list. Model binding from route, query, body
- [ ] DTO records (`ProjectCreateDto`, `ProjectDto`). Note why entities are never exposed
- [ ] Correct codes: 201 with `CreatedAtAction`, 204, 404
- [ ] **Ship:** Projects CRUD in memory with logging middleware
- [ ] Security: Immersive Labs account, web fundamentals labs (HTTP, cookies), log labs done
- [ ] Job: apply to 2 roles
- [ ] Optional: `GET /projects?search=`

## Day 26 - Tue 10 Nov - ASP.NET Core II: validation, errors, OpenAPI
- [ ] Data-annotation validation (`[Required]`, `[StringLength]`, `[Range]`). Confirm `[ApiController]` returns 400, test with curl
- [ ] Global error handling returning ProblemDetails (`AddProblemDetails`, `UseExceptionHandler`). `NotFoundException` maps to 404
- [ ] OpenAPI and its UI on. Check what your SDK template provides
- [ ] `TasksController` under `/projects/{projectId}/tasks`, in memory
- [ ] Notes: REST conventions (plural nouns, idempotent PUT and DELETE, when to PATCH)
- [ ] **Ship:** two resources with validation, ProblemDetails, OpenAPI
- [ ] Security: Immersive Labs injection basics
- [ ] Job: message 1 person
- [ ] Optional: custom validation attribute for past due dates

## Day 27 - Wed 11 Nov - ASP.NET Core III: services, lifetimes, configuration
- [ ] `IProjectService` and `ITaskService` registered with DI
- [ ] Demonstrate Scoped, Singleton, Transient in the web context (service holding a `Guid`, call twice)
- [ ] `appsettings.Development.json`, user-secrets for the connection string, `IOptions`
- [ ] 6 unit tests for the services
- [ ] Install `Microsoft.EntityFrameworkCore`, `Npgsql.EntityFrameworkCore.PostgreSQL`, `Microsoft.EntityFrameworkCore.Design`, `dotnet-ef` tool. Read the EF Core overview
- [ ] **Ship:** services via DI, secrets configured, EF installed, 6 tests
- [ ] Security: Immersive Labs authentication and session basics
- [ ] Job: apply to 2 roles, refresh CV
- [ ] Optional: fail-fast startup check for required settings

## Day 28 - Thu 12 Nov - EF Core I: entities and first migration
- [ ] Entities `User`, `Project`, `ProjectMember`, `TaskItem`, `Comment`, `Tag`, `TaskTag` with navigations. Fluent API for keys, indexes, required, max lengths, delete behaviour
- [ ] `TaskFlowDbContext` with `AddDbContext` and Npgsql, connection string from user-secrets
- [ ] `dotnet ef migrations add InitialCreate`. Read the SQL (`dotnet ef migrations script`), compare with `schema.sql`. `dotnet ef database update`
- [ ] Seed data. Notes: tracking vs no-tracking
- [ ] **Ship:** migration applied, database matches your design
- [ ] Security: Immersive Labs SQL injection labs
- [ ] Job: message 1 person and follow up
- [ ] Optional: write up differences between generated SQL and `schema.sql`

---

# Week 5 (Days 29-35, Fri 13 - Thu 19 Nov)

Goal: API on PostgreSQL, Gate 2 passed, authentication end to end. Explain every auth piece aloud as you build it.

## Day 29 - Fri 13 Nov - EF Core II: wire the API to the database
- [ ] Replace in-memory `ProjectService` with EF Core (`ToListAsync`, `FirstOrDefaultAsync`, `SaveChangesAsync`)
- [ ] Pass `CancellationToken` from controller into EF calls, note why
- [ ] Map entities to DTOs through projection (`Select`)
- [ ] Map FK and unique violations to 400 or 409 ProblemDetails, not 500
- [ ] **Ship:** Projects CRUD persisted in PostgreSQL
- [ ] Security: Immersive Labs cross-site scripting basics
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: `AsNoTracking` on reads, note the SQL change

## Day 30 - Sat 14 Nov - Tasks, N+1, GATE 2
Heavy day. Start early.
- [ ] Tasks CRUD with EF Core including relationships (assignee, tags many-to-many)
- [ ] Cause an N+1 on purpose (projects with task counts in a loop). Turn on EF SQL logging (dev only), count queries, fix with `Include` or a projection. Put before and after counts in the README
- [ ] Clean-clone test: fresh folder, follow only the README (`docker compose up`, migrate, run), fix every gap
- [ ] Walk the Gate 2 rubric, send the repo
- [ ] **Ship:** Gate 2 submission
- [ ] Security: one Immersive lab. If AZ-900 moved to today, sit it in this block
- [ ] Job: message 1 person

## Day 31 - Sun 15 Nov - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, Gate 2 feedback, fixes to make before auth
- [ ] Name Monday's deliverable

## Day 32 - Mon 16 Nov - Auth I: concepts, hashing, registration
- [ ] Notes: authentication vs authorisation, session cookies vs tokens, JWT structure, claims, expiry, how each fails
- [ ] Experiment: decode a sample JWT, change one character in the payload, watch validation fail
- [ ] Password hashing: why plain text and fast hashes fail. Use ASP.NET Core Identity `PasswordHasher` (or vetted BCrypt / Argon2). Test hash and verify
- [ ] `Email` (unique) and `PasswordHash` on `User` with a migration. `POST /auth/register` with validation. Never log passwords. Duplicate email returns 409
- [ ] **Ship:** register endpoint with hashed passwords and tests
- [ ] Security: Immersive Labs authentication labs
- [ ] Job: apply to 2 roles
- [ ] Optional: password-strength rule and test

## Day 33 - Tue 17 Nov - Auth II: login and JWT
- [ ] `POST /auth/login`: verify the hash, same generic error for wrong email or password
- [ ] Short-lived JWT (15 min) with `sub`, `email`, `role`. Signing key in user-secrets, never in the repo
- [ ] `AddAuthentication().AddJwtBearer(...)` validating issuer, audience, lifetime, key. `UseAuthentication` before `UseAuthorization`
- [ ] `[Authorize]` on Projects. curl: no token 401, valid 200, expired 401, tampered 401
- [ ] Notes: 401 vs 403
- [ ] **Ship:** login plus protected endpoints
- [ ] Security: Immersive Labs broken authentication, turn one finding into a fix or test
- [ ] Job: message 1 person
- [ ] Optional: clock-skew test for token expiry

## Day 34 - Wed 18 Nov - Auth III: roles, ownership, refresh tokens, CORS
- [ ] Roles Admin and Member as claims. `ProjectMember` authorisation handler and policy
- [ ] Enforce ownership in the query (filter by membership). Test that another project's user gets 404 or 403
- [ ] Refresh tokens: hashed token with expiry and revocation, `POST /auth/refresh` with rotation, revoke on logout (or cut item 5 if behind)
- [ ] CORS: named policy allowing only `http://localhost:5173`. Check preflight with curl
- [ ] 5-minute voice memo: how a login becomes an authorised request
- [ ] **Ship:** roles, ownership checks, CORS, refresh tokens or a note that you cut them
- [ ] Security: Immersive Labs broken access control and IDOR, add one proving test
- [ ] Job: apply to 2 roles. Add the TaskFlow repo link to your CV once public
- [ ] Optional: Admin-only endpoint with a test per role

## Day 35 - Thu 19 Nov - Pagination, filtering, sorting
- [ ] Paging (`page`, `pageSize` with a max) returning `{items, total, page, pageSize}`
- [ ] Filter tasks by status, assignee, due date. Sort only by an allow-list of fields
- [ ] Comments and Tags endpoints under tasks
- [ ] Indexes for filter columns in a migration, confirm with `EXPLAIN`. Check logged SQL for N+1 on every list endpoint
- [ ] **Ship:** task list with paging, filtering, sorting, no N+1
- [ ] Security: Immersive Labs parameterised queries, confirm EF parameterises by reading the logged SQL
- [ ] Job: message 1 person and follow up
- [ ] Optional: Postgres full-text search endpoint

---

# Week 6 (Days 36-42, Fri 20 - Thu 26 Nov)

Goal: feature-complete API with automated tests, CI on every push, hardening done.

## Day 36 - Fri 20 Nov - Error handling, logging, health checks
- [ ] Every error as ProblemDetails with a trace id. Map domain exceptions to 400, 404, 409
- [ ] Structured logging with Serilog (console sink, request logging, correlation id), or built-in `ILogger` with scopes
- [ ] `/health/live` and `/health/ready` (ready checks the database)
- [ ] Audit: table of every endpoint with `[Authorize]` or a justified `[AllowAnonymous]`
- [ ] **Ship:** API v0.1.0 tagged and pushed
- [ ] Security: Immersive Labs security misconfiguration, no stack traces in production
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: trace id in a response header, find the log line

## Day 37 - Sat 21 Nov - Testing I: unit tests
- [ ] Unit tests: auth service (hash and verify), membership rules, task filter logic (NSubstitute). 15 or more
- [ ] Test names read like specs: `Login_WithWrongPassword_ReturnsGenericError`
- [ ] `public partial class Program`, one `WebApplicationFactory` smoke test on `/health/live`
- [ ] Notes: unit vs integration and how each fails
- [ ] **Ship:** 15+ unit tests green, one smoke test
- [ ] Security: Immersive Labs sensitive data exposure, logs and errors contain no passwords or tokens
- [ ] Job: message 1 person
- [ ] Optional: test that proves a password never appears in logs

## Day 38 - Sun 22 Nov - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, test count, 3 riskiest untested behaviours
- [ ] Name Monday's deliverable

## Day 39 - Mon 23 Nov - Testing II: integration tests with Testcontainers
- [ ] Testcontainers for PostgreSQL. Custom `WebApplicationFactory` pointing at the test container, migrations on startup
- [ ] Helper: register, log in, return a bearer token
- [ ] Tests: register and login, 401 without token, projects CRUD, wrong-project user cannot read, invalid payload gives 400 ProblemDetails
- [ ] Isolate tests (Respawn or a new database per class)
- [ ] `dotnet test` from a clean clone
- [ ] **Ship:** 10 integration tests green
- [ ] Security: Immersive Labs SQL injection retest with curl against your own API
- [ ] Job: apply to 2 roles
- [ ] Optional: run the suite 3 times to find flaky tests

## Day 40 - Tue 24 Nov - Testing III and CI
- [ ] Integration tests for tasks: paging, filtering, sorting, non-allowed sort field returns 400
- [ ] `.github/workflows/ci.yml`: checkout, setup .NET, restore, build, test on push and PR (Ubuntu runners include Docker for Testcontainers)
- [ ] Branch protection on `main` requiring CI (if your plan allows)
- [ ] CI badge in the README
- [ ] **Ship:** green CI on `main`
- [ ] Security: Immersive Labs XSS. API returns JSON with right Content-Type, add `X-Content-Type-Options: nosniff`
- [ ] Job: message 1 person
- [ ] Optional: cache NuGet packages, test-results summary

## Day 41 - Wed 25 Nov - Authorisation matrix and secrets audit
- [ ] Authorisation matrix: every endpoint against anonymous, wrong user, member, admin as a `[Theory]`
- [ ] Secrets audit: search git history (`git log -p` or gitleaks), rotate leaks, check `.gitignore` and `appsettings.json`
- [ ] Input audit: max lengths, enum validation, required fields
- [ ] **Ship:** matrix tests green, secrets audit written up
- [ ] Security: Immersive Labs access control retest against your matrix
- [ ] Job: apply to 2 roles
- [ ] Optional: startup test failing if a controller lacks an authorisation attribute

## Day 42 - Thu 26 Nov - Hardening and documentation
- [ ] Rate-limit `/auth/login` and `/auth/register`, test the 429
- [ ] HTTPS redirection and HSTS for production
- [ ] README: overview, architecture sketch, how to run, API docs link, decisions, "what I'd do differently"
- [ ] OpenAPI describes bearer auth and response types
- [ ] Repo public, link sent to a human reviewer to read the auth code
- [ ] **Ship:** Gate 3 submission pack
- [ ] Security: Immersive Labs brute force and rate limiting, add one rate-limit test
- [ ] Job: message 1 person, follow up
- [ ] Optional: security headers (CSP, Referrer-Policy) with a test

---

# Week 7 (Days 43-49, Fri 27 Nov - Thu 3 Dec)

Goal: pass Gate 3, then build the React client against your own API.

## Day 43 - Fri 27 Nov - Gate 3 preparation
- [ ] Audit the API against the Gate 3 rubric, write the gaps
- [ ] Fix the gaps. Every endpoint has an authorisation test, CI green
- [ ] 5-minute voice memo: login to authorised request, no notes
- [ ] Chase your human reviewer for feedback on the auth code
- [ ] **Ship:** Gate 3 submission pack, final
- [ ] Security: clear the Immersive backlog, list TaskFlow fixes still open
- [ ] Job: apply to 1-2 roles with the public repo linked, count the week
- [ ] Optional: 90-second API demo in Swagger

## Day 44 - Sat 28 Nov - GATE 3
- [ ] Send the repo for grading and the auth questions aloud
- [ ] Fix every finding from me and your human reviewer
- [ ] Five-line retrospective on Phase 3
- [ ] Pre-read: OpenAPI-to-TypeScript generator docs (openapi-typescript or Orval), TanStack Query quick start
- [ ] **Ship:** Gate 3 passed, or a written list of what is left
- [ ] Security: one Immersive lab
- [ ] Job: message 1 person

## Day 45 - Sun 29 Nov - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, Gate 3 feedback
- [ ] Name Monday's deliverable

## Day 46 - Mon 30 Nov - React client: scaffold, typed client, routing
- [ ] `npm create vite@latest taskflow-web -- --template react-ts`. Add Tailwind, React Router, TanStack Query, React Hook Form, Zod
- [ ] Export the OpenAPI document, generate TypeScript types or a client. `apiClient` reading base URL from an env var
- [ ] Routes: `/login`, `/register`, `/projects` (protected), `/projects/:id`. Tailwind layout
- [ ] Call the API from the browser, watch the CORS preflight (OPTIONS) in the network tab
- [ ] **Ship:** app skeleton calling the API successfully
- [ ] Security: Immersive Labs reflected and stored XSS
- [ ] Job: apply to 2 roles
- [ ] Optional: dark mode toggle

## Day 47 - Tue 1 Dec - React client: authentication flow
- [ ] `/docs/adr-001-token-storage.md`: where tokens live and why. Simplest defensible choice: access token in memory plus refresh token in an httpOnly, Secure, SameSite cookie set by the API (needs a small API change)
- [ ] Login and register forms (React Hook Form + Zod), field errors from ProblemDetails
- [ ] Auth context, protected routes, silent refresh on 401, logout
- [ ] Test in the browser: expired token, wrong password, direct URL to a protected page
- [ ] **Ship:** login leads to the protected projects page
- [ ] Security: Immersive Labs how XSS steals tokens and what it means for your ADR
- [ ] Job: message 1 person
- [ ] Optional: "remember me" and write down its risk

## Day 48 - Wed 2 Dec - TanStack Query and the projects UI
- [ ] `QueryClient`, `useQuery` for the projects list, `useMutation` for create, update, delete with invalidation
- [ ] Projects list with paging and a create-project dialog with validation
- [ ] Loading, empty, error states for every request
- [ ] ProblemDetails errors next to the right fields
- [ ] **Ship:** projects CRUD in the UI
- [ ] Security: Immersive Labs CSRF, check whether your cookie settings make it a risk
- [ ] Job: apply to 2 roles
- [ ] Optional: debounced search on the projects list

## Day 49 - Thu 3 Dec - Tasks UI
- [ ] Project detail page: task list with status filter, sorting, paging. Create and edit task, assign user, attach tags
- [ ] Optimistic update for status change with rollback on error
- [ ] Accessibility pass: labels, visible focus, keyboard navigation, semantic HTML
- [ ] Refactor repeated code into hooks and small components
- [ ] **Ship:** tasks UI complete end to end
- [ ] Security: run `npm audit` and `dotnet list package --vulnerable`, fix or record each finding
- [ ] Job: message 1 person and follow up
- [ ] Optional: keyboard shortcuts for creating a task

---

# Week 8 (Days 50-56, Fri 4 - Thu 10 Dec)

Goal: front-end tests, Gate 4, containers, deployment pipeline, first Azure deployment.

## Day 50 - Fri 4 Dec - Front-end tests
- [ ] Vitest, React Testing Library, jest-dom, Mock Service Worker
- [ ] 8 tests: login validation, projects list from mocked API, empty state, error state, create-project success, create-project failure with field errors, protected route redirect, logout
- [ ] Tests read like specs and run in CI
- [ ] Notes: what each kind of test catches and how mocks lie
- [ ] **Ship:** 8 front-end tests green in CI
- [ ] Security: OWASP Top 10 review part 1 (A01-A05) against TaskFlow, one line each: where it applies, what you did, what is left
- [ ] Job: apply to 1-2 roles, count the week
- [ ] Optional: coverage report

## Day 51 - Sat 5 Dec - Playwright and GATE 4
- [ ] One Playwright test: log in, create a project, create a task, see it listed, against the local stack
- [ ] 3-minute recorded walkthrough: login, create project and task, network tab explaining each request
- [ ] Walk the Gate 4 rubric, send the repo and the recording
- [ ] Five-line retrospective
- [ ] **Ship:** Gate 4 submission
- [ ] Security: OWASP Top 10 review part 2 (A06-A10)
- [ ] Job: message 1 person
- [ ] Optional: second Playwright flow (task status change)

## Day 52 - Sun 6 Dec - Rest and weekly review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, Gate 4 feedback, the 3 deployment risks you fear most
- [ ] Name Monday's deliverable

## Day 53 - Mon 7 Dec - Docker I: the API image
- [ ] Multi-stage `Dockerfile` for the API (SDK build and publish, ASP.NET runtime). Non-root user, `.dockerignore`
- [ ] Build and run. Pass the connection string and JWT key as env vars. Hit `/health/ready`
- [ ] Notes: image layers, why multi-stage, why secrets must never be baked into an image
- [ ] Check the final image size, note what makes it big or small
- [ ] **Ship:** the API runs from a container image
- [ ] Security: container basics (non-root, minimal base image, no secrets in layers). Scan the image (`docker scout` or Trivy), note findings
- [ ] Job: apply to 2 roles
- [ ] Optional: compare image sizes after trimming

## Day 54 - Tue 8 Dec - Docker II: the whole stack
- [ ] Web `Dockerfile`: Node build stage, nginx stage with SPA fallback
- [ ] `docker-compose.yml` with `db` (volume, healthcheck), `api` (waits for healthy DB, applies migrations), `web`. Add `.env.example`
- [ ] From a clean clone `docker compose up` brings the whole app up and a user can log in and create a task
- [ ] Fix every README gap the clean-clone test exposes
- [ ] **Ship:** one-command local stack from a clean clone
- [ ] Security: `.env` git-ignored, `.env.example` has no real values, production secrets come from Key Vault
- [ ] Job: message 1 person
- [ ] Optional: compose profile for running tests

## Day 55 - Wed 9 Dec - Deployment pipeline and Azure decisions
- [ ] GitHub Actions on merge to `main`: build API and web images, tag with commit SHA, push to a registry (GHCR or ACR)
- [ ] Registry credentials in GitHub Actions secrets. Read the logs, confirm no secret is printed
- [ ] `/docs/adr-002-azure-target.md`: App Service or Container Apps for the API, where the web client goes. Pick the simpler option
- [ ] Create the Azure resource group. Set a budget alert before creating anything billable. Check your free credits or tiers
- [ ] **Ship:** images built and pushed by the pipeline, Azure target decided, budget alert set
- [ ] Security: least-privilege pipeline credentials, no long-lived admin keys
- [ ] Job: apply to 2 roles
- [ ] Optional: vulnerability scan step in the pipeline

## Day 56 - Thu 10 Dec - Azure deployment I: the API
- [ ] Provision the API host, managed PostgreSQL (or a DB container per the cut list), Key Vault
- [ ] Connection string and JWT signing key in Key Vault, referenced from app configuration
- [ ] Apply migrations to production in a controlled step (pipeline job or one-off task), not on every app start
- [ ] Deploy the API image. `https://<your-api>/health/ready` returns healthy
- [ ] **Ship:** the API is live on a public URL
- [ ] Security: one-page STRIDE threat model draft for TaskFlow, one line each (spoofing, tampering, repudiation, information disclosure, denial of service, elevation of privilege)
- [ ] Job: message 1 person and follow up
- [ ] Optional: alert for repeated 5xx responses

---

# Week 9 (Days 57-60, Fri 11 - Mon 14 Dec)

Goal: full app live, cold-build test passed, final gate submitted.

## Day 57 - Fri 11 Dec - Azure deployment II: web client and pipeline
- [ ] Deploy the web client (Static Web Apps or a container per your ADR). API CORS set to the production origin, client API base URL set to production
- [ ] Pipeline deploys on merge to `main`. Prove it: merge a small visible change through a PR and watch it go live
- [ ] Basic monitoring (Application Insights or log stream). Find one request's trace
- [ ] Smoke-test the live app from your phone: register, log in, create a project and a task
- [ ] **Ship:** the full-stack app is live and deploys from the pipeline
- [ ] Security: finalise the STRIDE threat model in `/docs`, add open items to the README as known risks
- [ ] Job: apply to 1-2 roles with the live URL, count the week
- [ ] Optional: custom domain, uptime check with an alert

## Day 58 - Sat 12 Dec - Cold-build test
Set a 4-hour timer. Documentation allowed. Tutorials not.
- [ ] Spec (ask for a different one if you want a surprise): "Signed-in users can see their tasks due in the next 7 days, sorted by due date and paged, on a new page."
- [ ] Build the endpoint, the migration (with an index if needed), unit and integration tests, and the UI page
- [ ] Merge through a PR so CI and deployment run, confirm it works on the live site
- [ ] Retrospective: where the 4 hours went, which concepts slowed you, what to revise
- [ ] **Ship:** feature merged, tested and deployed within 4 hours
- [ ] Security: review the new endpoint with your authorisation matrix and add its rows
- [ ] Job: message 1 person

## Day 59 - Sun 13 Dec - Rest and final review
- [ ] No coding. Rest and faith
- [ ] One-hour review: logs, cold-build retrospective, every claim you will make about yourself on Monday and its evidence
- [ ] Name Monday's deliverable

## Day 60 - Mon 14 Dec - GATE 5
- [ ] One-page case study: the problem, architecture diagram, key decisions and trade-offs, what broke, what you would change at 10x scale
- [ ] Polish every README. Pin the repos on GitHub. Update CV, LinkedIn and portfolio with the live app and case study
- [ ] Book or complete two mock interviews
- [ ] Honest self-assessment against the Gate 5 rubric, send everything for grading
- [ ] Decide the next 60 days: next certification, next skill, the one project that proves it
- [ ] **Ship:** Gate 5 submission pack
- [ ] Security: choose the next certification from what saved job ads actually ask for
- [ ] Job: apply with the case study and live app attached, message 3 people with the live link
- [ ] Optional: publish the case study as a blog post or LinkedIn article