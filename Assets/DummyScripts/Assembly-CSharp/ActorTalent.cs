/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ActorTalent // TypeDefIndex: 14625
{
	// Fields
	[NonSerialized]
	public LCTalent caster; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public uint talentSkillID; // 0x18
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public string talentName; // 0x20
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public SimpleSafeFloat[] talentParams; // 0x28
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _isTriggered; // 0x30
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	private List<BaseTalentMixin> _mixins; // 0x38

	// Constructors
	public ActorTalent() {} // Dummy constructor
	public ActorTalent(LCTalent caster, BaseTalentConfig talent) {} // 0x0000000183E68FB0-0x0000000183E69080

	// Methods
	// [XID] // 0x0000000189977C30-0x0000000189977C50
	public void Destroy() {} // 0x0000000183E68570-0x0000000183E68620
	// [XID] // 0x000000018997EE30-0x000000018997EE50
	private void InitTalentMixins() {} // 0x0000000183E68D90-0x0000000183E68FB0
	// [XID] // 0x0000000189986770-0x0000000189986790
	private void DestroyTalentMixins() {} // 0x0000000183E68AD0-0x0000000183E68C10
	// [XID] // 0x000000018998E350-0x000000018998E370
	public bool IsTriggered() => default; // 0x0000000183E68800-0x0000000183E688A0
	// [XID] // 0x0000000189995E40-0x0000000189995E60
	public void SetTalentActive(bool active) {} // 0x0000000183E68CD0-0x0000000183E68D90
	// [XID] // 0x000000018999D900-0x000000018999D920
	public void SetTalentTrigger(bool trigger) {} // 0x0000000183E68C10-0x0000000183E68CD0
	// [XID] // 0x00000001897588B0-0x00000001897588D0
	private void DoSetTalentTrigger(bool trigger, bool fromActive) {} // 0x0000000183E688A0-0x0000000183E68AD0
	// [XID] // 0x0000000189681700-0x0000000189681720
	public void RefreshParam(string abilityName, string paramName, ref float delta, ref float ratio) {} // 0x0000000183E68620-0x0000000183E68800
	// [XID] // 0x00000001899B4470-0x00000001899B4490
	public bool HasUnlockedTalentParam(string abilityName, string paramName) => default; // 0x0000000183E683B0-0x0000000183E68570
}

