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

public sealed class SignificanceTask : ThreadTask<SignificanceData>, IFrameSingletonTask // TypeDefIndex: 26644
{
	// Fields
	private ReentryChecker _reentryChecker; // 0x40
	private const string _taskName = "Significance"; // Metadata: 0x00B0C7B1
	private float _deltaTime; // 0x48
	private float _totalTime; // 0x4C
	private int _lastCollectFrame; // 0x50
	public IEntityTickLODManager _balanceTickGroupComputeThread; // 0x58
	public bool scheduledBuildTickListSuccess; // 0x60

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189996970-0x0000000189996990 */ get => default; } // 0x00000001840EE7D0-0x00000001840EE880 
	public int lastCollectFrame { /* [XID] */ /* 0x000000018999E3F0-0x000000018999E410 */ get => default; /* [XID] */ /* 0x00000001899A5E10-0x00000001899A5E30 */ set {} } // 0x00000001840EE680-0x00000001840EE720 0x00000001840EDB70-0x00000001840EDC20

	// Constructors
	public SignificanceTask() {} // 0x00000001840EE720-0x00000001840EE7D0

	// Methods
	// [XID] // 0x00000001899AD430-0x00000001899AD450
	public static bool ShouldBeExecuted(bool fromJobThread, int methodThreadLevel) => default; // 0x00000001840EE350-0x00000001840EE450
	// [XID] // 0x00000001899B4CF0-0x00000001899B4D10
	public void CollectWithFrameOffset(int frameOffset, bool fromJobThread) {} // 0x00000001840EE180-0x00000001840EE350
	// [XID] // 0x00000001899BC430-0x00000001899BC450
	public override void Collect() {} // 0x00000001840EDDC0-0x00000001840EDE70
	// [IDTag] // 0x00000001899C3DB0-0x00000001899C3DF0
	// [XID] // 0x00000001899C3DB0-0x00000001899C3DF0
	public void Execute(bool fromJobThread) {} // 0x00000001840EDC20-0x00000001840EDD60
	// [IDTag] // 0x00000001899CE340-0x00000001899CE380
	// [XID] // 0x00000001899CE340-0x00000001899CE380
	public override void Execute() {} // 0x00000001840EE040-0x00000001840EE0E0
	// [IDTag] // 0x00000001899D8840-0x00000001899D8880
	// [XID] // 0x00000001899D8840-0x00000001899D8880
	public void Flush(bool fromJobThread) {} // 0x00000001840EE4B0-0x00000001840EE620
	// [IDTag] // 0x00000001899E30D0-0x00000001899E3110
	// [XID] // 0x00000001899E30D0-0x00000001899E3110
	public override void Flush() {} // 0x00000001840EE0E0-0x00000001840EE180
	// [XID] // 0x00000001899ED6B0-0x00000001899ED6D0
	public override void Destroy() {} // 0x00000001840EDE70-0x00000001840EDF70
}

