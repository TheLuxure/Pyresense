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