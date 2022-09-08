/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioCombatPlugin : AudioComponentPlugin // TypeDefIndex: 12007
{
	// Fields
	private ConfigAudioCombat _generalConfig; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899A09B0-0x00000001899A09D0 */ get => default; } // 0x0000000181930410-0x00000001819304B0 
	protected ConfigAudioCombat generalConfig { /* [XID] */ /* 0x00000001899A84A0-0x00000001899A84C0 */ get => default; } // 0x000000018192FA30-0x000000018192FAD0 

	// Constructors
	public AudioCombatPlugin() {} // Dummy constructor
	public AudioCombatPlugin(VCBaseAudio component) {} // 0x0000000181930390-0x0000000181930410

	// Methods
	// [XID] // 0x00000001899AFC70-0x00000001899AFC90
	public override void Init() {} // 0x000000018192F960-0x000000018192FA30
	// [XID] // 0x00000001899B70C0-0x00000001899B70E0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018192F260-0x000000018192F340
	// [XID] // 0x00000001899BEB40-0x00000001899BEB60
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001819301D0-0x00000001819302B0
	// [XID] // 0x00000001899C65C0-0x00000001899C65E0
	public override bool OnRemoteEvtBeingHit(BaseEvent evt) => default; // 0x00000001819302B0-0x0000000181930390
	// [XID] // 0x00000001899CDB00-0x00000001899CDB20
	protected virtual bool HandleEvtBeingHit(EvtBeingHit evt) => default; // 0x000000018192FAD0-0x000000018192FC00
	// [XID] // 0x00000001899D50E0-0x00000001899D5100
	protected virtual void PostImpactEvent(EvtBeingHit evt) {} // 0x000000018192F690-0x000000018192F960
	// [XID] // 0x00000001899DC660-0x00000001899DC680
	protected virtual AudioOneTimeEvent GetHitEventConfig(AttackResult attackResult) => default; // 0x000000018192FC00-0x000000018192FD30
	// [XID] // 0x00000001899E3EA0-0x00000001899E3EC0
	protected virtual AudioOneTimeEvent GetOverrideImpactEvent(bool hitHead) => default; // 0x000000018192FD30-0x000000018192FDE0
	// [XID] // 0x00000001899EB410-0x00000001899EB430
	protected virtual bool DidHitHead(AttackResult attackResult) => default; // 0x000000018192FDE0-0x000000018192FEB0
	// [XID] // 0x00000001899F30A0-0x00000001899F30C0
	protected virtual BaseEntity GetEntity(uint entityId) => default; // 0x000000018192F090-0x000000018192F180
	// [XID] // 0x00000001899FA750-0x00000001899FA770
	protected bool HasActualImpact(AttackResult attackResult) => default; // 0x00000001819300E0-0x00000001819301D0
	// [XID] // 0x0000000189A01960-0x0000000189A01980
	protected bool IsDumbHit(AttackResult config) => default; // 0x000000018192FEB0-0x000000018192FFF0
	// [XID] // 0x0000000189A09410-0x0000000189A09430
	protected virtual void PostOneTimeImpactEvent(AudioOneTimeEvent eventConfig, AttackResult attackResult) {} // 0x000000018192F340-0x000000018192F690
}

