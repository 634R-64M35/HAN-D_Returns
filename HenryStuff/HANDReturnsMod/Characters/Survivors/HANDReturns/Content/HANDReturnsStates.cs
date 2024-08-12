using HANDReturns.Survivors.HANDReturns.SkillStates;

namespace HANDReturns.Survivors.HANDReturns
{
    public static class HANDReturnsStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
