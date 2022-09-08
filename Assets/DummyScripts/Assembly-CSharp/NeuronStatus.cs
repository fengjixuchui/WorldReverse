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

public sealed class NeuronStatus : NeuronBase, IAutoAllocRecycle // TypeDefIndex: 20219
{
	// Fields
	private float _lastChangeTime; // 0x20
	private bool _stimulated; // 0x24

	// Constructors
	public NeuronStatus() {} // 0x000000018456C5C0-0x000000018456C650

	// Methods
	[BlackList] // 0x00000001897DC7F0-0x00000001897DC830
	// [XID] // 0x00000001897DC7F0-0x00000001897DC830
	public override void AutoAllocTypeFields() {} // 0x000000018456BDF0-0x000000018456BE90
	[BlackList] // 0x00000001897E6F30-0x00000001897E6F70
	// [XID] // 0x00000001897E6F30-0x00000001897E6F70
	public override void AutoRecycleTypeFields() {} // 0x000000018456BE90-0x000000018456BF40
	[BlackList] // 0x00000001897F1DB0-0x00000001897F1DF0
	// [XID] // 0x00000001897F1DB0-0x00000001897F1DF0
	public override void ReturnToObjectPool() {} // 0x000000018456C520-0x000000018456C5C0
	// [XID] // 0x00000001897FC6E0-0x00000001897FC700
	public override bool IsStimulated(float currentTime) => default; // 0x000000018456BF40-0x000000018456BFF0
	// [XID] // 0x0000000189803C70-0x0000000189803C90
	public override void SetStimulate(bool stimulate, float currentTime) {} // 0x000000018456C450-0x000000018456C520
	// [XID] // 0x000000018980B0F0-0x000000018980B110
	public override float GetChangeTime() => default; // 0x000000018456C060-0x000000018456C110
	// [XID] // 0x0000000189812780-0x00000001898127A0
	public override void Reset() {} // 0x000000018456C260-0x000000018456C310
}

