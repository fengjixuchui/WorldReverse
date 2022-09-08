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

public sealed class EvtCutsceneNotify : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20087
{
	// Fields
	private OP _op; // 0x30

	// Properties
	public OP op { /* [XID] */ /* 0x000000018972A5F0-0x000000018972A610 */ get => default; } // 0x0000000181FC2F10-0x0000000181FC2FB0 

	// Nested types
	public enum OP // TypeDefIndex: 20088
	{
		INVALID = -1,
		START = 0,
		FINISH = 1
	}

	// Constructors
	public EvtCutsceneNotify() {} // 0x0000000181FC3110-0x0000000181FC3180

	// Methods
	[BlackList] // 0x0000000189B9ED10-0x0000000189B9ED50
	// [XID] // 0x0000000189B9ED10-0x0000000189B9ED50
	public override void AutoAllocTypeFields() {} // 0x0000000181FC2B70-0x0000000181FC2C10
	[BlackList] // 0x0000000189BA9400-0x0000000189BA9440
	// [XID] // 0x0000000189BA9400-0x0000000189BA9440
	public override void AutoRecycleTypeFields() {} // 0x0000000181FC2C10-0x0000000181FC2CC0
	[BlackList] // 0x0000000189BB3930-0x0000000189BB3970
	// [XID] // 0x0000000189BB3930-0x0000000189BB3970
	public override void ReturnToObjectPool() {} // 0x0000000181FC3070-0x0000000181FC3110
	// [XID] // 0x0000000189BC5B40-0x0000000189BC5B60
	public void Init(uint targetID, OP op) {} // 0x0000000181FC2D20-0x0000000181FC2E00
	// [XID] // 0x0000000189BCD540-0x0000000189BCD560
	public override void Clear() {} // 0x0000000181FC2E00-0x0000000181FC2EB0
}

