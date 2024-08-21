using HANDReturns.Survivors.HANDReturns.SkillStates;

namespace HANDReturns.Survivors.HANDReturns {
    public static class HANDReturnsStates {
        public static void Init() {
            Modules.Content.AddEntityState(typeof(PunchCombo));

            Modules.Content.AddEntityState(typeof(ShootDrone));

            Modules.Content.AddEntityState(typeof(Overclock));

            Modules.Content.AddEntityState(typeof(HammerSwing));
        }
    }
}
