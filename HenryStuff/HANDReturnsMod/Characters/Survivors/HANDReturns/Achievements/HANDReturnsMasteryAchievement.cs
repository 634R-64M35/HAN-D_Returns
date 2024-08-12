using RoR2;
using HANDReturns.Modules.Achievements;

namespace HANDReturns.Survivors.HANDReturns.Achievements {
    [RegisterAchievement(identifier, unlockableIdentifier, null, null)]
    public class HANDReturnsMasteryAchievement : BaseMasteryAchievement {
        public const string identifier = HANDReturnsSurvivor.HANDReturns_PREFIX + "MASTERY_ACHIEVEMENT";
        public const string unlockableIdentifier = HANDReturnsSurvivor.HANDReturns_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => HANDReturnsSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}