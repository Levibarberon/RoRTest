using RoR2;
using AE86Mod.Modules.Achievements;

namespace AE86Mod.Survivors.AE86.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class AE86MasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = AE86Survivor.HENRY_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = AE86Survivor.HENRY_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => AE86Survivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}