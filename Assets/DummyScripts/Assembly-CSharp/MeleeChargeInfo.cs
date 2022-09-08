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

public sealed class MeleeChargeInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20213
{
	// Fields
	public const int RETRY_TIMES = 3; // Metadata: 0x00AFD3AE
	public ChargeStatus status; // 0x10
	public Vector3 curDestination; // 0x14
	private int _retryTimes; // 0x20

	// Nested types
	public enum ChargeStatus // TypeDefIndex: 20214
	{
		Inactive = 0,
		Charging = 1
	}

	// Constructors
	public MeleeChargeInfo() {} // 0x0000000185075A00-0x0000000185075A70

	// Methods
	[BlackList] // 0x0000000189695CB0-0x0000000189695CF0
	// [XID] // 0x0000000189695CB0-0x0000000189695CF0
	public override void AutoAllocTypeFields() {} // 0x0000000185074F80-0x0000000185075020
	[BlackList] // 0x00000001896A01F0-0x00000001896A0230
	// [XID] // 0x00000001896A01F0-0x00000001896A0230
	public override void AutoRecycleTypeFields() {} // 0x0000000185075020-0x00000001850750E0
	[BlackList] // 0x00000001896AA590-0x00000001896AA5D0
	// [XID] // 0x00000001896AA590-0x00000001896AA5D0
	public override void ReturnToObjectPool() {} // 0x0000000185075960-0x0000000185075A00
	// [XID] // 0x00000001896B4B10-0x00000001896B4B30
	public override void OnPoolAllocated() {} // 0x0000000185075870-0x0000000185075960
	// [XID] // 0x00000001896BBD40-0x00000001896BBD60
	public override void Clear() {} // 0x0000000185075140-0x0000000185075230
	// [XID] // 0x00000001896C3200-0x00000001896C3220
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000185075230-0x00000001850756F0
}

