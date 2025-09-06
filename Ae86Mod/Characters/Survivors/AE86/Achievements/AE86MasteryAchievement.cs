using RoR2;
using Ae86Mod.Modules.Achievements;

namespace Ae86Mod.Survivors.Ae86.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class Ae86MasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = Ae86Survivor.AE86_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = Ae86Survivor.AE86_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => Ae86Survivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}