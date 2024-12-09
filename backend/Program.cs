using System.Text.Json.Serialization;
using Markbook;
using Markbook.SeedData;
using Markbook.Services;
using Microsoft.EntityFrameworkCore;


public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.WithOrigins(builder.Configuration["Cors:Frontend"]!).AllowAnyMethod().AllowAnyHeader();
            });
        });

        builder
            .Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

        builder.Services.AddTransient<IStudentService, StudentService>();
        builder.Services.AddTransient<IAssessmentService, AssessmentService>();


        builder.Services.AddDbContext<MarkbookContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres"));
        });

        builder.Services.AddTransient<SeedStudents>();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen();

        builder.Services.AddControllers();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            using (var scope = app.Services.CreateScope())
            {
                var studentSeeder = scope.ServiceProvider.GetService<SeedStudents>();
                studentSeeder.SeedStudent();
            }
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors();
        app.UseHttpsRedirection();
        app.MapControllers();   
        app.Run();
    }
}
