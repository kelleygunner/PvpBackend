using PvpBackend.Models.Interfaces;

namespace PvpBackend.Models;

public class GameRoom : IPositionReader, IPositionWrite, ITargetReader
{
    public ReadOnlySpan<float> GetXReadOnly()
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<float> GetYReadOnly()
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<float> GetSpeedReadOnly()
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<int> GetTargetIndicesReadOnly()
    {
        throw new NotImplementedException();
    }

    public Span<float> GetXWritable()
    {
        throw new NotImplementedException();
    }

    public Span<float> GetYWritable()
    {
        throw new NotImplementedException();
    }
}