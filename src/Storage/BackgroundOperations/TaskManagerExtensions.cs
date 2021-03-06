﻿using Microsoft.Extensions.DependencyInjection;
using SenseNet.BackgroundOperations;
using SenseNet.TaskManagement.Core;

// ReSharper disable once CheckNamespace
namespace SenseNet.Extensions.DependencyInjection
{
    public static class TaskManagerExtensions
    {
        public static IServiceCollection AddSenseNetTaskManager(this IServiceCollection services)
        {
            return services.AddSenseNetTaskManager<TaskManagerBase>();
        }
        public static IServiceCollection AddSenseNetTaskManager<T>(this IServiceCollection services) where T : class, ITaskManager
        {
            services.AddSingleton<ITaskManager, T>();

            return services;
        }
    }
}
