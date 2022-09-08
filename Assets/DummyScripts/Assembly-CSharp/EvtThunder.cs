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

public sealed class EvtThunder : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20173
{
	// Fields
	public Vector3 fromPos; // 0x30
	public Vector3 toPos; // 0x3C
	public bool isFar; // 0x48

	// Constructors
	public EvtThunder() {} // 0x0000000182CC23D0-0x0000000182CC2430

	// Methods
	[BlackList] // 0x0000000189A7CFB0-0x0000000189A7CFF0
	// [XID] // 0x0000000189A7CFB0-0x0000000189A7CFF0
	public override void AutoAllocTypeFields() {} // 0x0000000182CC1E20-0x0000000182CC1EC0
	[BlackList] // 0x0000000189A87900-0x0000000189A87940
	// [XID] // 0x0000000189A87900-0x0000000189A87940
	public override void AutoRecycleTypeFields() {} // 0x0000000182CC1EC0-0x0000000182CC1F90
	[BlackList] // 0x0000000189A92060-0x0000000189A920A0
	// [XID] // 0x0000000189A92060-0x0000000189A920A0
	public override void ReturnToObjectPool() {} // 0x0000000182CC2250-0x0000000182CC22F0
	// [XID] // 0x0000000189A9C690-0x0000000189A9C6B0
	public void Init(Vector3 fromPos, Vector3 toPos, bool isFar) {} // 0x0000000182CC2060-0x0000000182CC2190
	// [XID] // 0x0000000189AA3DE0-0x0000000189AA3E00
	public override string ToString() => default; // 0x0000000182CC22F0-0x0000000182CC23D0
}

