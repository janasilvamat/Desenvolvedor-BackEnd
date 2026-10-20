using Banco.Classes.Models.Contextos;

var builder = WebApplication.CreateBuilder(args);

//Criação do Banco
ContextoConta contexto = new ContextoConta();
contexto.Database.EnsureCreated();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes => 
{
    opcoes.SwaggerDoc("Versão 1", new Microsoft.OpenApi.OpenApiInfo
    {
        Title = "API de Contas Bancárias",
        Version = "Versão 1",
        Description = "API para gerenciar contas bancárias, permitindo operações como criação, consulta, atualização e exclusão de contas.",
        Contact = new Microsoft.OpenApi.OpenApiContact
        {
            Name = "Jana",
            Email = "janainasilvamat@gmail.com",
            Url = new Uri("https://github.com/janasilvamat")
        }
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //swagger é uma ferramenta para documentar e testar APIs
    app.MapOpenApi();
    app.UseSwagger();//usar documentação do swagger

    app.UseSwaggerUI( c =>
    {
        c.SwaggerEndpoint("/swagger/Versão 1/swagger.json", "API de Contas Bancárias");
        c.DocumentTitle = "Documentação da API de Contas Bancárias";
    }
    );//usar interface do swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
