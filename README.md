# Sentry Aspire .NET Sample

This sample .NET application demonstrates how Sentry can be used to instrument .NET Aspire solutions.

## Prerequisites

You'll need to have the Aspire workload and tooling installed. 

See [Aspire documentation](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/setup-tooling?tabs=visual-studio)
for more information.

## Instructions

The sample is **_almost_** ready to run... the only thing you need to provide is the DSN for a Sentry project. 

You can [get a free Sentry account here](https://sentry.io/signup/). When you create a new project in Sentry, you'll be 
asked to choose a platform. Choose "ASP.NET Core", then take the DSN that you get and us it to uncomment and change the
following line in `AspireWithSentry.ServiceDefaults/Extensions.cs`
```csharp
// options.Dsn = "... your DSN here ...";  // Replace this!!!
```

Once you've done that, you can run `AspireWithSentry.AppHost` to power up the Aspire + Sentry distributed solution 😎