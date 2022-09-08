/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class RuleLimitFrameGlobal : EventCullingRule // TypeDefIndex: 11296
{
	// Fields
	public int limitFrame; // 0x18
	private int lastSuccessPostFrame; // 0x1C

	// Constructors
	public RuleLimitFrameGlobal() {} // 0x0000000184E5EEE0-0x0000000184E5EF50

	// Methods
	// [XID] // 0x000000018960DBF0-0x000000018960DC10
	public override void Recycle() {} // 0x0000000184E5EAB0-0x0000000184E5EB50
	// [XID] // 0x00000001896153B0-0x00000001896153D0
	public override EventCullingResult ProcessEvent(WorkerThreadContext context, uint eventId, SyncId syncId) => default; // 0x0000000184E5EC00-0x0000000184E5ED30
	// [XID] // 0x00000001898B9500-0x00000001898B9520
	public override void OnEventSuccessPost(WorkerThreadContext context, uint eventId, SyncId syncId) {} // 0x0000000184E5EDE0-0x0000000184E5EEE0
}

