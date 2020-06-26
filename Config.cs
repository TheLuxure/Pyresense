using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace Pyresense
{
    [Label("Settings")]
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        //[Header("Elemental Hearts Setting")]

        [Header("Vanilla Settings")]
        [DefaultValue(true)]
        [ReloadRequired]
        [Label("Retexture of Curse's")]
        public bool VanillaDebuffCurseRetexture;

        [DefaultValue(false)]
        [ReloadRequired]
        [Label("Thrown damage on thrown items")]
        [Tooltip("Returned thrown damage (1.4)")]
        public bool ReturnThrownDamage;

        [Header("(Experimental) Vanilla Settings")]
        [DefaultValue(false)]
        [ReloadRequired]
        [Label("King Slime can be with different colors")]
        public bool KingSlimeColored;
    }
}
