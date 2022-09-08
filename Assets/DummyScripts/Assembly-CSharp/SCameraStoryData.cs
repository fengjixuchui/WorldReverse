/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct SCameraStoryData // TypeDefIndex: 32126
{
	// Fields
	public bool isEnter; // 0x00
	public bool isClear; // 0x01
	public double duration; // 0x08
	public CameraStateBlenderConfig.BlendType blendType; // 0x10
	public EasingFunction.Ease easeType; // 0x14
	public CameraStateBlenderConfig.PoleType poleType; // 0x18
	public CameraStateData stateData; // 0x20
	public bool storyDither; // 0xF8
	public bool closeCameraDither; // 0xF9
	public bool keepSp; // 0xFA
	public Action onFinishHandler; // 0x100

	// Methods
	// [XID] // 0x0000000189988310-0x0000000189988330
	public void UpdateOrientation() {} // 0x0000000183521A20-0x0000000183521C70
}

