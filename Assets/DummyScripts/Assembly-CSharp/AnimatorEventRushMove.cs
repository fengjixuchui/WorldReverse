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

public sealed class AnimatorEventRushMove : AnimatorEvent // TypeDefIndex: 19281
{
	// Fields
	// [Tooltip] // 0x0000000189A1D250-0x0000000189A1D280
	public float timeRange; // 0x20
	// [Tooltip] // 0x0000000189A260B0-0x0000000189A260E0
	public bool offesetForward; // 0x24
	// [Tooltip] // 0x0000000189A2EE20-0x0000000189A2EE50
	public float fixedOffeset; // 0x28
	public float minRush; // 0x2C
	public float maxRush; // 0x30

	// Constructors
	public AnimatorEventRushMove() {} // 0x00000001846B50A0-0x00000001846B5100

	// Methods
	// [XID] // 0x0000000189A37EB0-0x0000000189A37ED0
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x00000001846B4A70-0x00000001846B4C50
	// [XID] // 0x0000000189A3F600-0x0000000189A3F620
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x00000001846B4EC0-0x00000001846B50A0
	// [XID] // 0x0000000189A46C90-0x0000000189A46CB0
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x00000001846B4D00-0x00000001846B4EC0
}

