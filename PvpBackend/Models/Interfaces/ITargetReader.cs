namespace PvpBackend.Models.Interfaces;

public interface ITargetReader
{
    ReadOnlySpan<int> GetTargetIndicesReadOnly();
}