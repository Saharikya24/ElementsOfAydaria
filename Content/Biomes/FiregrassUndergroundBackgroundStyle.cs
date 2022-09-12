using Terraria.ModLoader;

namespace ElementsOfAydaria.Backgrounds
{
	public class FiregrassUndergroundBackgroundStyle : ModUndergroundBackgroundStyle
	{
		public override void FillTextureArray(int[] textureSlots) 
		{
			textureSlots[0] = BackgroundTextureLoader.GetBackgroundSlot(Mod, "Content/Biomes/Backgrounds/FiregrassBiomeUnderground0");
			textureSlots[1] = BackgroundTextureLoader.GetBackgroundSlot(Mod, "Content/Biomes/Backgrounds/FiregrassBiomeUnderground1");
			textureSlots[2] = BackgroundTextureLoader.GetBackgroundSlot(Mod, "Content/Biomes/Backgrounds/FiregrassBiomeUnderground2");
			textureSlots[3] = BackgroundTextureLoader.GetBackgroundSlot(Mod, "Content/Biomes/Backgrounds/FiregrassBiomeUnderground3");
		}
	}
}