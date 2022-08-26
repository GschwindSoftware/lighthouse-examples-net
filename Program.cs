// Copyright 2021 🔵🔵🔴🔵 Gschwind Software GmbH All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE file.

using Gschwind.Lighthouse.Example;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

// Konfiguration

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

// Abhängigkeiten

var services = new ServiceCollection()
    .AddLighthouseApi(config)
    .AddLogging(configure =>
        configure.AddSimpleConsole()
    )
    .AddSingleton<Quickstart>()
    .AddSingleton<TestPlan>()
    .AddSingleton<ExternalClientDataProvider>()
    .BuildServiceProvider();

// Beispielanwendung ausführen

await services
    .GetRequiredService<Quickstart>()
    .RunAsync();
