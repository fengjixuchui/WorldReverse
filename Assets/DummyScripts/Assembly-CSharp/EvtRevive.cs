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

public sealed class EvtRevive : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID // TypeDefIndex: 20149
{
	// Fields
	public uint reviverID; // 0x30

	// Constructors
	public EvtRevive() {} // 0x0000000182363070-0x00000001823630D0

	// Methods
	[BlackList] // 0x00000001895FDC40-0x00000001895FDC80
	// [XID] // 0x00000001895FDC40-0x00000001895FDC80
	public override void AutoAllocTypeFields() {} // 0x0000000182362A70-0x0000000182362B10
	[BlackList] // 0x0000000189608850-0x0000000189608890
	// [XID] // 0x0000000189608850-0x0000000189608890
	public override void AutoRecycleTypeFields() {} // 0x0000000182362B10-0x0000000182362BC0
	[BlackList] // 0x0000000189612DA0-0x0000000189612DE0
	// [XID] // 0x0000000189612DA0-0x0000000189612DE0
	public override void ReturnToObjectPool() {} // 0x0000000182362ED0-0x0000000182362F70
	// [XID] // 0x0000000189A6A500-0x0000000189A6A520
	public void Init(uint targetID, uint reviverID) {} // 0x0000000182362C90-0x0000000182362D70
	// [XID] // 0x0000000189624A90-0x0000000189624AB0
	public uint GetOtherID() => default; // 0x0000000182362D70-0x0000000182362E10
	// [XID] // 0x000000018962C1F0-0x000000018962C210
	public override string ToString() => default; // 0x0000000182362F70-0x0000000182363070
}

