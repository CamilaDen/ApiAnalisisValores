using ApiAnalisisValores.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace ApiAnalisisValores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _stadisticsService;
        public StatisticsController(IStatisticsService stadisticsService)
        {
            _stadisticsService = stadisticsService;
        }

        [HttpPost]
        public ResponseDTO CalculatStadistics(RequestDTO requestDTO)
        {
            return _stadisticsService.CalculatStatistics(requestDTO);
        }
    }
}
