/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AIThreatKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 20004
{
	// Fields
	public ConfigAIThreatSetting config; // 0x18
	public float viewThreatGrowRate; // 0x20
	public float hearThreatGrowRate; // 0x24
	public float feelThreatGrowRate; // 0x28
	public AIMath.AICurve viewAttenuation; // 0x30
	public AIMath.AICurve hearAttenuation; // 0x38
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public Dictionary<uint, ThreatInfo> candidateList; // 0x40
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public Dictionary<uint, ThreatInfo> threatList; // 0x48
	public ThreatInfo mainThreat; // 0x50
	public bool reachAwareThisFrame; // 0x58
	public bool reachAlertThisFrame; // 0x59
	public float? precombatSince; // 0x5C
	public bool enableHitFeeling; // 0x64
	public float threatBroadcastRange; // 0x68
	public TauntLevel resistTauntLevel; // 0x6C
	public float auxScoreChangeTargetCD; // 0x70

	// Constructors
	public AIThreatKnowledge() {} // 0x000000018517CD90-0x000000018517CE10

	// Methods
	[BlackList] // 0x00000001898A4CE0-0x00000001898A4D20
	// [XID] // 0x00000001898A4CE0-0x00000001898A4D20
	public override void AutoAllocTypeFields() {} // 0x000000018517BD00-0x000000018517BDF0
	[BlackList] // 0x00000001898AF470-0x00000001898AF4B0
	// [XID] // 0x00000001898AF470-0x00000001898AF4B0
	public override void AutoRecycleTypeFields() {} // 0x000000018517BDF0-0x000000018517BF00
	[BlackList] // 0x00000001898B9EC0-0x00000001898B9F00
	// [XID] // 0x00000001898B9EC0-0x00000001898B9F00
	public override void ReturnToObjectPool() {} // 0x000000018517CCF0-0x000000018517CD90
	// [XID] // 0x00000001898C4340-0x00000001898C4360
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, LCAIBetaData aiCreationData) {} // 0x000000018517C860-0x000000018517CCF0
	// [XID] // 0x00000001898CB910-0x00000001898CB930
	public void InitThreat(ConfigAIThreatSetting threatConfig, LCAIBetaData aiCreationData) {} // 0x000000018517BFC0-0x000000018517C450
	// [XID] // 0x00000001898B5DD0-0x00000001898B5DF0
	internal void RecoverFromServer(AIKnowledge aiKnowledge, LCAIBetaData data) {} // 0x000000018517C450-0x000000018517C800
}

