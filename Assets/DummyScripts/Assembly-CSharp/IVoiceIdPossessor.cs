/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IVoiceIdPossessor // TypeDefIndex: 11526
{
	// Properties
	ulong peerId { get; }
	int category { get; }
	bool playing { get; }
	IVoiceIntention currentIntention { get; }
	IVoiceIntention nextIntention { get; }
	uint nextVoiceId { get; }

	// Methods
	void GrantId(uint voiceId);
	void AnnulId(uint voiceId);
	void StopCurrent();
	void PlayNext();
	void DropAll(uint voiceId);
}

