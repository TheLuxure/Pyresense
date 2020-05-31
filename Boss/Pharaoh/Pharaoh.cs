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
    public class Pharaoh : ModNPC
    {
        public float bossPhaseHealth;
        public float P1;
        public float P2;
        public float P3;
        public bool BP1;
        public bool BP2;
        public bool BP3;
        public bool BS;
        public bool BSsummon = false;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pharaoh");
            Main.npcFrameCount[npc.type] = 18;
	    }

	    public override void SetDefaults() {
     	    npc.aiStyle = 0;  //5 is the flying AI
            npc.lifeMax = 3200;   //boss life
            npc.damage = 26;  //boss damage
            npc.defense = 0;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 32;
            npc.height = 56;
            Main.npcFrameCount[npc.type] = 18;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 30, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
	        npc.HitSound = SoundID.NPCHit1;
	        npc.DeathSound = SoundID.NPCDeath2;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/PharaohTheme");
            musicPriority = MusicPriority.BossHigh;
            npc.netAlways = true;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (BS && npc.life > bossPhaseHealth * 1 && !BSsummon) {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("PharaohsScorpion"));
                BSsummon = true;
            }
        }

        public override bool PreAI()
        {            
            bossPhaseHealth = npc.lifeMax / 3;
            return base.PreAI();
        }
        public override void AI()
        {
            if (NPC.AnyNPCs(mod.NPCType("PharaohsScorpion")) || !Main.player[Main.myPlayer].ZoneDesert) {
                npc.dontTakeDamage = true;
                npc.lifeMax += 1;
                npc.life += 1;
            } else {
                npc.dontTakeDamage = false;
            }

            if (npc.life > bossPhaseHealth * 2) {
                npc.ai[0] = 1;
                BP1 = true;
                BP2 = false;
                BP3 = false;
                BS = false;
            } else if (npc.life > bossPhaseHealth * 1) {
                npc.ai[0] = 2;
                BP1 = false;
                BP2 = true;
                BP3 = false;
                BS = true;
            } else if (npc.life > bossPhaseHealth * 0) {
                npc.ai[0] = 3;
                BP1 = false;
                BP2 = false;
                BP3 = true;
                BS = false;
            }

            if (npc.ai[0] == 1)
            {
                P1++;
            }
            else if (npc.ai[0] == 2)
            {
                P2++;
            }
            else if (npc.ai[0] == 3)
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
                ShootProjectile(1);
                P1 = 0;
            } else if (P2 >= 75) {
                npc.TargetClosest(true);
                Player player = Main.player[npc.target];

                float tpPosRand2;
                tpPosRand2 = Main.rand.NextFloat(6);
                if (tpPosRand2 > 4) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(300, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(400, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(200, 0);
                    }
                } else if (tpPosRand2 > 2) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-300, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-400, 0);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(-200, 0);
                    }
                } else if (tpPosRand2 > 0) {
                    if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -300);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -400);
                    } else if (Main.rand.NextBool(5)) {
                        npc.position = Main.player[npc.target].position + new Vector2(0, -200);
                    }
                }
                ShootProjectile(2);
                P2 = 0;
            } else if (P3 >= 50) {
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
                ShootProjectile(3);
                P3 = 0;
            }
            base.AI();
        }

		public override void NPCLoot() {
			int choice = Main.rand.Next(10);
			if (choice == 0) {
				Item.NewItem(npc.getRect(), ItemType<Items.Trophy.PharaohTrophy>());
			}
			if (Main.expertMode) {
				Item.NewItem(npc.getRect(), ItemType<Boss.Pharaoh.Loot.PharaohBag>());
			}
			else {
				choice = Main.rand.Next(7);
				if (choice == 0) {
					Item.NewItem(npc.getRect(), 848);
				}
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

        private const int Frame_P2_1 = 6;
        private const int Frame_P2_2 = 7;
        private const int Frame_P2_3 = 8;
        private const int Frame_P2_4 = 9;
        private const int Frame_P2_5 = 10;
        private const int Frame_P2_6 = 11;

        private const int Frame_P3_1 = 12;
        private const int Frame_P3_2 = 13;
        private const int Frame_P3_3 = 14;
        private const int Frame_P3_4 = 15;
        private const int Frame_P3_5 = 16;
        private const int Frame_P3_6 = 17;

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
                    npc.frame.Y = Frame_P2_1 * frameHeight;
                } else if (npc.frameCounter < 10) {
                    npc.frame.Y = Frame_P2_2 * frameHeight;
                } else if (npc.frameCounter < 15) {
                    npc.frame.Y = Frame_P2_3 * frameHeight;
                } else if (npc.frameCounter < 20) {
                    npc.frame.Y = Frame_P2_4 * frameHeight;
                } else if (npc.frameCounter < 25) {
                    npc.frame.Y = Frame_P2_5 * frameHeight;
                } else if (npc.frameCounter < 30) {
                    npc.frame.Y = Frame_P2_6 * frameHeight;
                } else {
                    npc.frameCounter = 0;
                }
            } else if (BP3 == true) {
                npc.frameCounter++;
                if (npc.frameCounter < 5) {
                    npc.frame.Y = Frame_P3_1 * frameHeight;
                } else if (npc.frameCounter < 10) {
                    npc.frame.Y = Frame_P3_2 * frameHeight;
                } else if (npc.frameCounter < 15) {
                    npc.frame.Y = Frame_P3_3 * frameHeight;
                } else if (npc.frameCounter < 20) {
                    npc.frame.Y = Frame_P3_4 * frameHeight;
                } else if (npc.frameCounter < 25) {
                    npc.frame.Y = Frame_P3_5 * frameHeight;
                } else if (npc.frameCounter < 30) {
                    npc.frame.Y = Frame_P3_6 * frameHeight;
                } else {
                    npc.frameCounter = 0;
                }
            }
            base.FindFrame(frameHeight);
        }

        public void ShootProjectile(int phase)
        {
            //In here, I want to shoot mini life crystals at the player. They will be shooting multiple times, maybe in groups of 3?
            switch (phase)
            {
                case 1:
                    Projectile.NewProjectile(npc.position + new Vector2(10, 0), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(10, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(0, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, 0), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(-10, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, -10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(0, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    return;
                case 2:
                    Projectile.NewProjectile(npc.position + new Vector2(10, -10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, 10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, 10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, -10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, -10), new Vector2(10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, 10), new Vector2(10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, 10), new Vector2(-10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, -10), new Vector2(-10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(-10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(-10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    return;
                case 3:
                    Projectile.NewProjectile(npc.position + new Vector2(10, -10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, 10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, 10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, -10), new Vector2(0, 0), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, -10), new Vector2(10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(10, 10), new Vector2(10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, 10), new Vector2(-10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(-10, -10), new Vector2(-10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(-10, 10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    Projectile.NewProjectile(npc.position + new Vector2(0, 0), new Vector2(-10, -10), ProjectileType<SandBallSmall>(), 100, 1f, npc.whoAmI);
                    return;
            }
        }

        public virtual void ScaleExpertStats (int numPlayers, float bossLifeScale) {
            npc.lifeMax = (int)(npc.lifeMax * 0.4f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.25f);
        }
	}
}
