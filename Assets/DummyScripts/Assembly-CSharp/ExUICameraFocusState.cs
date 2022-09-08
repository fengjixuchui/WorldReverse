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

public sealed class ExUICameraFocusState : ExUICameraBaseState // TypeDefIndex: 30624
{
	// Fields
	private DIR _dir; // 0x20
	private Vector3 _originalPos; // 0x24
	private Vector3 _focusPos; // 0x30
	private float _startTime; // 0x3C
	private float _totalTime; // 0x40

	// Nested types
	public enum DIR // TypeDefIndex: 30625
	{
		ToFocus = 0,
		ExitFocus = 1,
		Idle = 2
	}

	// Constructors
	public ExUICameraFocusState() {} // Dummy constructor
	public ExUICameraFocusState(MonoExUICamera sm) {} // 0x000000018227DEC0-0x000000018227DF40

	// Methods
	// [XID] // 0x0000000189BD5AC0-0x0000000189BD5AE0
	public override void Update() {} // 0x000000018227D750-0x000000018227DAC0
	// [XID] // 0x0000000189BDD760-0x0000000189BDD780
	public override void Enter(ExUICameraBaseState lastState, object param = null) {} // 0x000000018227DD20-0x000000018227DEC0
	// [XID] // 0x00000001895EA310-0x00000001895EA330
	public override void Exit(ExUICameraBaseState nextState) {} // 0x000000018227DC70-0x000000018227DD20
	// [XID] // 0x00000001895F1790-0x00000001895F17B0
	public void OnEvent_StartExit(float duration) {} // 0x000000018227DB20-0x000000018227DBE0
}

