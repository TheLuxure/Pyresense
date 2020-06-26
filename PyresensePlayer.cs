using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresensePlayer : ModPlayer
	{
		//Accessories
		public bool accPharaohsMedallion = false;

		//Debuffs/Buffs
		public bool curseCATsCurse;

		public override void ResetEffects() 
		{
			//Accessories
			accPharaohsMedallion = false;

			//Debuffs/Buffs
			curseCATsCurse = false;
		}

		public override void PostUpdate() {
			ModContent.GetInstance<Pyresense>().skillAdventureExp += 1;
			if (ModContent.GetInstance<Pyresense>().skillAdventureLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillAdventureLvl = 1;
			}
			if (ModContent.GetInstance<Pyresense>().skillHunterLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillHunterLvl = 1;
			}
			if (ModContent.GetInstance<Pyresense>().skillMiningLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillMiningLvl = 1;
			}
			if (ModContent.GetInstance<Pyresense>().skillButcheryLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillButcheryLvl = 1;
			}
			/*if (ModContent.GetInstance<Pyresense>().skillAdventureExp >= 54 * 60 && ModContent.GetInstance<Pyresense>().skillAdventureLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillAdventureLvl += 1;
				Main.NewText("Congratulations! Your Exploration lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillAdventureLvl + " lvl!", 127, 255, 212);
				ModContent.GetInstance<Pyresense>().skillAdventureExp = 0;
			}
			if (ModContent.GetInstance<Pyresense>().skillHunterExp >= 54 * 60 && ModContent.GetInstance<Pyresense>().skillHunterLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillHunterLvl += 1;
				Main.NewText("Congratulations! Your Hunter lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillHunterLvl + " lvl!", 127, 255, 212);
				ModContent.GetInstance<Pyresense>().skillHunterExp = 0;
			}
			if (ModContent.GetInstance<Pyresense>().skillMiningExp >= 54 * 60 && ModContent.GetInstance<Pyresense>().skillMiningLvl == 0) {
				ModContent.GetInstance<Pyresense>().skillMiningLvl += 1;
				Main.NewText("Congratulations! Your Foraging lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillMiningLvl + " lvl!", 127, 255, 212);
				ModContent.GetInstance<Pyresense>().skillMiningExp = 0;
			}*/
			if (ModContent.GetInstance<Pyresense>().skillAdventureLvl == 1 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= 54 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 2 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)59.0000000001 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 3 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)64.4545454547 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 4 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)70.4049586779 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 5 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)76.8963185578 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 6 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)81.7959838813 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 7 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)87.1410733251 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 8 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)92.9720799911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 9 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)99.3331781722 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 10 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)106.272558006 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 11 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)113.842790552 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 12 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)124.283044239 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 13 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)135.672411897 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 14 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)148.097176615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 15 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)161.651465398 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 16 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)176.437962253 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 17 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)192.568686094 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 18 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)207.984021194 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 19 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)224.800750394 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 20 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)243.146273157 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 21 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)265.341388899 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 22 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)289.554242436 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 23 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)315.968264476 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 24 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)344.783561247 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 25 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)376.218430452 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 26 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)410.511015039 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 27 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)447.921107316 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 28 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)488.732117072 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 29 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)533.253218624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 30 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)581.821693045 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 31 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)634.805483322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 32 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)692.605981806 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 33 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)755.661071062 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 34 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)824.448441159 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 35 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)899.489208538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 36 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)981.35186386 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 37 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1070.65657876 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 38 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1168.0799041 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 39 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1274.35989538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 40 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1390.30170405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 41 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1516.78367715 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 42 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1654.76401144 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 43 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1805.28801248 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 44 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)1969.49601362 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 45 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)2148.63201486 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 46 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)2344.05310712 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 47 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)2557.23975322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 48 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)2789.80700352 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 49 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)3043.51673112 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 50 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)3320.29097941 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 51 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)3622.226523 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 52 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)3951.61075237 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 53 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)4310.93900259 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 54 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)4702.93345737 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 55 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)5130.56377168 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 56 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)5597.06956911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 57 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)6105.98498449 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 58 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)6661.16543763 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 59 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)7266.81684106 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 60 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)7927.52746298 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 61 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)8648.30268689 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 62 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)9434.60293116 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 63 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)10292.3850158 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 64 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)11228.14729 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 65 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)12248.9788618 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 66 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)13362.6133038 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 67 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)14577.4872405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 68 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)15902.8042624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 69 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)17348.6046499 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 70 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)18925.8414363 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 71 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)20646.4633851 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 72 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)22523.505511 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 73 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)24571.1878302 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 74 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)26805.0230875 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 75 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)29241.9342773 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 76 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)31900.382848 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 77 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)34800.5085615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 78 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)37964.2820671 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 79 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)41415.671346 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 80 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)45180.8232866 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 82 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)49288.2617672 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 83 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)53769.1037461 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 84 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)58657.2949958 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 85 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)63989.8672682 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 86 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)69807.2188381 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 87 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)76153.4205507 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 88 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)83076.5496917 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 89 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)90629.0542092 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 90 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)98868.1500465 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 91 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)107856.254596 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 92 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)117661.459559 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 93 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)128358.046792 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 94 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)140027.051046 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 95 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)152756.873868 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 96 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)166643.953311 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 97 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)181793.494521 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 98 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)198320.26675 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillAdventureLvl == 99 && ModContent.GetInstance<Pyresense>().skillAdventureExp >= (int)216349.472818 * (int)60f) {
				if (ModContent.GetInstance<Pyresense>().skillAdventureLvl != ModContent.GetInstance<Pyresense>().skillAdventureLvlMax) {
					ModContent.GetInstance<Pyresense>().skillAdventureLvl += 1;
					if (ModContent.GetInstance<Pyresense>().skillAdventureLvl == 100) {
						Main.NewText("Congratulations! Your Exploration lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillAdventureLvl + " lvl!", 127, 255, 212);
						Main.NewText("Now, you unlock every recipe, weapon, armor, tool and etch.!", 127, 255, 212);
					} else {
						Main.NewText("Congratulations! Your Exploration lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillAdventureLvl + " lvl!", 127, 255, 212);
					}
					ModContent.GetInstance<Pyresense>().skillAdventureExp = 0;
				}
			}
			if (ModContent.GetInstance<Pyresense>().skillHunterLvl == 1 && ModContent.GetInstance<Pyresense>().skillHunterExp >= 54 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 2 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)59.0000000001 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 3 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)64.4545454547 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 4 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)70.4049586779 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 5 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)76.8963185578 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 6 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)81.7959838813 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 7 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)87.1410733251 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 8 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)92.9720799911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 9 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)99.3331781722 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 10 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)106.272558006 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 11 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)113.842790552 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 12 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)124.283044239 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 13 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)135.672411897 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 14 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)148.097176615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 15 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)161.651465398 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 16 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)176.437962253 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 17 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)192.568686094 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 18 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)207.984021194 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 19 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)224.800750394 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 20 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)243.146273157 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 21 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)265.341388899 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 22 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)289.554242436 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 23 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)315.968264476 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 24 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)344.783561247 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 25 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)376.218430452 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 26 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)410.511015039 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 27 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)447.921107316 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 28 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)488.732117072 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 29 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)533.253218624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 30 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)581.821693045 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 31 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)634.805483322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 32 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)692.605981806 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 33 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)755.661071062 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 34 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)824.448441159 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 35 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)899.489208538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 36 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)981.35186386 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 37 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1070.65657876 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 38 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1168.0799041 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 39 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1274.35989538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 40 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1390.30170405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 41 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1516.78367715 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 42 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1654.76401144 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 43 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1805.28801248 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 44 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)1969.49601362 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 45 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)2148.63201486 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 46 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)2344.05310712 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 47 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)2557.23975322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 48 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)2789.80700352 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 49 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)3043.51673112 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 50 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)3320.29097941 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 51 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)3622.226523 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 52 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)3951.61075237 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 53 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)4310.93900259 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 54 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)4702.93345737 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 55 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)5130.56377168 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 56 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)5597.06956911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 57 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)6105.98498449 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 58 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)6661.16543763 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 59 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)7266.81684106 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 60 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)7927.52746298 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 61 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)8648.30268689 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 62 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)9434.60293116 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 63 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)10292.3850158 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 64 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)11228.14729 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 65 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)12248.9788618 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 66 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)13362.6133038 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 67 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)14577.4872405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 68 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)15902.8042624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 69 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)17348.6046499 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 70 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)18925.8414363 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 71 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)20646.4633851 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 72 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)22523.505511 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 73 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)24571.1878302 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 74 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)26805.0230875 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 75 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)29241.9342773 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 76 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)31900.382848 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 77 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)34800.5085615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 78 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)37964.2820671 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 79 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)41415.671346 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 80 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)45180.8232866 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 82 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)49288.2617672 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 83 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)53769.1037461 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 84 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)58657.2949958 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 85 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)63989.8672682 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 86 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)69807.2188381 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 87 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)76153.4205507 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 88 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)83076.5496917 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 89 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)90629.0542092 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 90 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)98868.1500465 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 91 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)107856.254596 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 92 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)117661.459559 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 93 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)128358.046792 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 94 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)140027.051046 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 95 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)152756.873868 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 96 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)166643.953311 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 97 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)181793.494521 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 98 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)198320.26675 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillHunterLvl == 99 && ModContent.GetInstance<Pyresense>().skillHunterExp >= (int)216349.472818 * (int)60f) {
				if (ModContent.GetInstance<Pyresense>().skillHunterLvl != ModContent.GetInstance<Pyresense>().skillHunterLvlMax) {
					ModContent.GetInstance<Pyresense>().skillHunterLvl += 1;
					if (ModContent.GetInstance<Pyresense>().skillHunterLvl == 100) {
						Main.NewText("Congratulations! Your Hunter lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillHunterLvl + " lvl!", 127, 255, 212);
						Main.NewText("Now, you unlock every recipe, weapon, armor, tool and etch.!", 127, 255, 212);
					} else {
						Main.NewText("Congratulations! Your Hunter lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillHunterLvl + " lvl!", 127, 255, 212);
					}
					ModContent.GetInstance<Pyresense>().skillHunterExp = 0;
				}
			}
			if (ModContent.GetInstance<Pyresense>().skillMiningLvl == 1 && ModContent.GetInstance<Pyresense>().skillMiningExp >= 54 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 2 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)59.0000000001 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 3 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)64.4545454547 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 4 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)70.4049586779 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 5 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)76.8963185578 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 6 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)81.7959838813 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 7 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)87.1410733251 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 8 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)92.9720799911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 9 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)99.3331781722 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 10 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)106.272558006 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 11 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)113.842790552 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 12 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)124.283044239 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 13 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)135.672411897 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 14 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)148.097176615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 15 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)161.651465398 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 16 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)176.437962253 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 17 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)192.568686094 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 18 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)207.984021194 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 19 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)224.800750394 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 20 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)243.146273157 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 21 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)265.341388899 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 22 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)289.554242436 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 23 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)315.968264476 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 24 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)344.783561247 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 25 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)376.218430452 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 26 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)410.511015039 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 27 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)447.921107316 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 28 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)488.732117072 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 29 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)533.253218624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 30 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)581.821693045 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 31 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)634.805483322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 32 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)692.605981806 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 33 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)755.661071062 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 34 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)824.448441159 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 35 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)899.489208538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 36 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)981.35186386 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 37 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1070.65657876 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 38 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1168.0799041 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 39 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1274.35989538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 40 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1390.30170405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 41 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1516.78367715 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 42 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1654.76401144 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 43 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1805.28801248 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 44 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)1969.49601362 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 45 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)2148.63201486 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 46 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)2344.05310712 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 47 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)2557.23975322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 48 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)2789.80700352 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 49 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)3043.51673112 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 50 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)3320.29097941 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 51 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)3622.226523 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 52 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)3951.61075237 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 53 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)4310.93900259 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 54 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)4702.93345737 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 55 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)5130.56377168 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 56 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)5597.06956911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 57 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)6105.98498449 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 58 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)6661.16543763 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 59 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)7266.81684106 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 60 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)7927.52746298 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 61 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)8648.30268689 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 62 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)9434.60293116 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 63 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)10292.3850158 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 64 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)11228.14729 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 65 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)12248.9788618 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 66 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)13362.6133038 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 67 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)14577.4872405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 68 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)15902.8042624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 69 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)17348.6046499 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 70 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)18925.8414363 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 71 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)20646.4633851 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 72 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)22523.505511 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 73 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)24571.1878302 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 74 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)26805.0230875 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 75 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)29241.9342773 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 76 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)31900.382848 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 77 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)34800.5085615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 78 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)37964.2820671 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 79 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)41415.671346 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 80 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)45180.8232866 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 82 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)49288.2617672 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 83 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)53769.1037461 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 84 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)58657.2949958 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 85 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)63989.8672682 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 86 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)69807.2188381 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 87 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)76153.4205507 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 88 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)83076.5496917 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 89 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)90629.0542092 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 90 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)98868.1500465 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 91 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)107856.254596 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 92 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)117661.459559 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 93 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)128358.046792 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 94 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)140027.051046 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 95 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)152756.873868 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 96 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)166643.953311 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 97 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)181793.494521 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 98 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)198320.26675 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillMiningLvl == 99 && ModContent.GetInstance<Pyresense>().skillMiningExp >= (int)216349.472818 * (int)60f) {
				if (ModContent.GetInstance<Pyresense>().skillMiningLvl != ModContent.GetInstance<Pyresense>().skillMiningLvlMax) {
					ModContent.GetInstance<Pyresense>().skillMiningLvl += 1;
					if (ModContent.GetInstance<Pyresense>().skillMiningLvl == 100) {
						Main.NewText("Congratulations! Your Foraging lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillMiningLvl + " lvl!", 127, 255, 212);
						Main.NewText("Now, you unlock every recipe, weapon, armor, tool and etch.!", 127, 255, 212);
					} else {
						Main.NewText("Congratulations! Your Foraging lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillMiningLvl + " lvl!", 127, 255, 212);
					}
					ModContent.GetInstance<Pyresense>().skillMiningExp = 0;
				}
			}
			if (ModContent.GetInstance<Pyresense>().skillButcheryLvl == 1 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= 54 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 2 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)59.0000000001 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 3 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)64.4545454547 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 4 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)70.4049586779 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 5 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)76.8963185578 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 6 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)81.7959838813 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 7 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)87.1410733251 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 8 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)92.9720799911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 9 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)99.3331781722 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 10 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)106.272558006 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 11 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)113.842790552 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 12 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)124.283044239 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 13 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)135.672411897 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 14 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)148.097176615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 15 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)161.651465398 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 16 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)176.437962253 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 17 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)192.568686094 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 18 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)207.984021194 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 19 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)224.800750394 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 20 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)243.146273157 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 21 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)265.341388899 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 22 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)289.554242436 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 23 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)315.968264476 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 24 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)344.783561247 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 25 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)376.218430452 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 26 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)410.511015039 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 27 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)447.921107316 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 28 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)488.732117072 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 29 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)533.253218624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 30 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)581.821693045 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 31 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)634.805483322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 32 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)692.605981806 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 33 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)755.661071062 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 34 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)824.448441159 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 35 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)899.489208538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 36 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)981.35186386 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 37 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1070.65657876 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 38 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1168.0799041 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 39 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1274.35989538 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 40 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1390.30170405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 41 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1516.78367715 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 42 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1654.76401144 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 43 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1805.28801248 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 44 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)1969.49601362 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 45 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)2148.63201486 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 46 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)2344.05310712 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 47 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)2557.23975322 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 48 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)2789.80700352 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 49 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)3043.51673112 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 50 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)3320.29097941 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 51 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)3622.226523 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 52 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)3951.61075237 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 53 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)4310.93900259 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 54 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)4702.93345737 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 55 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)5130.56377168 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 56 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)5597.06956911 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 57 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)6105.98498449 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 58 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)6661.16543763 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 59 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)7266.81684106 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 60 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)7927.52746298 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 61 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)8648.30268689 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 62 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)9434.60293116 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 63 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)10292.3850158 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 64 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)11228.14729 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 65 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)12248.9788618 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 66 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)13362.6133038 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 67 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)14577.4872405 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 68 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)15902.8042624 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 69 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)17348.6046499 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 70 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)18925.8414363 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 71 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)20646.4633851 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 72 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)22523.505511 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 73 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)24571.1878302 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 74 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)26805.0230875 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 75 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)29241.9342773 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 76 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)31900.382848 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 77 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)34800.5085615 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 78 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)37964.2820671 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 79 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)41415.671346 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 80 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)45180.8232866 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 82 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)49288.2617672 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 83 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)53769.1037461 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 84 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)58657.2949958 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 85 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)63989.8672682 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 86 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)69807.2188381 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 87 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)76153.4205507 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 88 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)83076.5496917 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 89 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)90629.0542092 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 90 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)98868.1500465 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 91 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)107856.254596 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 92 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)117661.459559 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 93 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)128358.046792 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 94 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)140027.051046 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 95 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)152756.873868 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 96 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)166643.953311 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 97 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)181793.494521 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 98 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)198320.26675 * (int)60f ||
				ModContent.GetInstance<Pyresense>().skillButcheryLvl == 99 && ModContent.GetInstance<Pyresense>().skillButcheryExp >= (int)216349.472818 * (int)60f) {
				if (ModContent.GetInstance<Pyresense>().skillButcheryLvl != ModContent.GetInstance<Pyresense>().skillButcheryLvlMax) {
					ModContent.GetInstance<Pyresense>().skillButcheryLvl += 1;
					if (ModContent.GetInstance<Pyresense>().skillButcheryLvl == 100) {
						Main.NewText("Congratulations! Your Butchery lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillButcheryLvl + " lvl!", 127, 255, 212);
						Main.NewText("Now, you unlock every recipe, weapon, armor, tool and etch.!", 127, 255, 212);
					} else {
						Main.NewText("Congratulations! Your Butchery lvl was upgraded to " + ModContent.GetInstance<Pyresense>().skillButcheryLvl + " lvl!", 127, 255, 212);
					}
					ModContent.GetInstance<Pyresense>().skillButcheryExp = 0;
				}
			}
		}

		public override void UpdateDead() {
			curseCATsCurse = false;
		}

		public override void UpdateBadLifeRegen() {
			if (curseCATsCurse) {
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				player.lifeRegen -= 128;
			}
		}

		public override float UseTimeMultiplier(Item item) {
            return accPharaohsMedallion ? 1f : 1f;
		}

		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath) {
			/*Main.NewText("[Pyresense] Mod contain skills which NOT saving!", 127, 255, 212);
			Main.NewText("          This problem gonna be fixed in future.", 127, 255, 212);
			Main.NewText("                    Sorry for any inconvenience.", 127, 255, 212);*/
			ModContent.GetInstance<Pyresense>().skillMiningLvl = 0;
			ModContent.GetInstance<Pyresense>().skillAdventureLvl = 0;
			ModContent.GetInstance<Pyresense>().skillHunterLvl = 0;
			ModContent.GetInstance<Pyresense>().skillButcheryLvl = 0;
		}
	}
}
