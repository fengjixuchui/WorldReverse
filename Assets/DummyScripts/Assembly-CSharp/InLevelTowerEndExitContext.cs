/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelTowerEndExitContext : BasePageContext // TypeDefIndex: 31306
{
	// Fields
	private MonoTowerEndExit _dialogMono; // 0x190
	private bool _hasRestart; // 0x198
	private bool _ticking; // 0x199
	private readonly float TotalWaitTime; // 0x19C
	private float _currTime; // 0x1A0

	// Constructors
	public InLevelTowerEndExitContext() {} // Dummy constructor
	public InLevelTowerEndExitContext(bool hasRestart) {} // 0x00000001840A3360-0x00000001840A3450

	// Methods
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840A2650-0x00000001840A2840
	public override void SetupView() {} // 0x00000001840A2FF0-0x00000001840A3090
	private void InitPage() {} // 0x00000001840A2840-0x00000001840A2FF0
	public override void UpdateView() {} // 0x00000001840A31F0-0x00000001840A3360
	private void TryExit() {} // 0x00000001840A3140-0x00000001840A31F0
	private void TryAgain() {} // 0x00000001840A3090-0x00000001840A3140
}

