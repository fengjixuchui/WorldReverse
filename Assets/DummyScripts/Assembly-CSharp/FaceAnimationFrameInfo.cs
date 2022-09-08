/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class FaceAnimationFrameInfo : IAutoAllocRecycle // TypeDefIndex: 19815
{
	// Fields
	public string name; // 0x10
	public int length; // 0x18
	public float timePerFrame; // 0x1C
	public int[] leftEyeFrames; // 0x20
	public int[] rightEyeFrames; // 0x28
	public int[] mouthFrames; // 0x30
	public string message; // 0x38

	// Constructors
	public FaceAnimationFrameInfo() {} // 0x0000000181346320-0x0000000181346380

	// Methods
	// [XID] // 0x00000001896F5870-0x00000001896F5890
	public void OnBeforePoolRecycled() {} // 0x0000000181346130-0x00000001813461E0
	// [XID] // 0x00000001896FD030-0x00000001896FD050
	public void OnPoolAllocated() {} // 0x00000001813461E0-0x0000000181346280
	[BlackList] // 0x00000001897044C0-0x0000000189704500
	// [XID] // 0x00000001897044C0-0x0000000189704500
	public virtual void AutoAllocTypeFields() {} // 0x0000000181345FE0-0x0000000181346080
	[BlackList] // 0x000000018970EFC0-0x000000018970F000
	// [XID] // 0x000000018970EFC0-0x000000018970F000
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181346080-0x0000000181346130
	[BlackList] // 0x00000001897196F0-0x0000000189719730
	// [XID] // 0x00000001897196F0-0x0000000189719730
	public virtual void ReturnToObjectPool() {} // 0x0000000181346280-0x0000000181346320
}

