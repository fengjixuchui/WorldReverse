/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using miHoYoThread;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SCameraBaseState : BaseCameraState // TypeDefIndex: 32069
{
	// Fields
	protected ISCameraRunner _sRunner; // 0x120
	[MainThreadOnly] // 0x0000000189613C10-0x0000000189613C20
	protected VCStackCamera _vcCamera; // 0x128

	// Properties
	public ISCameraRunner SRunner { /* [XID] */ /* 0x0000000189AC19B0-0x0000000189AC19D0 */ get => default; } // 0x0000000183FAC140-0x0000000183FAC1F0 
	public VCStackCamera vcCamera { /* [XID] */ /* 0x0000000189BB19C0-0x0000000189BB19E0 */ get => default; } // 0x0000000183FAC4D0-0x0000000183FAC580 
	public CameraProfile profile { /* [XID] */ /* 0x0000000189B1BD50-0x0000000189B1BD70 */ get => default; } // 0x0000000183FAC330-0x0000000183FAC3F0 
	public double zoomVelocity { /* [XID] */ /* 0x0000000189B57660-0x0000000189B57680 */ get => default; } // 0x0000000183FACF80-0x0000000183FAD050 

	// Constructors
	public SCameraBaseState() {} // 0x0000000183FAD920-0x0000000183FAD990

	// Methods
	// [XID] // 0x0000000189AC8FB0-0x0000000189AC8FD0
	public override void RegisterRunner(ICameraStateRunner runner) {} // 0x0000000183FAD4D0-0x0000000183FAD5A0
	// [XID] // 0x0000000189AD0A00-0x0000000189AD0A20
	public override void SwitchBackground(bool value) {} // 0x0000000183FAD5A0-0x0000000183FAD680
	// [XID] // 0x0000000189AD8620-0x0000000189AD8640
	protected override void OnSpawn() {} // 0x0000000183FAD350-0x0000000183FAD410
	// [XID] // 0x0000000189AE0260-0x0000000189AE0280
	protected override void OnUnSpawn() {} // 0x0000000183FAD410-0x0000000183FAD4D0
	// [XID] // 0x0000000189AE7870-0x0000000189AE7890
	public override void OnBlendToStart() {} // 0x0000000183FAD290-0x0000000183FAD350
	// [XID] // 0x0000000189AEF4D0-0x0000000189AEF4F0
	public override void OnBlendFromStart() {} // 0x0000000183FAD110-0x0000000183FAD1D0
	// [XID] // 0x0000000189AF6950-0x0000000189AF6970
	public override void OnBlendToFinished() {} // 0x0000000183FAD1D0-0x0000000183FAD290
	// [XID] // 0x0000000189AFDF80-0x0000000189AFDFA0
	public override void OnBlendFromFinished() {} // 0x0000000183FAD050-0x0000000183FAD110
	// [XID] // 0x0000000189B05750-0x0000000189B05770
	public virtual void ClearOnDisconnect() {} // 0x0000000183FACE90-0x0000000183FACF80
	// [XID] // 0x0000000189B0CF20-0x0000000189B0CF40
	public virtual bool ShiftWorld(Vector3d newShift, Vector3d oldShift) => default; // 0x0000000183FAC9C0-0x0000000183FACC90
	// [XID] // 0x0000000189B234D0-0x0000000189B234F0
	public void SetVCCamera(VCStackCamera vcCamera) {} // 0x0000000183FAC580-0x0000000183FAC630
	// [XID] // 0x0000000189B2A750-0x0000000189B2A770
	public void SetCameraAvatarPrepareData(CameraAvatarPrepareData data) {} // 0x0000000183FACCF0-0x0000000183FACDC0
	// [XID] // 0x0000000189B31CF0-0x0000000189B31D10
	public void SetCameraAvatarInfoData(ref CameraAvatarInfoData data) {} // 0x0000000183FACDC0-0x0000000183FACE90
	// [XID] // 0x0000000189B394B0-0x0000000189B394D0
	public void RefreshCameraAvatarInfo() {} // 0x0000000183FAC840-0x0000000183FAC900
	// [XID] // 0x0000000189B40DB0-0x0000000189B40DD0
	public void SetCameraShareData(ref CameraShareData data) {} // 0x0000000183FAC690-0x0000000183FAC760
	// [XID] // 0x0000000189B48720-0x0000000189B48740
	public override void UpdateByState(ICameraState state) {} // 0x0000000183FAD680-0x0000000183FAD920
	// [XID] // 0x0000000189B4FE40-0x0000000189B4FE60
	public override void Collect() {} // 0x0000000183FAC270-0x0000000183FAC330
}

