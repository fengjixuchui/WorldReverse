/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtGadgetState : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20119
{
	// Fields
	private uint _fromState; // 0x30
	private uint _gState; // 0x34

	// Constructors
	public EvtGadgetState() {} // 0x0000000182043AD0-0x0000000182043B30

	// Methods
	[BlackList] // 0x0000000189B0D770-0x0000000189B0D7B0
	// [XID] // 0x0000000189B0D770-0x0000000189B0D7B0
	public override void AutoAllocTypeFields() {} // 0x0000000182043410-0x00000001820434B0
	[BlackList] // 0x0000000189B179A0-0x0000000189B179E0
	// [XID] // 0x0000000189B179A0-0x0000000189B179E0
	public override void AutoRecycleTypeFields() {} // 0x00000001820434B0-0x0000000182043560
	[BlackList] // 0x0000000189B22110-0x0000000189B22150
	// [XID] // 0x0000000189B22110-0x0000000189B22150
	public override void ReturnToObjectPool() {} // 0x0000000182043920-0x00000001820439C0
	// [XID] // 0x0000000189B2C690-0x0000000189B2C6B0
	public void Init(uint targetID, uint fromState, uint gState) {} // 0x0000000182043630-0x0000000182043720
	// [XID] // 0x0000000189B33C00-0x0000000189B33C20
	public GadgetState GetGadgetFromState() => default; // 0x0000000182043880-0x0000000182043920
	// [XID] // 0x00000001897AE2C0-0x00000001897AE2E0
	public GadgetState GetGadgetState() => default; // 0x0000000182043720-0x00000001820437C0
	// [XID] // 0x0000000189B42DB0-0x0000000189B42DD0
	public override string ToString() => default; // 0x00000001820439C0-0x0000000182043AD0
}

