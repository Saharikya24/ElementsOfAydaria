using System;
using ElementsOfAydaria.Content.Tiles;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework.Input;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;
using Terraria.GameContent.Generation;

namespace ElementsOfAydaria.Common
{
	public class FiregrassBiomeTileCount : ModSystem
	{
		public int SunsandCount;

		public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts) {
			SunsandCount = tileCounts[ModContent.TileType<Sunsand>()];
		}
	}
}
	class FiregrassBiomeWorld : ModSystem
{
	public static bool JustPressed(Keys key)
	{
		return Main.keyState.IsKeyDown(key) && !Main.oldKeyState.IsKeyDown(key);
	}

	public override void PostUpdateEverything()
	{
		if (JustPressed(Keys.D1))
			TestMethod((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16);
	}

	private void TestMethod(int x, int y)
	{
		Dust.QuickBox(new Vector2(x, y) * 16, new Vector2(x + 1, y + 1) * 16, 2, Color.OrangeRed, null);

		WorldGen.TileRunner(x - 1, y, WorldGen.genRand.Next(3, 8),
		WorldGen.genRand.Next(2, 8), ModContent.TileType<Sunsand>());
	}
}
