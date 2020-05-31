using Terraria;
using Terraria.ModLoader;

namespace Pyresense.Boss.Pharaoh.Loot
{
    public class PharaohsMedallion : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Pharaoh's Medallion");
            Tooltip.SetDefault("If worn in the desert, grants minor increase to damage, melee speed, critical strike chance,"
                             + "\nlife regeneration, defense and minion knockback");
        }

        public override void SetDefaults()
        {          
            item.width = 16;
            item.height = 16;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = -12;
            item.defense = 4;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            if (player.ZoneDesert) {
                player.allDamage += .1f;
                player.meleeSpeed += .1f;
                player.meleeCrit += 2;
                player.magicCrit += 2;
                player.rangedCrit += 2;
                player.moveSpeed += .1f;
                player.lifeRegenTime += 1;
                player.minionKB += .005f;
            }
			player.GetModPlayer<PyresensePlayer>().accPharaohsMedallion = true;
		}
    }
}
