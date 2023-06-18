using Microsoft.EntityFrameworkCore;
using MinimalApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("gamedb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/character", async (DataContext context) => Results.Ok(await context.Characters.ToListAsync()));

app.MapGet("/character/{id}", async (DataContext context, int id) => await context.Characters.FindAsync(id)
    is Character character ?
    Results.Ok(character) :
    Results.NotFound("Character not found!"));

app.MapPost("/character", async (DataContext context, Character request) =>
{
    try
    {
        await context.Characters.AddAsync(request);
        await context.SaveChangesAsync();
        return Results.Ok(request);
    }
    catch
    {
        return Results.StatusCode(500);
    }
});

app.MapPut("/character/{id}", async (DataContext context, int id, Character request) =>
{
    try
    {
       var character = await context.Characters.FindAsync(id);

       if (character == null) return Results.NotFound("Character not found!");

       character.Name = request.Name;
       character.Description = request.Description;
       character.Height = request.Height;
       character.Power = request.Power;
       character.Blood = request.Blood;
       character.Birthday = request.Birthday;

       await context.SaveChangesAsync();

       return Results.Ok(request);
    }
    catch
    {
        return Results.StatusCode(500);
    }
});

app.MapDelete("/charater/{id}", async (DataContext context, int id) =>
{
    try
    {
        var character = await context.Characters.FindAsync(id);

        if (character == null) return Results.NotFound("Character not found!");

        context.Characters.Remove(character);
        await context.SaveChangesAsync();

        return Results.Ok(id);
    }
    catch
    {
        return Results.StatusCode(500);
    }
});


app.Run();

