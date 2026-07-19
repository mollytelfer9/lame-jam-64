using UnrealBuildTool;

public class Clock FarmEditorTarget : TargetRules
{
	public Clock FarmEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Clock Farm");
	}
}
