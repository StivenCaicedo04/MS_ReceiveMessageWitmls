using MS_ReceiveMessageWitmls.Kafka;
using MS_ReceiveMessageWitmls.Service;
using MS_ReceiveMessageWitmls.Service.Interfaces;
using MS_ReceiveMessageWitmls.Utils;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<KafkaProducerService>();
builder.Services.AddTransient<IGetCapService, GetCapService>();
builder.Services.AddTransient<IGetFromStoreService, GetFromStoreService>();
builder.Services.AddTransient<IXmlSerializerHelper, XmlSerializerHelper>();
builder.Services.AddSingleton<IWitsmlServerReceive, WitsmlServerReceive>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Configura el middleware SOAP aquí
app.UseSoapEndpoint<IWitsmlServerReceive>(
    "/WitsmlService.svc",    // Ruta del servicio
    new SoapEncoderOptions() // Opciones del codificador SOAP
);

app.UseAuthorization();

app.MapControllers();

app.Run();