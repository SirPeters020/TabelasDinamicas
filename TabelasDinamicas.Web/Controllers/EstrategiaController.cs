using Microsoft.AspNetCore.Mvc;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EstrategiaController : ControllerBase
{
    private readonly IEstrategiaService _estrategiaService;

    public EstrategiaController(IEstrategiaService estrategiaService)
    {
        _estrategiaService = estrategiaService;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var estrategias = await _estrategiaService.Get();

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetId([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        var estrategias = await _estrategiaService.Get(id);

        if (estrategias == null) return NotFound(estrategias);

        return Ok(estrategias);
    }

    [HttpPost]
    public async Task<IActionResult> Add(EstrategiaPostViewModel model)
    {
        await _estrategiaService.Add(model);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id,  EstrategiaPostViewModel model)
    {
        if(id == Guid.Empty) return BadRequest();

        await _estrategiaService.Update(model, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (id == Guid.Empty) return BadRequest();

        await _estrategiaService.Delete(id);

        return Ok();
    }
}
