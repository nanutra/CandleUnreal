using UnrealBuildTool;

public class CandleTarget : TargetRules
{
	public CandleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Candle");
	}
}
