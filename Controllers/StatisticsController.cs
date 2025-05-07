using ApiAnalisisValores.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace ApiAnalisisValores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStadisticsService _stadisticsService;
        public StatisticsController(IStadisticsService stadisticsService)
        {
            _stadisticsService = stadisticsService;
        }

        [HttpGet]
        public ResponseDTO GetStadistics(RequestDTO requestDTO)
        {
            return _stadisticsService.GetStadistics(requestDTO);
        }
    }
}
