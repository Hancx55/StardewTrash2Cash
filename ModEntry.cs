using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Menus;

using HarmonyLib;
using System.Security.Cryptography.X509Certificates;


namespace trash2cash
{
    /// <summary>The mod entry point.</summary>
    internal sealed class ModEntry : Mod
    {
   
        public override void Entry(IModHelper helper)
        {


            helper.Events.GameLoop.DayStarted += this.OnDayStarted;

            var harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.PatchAll();



        }

        private void OnDayStarted(object? sender, DayStartedEventArgs e)
        {
            this.Monitor.Log("GOODMORNING!!!", LogLevel.Info);
        }

        [HarmonyPatch(typeof(Utility), nameof(Utility.trashItem))]
        public static class TrashItemPatch
        {
            
            public static bool Prefix(Item item)
            {
                if (item == null)
                    return false;
                Game1.playSound("coin");
                Game1.player.Money += item.salePrice() * item.Stack;
                return false;
            }
        }

    }
}
