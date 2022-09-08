/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAvatarAudio : VCCharacterAudio, IVoiceStreamEmployer, IDialogSpeechPoster, IAnimatorVoicePoster // TypeDefIndex: 11789
{
	// Fields
	private ConfigAvatarSpeech _speechConfig; // 0x140
	private AudioAvatarVoiceStreamPlugin _voiceStream; // 0x148
	private AudioAvatarDialogVoicePlugin _dialogVoice; // 0x150
	private AudioAvatarAnimatorVoicePlugin _animatorVoice; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189722E50-0x0000000189722E70 */ get => default; } // 0x0000000183349F60-0x000000018334A000 
	public uint voiceSwitch { /* [XID] */ /* 0x000000018972A460-0x000000018972A4A0 */ get; /* [XID] */ /* 0x0000000189734BB0-0x0000000189734BF0 */ set; } // 0x00000001833483E0-0x0000000183348440 0x0000000183348370-0x00000001833483E0
	public uint bodyTypeSwitch { /* [XID] */ /* 0x000000018973F9A0-0x000000018973F9E0 */ get; /* [XID] */ /* 0x0000000189749F70-0x0000000189749FB0 */ set; } // 0x0000000183348440-0x00000001833484A0 0x0000000183349AB0-0x0000000183349B20
	protected override bool isOccEnabled { /* [XID] */ /* 0x0000000189B3BFD0-0x0000000189B3BFF0 */ get => default; } // 0x00000001833497C0-0x00000001833498A0 

	// Constructors
	public VCAvatarAudio() {} // 0x0000000183349EF0-0x0000000183349F60

	// Methods
	// [XID] // 0x000000018975B870-0x000000018975B890
	public override void Init() {} // 0x0000000183348EA0-0x0000000183349200
	// [XID] // 0x0000000189763300-0x0000000189763320
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183349E00-0x0000000183349EF0
	// [XID] // 0x000000018976AA90-0x000000018976AAB0
	public override void OnEnable() {} // 0x0000000183349BF0-0x0000000183349CA0
	// [XID] // 0x0000000189772070-0x0000000189772090
	public override void OnDisable() {} // 0x0000000183349B20-0x0000000183349BF0
	// [XID] // 0x0000000189920FF0-0x0000000189921010
	public override void PostEvent(uint eventId) {} // 0x00000001833488D0-0x0000000183348A30
	// [XID] // 0x00000001897811E0-0x0000000189781200
	public void SubmitVoiceIntention(IVoiceIntention intention) {} // 0x0000000183348090-0x0000000183348160
	// [XID] // 0x00000001897886A0-0x00000001897886C0
	public void PostEnterSpeedupFieldEvent() {} // 0x0000000183348640-0x0000000183348700
	// [XID] // 0x0000000189631920-0x0000000189631940
	public void ProcessWeatherChange(AudioWeatherProperties weatherProperties, uint weatherSwitchId) {} // 0x0000000183347890-0x0000000183347980
	// [XID] // 0x00000001897975B0-0x00000001897975D0
	public AudioVoiceStreamPlugin GetVoiceStreamPlugin() => default; // 0x0000000183349A00-0x0000000183349AB0
	// [XID] // 0x000000018979F4D0-0x000000018979F4F0
	public AudioDialogVoicePlugin GetDialogVoicePlugin() => default; // 0x00000001833482C0-0x0000000183348370
	// [XID] // 0x00000001897A6AA0-0x00000001897A6AC0
	public AudioAnimatorVoicePlugin GetAnimatorVoicePlugin() => default; // 0x0000000183348CD0-0x0000000183348D80
	// [XID] // 0x00000001897AE200-0x00000001897AE220
	public void SubmitFakeAvatarVoiceIntention(uint eventId) {} // 0x0000000183347590-0x00000001833476F0
	// [XID] // 0x00000001899DF740-0x00000001899DF760
	public void SubmitGlobalVoiceIntention(IVoiceIntention intention) {} // 0x0000000183347D20-0x0000000183347E60
	// [XID] // 0x00000001897BE080-0x00000001897BE0A0
	public bool CheckAnimatorAllowsWeaponPutAwayEvent() => default; // 0x0000000183349610-0x0000000183349750
	// [XID] // 0x00000001897C56F0-0x00000001897C5710
	public void StopAll() {} // 0x0000000183348570-0x0000000183348640
	// [XID] // 0x00000001897CCD20-0x00000001897CCD40
	protected override ConfigEntityAudio GetConfigEntityAudio() => default; // 0x0000000183348BD0-0x0000000183348CD0
	// [XID] // 0x00000001897D4420-0x00000001897D4440
	protected override ConfigAnimationAudio GetConfigAnimationAudio(ConfigCharacter configCharacter) => default; // 0x0000000183348D80-0x0000000183348EA0
	// [XID] // 0x00000001899FD670-0x00000001899FD690
	protected override bool HandleEvtAudio(EvtAudio evt) => default; // 0x00000001833487F0-0x00000001833488D0
	// [XID] // 0x00000001897E35E0-0x00000001897E3600
	private void SetPersonality() {} // 0x0000000183349440-0x0000000183349610
	// [XID] // 0x0000000189BD6E90-0x0000000189BD6EB0
	private void LocateSpeechConfig() {} // 0x0000000183347FC0-0x0000000183348090
	// [XID] // 0x00000001897F2B30-0x00000001897F2B50
	private void SetAvatarBodyTypeSwitch() {} // 0x0000000183349CA0-0x0000000183349E00
	// [XID] // 0x00000001897FA370-0x00000001897FA390
	private void SetWeatherSwitch() {} // 0x0000000183347E60-0x0000000183347FC0
	// [XID] // 0x0000000189763440-0x0000000189763460
	private void SetAccessTypeSwitch() {} // 0x0000000183348A30-0x0000000183348BD0
	// [XID] // 0x0000000189808D70-0x0000000189808D90
	private void SetMoveStateAudioConfig() {} // 0x0000000183348160-0x0000000183348260
	// [XID] // 0x0000000189810660-0x0000000189810680
	private void HandlePickItem(ItemConfig itemConfig) {} // 0x0000000183349200-0x00000001833493D0
	// [XID] // 0x0000000189788820-0x0000000189788840
	private ConfigAvatar GetAvatarConfig() => default; // 0x0000000183349910-0x0000000183349A00
	// [XID] // 0x0000000189A13D10-0x0000000189A13D30
	private AvatarExcelConfig GetAvatarExcelConfig() => default; // 0x0000000183348700-0x00000001833487F0
	// [XID] // 0x0000000189826C50-0x0000000189826C70
	private bool CanUseEquipment(ItemConfig equip) => default; // 0x0000000183347B60-0x0000000183347D20
	// [XID] // 0x00000001899AB6D0-0x00000001899AB6F0
	private void StopEquipAudio() {} // 0x00000001833479F0-0x0000000183347B60
	// [XID] // 0x0000000189835A10-0x0000000189835A30
	private void ReportToTeamAudio(bool enabling) {} // 0x0000000183347770-0x0000000183347890
}

