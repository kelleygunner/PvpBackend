using PvpBackend.Models;

namespace PvpBackend.Systems.Interfaces;

public interface IGameSystem
{
    void Update(GameRoom gameRoom, float deltaTime);
}