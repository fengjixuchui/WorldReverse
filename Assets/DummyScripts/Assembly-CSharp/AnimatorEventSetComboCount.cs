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

public sealed class AnimatorEventSetComboCount : AnimatorEvent // TypeDefIndex: 19308
{
	// Fields
	public SetType set; // 0x20
	public int comboCount; // 0x24

	// Nested types
	public enum SetType // TypeDefIndex: 19309
	{
		Set = 0,
		Clear = 1
	}

	// Constructors
	public AnimatorEventSetComboCount() {} // 0x000000018340B4D0-0x000000018340B530

	// Methods
	// [XID] // 0x000000018972E130-0x000000018972E150
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x000000018340AF10-0x000000018340B060
	// [XID] // 0x0000000189735820-0x0000000189735840
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x000000018340B380-0x000000018340B4D0
	// [XID] // 0x000000018973D370-0x000000018973D390
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x000000018340B110-0x000000018340B380
}

