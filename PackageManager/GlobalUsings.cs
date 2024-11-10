global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using PackageManager.Models;
global using PackageManager.Presentation;
global using PackageManager.DataContracts;
global using PackageManager.DataContracts.Serialization;
global using PackageManager.Services.Caching;
global using PackageManager.Services.Endpoints;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using Color = Windows.UI.Color;
[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]
