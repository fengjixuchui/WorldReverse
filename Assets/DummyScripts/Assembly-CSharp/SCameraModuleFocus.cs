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

public sealed class SCameraModuleFocus : SCameraModuleBase // TypeDefIndex: 32091
{
	// Fields
	private Vector3d _refAnchorSpherical; // 0x28
	private Vector3d _refLookAt; // 0x40
	private double _refRadius; // 0x58
	private SCameraFocusState _focusState; // 0x60
	private SCameraFocusData _focusData; // 0x68
	private double _focusRotationRatio; // 0xC8
	private double _focusOffsetAngle; // 0xD0
	private double _focusStartOffsetAngle; // 0xD8

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x00000001899631A0-0x00000001899631C0 */ get => default; } // 0x000000018243F830-0x000000018243F8D0 

	// Constructors
	public SCameraModuleFocus() {} // 0x00000001824408A0-0x0000000182440940

	// Methods
	// [XID] // 0x000000018996A5C0-0x000000018996A5E0
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x000000018243FBA0-0x000000018243FD80
	// [XID] // 0x0000000189972280-0x00000001899722A0
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018243F4E0-0x000000018243F6C0
	// [XID] // 0x0000000189979AA0-0x0000000189979AC0
	public override void Start(ref CameraShareData data) {} // 0x000000018243F8D0-0x000000018243F9A0
	// [XID] // 0x0000000189981270-0x0000000189981290
	private void CheckPole(ref CameraShareData data) {} // 0x00000001824401D0-0x00000001824407B0
	// [XID] // 0x0000000189988A20-0x0000000189988A40
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018243FD80-0x000000018243FEA0
	// [XID] // 0x0000000189990220-0x0000000189990240
	private void PrepareFocusData() {} // 0x000000018243F6C0-0x000000018243F830
	// [XID] // 0x0000000189997CF0-0x0000000189997D10
	private void UpdateFocus(double deltaTime, ref CameraShareData data) {} // 0x000000018243FEA0-0x0000000182440130
	// [XID] // 0x000000018999F4C0-0x000000018999F4E0
	private void ComputeRefAnchorDuringRotating(double deltaTime, ref CameraShareData data) {} // 0x000000018243FA50-0x000000018243FBA0
	// [XID] // 0x00000001899A6FD0-0x00000001899A6FF0
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018243F180-0x000000018243F450
}

