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

public sealed class SCameraModuleBossAdjust : SCameraModuleBase // TypeDefIndex: 32089
{
	// Fields
	private SCameraGiantBossAdjustState _bossAdjustState; // 0x28
	private ConfigSpecialCamera _lastConfig; // 0x30
	private ConfigSpecialCamera _config; // 0x38
	private BaseEntity _configEntity; // 0x40
	private double _tickTime; // 0x48
	private const double ADJUST_TIME = 0.5; // Metadata: 0x00B13C8E
	private double _currHeightAdjust; // 0x50
	private Vector3d _refAnchorSpherical; // 0x58
	private double speYRad; // 0x70
	private Vector3d _heightAdjust; // 0x78
	private bool _goingToIdeal; // 0x90
	private Vector3d _idealAnchorSpherical; // 0x98
	private double _preX; // 0xB0
	private double _currTime; // 0xB8
	private BaseEntity _currTarget; // 0xC0
	private Vector3d _enemyCenter; // 0xC8

	// Constructors
	public SCameraModuleBossAdjust() {} // 0x00000001839F6480-0x00000001839F6590

	// Methods
	// [XID] // 0x0000000189918320-0x0000000189918340
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x00000001839F57F0-0x00000001839F58E0
	// [XID] // 0x000000018991FBA0-0x000000018991FBC0
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x00000001839F5580-0x00000001839F5650
	// [XID] // 0x00000001899273D0-0x00000001899273F0
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001839F5300-0x00000001839F5580
	// [XID] // 0x000000018992EBB0-0x000000018992EBD0
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001839F58E0-0x00000001839F5CC0
	// [XID] // 0x0000000189936030-0x0000000189936050
	private void CheckGoingToIdeal(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001839F5D60-0x00000001839F61E0
	// [XID] // 0x000000018993DA90-0x000000018993DAB0
	private void StartGoingToIdeal(double toMoveRad) {} // 0x00000001839F5700-0x00000001839F57F0
	// [XID] // 0x0000000189945240-0x0000000189945260
	private void LerpToIdeal(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001839F6300-0x00000001839F6480
	// [XID] // 0x000000018994C6B0-0x000000018994C6D0
	private void StopGoingToIdeal() {} // 0x00000001839F6260-0x00000001839F6300
	// [XID] // 0x0000000189953DE0-0x0000000189953E00
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001839F4F00-0x00000001839F5270
}

