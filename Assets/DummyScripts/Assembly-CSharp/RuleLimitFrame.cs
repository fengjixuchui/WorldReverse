/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class RuleLimitFrame : EventCullingRule // TypeDefIndex: 11297
{
	// Fields
	public int limitFrame; // 0x18
	private Dictionary<ulong, int> lastSuccessPostFrame; // 0x20

	// Constructors
	public RuleLimitFrame() {} // 0x00000001810900F0-0x0000000181090190

	// Methods
	// [XID] // 0x00000001898C09A0-0x00000001898C09C0
	public override void Recycle() {} // 0x000000018108FC10-0x000000018108FCE0
	// [XID] // 0x0000000189921210-0x0000000189921230
	public override EventCullingResult ProcessEvent(WorkerThreadContext context, uint eventId, SyncId syncId) => default; // 0x000000018108FD90-0x000000018108FF10
	// [XID] // 0x0000000189928BB0-0x0000000189928BD0
	public override void OnEventSuccessPost(WorkerThreadContext context, uint eventId, SyncId syncId) {} // 0x000000018108FFC0-0x00000001810900F0
}

