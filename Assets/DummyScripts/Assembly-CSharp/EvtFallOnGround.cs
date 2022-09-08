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

public sealed class EvtFallOnGround : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20110
{
	// Fields
	public GroundType groundType; // 0x30
	public Vector3 velocity; // 0x34
	public float waterDepth; // 0x40

	// Nested types
	public enum GroundType // TypeDefIndex: 20111
	{
		Land = 0,
		Water = 1,
		LandUnderWater = 2
	}

	// Constructors
	public EvtFallOnGround() {} // 0x0000000184B7F400-0x0000000184B7F460

	// Methods
	[BlackList] // 0x00000001899AA7E0-0x00000001899AA820
	// [XID] // 0x00000001899AA7E0-0x00000001899AA820
	public override void AutoAllocTypeFields() {} // 0x0000000184B7ECB0-0x0000000184B7ED50
	[BlackList] // 0x00000001899B5020-0x00000001899B5060
	// [XID] // 0x00000001899B5020-0x00000001899B5060
	public override void AutoRecycleTypeFields() {} // 0x0000000184B7ED50-0x0000000184B7EE10
	[BlackList] // 0x00000001899BF870-0x00000001899BF8B0
	// [XID] // 0x00000001899BF870-0x00000001899BF8B0
	public override void ReturnToObjectPool() {} // 0x0000000184B7F0D0-0x0000000184B7F170
	// [XID] // 0x00000001899C9E20-0x00000001899C9E40
	public void Init(uint targetID, GroundType type, Vector3 velocity, float waterDepth = 0f /* Metadata: 0x00AFD24E */) {} // 0x0000000184B7EEE0-0x0000000184B7F010
	// [XID] // 0x00000001899D16A0-0x00000001899D16C0
	public override string ToString() => default; // 0x0000000184B7F170-0x0000000184B7F400
}

