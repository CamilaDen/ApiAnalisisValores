namespace ApiAnalisisValores.DTO_s
{
    public class RequestDTO
    {
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }
        public List<double> Values { get; set; } = new();
    }
}
