using Ae86Mod.Survivors.Ae86.SkillStates;

namespace Ae86Mod.Survivors.Ae86
{
    public static class Ae86States
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
