using Pyresense.Projectiles.Weapons.Magic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Weapons.Magic
{
	public class FireBolt : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Casts a fire bolt");
		}

		public override void SetDefaults() {
			item.CloneDefaults(165);
			item.damage = 60;
			item.noMelee = true;
			item.magic = true;
			item.mana = 8;
			item.rare = 4;
			item.width = 28;
			item.height = 30;
			item.useTime = 28;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 26;
			item.shoot = ProjectileType<Projectiles.Weapons.Magic.FireBoltProjectile>();
			item.value = 20000;
		}
	}
}
