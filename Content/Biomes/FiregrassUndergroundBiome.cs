using ElementsOfAydaria.Common;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Biomes
{
	public class FiregrassUndergroundBiome : ModBiome
	{
		public override ModUndergroundBackgroundStyle UndergroundBackgroundStyle => ModContent.Find<ModUndergroundBackgroundStyle>("ElementsOfAydaria/Content/Biomes/Backgrounds/FiregrassUndergroundBackgroundStyle");
		public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Biomes/Music/Azure");
		public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
		public override string BestiaryIcon => base.BestiaryIcon;
		public override string BackgroundPath => base.BackgroundPath;
		public override Color? BackgroundColor => base.BackgroundColor;
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Firegrass Meadow Underground");
		}
		public override bool IsBiomeActive(Player player) 
		{
			return (player.ZoneRockLayerHeight || player.ZoneDirtLayerHeight) &&
				ModContent.GetInstance<FiregrassBiomeTileCount>().SunsandCount >= 40 &&
				Math.Abs(player.position.ToTileCoordinates().X - Main.maxTilesX / 2) < Main.maxTilesX / 6;
		}
	}
}
