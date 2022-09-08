/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorEventFreeInteraction : AnimatorEvent // TypeDefIndex: 19303
{
	// Fields
	public InterFreePriority priority; // 0x20
	public InteractionType interactionType; // 0x24
	public float duration; // 0x28
	public float deltaAngle; // 0x2C
	private bool _show_BODY_LANG; // 0x30
	private bool _show_EMOTION; // 0x31
	private bool _show_STEER; // 0x32
	// [InspectorShowIf] // 0x000000018963B5D0-0x000000018963B600
	public int bodyLangParamMin; // 0x34
	// [InspectorShowIf] // 0x000000018963B5D0-0x000000018963B600
	public int bodyLangParamMax; // 0x38
	// [InspectorShowIf] // 0x000000018963B5D0-0x000000018963B600
	public bool forceInterrupt; // 0x3C
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public string emotionName; // 0x40
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public float emotionTransitionTime; // 0x48
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public Vector3 lookAtOffset; // 0x4C
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public float eyeTransitionTime; // 0x58
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public bool blinkEnabled; // 0x5C
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public float blinkMinGap; // 0x60
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public float blinkMaxGap; // 0x64
	// [InspectorShowIf] // 0x000000018967A6B0-0x000000018967A6E0
	public float blinkDuration; // 0x68
	// [InspectorShowIf] // 0x00000001896917E0-0x0000000189691810
	public DialogSteerType steerType; // 0x6C
	// [InspectorShowIf] // 0x00000001896917E0-0x0000000189691810
	public float steerAngle; // 0x70

	// Properties
	private bool show_BODY_LANG { /* [XID] */ /* 0x00000001896A1B40-0x00000001896A1B60 */ get => default; } // 0x0000000181363F70-0x0000000181364010 
	private bool show_EMOTION { /* [XID] */ /* 0x00000001896A8F20-0x00000001896A8F40 */ get => default; } // 0x00000001813639B0-0x0000000181363A50 
	private bool show_STEER { /* [XID] */ /* 0x00000001896B00F0-0x00000001896B0110 */ get => default; } // 0x0000000181363860-0x0000000181363900 

	// Constructors
	public AnimatorEventFreeInteraction() {} // 0x00000001813644E0-0x00000001813645A0

	// Methods
	// [XID] // 0x00000001896B7970-0x00000001896B7990
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x0000000181363280-0x0000000181363860
	// [XID] // 0x00000001896BEA50-0x00000001896BEA70
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x0000000181364010-0x00000001813644E0
	// [XID] // 0x00000001896C63F0-0x00000001896C6410
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x0000000181363CF0-0x0000000181363F70
	// [XID] // 0x00000001896CDA10-0x00000001896CDA30
	private ConfigBaseInterAction GenInteractionConfig() => default; // 0x0000000181363A50-0x0000000181363CF0
}

