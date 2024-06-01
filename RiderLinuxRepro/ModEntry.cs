using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace RiderLinuxRepro;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        // Breakpoint above here for the earliest possible entry point for the mod.
        helper.Events.GameLoop.GameLaunched += GameLaunched;
    }

    private void GameLaunched(object? sender, GameLaunchedEventArgs e)
    {
        // And right here for after the game has launched, before the first update tick.
    }
}