using FDBOrchestration.CoreDrug.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FDBWebApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoreDrugController : ControllerBase
    {
        public readonly ICoreDrugOrchestration _coreDrugOrchestartion;
        public CoreDrugController(ICoreDrugOrchestration coreDrugOrchestartion)
        {
            _coreDrugOrchestartion = coreDrugOrchestartion;
        }
        [HttpGet("GetDispensableGenerics")]
        public async Task<IActionResult> GetDispensableGenerics(string DrugNameDesc = null)
        {
            try
            {
                var searchResults = await _coreDrugOrchestartion.GetDispensableGenerics(DrugNameDesc);

                // Check if the Items list in searchResults contains any matching items
                if (searchResults.Items == null || !searchResults.Items.Any())
                {
                    return NotFound("No drugs found matching the search criteria.");
                }

                return Ok(searchResults);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
