/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCTimelineAudio : VCBaseAudio, IVoiceStreamEmployer, IDialogSpeechPoster, IAnimatorVoicePoster // TypeDefIndex: 11971
{
	// Fields
	private AudioGadgetVoiceStreamPlugin _voiceStream; // 0x140
	private AudioGadgetDialogVoicePlugin _dialogVoice; // 0x148
	private AudioGadgetAnimatorVoicePlugin _animatorVoice; // 0x150
	private bool _partiallyInited; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189986870-0x0000000189986890 */ get => default; } // 0x0000000180CAE8F0-0x0000000180CAE990 

	// Constructors
	public VCTimelineAudio() {} // 0x0000000180CAE890-0x0000000180CAE8F0

	// Methods
	// [XID] // 0x000000018998E470-0x000000018998E490
	public override void Init() {} // 0x0000000180CAE560-0x0000000180CAE650
	// [XID] // 0x0000000189995FC0-0x0000000189995FE0
	public override void OnDisable() {} // 0x0000000180CAE7D0-0x0000000180CAE890
	// [XID] // 0x000000018999DA00-0x000000018999DA20
	public override void Stop() {} // 0x0000000180CAE040-0x0000000180CAE100
	// [XID] // 0x00000001899A5320-0x00000001899A5340
	public override bool PostDialogSpeechEvent(uint dialogId, IDialogVoiceEventResponder responder) => default; // 0x0000000180CAE160-0x0000000180CAE240
	// [XID] // 0x00000001899ACD50-0x00000001899ACD70
	public AudioVoiceStreamPlugin GetVoiceStreamPlugin() => default; // 0x0000000180CAE720-0x0000000180CAE7D0
	// [XID] // 0x00000001899B4590-0x00000001899B45B0
	public AudioDialogVoicePlugin GetDialogVoicePlugin() => default; // 0x0000000180CAE240-0x0000000180CAE2F0
	// [XID] // 0x00000001899BBA10-0x00000001899BBA30
	public AudioAnimatorVoicePlugin GetAnimatorVoicePlugin() => default; // 0x0000000180CAE4B0-0x0000000180CAE560
	// [XID] // 0x00000001899C3650-0x00000001899C3670
	private void PartiallyInit() {} // 0x0000000180CAE350-0x0000000180CAE4B0
}

