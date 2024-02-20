using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services) 
        {
            //Permite registrar automaticamento los mappeos que haga en esta biblioteca de clases
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //Las sentencias de validacion vendran dentro de esta biblioteca de clases
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //Esto nos permitirá hacer la referencia de proyecto
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
