using Microsoft.AspNetCore.Mvc;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class TabelaController : ControllerBase
{
    private readonly ITabelasService _tabelaService;

    public TabelaController(ITabelasService tabelaService)
    {
        _tabelaService = tabelaService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var estrategias = await _tabelaService.Get();

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetId([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        var estrategias = await _tabelaService.Get(id);

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TabelasPostViewModel model)
    {
        await _tabelaService.Add(model);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, TabelasPostViewModel model)
    {
        if (id == Guid.Empty) return BadRequest();

        await _tabelaService.Update(model, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        await _tabelaService.Delete(id);

        return Ok();
    }
}
