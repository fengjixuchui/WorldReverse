/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCSCameraAimingCtrlPlugin : BaseComponentPlugin // TypeDefIndex: 12168
{
	// Fields
	private const string FOCUS_SHOT_NAME = "CameraFocusLongShot"; // Metadata: 0x00AEB6C2
	private const int INDEX_UPPER_VCAM = 0; // Metadata: 0x00AEB6D9
	private const int INDEX_LOWER_VCAM = 1; // Metadata: 0x00AEB6DD
	private const double DEFAULT_PITCH_X = 0; // Metadata: 0x00AEB6E1
	private CinemachineBrain _brain; // 0x58
	private MonoCameraFocusAttackHelper _cameraFocusSet; // 0x60
	private CinemachineMixingCamera _mixingCamera; // 0x68
	private Transform _targetAnchor; // 0x70
	private double _minDegreeX; // 0x78
	private double _maxDegreeX; // 0x80
	private double _minLerpDegreeX; // 0x88
	private double _maxLerpDegreeX; // 0x90
	private Vector3d _anchorEuler; // 0x98
	private Vector3d _cameraFollowLowerPos; // 0xB0
	private double _cameraFollowLowerDegree; // 0xC8
	private bool _needCameraFollowLower; // 0xD0
	private Vector3d _cameraFollowUpperPos; // 0xD8
	private double _cameraFollowUpperDegree; // 0xF0
	private bool _needCameraFollowUpper; // 0xF8
	private VCStackCamera _vcStackCamera; // 0x100
	private SCameraShotTask _shotTask; // 0x108

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A8E5B0-0x0000000189A8E5D0 */ get => default; } // 0x0000000182A5FA10-0x0000000182A5FAB0 

	// Constructors
	public VCSCameraAimingCtrlPlugin() {} // 0x0000000182A5F8C0-0x0000000182A5FA10

	// Methods
	// [XID] // 0x0000000189A959F0-0x0000000189A95A10
	public override void Init() {} // 0x0000000182A5ED40-0x0000000182A5EE40
	// [XID] // 0x0000000189A9D2C0-0x0000000189A9D2E0
	private void InitCamerSet() {} // 0x0000000182A5E920-0x0000000182A5EA90
	// [XID] // 0x0000000189AA49C0-0x0000000189AA49E0
	private void InitCamerSetInternal(GameObject shotInst) {} // 0x0000000182A5E720-0x0000000182A5E850
	// [XID] // 0x0000000189B09D20-0x0000000189B09D40
	public void EnterFocus() {} // 0x0000000182A5EE40-0x0000000182A5F090
	// [XID] // 0x000000018973FB80-0x000000018973FBA0
	public void ExitFocus() {} // 0x0000000182A5F310-0x0000000182A5F3D0
	// [XID] // 0x0000000189A99160-0x0000000189A99180
	public void RegisterAimingCameraSet(GameObject setObj) {} // 0x0000000182A5EA90-0x0000000182A5ED40
	// [XID] // 0x000000018983FF80-0x000000018983FFA0
	private bool IsAimingInValid() => default; // 0x0000000182A5E850-0x0000000182A5E920
	// [XID] // 0x0000000189652840-0x0000000189652860
	public double UpdatePitchXByDegree(double degree) => default; // 0x0000000182A5F5E0-0x0000000182A5F7B0
	// [XID] // 0x0000000189B4FBF0-0x0000000189B4FC10
	private void SetWeights(double degree) {} // 0x0000000182A5F7B0-0x0000000182A5F8C0
	// [XID] // 0x0000000189AD9930-0x0000000189AD9950
	public void SetCameraFollowLower(Vector3d cameraFollowLowerPos, double cameraFollowLowerDegree) {} // 0x0000000182A5F3D0-0x0000000182A5F5E0
	// [XID] // 0x000000018999C210-0x000000018999C230
	public void SetCameraFollowUpper(Vector3d cameraFollowUpperPos, double cameraFollowUpperDegree) {} // 0x0000000182A5F090-0x0000000182A5F2A0
}

