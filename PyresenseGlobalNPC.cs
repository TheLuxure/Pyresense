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

		public override void SetDefaults(NPC npc) {
			if (npc.type == 127) {
				if (NPC.AnyNPCs(128)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(129)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(130)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(131)) {
					npc.defense = npc.defense * 225;
				}
			}
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
			if (npc.type == 370 && !Main.expertMode)
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Souls.SoulofTide>(), Main.rand.Next(20, 40));
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