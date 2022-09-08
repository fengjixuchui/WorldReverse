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

public sealed class AnimatorEventSetParamValue : AnimatorEvent // TypeDefIndex: 19310
{
	// Fields
	public TriggerParamType triggerType; // 0x20
	public string paramName; // 0x28
	public SetParamValueType setType; // 0x30
	public int intValue; // 0x34

	// Nested types
	public enum SetParamValueType // TypeDefIndex: 19311
	{
		Overwrite = 0,
		Addition = 1
	}

	public enum TriggerParamType // TypeDefIndex: 19312
	{
		Integer = 0
	}

	// Constructors
	public AnimatorEventSetParamValue() {} // 0x0000000181BEB8F0-0x0000000181BEB950

	// Methods
	// [XID] // 0x0000000189744830-0x0000000189744850
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x0000000181BEB1E0-0x0000000181BEB410
	// [XID] // 0x000000018974C580-0x000000018974C5A0
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x0000000181BEB720-0x0000000181BEB8F0
	// [XID] // 0x00000001897537A0-0x00000001897537C0
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x0000000181BEB4C0-0x0000000181BEB600
	// [XID] // 0x000000018975AD20-0x000000018975AD40
	private void SetIntegerParam(BaseEntity entity) {} // 0x0000000181BEB600-0x0000000181BEB720
}

