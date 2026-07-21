using StardewModdingAPI;

namespace SkillPrestige.WizardryAdapter
{
    public interface IWizardSkillApi
    {
        /*********
        ** Methods
        *********/
        /// <summary>Cause the player to forget all learned spell and reset earned spell points to zero. This should only be used in very specialized cases like Skill Prestige.</summary>
        /// <param name="manifest">The mod calling the API.</param>
        void ResetProgress(IManifest manifest);
    }
}

