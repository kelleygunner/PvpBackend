namespace PvpBackend.Models.Interfaces;

public interface IPositionWrite
{
    Span<float> GetXWritable();
    Span<float> GetYWritable();
}