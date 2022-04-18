using Fiap.Smarthealth.Application.PostoSaude;

namespace Fiap.Smarthealth.Api.Actions.PostoSaudeEndpoint;

public static class PostoSaudeEndpoint
{
    public static void MapPostoSaudeEndpoint(this WebApplication? app)
    {
        // LIST        
        app!.MapGet("/posto", async (IPostoSaudeService _postoSaudeAppService) =>
            await _postoSaudeAppService.GetAllAsync())
        .Produces<List<PostoSaudeDTO>>(StatusCodes.Status200OK)
        .WithName("GetPostoSaude")
        .WithTags("PostoSaude");

        // GET
        app!.MapGet("/posto/{id}", async (IPostoSaudeService _postoSaudeAppService, Guid id) =>
        {
            var result = await _postoSaudeAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<PostoSaudeDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetPostoSaudeById")
        .WithTags("PostoSaude");

        // POST
        app!.MapPost("/posto", async (IPostoSaudeService _postoSaudeAppService, PostoSaudeDTO postoSaude) =>
        {
            var result = await _postoSaudeAppService.CreateAsync(postoSaude);

            return result != null
            ? Results.CreatedAtRoute("GetPostoSaudeById", new { id = result.Id }, postoSaude)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<PostoSaudeDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostPostoSaude")
        .WithTags("PostoSaude");

        // UPDATE
        app!.MapPut("/posto/{id}", async (IPostoSaudeService _postoSaudeAppService, Guid id, PostoSaudeDTO postoSaude) =>
        {
            var result = await _postoSaudeAppService.UpdateAsync(postoSaude);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutPostoSaude")
        .WithTags("PostoSaude");

        // DELETE
        app!.MapDelete("/posto/{id}", async (IPostoSaudeService _postoSaudeAppService, Guid id) =>
            await _postoSaudeAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeletePostoSaude")
        .WithTags("PostoSaude");
    }
}
