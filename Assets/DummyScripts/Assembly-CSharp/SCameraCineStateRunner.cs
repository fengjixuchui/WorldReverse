/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using miHoYoCamera;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraCineStateRunner : SCameraStateBaseRunner<SCameraCineState> // TypeDefIndex: 32058
{
	// Fields
	private List<SCameraShotTask> _stack; // 0x658
	private List<SCameraShotTask> _shotBuffer; // 0x660
	private CinemachineBrain _brain; // 0x668
	private PipelineCameraModuleConfig _rotateConfig; // 0x670
	private SCameraShotTask _topShot; // 0x678
	private SCameraShotTask _fromShot; // 0x680
	private SCameraShotTask _toShot; // 0x688
	private CameraStateBlenderConfig.BlendType _blendType; // 0x690
	private EasingFunction.Ease _easeType; // 0x694
	private CameraStateBlenderConfig.PoleType _poleType; // 0x698
	private EasingFunction.FunctionValue _lerpFunc; // 0x6A0
	private double _duration; // 0x6A8
	private double _blendTime; // 0x6B0
	private bool _isFinished; // 0x6B8
	private bool _needClear; // 0x6B9
	private bool _shotTickDirty; // 0x6BA
	private CameraStateBlenderConfig _blenderCfg; // 0x6C0
	private bool _isBlendingFrom; // 0x6C8
	private SCameraModuleInitialize _initialModule; // 0x6D0

	// Properties
	public CameraStateBlenderConfig BlenderCfg { /* [XID] */ /* 0x00000001898F8B20-0x00000001898F8B40 */ get => default; } // 0x0000000184523070-0x0000000184523190 
	public bool IsBlendingFrom { /* [XID] */ /* 0x00000001899004F0-0x0000000189900510 */ set {} } // 0x0000000184522DC0-0x0000000184522E70

	// Constructors
	public SCameraCineStateRunner() {} // 0x0000000184525060-0x00000001845251A0

	// Methods
	// [XID] // 0x0000000189907C30-0x0000000189907C50
	public void EnableSelfUpdate(bool value) {} // 0x0000000184524360-0x0000000184524460
	// [XID] // 0x000000018990F420-0x000000018990F440
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000184522BA0-0x0000000184522DC0
	// [XID] // 0x0000000189BC7D80-0x0000000189BC7DA0
	public void EnterCineShot(SCameraShotTask shot) {} // 0x00000001845237C0-0x0000000184523940
	// [XID] // 0x000000018991E5F0-0x000000018991E610
	public bool ClearCineShot() => default; // 0x00000001845233D0-0x0000000184523520
	// [XID] // 0x0000000189925DF0-0x0000000189925E10
	public override void ClearOnDisconnect() {} // 0x0000000184524770-0x0000000184524910
	// [XID] // 0x000000018992D380-0x000000018992D3A0
	private void CollectShotBuffer(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000184522020-0x0000000184522260
	// [XID] // 0x00000001899348B0-0x00000001899348D0
	private void AddShotToStack(SCameraShotTask shotTask) {} // 0x0000000184523250-0x00000001845233D0
	// [XID] // 0x000000018993C360-0x000000018993C380
	private void FinishCurrentImPersistent() {} // 0x0000000184521ED0-0x0000000184522020
	// [XID] // 0x00000001899439B0-0x00000001899439D0
	private void RefreshAvatarLookAt(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000184523D20-0x0000000184523E10
	// [XID] // 0x00000001895F29C0-0x00000001895F29E0
	private void SetBlenderParamByShot(SCameraShotTask shot, bool exit) {} // 0x0000000184523520-0x00000001845236A0
	// [XID] // 0x0000000189952890-0x00000001899528B0
	private void ClearBlenderParam() {} // 0x0000000184523E10-0x0000000184523EF0
	// [XID] // 0x0000000189959E70-0x0000000189959E90
	private void TickShot(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000184522400-0x0000000184522B20
	// [XID] // 0x0000000189961840-0x0000000189961860
	public void TickShotExternalForRescycle() {} // 0x0000000184523190-0x0000000184523250
	// [XID] // 0x0000000189832A00-0x0000000189832A20
	private void CheckStackFinishExceptTop() {} // 0x0000000184523F70-0x0000000184524100
	// [XID] // 0x00000001899709B0-0x00000001899709D0
	protected override void InitModules() {} // 0x0000000184524100-0x0000000184524260
	// [XID] // 0x0000000189978370-0x0000000189978390
	private void RefreshInitialModule() {} // 0x0000000184522E70-0x0000000184522F50
	// [XID] // 0x000000018997F480-0x000000018997F4A0
	public override void OnSpawn() {} // 0x0000000184521E20-0x0000000184521ED0
	// [XID] // 0x0000000189986E20-0x0000000189986E40
	protected override void StartInternal() {} // 0x0000000184524E20-0x0000000184524F70
	// [XID] // 0x000000018998E890-0x000000018998E8B0
	protected override void CollectPreInternal() {} // 0x0000000184522340-0x0000000184522400
	// [XID] // 0x0000000189996420-0x0000000189996440
	protected override void CollectInternal(float deltaTime) {} // 0x0000000184522260-0x0000000184522340
	// [XID] // 0x000000018999DF70-0x000000018999DF90
	private void CopyToLastFrame(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000184521C50-0x0000000184521E20
	// [XID] // 0x00000001899A59F0-0x00000001899A5A10
	protected override void TickInternal(float deltaTime) {} // 0x0000000184524F70-0x0000000184525060
	// [XID] // 0x00000001899AD050-0x00000001899AD070
	private void TickShotBlend(double deltaTime) {} // 0x0000000184524990-0x0000000184524B60
	// [XID] // 0x00000001899B4890-0x00000001899B48B0
	private void UpdateShareData(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000184524540-0x0000000184524710
	// [XID] // 0x00000001899BBF00-0x00000001899BBF20
	private void InnerLerp(double t) {} // 0x0000000184523940-0x0000000184523D20
	// [XID] // 0x00000001899C3A30-0x00000001899C3A50
	protected override void FlushInternal(float deltaTime) {} // 0x0000000184522FB0-0x0000000184523070
	// [XID] // 0x00000001899CAFF0-0x00000001899CB010
	protected override void PostFlushTopInternal() {} // 0x0000000184524CA0-0x0000000184524E20
	// [XID] // 0x00000001899D2580-0x00000001899D25A0
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000184524260-0x0000000184524360
	// [XID] // 0x00000001899D9C60-0x00000001899D9C80
	protected override void HandleClearFilter(ref SCameraCmd cmd) {} // 0x0000000184523700-0x00000001845237C0
}

