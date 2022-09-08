/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCTeamAudio : VCBaseAudio, IDialogSpeechPoster, IVoiceStreamEmployer // TypeDefIndex: 11970
{
	// Fields
	private AudioTeamReminderVoicePlugin _reminderVoice; // 0x140
	private AudioTeamDialogVoicePlugin _dialogVoice; // 0x148
	private AudioTeamVoiceStreamPlugin _voiceStream; // 0x150

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899524F0-0x0000000189952510 */ get => default; } // 0x00000001843F6600-0x00000001843F66A0 

	// Constructors
	public VCTeamAudio() {} // 0x00000001843F65A0-0x00000001843F6600

	// Methods
	// [XID] // 0x0000000189959990-0x00000001899599B0
	public override void Init() {} // 0x00000001843F6210-0x00000001843F6360
	// [XID] // 0x00000001899612D0-0x00000001899612F0
	public override void OnDisable() {} // 0x00000001843F64E0-0x00000001843F65A0
	// [XID] // 0x0000000189968970-0x0000000189968990
	public override void Stop() {} // 0x00000001843F5F00-0x00000001843F5FC0
	// [XID] // 0x000000018996FF60-0x000000018996FF80
	public AudioDialogVoicePlugin GetDialogVoicePlugin() => default; // 0x00000001843F6100-0x00000001843F61B0
	// [XID] // 0x0000000189977D50-0x0000000189977D70
	public AudioVoiceStreamPlugin GetVoiceStreamPlugin() => default; // 0x00000001843F6430-0x00000001843F64E0
	// [XID] // 0x000000018997EF70-0x000000018997EF90
	public bool PostReminderSpeechEvent(uint reminderId, IDialogVoiceEventResponder responder = null) => default; // 0x00000001843F6020-0x00000001843F6100
}

