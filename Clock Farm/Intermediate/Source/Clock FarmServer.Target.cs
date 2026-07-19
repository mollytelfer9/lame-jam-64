using UnrealBuildTool;

public class Clock FarmServerTarget : TargetRules
{
	public Clock FarmServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Clock Farm");
	}
}
