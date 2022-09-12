using ElementsOfAydaria.Content.Dusts;
using ElementsOfAydaria.Content.Items.Placeable;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Tiles
{
	public class FiregrassTree : ModTree
	{
		public override TreePaintingSettings TreeShaderSettings => new TreePaintingSettings 
		{
			UseSpecialGroups = true,
			SpecialGroupMinimalHueValue = 11f / 72f,
			SpecialGroupMaximumHueValue = 0.25f,
			SpecialGroupMinimumSaturationValue = 0.88f,
			SpecialGroupMaximumSaturationValue = 1f
		};

		public override void SetStaticDefaults() 
		{
			GrowsOnTileId = new int[1] { ModContent.TileType<Sunsand>() };
		}
		public override Asset<Texture2D> GetTexture() 
		{
			return ModContent.Request<Texture2D>("ElementsOfAydaria/Content/Tiles/Plants/FiregrassTree");
		}

		public override int SaplingGrowthType(ref int style) 
		{
			style = 0;
			return ModContent.TileType<Plants.FiregrassSapling>();
		}

		public override void SetTreeFoliageSettings(Tile tile, ref int xoffset, ref int treeFrame, ref int floorY, ref int topTextureFrameWidth, ref int topTextureFrameHeight) 
		{

		}

		public override Asset<Texture2D> GetBranchTextures() 
		{
			return ModContent.Request<Texture2D>("ElementsOfAydaria/Content/Tiles/Plants/FiregrassTree_Branches");
		}

		public override Asset<Texture2D> GetTopTextures() 
		{
			return ModContent.Request<Texture2D>("ElementsOfAydaria/Content/Tiles/Plants/FiregrassTree_Tops");
		}

		public override int DropWood() 
		{
			return ModContent.ItemType<Sunwood>();
		}

		public override bool Shake(int x, int y, ref bool createLeaves) 
		{
			Item.NewItem(WorldGen.GetItemSource_FromTreeShake(x, y), new Vector2(x, y) * 16, ModContent.ItemType<Items.Placeable.SunsandBlock>());
			return false;
		}

		public override int TreeLeaf() 
		{
			return ModContent.GoreType<FiregrassTreeLeaf>();
		}
	}
}