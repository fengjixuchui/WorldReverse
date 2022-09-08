/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal abstract class EventCullingRule // TypeDefIndex: 11290
{
	// Properties
	public EventCullingRule next { /* [XID] */ /* 0x0000000189A6E9E0-0x0000000189A6EA20 */ get; /* [XID] */ /* 0x0000000189A64290-0x0000000189A642D0 */ set; } // 0x000000018319FB80-0x000000018319FBE0 0x000000018319FA30-0x000000018319FA90

	// Constructors
	protected EventCullingRule() {} // 0x000000018319FCD0-0x000000018319FD30

	// Methods
	// [XID] // 0x0000000189A55090-0x0000000189A550B0
	public virtual EventCullingResult ProcessEvent(WorkerThreadContext context, uint eventId, SyncId syncId) => default; // 0x000000018319FA90-0x000000018319FB80
	// [XID] // 0x0000000189A5C9A0-0x0000000189A5C9C0
	public virtual void OnEventSuccessPost(WorkerThreadContext context, uint eventId, SyncId syncId) {} // 0x000000018319FBE0-0x000000018319FCD0
	public abstract void Recycle();
}

