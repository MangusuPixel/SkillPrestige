namespace SkillPrestige.SpaceCore;

public class SpaceCoreSkillRegistrations
{
    public static List<SpaceCoreSkill> AllSkillsRegistered => new List<SpaceCoreSkill>
    {
        new LuckSkill(),
        new YetAnother_CookingSkill(),
        new BinningSkill(),
        new SocializingSkill(),
        new TravellingSkill(),
        new ArchaeologySkill(),
        new SpookySkill(),
        new ArsVenefici_WizardrySkill(),
        new RogueSkill(),
        new BardSkill(),
        new DruidSkill(),
        new PaladinSkill(),
        new WitchcraftSkill(),
        new SewingSkill(),
        new WizardrySkill(),
        new Blue_CookingSkill(),
    };
}
internal class LuckSkill : SpaceCoreSkill
{
    public LuckSkill() : base("moonslime.Luck", "moonslime.LuckSkill", "Luck Skill", "Luck", 5) { }
}
internal class YetAnother_CookingSkill : SpaceCoreSkill
{
    public YetAnother_CookingSkill() : base("moonslime.Cooking", "moonslime.CookingSkill", "Cooking Skill [Moon]", "Cooking", 6) { }
}
internal class BinningSkill : SpaceCoreSkill
{
    public BinningSkill() : base("drbirbdev.Binning", "drbirbdev.BinningSkill", "Binning Skill", "Binning", 7) { }
}
internal class SocializingSkill : SpaceCoreSkill
{
    public SocializingSkill() : base("drbirbdev.Socializing", "drbirbdev.SocializingSkill", "Socializing Skill", "Socializing", 8) { }
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
internal class ArsVenefici_WizardrySkill : SpaceCoreSkill
{
    public ArsVenefici_WizardrySkill() : base("HeyImAmethyst.Wizardry", "HeyImAmethyst.ArsVenefici", "Wizardry Skill [Amethyst]", "Wizardry", 13) { }
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
internal class SewingSkill : SpaceCoreSkill
{
    public SewingSkill() : base("selph.TextileExpansionCode_TextileSkill", "selph.TextileExpansionCode", "Sewing Skill", "Sewing", 19) { }
}
internal class WizardrySkill : SpaceCoreSkill
{
    public WizardrySkill() : base("moonslime.Wizard", "moonslime.WizardrySkill", "Wizardry Skill", "Wizardry Skill [Moon]", 20) { }
}
internal class Blue_CookingSkill : SpaceCoreSkill
{
    public Blue_CookingSkill() : base("blueberry.LoveOfCooking.CookingSkill", "blueberry.LoveOfCooking", "Cooking Skill [Blue]", "", 21) { }
}
