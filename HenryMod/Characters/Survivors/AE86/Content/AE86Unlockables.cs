using AE86Mod.Survivors.AE86.Achievements;
using RoR2;
using UnityEngine;

namespace AE86Mod.Survivors.AE86
{
    public static class AE86Unlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                AE86MasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(AE86MasteryAchievement.identifier),
                AE86Survivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
