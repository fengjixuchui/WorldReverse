/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCAIBetaData // TypeDefIndex: 20622
{
	// Fields
	public static LCAIBetaData DefaultData; // 0x00
	public Vector3? bornPos; // 0x10
	public uint initialPoseID; // 0x20
	public uint currentPoseID; // 0x24
	public float defendAreaRange; // 0x28
	public uint defendAreaID; // 0x2C
	public uint wanderAreaID; // 0x30
	public string nerveSettingName; // 0x38
	public string sensingTemplate; // 0x40
	public bool disableWander; // 0x48
	public uint landingPointID; // 0x4C
	public uint extractionPointID; // 0x50
	public ConfigLevelMonsterAIPatrol aiPatrolSetting; // 0x58
	public bool forceCombatOnSpawn; // 0x60
	public bool standOnDistantMesh; // 0x61
	private SceneEntityAiInfo _protoAIInfo; // 0x68
	private MonsterRoute _serverRoute; // 0x70

	// Properties
	public SceneEntityAiInfo protoAIInfo { /* [XID] */ /* 0x00000001897A3C70-0x00000001897A3C90 */ get => default; /* [XID] */ /* 0x00000001897A7520-0x00000001897A7540 */ set {} } // 0x0000000182655A00-0x0000000182655AA0 0x0000000182655AA0-0x0000000182655BA0
	public MonsterRoute serverRoute { /* [XID] */ /* 0x00000001897AF030-0x00000001897AF050 */ get => default; /* [XID] */ /* 0x000000018969C8D0-0x000000018969C8F0 */ set {} } // 0x0000000182655BA0-0x0000000182655C40 0x0000000182655C40-0x0000000182655D40

	// Constructors
	public LCAIBetaData() {} // 0x0000000182655DC0-0x0000000182655E60
	static LCAIBetaData() {} // 0x0000000182655D40-0x0000000182655DC0
}

