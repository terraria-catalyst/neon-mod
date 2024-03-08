using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;

namespace Neon.UI;

[Autoload(Side = ModSide.Client)]
public sealed class UIManager : ModSystem
{
    // Keeps track of the last game time update, which isn't provided for rendering.
    private static GameTime? gameTime;

    public override void Load()
    {
        base.Load();
    }

    public override void UpdateUI(GameTime gameTime)
    {
        base.UpdateUI(gameTime);
        
        UIManager.gameTime = gameTime;
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        base.ModifyInterfaceLayers(layers);

        var index = layers.FindIndex(l => l.Name == "Vanilla: Mouse Text");

        if (index == -1)
        {
            return;
        }
        
        // TODO: UI.
    }
}