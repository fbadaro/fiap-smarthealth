using Fiap.Smarthealth.Application.Familia;

namespace Fiap.Smarthealth.Api.Actions.FamiliaEndpoint;

public static class FamiliaEndpoint
{
    public static void MapFamiliaEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/familia", async (IFamiliaService _familiaAppService) =>
            await _familiaAppService.GetAllAsync())
        .Produces<List<FamiliaDTO>>(StatusCodes.Status200OK)
        .WithName("GetFamilia")
        .WithTags("Familia");

        // GET
        app!.MapGet("/familia/{id}", async (IFamiliaService _familiaAppService, Guid id) =>
        {
            var result = await _familiaAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<FamiliaDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetFamiliaById")
        .WithTags("Familia");

        // POST
        app!.MapPost("/familia", async (IFamiliaService _familiaAppService, FamiliaDTO familia) =>
        {
            var result = await _familiaAppService.CreateAsync(familia);

            return result != null            
            ? Results.CreatedAtRoute("GetFamiliaById", new { id = result.Id }, familia)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<FamiliaDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostFamilia")
        .WithTags("Familia");

        // UPDATE
        app!.MapPut("/familia/{id}", async (IFamiliaService _familiaAppService, Guid id, FamiliaDTO familia) =>
        {
            var result = await _familiaAppService.UpdateAsync(familia);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutFamilia")
        .WithTags("Familia");

        // DELETE
        app!.MapDelete("/familia/{id}", async (IFamiliaService _familiaAppService, Guid id) =>
            await _familiaAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)        
        .WithName("DeleteFamilia")
        .WithTags("Familia");
    }
}
