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

namespace Pyresense.Boss.RoyalSlime
{
    public class RoyalSlime : ModNPC
    {
        public float bossPhaseHealth;
        public float P1;
        public float P2;
        public bool BP1;
        public bool BP2;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Royal Slime");
            Main.npcFrameCount[npc.type] = 6;
	    }

	    public override void SetDefaults() {
     	    npc.aiStyle = 0;
            npc.lifeMax = 35500;
            npc.damage = 62;
            npc.defense = 0;
            npc.knockBackResist = 0f;
            npc.width = 122;
            npc.height = 115;
            Main.npcFrameCount[npc.type] = 6;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 15, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            music = 4;
            musicPriority = MusicPriority.BossHigh;
            npc.netAlways = true;
            npc.scale = 0.5f;
            npc.alpha = 192;
        }

        public override bool PreAI()
        {            
            bossPhaseHealth = npc.lifeMax / 2;
            return base.PreAI();
        }
        public override void AI()
        {
            if (npc.life > bossPhaseHealth * 1) {
                npc.ai[0] = 1;
                BP1 = true;
                BP2 = false;
            } else if (npc.life > bossPhaseHealth * 0) {
                npc.ai[0] = 2;
                BP1 = false;
                BP2 = true;
            }

            if (npc.ai[0] == 1)
            {
                P1++;
            }
            else if (npc.ai[0] == 2)
            {
                P2++;
            }

	    	if (!PyresenseWorld.downedPharaoh) {
		    	PyresenseWorld.downedPharaoh = true;
		    	if (Main.netMode == NetmodeID.Server) {
			    	NetMessage.SendData(MessageID.WorldData); // Immediately inform clients of new world state.
				}
			}
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
            if (BP1 == true || BP2 == true) {
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
            base.FindFrame(frameHeight);
        }

        public virtual void ScaleExpertStats (int numPlayers, float bossLifeScale) {
            npc.lifeMax = (int)(npc.lifeMax * 0.75f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.5f);
        }
	}
}
