/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AIDefendAreaKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 19951
{
	// Fields
	private ConfigAIDefendArea config; // 0x18
	public float defendRange; // 0x20
	public SimplePolygon? defendArea; // 0x28
	public Vector3 defendCenter; // 0x40
	public bool isInDefendRange; // 0x4C

	// Constructors
	public AIDefendAreaKnowledge() {} // 0x00000001817E69F0-0x00000001817E6A80

	// Methods
	[BlackList] // 0x0000000189AA6E40-0x0000000189AA6E80
	// [XID] // 0x0000000189AA6E40-0x0000000189AA6E80
	public override void AutoAllocTypeFields() {} // 0x00000001817E6160-0x00000001817E6200
	[BlackList] // 0x0000000189AB1820-0x0000000189AB1860
	// [XID] // 0x0000000189AB1820-0x0000000189AB1860
	public override void AutoRecycleTypeFields() {} // 0x00000001817E6200-0x00000001817E62F0
	[BlackList] // 0x0000000189ABC3A0-0x0000000189ABC3E0
	// [XID] // 0x0000000189ABC3A0-0x0000000189ABC3E0
	public override void ReturnToObjectPool() {} // 0x00000001817E6950-0x00000001817E69F0
	// [XID] // 0x0000000189709C90-0x0000000189709CB0
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, AIKnowledge knowledge, LCAIBetaData aiCreationData) {} // 0x00000001817E6780-0x00000001817E6950
	// [XID] // 0x0000000189ACE230-0x0000000189ACE250
	public void InitDefendArea(ConfigAIDefendArea config, AIKnowledge knowledge, LCAIBetaData aiCreationData) {} // 0x00000001817E6570-0x00000001817E6720
	// [XID] // 0x0000000189AD5FC0-0x0000000189AD5FE0
	public bool CheckInDefendArea(Vector3 point) => default; // 0x00000001817E62F0-0x00000001817E64B0
}

