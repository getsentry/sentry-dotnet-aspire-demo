# Sentry Aspire .NET Sample

This sample .NET application demonstrates how Sentry can be used to instrument .NET Aspire solutions.

## Prerequisites

You'll need to have the Aspire workload and tooling installed. 

See [Aspire documentation](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/setup-tooling?tabs=visual-studio)
for more information.

## Instructions

The sample is **_almost_** ready to run... the only thing you need to provide is the DSN for a Sentry project. 

You can [get a free Sentry account here](https://sentry.io/signup/). Create a new ASP.NET Core project in Sentry, and then modify the 
following code in `AspireWithSentry.ServiceDefaults/Extensions.cs`

```csharp
throw new NotImplementedException(
    "Supply a valid DSN below and remove this exception. See the README.md for help.");
// TODO: Configure the DSN of your Sentry project below
// options.Dsn = "... your DSN here ...";  // Replace this!!!
```

You can remove all of that code and replace it with:
    
```csharp
options.Dsn = "<the dsn that from the settings for your Sentry project...>";
```

Once you've done that, you can run `AspireWithSentry.AppHost` to power up the Aspire + Sentry distributed solution 😎