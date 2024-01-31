// Global using directives

global using AutoMapper;
global using BeHeroes.CodeOps.Abstractions.Aggregates;
global using BeHeroes.CodeOps.Abstractions.Commands;
global using BeHeroes.CodeOps.Abstractions.Data;
global using BeHeroes.CodeOps.Abstractions.Events;
global using BeHeroes.CodeOps.Abstractions.Repositories;
global using BeHeroes.CodeOps.Abstractions.Strategies;
global using BeHeroes.CodeOps.Infrastructure.EntityFramework;
global using BeHeroes.CodeOps.Infrastructure.EntityFramework.Repositories;
global using BeHeroes.CodeOps.Infrastructure.Kafka;
global using BeHeroes.CodeOps.Infrastructure.Kafka.Strategies;
global using BeHeroes.CodeOps.Security.Policies;
global using Confluent.Kafka;
global using Confluent.Kafka.Admin;
global using Heimdall.Templates.DotNet.Microservice.Application;
global using Heimdall.Templates.DotNet.Microservice.Application.Events.Domain;
global using Heimdall.Templates.DotNet.Microservice.Application.Telemetry;
global using Heimdall.Templates.DotNet.Microservice.Domain.Aggregates;
global using Heimdall.Templates.DotNet.Microservice.Domain.Repositories;
global using Heimdall.Templates.DotNet.Microservice.Domain.ValueObjects;
global using Heimdall.Templates.Dotnet.Microservice.Infrastructure.EntityFramework;
global using Heimdall.Templates.Dotnet.Microservice.Infrastructure.EntityFramework.Repositories;
global using Heimdall.Templates.Dotnet.Microservice.Infrastructure.Kafka.Strategies;
global using MediatR;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Options;
global using Microsoft.Identity.Client;
global using Microsoft.Identity.Client.AppConfig;
global using Npgsql;
global using Metrics = Heimdall.Templates.DotNet.Microservice.Application.Telemetry.Metrics;
global using OpenTelemetry.Trace;
global using OpenTelemetry.Metrics;
global using OpenTelemetry.Logs;
global using System.Diagnostics.Metrics;
global using System.Linq.Expressions;
global using System.Net.Http.Headers;
global using System.Reflection;
global using System.Security.Cryptography;
global using System.Security.Cryptography.X509Certificates;
global using System.Text.Json;