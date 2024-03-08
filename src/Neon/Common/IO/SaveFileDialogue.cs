using Mono.Cecil.Cil;
using MonoMod.Cil;
using System;
using System.Reflection;
using Terraria.ModLoader;

namespace Neon.Common.IO;

internal sealed class SaveFileDialogue : ILoadable
{
    void ILoadable.Load(Mod mod) {
        IL_nativefiledialog.NFD_SaveDialog += SaveDialog;
    }

    void ILoadable.Unload() { }

    // tModLoader changes freePtr to false to prevent AccessViolations.
    // This is however only done in OpenDialog, so we have to do it in SaveDialog by ourselves.
    private void SaveDialog(ILContext il) {
        var method = typeof(nativefiledialog).GetMethod("UTF8_ToManaged", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
        var cursor = new ILCursor(il);

        // TODO: Exception handling.
        cursor.GotoNext(MoveType.Before, i => i.MatchCall(method));
        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_I4_0);
    }
}