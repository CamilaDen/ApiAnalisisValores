using ApiAnalisisValores.DTO_s;
using MathNet.Numerics.Statistics;
using Service.Interfaces;

namespace Service.Implementations
{
    public class StatisticsService : IStatisticsService
    {
        public ResponseDTO CalculatStatistics(RequestDTO requestDTO)
        {
            if (requestDTO.Values == null || requestDTO.Values.Count == 0)
            {
                throw new ArgumentException("Values cannot be null or empty.");
            }

            var result = new ResponseDTO();

            result.Mean = requestDTO.Values.Mean();
            result.Median = Statistics.Median(requestDTO.Values);
            result.StandardDeviation = double.IsNaN(Statistics.StandardDeviation(requestDTO.Values)) || double.IsInfinity(Statistics.StandardDeviation(requestDTO.Values)) ? 0 
                : Statistics.StandardDeviation(requestDTO.Values);

            result.Variance = double.IsNaN(Statistics.Variance(requestDTO.Values)) || double.IsInfinity(Statistics.Variance(requestDTO.Values)) ? 0 
                : Statistics.Variance(requestDTO.Values);

            result.OutOfSpecCount = requestDTO.Values.Count(x => x < requestDTO.LowerLimit || x > requestDTO.UpperLimit);
           
            return result;
        }
    }
}
