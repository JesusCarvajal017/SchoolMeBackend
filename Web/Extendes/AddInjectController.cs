using Business.Implements.Auth;
using Business.Implements.Bases;
using Business.Implements.Commands.Security;
using Business.Implements.Querys.Security;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Data.Implements.Auth;
using Data.Implements.Commands;
using Data.Implements.Commands.Security;
using Data.Implements.Querys;
using Data.Implements.Querys.Security;
using Data.Implements.View;
using Data.Infrastructure.Interceptors;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
using Entity.Dtos.Security.UserRol;
using Entity.Model.Security;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;
using Utilities.Jwt;

namespace Web.Extendes
{
    public static class AddInjectController
    {
        public static IServiceCollection AddInject(this IServiceCollection services)
        {

            // ============================ Inyecciones genericas ============================ 

            // Coommand === Data
            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );

            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );

            // servicios === business
            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
                );
            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );


            // ============================  inyecciones concretas ============================ 

            // ================ QUERYS ================

            // QUERY DATA 
            services.AddScoped(
                typeof(IQuerys<RolFormPermission>),
                typeof(RolFormPermissionQueryData)
            );

            services.AddScoped(
                typeof(IQuerys<ModuleForm>),
                typeof(ModuleFormQueryData)
            );

            services.AddScoped(
                typeof(IQuerys<Person>),
                typeof(PersonQueryData)
            );

            // user - rol
            services.AddScoped<IQuerysUserRol, UserRolQueryData>();
            services.AddScoped<IQueryUserRolServices, UserRolQueryBusiness>();

            // user
            services.AddScoped<ICommandUser, UserCommandData>();
            services.AddScoped<ICommandUserServices, UserCommandBusines>();


            // ================ COMMANDS ================
            services.AddScoped(
                typeof(ICommands<User>),
                typeof(UserCommandData)
            );

            //services.AddScoped();

            services.AddScoped<AuthBusiness>();
            services.AddScoped<LoginData>();
            services.AddScoped<GenerateToken>();



            services.AddScoped<IGenericHerlpers, GenericHelpers>();
  
            services.AddScoped<LogginDbCommandsInterceptor>();
            services.AddScoped<ViewData>();



            return services;

        }
    }
}
