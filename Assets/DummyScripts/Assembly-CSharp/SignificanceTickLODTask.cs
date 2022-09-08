/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SignificanceTickLODTask : ThreadTask<SignificanceTickLODData>, IFrameSingletonTask // TypeDefIndex: 26646
{
	// Fields
	private ReentryChecker _reentryChecker; // 0x40
	private int _lastExecuteFrame; // 0x48
	private int _lastCollectFrame; // 0x4C
	private int _lastFlushFrame; // 0x50
	public TickObjectProxyLODManagerEntity _balanceTickGroupComputeThread; // 0x58
	public static bool forceCatchupFrame; // 0x00

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189A49770-0x0000000189A49790 */ get => default; } // 0x0000000184B31570-0x0000000184B31620 
	public int lastCollectFrame { /* [XID] */ /* 0x0000000189A51100-0x0000000189A51120 */ get => default; /* [XID] */ /* 0x0000000189A58680-0x0000000189A586A0 */ set {} } // 0x0000000184B313B0-0x0000000184B31450 0x0000000184B30AF0-0x0000000184B30BA0

	// Constructors
	public SignificanceTickLODTask() {} // 0x0000000184B314B0-0x0000000184B31570
	static SignificanceTickLODTask() {} // 0x0000000184B31450-0x0000000184B314B0

	// Methods
	// [IDTag] // 0x0000000189A60230-0x0000000189A60270
	// [XID] // 0x0000000189A60230-0x0000000189A60270
	public void Collect(bool fromJobThread) {} // 0x0000000184B30D60-0x0000000184B30E40
	// [IDTag] // 0x0000000189A6AC60-0x0000000189A6ACA0
	// [XID] // 0x0000000189A6AC60-0x0000000189A6ACA0
	public override void Collect() {} // 0x0000000184B30EA0-0x0000000184B30F40
	// [IDTag] // 0x0000000189A74F90-0x0000000189A74FD0
	// [XID] // 0x0000000189A74F90-0x0000000189A74FD0
	public void Execute(bool fromJobThread) {} // 0x0000000184B30BA0-0x0000000184B30D60
	// [IDTag] // 0x0000000189A7F9E0-0x0000000189A7FA20
	// [XID] // 0x0000000189A7F9E0-0x0000000189A7FA20
	public override void Execute() {} // 0x0000000184B310B0-0x0000000184B31150
	// [IDTag] // 0x0000000189A8A630-0x0000000189A8A670
	// [XID] // 0x0000000189A8A630-0x0000000189A8A670
	public void Flush(bool fromJobThread) {} // 0x0000000184B31250-0x0000000184B31350
	// [IDTag] // 0x0000000189A94AA0-0x0000000189A94AE0
	// [XID] // 0x0000000189A94AA0-0x0000000189A94AE0
	public override void Flush() {} // 0x0000000184B31150-0x0000000184B311F0
	// [XID] // 0x0000000189A9F230-0x0000000189A9F250
	public override void Destroy() {} // 0x0000000184B30F40-0x0000000184B30FE0
}

