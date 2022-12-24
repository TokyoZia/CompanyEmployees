using AutoMapper;
using CompanyEmployees.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using Repository;

namespace CompanyEmployees;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
            "/nlog.config"));
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.ConfigureCors();
        services.ConfigureIISIntegration();
        services.ConfigureLoggerService();
        services.ConfigureSqlContext(Configuration);
        services.ConfigureRepositoryManager();
        services.AddAutoMapper(typeof(Startup));
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.ConfigureVersioning();
        services.AddAuthentication();
        services.ConfigureIdentity();
        services.ConfigureJWT(Configuration);
        services.AddScoped<IAuthenticationManager, AuthenticationManager>();
        services.ConfigureSwagger();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
ILoggerManager logger)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }
        app.ConfigureExceptionHandler(logger);
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseCors("CorsPolicy");
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.All
        });
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI(s =>
        {
            s.SwaggerEndpoint("/swagger/v1/swagger.json", "Code Maze API v1");
         
        });
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>().ForMember(c => c.FullAddress, opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            CreateMap<Player, PlayerDto>();
            CreateMap<Comand, ComandDto>();
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}