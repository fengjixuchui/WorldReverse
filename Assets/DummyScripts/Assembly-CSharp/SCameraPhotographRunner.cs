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

public sealed class SCameraPhotographRunner : SCameraStateBaseRunner<SCameraPhotographState> // TypeDefIndex: 32106
{
	// Fields
	private SCameraModuleInitialize _initialModule; // 0x658
	private SCameraModulePhotograph _photographModule; // 0x660
	private double _fov; // 0x668
	private double _shiftLeftRight; // 0x670
	private double _shiftUpDown; // 0x678
	private double startLerpX; // 0x680
	private double startLerpY; // 0x688
	private Vector3d targetVector; // 0x690

	// Properties
	public double ShiftLeftRight { /* [XID] */ /* 0x0000000189934890-0x00000001899348B0 */ get => default; } // 0x0000000182B60F00-0x0000000182B60FB0 
	public double ShiftUpDown { /* [XID] */ /* 0x000000018993C340-0x000000018993C360 */ get => default; } // 0x0000000182B60DA0-0x0000000182B60E50 

	// Constructors
	public SCameraPhotographRunner() {} // 0x0000000182B627F0-0x0000000182B628C0

	// Methods
	// [XID] // 0x0000000189943990-0x00000001899439B0
	protected override void InitModules() {} // 0x0000000182B61B10-0x0000000182B61C80
	// [XID] // 0x000000018994AF10-0x000000018994AF30
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000182B61030-0x0000000182B61590
	// [XID] // 0x0000000189952870-0x0000000189952890
	public void EnterPhotograph() {} // 0x0000000182B61800-0x0000000182B61950
	// [XID] // 0x0000000189959E50-0x0000000189959E70
	public void ExitPhotograph() {} // 0x0000000182B60BE0-0x0000000182B60CE0
	// [XID] // 0x0000000189961820-0x0000000189961840
	public override void OnSpawn() {} // 0x0000000182B60AF0-0x0000000182B60BE0
	// [XID] // 0x0000000189968F50-0x0000000189968F70
	protected override void CollectPreInternal() {} // 0x0000000182B60E50-0x0000000182B60F00
	// [XID] // 0x0000000189970990-0x00000001899709B0
	public override void OnUnSpawn() {} // 0x0000000182B62640-0x0000000182B62720
	// [XID] // 0x0000000189978350-0x0000000189978370
	protected override void TickInternal(float deltaTime) {} // 0x0000000182B62720-0x0000000182B627F0
	// [XID] // 0x000000018997F460-0x000000018997F480
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000182B61C80-0x0000000182B61E60
	// [XID] // 0x0000000189986E00-0x0000000189986E20
	protected override void HandleSetFov(ref SCameraCmd cmd) {} // 0x0000000182B62420-0x0000000182B624E0
	// [XID] // 0x000000018998E870-0x000000018998E890
	protected override void HandleShiftCmd(ref SCameraCmd cmd) {} // 0x0000000182B60CE0-0x0000000182B60DA0
	// [XID] // 0x0000000189996400-0x0000000189996420
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x0000000182B609F0-0x0000000182B60AF0
	// [XID] // 0x000000018999DF50-0x000000018999DF70
	protected override void HandleInitBackward(ref SCameraCmd cmd) {} // 0x0000000182B61590-0x0000000182B61780
	// [XID] // 0x00000001899A59D0-0x00000001899A59F0
	protected override void HandleLerpBackward(ref SCameraCmd cmd) {} // 0x0000000182B61EC0-0x0000000182B623A0
}

