using ElementsOfAydaria.Content.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Tiles
{
	public class SunwoodBlock : ModTile
	{
		public override void SetStaticDefaults() 
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;

			DustType = ModContent.DustType<SunSparkle>();
			ItemDrop = ModContent.ItemType<Items.Placeable.SunsandBlock>();

			AddMapEntry(new Color(200, 200, 200));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) 
		{
			num = fail ? 1 : 3;
		}
	}
}