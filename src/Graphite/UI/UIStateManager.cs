using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace Graphite.UI;

[Autoload(Side = ModSide.Client)]
public sealed class UIStateManager : ModSystem
{
    // Keeps track of the last game time update, which isn't provided for rendering.
    private static GameTime? gameTime;

    private UserInterface UserInterface { get; } = new();

    public override void Load()
    {
        base.Load();
        
        UserInterface.SetState(new UIStructureHotbar());
    }

    public override void UpdateUI(GameTime gameTime)
    {
        base.UpdateUI(gameTime);
        
        UIStateManager.gameTime = gameTime;
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        base.ModifyInterfaceLayers(layers);

        var index = layers.FindIndex(l => l.Name == "Vanilla: Mouse Text");

        if (index == -1)
        {
            return;
        }

        layers.Insert(index + 1, new LegacyGameInterfaceLayer("Graphite:Hotbar", drawHotbar));

        bool drawHotbar()
        {
            UserInterface.Draw(Main.spriteBatch, gameTime);

            return true;
        }
    }
}