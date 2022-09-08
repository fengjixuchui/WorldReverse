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

public sealed class EvtTransmitAvatar : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20174
{
	// Fields
	public Vector3 pos; // 0x30
	public float yaw; // 0x3C
	public EnterType enterType; // 0x40
	public TransmitType transType; // 0x44
	public uint token; // 0x48

	// Nested types
	public enum TransmitType // TypeDefIndex: 20175
	{
		Default = 0,
		Wormhole = 1,
		Quick = 2,
		DirectlySetPos = 3
	}

	// Constructors
	public EvtTransmitAvatar() {} // 0x0000000181B0BD40-0x0000000181B0BDA0

	// Methods
	[BlackList] // 0x0000000189AAB2F0-0x0000000189AAB330
	// [XID] // 0x0000000189AAB2F0-0x0000000189AAB330
	public override void AutoAllocTypeFields() {} // 0x0000000181B0B790-0x0000000181B0B830
	[BlackList] // 0x0000000189AB5D20-0x0000000189AB5D60
	// [XID] // 0x0000000189AB5D20-0x0000000189AB5D60
	public override void AutoRecycleTypeFields() {} // 0x0000000181B0B830-0x0000000181B0B8F0
	[BlackList] // 0x0000000189AC06B0-0x0000000189AC06F0
	// [XID] // 0x0000000189AC06B0-0x0000000189AC06F0
	public override void ReturnToObjectPool() {} // 0x0000000181B0BBC0-0x0000000181B0BC60
	// [XID] // 0x000000018995E450-0x000000018995E470
	public void Init(Vector3 pos, TransmitType transType, EnterType enterType, uint token, float yaw = 0f /* Metadata: 0x00AFD2A7 */) {} // 0x0000000181B0B9C0-0x0000000181B0BB00
	// [XID] // 0x0000000189AD2B60-0x0000000189AD2B80
	public override string ToString() => default; // 0x0000000181B0BC60-0x0000000181B0BD40
}

