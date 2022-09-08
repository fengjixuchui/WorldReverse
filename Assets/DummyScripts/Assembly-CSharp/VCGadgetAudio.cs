/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCGadgetAudio : VCBaseAudio, IAnimatorVoicePoster // TypeDefIndex: 11867
{
	// Fields
	private AudioGadgetAnimatorVoicePlugin _animatorVoice; // 0x140

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A477A0-0x0000000189A477C0 */ get => default; } // 0x0000000182F8F3E0-0x0000000182F8F480 

	// Constructors
	public VCGadgetAudio() {} // 0x0000000182F8F380-0x0000000182F8F3E0

	// Methods
	// [XID] // 0x0000000189A4EF90-0x0000000189A4EFB0
	public override void Init() {} // 0x0000000182F8E740-0x0000000182F8E860
	// [XID] // 0x0000000189A56600-0x0000000189A56620
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182F8F2A0-0x0000000182F8F380
	// [XID] // 0x0000000189B12B90-0x0000000189B12BB0
	public override void PostFadeOutEvent() {} // 0x0000000182F8EB40-0x0000000182F8EC90
	// [XID] // 0x0000000189AB2510-0x0000000189AB2530
	public AudioAnimatorVoicePlugin GetAnimatorVoicePlugin() => default; // 0x0000000182F8E690-0x0000000182F8E740
	// [XID] // 0x0000000189B19FA0-0x0000000189B19FC0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182F8E240-0x0000000182F8E320
	// [XID] // 0x0000000189A74780-0x0000000189A747A0
	protected override ConfigEntityAudio GetConfigEntityAudio() => default; // 0x0000000182F8E590-0x0000000182F8E690
	// [XID] // 0x0000000189B21450-0x0000000189B21470
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000182F8F1A0-0x0000000182F8F2A0
	// [XID] // 0x0000000189AC8D80-0x0000000189AC8DA0
	protected override bool HandleEvtAudio(EvtAudio evt) => default; // 0x0000000182F8E320-0x0000000182F8E470
	// [XID] // 0x0000000189A8B610-0x0000000189A8B630
	protected virtual void SetPersonalityIfOwnedByAvatar() {} // 0x0000000182F8D930-0x0000000182F8DAC0
	// [XID] // 0x0000000189AC1530-0x0000000189AC1550
	protected virtual bool HandleEvtOpenChest(EvtGadgetState evt) => default; // 0x0000000182F8EEB0-0x0000000182F8F010
	// [XID] // 0x0000000189A9A6C0-0x0000000189A9A6E0
	protected virtual void SetAnimationAudioConfig() {} // 0x0000000182F8E150-0x0000000182F8E240
	// [XID] // 0x0000000189A942D0-0x0000000189A942F0
	protected virtual bool GetIfTriggersAnimationRecurrentSpeechFromConfig() => default; // 0x0000000182F8EDF0-0x0000000182F8EEB0
	// [XID] // 0x0000000189A6EB00-0x0000000189A6EB20
	protected virtual ConfigGadgetAudio GetConfig() => default; // 0x0000000182F8DBA0-0x0000000182F8DC80
	protected virtual T GetEntityConfig<T>()
		where T : ConfigEntity => default;
	// [XID] // 0x0000000189AB0A30-0x0000000189AB0A50
	protected virtual void AddAbilityPluginIfNecessary() {} // 0x0000000182F8DEC0-0x0000000182F8DFD0
	// [XID] // 0x0000000189A67450-0x0000000189A67470
	protected virtual void AddAnimatorPluginsIfNecessary() {} // 0x0000000182F8F010-0x0000000182F8F1A0
	// [XID] // 0x0000000189ABFAA0-0x0000000189ABFAC0
	protected virtual void AddCombatPluginIfNecessary() {} // 0x0000000182F8DFD0-0x0000000182F8E150
	// [XID] // 0x0000000189A9BC40-0x0000000189A9BC60
	protected virtual void AlignAvatarVoiceSwitch() {} // 0x0000000182F8DD60-0x0000000182F8DEC0
	// [XID] // 0x0000000189ACEC30-0x0000000189ACEC50
	protected virtual void SetupSupplementarySwitches() {} // 0x0000000182F8E8C0-0x0000000182F8EB40
	// [XID] // 0x0000000189AD6BD0-0x0000000189AD6BF0
	protected virtual bool CheckOwnerAvatarAnimatorAllowsWeaponAppearEvent() => default; // 0x0000000182F8D830-0x0000000182F8D930
	// [XID] // 0x0000000189AD82F0-0x0000000189AD8310
	protected override bool ShouldIgnoreHittingSceneMessage() => default; // 0x0000000182F8E470-0x0000000182F8E590
}

