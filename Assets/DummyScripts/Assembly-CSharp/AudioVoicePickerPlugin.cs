/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioVoicePickerPlugin : AudioComponentPlugin // TypeDefIndex: 12030
{
	// Fields
	private AudioVoiceStreamPlugin _voiceStream; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189720040-0x0000000189720060 */ get; } // 0x000000018214B910-0x000000018214B9B0 
	protected abstract AudioVoiceTrigger voiceTrigger { get; }
	protected AudioVoiceStreamPlugin voiceStream { /* [XID] */ /* 0x00000001896C71B0-0x00000001896C71D0 */ get; } // 0x000000018214B370-0x000000018214B430 

	// Constructors
	protected AudioVoicePickerPlugin() {} // Dummy constructor
	protected AudioVoicePickerPlugin(VCBaseAudio component) {} // 0x000000018214B890-0x000000018214B910

	// Methods
	// [XID] // 0x000000018972ECD0-0x000000018972ECF0
	protected virtual AudioVoiceStreamPlugin GetVoiceStreamPluginFromComponent() => default; // 0x000000018214B560-0x000000018214B630
	// [XID] // 0x0000000189600210-0x0000000189600230
	protected virtual bool PickVoice(uint id, out ExternalVoiceItem voiceItem, out ExternalVoiceSound voiceSound) {
		voiceItem = default;
		voiceSound = default;
		return default;
	} // 0x000000018214B030-0x000000018214B260
	// [XID] // 0x00000001896B0B20-0x00000001896B0B40
	protected virtual VoicePickerParams GetVoicePickerParams(AudioManager audioManager, ExternalVoiceItem voiceItem) => default; // 0x000000018214B430-0x000000018214B560
	// [XID] // 0x0000000189745570-0x0000000189745590
	protected virtual bool PickVoiceItem(uint id, out ExternalVoiceItem voiceItem) {
		voiceItem = default;
		return default;
	} // 0x000000018214B260-0x000000018214B370
	// [XID] // 0x000000018974D070-0x000000018974D090
	protected virtual int SubmitIntention(ExternalVoiceItem voiceItem, ExternalVoiceSound voiceSound, AudioVoiceStreamPlugin voiceStream, IExternalSourceVoiceStartResponder startResponder, IExternalSourceVoiceStopResponder stopResponder) => default; // 0x000000018214B6A0-0x000000018214B890
	// [XID] // 0x00000001897545B0-0x00000001897545D0
	protected virtual ExternalVoiceIdentity AssembleVoiceIdentity(uint triggerParam) => default; // 0x000000018214AF40-0x000000018214B030
}

