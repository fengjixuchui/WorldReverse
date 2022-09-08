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

public sealed class EvtBleeding : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20071
{
	// Fields
	public uint sourceID; // 0x30
	public float loseHPValue; // 0x34
	public bool lethal; // 0x38

	// Constructors
	public EvtBleeding() {} // 0x000000018217EA60-0x000000018217EAC0

	// Methods
	[BlackList] // 0x0000000189843AA0-0x0000000189843AE0
	// [XID] // 0x0000000189843AA0-0x0000000189843AE0
	public override void AutoAllocTypeFields() {} // 0x000000018217E350-0x000000018217E3F0
	[BlackList] // 0x000000018984E040-0x000000018984E080
	// [XID] // 0x000000018984E040-0x000000018984E080
	public override void AutoRecycleTypeFields() {} // 0x000000018217E3F0-0x000000018217E4A0
	[BlackList] // 0x0000000189858320-0x0000000189858360
	// [XID] // 0x0000000189858320-0x0000000189858360
	public override void ReturnToObjectPool() {} // 0x000000018217E740-0x000000018217E7E0
	// [XID] // 0x00000001898628B0-0x00000001898628D0
	public void Init(uint targetID, uint fromID, float loseHPValue, bool lethal) {} // 0x000000018217E570-0x000000018217E680
	// [XID] // 0x0000000189869CC0-0x0000000189869CE0
	public override string ToString() => default; // 0x000000018217E7E0-0x000000018217EA60
}

