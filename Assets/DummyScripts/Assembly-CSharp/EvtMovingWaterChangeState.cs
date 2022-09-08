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

public sealed class EvtMovingWaterChangeState : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20135
{
	// Fields
	public Vector3 position; // 0x30
	public bool isStart; // 0x3C
	public uint entityId; // 0x40
	public int routeIndex; // 0x44
	public uint routeId; // 0x48

	// Constructors
	public EvtMovingWaterChangeState() {} // 0x0000000184847FC0-0x0000000184848020

	// Methods
	[BlackList] // 0x00000001898FA7C0-0x00000001898FA800
	// [XID] // 0x00000001898FA7C0-0x00000001898FA800
	public override void AutoAllocTypeFields() {} // 0x0000000184847A40-0x0000000184847AE0
	[BlackList] // 0x00000001899052A0-0x00000001899052E0
	// [XID] // 0x00000001899052A0-0x00000001899052E0
	public override void AutoRecycleTypeFields() {} // 0x0000000184847AE0-0x0000000184847BA0
	[BlackList] // 0x000000018990FAF0-0x000000018990FB30
	// [XID] // 0x000000018990FAF0-0x000000018990FB30
	public override void ReturnToObjectPool() {} // 0x0000000184847E70-0x0000000184847F10
	// [XID] // 0x00000001897709B0-0x00000001897709D0
	public void Init(uint id, uint routeId, int index, Vector3 position, bool isStart = false /* Metadata: 0x00AFD27E */) {} // 0x0000000184847C70-0x0000000184847DB0
	// [XID] // 0x0000000189921DC0-0x0000000189921DE0
	public override string ToString() => default; // 0x0000000184847F10-0x0000000184847FC0
}

