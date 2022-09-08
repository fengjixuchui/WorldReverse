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

public sealed class SCameraModuleFollowRotate : SCameraModuleBase // TypeDefIndex: 32092
{
	// Fields
	private const double _kRecenteringMinSpeed = 0.029999999329447746; // Metadata: 0x00B13C96
	private const double _kRecenteringMaxSpeed = 0.12999999523162842; // Metadata: 0x00B13C9E
	private const double _kRecenteringAcceleration = 0.05000000074505806; // Metadata: 0x00B13CA6
	private double _currentRecenteringSpeed; // 0x28
	private Vector3d _refAnchorSpherical; // 0x30
	private Vector3d _backward; // 0x48
	private Vector3d _idealAutoSph; // 0x60
	private bool isInCombat; // 0x78

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x00000001899AE960-0x00000001899AE980 */ get => default; } // 0x0000000181820FF0-0x0000000181821090 

	// Constructors
	public SCameraModuleFollowRotate() {} // 0x0000000181822140-0x00000001818221B0

	// Methods
	// [XID] // 0x00000001899B5CC0-0x00000001899B5CE0
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x0000000181820F20-0x0000000181820FF0
	// [XID] // 0x00000001899BD9E0-0x00000001899BDA00
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000181820E10-0x0000000181820F20
	// [XID] // 0x00000001899C5100-0x00000001899C5120
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181821420-0x0000000181821630
	// [XID] // 0x00000001899CC7D0-0x00000001899CC7F0
	private void RecordIdealYawWhenFirstEnterMove(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001818217A0-0x00000001818218F0
	// [XID] // 0x00000001899D3E80-0x00000001899D3EA0
	private void CheckIfEnterAutoKeepYaw(ref CameraShareData data) {} // 0x00000001818218F0-0x0000000181821A40
	// [XID] // 0x00000001899DB450-0x00000001899DB470
	private void ComputeRefAnchorDuringAuotKeepYaw(ref CameraShareData data) {} // 0x00000001818216D0-0x00000001818217A0
	// [XID] // 0x00000001899E2B50-0x00000001899E2B70
	private void ComputeRefAnchorDuringRotating(double deltaTime, ref CameraShareData data) {} // 0x00000001818212D0-0x0000000181821420
	// [XID] // 0x00000001899EA1B0-0x00000001899EA1D0
	private void ComputeRefAnchoIfRotated(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181821090-0x0000000181821220
	// [XID] // 0x00000001899F1C40-0x00000001899F1C60
	private void ComputeRefAnchorIfNoControl(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181821A40-0x0000000181821BF0
	// [XID] // 0x00000001899F9420-0x00000001899F9440
	private void ComputeRefAnchorIfRecentering(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181821C60-0x0000000181821FC0
	// [XID] // 0x0000000189A00700-0x0000000189A00720
	private void TryReduceAnchorAngularVelocity(double deltaTime, ref CameraShareData data) {} // 0x0000000181821FC0-0x00000001818220C0
	// [XID] // 0x0000000189A08040-0x0000000189A08060
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181820B70-0x0000000181820E10
}

