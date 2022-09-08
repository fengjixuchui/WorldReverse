/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal class EventCullingGlobalRuleList // TypeDefIndex: 11292
{
	// Properties
	public int count { /* [XID] */ /* 0x0000000189B31A60-0x0000000189B31AA0 */ get; /* [XID] */ /* 0x0000000189B3BF50-0x0000000189B3BF90 */ private set; } // 0x0000000184956280-0x00000001849562E0 0x0000000184955E80-0x0000000184955EE0
	private EventCullingRule first { /* [XID] */ /* 0x0000000189B46B40-0x0000000189B46B80 */ get; /* [XID] */ /* 0x0000000189B513F0-0x0000000189B51430 */ set; } // 0x00000001849564D0-0x0000000184956530 0x0000000184955BD0-0x0000000184955C30
	private EventCullingRule last { /* [XID] */ /* 0x0000000189B5BD20-0x0000000189B5BD60 */ get; /* [XID] */ /* 0x0000000189B66300-0x0000000189B66340 */ set; } // 0x00000001849562E0-0x0000000184956340 0x0000000184955C30-0x0000000184955C90

	// Constructors
	public EventCullingGlobalRuleList() {} // 0x0000000184956530-0x0000000184956650

	// Methods
	// [XID] // 0x0000000189B708D0-0x0000000189B708F0
	public void Add(EventCullingRule rule) {} // 0x0000000184956080-0x0000000184956280
	// [XID] // 0x0000000189B77D60-0x0000000189B77D80
	public void Clear() {} // 0x0000000184955C90-0x0000000184955E80
	// [XID] // 0x0000000189A62A40-0x0000000189A62A60
	public EventCullingResult ProcessEvent(WorkerThreadContext context, uint eventId, SyncId syncId) => default; // 0x0000000184955EE0-0x0000000184956080
	// [XID] // 0x0000000189662FC0-0x0000000189662FE0
	public void OnEventSuccessPost(WorkerThreadContext context, uint eventId, SyncId syncId) {} // 0x0000000184956340-0x00000001849564D0
}

