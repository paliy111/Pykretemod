using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Pykretemod.Items.armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class PykreteLeggings : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Pykrete>(), 16);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
