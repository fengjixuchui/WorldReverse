/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using FullInspector;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoGachaScene : MonoBehaviour // TypeDefIndex: 30785
	{
		// Fields
		// [Header] // 0x000000018981CC00-0x000000018981CC30
		public bool enableCutscene; // 0x18
		public string cutsceneOnePath; // 0x20
		public string cutsceneTenPath; // 0x28
		public Vector3 cutsceneOffset; // 0x30
		// [Header] // 0x00000001898258A0-0x00000001898258F0
		[SerializeField] // 0x00000001898258A0-0x00000001898258F0
		private GameObject _skybox; // 0x40
		// [Header] // 0x0000000189831690-0x00000001898316E0
		[SerializeField] // 0x0000000189831690-0x00000001898316E0
		private float _starGazingOffset; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _starEffectTrans; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _starEffectPrefab; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _effectFastSpeed; // 0x60
		// [Header] // 0x0000000189853290-0x00000001898532D0
		[SerializeField] // 0x0000000189853290-0x00000001898532D0
		private float _moveOneOffset; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _showGroupOffset; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _moveEffectDuration; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _moveNextDuration; // 0x70
		// [Header] // 0x0000000189875040-0x0000000189875080
		[SerializeField] // 0x0000000189875040-0x0000000189875080
		private GameObject _cameraMoveEffect; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _cutsceneCameraEffect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _cutsceneEffectDelayDuration; // 0x88
		// [Header] // 0x000000018988E040-0x000000018988E090
		[SerializeField] // 0x000000018988E040-0x000000018988E090
		private GameObject _avatarCameraPrefab; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarCameraTrans; // 0x98
		// [Header] // 0x00000001898A1370-0x00000001898A13B0
		[SerializeField] // 0x00000001898A1370-0x00000001898A13B0
		private Transform _modelGroupTrans; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _weaponViewTran; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarViewTran; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _groundPlaneTran; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemViewSceneTran; // 0xC0
		// [Header] // 0x00000001898CB4A0-0x00000001898CB4E0
		[SerializeField] // 0x00000001898CB4A0-0x00000001898CB4E0
		private CinemachineVirtualCamera _unUseCamera; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _cutInCamera; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _gachaPoolCamera; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _gazingCamera; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _viewCamera; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _afterGazingCamera; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera _onetimeCamera; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineVirtualCamera[] _10timesCamera; // 0x100
		// [Header] // 0x000000018990C4E0-0x000000018990C520
		[SerializeField] // 0x000000018990C4E0-0x000000018990C520
		private AnimationCurve _fovCurve; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fovDuration; // 0x110
		// [Header] // 0x000000018991FC80-0x000000018991FCC0
		[SerializeField] // 0x000000018991FC80-0x000000018991FCC0
		private string characterSettingPath; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CharacterViewStyle.Style _curCharacterStyle; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CinemachineBlenderSettings _normalBlender; // 0x1D8
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private State _sceneState; // 0x1E0
		private PostProcessLayer _postProcessLayer; // 0x1F0
		private GameObject _skyboxObj; // 0x1F8
		private GameObject _starEffect; // 0x200
		private UnityEngine.ShadowQuality _originalShadowQuality; // 0x208
		private GameObject _cameraMoveEffectObj; // 0x210
		private GameObject _cutsceneCameraEffectObj; // 0x218
		private Action _gazingCallBack; // 0x220
		private bool _startGazing; // 0x228
		private float _curDuration; // 0x22C
		private CinemachineBrain _cineCameraBrain; // 0x230
		private MonoGachaGazing _monoGazing; // 0x238
		private BaseEntity _curEntity; // 0x240
		private float _originalFOV; // 0x248
		private bool _enableCinemachine; // 0x24C
		private bool _startFovChange; // 0x24D
		private float _changeFovTime; // 0x250
		private Coroutine _beforeCutscene; // 0x258
		private bool needShowEntity; // 0x260
		// [Header] // 0x000000018994C7D0-0x000000018994C800
		private float _cutInNowTime; // 0x264
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _cutInMaxTime; // 0x268
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _skyBoxCutInTime; // 0x26C
		private float _sceneReadyAddHeight; // 0x270
		private bool _enterCutIn; // 0x274
		private bool _hasSetSkyBox; // 0x275
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _skyBoxStartScale; // 0x278
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _skyBoxEndScale; // 0x284
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _skyBoxAlphaLerpCurve; // 0x290
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _skyBoxScaleLerpCurve; // 0x298
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color bgColor; // 0x2A0
		private const float AVATAR_CAMERA_FOV = 45f; // Metadata: 0x00B11576
		private bool _hasClosedFog; // 0x2B0
		private bool _originalFogEnable; // 0x2B1
		private BodyCameraStyle.Style _curBodyCameraStyle; // 0x2B4
		private Renderer _skyboxRenderer; // 0x3C0
		private Renderer[] _cloudRenderers; // 0x3C8
		private MaterialPropertyBlock _mpb; // 0x3D0
		private static int _skyboxLightColorId; // 0x00
		private static int _skyboxDarkColorId; // 0x04
		private static int _skyboxHDRColorId; // 0x08
		private static int _skyboxOpacity; // 0x0C
		private static int _cloudOpacity; // 0x10
		private static int _skyBoxZtestMode; // 0x14
		private static int _skyboxMaterial02Color01; // 0x18
		private static int _skyboxMaterial02Color02; // 0x1C
		private static int _avatarColorId; // 0x20
		private static int _avatarCenterId; // 0x24
		private static int _effectPropagate; // 0x28
		private static int _ZtestMode_Disable; // 0x2C
		private static int _ZtestMode_LessEqual; // 0x30
		private Color _curLightColor; // 0x3D8
		private Color _curDarkColor; // 0x3E8
		private Color _curThirdColor; // 0x3F8
		private Color _curMaterial02Color01; // 0x408
		private Color _curMaterial02Color02; // 0x418
	
		// Properties
		public Camera sceneCamera { /* [XID] */ /* 0x00000001899998F0-0x0000000189999930 */ get; /* [XID] */ /* 0x00000001899A4140-0x00000001899A4180 */ private set; } // 0x000000018406CF50-0x000000018406CFB0 0x0000000184067380-0x00000001840673F0
		public float moveEffectDuration { /* [XID] */ /* 0x00000001899B5E60-0x00000001899B5E80 */ get => default; } // 0x000000018406CC90-0x000000018406CD40 
		public float moveNextDuration { /* [XID] */ /* 0x00000001899BDB80-0x00000001899BDBA0 */ get => default; } // 0x000000018406CD40-0x000000018406CDF0 
		public float moveOneOffset { /* [XID] */ /* 0x00000001899C52C0-0x00000001899C52E0 */ get => default; } // 0x000000018406CDF0-0x000000018406CEA0 
		public float showGroupOffset { /* [XID] */ /* 0x00000001899CC970-0x00000001899CC990 */ get => default; } // 0x000000018406D060-0x000000018406D110 
		public Transform modelGroupTrans { /* [XID] */ /* 0x00000001899D4010-0x00000001899D4030 */ get => default; } // 0x000000018406CBE0-0x000000018406CC90 
		public CinemachineVirtualCamera onetimeCamera { /* [XID] */ /* 0x00000001899DB580-0x00000001899DB5A0 */ get => default; } // 0x000000018406CEA0-0x000000018406CF50 
		public CinemachineVirtualCamera[] sceneViewCamera10Times { /* [XID] */ /* 0x00000001899E2C60-0x00000001899E2C80 */ get => default; } // 0x000000018406CFB0-0x000000018406D060 
		public CinemachineVirtualCamera gachaPoolCamera { /* [XID] */ /* 0x00000001899EA390-0x00000001899EA3B0 */ get => default; } // 0x000000018406CA80-0x000000018406CB30 
		public CinemachineVirtualCamera gazingCamera { /* [XID] */ /* 0x00000001899F1D60-0x00000001899F1D80 */ get => default; } // 0x000000018406CB30-0x000000018406CBE0 
		public CinemachineVirtualCamera viewCamera { /* [XID] */ /* 0x00000001899F95A0-0x00000001899F95C0 */ get => default; } // 0x000000018406D110-0x000000018406D1C0 
		public CharacterViewStyle.Style curCharacterStyle { /* [XID] */ /* 0x0000000189A008C0-0x0000000189A008E0 */ get => default; } // 0x000000018406C830-0x000000018406CA80 
		public Transform weaponViewTran { /* [XID] */ /* 0x0000000189A081A0-0x0000000189A081C0 */ get => default; } // 0x000000018406D1C0-0x000000018406D270 
		public Transform avatarViewTran { /* [XID] */ /* 0x0000000189A0F5B0-0x0000000189A0F5D0 */ get => default; } // 0x000000018406C780-0x000000018406C830 
	
		// Nested types
		private enum State // TypeDefIndex: 30786
		{
			Hide = 0,
			CutIn = 1,
			Ready = 2
		}
	
		// Constructors
		public MonoGachaScene() {} // 0x000000018406C4E0-0x000000018406C780
		static MonoGachaScene() {} // 0x000000018406C2F0-0x000000018406C4E0
	
		// Methods
		// [XID] // 0x000000018998A310-0x000000018998A330
		public bool IsValid() => default; // 0x0000000184068AB0-0x0000000184068B60
		// [XID] // 0x0000000189991BE0-0x0000000189991C00
		public bool IsShow() => default; // 0x0000000184068A00-0x0000000184068AB0
		// [XID] // 0x00000001899AEAE0-0x00000001899AEB00
		public void InitGachaContext(InLevelGachaGroupContext gachaContext) {} // 0x0000000184068880-0x0000000184068930
		// [XID] // 0x0000000189A16C40-0x0000000189A16C60
		public void Awake() {} // 0x0000000184066BE0-0x0000000184067190
		// [XID] // 0x0000000189A1E2A0-0x0000000189A1E2C0
		public void ResetCamera() {} // 0x000000018406A7D0-0x000000018406AA40
		// [XID] // 0x0000000189A259A0-0x0000000189A259C0
		private void ResetEffects() {} // 0x0000000184069D50-0x0000000184069E10
		// [XID] // 0x0000000189A2CDC0-0x0000000189A2CDE0
		public void LateUpdate() {} // 0x0000000184069C90-0x0000000184069D50
		// [XID] // 0x0000000189A34790-0x0000000189A347B0
		private void UpdateState() {} // 0x00000001840679C0-0x0000000184067A70
		// [XID] // 0x0000000189A3BBB0-0x0000000189A3BBD0
		private void UpdateCinemachine() {} // 0x0000000184069140-0x0000000184069240
		// [XID] // 0x0000000189A43840-0x0000000189A43860
		private void UpdateGazing() {} // 0x0000000184068200-0x0000000184068370
		// [XID] // 0x0000000189A4AC90-0x0000000189A4ACB0
		private void UpdateFov() {} // 0x0000000184068050-0x0000000184068200
		// [XID] // 0x0000000189A52370-0x0000000189A52390
		private void StartFovChange(CinemachineVirtualCamera camera) {} // 0x000000018406A710-0x000000018406A7D0
		// [XID] // 0x0000000189A59CA0-0x0000000189A59CC0
		public void InitGazing(Action callback) {} // 0x0000000184068930-0x0000000184068A00
		// [XID] // 0x0000000189A61460-0x0000000189A61480
		public void ShowGazingEffect(IList<GachaItem> list) {} // 0x000000018406B130-0x000000018406B220
		// [XID] // 0x0000000189A69390-0x0000000189A693B0
		public void SpeedUpGazing() {} // 0x000000018406C230-0x000000018406C2F0
		// [XID] // 0x0000000189A70720-0x0000000189A70740
		public void ShowPoolCamera() {} // 0x000000018406B2D0-0x000000018406B3C0
		// [XID] // 0x0000000189A77FF0-0x0000000189A78010
		public void ShowGazingCamera() {} // 0x000000018406ADF0-0x000000018406B130
		// [XID] // 0x0000000189A7F5C0-0x0000000189A7F5E0
		public void HideGazing() {} // 0x0000000184068550-0x0000000184068640
		// [XID] // 0x0000000189A87300-0x0000000189A87320
		public void BeforeCutscene() {} // 0x0000000184067190-0x0000000184067380
		// [XID] // 0x0000000189A8EB40-0x0000000189A8EB60
		public void AfterCutscene() {} // 0x0000000184066A80-0x0000000184066BE0
		// [XID] // 0x0000000189A96190-0x0000000189A961B0
		public void ShowViewCamera() {} // 0x000000018406B480-0x000000018406B580
		// [XID] // 0x0000000189A9D6A0-0x0000000189A9D6C0
		public void ShowTenSettlement() {} // 0x000000018406B3C0-0x000000018406B480
		// [XID] // 0x0000000189AA4F00-0x0000000189AA4F20
		public void ShowItemEffect() {} // 0x000000018406B220-0x000000018406B2D0
		// [XID] // 0x0000000189AAC750-0x0000000189AAC770
		private void CheckShowItemEffect() {} // 0x0000000184068370-0x0000000184068490
		// [XID] // 0x0000000189AB3F70-0x0000000189AB3F90
		public void SetCurEntity(BaseEntity entity) {} // 0x000000018406AD00-0x000000018406ADF0
		// [XID] // 0x0000000189ABBCD0-0x0000000189ABBCF0
		public void RotateWeaponTrans(bool rotate) {} // 0x000000018406AA40-0x000000018406AC10
		// [XID] // 0x0000000189AC3440-0x0000000189AC3460
		private void SetDefaultSkyboxColor() {} // 0x0000000184067B30-0x0000000184067E60
		// [XID] // 0x0000000189ACAB50-0x0000000189ACAB70
		private void UpdateSkyboxAlpha() {} // 0x0000000184068B60-0x0000000184069080
		// [XID] // 0x0000000189AD2590-0x0000000189AD25B0
		private void RefreshStyleSetting(AvatarDataItem avatarData) {} // 0x0000000184069ED0-0x000000018406A150
		// [XID] // 0x0000000189ADA070-0x0000000189ADA090
		private Transform GetUnuseLookAtObject() => default; // 0x0000000184069E10-0x0000000184069ED0
		// [XID] // 0x0000000189AE1970-0x0000000189AE1990
		private Transform GetCurrentLookAtObject() => default; // 0x0000000184068490-0x0000000184068550
		// [XID] // 0x0000000189AE9120-0x0000000189AE9140
		private Transform GetCurrentMoveCamera() => default; // 0x0000000184067A70-0x0000000184067B30
		// [XID] // 0x0000000189AF0EF0-0x0000000189AF0F10
		private void MoveVirtualCameraByLocalPos(Vector3 tarLocalPos, Vector3 lookAtLocalPos, float? fov = default, bool canMove = false /* Metadata: 0x00B11575 */) {} // 0x0000000184069B80-0x0000000184069C90
		// [XID] // 0x0000000189AF8370-0x0000000189AF8390
		private void CheckCameraSceneType() {} // 0x0000000184067E60-0x0000000184068050
		// [XID] // 0x0000000189AFFA40-0x0000000189AFFA60
		public void SetActive(bool enable) {} // 0x000000018406AC10-0x000000018406AD00
		// [XID] // 0x0000000189B06FF0-0x0000000189B07010
		public void OnEnable() {} // 0x000000018406A390-0x000000018406A710
		// [XID] // 0x0000000189B0E830-0x0000000189B0E850
		public void OnDisable() {} // 0x000000018406A150-0x000000018406A390
		// [XID] // 0x0000000189B15C20-0x0000000189B15C40
		public void Hide() {} // 0x0000000184068640-0x00000001840687B0
		// [XID] // 0x0000000189B1D330-0x0000000189B1D350
		public void Show() {} // 0x000000018406B580-0x000000018406C230
		// [XID] // 0x0000000189B24BB0-0x0000000189B24BD0
		private void UpdateCutIn() {} // 0x0000000184069240-0x0000000184069B80
		// [XID] // 0x0000000189B2C040-0x0000000189B2C060
		private void CloseFog() {} // 0x0000000184069080-0x0000000184069140
		// [XID] // 0x0000000189B335F0-0x0000000189B33610
		private void UpdateUIScenePos() {} // 0x00000001840673F0-0x00000001840679C0
	}
}
