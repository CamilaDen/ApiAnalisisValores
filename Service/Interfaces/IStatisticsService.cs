using ApiAnalisisValores.DTO_s;

namespace Service.Interfaces
{
    public interface IStatisticsService
    {
       ResponseDTO CalculatStatistics(RequestDTO requestDTO);
    }
}
