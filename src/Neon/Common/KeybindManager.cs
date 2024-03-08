using Terraria.ModLoader;

namespace Neon.Common;

public sealed class KeybindManager : ModSystem
{
    public static ModKeybind Capture { get; private set; }

    public override void Load()
    {
        base.Load();

        Capture = KeybindLoader.RegisterKeybind(Mod, "Capture", "P");
    }

    public override void Unload()
    {
        base.Unload();

        Capture = null;
    }
}