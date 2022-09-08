/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreeEntity : ScenePropEntity, IAutoAllocRecycle // TypeDefIndex: 19885
{
	// Fields
	public ICombatSceneProp treeObj; // 0x588

	// Constructors
	public TreeEntity() {} // 0x00000001844033A0-0x0000000184403420

	// Methods
	// [XID] // 0x000000018981BAC0-0x000000018981BAE0
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFCFFD */) {} // 0x0000000184402520-0x0000000184402600
	// [XID] // 0x0000000189822F50-0x0000000189822F70
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFD001 */, bool runtimeIDChange = false /* Metadata: 0x00AFD005 */) {} // 0x0000000184402600-0x00000001844026E0
	// [XID] // 0x000000018982A990-0x000000018982A9B0
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x0000000184402120-0x00000001844021F0
	// [XID] // 0x0000000189831DE0-0x0000000189831E00
	public void Reset(int bushId) {} // 0x0000000184402250-0x0000000184402520
	public override bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AFD006 */, bool isRecoverFromServer = false /* Metadata: 0x00AFD007 */) => default;
	// [XID] // 0x00000001898393E0-0x0000000189839400
	public override long GetScenePropID() => default; // 0x0000000184403040-0x0000000184403100
	// [IDTag] // 0x00000001898409D0-0x0000000189840A10
	// [XID] // 0x00000001898409D0-0x0000000189840A10
	public override Vector3 GetHitPosition(Vector3 center, Vector3 extents) => default; // 0x00000001844026E0-0x0000000184402850
	// [IDTag] // 0x000000018984AF90-0x000000018984AFD0
	// [XID] // 0x000000018984AF90-0x000000018984AFD0
	public override Vector3 GetHitPosition(Vector3 center, float radius) => default; // 0x0000000184402850-0x0000000184402F60
	[BlackList] // 0x0000000189855130-0x0000000189855170
	// [XID] // 0x0000000189855130-0x0000000189855170
	public override void AutoAllocTypeFields() {} // 0x0000000184401ED0-0x0000000184401F70
	[BlackList] // 0x000000018985F410-0x000000018985F450
	// [XID] // 0x000000018985F410-0x000000018985F450
	public override void AutoRecycleTypeFields() {} // 0x0000000184401F70-0x0000000184402020
	[BlackList] // 0x0000000189869CE0-0x0000000189869D20
	// [XID] // 0x0000000189869CE0-0x0000000189869D20
	public override void ReturnToObjectPool() {} // 0x0000000184403300-0x00000001844033A0
}

