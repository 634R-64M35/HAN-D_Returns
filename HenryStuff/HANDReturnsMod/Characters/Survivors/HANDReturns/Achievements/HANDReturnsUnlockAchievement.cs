using RoR2;
using RoR2.Achievements;

namespace HANDReturns.Survivors.HANDReturns.Achievements {
    [RegisterAchievement(identifier, unlockableIdentifier, null, null)]
    public class HANDReturnsUnlockAchievement : BaseAchievement {
        public const string identifier = HANDReturnsSurvivor.HANDReturns_PREFIX + "UNLOCK_ACHIEVEMENT";
        public const string unlockableIdentifier = HANDReturnsSurvivor.HANDReturns_PREFIX + "playUnlockable";
    }
}