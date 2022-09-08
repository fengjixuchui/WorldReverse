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

public sealed class AnimatorEventTurnDirection : AnimatorEvent // TypeDefIndex: 19277
{
	// Fields
	// [Tooltip] // 0x00000001899B2220-0x00000001899B2250
	public TurnMode turnMode; // 0x20
	// [Tooltip] // 0x00000001899BAE80-0x00000001899BAEB0
	public float faceToTargetAngleThreshold; // 0x24

	// Constructors
	public AnimatorEventTurnDirection() {} // 0x00000001829BD070-0x00000001829BD0D0

	// Methods
	// [XID] // 0x00000001899C40E0-0x00000001899C4100
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x00000001829BCB50-0x00000001829BCCD0
	// [XID] // 0x00000001899CB8E0-0x00000001899CB900
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x00000001829BCEF0-0x00000001829BD070
	// [XID] // 0x00000001899D2DD0-0x00000001899D2DF0
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x00000001829BCD80-0x00000001829BCEF0
}

