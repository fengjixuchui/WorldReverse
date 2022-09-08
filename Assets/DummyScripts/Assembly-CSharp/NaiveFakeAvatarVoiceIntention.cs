/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NaiveFakeAvatarVoiceIntention : IFakeAvatarVoiceIntention // TypeDefIndex: 11519
{
	// Properties
	public uint eventId { /* [XID] */ /* 0x000000018984D420-0x000000018984D460 */ get; /* [XID] */ /* 0x00000001898574A0-0x00000001898574E0 */ set; } // 0x00000001828C9280-0x00000001828C92E0 0x00000001828C94F0-0x00000001828C9550
	public uint voiceSwitchId { /* [XID] */ /* 0x00000001898618D0-0x0000000189861910 */ get; /* [XID] */ /* 0x000000018986C090-0x000000018986C0D0 */ set; } // 0x00000001828C91C0-0x00000001828C9220 0x00000001828C95B0-0x00000001828C9610
	public IIntentionSubmitter submitter { get; /* [XID] */ /* 0x000000018987E170-0x000000018987E1B0 */ set; } // 0x00000001828C9220-0x00000001828C9280 0x00000001828C9610-0x00000001828C9670
	public VoiceQueueBehaviour queueBehaviour { get; /* [XID] */ /* 0x000000018988F5C0-0x000000018988F600 */ set; } // 0x00000001828C9550-0x00000001828C95B0 0x00000001828C9490-0x00000001828C94F0
	public bool clearQueue { get; set; } // 0x00000001828C9430-0x00000001828C9490 0x00000001828C9670-0x00000001828C96D0

	// Constructors
	public NaiveFakeAvatarVoiceIntention() {} // 0x00000001828C99B0-0x00000001828C9A10

	// Methods
	// [XID] // 0x0000000189A943B0-0x0000000189A943D0
	public bool CanInterrupt(IVoiceIntention other) => default; // 0x00000001828C92E0-0x00000001828C9390
	// [XID] // 0x00000001898B0090-0x00000001898B00B0
	public AudioPostedEventStatus Play(object cookie, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask) => default; // 0x00000001828C96D0-0x00000001828C99B0
	// [XID] // 0x00000001898B7550-0x00000001898B7570
	public void Recycle() {} // 0x00000001828C9390-0x00000001828C9430
}

