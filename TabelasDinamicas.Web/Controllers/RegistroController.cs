using Microsoft.AspNetCore.Mvc;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistroController : ControllerBase
{
    private readonly IRegistrosService _registroService;

    public RegistroController(IRegistrosService registroService)
    {
        _registroService = registroService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var estrategias = await _registroService.Get();

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetId([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        var estrategias = await _registroService.Get(id);

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpPost]
    public async Task<IActionResult> Add(RegistroPostViewModel model)
    {
        await _registroService.Add(model);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, RegistroPostViewModel model)
    {
        if (id == Guid.Empty) return BadRequest();

        await _registroService.Update(model, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        await _registroService.Delete(id);

        return Ok();
    }
}
