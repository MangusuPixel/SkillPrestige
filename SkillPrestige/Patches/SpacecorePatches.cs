using System;
using System.Linq;
using HarmonyLib;
using SkillPrestige.Framework;
using SkillPrestige.Logging;
using StardewValley;

namespace SkillPrestige.Patches
{
    internal class SpacecorePatches
    {
        internal static void Apply(Harmony harmony)
        {
            Logger.LogInformation("Patching Spacecore.");

            harmony.Patch(
                original: AccessTools.Method(typeof(SpaceCore.Interface.SkillLevelUpMenu),
                    nameof(SpaceCore.Interface.SkillLevelUpMenu.getImmediateProfessionPerk),
                    [typeof(int)]),
                prefix: new HarmonyMethod(typeof(SpacecorePatches), nameof(getImmediateProfessionPerk_Prefix))
            );
        }

        private static bool getImmediateProfessionPerk_Prefix(int whichProfession)
        {
            try
            {
                // Remove the immediate effects of owned professions before spacecore adds them again
                // Patch should be removed when spacecore is updated to check for duplicate effects:
                // https://github.com/spacechase0/StardewValleyMods/pull/584

                if (Game1.player.professions.Contains(whichProfession))
                {
                    var professions = Skill.AllSkills.SelectMany(x => x.Professions);
                    var profession = professions.SingleOrDefault(x => x.Id == whichProfession);
                    profession?.SpecialHandling?.RemoveEffect();
                }
            } catch(Exception ex)
            {
                Logger.LogError($"Failed in {nameof(getImmediateProfessionPerk_Prefix)}:\n{ex}");
            }

            return true;
        }
    }
}
