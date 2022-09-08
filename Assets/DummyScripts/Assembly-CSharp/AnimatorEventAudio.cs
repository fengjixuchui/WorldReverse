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

public sealed class AnimatorEventAudio : AnimatorEvent // TypeDefIndex: 19290
{
	// Fields
	private bool _hasConvertedId; // 0x20
	private uint _audioEventId; // 0x24
	public string audioEventName; // 0x28
	public AudioAnimEventParam.Condition condition; // 0x30

	// Properties
	public uint audioEventId { /* [XID] */ /* 0x0000000189B03170-0x0000000189B03190 */ get => default; } // 0x0000000183747E10-0x0000000183747F30 

	// Constructors
	public AnimatorEventAudio() {} // 0x0000000183748090-0x00000001837480F0

	// Methods
	// [XID] // 0x0000000189B0A870-0x0000000189B0A890
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x0000000183747900-0x0000000183747BD0
	// [XID] // 0x0000000189B11F60-0x0000000189B11F80
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x0000000183747F30-0x0000000183748090
	// [XID] // 0x0000000189B19270-0x0000000189B19290
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x0000000183747C80-0x0000000183747E10
}

