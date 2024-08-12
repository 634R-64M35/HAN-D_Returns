using HANDReturns.Survivors.HANDReturns.Achievements;
using RoR2;
using UnityEngine;

namespace HANDReturns.Survivors.HANDReturns
{
    public static class HANDReturnsUnlockables {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init() {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                HANDReturnsMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(HANDReturnsMasteryAchievement.identifier),
                HANDReturnsSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));

            characterUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                HANDReturnsUnlockAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(HANDReturnsUnlockAchievement.identifier),
                HANDReturnsSurvivor.instance.assetBundle.LoadAsset<Sprite>("texHANDReturnsIcon"));
        }
    }
}
