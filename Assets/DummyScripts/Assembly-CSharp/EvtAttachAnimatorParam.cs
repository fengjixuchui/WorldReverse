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

public sealed class EvtAttachAnimatorParam : EvtBaseAttach, IAutoAllocRecycle // TypeDefIndex: 20051
{
	// Fields
	private AnimatorControllerParameterType _type; // 0x30
	private string _paramName; // 0x38
	public float paramFloat; // 0x40
	public int paramInt; // 0x44
	public bool paramBool; // 0x48
	public bool paramTrigger; // 0x49

	// Properties
	public AnimatorControllerParameterType type { /* [XID] */ /* 0x0000000189A8F170-0x0000000189A8F190 */ get => default; } // 0x000000018387D9F0-0x000000018387DA90 
	public string paramName { /* [XID] */ /* 0x0000000189A96660-0x0000000189A96680 */ get => default; } // 0x000000018387D8F0-0x000000018387D990 

	// Constructors
	public EvtAttachAnimatorParam() {} // 0x000000018387DB30-0x000000018387DBA0

	// Methods
	[BlackList] // 0x0000000189A6F4A0-0x0000000189A6F4E0
	// [XID] // 0x0000000189A6F4A0-0x0000000189A6F4E0
	public override void AutoAllocTypeFields() {} // 0x000000018387D5F0-0x000000018387D690
	[BlackList] // 0x0000000189A7A2B0-0x0000000189A7A2F0
	// [XID] // 0x0000000189A7A2B0-0x0000000189A7A2F0
	public override void AutoRecycleTypeFields() {} // 0x000000018387D690-0x000000018387D740
	[BlackList] // 0x0000000189A84860-0x0000000189A848A0
	// [XID] // 0x0000000189A84860-0x0000000189A848A0
	public override void ReturnToObjectPool() {} // 0x000000018387DA90-0x000000018387DB30
	// [XID] // 0x0000000189A9DC10-0x0000000189A9DC30
	public void Init(uint targetID, AnimatorControllerParameterType type, string paramName) {} // 0x000000018387D7A0-0x000000018387D890
}

