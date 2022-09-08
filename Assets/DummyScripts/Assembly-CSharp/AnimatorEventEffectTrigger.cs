/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorEventEffectTrigger : AnimatorEvent // TypeDefIndex: 19317
{
	// Fields
	public AnimatorParamType type; // 0x20
	public int value; // 0x24
	public string parameter; // 0x28
	public string effectPattern; // 0x30
	private static List<MonoEffectProxy> _proxyListCache; // 0x00

	// Constructors
	public AnimatorEventEffectTrigger() {} // 0x0000000181890240-0x00000001818902B0
	static AnimatorEventEffectTrigger() {} // 0x00000001818901B0-0x0000000181890240

	// Methods
	// [XID] // 0x00000001897C7DF0-0x00000001897C7E10
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x000000018188F840-0x000000018188FA80
	// [XID] // 0x00000001897CF0B0-0x00000001897CF0D0
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x000000018188FFD0-0x00000001818901B0
	// [XID] // 0x00000001897D6840-0x00000001897D6860
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x000000018188FB30-0x000000018188FCD0
	// [XID] // 0x00000001897DE070-0x00000001897DE090
	public static void SetEffectAnimatorParam(BaseEntity target, string effectName, string parameter, AnimatorParamType type, int value) {} // 0x000000018188FCD0-0x000000018188FFD0
}

