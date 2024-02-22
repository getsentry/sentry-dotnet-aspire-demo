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

# Extra for experts

Once you're familiar with the basic AspireWithSentry sample, you might like to enable a couple of Sentry's other
features:

### Upload Debug Symbols and Source Maps

If you upload debug symbols and source maps to Sentry, you'll be able to see the original source code and detailed 
stack traces. 

See the [Uploading Files docs](https://docs.sentry.io/platforms/dotnet/guides/aspnetcore/data-management/debug-files/upload/) for details.  

### Replays

Replays can be enabled with a loader script in `AspireWithSentry.Web/Components/Layout/MainLayout.razor`. Check the 
Replays dashboard in your Sentry project for more info about that.

### Check out more samples

We can't cover everything in a single sample project, but there are [loads more samples](https://github.com/getsentry/sentry-dotnet/tree/main/samples) available in the .NET SDK repo.
