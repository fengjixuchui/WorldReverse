/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSceneAudioPostMIDIEvent : EvtSceneAudio, IAutoAllocRecycle // TypeDefIndex: 20155
{
	// Properties
	public override SceneAudioType audioType { /* [XID] */ /* 0x000000018972E050-0x000000018972E070 */ get => default; } // 0x0000000184AAE160-0x0000000184AAE200 
	public int instrument { /* [XID] */ /* 0x0000000189735730-0x0000000189735770 */ get; /* [XID] */ /* 0x00000001897405F0-0x0000000189740630 */ private set; } // 0x0000000184AAE360-0x0000000184AAE3C0 0x0000000184AAE420-0x0000000184AAE480
	public int note { /* [XID] */ /* 0x000000018974AE60-0x000000018974AEA0 */ get; /* [XID] */ /* 0x0000000189755240-0x0000000189755280 */ private set; } // 0x0000000184AADEE0-0x0000000184AADF40 0x0000000184AAE4E0-0x0000000184AAE540

	// Constructors
	public EvtSceneAudioPostMIDIEvent() {} // 0x0000000184AAE5E0-0x0000000184AAE640

	// Methods
	[BlackList] // 0x000000018970EEE0-0x000000018970EF20
	// [XID] // 0x000000018970EEE0-0x000000018970EF20
	public override void AutoAllocTypeFields() {} // 0x0000000184AADF40-0x0000000184AADFE0
	[BlackList] // 0x0000000189719610-0x0000000189719650
	// [XID] // 0x0000000189719610-0x0000000189719650
	public override void AutoRecycleTypeFields() {} // 0x0000000184AADFE0-0x0000000184AAE100
	[BlackList] // 0x00000001897238F0-0x0000000189723930
	// [XID] // 0x00000001897238F0-0x0000000189723930
	public override void ReturnToObjectPool() {} // 0x0000000184AAE540-0x0000000184AAE5E0
	// [XID] // 0x000000018975F830-0x000000018975F850
	public void Init(uint targetID, int instrument, int note) {} // 0x0000000184AAE200-0x0000000184AAE360
}

