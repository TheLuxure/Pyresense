using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Boss.Pharaoh
{
    public class PharaohsScorpion : ModNPC
    {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pharaoh's Scorpion");
            Main.npcFrameCount[npc.type] = 4;
	    }

	    public override void SetDefaults() {
     	    npc.aiStyle = 3;  //5 is the flying AI
            npc.lifeMax = 1200;   //boss life
            npc.damage = 12;  //boss damage
            npc.defense = 3;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 74;
            npc.height = 56;
            Main.npcFrameCount[npc.type] = 4;    //boss frame/animation 
            npc.npcSlots = 1f;
            npc.lavaImmune = true;
	        npc.HitSound = SoundID.NPCHit1;
	        npc.DeathSound = SoundID.NPCDeath2;
            npc.netAlways = true;
        }

        public override void AI()
        {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
        }

        private const int Frame_1 = 0;
        private const int Frame_2 = 1;
        private const int Frame_3 = 2;
        private const int Frame_4 = 3;

        public override void FindFrame(int frameHeight)
        {
            npc.spriteDirection = npc.direction;
            npc.frameCounter++;
            if (npc.frameCounter < 5) {
                npc.frame.Y = Frame_1 * frameHeight;
            } else if (npc.frameCounter < 10) {
                npc.frame.Y = Frame_2 * frameHeight;
            } else if (npc.frameCounter < 15) {
                npc.frame.Y = Frame_3 * frameHeight;
            } else if (npc.frameCounter < 20) {
                npc.frame.Y = Frame_4 * frameHeight;
            } else {
                npc.frameCounter = 0;
            }
        }
	}
}
