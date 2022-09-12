using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Biomes
{
	public class FiregrassWaterfallStyle : ModWaterfallStyle
	{
		public override void AddLight(int i, int j) =>
			Lighting.AddLight(new Vector2(i, j).ToWorldCoordinates(), Color.White.ToVector3() * 0.5f);
	}
}