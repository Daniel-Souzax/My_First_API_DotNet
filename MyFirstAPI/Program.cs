using MyFirstAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting(option => option.LowercaseUrls = true);

var teste = builder.Configuration.GetSection("MyClass").Get<MyClass>();
var testeNumber = builder.Configuration.GetSection("MyClass").GetSection("Number").Get<int>();
var testeSimplificado = builder.Configuration.GetValue<int>("MyClass:Number");
var testeJson = builder.Configuration.GetSection("MyClass").GetSection("Prop1").Value;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
