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

public sealed class SCameraModulePhotograph : SCameraModuleBase // TypeDefIndex: 32099
{
	// Fields
	private SCameraPhotographState _photographState; // 0x28
	private Vector3d _refAnchorSpherical; // 0x30
	private Vector3d _posAdjust; // 0x48
	private double _shiftTargetLeftRight; // 0x60
	private double _shiftTargetUpDown; // 0x68
	private double _shiftCurrLeftRight; // 0x70
	private double _shiftCurrUpDown; // 0x78
	private double _preShiftLeftRight; // 0x80
	private double _preShiftUpDown; // 0x88
	private double _shiftTime; // 0x90
	private double _shiftTimeUpDown; // 0x98

	// Constructors
	public SCameraModulePhotograph() {} // 0x000000018150FAD0-0x000000018150FB80

	// Methods
	// [XID] // 0x00000001897A0F20-0x00000001897A0F40
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x000000018150F330-0x000000018150F420
	// [XID] // 0x00000001897A85A0-0x00000001897A85C0
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x000000018150F0E0-0x000000018150F1B0
	// [XID] // 0x0000000189774EA0-0x0000000189774EC0
	public void Reset() {} // 0x000000018150F1B0-0x000000018150F280
	// [XID] // 0x00000001897B7C50-0x00000001897B7C70
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018150EEC0-0x000000018150F0E0
	// [XID] // 0x00000001897BFCC0-0x00000001897BFCE0
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018150F420-0x000000018150F9B0
	// [XID] // 0x00000001897C7510-0x00000001897C7530
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018150EA90-0x000000018150EE30
}

