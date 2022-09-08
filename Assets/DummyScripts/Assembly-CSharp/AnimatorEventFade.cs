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

public sealed class AnimatorEventFade : AnimatorEvent // TypeDefIndex: 19304
{
	// Fields
	public float fromeValue; // 0x20
	public float toValue; // 0x24
	public float duration; // 0x28
	public bool isFromCurrentValue; // 0x2C

	// Constructors
	public AnimatorEventFade() {} // 0x00000001823204E0-0x0000000182320560

	// Methods
	// [XID] // 0x00000001896D4EE0-0x00000001896D4F00
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x000000018231FF60-0x0000000182320110
	// [XID] // 0x00000001896DC5E0-0x00000001896DC600
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x0000000182320330-0x00000001823204E0
	// [XID] // 0x00000001896E3D90-0x00000001896E3DB0
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x00000001823201C0-0x0000000182320330
}

