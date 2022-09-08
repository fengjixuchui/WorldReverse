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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class EvtAISound : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20043
{
	// Fields
	public AISoundType soundType; // 0x30
	public Vector3 position; // 0x34
	public float volume; // 0x40

	// Constructors
	protected EvtAISound() {} // 0x0000000183EC8C20-0x0000000183EC8C80

	// Methods
	[BlackList] // 0x0000000189929560-0x00000001899295A0
	// [XID] // 0x0000000189929560-0x00000001899295A0
	public override void AutoAllocTypeFields() {} // 0x0000000183EC8670-0x0000000183EC8710
	[BlackList] // 0x0000000189933820-0x0000000189933860
	// [XID] // 0x0000000189933820-0x0000000189933860
	public override void AutoRecycleTypeFields() {} // 0x0000000183EC8710-0x0000000183EC87D0
	[BlackList] // 0x000000018993E230-0x000000018993E270
	// [XID] // 0x000000018993E230-0x000000018993E270
	public override void ReturnToObjectPool() {} // 0x0000000183EC8A60-0x0000000183EC8B00
	// [XID] // 0x0000000189948760-0x0000000189948780
	public void Init(AISoundType pSoundType, Vector3 pSourcePosition) {} // 0x0000000183EC88A0-0x0000000183EC89A0
	// [XID] // 0x000000018994FEB0-0x000000018994FED0
	public override string ToString() => default; // 0x0000000183EC8B00-0x0000000183EC8C20
}

