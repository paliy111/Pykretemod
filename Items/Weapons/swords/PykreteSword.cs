using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace Pykretemod.Items.Weapons.swords
{
    class PykreteSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Sword");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.damage = 15;
            item.crit = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Pykrete>(), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
