using SpaceCore;

namespace SkillPrestige.Professions
{
    /// <summary>Special handling for SpaceCore skills.</summary>
    internal class SpaceCoreProfessionHandling(Skills.Skill.Profession profession) : IProfessionSpecialHandling
    {
        private readonly Skills.Skill.Profession _profession = profession;

        public void ApplyEffect()
        {
            this._profession.DoImmediateProfessionPerk();
        }

        public void RemoveEffect()
        {
            this._profession.UndoImmediateProfessionPerk();
        }
    }
}
