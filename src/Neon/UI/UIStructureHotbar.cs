using Terraria.UI;

namespace Neon.UI;

/*
 * Ideally, this hotbar will be located at the right-middle position of the screen,
 * containing a vertical list of options for structure generation/creation:
 * 
 * 1 - Saving
 *  1.1 - Clear Selected Area
 *  1.2 - Tile Marking Modes
 *  1.3 - Wall Marking Modes
 *
 * NOTE: Marking modes determine tile placement conditions. For example: whether a tile
 *       should only be placed if there is not a tile in the desired position, or the
 *       inverse, and so on...
 *
 * 2 - Generating
 */
public sealed class UIStructureHotbar : UIState;