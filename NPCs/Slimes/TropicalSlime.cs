using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.NPCs.Slimes
{
	public class TropicalSlime : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Tropical Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults() {
			npc.width = 24;
			npc.height = 18;
			npc.damage = 22;
			npc.defense = 2;
			npc.lifeMax = 31;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 1;
			aiType = 1;
			animationType = NPCID.BlueSlime;
			npc.value = 25;
			//npc.alpha = 175;
			npc.scale = 1.125f;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return spawnInfo.player.ZoneBeach ? 0.1f : 0f;
		}
	}
}
