var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policy =>
{

    //policy.AddDefaultPolicy(bydefault =>
    //{
    //    bydefault.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    //});

    policy.AddPolicy("adminPolicy", adminPolicy =>
    {
        string[] methods = new string[2];
        methods[0] = "GET";
        methods[1] = "POST";

        string[] sitesAllowed = new string[1];
        sitesAllowed[0] = "http://localhost:4200";

        string[] allowedFormat = new string[1];
        allowedFormat[0] = "application/json";

        adminPolicy.WithOrigins(sitesAllowed);
        adminPolicy.WithHeaders(allowedFormat);
        adminPolicy.WithMethods(methods);
    });

});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
