using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Pykretemod.Projectiles.Mage;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pykretemod.Items.Weapons.Mage
{
    public class PykreteWand : ModItem
    {
        public override void SetDefaults()
        {
            item.mana = 5;
            item.UseSound = SoundID.Item43;
            item.useStyle = 5;
            item.damage = 17;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 16;
            item.height = 16;
            item.shoot = mod.ProjectileType("PykreteProjectile");
            item.shootSpeed = 8f;
            item.knockBack = 4f;
            item.value = 10000;
            item.magic = true;
            item.rare = 1;
            item.noMelee = true;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Pykrete>(), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
