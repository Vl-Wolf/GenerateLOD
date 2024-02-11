// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GenerateLOD : ModuleRules
{
	public GenerateLOD(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] 
			{
				
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] 
			{
				
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core", 
				"EditorScriptingUtilities"
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore", 
				"EditorScriptingUtilities",
				"DeveloperSettings"
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				
			}
			);
	}
}
