using Business.Implements.Auth;
using Business.Implements.Bases;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Data.Implements.Auth;
using Data.Implements.Commands;
using Data.Implements.Querys;
using Data.Implements.Security;
using Data.Implements.View;
using Data.Infrastructure.Interceptors;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
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
            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );

            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );

            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
                );
            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );



            // ============================  inyecciones concretas ============================ 

            // ======== QUERYS ========

            services.AddScoped(
                typeof(IQuerys<RolFormPermission>),
                typeof(RolFormPermissionData)
            );

            services.AddScoped(
                typeof(IQuerys<ModuleForm>),
                typeof(ModuleFormData)
            );


            // ======== COMMANDS ========
            services.AddScoped(
                typeof(ICommands<User>),
                typeof(UserData)
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
