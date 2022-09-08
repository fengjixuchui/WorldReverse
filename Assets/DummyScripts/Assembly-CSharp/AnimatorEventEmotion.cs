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

public sealed class AnimatorEventEmotion : AnimatorEvent // TypeDefIndex: 19302
{
	// Fields
	public bool enableEmotion; // 0x20
	public string emotionName; // 0x28
	public float emotionTransitionTime; // 0x30
	public bool enableEyeCtrl; // 0x34
	public Vector3 eyeTargetOffset; // 0x38
	public float eyeTransitionTime; // 0x44
	public bool enableBlink; // 0x48

	// Constructors
	public AnimatorEventEmotion() {} // 0x000000018656D170-0x000000018656D1E0

	// Methods
	// [XID] // 0x0000000189624B30-0x0000000189624B50
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x000000018656C890-0x000000018656CBD0
	// [XID] // 0x000000018962C2F0-0x000000018962C310
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x000000018656CE80-0x000000018656D170
	// [XID] // 0x0000000189633E10-0x0000000189633E30
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x000000018656CC80-0x000000018656CE80
}

