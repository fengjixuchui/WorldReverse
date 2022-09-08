/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CameraEntity : BaseEntity, IAutoAllocRecycle // TypeDefIndex: 19873
{
	// Fields
	public static bool CameraMoveInited; // 0x00
	private VCStackCamera _vcStackCamera; // 0x4C8
	private VCCameraCharacterAmbientSensors _vcSensors; // 0x4D0

	// Properties
	public bool isMainCamera { /* [XID] */ /* 0x0000000189B69EF0-0x0000000189B69F30 */ get; /* [XID] */ /* 0x0000000189B74200-0x0000000189B74240 */ set; } // 0x00000001819337C0-0x0000000181933820 0x0000000181936920-0x0000000181936990
	public Camera camera { /* [XID] */ /* 0x0000000189B7E680-0x0000000189B7E6C0 */ get; /* [XID] */ /* 0x0000000189B88F50-0x0000000189B88F90 */ set; } // 0x00000001819368C0-0x0000000181936920 0x0000000181933EF0-0x0000000181933F60
	public VCStackCamera vcStackCamera { /* [XID] */ /* 0x0000000189BB0C50-0x0000000189BB0C70 */ get => default; } // 0x0000000181934640-0x0000000181934710 
	public VCCameraCharacterAmbientSensors vcSensors { /* [XID] */ /* 0x0000000189BB7E40-0x0000000189BB7E60 */ get => default; } // 0x0000000181933B50-0x0000000181933C20 

	// Constructors
	public CameraEntity(bool isMainCamera) {} // 0x0000000181937B00-0x0000000181937BB0
	public CameraEntity() {} // 0x0000000181937BB0-0x0000000181937DC0
	static CameraEntity() {} // 0x0000000181937AA0-0x0000000181937B00

	// Methods
	// [XID] // 0x0000000189B933B0-0x0000000189B933D0
	public override bool IsLevelReadyToExecuteTickFunctions() => default; // 0x0000000181935F10-0x0000000181935FB0
	// [XID] // 0x0000000189B9A8A0-0x0000000189B9A8C0
	public override bool ShouldTickComponents() => default; // 0x0000000181936660-0x0000000181936710
	// [XID] // 0x0000000189BA2030-0x0000000189BA2050
	public override bool ShouldLateTickComponents() => default; // 0x0000000181935320-0x00000001819353D0
	// [XID] // 0x0000000189BA9480-0x0000000189BA94A0
	public void CallConstructor(bool isMainCamera) {} // 0x0000000181935FB0-0x00000001819360A0
	// [XID] // 0x0000000189BBF5B0-0x0000000189BBF5D0
	public void OnLevelLoaded() {} // 0x00000001819378A0-0x0000000181937A00
	// [XID] // 0x0000000189BC7190-0x0000000189BC71B0
	public void SetFollowTarget(BaseEntity entity) {} // 0x0000000181934B50-0x0000000181934C60
	// [XID] // 0x0000000189BCEE80-0x0000000189BCEEA0
	public void TryRefreshHeroEntity() {} // 0x00000001819354A0-0x0000000181935590
	// [IDTag] // 0x0000000189BD6260-0x0000000189BD62A0
	// [XID] // 0x0000000189BD6260-0x0000000189BD62A0
	public void ResetCameraToAvatarBackward(Vector3 pos) {} // 0x0000000181936AC0-0x0000000181936BD0
	// [XID] // 0x00000001895E5F70-0x00000001895E5F90
	public void OnVisualEntityLoaded(BaseEntity entity) {} // 0x0000000181936280-0x00000001819365A0
	// [XID] // 0x00000001895ED8F0-0x00000001895ED910
	protected override void InitAuthority() {} // 0x0000000181935000-0x00000001819350B0
	// [XID] // 0x00000001895F5090-0x00000001895F50B0
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x0000000181933D10-0x0000000181933EF0
	// [XID] // 0x00000001895FC670-0x00000001895FC690
	public override void OnClientConnect() {} // 0x00000001819358A0-0x0000000181935950
	// [XID] // 0x0000000189603FF0-0x0000000189604010
	public override void OnClientDisconnect() {} // 0x0000000181934C60-0x0000000181934D10
	// [XID] // 0x000000018960B970-0x000000018960B990
	public static Vector3 GetCameraStableForward() => default; // 0x0000000181934D10-0x0000000181934E70
	// [XID] // 0x0000000189612F00-0x0000000189612F20
	public static void TryRotateCamera(Vector3 deltaDrag) {} // 0x0000000181936BD0-0x0000000181936D30
	// [XID] // 0x000000018961A680-0x000000018961A6A0
	public static void TryRotateCameraOnFocus(Vector3 deltaDrag) {} // 0x0000000181934E70-0x0000000181935000
	// [XID] // 0x0000000189621BA0-0x0000000189621BC0
	public static void TryZoomCamera(float zoomDelta) {} // 0x0000000181937770-0x00000001819378A0
	// [XID] // 0x0000000189629530-0x0000000189629550
	public static void TryMoveCamera(Vector2 move) {} // 0x0000000181935590-0x00000001819356C0
	// [XID] // 0x0000000189630E20-0x0000000189630E40
	public static void TrySetRefAnchorPosition(Vector3 pos) {} // 0x0000000181933FC0-0x0000000181934110
	// [XID] // 0x0000000189638940-0x0000000189638960
	public static void TrySetCameraPosition(Vector3 pos) {} // 0x0000000181933820-0x0000000181933970
	// [XID] // 0x000000018963FCF0-0x000000018963FD10
	public static void TrySetClampRotatePitch(Vector2 clampVal) {} // 0x0000000181935DE0-0x0000000181935F10
	// [XID] // 0x0000000189647550-0x0000000189647570
	public static void TrySetClampZoomScale(Vector2 clampVal) {} // 0x00000001819341F0-0x0000000181934320
	// [XID] // 0x000000018964EC00-0x000000018964EC20
	public static void TryMoveRotateVertically(double anchorPosX, double anchorPosZ, double sphericalY) {} // 0x0000000181934390-0x0000000181934500
	// [IDTag] // 0x0000000189655A60-0x0000000189655AA0
	// [XID] // 0x0000000189655A60-0x0000000189655AA0
	public static void ResetCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AFCF95 */) {} // 0x0000000181936990-0x0000000181936AC0
	// [XID] // 0x0000000189660AB0-0x0000000189660AD0
	public static void LerpCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AFCF99 */, float lerp = 1f /* Metadata: 0x00AFCF9D */) {} // 0x0000000181936710-0x0000000181936860
	// [XID] // 0x00000001896684C0-0x00000001896684E0
	public static void InitCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AFCFA1 */) {} // 0x00000001819360A0-0x00000001819361D0
	// [XID] // 0x000000018966FF70-0x000000018966FF90
	public static void EnableProtectDither(bool value) {} // 0x0000000181933C20-0x0000000181933D10
	// [XID] // 0x0000000189677880-0x00000001896778A0
	public static void ResetCameraPostParam() {} // 0x0000000181937320-0x0000000181937400
	// [XID] // 0x000000018967ED80-0x000000018967EDA0
	public static void ResetCameraParam() {} // 0x00000001819371E0-0x0000000181937320
	// [XID] // 0x00000001896866B0-0x00000001896866D0
	public static void ResetCameraBrain() {} // 0x0000000181934560-0x0000000181934640
	// [XID] // 0x000000018968E490-0x000000018968E4B0
	public static void ResetCameraFov() {} // 0x0000000181934110-0x00000001819341F0
	// [XID] // 0x0000000189695DB0-0x0000000189695DD0
	public static void ResetCameraToNormal() {} // 0x00000001819350B0-0x0000000181935190
	// [XID] // 0x000000018969D520-0x000000018969D540
	public static void UpdateSpCam() {} // 0x00000001819356C0-0x00000001819357A0
	// [XID] // 0x00000001896A4560-0x00000001896A4580
	public static void EnterKeepSpCamera() {} // 0x0000000181935B20-0x0000000181935C00
	// [XID] // 0x00000001896ABD50-0x00000001896ABD70
	public static void ClearCameraFilter() {} // 0x00000001819349A0-0x0000000181934A80
	// [XID] // 0x00000001896B2F10-0x00000001896B2F30
	public static void UpdateAuthority(bool value) {} // 0x00000001819347E0-0x00000001819348D0
	// [XID] // 0x00000001896BA730-0x00000001896BA750
	internal Vector3 GetCameraStableForwardInternal() => default; // 0x00000001819357A0-0x00000001819358A0
	// [XID] // 0x00000001896C1800-0x00000001896C1820
	internal void TryRotateCameraInternal(Vector2 deltaDrag) {} // 0x00000001819374C0-0x0000000181937590
	// [XID] // 0x00000001896C8F40-0x00000001896C8F60
	internal void TryRotateCameraOnFocusInternal(Vector2 deltaDrag) {} // 0x00000001819348D0-0x00000001819349A0
	// [XID] // 0x00000001896D0900-0x00000001896D0920
	internal void TryZoomCameraInternal(float zoomDelta) {} // 0x0000000181934710-0x00000001819347E0
	// [XID] // 0x00000001896D7E30-0x00000001896D7E50
	internal void TryMoveCameraInternal(Vector2 moveDelta) {} // 0x0000000181937110-0x00000001819371E0
	// [XID] // 0x00000001896DF700-0x00000001896DF720
	internal void TrySetRefAnchorPositionInternal(Vector3 pos) {} // 0x0000000181935950-0x0000000181935A40
	// [XID] // 0x00000001896E6AA0-0x00000001896E6AC0
	internal void TrySetCameraPositionInternal(Vector3 pos) {} // 0x0000000181936DF0-0x0000000181936EE0
	// [XID] // 0x00000001896EE050-0x00000001896EE070
	internal void TrySetClampRotatePitchInternal(Vector2 clampVal) {} // 0x00000001819353D0-0x00000001819354A0
	// [XID] // 0x00000001896F5850-0x00000001896F5870
	internal void TrySetClampZoomScaleInternal(Vector2 clampVal) {} // 0x0000000181935190-0x0000000181935260
	// [XID] // 0x00000001896FD010-0x00000001896FD030
	internal void TryMoveRotateVerticallyInternal(double anchorPosX, double anchorPosZ, double sphericalY) {} // 0x0000000181937660-0x0000000181937770
	// [XID] // 0x00000001897044A0-0x00000001897044C0
	internal void ResetCameraToAvatarBackwardInternal(float poleOffsetDeg = 0f /* Metadata: 0x00AFCFA5 */) {} // 0x0000000181936F80-0x0000000181937050
	// [XID] // 0x000000018970BC90-0x000000018970BCB0
	internal void LerpCameraToAvatarBackwardInternal(float poleOffsetDeg = 0f /* Metadata: 0x00AFCFA9 */, float lerp = 1f /* Metadata: 0x00AFCFAD */) {} // 0x00000001819336D0-0x00000001819337C0
	// [XID] // 0x00000001897135E0-0x0000000189713600
	internal void InitCameraToAvatarBackwardInternal(float poleOffsetDeg = 0f /* Metadata: 0x00AFCFB1 */) {} // 0x0000000181937590-0x0000000181937660
	// [XID] // 0x000000018971ADE0-0x000000018971AE00
	internal void EnableProtectDitherInternal(bool value) {} // 0x00000001819361D0-0x0000000181936280
	// [XID] // 0x0000000189722120-0x0000000189722140
	internal void ResetCameraPostParamInternal() {} // 0x0000000181937050-0x0000000181937110
	// [XID] // 0x0000000189729830-0x0000000189729850
	internal void ResetCameraBrainInternal() {} // 0x0000000181937400-0x00000001819374C0
	// [XID] // 0x0000000189731020-0x0000000189731040
	internal void ResetCameraFovInternal() {} // 0x0000000181936EE0-0x0000000181936F80
	// [XID] // 0x0000000189A80B80-0x0000000189A80BA0
	internal void ResetCameraToNormalInternal() {} // 0x0000000181935D20-0x0000000181935DE0
	// [XID] // 0x0000000189740670-0x0000000189740690
	internal void UpdateSpCamInternal() {} // 0x0000000181936D30-0x0000000181936DF0
	// [XID] // 0x00000001897479F0-0x0000000189747A10
	internal void EnterKeepSpCameraInternal() {} // 0x00000001819365A0-0x0000000181936660
	// [XID] // 0x000000018974F1B0-0x000000018974F1D0
	internal void ClearCameraFilterInternal() {} // 0x0000000181935C00-0x0000000181935CC0
	// [XID] // 0x0000000189756880-0x00000001897568A0
	internal void UpdateAuthorityInternal(bool value) {} // 0x0000000181934A80-0x0000000181934B50
	[BlackList] // 0x000000018975DCB0-0x000000018975DCF0
	// [XID] // 0x000000018975DCB0-0x000000018975DCF0
	public override void AutoAllocTypeFields() {} // 0x0000000181933970-0x0000000181933A10
	[BlackList] // 0x0000000189768500-0x0000000189768540
	// [XID] // 0x0000000189768500-0x0000000189768540
	public override void AutoRecycleTypeFields() {} // 0x0000000181933A10-0x0000000181933B50
	[BlackList] // 0x0000000189772BC0-0x0000000189772C00
	// [XID] // 0x0000000189772BC0-0x0000000189772C00
	public override void ReturnToObjectPool() {} // 0x0000000181937A00-0x0000000181937AA0
}

