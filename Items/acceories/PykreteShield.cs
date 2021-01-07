using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pykretemod.Items.acceories
{
    [AutoloadEquip(EquipType.Shield)]
    class PykreteShield : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Movement decreased by 10%" + " and grants immunity to knockback");
        }
        public override void SetDefaults()
        {
            item.defense = 4;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed -= 0.1f;
            player.noKnockback = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Pykrete>(), 10);
            //recipe.AddIngredient(ItemID.CobaltShield);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
