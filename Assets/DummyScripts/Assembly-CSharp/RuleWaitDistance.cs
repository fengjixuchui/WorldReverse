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

internal sealed class RuleWaitDistance : EventCullingRule // TypeDefIndex: 11295
{
	// Fields
	public int checkFrames; // 0x1C
	private Dictionary<ulong, int> leftFrame; // 0x20

	// Properties
	public float distanceSqr { /* [XID] */ /* 0x0000000189BDD1D0-0x0000000189BDD210 */ get; /* [XID] */ /* 0x00000001895ECCE0-0x00000001895ECD20 */ private set; } // 0x000000018451A0A0-0x000000018451A110 0x0000000184519AD0-0x0000000184519B40
	public float distance { /* [XID] */ /* 0x00000001895F7650-0x00000001895F7670 */ set {} } // 0x0000000184519FB0-0x000000018451A0A0

	// Constructors
	public RuleWaitDistance() {} // 0x000000018451A110-0x000000018451A1E0

	// Methods
	// [XID] // 0x000000018988CA10-0x000000018988CA30
	public override void Recycle() {} // 0x0000000184519B40-0x0000000184519C50
	// [XID] // 0x0000000189606350-0x0000000189606370
	public override EventCullingResult ProcessEvent(WorkerThreadContext context, uint eventId, SyncId syncId) => default; // 0x0000000184519D00-0x0000000184519FB0
}

