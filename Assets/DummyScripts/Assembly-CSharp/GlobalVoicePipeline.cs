/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GlobalVoicePipeline : VoicePipeline, IVoiceIdPossessor // TypeDefIndex: 11531
{
	// Fields
	private readonly MultiVoiceIdPossessor<GlobalVoicePipeline> _actualPossessor; // 0x30
	private SyncId _syncId; // 0x38

	// Properties
	ulong peerId { /* [XID] */ /* 0x0000000189A03530-0x0000000189A03550 */ get => default; } // 0x000000018497FFB0-0x0000000184980080 
	int category { /* [XID] */ /* 0x0000000189A0AB90-0x0000000189A0ABB0 */ get => default; } // 0x000000018497FC70-0x000000018497FD10 
	bool playing { /* [XID] */ /* 0x00000001896AF750-0x00000001896AF770 */ get => default; } // 0x0000000184980080-0x0000000184980130 
	IVoiceIntention currentIntention { /* [XID] */ /* 0x0000000189A197F0-0x0000000189A19810 */ get => default; } // 0x000000018497FD10-0x000000018497FDE0 
	IVoiceIntention nextIntention { /* [XID] */ /* 0x00000001896BE0C0-0x00000001896BE0E0 */ get => default; } // 0x000000018497FDE0-0x000000018497FEB0 
	uint nextVoiceId { /* [XID] */ /* 0x00000001896C59B0-0x00000001896C59D0 */ get => default; } // 0x000000018497FEB0-0x000000018497FFB0 

	// Constructors
	public GlobalVoicePipeline() {} // Dummy constructor
	public GlobalVoicePipeline(VoiceIdRegistration idReg, SyncId syncId) {} // 0x0000000184980130-0x00000001849801E0

	// Methods
	// [XID] // 0x0000000189A2F930-0x0000000189A2F950
	void MoleMole.Audio.IVoiceIdPossessor.GrantId(uint voiceId) {} // 0x000000018497FAF0-0x000000018497FBC0
	// [XID] // 0x0000000189A37300-0x0000000189A37320
	void MoleMole.Audio.IVoiceIdPossessor.AnnulId(uint voiceId) {} // 0x000000018497F950-0x000000018497FA20
	// [XID] // 0x00000001896EA8C0-0x00000001896EA8E0
	void MoleMole.Audio.IVoiceIdPossessor.PlayNext() {} // 0x000000018497FBC0-0x000000018497FC70
	// [XID] // 0x0000000189A460C0-0x0000000189A460E0
	void MoleMole.Audio.IVoiceIdPossessor.DropAll(uint voiceId) {} // 0x000000018497FA20-0x000000018497FAF0
	// [XID] // 0x0000000189A4D810-0x0000000189A4D830
	protected override SyncId GetSyncId() => default; // 0x000000018497F4E0-0x000000018497F5D0
	// [XID] // 0x0000000189700D90-0x0000000189700DB0
	protected override void TryPlayNext() {} // 0x000000018497F7F0-0x000000018497F8A0
	// [XID] // 0x0000000189A5C980-0x0000000189A5C9A0
	protected override void CancelPendingVoiceIdentityRequest() {} // 0x000000018497F8A0-0x000000018497F950
	// [XID] // 0x0000000189A64270-0x0000000189A64290
	protected override void RedeemPlayFailure() {} // 0x000000018497F740-0x000000018497F7F0
	// [XID] // 0x00000001897170C0-0x00000001897170E0
	protected override void EventStopCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x000000018497F5D0-0x000000018497F740
}

