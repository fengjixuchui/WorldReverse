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

public sealed class AnimatorEventEffect : AnimatorEvent // TypeDefIndex: 19274
{
	// Fields
	public string effectPatternName; // 0x20
	// [Tooltip] // 0x000000018997B7D0-0x000000018997B800
	public AttachType attachType; // 0x28

	// Nested types
	public enum AttachType // TypeDefIndex: 19275
	{
		None = 0,
		AttachToStateLayer = 1,
		AttachToAnimatorState = 2
	}

	// Constructors
	public AnimatorEventEffect() {} // 0x00000001823C1480-0x00000001823C14E0

	// Methods
	// [XID] // 0x0000000189984710-0x0000000189984730
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x00000001823C0E90-0x00000001823C1040
	// [XID] // 0x000000018998C130-0x000000018998C150
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x00000001823C12C0-0x00000001823C1480
	// [XID] // 0x0000000189993E70-0x0000000189993E90
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x00000001823C10F0-0x00000001823C12C0
}

