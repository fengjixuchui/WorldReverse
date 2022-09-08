/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCPaimonAudio : VCGadgetAudio, IVoiceStreamEmployer, IDialogSpeechPoster // TypeDefIndex: 11926
{
	// Fields
	private AudioGadgetVoiceStreamPlugin _voiceStream; // 0x148
	private AudioGadgetDialogVoicePlugin _dialogVoice; // 0x150
	private ConfigAudioGadget _config; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189841540-0x0000000189841560 */ get => default; } // 0x0000000183DEB730-0x0000000183DEB7D0 

	// Constructors
	public VCPaimonAudio() {} // 0x0000000183DEB6D0-0x0000000183DEB730

	// Methods
	// [XID] // 0x0000000189848A20-0x0000000189848A40
	public override void Init() {} // 0x0000000183DEB1A0-0x0000000183DEB2F0
	// [XID] // 0x000000018960F350-0x000000018960F370
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183DEB610-0x0000000183DEB6D0
	// [XID] // 0x00000001896168F0-0x0000000189616910
	public override void OnDisable() {} // 0x0000000183DEB470-0x0000000183DEB530
	// [XID] // 0x000000018961E1E0-0x000000018961E200
	public override void Stop() {} // 0x0000000183DEAE30-0x0000000183DEAEF0
	// [XID] // 0x00000001897D9310-0x00000001897D9330
	public void SetPaimonSpeedRtpc(float speed) {} // 0x0000000183DEB530-0x0000000183DEB610
	// [XID] // 0x000000018962CF30-0x000000018962CF50
	public AudioVoiceStreamPlugin GetVoiceStreamPlugin() => default; // 0x0000000183DEB3C0-0x0000000183DEB470
	// [XID] // 0x0000000189634B20-0x0000000189634B40
	public AudioDialogVoicePlugin GetDialogVoicePlugin() => default; // 0x0000000183DEB090-0x0000000183DEB140
	// [XID] // 0x00000001898502E0-0x0000000189850300
	private void FindConfig() {} // 0x0000000183DEAFC0-0x0000000183DEB090
}

