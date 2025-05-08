namespace ApiAnalisisValores.DTO_s
{
    public class ResponseDTO
    {
        public double Mean { get; set; }
        public double Median { get; set; }
        public double StandardDeviation { get; set; }
        public double Variance { get; set; }
        public int OutOfSpecCount { get; set; }
    }
}
