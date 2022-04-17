using Fiap.Smarthealth.Application.AgenteSaude;

namespace Fiap.Smarthealth.Api.Actions.AgenteSaudeEnpoint;

public static class AgenteSaudeEndpoint
{
    public static void MapAgenteSaudeEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/agente", async (IAgenteSaudeService _agenteSaudeAppService) =>
            await _agenteSaudeAppService.GetAllAsync())
        .Produces<List<AgenteSaudeDTO>>(StatusCodes.Status200OK)
        .WithName("GetAgenteSaude")
        .WithTags("AgenteSaude");

        // GET
        app!.MapGet("/agente/{id}", async (IAgenteSaudeService _agenteSaudeAppService, Guid id) =>
        {
            var result = await _agenteSaudeAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<AgenteSaudeDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetAgenteSaudeById")
        .WithTags("AgenteSaude");

        // POST
        app!.MapPost("/agente", async (IAgenteSaudeService _agenteSaudeAppService, AgenteSaudeDTO agenteSaude) =>
        {
            var result = await _agenteSaudeAppService.CreateAsync(agenteSaude);

            return result != null
            ? Results.CreatedAtRoute("GetAgenteSaudeById", new { id = result.Id }, agenteSaude)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<AgenteSaudeDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostAgenteSaude")
        .WithTags("AgenteSaude");

        // UPDATE
        app!.MapPut("/agente/{id}", async (IAgenteSaudeService _agenteSaudeAppService, Guid id, AgenteSaudeDTO agenteSaude) =>
        {
            var result = await _agenteSaudeAppService.UpdateAsync(agenteSaude);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutAgenteSaude")
        .WithTags("AgenteSaude");

        // DELETE
        app!.MapDelete("/agente/{id}", async (IAgenteSaudeService _agenteSaudeAppService, Guid id) =>
            await _agenteSaudeAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteAgenteSaude")
        .WithTags("AgenteSaude");
    }
}
