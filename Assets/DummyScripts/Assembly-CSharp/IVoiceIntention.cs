/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IVoiceIntention // TypeDefIndex: 11524
{
	// Properties
	IIntentionSubmitter submitter { get; set; }
	VoiceQueueBehaviour queueBehaviour { get; }
	bool clearQueue { get; }

	// Methods
	bool CanInterrupt(IVoiceIntention other);
	AudioPostedEventStatus Play(object cookie, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask);
	void Recycle();
}

