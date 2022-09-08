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

public sealed class EvtAvatarBecomeThreat : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20058
{
	// Properties
	public BaseEntity fromEntity { /* [XID] */ /* 0x0000000189BC8C20-0x0000000189BC8C60 */ get; /* [XID] */ /* 0x0000000189BBDE20-0x0000000189BBDE60 */ private set; } // 0x000000018201C610-0x000000018201C670 0x000000018201C450-0x000000018201C4B0
	public bool becomeThreat { /* [XID] */ /* 0x0000000189BDDD20-0x0000000189BDDD60 */ get; /* [XID] */ /* 0x0000000189BD32B0-0x0000000189BD32F0 */ private set; } // 0x000000018201C390-0x000000018201C3F0 0x000000018201C6D0-0x000000018201C730

	// Constructors
	public EvtAvatarBecomeThreat() {} // 0x000000018201C9F0-0x000000018201CA50

	// Methods
	[BlackList] // 0x0000000189B9ED50-0x0000000189B9ED90
	// [XID] // 0x0000000189B9ED50-0x0000000189B9ED90
	public override void AutoAllocTypeFields() {} // 0x000000018201C160-0x000000018201C200
	[BlackList] // 0x0000000189BA9440-0x0000000189BA9480
	// [XID] // 0x0000000189BA9440-0x0000000189BA9480
	public override void AutoRecycleTypeFields() {} // 0x000000018201C200-0x000000018201C320
	[BlackList] // 0x0000000189BB3970-0x0000000189BB39B0
	// [XID] // 0x0000000189BB3970-0x0000000189BB39B0
	public override void ReturnToObjectPool() {} // 0x000000018201C790-0x000000018201C830
	// [XID] // 0x00000001895ED870-0x00000001895ED890
	public void Init(uint targetID, BaseEntity fromEntity, bool becomeThreat) {} // 0x000000018201C4B0-0x000000018201C610
	// [XID] // 0x00000001895F4FD0-0x00000001895F4FF0
	public override string ToString() => default; // 0x000000018201C830-0x000000018201C9F0
}

