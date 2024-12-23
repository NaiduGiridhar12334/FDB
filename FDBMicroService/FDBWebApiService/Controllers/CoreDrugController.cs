﻿using FDBOrchestration.CoreDrug.Interface;
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
        
        [HttpGet("GetDispensableDrugs")]
        public async Task<IActionResult> GetDispensableDrugs(string DrugNameDesc = null)
        {
            try
            {
                var searchResults = await _coreDrugOrchestartion.GetDispensableDrugs(DrugNameDesc);

                // Check if the Items list in searchResults contains any matching items
                if (searchResults== null)
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

        [HttpGet("ERXDispensableDrugs")]
        public async Task<IActionResult> GetERXDispensableDrugs(string PrescribableDrugDesc = null)
        {
            try
            {
                var result = await _coreDrugOrchestartion.GetERXDispensableDrugs(PrescribableDrugDesc);

                if (result == null)
                {
                    return NotFound("No drugs found matching the search criteria.");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
