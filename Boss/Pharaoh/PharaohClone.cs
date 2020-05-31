using Pyresense.Boss.Pharaoh.Loot;
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
    [AutoloadBossHead]
    public class PharaohClone : ModNPC
    {
        public float bossPhaseHealth;
        public float P1;
        public float P2;
        public float P3;
        public bool BP1;
        public bool BP2;
        public bool BP3;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pharaoh");
            Main.npcFrameCount[npc.type] = 6;
	    }

	    public override void SetDefaults() {
     	    npc.aiStyle = 0;  //5 is the flying AI
            npc.lifeMax = 3200;   //boss life
            npc.life = 1600;
            npc.damage = 26;  //boss damage
            npc.defense = 0;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 32;
            npc.height = 56;
            Main.npcFrameCount[npc.type] = 6;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 0, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
	        npc.HitSound = SoundID.NPCHit1;
	        npc.DeathSound = SoundID.NPCDeath2;
            npc.netAlways = true;
            npc.dontTakeDamage = true;
        }

        public override bool PreAI()
        {            
            bossPhaseHealth = npc.lifeMax / 2;
            return base.PreAI();
        }
        public override void AI()
        {
            if (!NPC.AnyNPCs(mod.NPCType("Pharaoh"))) {
                npc.lifeMax = 0;
                npc.life = 0;
                npc.damage = 0;
                npc.defense = 0;
            }
            if (npc.life > bossPhaseHealth * 1) {
                npc.ai[0] = 1;
                BP1 = true;
                BP2 = false;
                BP3 = false;
            } else if (npc.life > bossPhaseHealth * 0) {
                npc.ai[0] = 2;
                BP1 = false;
                BP2 = false;
                BP3 = true;
            }

            if (npc.ai[0] == 1)
            {
                P1++;
            }
            else if (npc.ai[0] == 2)
            {
                P3++;
            }

            if (P1 >= 100)
            {
                npc.TargetClosest(true);
                Player player = Main.player[npc.target];

                float tpPosRand1;
                tpPosRand1 = Main.rand.NextFloat(6);
                if (tpPosRand1 > 4) {
                    npc.position = Main.player[npc.target].position + new Vector2(200, 0);
                } else if (tpPosRand1 > 2) {
                    npc.position = Main.player[npc.target].position + new Vector2(-200, 0);
                } else if (tpPosRand1 > 0) {
                    npc.position = Main.player[npc.target].position + new Vector2(0, -200);
                }
                P1 = 0;
            } else if (P2 >= 75) {
                npc.TargetClosest(true);
                Player player = Main.player[npc.target];

                float tpPosRand2;
                tpPosRand2 = Main.rand.NextFloat(6);
                if (tpPosRand2 > 4) {
                    if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(300, 0);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(400, 0);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(200, 0);
                    }
                } else if (tpPosRand2 > 2) {
                    if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-300, 0);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-400, 0);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-200, 0);
                    }
                } else if (tpPosRand2 > 0) {
                    if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -300);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -400);
                    } else if (Main.rand.NextBool(3)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -200);
                    }
                }
                P2 = 0;
            } else if (P2 >= 50 || P3 >= 50) {
                npc.TargetClosest(true);
                Player player = Main.player[npc.target];

                float tpPosRand3;
                tpPosRand3 = Main.rand.NextFloat(16);
                if (tpPosRand3 > 14) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(400, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(500, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(600, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(300, 0);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(200, 0);
                    }
                } else if (tpPosRand3 > 12) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-400, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-500, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-600, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-300, 0);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(-200, 0);
                    }
                } else if (tpPosRand3 > 10) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -200);
                    }
                } else if (tpPosRand3 > 8) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(400, -400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(500, -500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(600, -600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(300, -300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(200, -200);
                    }
                } else if (tpPosRand3 > 6) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-400, -400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-500, -500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-600, -600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-300, -300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(-200, -200);
                    }
                } else if (tpPosRand3 > 4) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(400, 400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(500, 500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(600, 600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(300, 300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(200, 200);
                    }
                } else if (tpPosRand3 > 2) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-400, 400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-500, 500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-600, 600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-300, 300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(-200, 200);
                    }
                } else if (tpPosRand3 > 0) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, 400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, 500);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, 600);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, 300);
                    } else {
                        npc.position = Main.player[npc.target].position + new Vector2(0, 200);
                    }
                }
                P2 = 0;
                P3 = 0;
            }
            base.AI();
        }

        private const int Frame_P1_1 = 0;
        private const int Frame_P1_2 = 1;
        private const int Frame_P1_3 = 2;
        private const int Frame_P1_4 = 3;
        private const int Frame_P1_5 = 4;
        private const int Frame_P1_6 = 5;

        public override void FindFrame(int frameHeight)
        {
            npc.spriteDirection = npc.direction;
            if (BP1 == true) {
                npc.frameCounter++;
                if (npc.frameCounter < 5) {
                    npc.frame.Y = Frame_P1_1 * frameHeight;
                } else if (npc.frameCounter < 10) {
                    npc.frame.Y = Frame_P1_2 * frameHeight;
                } else if (npc.frameCounter < 15) {
                    npc.frame.Y = Frame_P1_3 * frameHeight;
                } else if (npc.frameCounter < 20) {
                    npc.frame.Y = Frame_P1_4 * frameHeight;
                } else if (npc.frameCounter < 25) {
                    npc.frame.Y = Frame_P1_5 * frameHeight;
                } else if (npc.frameCounter < 30) {
                    npc.frame.Y = Frame_P1_6 * frameHeight;
                } else {
                    npc.frameCounter = 0;
                }
            } else if (BP2 == true) {
                npc.frameCounter++;
                if (npc.frameCounter < 5) {
                    npc.frame.Y = Frame_P1_1 * frameHeight;
                } else if (npc.frameCounter < 10) {
                    npc.frame.Y = Frame_P1_2 * frameHeight;
                } else if (npc.frameCounter < 15) {
                    npc.frame.Y = Frame_P1_3 * frameHeight;
                } else if (npc.frameCounter < 20) {
                    npc.frame.Y = Frame_P1_4 * frameHeight;
                } else if (npc.frameCounter < 25) {
                    npc.frame.Y = Frame_P1_5 * frameHeight;
                } else if (npc.frameCounter < 30) {
                    npc.frame.Y = Frame_P1_6 * frameHeight;
                } else {
                    npc.frameCounter = 0;
                }
            }
        }
	}
}
