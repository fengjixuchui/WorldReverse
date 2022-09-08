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

public sealed class EvtSceneAudioSetSwitch : EvtSceneAudio, IAutoAllocRecycle // TypeDefIndex: 20156
{
	// Properties
	public override SceneAudioType audioType { /* [XID] */ /* 0x000000018979B9D0-0x000000018979B9F0 */ get => default; } // 0x00000001820EA320-0x00000001820EA3C0 
	public uint switchName { get; /* [XID] */ /* 0x00000001897AA3C0-0x00000001897AA400 */ private set; } // 0x00000001820EA630-0x00000001820EA690 0x00000001820EA260-0x00000001820EA2C0
	public uint switchValue { get; /* [XID] */ /* 0x00000001897BD310-0x00000001897BD350 */ private set; } // 0x00000001820EA2C0-0x00000001820EA320 0x00000001820EA570-0x00000001820EA5D0

	// Constructors
	public EvtSceneAudioSetSwitch() {} // 0x00000001820EA730-0x00000001820EA790

	// Methods
	[BlackList] // 0x000000018977B8E0-0x000000018977B920
	// [XID] // 0x000000018977B8E0-0x000000018977B920
	public override void AutoAllocTypeFields() {} // 0x00000001820EA040-0x00000001820EA0E0
	[BlackList] // 0x0000000189786300-0x0000000189786340
	// [XID] // 0x0000000189786300-0x0000000189786340
	public override void AutoRecycleTypeFields() {} // 0x00000001820EA0E0-0x00000001820EA200
	[BlackList] // 0x00000001897908D0-0x0000000189790910
	// [XID] // 0x00000001897908D0-0x0000000189790910
	public override void ReturnToObjectPool() {} // 0x00000001820EA690-0x00000001820EA730
	// [XID] // 0x00000001897C7D10-0x00000001897C7D30
	public void Init(uint targetID, uint switchName, uint switchValue) {} // 0x00000001820EA3C0-0x00000001820EA510
}

