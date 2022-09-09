﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct EventParams // TypeDefIndex: 11304
{
	// Fields
	private static readonly EventParams _empty; // 0x00

	// Properties
	public static EventParams empty { /* [XID] */ /* 0x00000001897AFBF0-0x00000001897AFC10 */ get => default; } // 0x0000000184A33000-0x0000000184A331F0 
	public uint eventId { /* [XID] */ /* 0x00000001897B7990-0x00000001897B79D0 */ get; set; } // 0x0000000184A32CA0-0x0000000184A32D60 0x0000000184A33710-0x0000000184A337D0
	public uint inPlayingId { /* [XID] */ /* 0x00000001897C9CC0-0x00000001897C9D00 */ get; set; } // 0x0000000184A331F0-0x0000000184A332B0 0x0000000184A33BB0-0x0000000184A33C10
	public uint externalSoundCookie { /* [XID] */ /* 0x00000001897DBBF0-0x00000001897DBC30 */ get; /* [XID] */ /* 0x00000001897E65D0-0x00000001897E6610 */ set; } // 0x0000000184A33890-0x0000000184A338F0 0x0000000184A33B50-0x0000000184A33BB0
	public string externalSourceName { /* [XID] */ /* 0x00000001897F11E0-0x00000001897F1220 */ get; /* [XID] */ /* 0x00000001897FBD00-0x00000001897FBD40 */ set; } // 0x0000000184A32EE0-0x0000000184A32FA0 0x0000000184A33430-0x0000000184A334F0
	public object cookie { /* [XID] */ /* 0x0000000189805CB0-0x0000000189805CF0 */ get; /* [XID] */ /* 0x00000001898106F0-0x0000000189810730 */ set; } // 0x0000000184A335B0-0x0000000184A33680 0x0000000184A339D0-0x0000000184A33A90
	public SyncId syncId { /* [XID] */ /* 0x000000018979E2B0-0x000000018979E2F0 */ get; set; } // 0x0000000184A33680-0x0000000184A33710 0x0000000184A338F0-0x0000000184A339D0
	public EventStartCallback startCallback { /* [XID] */ /* 0x000000018982CC70-0x000000018982CCB0 */ get; /* [XID] */ /* 0x00000001898372F0-0x0000000189837330 */ set; } // 0x0000000184A32D60-0x0000000184A32E20 0x0000000184A337D0-0x0000000184A33890
	public EventCallback callback { /* [XID] */ /* 0x00000001898414C0-0x0000000189841500 */ get; /* [XID] */ /* 0x000000018984BD90-0x000000018984BDD0 */ set; } // 0x0000000184A33A90-0x0000000184A33B50 0x0000000184A33370-0x0000000184A33430
	public AkCallbackType callbackMask { /* [XID] */ /* 0x0000000189855D50-0x0000000189855D90 */ get; /* [XID] */ /* 0x0000000189860310-0x0000000189860350 */ set; } // 0x0000000184A32FA0-0x0000000184A33000 0x0000000184A334F0-0x0000000184A335B0
	public bool callbackFromCommand { /* [XID] */ /* 0x000000018986AAB0-0x000000018986AAF0 */ get; /* [XID] */ /* 0x0000000189874B10-0x0000000189874B50 */ set; } // 0x0000000184A332B0-0x0000000184A33370 0x0000000184A32E20-0x0000000184A32EE0

	// Constructors
	static EventParams() {
		_empty = default;
	} // 0x0000000184A33C10-0x0000000184A34010
	public EventParams(uint eventId, SyncId syncId) : this() {

	} // 0x0000000184A34010-0x0000000184A34240
}
