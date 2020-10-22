using Terraria.ID;
using Terraria.ModLoader;

namespace DacernQOL.Items
{
	public class Recipes : GlobalItem
    {
        public class Crafting : GlobalItem
        {
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Candle, 1);
                recipe.AddIngredient(ItemID.WaterBucket, 2);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.WaterCandle, 1);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.IronOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.LeadOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LeadOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.IronOre);


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CopperOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.TinOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TinOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CopperOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SilverOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.TungstenOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TungstenOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.SilverOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PlatinumOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.GoldOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.GoldOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.PlatinumOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CorruptSeeds, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CrimsonSeeds);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CrimsonSeeds, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CorruptSeeds);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.DemoniteOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CrimtaneOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CrimtaneOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.DemoniteOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.OrichalcumOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.MythrilOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PalladiumOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CobaltOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CobaltOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.PalladiumOre);
                recipe.AddRecipe();


                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MythrilOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.OrichalcumOre);
                recipe.AddRecipe();
                
                
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TitaniumOre, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.AdamantiteOre);
                recipe.AddRecipe();
            }
        }
    }
    public class BoneAxe : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 9;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 19;
            item.useAnimation = 19;
            item.axe = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.crit = 4;
            item.value = 3000;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }


    }
}