/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NaiveVocieIntention : IVoiceIntention // TypeDefIndex: 11525
{
	// Properties
	public uint eventId { /* [XID] */ /* 0x00000001898E98B0-0x00000001898E98F0 */ get; /* [XID] */ /* 0x00000001898F3E00-0x00000001898F3E40 */ set; } // 0x0000000182156330-0x0000000182156390 0x00000001821565A0-0x0000000182156600
	public IIntentionSubmitter submitter { get; /* [XID] */ /* 0x0000000189905E00-0x0000000189905E40 */ set; } // 0x00000001821562D0-0x0000000182156330 0x0000000182156660-0x00000001821566C0
	public VoiceQueueBehaviour queueBehaviour { get; /* [XID] */ /* 0x0000000189917FE0-0x0000000189918020 */ set; } // 0x0000000182156600-0x0000000182156660 0x0000000182156540-0x00000001821565A0
	public bool clearQueue { get; set; } // 0x00000001821564E0-0x0000000182156540 0x00000001821566C0-0x0000000182156720

	// Constructors
	public NaiveVocieIntention() {} // 0x0000000182156970-0x00000001821569D0

	// Methods
	// [XID] // 0x00000001899316B0-0x00000001899316D0
	public bool CanInterrupt(IVoiceIntention other) => default; // 0x0000000182156390-0x0000000182156440
	// [XID] // 0x0000000189938D80-0x0000000189938DA0
	public AudioPostedEventStatus Play(object cookie, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask) => default; // 0x0000000182156720-0x0000000182156970
	// [XID] // 0x0000000189940550-0x0000000189940570
	public void Recycle() {} // 0x0000000182156440-0x00000001821564E0
}

