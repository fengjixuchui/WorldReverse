/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioDialogVoicePlugin : AudioEntityVoicePlugin // TypeDefIndex: 12009
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A3B690-0x0000000189A3B6B0 */ get; } // 0x0000000183603D70-0x0000000183603E10 
	protected override AudioVoiceTrigger voiceTrigger { /* [XID] */ /* 0x0000000189A43200-0x0000000189A43220 */ get; } // 0x0000000183603BE0-0x0000000183603C80 

	// Constructors
	protected AudioDialogVoicePlugin() {} // Dummy constructor
	protected AudioDialogVoicePlugin(VCBaseAudio component) {} // 0x0000000183603CF0-0x0000000183603D70

	// Methods
	// [XID] // 0x0000000189A4A6B0-0x0000000189A4A6D0
	public virtual bool PostDialogSpeechEvent(uint dialogId, IDialogVoiceEventResponder responder) => default; // 0x0000000183603A80-0x0000000183603BE0
}

