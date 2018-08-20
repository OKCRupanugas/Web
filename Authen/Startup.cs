using System.IO;
using System.Net;
using System.Text;
using Authen.Factory;
using Authen.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.FactoryExecutions;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;
using RupanugaCoreServices.SharedService;
using Swashbuckle.AspNetCore.Swagger;


namespace Authen
{
    public class Startup
    {
        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; // todo: get this from somewhere secure
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
            });
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("Data Source=localhost;Initial Catalog=ISKCON_OKC;Integrated Security=True"));

            services.AddDbContext<RupanugaOKCDBContext>(options =>
                options.UseSqlServer("Data Source=localhost;Initial Catalog=ISKCON_OKC;Integrated Security=True"));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "ISKCON OKC", Version = "v1" });
            });

            DIRegistration.RegisterServices(services);


            //services.addswag

            //services.AddSingleton<IJwtFactory, JwtFactory>();

            //// Register the ConfigurationBuilder instance of FacebookAuthSettings
            //services.Configure<FacebookAuthSettings>(Configuration.GetSection(nameof(FacebookAuthSettings)));

            //services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();

            //// jwt wire up
            //// Get options from app settings
            //var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            //// Configure JwtIssuerOptions
            //services.Configure<JwtIssuerOptions>(options =>
            //{
            //    options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
            //    options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            //});

            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidateIssuer = true,
            //    ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

            //    ValidateAudience = true,
            //    ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = _signingKey,

            //    RequireExpirationTime = false,
            //    ValidateLifetime = true,
            //    ClockSkew = TimeSpan.Zero
            //};

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            //}).AddJwtBearer(configureOptions =>
            //{
            //    configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    configureOptions.TokenValidationParameters = tokenValidationParameters;
            //    configureOptions.SaveToken = true;
            //});

            //// api user claim policy
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("ApiUser", policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
            //});

            //// add identity
            //var builder = services.AddIdentityCore<AppUser>(o =>
            //{
            //    // configure identity options
            //    o.Password.RequireDigit = false;
            //    o.Password.RequireLowercase = false;
            //    o.Password.RequireUppercase = false;
            //    o.Password.RequireNonAlphanumeric = false;
            //    o.Password.RequiredLength = 6;
            //});
            //builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            //builder.AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //services.AddAutoMapper();
            services.AddMvc();//.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseExceptionHandler(
                builder =>
                {
                    builder.Run(
                        async context =>
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                                var error = context.Features.Get<IExceptionHandlerFeature>();
                                if (error != null)
                                {
                                    //  context.Response.AddApplicationError(error.Error.Message);
                                    await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                                }
                            });
                });
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            //app.UseJwtBearerAuthentication();
            app.UseCors("AllowAll");
            app.UseMvc();
            app.Run(async(context)=>
            {
                await context.Response.WriteAsync("Hari Bol!!");
            });
            
            //app.UseAuthentication();
            //app.UseDefaultFiles();
            //app.UseStaticFiles();
            
        }
    }
}
