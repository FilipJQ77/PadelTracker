using PadelTracker.Common.Models;

namespace PadelTracker.Blazor;

public class AppState
{
    public List<Player> Players { get; set; } = new();
}