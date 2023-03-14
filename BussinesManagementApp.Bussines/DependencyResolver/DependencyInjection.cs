using BussinessManagementApp.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BussinessManagementApp.Entities.IdentityEntities;
using BussinesManagementApp.Bussines.Services;
using BussinessManagementApp.DataAccess.Constants;
using FluentValidation;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Bussines.Validations.FluentValidation.CustomerValidations;
using BussinesManagementApp.Bussines.Validations.FluentValidation.CustomerOrderValidations;
using BussinesManagementApp.Bussines.Validations.FluentValidation.ProductValidations;
using BussinesManagementApp.Bussines.Validations.FluentValidation.SupplierValidations;
using BussinesManagementApp.Bussines.Validations.FluentValidation.SupplierOrderValidations;
using BussinesManagementApp.Bussines.Validations.FluentValidation.WarehouseProductValidations;
using BussinesManagementApp.Bussines.Mapper.AutoMapper;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.DataAccess.UnitOfWork;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos.ReportDtos;
using BussinesManagementApp.Bussines.Validations.FluentValidation.ReportModelValidations;
using BussinesManagementApp.Bussines.Helpers;

namespace BussinesManagementApp.Bussines.DependencyResolver
{
    public static class DependencyInjection
    {
        public static void DependencyExtension(this IServiceCollection services ,string ConnectionString , string IdentityConnectionString)
        {

            services.AddDbContext<BussinesManagementDbContext>(x => {
                x.UseSqlServer(
                    ConnectionString
                    //"server=.;Database=BussinesManagementDb; integrated security=true;"
                    //"server=sql.bsite.net\\MSSQL2016;Database=sfatektas2_BusinessManagementDb; User Id=sfatektas2_BusinessManagementDb;Password=Tr123456;"
                    ); },ServiceLifetime.Transient); //TODO appconfig 

            //sanal server ile bahsedilen kavramın detylandırılmasını iste !

            services.AddDbContext<IdentityDb>(x => x.UseSqlServer(
                //"server=.;Database=IdentityDb; integrated security=true;"
                IdentityConnectionString
                ));
            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                //password Options
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = true;
                opt.Password.RequireNonAlphanumeric= false;
                //Lockout Options
                opt.Lockout.MaxFailedAccessAttempts = IdentityDbOptionsConstant.MaxFailedAccessAttempts;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                opt.Lockout.AllowedForNewUsers = true;

                //Sıgin Options
                opt.SignIn.RequireConfirmedPhoneNumber = false;
            }).AddEntityFrameworkStores<IdentityDb>();

            //AutoMapper
            
            services.AddAutoMapper(conf =>
            {
                conf.AllowNullCollections = true;
                conf.AddProfile(new CustomerProfile());
                conf.AddProfile(new CustomerOrderProfile());
                conf.AddProfile(new OtherEntitesProfile());
                conf.AddProfile(new ProductProfile());
                conf.AddProfile(new SupplierProfile());
                conf.AddProfile(new SupplierOrderProfile());
                conf.AddProfile(new WarehouseProductProfile());
            });
            //Fluent Validation

                //Customer
            services.AddTransient<IValidator<CustomerCreateDto>, CustomerCreateDtoValidator>();
            services.AddTransient<IValidator<CustomerUpdateDto>, CustomerUpdateDtoValidator>();
                //CustomerOrder
            services.AddTransient<IValidator<CustomerOrderCreateDto>, CustomerOrderCreateDtoValidator>();
            services.AddTransient<IValidator<CustomerOrderUpdateDto>, CustomerOrderUpdateDtoValidator>();
                //Product
            services.AddTransient<IValidator<ProductCreateDto>, ProductCreateDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
                //Supplier
            services.AddTransient<IValidator<SupplierCreateDto>, SupplierCreateDtoValidator>();
            services.AddTransient<IValidator<SupplierUpdateDto>, SupplierUpdateDtoValidator>();
                //SupplierOrder
            services.AddTransient<IValidator<SupplierOrderCreateDto>, SupplierOrderCreateValidator>();
            services.AddTransient<IValidator<SupplierOrderUpdateDto>, SupplierOrderUpdateValidator>();
            //Warehouse
            services.AddTransient<IValidator<WarehouseProductCreateDto>, WarehouseProductCreateDtoValidator>();
            services.AddTransient<IValidator<WarehouseProductUpdateDto>, WarehouseProductUpdateDtoValidator>();
            // ReportModel
            services.AddTransient<IValidator<ReportQueryDto>, ReportQueryDtoValidator>();


            //DI
            services.AddTransient<IUow, Uow>();
            //services
            services.AddScoped<IdentityService>();
            services.AddTransient<ISupplierService,SupplierService>();
            services.AddTransient<ICustomerService,CustomerService>();
            services.AddTransient<IProductService,ProductService>();
            services.AddTransient<ISupplierOrderService , SupplierOrderService>();
            services.AddTransient<IWarehouseProductService , WarehouseProductService>();
            services.AddTransient<ICustomerOrderService , CustomerOrderService>();
            services.AddScoped<IReportService , ReportService>();
        }
    }
}
