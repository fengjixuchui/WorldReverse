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

public abstract class EvtSceneAudio : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20152
{
	// Properties
	public abstract SceneAudioType audioType { get; }

	// Nested types
	public enum SceneAudioType // TypeDefIndex: 20153
	{
		Invalid = 0,
		PostEvent = 1,
		Switch = 2,
		State = 3,
		RTPC = 4,
		PostMIDIEvent = 5
	}

	// Constructors
	protected EvtSceneAudio() {} // 0x00000001830F37C0-0x00000001830F3820

	// Methods
	[BlackList] // 0x0000000189691720-0x0000000189691760
	// [XID] // 0x0000000189691720-0x0000000189691760
	public override void AutoAllocTypeFields() {} // 0x00000001830F34C0-0x00000001830F3560
	[BlackList] // 0x000000018969BAB0-0x000000018969BAF0
	// [XID] // 0x000000018969BAB0-0x000000018969BAF0
	public override void AutoRecycleTypeFields() {} // 0x00000001830F3560-0x00000001830F3600
	[BlackList] // 0x00000001896A5D40-0x00000001896A5D80
	// [XID] // 0x00000001896A5D40-0x00000001896A5D80
	public override void ReturnToObjectPool() {} // 0x00000001830F3720-0x00000001830F37C0
}

