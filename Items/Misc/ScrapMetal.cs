using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Misc
{
    public class ScrapMetal : ModItem
    {
        public override void SetDefaults() {
            item.width = 34;
			item.height = 34;
            item.maxStack = 999;
            item.value = 500;
            item.rare = 1;
        }
	}
}
