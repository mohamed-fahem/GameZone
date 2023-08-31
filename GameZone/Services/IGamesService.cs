
namespace GameZone.Services;

public interface IGamesService
{
    Task Create(CreateGameViewModel model);
}
