using UnrealBuildTool;

public class Clock FarmClientTarget : TargetRules
{
	public Clock FarmClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Clock Farm");
	}
}
