using App.Services;
using ConsoleLog.Services;
using Domain.Services;
using Infra.Services;

//Jeito tradicional de recuperar exceções personalizadas.

// Capturando exceções repositório.
try
{
    var repositoryService = new RepositoryService(-1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Capturando exceções application.
try
{
    var app = new AppService(-1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Capturando exceções Domain.
try
{
    var domainService = new DomainService(-1);
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Capturando exceções ConsoleLog.
try
{
    var consoleService = new ConsoleLogService(-1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Criação de método estático personalizado por namespace

var consoleLogService = new ConsoleLogService(2);
consoleLogService.GenericException();
