using StardewValley;

namespace SkillPrestige.WizardryAdapter
{
    public interface IManaBarApi
    {
        void SetMaxMana(Farmer farmer, int newMaxMana);
        void AddToMaxMana(Farmer farmer, int maxManaToAdd);
        void SetManaToMax(Farmer farmer);
    }
}
