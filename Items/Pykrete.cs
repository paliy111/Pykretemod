using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Pykretemod.Items
{
    public class Pykrete : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Bar");
        }
        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 13;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 5, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 8);
            recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddRecipeGroup("IronBar", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
