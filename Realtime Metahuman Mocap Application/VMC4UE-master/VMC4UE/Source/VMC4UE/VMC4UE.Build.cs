// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class VMC4UE : ModuleRules
{
    public VMC4UE (ReadOnlyTargetRules Target) : base (Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange (new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "AnimGraphRuntime", "UEOSC" });
    }
}