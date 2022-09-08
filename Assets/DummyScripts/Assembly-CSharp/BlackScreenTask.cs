/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BlackScreenTask // TypeDefIndex: 20672
{
	// Fields
	public float fadeInTargetTime; // 0x10
	public float fadeOutTargetTime; // 0x14
	public Action fadeInAction; // 0x18
	public Action fadeOutAction; // 0x20
	public CurtainTask curtainTask; // 0x28

	// Constructors
	public BlackScreenTask() {} // 0x00000001823B8EA0-0x00000001823B8F20

	// Methods
	// [XID] // 0x0000000189AEFB60-0x0000000189AEFB80
	public void TryDoAction(float currTime) {} // 0x00000001823B8C60-0x00000001823B8DC0
	// [XID] // 0x0000000189AF70A0-0x0000000189AF70C0
	public void TryTickCurtainTask(float currTime) {} // 0x00000001823B8A90-0x00000001823B8B90
	// [XID] // 0x0000000189AFE710-0x0000000189AFE730
	public bool IsAllFinish(float currTime) => default; // 0x00000001823B8DC0-0x00000001823B8EA0
	// [XID] // 0x0000000189B05F60-0x0000000189B05F80
	public bool IsCurtainTaskUnfinish() => default; // 0x00000001823B8B90-0x00000001823B8C60
}

