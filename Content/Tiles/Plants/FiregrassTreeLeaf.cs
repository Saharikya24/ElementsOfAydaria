using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementsOfAydaria.Content.Tiles
{
	public class FiregrassTreeLeaf : ModGore
	{
		public override string Texture => "ElementsOfAydaria/Content/Tiles/Plants/FiregrassTree_Leaf";

		public override void SetStaticDefaults() 
		{
			
			GoreID.Sets.SpecialAI[Type] = 3;
		}
	}
}
