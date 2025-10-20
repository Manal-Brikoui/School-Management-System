using Microsoft.EntityFrameworkCore;
using School.Application.Interfaces;
using School.Application.Services;
using School.Infrastructure.Data;
using School.Infrastructure.Repositories;
using School.Application.Mapping;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString,
        x => x.MigrationsAssembly("School.Infrastructure") // Très important pour les migrations
    ));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<IGradeRepository, GradeRepository>();


builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<IGradeService, GradeService>();


builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
