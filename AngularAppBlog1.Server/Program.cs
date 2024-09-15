using BUSINESS.Contracts;
using BUSINESS.Contracts;
using BUSINESS.Implemetations;
using DATA.Db;
using DATA.Implemetations;
using Microsoft.Extensions.Configuration;
using SHARED.DataContracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICommentBusinessEngine, CommentBusinessEngine>();
builder.Services.AddScoped<IAuthBusinessEngine, AuthBusinessEngine>();
builder.Services.AddScoped<ITopicBusinessEngine, TopicBusinessEngine>();
builder.Services.AddScoped<IUserBusinessEngine, UserBusinessEngine>();
builder.Services.AddScoped<IUserSettingsRepository, UserSettingsRepository>();
builder.Services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();

builder.Services.AddDbContext<BlogAppDbContext>();
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();


app.Run();
