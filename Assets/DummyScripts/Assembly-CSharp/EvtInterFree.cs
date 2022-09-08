/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtInterFree : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20129
{
	// Fields
	private LCBaseIntee _intee; // 0x30
	private InterFreePriority _priority; // 0x38
	private ConfigBaseInterAction _cfg; // 0x40

	// Properties
	public LCBaseIntee intee { /* [XID] */ /* 0x00000001897FD9E0-0x00000001897FDA00 */ get => default; } // 0x0000000184905AC0-0x0000000184905B60 
	public InterFreePriority priority { /* [XID] */ /* 0x00000001898DA050-0x00000001898DA070 */ get => default; } // 0x00000001849059C0-0x0000000184905A60 
	public ConfigBaseInterAction cfg { /* [XID] */ /* 0x000000018980C770-0x000000018980C790 */ get => default; } // 0x00000001849057C0-0x0000000184905860 

	// Constructors
	public EvtInterFree() {} // 0x0000000184905C00-0x0000000184905C70

	// Methods
	[BlackList] // 0x00000001897DDF10-0x00000001897DDF50
	// [XID] // 0x00000001897DDF10-0x00000001897DDF50
	public override void AutoAllocTypeFields() {} // 0x0000000184905610-0x00000001849056B0
	[BlackList] // 0x00000001897E88D0-0x00000001897E8910
	// [XID] // 0x00000001897E88D0-0x00000001897E8910
	public override void AutoRecycleTypeFields() {} // 0x00000001849056B0-0x0000000184905760
	[BlackList] // 0x00000001897F3690-0x00000001897F36D0
	// [XID] // 0x00000001897F3690-0x00000001897F36D0
	public override void ReturnToObjectPool() {} // 0x0000000184905B60-0x0000000184905C00
	// [XID] // 0x0000000189813EE0-0x0000000189813F00
	public void Init(LCBaseIntee intee, InterFreePriority priority, ConfigBaseInterAction cfg) {} // 0x0000000184905860-0x0000000184905960
}

