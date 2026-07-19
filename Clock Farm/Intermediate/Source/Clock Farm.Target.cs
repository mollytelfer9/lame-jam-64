using UnrealBuildTool;

public class Clock FarmTarget : TargetRules
{
	public Clock FarmTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Clock Farm");
	}
}
