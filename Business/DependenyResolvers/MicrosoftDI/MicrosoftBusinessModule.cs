using Microsoft.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using FluentValidation;
using Business.Validators;
using DTOs.Concrete;

namespace Business.DependencyResolvers.MicrosoftDI
{
	public static class MicrosoftBusinessModule
	{
		public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("Connection")));

			services.AddScoped<IIlanService, IlanManager>();
			services.AddScoped<IIlanDal, IlanDal>();

			services.AddScoped<IKaynakService, KaynakManager>();
			services.AddScoped<IKaynakDal, KaynakDal>();

			services.AddScoped<IValidator<IlanForUpdateDto>, IlanForUpdateValidator>();
			services.AddScoped<IValidator<KaynakForUpdateDto>, KaynakForUpdateValidator>();
		}
	}
}
