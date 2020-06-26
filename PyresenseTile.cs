using Pyresense.Items.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresenseTile : GlobalTile
	{
		public override bool Drop(int i, int j, int type)
		{
			if (//Stone
				type == 1 || type == 25 || type == 203 || type == 117 || type == 130 
				|| type == 131 
				//Sandstone
				|| type == 396 || type == 400 || type == 401 || type == 403)
				{
				if (Main.rand.NextBool(30)) {
					Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("MiningStone"));
				}
				/*
				1.54 == (int)64.9350649351
				1.82 == (int)54.9450549451
				2.5 == 40
				2.77 == (int)36.1010830325
				3.44 == (int)29.0697674419
				*/
				//Level 1
				if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 0 && ModContent.
					GetInstance<Pyresense>().skillMiningLvl <= 20) {
					if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)64.9350649351)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 1922);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)64.9350649351)) {
							Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Misc.ScrapMetal>());
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else {
						if (Main.rand.NextBool((int)64.9350649351)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 13);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 13);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					}
				//Level 20
				} else if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 19 && ModContent.
							GetInstance<Pyresense>().skillMiningLvl <= 40) {
					if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)54.9450549451)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 1922);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)54.9450549451)) {
							Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Misc.ScrapMetal>());
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else {
						if (Main.rand.NextBool((int)54.9450549451)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 13);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 13);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 34) {
						if (Main.rand.NextBool((int)54.9450549451)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 22);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 22);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 22);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 650 * 60;
						}
					}
				//Level 40
				} else if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 39 && ModContent.
							GetInstance<Pyresense>().skillMiningLvl >= 60) {
					if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool(40)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 1922);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool(40)) {
							Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Misc.ScrapMetal>());
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else {
						if (Main.rand.NextBool(40)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 13);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 13);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 34) {
						if (Main.rand.NextBool(40)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 22);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 22);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 22);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 650 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 64) {
						if (Main.rand.NextBool(40)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 182);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 182);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 3550 * 60;
						}
					}
				//Level 60
				} else if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 59 && ModContent.
							GetInstance<Pyresense>().skillMiningLvl >= 80) {
					if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)36.1010830325)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 1922);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)36.1010830325)) {
							Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Misc.ScrapMetal>());
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else {
						if (Main.rand.NextBool((int)36.1010830325)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 13);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 13);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 34) {
						if (Main.rand.NextBool((int)36.1010830325)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 22);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 22);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 22);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 650 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 64) {
						if (Main.rand.NextBool((int)36.1010830325)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 182);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 182);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 3550 * 60;
						}
					}
				//Level 80
				} else if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 79) {
					if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 1922);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 1922);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else if (Main.rand.NextBool(3)) {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Misc.ScrapMetal>());
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					} else {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 13);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 13);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 20 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 34) {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 22);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 22);
								if (Main.rand.NextBool(3)) {
									Item.NewItem(i * 16, j * 16, 16, 16, 22);
								}
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 650 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 64) {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 182);
							if (Main.rand.NextBool(2)) {
								Item.NewItem(i * 16, j * 16, 16, 16, 182);
							}
							ModContent.GetInstance<Pyresense>().skillMiningExp += 3550 * 60;
						}
					}
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl >= 89) {
						if (Main.rand.NextBool((int)29.0697674419)) {
							Item.NewItem(i * 16, j * 16, 16, 16, 73);
							ModContent.GetInstance<Pyresense>().skillMiningExp += 19800 * 60;
						}
					}
				}
			}
			return true;
		}
	}
}