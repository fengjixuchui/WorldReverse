/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoEmotion;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InterEmotionTask : BaseInterTask // TypeDefIndex: 20920
{
	// Fields
	private EmoSync _emoSync; // 0x38
	private EyeCtrl _eyeCtrl; // 0x40
	private Transform _viewTarget; // 0x48
	private Vector3 _originPos; // 0x50
	private Vector3 _startPos; // 0x5C
	private Vector3 _targetPos; // 0x68

	// Properties
	public override InteractionType dataType { /* [XID] */ /* 0x00000001896DADE0-0x00000001896DAE00 */ get => default; } // 0x00000001837779D0-0x0000000183777A70 

	// Constructors
	public InterEmotionTask() {} // 0x00000001837780F0-0x0000000183778160

	// Methods
	// [XID] // 0x00000001896D3260-0x00000001896D3280
	public override void ResetObject() {} // 0x0000000183777FC0-0x00000001837780F0
	// [XID] // 0x00000001896E2580-0x00000001896E25A0
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x0000000183777A70-0x0000000183777BE0
	// [XID] // 0x00000001896E9A60-0x00000001896E9A80
	private bool InitComponents(BaseEntity inteeEntity) => default; // 0x00000001837776F0-0x0000000183777900
	// [XID] // 0x00000001896F0C20-0x00000001896F0C40
	private void PerformEmotion(ConfigEmotionInterAction cfg) {} // 0x0000000183777BE0-0x0000000183777F40
	// [XID] // 0x00000001896F84A0-0x00000001896F84C0
	public override void Tick() {} // 0x0000000183777600-0x00000001837776F0
	// [XID] // 0x00000001896FFE20-0x00000001896FFE40
	private void TickEyeCtrl(bool isFinished = false /* Metadata: 0x00AFE6E3 */) {} // 0x0000000183777360-0x00000001837775A0
}

