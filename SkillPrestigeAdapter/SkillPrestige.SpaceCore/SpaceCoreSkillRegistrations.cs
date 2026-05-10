namespace SkillPrestige.SpaceCore;

public class SpaceCoreSkillRegistrations
{
    public static List<SpaceCoreSkill> AllSkillsRegistered => new List<SpaceCoreSkill>
    {
        new LuckSkill(),
        new CookingSkill(),
        new BinningSkill(),
        new SocializingSkill(),
        new SlimingSkill(),
        new TravellingSkill(),
        new ArchaeologySkill(),
        new SpookySkill(),
        new WizardrySkill(),
        new RogueSkill(),
        new BardSkill(),
        new DruidSkill(),
        new PaladinSkill(),
        new WitchcraftSkill(),
    };
}
internal class LuckSkill : SpaceCoreSkill
{
    public LuckSkill() : base("moonslime.Luck", "moonslime.LuckSkill", "Luck Skill", "Luck", 5) { }
}
internal class CookingSkill : SpaceCoreSkill
{
    public CookingSkill() : base("moonslime.Cooking", "moonslime.CookingSkill", "Yet Another Cooking Skill", "Cooking", 6) { }
}
internal class BinningSkill : SpaceCoreSkill
{
    public BinningSkill() : base("drbirbdev.Binning", "drbirbdev.BinningSkill", "Binning Skill", "Binning", 7) { }
}
internal class SocializingSkill : SpaceCoreSkill
{
    public SocializingSkill() : base("drbirbdev.Socializing", "drbirbdev.SocializingSkill", "Socializing Skill", "Socializing", 8) { }
}
internal class SlimingSkill : SpaceCoreSkill
{
    public SlimingSkill() : base("drbirbdev.Sliming", "drbirbdev.SlimingSkill", "Sliming Skill", "Sliming", 9) { }
}
internal class TravellingSkill : SpaceCoreSkill
{
    public TravellingSkill() : base("Achtuur.Travelling", "Achtuur.StardewTravelSkill", "Stardew Travel Skill", "Travelling", 10) { }
}
internal class ArchaeologySkill : SpaceCoreSkill
{
    public ArchaeologySkill() : base("moonslime.Archaeology", "moonslime.ArchaeologySkill", "Archaeology Skill", "Archaeology", 11) { }
}
internal class SpookySkill : SpaceCoreSkill
{
    public SpookySkill() : base("moonslime.Spooky", "moonslime.SpookySkill", "Scaring/Thieving Skill", "Scaring", 12) { }
}
internal class WizardrySkill : SpaceCoreSkill
{
    public WizardrySkill() : base("HeyImAmethyst.Wizardry", "HeyImAmethyst.ArsVenefici", "Wizardry Skill from Ars Venifici", "Wizardry", 13) { }
}
internal class RogueSkill : SpaceCoreSkill
{
    public RogueSkill() : base("DestyNova.SwordAndSorcery.Rogue", "KCC.SnS", "Artificer Skill of SnS", "Artificer", 14) { }
}
internal class BardSkill : SpaceCoreSkill
{
    public BardSkill() : base("DestyNova.SwordAndSorcery.Bardics", "KCC.SnS", "Bard Skill of SnS", "Bard", 15) { }
}
internal class DruidSkill : SpaceCoreSkill
{
    public DruidSkill() : base("DestyNova.SwordAndSorcery.Druidics", "KCC.SnS", "Druid Skill of SnS", "Druid", 16) { }
}
internal class PaladinSkill : SpaceCoreSkill
{
    public PaladinSkill() : base("DestyNova.SwordAndSorcery.Paladin", "KCC.SnS", "Paladin Skill of SnS", "Paladin", 17) { }
}
internal class WitchcraftSkill : SpaceCoreSkill
{
    public WitchcraftSkill() : base("DestyNova.SwordAndSorcery.Witchcraft", "KCC.SnS", "Witchcraft Skill of SnS", "Witchcraft", 18) { }
}
