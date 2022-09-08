/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioGadgetCombatPlugin : AudioCombatPlugin // TypeDefIndex: 12012
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A70120-0x0000000189A70140 */ get => default; } // 0x0000000182C71A20-0x0000000182C71AC0 

	// Constructors
	public AudioGadgetCombatPlugin() {} // Dummy constructor
	public AudioGadgetCombatPlugin(VCBaseAudio component) {} // 0x0000000182C719A0-0x0000000182C71A20

	// Methods
	// [XID] // 0x0000000189A77900-0x0000000189A77920
	protected override void PostImpactEvent(EvtBeingHit evt) {} // 0x0000000182C71460-0x0000000182C71660
	// [XID] // 0x0000000189A7F000-0x0000000189A7F020
	protected override AudioOneTimeEvent GetOverrideImpactEvent(bool hitHead) => default; // 0x0000000182C71740-0x0000000182C718B0
	// [XID] // 0x0000000189A869A0-0x0000000189A869C0
	protected override AudioOneTimeEvent GetHitEventConfig(AttackResult attackResult) => default; // 0x0000000182C71660-0x0000000182C71740
}

