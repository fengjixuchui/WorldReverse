/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CutsceneFadeTask : BaseCutsceneTask // TypeDefIndex: 20700
{
	// Fields
	private FadeType _fadeType; // 0xC0
	private Color _tarColor; // 0xC4
	private CurtainTask _curtainTask; // 0xD8

	// Nested types
	public enum FadeType // TypeDefIndex: 20701
	{
		IN = 0,
		OUT = 1
	}

	// Constructors
	public CutsceneFadeTask() {} // 0x0000000182EE9360-0x0000000182EE9410

	// Methods
	// [IDTag] // 0x0000000189737240-0x0000000189737280
	// [XID] // 0x0000000189737240-0x0000000189737280
	public void Init(ConfigTimeline cfg, FadeType fadeType, Action<ILuaActor> finishHandler) {} // 0x0000000182EE8EF0-0x0000000182EE9060
	// [IDTag] // 0x0000000189741A20-0x0000000189741A60
	// [XID] // 0x0000000189741A20-0x0000000189741A60
	public void Init(float duration, FadeType fadeType, Action<ILuaActor> finishHandler) {} // 0x0000000182EE9060-0x0000000182EE9160
	// [XID] // 0x000000018974C410-0x000000018974C430
	public override void Start() {} // 0x0000000182EE8CA0-0x0000000182EE8EF0
	// [XID] // 0x00000001897536C0-0x00000001897536E0
	public void FinishCurtain() {} // 0x0000000182EE9240-0x0000000182EE9300
}

