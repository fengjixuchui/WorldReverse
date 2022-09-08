/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraModuleZoom : SCameraModuleBase // TypeDefIndex: 32102
{
	// Fields
	private const double BACK_TO_IDEAL_FACTOR = 0.0001500000071246177; // Metadata: 0x00B13EDA
	private const double BACK_TO_IDEAL_STOP_THRESHOLD = 0.10000000149011612; // Metadata: 0x00B13EE2
	private double _elevationLocateRatio; // 0x28
	private double _ratioElevation; // 0x30
	private bool _charactorCombatValid; // 0x38
	private bool _charactorCombatNeedReset; // 0x39
	private double _cameraForceRadius; // 0x40
	private double _cameraForceRadiusDuration; // 0x48
	private bool _cameraShouldKeepForceRadius; // 0x50
	private double _radiusBeforeForce; // 0x58
	private double _radiusForceTimeCnt; // 0x60
	private bool isInCombat; // 0x68
	private bool _moveToDefault; // 0x69
	private double _moveToDefaultTime; // 0x70
	private double _preDistance; // 0x78

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x000000018984D8A0-0x000000018984D8C0 */ get => default; } // 0x00000001822F9A90-0x00000001822F9B30 

	// Constructors
	public SCameraModuleZoom() {} // 0x00000001822FAF50-0x00000001822FAFE0

	// Methods
	// [XID] // 0x0000000189854920-0x0000000189854940
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001822F9890-0x00000001822F9A90
	// [XID] // 0x000000018985C1E0-0x000000018985C200
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001822F9DF0-0x00000001822FA520
	// [XID] // 0x0000000189863B80-0x0000000189863BA0
	private void CheckMoveToDefault(ref CameraShareData data, double deltaTime) {} // 0x00000001822FA710-0x00000001822FA890
	// [XID] // 0x000000018986ADD0-0x000000018986ADF0
	private double CalculateCombatPulling(ref CameraShareData data, double deltaTime, double currManual) => default; // 0x00000001822FA920-0x00000001822FAAD0
	// [XID] // 0x0000000189872200-0x0000000189872220
	private void CalculateRatioElevation(ref CameraShareData data) {} // 0x00000001822FAD80-0x00000001822FAF50
	// [XID] // 0x0000000189879E90-0x0000000189879EB0
	private void ReduceZoomVelocity(double deltaTime, ref CameraShareData data) {} // 0x00000001822FA5C0-0x00000001822FA710
	// [XID] // 0x0000000189880F80-0x0000000189880FA0
	private void LerpBackToLastModuleRatio(ref CameraShareData data) {} // 0x00000001822F9B30-0x00000001822F9D40
	// [XID] // 0x0000000189888560-0x0000000189888580
	private double SingleLinearLerp(double src, double tar, double lerpRatio, double dt) => default; // 0x00000001822FAC50-0x00000001822FAD80
	// [XID] // 0x000000018988F980-0x000000018988F9A0
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001822F96B0-0x00000001822F9890
	// [XID] // 0x0000000189896E80-0x0000000189896EA0
	public override void Flush(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001822FAAD0-0x00000001822FABE0
}

