using System.Collections.Generic;
using Abp.Application.Services;
using AutoMapper;

namespace ExtramileManager.Tasks
{
    /// <summary>
    /// Implements <see cref="ITaskAppService"/> to perform task related application functionality.
    /// 
    /// Inherits from <see cref="ApplicationService"/>.
    /// <see cref="ApplicationService"/> contains some basic functionality common for application services (such as logging and localization).
    /// </summary>
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        // These members set in constructor using constructor injection.

        public string hello()
        {
            return "a";
        }
    }
}