using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresenseGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;
		
		public bool curseCATsCurse;

		public override void ResetEffects(NPC npc) {
			curseCATsCurse = false;
		}

		public override void NPCLoot(NPC npc)
		{
			if (npc.type == 4 && Main.rand.NextBool(2) && !Main.expertMode)
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.EyeStaff>());
			}
			if (npc.type == 6 && Main.rand.NextBool(100))
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.EaterofSoulStaff>());
			}
			if (npc.type == 173 && Main.rand.NextBool(100))
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.CrimeraStaff>());
			}
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage) {
			if (curseCATsCurse) {
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 128;
				if (damage < 24) {
					damage = 24;
				}
			}
		}
	}
}