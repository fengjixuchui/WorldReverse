/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal class EventCullingRuleList // TypeDefIndex: 11291
{
	// Properties
	public uint eventId { /* [XID] */ /* 0x0000000189AA30C0-0x0000000189AA3100 */ get; private set; } // 0x000000018182CF50-0x000000018182CFB0 0x000000018182D2C0-0x000000018182D320
	public int count { /* [XID] */ /* 0x0000000189AB50C0-0x0000000189AB5100 */ get; /* [XID] */ /* 0x0000000189ABFB20-0x0000000189ABFB60 */ private set; } // 0x000000018182D700-0x000000018182D760 0x000000018182D260-0x000000018182D2C0
	private EventCullingRule first { /* [XID] */ /* 0x0000000189ACA4C0-0x0000000189ACA500 */ get; /* [XID] */ /* 0x0000000189AD5440-0x0000000189AD5480 */ set; } // 0x000000018182D990-0x000000018182D9F0 0x000000018182CFB0-0x000000018182D010
	private EventCullingRule last { /* [XID] */ /* 0x0000000189ADFEA0-0x0000000189ADFEE0 */ get; /* [XID] */ /* 0x0000000189AEA3F0-0x0000000189AEA430 */ set; } // 0x000000018182D760-0x000000018182D7C0 0x000000018182D010-0x000000018182D070

	// Constructors
	public EventCullingRuleList() {} // Dummy constructor
	public EventCullingRuleList(uint eventId) {} // 0x000000018182D9F0-0x000000018182DB60

	// Methods
	// [XID] // 0x0000000189AF4DC0-0x0000000189AF4DE0
	public void Add(EventCullingRule rule) {} // 0x000000018182D500-0x000000018182D700
	// [XID] // 0x0000000189AFC3A0-0x0000000189AFC3C0
	public void Clear() {} // 0x000000018182D070-0x000000018182D260
	// [XID] // 0x0000000189654210-0x0000000189654230
	public EventCullingResult ProcessEvent(WorkerThreadContext context, SyncId syncId) => default; // 0x000000018182D320-0x000000018182D500
	// [XID] // 0x0000000189BAE8E0-0x0000000189BAE900
	public void OnEventSuccessPost(WorkerThreadContext context, SyncId syncId) {} // 0x000000018182D7C0-0x000000018182D990
}

