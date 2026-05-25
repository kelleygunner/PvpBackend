using PvpBackend.Models;
using PvpBackend.Models.Interfaces;
using PvpBackend.Systems.Interfaces;

namespace PvpBackend.Systems;

public class MovementSystem : IGameSystem
{
    public void Update(GameRoom gameRoom, float deltaTime)
    {
        var positionReader = gameRoom as IPositionReader;
        var positionWriter = gameRoom as IPositionWrite;

        var targetReader = gameRoom as ITargetReader;

        var xWritable = positionWriter.GetXWritable();
        var yWritable = positionWriter.GetYWritable();
        var xPositions = positionReader.GetXReadOnly();
        var yPositions = positionReader.GetYReadOnly();
        var speeds = positionReader.GetSpeedReadOnly();
        var targets = targetReader.GetTargetIndicesReadOnly();

        for (var i = 0; i < xPositions.Length; ++i)
        {
            var targetIndex = targets[i];
            if (targetIndex < 0 || targetIndex >= xPositions.Length)
                continue;
            var dx = xPositions[targetIndex] - xPositions[i];
            var dy = yPositions[targetIndex] - yPositions[i];
            var distance = MathF.Sqrt(dx * dx + dy * dy);
            if (distance < 0.01f)
                continue;
            xWritable[i] += dx/distance * speeds[i] * deltaTime;
            yWritable[i] += dy/distance * speeds[i] * deltaTime;
        }
    }
}