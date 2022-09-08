/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorEventSkillStart : AnimatorEvent // TypeDefIndex: 19295
{
	// Fields
	public bool disableReverseTrack; // 0x20
	public uint skillID; // 0x24
	public float cdRatio; // 0x28
	public float costStaminaRatio; // 0x2C

	// Constructors
	public AnimatorEventSkillStart() {} // 0x00000001827068B0-0x0000000182706920

	// Methods
	// [XID] // 0x0000000189B7A170-0x0000000189B7A190
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x0000000182706310-0x00000001827064C0
	// [XID] // 0x0000000189B81890-0x0000000189B818B0
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x0000000182706710-0x00000001827068B0
	// [XID] // 0x0000000189B88F90-0x0000000189B88FB0
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x0000000182706570-0x0000000182706710
}

