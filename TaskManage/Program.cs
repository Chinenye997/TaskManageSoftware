var builder = WebApplication.CreateBuilder(args);// this means setting our projects up 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();// it send/channel each request to it resposible router.
builder.Services.AddSwaggerGen();// This is like a tester that we use to test all the action we created on the api.

var app = builder.Build();// This build all the service that have be added to this one up they. 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// this means to run the program if the app.Environment.IsDevelopment exsit else 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();// It help to redirect the api to their various rout and all

app.UseAuthorization();

app.MapControllers();// this means mapping differnt controller to their expartive endpoint and all.

app.Run();// means to run the program
