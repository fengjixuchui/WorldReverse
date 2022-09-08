/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCManekinAudio : VCCharacterAudio, IAnimatorVoicePoster // TypeDefIndex: 11895
{
	// Fields
	private AudioManekinAnimatorVoicePlugin _animatorVoice; // 0x140

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898078A0-0x00000001898078C0 */ get => default; } // 0x00000001841F3E40-0x00000001841F3EE0 
	public uint voiceSwitch { /* [XID] */ /* 0x00000001896B6C00-0x00000001896B6C40 */ get; /* [XID] */ /* 0x00000001896C0F60-0x00000001896C0FA0 */ set; } // 0x00000001841F3390-0x00000001841F33F0 0x00000001841F3320-0x00000001841F3390
	public uint bodyTypeSwitch { /* [XID] */ /* 0x00000001896CB2F0-0x00000001896CB330 */ get; /* [XID] */ /* 0x00000001896D5B10-0x00000001896D5B50 */ set; } // 0x00000001841F33F0-0x00000001841F3450 0x00000001841F38A0-0x00000001841F3910
	protected override bool isOccEnabled { /* [XID] */ /* 0x000000018980EF40-0x000000018980EF60 */ get => default; } // 0x00000001841F3790-0x00000001841F3830 

	// Constructors
	public VCManekinAudio() {} // 0x00000001841F3DE0-0x00000001841F3E40

	// Methods
	// [XID] // 0x00000001898165E0-0x0000000189816600
	public override void Init() {} // 0x00000001841F3620-0x00000001841F3720
	// [XID] // 0x0000000189896BE0-0x0000000189896C00
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001841F3D10-0x00000001841F3DE0
	// [XID] // 0x00000001898A5A90-0x00000001898A5AB0
	public AudioAnimatorVoicePlugin GetAnimatorVoicePlugin() => default; // 0x00000001841F3450-0x00000001841F3500
	// [XID] // 0x00000001896FDCF0-0x00000001896FDD10
	protected override ConfigAnimationAudio GetConfigAnimationAudio(ConfigCharacter configCharacter) => default; // 0x00000001841F3500-0x00000001841F3620
	// [XID] // 0x000000018983A0B0-0x000000018983A0D0
	private void SetUseGuiListener() {} // 0x00000001841F3BD0-0x00000001841F3D10
	// [XID] // 0x000000018970C800-0x000000018970C820
	private void SetAvatarVoiceSwitch() {} // 0x00000001841F3910-0x00000001841F3A70
	// [XID] // 0x0000000189848A40-0x0000000189848A60
	private void SetAvatarBodyTypeSwitch() {} // 0x00000001841F3A70-0x00000001841F3BD0
}

