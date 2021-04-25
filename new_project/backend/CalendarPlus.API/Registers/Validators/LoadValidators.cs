using CalendarPlus.API.Middlewares;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers.Validators
{
    public static class LoadValidators
    {
        public static void Load(IServiceCollection services)
        {
            services
                .AddMvc(options =>
                {
                    options.Filters.Add(new ModelValidationFilter());
                })
                .AddFluentValidation(setup =>
                {
                    setup.RegisterValidatorsFromAssemblyContaining<Startup>();
                });
        }
    }
}