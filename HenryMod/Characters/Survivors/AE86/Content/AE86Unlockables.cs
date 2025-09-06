using Ae86Mod.Survivors.Ae86.Achievements;
using RoR2;
using UnityEngine;

namespace Ae86Mod.Survivors.Ae86
{
    public static class Ae86Unlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                Ae86MasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(Ae86MasteryAchievement.identifier),
                Ae86Survivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
