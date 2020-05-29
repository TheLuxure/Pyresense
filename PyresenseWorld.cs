using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.ModLoader.IO;
using Terraria.GameContent.Generation;
using static Terraria.ModLoader.ModContent;
using System.Linq;

namespace Pyresense
{
	public class PyresenseWorld : ModWorld
	{
		public static bool downedPharaoh;

    	public override void Initialize() {
	    	downedPharaoh = false;
        }

		public override TagCompound Save() {
		var downed = new List<string>();
		if (downedPharaoh) {
			downed.Add("pharaoh");
		}

			return new TagCompound {
				["downed"] = downed
			};
		}

		public override void Load(TagCompound tag) {
			var downed = tag.GetList<string>("downed");
			downedPharaoh = downed.Contains("pharaoh");
		}

		public override void LoadLegacy(BinaryReader reader) {
			int loadVersion = reader.ReadInt32();
			if (loadVersion == 0) {
				BitsByte flags = reader.ReadByte();
				downedPharaoh = flags[0];
			}
			else {
				mod.Logger.WarnFormat("Pyresense: Unknown loadVersion: {0}", loadVersion);
			}
		}

		public override void NetSend(BinaryWriter writer) {
			var flags = new BitsByte();
			flags[0] = downedPharaoh;
			writer.Write(flags);
		}

		public override void NetReceive(BinaryReader reader) {
			BitsByte flags = reader.ReadByte();
			downedPharaoh = flags[0];

		}
	}
}