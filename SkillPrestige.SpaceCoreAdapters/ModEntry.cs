using SkillPrestige.Mods;
using StardewModdingAPI;

namespace SkillPrestige.SpaceCoreAdapters;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        foreach (var skill in SpaceCoreSkillRegistrations.AllSkillsRegistered)
        {
            if (!this.Helper.ModRegistry.IsLoaded(skill.UniqueModId))
            {
                continue;
            }
            ModHandler.RegisterMod(skill);
        }
    }
}
