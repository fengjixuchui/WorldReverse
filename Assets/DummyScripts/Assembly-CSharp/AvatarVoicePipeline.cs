/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarVoicePipeline : EntityVoicePipeline, IVoiceIdPossessor // TypeDefIndex: 11528
{
	// Fields
	private readonly VoiceIdRegistration _idReg; // 0x40
	private readonly ulong _peerId; // 0x48
	private readonly uint _voiceId; // 0x50
	private bool _possessesVoiceId; // 0x54

	// Properties
	ulong peerId { /* [XID] */ /* 0x0000000189947BF0-0x0000000189947C10 */ get => default; } // 0x0000000181AA7150-0x0000000181AA71F0 
	int category { /* [XID] */ /* 0x000000018994F2D0-0x000000018994F2F0 */ get => default; } // 0x0000000181AA6E70-0x0000000181AA6F10 
	bool playing { /* [XID] */ /* 0x0000000189956860-0x0000000189956880 */ get => default; } // 0x0000000181AA71F0-0x0000000181AA72A0 
	IVoiceIntention currentIntention { /* [XID] */ /* 0x000000018995E350-0x000000018995E370 */ get => default; } // 0x0000000181AA6F10-0x0000000181AA6FE0 
	IVoiceIntention nextIntention { /* [XID] */ /* 0x0000000189B20110-0x0000000189B20130 */ get => default; } // 0x0000000181AA6FE0-0x0000000181AA70B0 
	uint nextVoiceId { /* [XID] */ /* 0x0000000189B2EA50-0x0000000189B2EA70 */ get => default; } // 0x0000000181AA70B0-0x0000000181AA7150 

	// Constructors
	public AvatarVoicePipeline() {} // Dummy constructor
	public AvatarVoicePipeline(VoiceIdRegistration idReg, VCBaseAudio component, ulong peerId, uint voiceId) {} // 0x0000000181AA72A0-0x0000000181AA7330

	// Methods
	// [XID] // 0x0000000189B36280-0x0000000189B362A0
	void MoleMole.Audio.IVoiceIdPossessor.GrantId(uint voiceId) {} // 0x0000000181AA6CD0-0x0000000181AA6DC0
	// [XID] // 0x000000018997C020-0x000000018997C040
	void MoleMole.Audio.IVoiceIdPossessor.AnnulId(uint voiceId) {} // 0x0000000181AA6B10-0x0000000181AA6C00
	// [XID] // 0x0000000189983C70-0x0000000189983C90
	void MoleMole.Audio.IVoiceIdPossessor.PlayNext() {} // 0x0000000181AA6DC0-0x0000000181AA6E70
	// [XID] // 0x0000000189B4CC70-0x0000000189B4CC90
	void MoleMole.Audio.IVoiceIdPossessor.DropAll(uint voiceId) {} // 0x0000000181AA6C00-0x0000000181AA6CD0
	// [XID] // 0x0000000189B5BF30-0x0000000189B5BF50
	public override void OnDisable() {} // 0x0000000181AA6190-0x0000000181AA62C0
	// [XID] // 0x0000000189B95880-0x0000000189B958A0
	protected override void TryPlayNext() {} // 0x0000000181AA68C0-0x0000000181AA6A10
	// [XID] // 0x0000000189621210-0x0000000189621230
	protected override void CancelPendingVoiceIdentityRequest() {} // 0x0000000181AA6A10-0x0000000181AA6B10
	// [XID] // 0x00000001899A9BC0-0x00000001899A9BE0
	protected override void RedeemPlayFailure() {} // 0x0000000181AA6760-0x0000000181AA68C0
	// [XID] // 0x0000000189646AA0-0x0000000189646AC0
	protected override void EventStopCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x0000000181AA64B0-0x0000000181AA6760
	// [XID] // 0x00000001899B8AC0-0x00000001899B8AE0
	private void RequestVoiceIdWithPendingIntentions() {} // 0x0000000181AA62C0-0x0000000181AA6450
}

