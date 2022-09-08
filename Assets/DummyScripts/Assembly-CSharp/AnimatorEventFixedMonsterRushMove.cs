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

public sealed class AnimatorEventFixedMonsterRushMove : AnimatorEvent // TypeDefIndex: 19318
{
	// Fields
	// [Tooltip] // 0x00000001897E5A80-0x00000001897E5AB0
	public float timeRange; // 0x20
	// [Tooltip] // 0x00000001897EECC0-0x00000001897EECF0
	public float maxRange; // 0x24
	// [Tooltip] // 0x00000001897F7D10-0x00000001897F7D40
	public string overrideMoveCollider; // 0x28
	// [Tooltip] // 0x0000000189800BD0-0x0000000189800C00
	public string[] animatorStateIDs; // 0x30
	// [Tooltip] // 0x00000001898099A0-0x00000001898099D0
	public bool isInAir; // 0x38

	// Constructors
	public AnimatorEventFixedMonsterRushMove() {} // 0x00000001826C1510-0x00000001826C1570

	// Methods
	// [XID] // 0x0000000189812860-0x0000000189812880
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x00000001826C0DF0-0x00000001826C1060
	// [XID] // 0x000000018981A4C0-0x000000018981A4E0
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x00000001826C12D0-0x00000001826C1510
	// [XID] // 0x0000000189821B70-0x0000000189821B90
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x00000001826C1110-0x00000001826C12D0
}

