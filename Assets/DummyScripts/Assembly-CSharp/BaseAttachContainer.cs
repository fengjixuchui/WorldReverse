/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseAttachContainer // TypeDefIndex: 14621
{
	// Fields
	private List<AttachedModifier> _modifiersAttached; // 0x10

	// Constructors
	public BaseAttachContainer() {} // 0x0000000182438EF0-0x0000000182438F50

	// Methods
	// [XID] // 0x0000000189898420-0x0000000189898440
	public void Release() {} // 0x0000000182438B90-0x0000000182438C50
	// [XID] // 0x00000001896CB560-0x00000001896CB580
	private List<AttachedModifier> AllocateModifierAttachedList() => default; // 0x0000000182438670-0x0000000182438740
	// [XID] // 0x0000000189938BE0-0x0000000189938C00
	public void AttachModifier(ActorModifier modifier) {} // 0x0000000182438740-0x00000001824389B0
	// [XID] // 0x00000001899403B0-0x00000001899403D0
	public void RemoveAttachedModifier(ActorModifier modifier) {} // 0x00000001824389B0-0x0000000182438B90
	// [XID] // 0x0000000189947A30-0x0000000189947A50
	public void DetachFromActor(LCAbility actor, RemoveAbilityReason removeReason) {} // 0x0000000182438C50-0x0000000182438EF0
}

