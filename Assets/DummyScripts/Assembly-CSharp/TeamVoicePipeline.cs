/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TeamVoicePipeline : EntityVoicePipeline, IVoiceIdPossessor // TypeDefIndex: 11535
{
	// Fields
	private readonly MultiVoiceIdPossessor<TeamVoicePipeline> _actualPossessor; // 0x40

	// Properties
	ulong peerId { /* [XID] */ /* 0x00000001895FE990-0x00000001895FE9B0 */ get => default; } // 0x000000018236E420-0x000000018236E4F0 
	int category { /* [XID] */ /* 0x0000000189606330-0x0000000189606350 */ get => default; } // 0x000000018236E0E0-0x000000018236E180 
	bool playing { /* [XID] */ /* 0x000000018960DBD0-0x000000018960DBF0 */ get => default; } // 0x000000018236E4F0-0x000000018236E5A0 
	IVoiceIntention currentIntention { /* [XID] */ /* 0x0000000189615390-0x00000001896153B0 */ get => default; } // 0x000000018236E180-0x000000018236E250 
	IVoiceIntention nextIntention { /* [XID] */ /* 0x000000018961CAE0-0x000000018961CB00 */ get => default; } // 0x000000018236E250-0x000000018236E320 
	uint nextVoiceId { /* [XID] */ /* 0x0000000189787290-0x00000001897872B0 */ get => default; } // 0x000000018236E320-0x000000018236E420 

	// Constructors
	public TeamVoicePipeline() {} // Dummy constructor
	public TeamVoicePipeline(VoiceIdRegistration idReg, VCBaseAudio component) {} // 0x000000018236E5A0-0x000000018236E650

	// Methods
	// [XID] // 0x000000018962B770-0x000000018962B790
	void MoleMole.Audio.IVoiceIdPossessor.GrantId(uint voiceId) {} // 0x000000018236DF60-0x000000018236E030
	// [XID] // 0x0000000189632FB0-0x0000000189632FD0
	void MoleMole.Audio.IVoiceIdPossessor.AnnulId(uint voiceId) {} // 0x000000018236DDC0-0x000000018236DE90
	// [XID] // 0x000000018963AAF0-0x000000018963AB10
	void MoleMole.Audio.IVoiceIdPossessor.PlayNext() {} // 0x000000018236E030-0x000000018236E0E0
	// [XID] // 0x00000001896421B0-0x00000001896421D0
	void MoleMole.Audio.IVoiceIdPossessor.DropAll(uint voiceId) {} // 0x000000018236DE90-0x000000018236DF60
	// [XID] // 0x00000001896499C0-0x00000001896499E0
	public override void OnDisable() {} // 0x000000018236D8D0-0x000000018236D9E0
	// [XID] // 0x00000001896510A0-0x00000001896510C0
	protected override void TryPlayNext() {} // 0x000000018236DC60-0x000000018236DD10
	// [XID] // 0x0000000189658810-0x0000000189658830
	protected override void CancelPendingVoiceIdentityRequest() {} // 0x000000018236DD10-0x000000018236DDC0
	// [XID] // 0x000000018965FE20-0x000000018965FE40
	protected override void RedeemPlayFailure() {} // 0x000000018236DBB0-0x000000018236DC60
	// [XID] // 0x0000000189667940-0x0000000189667960
	protected override void EventStopCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x000000018236DA40-0x000000018236DBB0
}

