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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraPostModuleShake : SCameraStatePostModule // TypeDefIndex: 32122
{
	// Fields
	private int _LayerIndex; // 0x18
	private RaycastHit _hitInfo; // 0x20
	private int[] _colliderIds; // 0x60
	private float? _shakeEnergyContainer; // 0x68
	private double _shakeEnergy; // 0x70
	private Vector3 _shakeOffset; // 0x78
	private double _shakeTimer; // 0x88
	private Vector3d _idealLocalPosition; // 0x90
	private Vector3d _beforeShake_Position; // 0xA8
	private Vector3d _beforeShake_Forward; // 0xC0
	private Vector3d _beforeShake_Up; // 0xD8
	private Vector3d _curGlobalPosition; // 0xF0
	private Quaterniond _curOrientation; // 0x108
	private Vector3d _curForward; // 0x128
	private Vector3d _curUp; // 0x140
	private const double SMALL_NUM_FOR_NEAR_CLIP_PLANE_THICKNESS = 0.0020000000949949026; // Metadata: 0x00B140D8

	// Constructors
	public SCameraPostModuleShake() {} // 0x00000001829AB7A0-0x00000001829AB8C0

	// Methods
	// [XID] // 0x00000001896F38D0-0x00000001896F38F0
	protected override void TickInternal(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001829AAFE0-0x00000001829AB2B0
	// [XID] // 0x00000001896FAFB0-0x00000001896FAFD0
	private void UpdateTransform(ref CameraStateData data) {} // 0x00000001829AB490-0x00000001829AB5F0
	// [XID] // 0x00000001897026C0-0x00000001897026E0
	private void SetupShake() {} // 0x00000001829AB5F0-0x00000001829AB6E0
	// [XID] // 0x0000000189709F30-0x0000000189709F50
	private void ClearShake() {} // 0x00000001829AB3C0-0x00000001829AB490
	// [XID] // 0x00000001897119B0-0x00000001897119D0
	private void UpdateShake(double deltaTime, ref CameraStateData data) {} // 0x00000001829AAE40-0x00000001829AAFE0
	// [XID] // 0x0000000189718DF0-0x0000000189718E10
	private void ShakeProtect(ref CameraStateData data) {} // 0x00000001829AA660-0x00000001829AAE40
	// [XID] // 0x0000000189720590-0x00000001897205B0
	private void CopyOutput(ref CameraStateData data) {} // 0x00000001829AB2B0-0x00000001829AB3C0
}

