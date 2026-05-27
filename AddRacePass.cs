using MelonLoader;
using BTD_Mod_Helper;
using AddRacePass;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Player;

[assembly: MelonInfo(typeof(AddRacePass.AddRacePass), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace AddRacePass;

public class AddRacePass : BloonsTD6Mod
{
    public static ModSettingInt racePassValue = new ModSettingInt(1)
    {
        displayName = "Amount of Race Passes to Add",
        slider = false
    };
    
    public override void OnApplicationStart()
    {
        ModHelper.Msg<AddRacePass>("AddRacePass loaded!");
    }

    public override void OnUpdate()
    {
        Game instance = Game.instance;
        InGame instance2 = InGame.instance;
        if (Input.GetKeyDown(KeyCode.F1) && instance != null)
        {
            Game.instance.playerService.Player.ClaimRacePass(LootFrom.gifting, racePassValue, null);
        }
        base.OnUpdate();
    }

}