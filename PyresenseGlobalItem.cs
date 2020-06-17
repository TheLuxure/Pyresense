using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresenseGlobalItem : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == 75) {
				item.maxStack = 999;
			}
			if (ModContent.GetInstance<Config>().ReturnThrownDamage &&
				/*Before 1.4 (pre-hm)*/ item.type == 3245 || item.type == 3821 || item.type == 949 || item.type == 42 || item.type == 1809 ||
				item.type == 279 || item.type == 287 || item.type == 1130 || item.type == 3379 || item.type == 1913 || item.type == 161
				|| item.type == 3094 || item.type == 3197 || item.type == 154 || item.type == 2590 || item.type == 3378 || item.type == 3548 ||
				item.type == 168 || item.type == 2586 || item.type == 3116 || item.type == 166 || item.type == 3115 || item.type == 235
				|| item.type == 167 || item.type == 1338 || item.type == 580 || item.type == 2896 || item.type == 422 || item.type == 423 ||
				item.type == 3477 /*After 1.4 (pre-hm)*/ /*|| item.type == 4343 || item.type == 4344*/ || item.type == 280 || item.type == 277
				|| item.type == 802 || item.type == 2332 /*|| item.type == 4061*/ || item.type == 274
				/*Before 1.4(hm; not existing)*/
				|| item.type == 3030 || item.type == 517 || item.type == 561 || item.type == 1324 || item.type == 1122 || item.type == 1513 ||
				item.type == 1569 || item.type == 3054 || item.type == 1571 || item.type == 3543 || item.type == 3858 || item.type == 1327
				|| item.type == 1306 || item.type == 537 || item.type == 1186 || item.type == 537 || item.type == 390 || item.type == 1193 ||
				item.type == 406 || item.type == 1200 || item.type == 550 || item.type == 3836 || item.type == 1228 || item.type == 756
				|| item.type == 2331 || item.type == 1947) {
					item.melee = false;
					item.ranged = false;
					item.magic = false;
					item.summon = false;
					item.thrown = true;
			}
			/*if (item.rare == -1) {
				item.value = 0;
			} else if (item.rare == 0) {
				item.value = 100;
			} else if (item.rare == 1) {
				item.value = 200;
			} else if (item.rare == 2) {
				item.value = 400;
			} else if (item.rare == 3) {
				item.value = 800;
			} else if (item.rare == 4) {
				item.value = 1600;
			} else if (item.rare == 5) {
				item.value = 3200;
			} else if (item.rare == 6) {
				item.value = 6400;
			} else if (item.rare == 7) {
				item.value = 12800;
			} else if (item.rare == 8) {
				item.value = 25600;
			} else if (item.rare == 9) {
				item.value = 51200;
			} else if (item.rare == 10) {
				item.value = 102400;
			} else if (item.rare == 11) {
				item.value = 204800;
			}*/
		}
	}
}