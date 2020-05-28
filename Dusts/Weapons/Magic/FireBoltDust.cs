using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Pyresense.Dusts.Weapons.Magic
{
	public class FireBoltDust : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.velocity.Y = Main.rand.Next(-10, 6) * 0.1f;
			dust.velocity.X *= 0.3f;
			dust.scale *= 1.5f;
			dust.alpha = 255;
		}
	}
}