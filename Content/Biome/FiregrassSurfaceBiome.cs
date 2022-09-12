using ElementsOfAydaria.Common;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Graphics.Capture;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Biomes
{
	public class FiregrassSurfaceBiome : ModBiome
	{
		public override ModWaterStyle WaterStyle => ModContent.Find<ModWaterStyle>("ElementsOfAydaria/FiregrassWaterStyle");
		public override ModSurfaceBackgroundStyle SurfaceBackgroundStyle => ModContent.Find<ModSurfaceBackgroundStyle>("ElementsOfAydaria/FiregrassSurfaceBackgroundStyle");
		public override CaptureBiome.TileColorStyle TileColorStyle => CaptureBiome.TileColorStyle.Crimson;
		public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Biomes/Music/Azure");
		public override string BestiaryIcon => base.BestiaryIcon;
		public override string BackgroundPath => base.BackgroundPath;
		public override Color? BackgroundColor => base.BackgroundColor;
		public override string MapBackground => BackgroundPath;

		public override void SetStaticDefaults() 
		{
		}

		public override bool IsBiomeActive(Player player) 
		{

			bool b1 = ModContent.GetInstance<FiregrassBiomeTileCount>().SunsandCount >= 40;

			bool b2 = Math.Abs(player.position.ToTileCoordinates().X - Main.maxTilesX / 2) < Main.maxTilesX / 6;

			bool b3 = player.ZoneSkyHeight || player.ZoneOverworldHeight;
			return b1 && b2 && b3;
		}
	}
}
