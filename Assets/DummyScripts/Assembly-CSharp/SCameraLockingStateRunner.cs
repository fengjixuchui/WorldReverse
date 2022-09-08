/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraLockingStateRunner : SCameraStateBaseRunner<SCameraLockingState> // TypeDefIndex: 32088
{
	// Fields
	private List<SCameraLockingData> _stack; // 0x658
	private bool _hasData; // 0x660
	private SCameraModuleInitialize _initialModule; // 0x668
	private SCameraModuleLocking _lockingModule; // 0x670

	// Properties
	public List<SCameraLockingData> dataStack { /* [XID] */ /* 0x00000001898AED20-0x00000001898AED40 */ get => default; } // 0x0000000184244890-0x0000000184244940 

	// Constructors
	public SCameraLockingStateRunner() {} // 0x0000000184245360-0x0000000184245410

	// Methods
	// [XID] // 0x00000001898B6140-0x00000001898B6160
	protected override void InitModules() {} // 0x0000000184244C60-0x0000000184244DD0
	// [XID] // 0x00000001898BD990-0x00000001898BD9B0
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000184244150-0x0000000184244720
	// [XID] // 0x00000001898C52C0-0x00000001898C52E0
	public override void OnSpawn() {} // 0x0000000184243FA0-0x0000000184244090
	// [XID] // 0x00000001898CC7B0-0x00000001898CC7D0
	public void RefreshCombatSetting(double deltaTime) {} // 0x00000001842450E0-0x00000001842451C0
	// [XID] // 0x00000001898D41D0-0x00000001898D41F0
	protected override void CollectPreInternal() {} // 0x0000000184244090-0x0000000184244150
	// [XID] // 0x00000001898DB9F0-0x00000001898DBA10
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000184244DD0-0x0000000184244ED0
	// [XID] // 0x00000001898E35D0-0x00000001898E35F0
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x0000000184243EA0-0x0000000184243FA0
	// [XID] // 0x00000001898EB260-0x00000001898EB280
	public override void OnUnSpawn() {} // 0x00000001842451C0-0x00000001842452A0
	// [XID] // 0x00000001898F29A0-0x00000001898F29C0
	public void EnterLocking(SCameraLockingData data) {} // 0x0000000184244ED0-0x0000000184244FA0
	// [XID] // 0x00000001898FA150-0x00000001898FA170
	private void EnterLockingInternal(SCameraLockingData data) {} // 0x0000000184244A20-0x0000000184244B20
	// [XID] // 0x0000000189901B00-0x0000000189901B20
	public void ExitLocking(SCameraLockingData data) {} // 0x0000000184244720-0x0000000184244810
	// [XID] // 0x00000001899092B0-0x00000001899092D0
	private void ExitLockingInternal(SCameraLockingData data) {} // 0x0000000184244940-0x0000000184244A20
	// [XID] // 0x00000001899107A0-0x00000001899107C0
	protected override void TickInternal(float deltaTime) {} // 0x00000001842452A0-0x0000000184245360
}

