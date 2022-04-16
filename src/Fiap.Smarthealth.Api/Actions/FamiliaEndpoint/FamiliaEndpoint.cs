using Fiap.Smarthealth.Application.Familia;

namespace Fiap.Smarthealth.Api.Actions.FamiliaEndpoint;

public static class FamiliaEndpoint
{
    public static void MapFamiliaEndpoint(this WebApplication? app)
    {
        app!.MapGet("/familia", async (IFamiliaService _familiaAppService) =>
            await _familiaAppService.GetAllAsync())
        .WithName("GetFamilia")
        .WithTags("Familia");

        app!.MapPost("/familia", async (IFamiliaService _familiaAppService, FamiliaDTO familia) =>            
            await _familiaAppService.CreateAsync(familia))
        .Produces<FamiliaDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostFamilia")
        .WithTags("Familia");

        app!.MapDelete("/fornecedor/{id}", async (IFamiliaService _familiaAppService, Guid id) =>
            await _familiaAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)        
        .WithName("DeleteFamilia")
        .WithTags("Familia");
    }
}
