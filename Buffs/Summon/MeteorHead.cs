using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Buffs.Summon
{
	public class MeteorHead : ModBuff
	{
		public override void SetDefaults() {
			// DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Meteor Head");
			Description.SetDefault("\"The Meteor Head will fight for you\"");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ProjectileType<Minions.MeteorHeadMinion>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}