namespace PvpBackend.Models.Interfaces;

public interface IPositionReader
{
    ReadOnlySpan<float> GetXReadOnly();
    ReadOnlySpan<float> GetYReadOnly();
    
    ReadOnlySpan<float> GetSpeedReadOnly();
}