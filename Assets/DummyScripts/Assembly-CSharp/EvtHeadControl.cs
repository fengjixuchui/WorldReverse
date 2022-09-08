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

public sealed class EvtHeadControl : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20122
{
	// Properties
	public BaseEntity targetEntity { /* [XID] */ /* 0x00000001895F4F90-0x00000001895F4FD0 */ get; /* [XID] */ /* 0x00000001895EA9B0-0x00000001895EA9F0 */ private set; } // 0x000000018458A880-0x000000018458A8E0 0x000000018458AA00-0x000000018458AA60
	public VCBaseHeadController.TargetType type { /* [XID] */ /* 0x0000000189609FF0-0x000000018960A030 */ get; /* [XID] */ /* 0x00000001895FF590-0x00000001895FF5D0 */ private set; } // 0x000000018458AA60-0x000000018458AAC0 0x000000018458A9A0-0x000000018458AA00
	public bool target { /* [XID] */ /* 0x000000018961EF40-0x000000018961EF80 */ get; /* [XID] */ /* 0x00000001896143D0-0x0000000189614410 */ private set; } // 0x000000018458A5B0-0x000000018458A610 0x000000018458A670-0x000000018458A6D0

	// Constructors
	public EvtHeadControl() {} // 0x000000018458AE10-0x000000018458AE70

	// Methods
	[BlackList] // 0x0000000189BC5B00-0x0000000189BC5B40
	// [XID] // 0x0000000189BC5B00-0x0000000189BC5B40
	public override void AutoAllocTypeFields() {} // 0x000000018458A340-0x000000018458A3E0
	[BlackList] // 0x0000000189BD0400-0x0000000189BD0440
	// [XID] // 0x0000000189BD0400-0x0000000189BD0440
	public override void AutoRecycleTypeFields() {} // 0x000000018458A3E0-0x000000018458A540
	[BlackList] // 0x0000000189BDAC20-0x0000000189BDAC60
	// [XID] // 0x0000000189BDAC20-0x0000000189BDAC60
	public override void ReturnToObjectPool() {} // 0x000000018458AAC0-0x000000018458AB60
	// [XID] // 0x0000000189629450-0x0000000189629470
	public void Init(uint targetID, BaseEntity focusEntity, VCBaseHeadController.TargetType type, bool target) {} // 0x000000018458A6D0-0x000000018458A880
	// [XID] // 0x0000000189630D80-0x0000000189630DA0
	public override string ToString() => default; // 0x000000018458AB60-0x000000018458AE10
}

