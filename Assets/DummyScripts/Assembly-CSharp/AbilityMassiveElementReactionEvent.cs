/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMassiveElementReactionEvent : AbilityTaskEvent // TypeDefIndex: 20591
{
	// Fields
	public MassiveElementTriggerType triggerType; // 0x10
	public bool forceEnable; // 0x14

	// Properties
	public override AbilityEventID eventID { /* [XID] */ /* 0x000000018960CDA0-0x000000018960CDC0 */ get => default; } // 0x0000000183ECBDC0-0x0000000183ECBE60 

	// Constructors
	public AbilityMassiveElementReactionEvent() {} // 0x0000000183ECBE60-0x0000000183ECBED0

	// Methods
	// [XID] // 0x0000000189614330-0x0000000189614350
	public void Init(MassiveElementTriggerType pTriggerType, bool pForceEnable) {} // 0x0000000183ECBAB0-0x0000000183ECBB80
	// [XID] // 0x000000018961BD70-0x000000018961BD90
	public override void Destroy() {} // 0x0000000183ECBA10-0x0000000183ECBAB0
	// [XID] // 0x00000001896232A0-0x00000001896232C0
	public static void ForceEnableMassiveElementReaction(MassiveElementTriggerType triggerType) {} // 0x0000000183ECB8A0-0x0000000183ECBA10
	// [XID] // 0x000000018962AAE0-0x000000018962AB00
	public static void ForceDisableMassiveElementReaction(MassiveElementTriggerType triggerType) {} // 0x0000000183ECBB80-0x0000000183ECBCF0
}

