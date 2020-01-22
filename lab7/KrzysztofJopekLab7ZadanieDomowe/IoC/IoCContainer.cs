using KrzysztofJopekLab7ZadanieDomowe.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.IoC
{
        public static class IoC
        {
            public static ApplicationDbContext ApplicationDbContext =>
                IoCContainer.Provider.GetService<ApplicationDbContext>();
        }

        public static class IoCContainer
        {
            public static ServiceProvider Provider { get; set; }
        }   
}
