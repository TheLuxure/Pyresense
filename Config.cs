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
    }
}
