using AE86Mod.Survivors.AE86.SkillStates;

namespace AE86Mod.Survivors.AE86
{
    public static class AE86States
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
