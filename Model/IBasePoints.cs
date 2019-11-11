namespace GurpsCC.Model
{
    public interface IBasePoints
    {
        int MaxDisadvantagePoints { get; set; }
        int MaxPoints { get; set; }
        int UnspentPoints { get; set; }
        int UsedDisadvantagePoints { get; set; }
        int UsedPoints { get; set; }
    }
}