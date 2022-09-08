/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraNormalStateRunner : SCameraStateBaseRunner<SCameraNormalState> // TypeDefIndex: 32104
{
	// Fields
	private SCameraModuleInitialize _initialModule; // 0x658
	private double startLerpX; // 0x660
	private double startLerpY; // 0x668
	private Vector3d targetVector; // 0x670

	// Constructors
	public SCameraNormalStateRunner() {} // 0x0000000180E4E0B0-0x0000000180E4E160

	// Methods
	// [XID] // 0x00000001898C3AC0-0x00000001898C3AE0
	protected override void InitModules() {} // 0x0000000180E4CFC0-0x0000000180E4D120
	// [XID] // 0x00000001898CB340-0x00000001898CB360
	public override void OnSpawn() {} // 0x0000000180E4BEB0-0x0000000180E4BF60
	// [XID] // 0x00000001898D2A40-0x00000001898D2A60
	protected override void CollectPreInternal() {} // 0x0000000180E4BF60-0x0000000180E4C020
	// [XID] // 0x00000001898DA400-0x00000001898DA420
	protected override void HandleSetKeepRotation(ref SCameraCmd cmd) {} // 0x0000000180E4DF50-0x0000000180E4E0B0
	// [XID] // 0x00000001898E20D0-0x00000001898E20F0
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000180E4D120-0x0000000180E4D300
	// [XID] // 0x00000001898E9C70-0x00000001898E9C90
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x0000000180E4BD50-0x0000000180E4BEB0
	// [XID] // 0x00000001898F13D0-0x00000001898F13F0
	protected override void HandleResetBackward(ref SCameraCmd cmd) {} // 0x0000000180E4D300-0x0000000180E4D8B0
	// [XID] // 0x00000001898F8B00-0x00000001898F8B20
	protected override void HandleLerpBackward(ref SCameraCmd cmd) {} // 0x0000000180E4D910-0x0000000180E4DDF0
	// [XID] // 0x00000001899004D0-0x00000001899004F0
	protected override void HandleInitBackward(ref SCameraCmd cmd) {} // 0x0000000180E4CAE0-0x0000000180E4CCD0
	// [XID] // 0x0000000189907C10-0x0000000189907C30
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000180E4C020-0x0000000180E4CA60
	// [XID] // 0x000000018990F400-0x000000018990F420
	public void GetLookAtPositionAndRadius(ref Vector3d lookAt, ref double radius) {} // 0x0000000180E4CE30-0x0000000180E4CF40
}

