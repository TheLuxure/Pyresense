using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Buffs.Summon
{
	public class EyeofCthulhuBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Eye of Cthulhu");
			Description.SetDefault("\"The Eye will fight for you\"");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ProjectileType<Minions.EyeofCthulhuMinion>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}