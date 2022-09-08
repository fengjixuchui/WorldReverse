/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSceneUISetup : MonoBehaviour // TypeDefIndex: 30894
	{
		// Fields
		// [Header] // 0x0000000189997EF0-0x0000000189997F30
		[SerializeField] // 0x0000000189997EF0-0x0000000189997F30
		private float _appearanceShowDelay; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _appearanceAvatarRotationSpeed; // 0x1C
		private Vector3 _avatarDefaultEulerAngles; // 0x20
		private const string EFF_UI_FASHION_SWITCH_PATH = "ART/Effect/UI/Character/Eff_UI_Fashion_Switch"; // Metadata: 0x00B116C6
		private GameObject _eff_ui_fashion_switch; // 0x30
		// [Header] // 0x00000001899ABB30-0x00000001899ABB80
		[SerializeField] // 0x00000001899ABB30-0x00000001899ABB80
		private Vector3 _bpWeaponRootOffset; // 0x38
		// [Header] // 0x00000001899B7660-0x00000001899B76A0
		[SerializeField] // 0x00000001899B7660-0x00000001899B76A0
		private Transform[] _virtualCameraArray; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _lookAtObjectArray; // 0x50
		private Stack<VirtualCameraMoveInfo> _lastCamMoveStack; // 0x58
		// [Header] // 0x00000001899C9850-0x00000001899C98A0
		[SerializeField] // 0x00000001899C9850-0x00000001899C98A0
		private List<CodexSlotMaterialConfig> _codexSlotMaterialConfigs; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _codexContainer; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _codexSlotRoot; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _codexEquipRoot; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _codexRelicRoot; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _codexCreatureRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexRotateMaxVelocity; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexRotateRatio; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexRotateReduceRatio; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexRotateVelocityRatio; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexSlotMinSize; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexSlotMaxSize; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexSlotScale; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexSubPageClickDelay; // 0xAC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexSlotRootPos; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexBookPos; // 0xBC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexBookRot; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraDefaultPos; // 0xD4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraDefaultLookAt; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraHomePagePos; // 0xEC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraSubPagePos; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreature16to9Pos; // 0x104
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreature4to3Pos; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreatureLookAt; // 0x11C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreatureDetailsPos; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreatureDetailsLookAt; // 0x134
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreatureAnimalDetailsPos; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _codexCameraCreatureAnimalDetailsLookAt; // 0x14C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _codexSlotAlphaLerpCurve; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _codexSlotLabelAlphaLerpCurve; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector4 _centerColor1; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector4 _centerColor2; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector4 _edgeColor1; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector4 _edgeColor2; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _codexSlotColorLerpCurve; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexGroundY; // 0x1B0
		private float _codexSelectCurrTime; // 0x1B4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexSelectLerpTime; // 0x1B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _codexEnviroSystemProfilePath; // 0x1C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexWeaponEffectMaxTime; // 0x1C8
		private float _codexWeaponEffectCurrTime; // 0x1CC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _startCodexWeaponEffectColor; // 0x1D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _endCodexWeaponEffectColor; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _codexWeaponEffectLerpCurve; // 0x1F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexCreatureMonsterRootY; // 0x1F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexCreatureAnimalRootY; // 0x1FC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexCreatureMaxAlignTime; // 0x200
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _codexCreatureMinAlignTime; // 0x204
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _codexCreatureAlignCurve; // 0x208
		private float _codexCreatureAlignCurrTime; // 0x210
		private float _codexCreatureAlignLerpTime; // 0x214
		private CodexShowType _codexShowType; // 0x218
		private MonoCodexModel _codexModel; // 0x220
		private GameObject _codexSkybox; // 0x228
		private GameObject _codexEffect; // 0x230
		private List<MonoCodexSlot> _codexSlotList; // 0x238
		private List<float> _angleList; // 0x240
		private uint _codexModelHandle; // 0x248
		private const string CODEX_MODEL_PREFAB_PATH = "ART/Others/SystemRes/Sr_Codex_CodexBook/Sr_Codex_CodexBook"; // Metadata: 0x00B116F7
		private uint _codexSkyboxHandle; // 0x24C
		private const string CODEX_SKYBOX_PREFAB_PATH = "ART/Effect/UI/UI/Eff_Codex_Skybox"; // Metadata: 0x00B11735
		private const int CODEX_SLOT_NUM = 7; // Metadata: 0x00B1175A
		private const int CODEX_SLOT_VISIBLE_NUM = 5; // Metadata: 0x00B1175E
		private const int ANGLE_SEGMENTATION_NUM = 24; // Metadata: 0x00B11762
		private float _codexSlotRadius; // 0x250
		private uint _codexSlotHandle; // 0x254
		private const string CODEX_SLOT_PREFAB_PATH = "ART/UI/Menus/Widget/CodexPage/CodexSlot"; // Metadata: 0x00B11766
		private const string CODEX_SLOT_ICON_PATH = "ART/Effect/Texture/"; // Metadata: 0x00B11791
		private Dictionary<string, Texture2D> _codexImgDic; // 0x258
		private uint _codexSlotIconParticleHandle; // 0x260
		private string CODEX_SLOT_ICON_PARTICLE_PATH; // 0x268
		private Color _codexSlotColor; // 0x270
		private uint _codexEffectHandle; // 0x280
		private const string CODEX_EFFECT_PREFAB_PATH = "ART/Effect/UI/Character/Eff_UI_CodexBook_Galaxy"; // Metadata: 0x00B117A8
		private GadgetEntity _codexWeaponEntity; // 0x288
		private GameObject _codexWeaponEffect; // 0x290
		private uint _codexWeaponEffectHandle; // 0x298
		private const string CODEX_WEAPON_EFFECT_PREFAB_PATH = "ART/Effect/UI/Character/Eff_UI_Codex_Weapon_Switch"; // Metadata: 0x00B117DB
		private GameObject _codexReliquary; // 0x2A0
		private bool _useCodexEnviroSkyProfile; // 0x2A8
		private string _currEnviroSkyProfilePath; // 0x2B0
		private EnviroSky.UpdateType _currEnviroSkyUpdateType; // 0x2B8
		private GameObject _codexCreature; // 0x2C0
		private uint _codexCreatureHandle; // 0x2C8
		private AsyncJob _loadCreatureJob; // 0x2D0
		private const string CODEX_ANIMAL_PREFAB_ROOT_PATH = "ART/System/Codex/Animal/"; // Metadata: 0x00B11811
		private const string CODEX_MONSTER_PREFAB_ROOT_PATH = "ART/System/Codex/Monster/"; // Metadata: 0x00B1182D
		private GameObject _codexMonsterEffect; // 0x2E0
		private uint _codexMonsterEffectHandle; // 0x2E8
		private const string CODEX_MONSTER_EFFECT_PREFAB_PATH = "ART/Effect/UI/Character/Eff_UI_Codex_Monster_Switch"; // Metadata: 0x00B1184A
		private bool _onDragCodex; // 0x2EC
		private float _codexClockwise; // 0x2F0
		private bool _onEnterDragCodex; // 0x2F4
		private float _codexRotateVelocity; // 0x2F8
		private int _currCodexMidIndex; // 0x2FC
		private bool _shouldAutoRotate; // 0x300
		private float _startCodexAngleValue; // 0x304
		private float _targetCodexAngleValue; // 0x308
		private float _currMoveTime; // 0x30C
		private float _maxMoveTime; // 0x310
		private float _startCodexAngleValueH2S; // 0x314
		private float _targetCodexAngleValueH2S; // 0x318
		private float _startCodexCreatureAngle; // 0x31C
		private float _targetCodexCreatureAngle; // 0x320
		private bool _codexCreatureAlign; // 0x324
		private Dictionary<int, BaseUIScenePlugin> _pluginDic; // 0x328
		private UISceneSkyboxPlugin _skyboxPlugin; // 0x330
		private UISceneCameraPlugin _cameraPlugin; // 0x338
		// [Header] // 0x0000000189B2D6F0-0x0000000189B2D740
		[SerializeField] // 0x0000000189B2D6F0-0x0000000189B2D740
		private Vector3 _coopDefaultPos; // 0x340
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _coopDefaultLookAt; // 0x34C
		// [Range] // 0x0000000189B3F7A0-0x0000000189B3F7E0
		[SerializeField] // 0x0000000189B3F7A0-0x0000000189B3F7E0
		private float _coopCameraMoveRatio; // 0x358
		// [Range] // 0x0000000189B4A170-0x0000000189B4A1B0
		[SerializeField] // 0x0000000189B4A170-0x0000000189B4A1B0
		private float _coopSkyboxScaleRatio; // 0x35C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _coopBorderSize; // 0x360
		private Vector2 _coopParallax; // 0x368
		private Vector3 _coopLookAtDir; // 0x370
		private Vector2 _coopRealMovePos; // 0x37C
		private bool _isCoopCameraOutRange; // 0x384
		private Vector3? _defaultCoopSkyboxScale; // 0x388
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private string characterSettingPath; // 0x398
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarCameraTrans; // 0x3A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarCameraPrefab; // 0x3A8
		private Camera _avatarCamera; // 0x3B0
		private Transform _lightTransform; // 0x3B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarContainer; // 0x3C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _weaponContainer; // 0x3C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Renderer _skyboxRenderer; // 0x3D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _maxLerpTime; // 0x3D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minRotAngle; // 0x3DC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _ground; // 0x3E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Renderer _groundRenderer; // 0x3E8
		protected BaseEntity _manekinEntity; // 0x3F0
		private ShowType _type; // 0x3F8
		private ShowSubType _subType; // 0x3FC
		private MaterialPropertyBlock _mpb; // 0x400
		private static int _avatarColorId; // 0x00
		private static int _avatarCenterId; // 0x04
		private static int _effectPropagate; // 0x08
		private static int _groundAlphaId; // 0x0C
		private static int _ZtestMode_Disable; // 0x10
		private static int _ZtestMode_LessEqual; // 0x14
		private CharacterViewStyle.Style _curCharacterStyle; // 0x408
		private BodyCameraStyle.Style _curBodyCameraStyle; // 0x4C0
		private ElementStyle.Style _curElementStyle; // 0x5D0
		private ElementType _curElementType; // 0x6B8
		private Stack<ShowType> _showStack; // 0x6C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMin; // 0x6C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMax; // 0x6CC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMinAvtar; // 0x6D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomDegree; // 0x6D4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _cameraBlurMaxValue; // 0x6D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _cameraBlurMinValue; // 0x6DC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _groundAlphaMax; // 0x6E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _groundAlphaMin; // 0x6E4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _ditherMaxThreshold; // 0x6E8
		private const string _elementEffectFolderPath = "ART/Effect/UI/"; // Metadata: 0x00B11881
		private Dictionary<ElementType, string> _effectPrefabPathDic; // 0x6F0
		private Dictionary<ElementType, uint> _effectPrefabHandlerDic; // 0x6F8
		private Dictionary<ElementType, GameObject> _elementEffectDic; // 0x700
		private List<ElementType> _elementEffectNullList; // 0x708
		private bool _hasClosedFog; // 0x710
		private bool _originalFogEnable; // 0x711
		private int _lastTriggerIndex; // 0x714
		private NormalTimer _idleTriggerTimer; // 0x718
		private float _lastOpenEffectTime; // 0x720
		private UnityEngine.ShadowQuality _originalShadowQuality; // 0x724
		private bool _enableSetAvatarDither; // 0x728
		private const string WEAPON_STATE_ID = "WeaponStateID"; // Metadata: 0x00B11893
		private const string NEXT_WEAPON_STATE_ID = "NextWeaponStateID"; // Metadata: 0x00B118A4
		private SceneUiState _sceneState; // 0x72C
		private float _cutInNowTime; // 0x730
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _cutInMaxTime; // 0x734
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _skyBoxCutInTime; // 0x738
		private float _sceneReadyAddHeight; // 0x73C
		private bool _enterCutIn; // 0x740
		private bool _hasSetSkyBox; // 0x741
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _skyBoxStartScale; // 0x744
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _skyBoxEndScale; // 0x750
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _skyBoxColorLerpCurve; // 0x760
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _skyBoxAlphaLerpCurve; // 0x768
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _skyBoxScaleLerpCurve; // 0x770
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _groundStartScale; // 0x778
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _groundEndScale; // 0x784
		private float _groundNowTime; // 0x790
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _groundMaxTime; // 0x794
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _groundScaleLerpCurve; // 0x798
		private PostProcessLayer _avatarLayerProcess; // 0x7A0
		private int _elementEffectIndex; // 0x7A8
		// [Header] // 0x0000000189643EF0-0x0000000189643F20
		private Vector3 _storyAndVoiceCamMoveVec; // 0x7AC
		// [Header] // 0x000000018964B630-0x000000018964B680
		[SerializeField] // 0x000000018964B630-0x000000018964B680
		private Transform _relicRoot; // 0x7B8
		private Transform _relicRotation; // 0x7C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicRotateRatio; // 0x7C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicRotateReduceRatio; // 0x7CC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _rotateVelocityMin; // 0x7D0
		private float _rotateVelocity; // 0x7D4
		private bool _onDragRelic; // 0x7D8
		private float _clockwise; // 0x7DC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _rotateVelocityRatio; // 0x7E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _relicRootRotation; // 0x7E4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _relicRootBackRotation; // 0x7F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _relicRootOffset; // 0x7FC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicCamFov; // 0x808
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _relicRootArray; // 0x810
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float[] _relicRotationArray; // 0x818
		private bool _onEnterDrag; // 0x820
		private float _relicCurrTime; // 0x824
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicLerpTime; // 0x828
		private float _relicLerpScale; // 0x82C
		private RelicLerpState _relicLerpState; // 0x830
		private int _relicSelectIndex; // 0x834
		private float _relicCurrRotation; // 0x838
		private float _relicTargetRotation; // 0x83C
		private float _relicRootCurrAngle; // 0x840
		private float _relicRootTargetAngle; // 0x844
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _charRotationY; // 0x848
		private float _charCurrRotation; // 0x84C
		private float _charTargetRotation; // 0x850
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _relicOffset; // 0x854
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicAnimDelay; // 0x860
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _defaultRelicCamPos; // 0x864
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _defaultRelicCamTarget; // 0x870
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _relicScaleChangeVec; // 0x87C
		private Vector3 _relicCurrScale; // 0x888
		private Vector3 _relicTargetScale; // 0x894
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _replaceRelicCamMoveVec; // 0x8A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicSelectLerpTime; // 0x8AC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _relicStopTime; // 0x8B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _fadeCurve; // 0x8B8
		private Dictionary<uint, string[]> _relicEffectPathDic; // 0x8C0
		private Dictionary<int, GameObject> _relicClickEffectDic; // 0x8C8
		private Dictionary<string, GameObject> _relicPrefabDic; // 0x8D0
		private string _relicImgFolderPath; // 0x8D8
		private Dictionary<string, Texture2D> _relicImgDic; // 0x8E0
		private string _levelTextPrefabPath; // 0x8E8
		private Dictionary<int, MonoRelicLevelTextSlot> _levelTextEffectDic; // 0x8F0
		private bool _canShowLevelText; // 0x8F8
		private string _relicImgPrefabPath; // 0x900
		private GameObject _relicImgPrefab; // 0x908
		private string _relicNoticePrefabPath; // 0x910
		private GameObject _relicNoticePrefab; // 0x918
		private bool _checkRedPoint; // 0x920
		private bool _onRelicSelect; // 0x921
		private Coroutine _unselectRelicCoroutine; // 0x928
		// [Header] // 0x00000001896F1DE0-0x00000001896F1E20
		[SerializeField] // 0x00000001896F1DE0-0x00000001896F1E20
		private Transform _talentStarRoot; // 0x930
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _talentCamOffset; // 0x938
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _talentLerpTime; // 0x944
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _talentStarLerpTime; // 0x948
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _skyGalaxyFadeValue; // 0x94C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _defaultTalentStarScale; // 0x950
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _selectTalentStarScale; // 0x95C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _talentBgShowDelay; // 0x968
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _talentBgLerpCurve; // 0x970
		private float _talentCurrTime; // 0x978
		private bool _lerpTalentBgAlpha; // 0x97C
		private float _talentBgCurrAlpha; // 0x980
		private float _talentBgTargetAlpha; // 0x984
		private float _talentLinesCurrAlpha; // 0x988
		private float _talentLinesTargetAlpha; // 0x98C
		private static int _talentBgOpacity; // 0x18
		private Dictionary<uint, string> _talentStarPathDic; // 0x990
		private Dictionary<uint, GameObject> _talentStarPrefabDic; // 0x998
		private uint _cacheConfigId; // 0x9A0
		private GameObject _cacheTalentStar; // 0x9A8
		private GameObject _cacheTalentLevelUpEffect; // 0x9B0
		private const string TALENT_STAR_FOLDER_PATH = "ART/UI/Menus/Widget/CharacterPage/Talent_StarTray/"; // Metadata: 0x00B118B9
		private const string TALENT_STAR_BIG_PATH = "ART/Effect/UI/Character/Eff_UI_TalentStar_Big"; // Metadata: 0x00B118EF
		private const string TALENT_LEVELUP_EFFECT_PATH = "ART/Effect/UI/Character/Eff_UI_AvatarTalent_LevelUp"; // Metadata: 0x00B11920
		private const string TALENT_STAR_BG_FOLDER_PATH = "ART/UI/TalentTexture/"; // Metadata: 0x00B11957
		private GameObject _bigStarPrefab; // 0x9B8
		private GameObject _talentLevelUpEffectPrefab; // 0x9C0
		private List<GameObject> _bigStarGameObjectList; // 0x9C8
		private List<GameObject> _smallStarGameObjectList; // 0x9D0
		private int _selectIndex; // 0x9D8
		private Coroutine _talentStarScaleCoroutine; // 0x9E0
		// [Header] // 0x00000001897383B0-0x00000001897383F0
		[SerializeField] // 0x00000001897383B0-0x00000001897383F0
		private float _distFromCamera; // 0x9E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _distFromGround; // 0x9EC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _distFromGroundSelect; // 0x9F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _defaultTeamCameraPos; // 0x9F4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _defaultTeamCameraTarget; // 0xA00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _teamAvatarCameraPos; // 0xA0C
		private Vector3[] _teamAvatarPos; // 0xA18
		private Vector3 _lookAtPos; // 0xA20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _teamGroundY; // 0xA2C
		private Dictionary<ulong, BaseEntity> _teamEntityDic; // 0xA30
		private Dictionary<ulong, Vector3> _teamEntityPosDic; // 0xA38
		private const int MAX_TEAM_DIC_NUM = 5; // Metadata: 0x00B11970
		private ulong _lastToRemoveAvatar; // 0xA40
		private string _teamEffectPath; // 0xA48
		private uint _teamEffectHandler; // 0xA50
		private GameObject _teamEffect; // 0xA58
		private bool _isLoadingTeamEffect; // 0xA60
		private string _teamSelectionEffectPath; // 0xA68
		private uint _teamSelectionEffectHandler; // 0xA70
		private GameObject _teamSelectionEffect; // 0xA78
		private bool _isLoadingTeamSelectionEffect; // 0xA80
		private bool _showTeamAvatarDetail; // 0xA81
		private float _detailAvatarCurrTime; // 0xA84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _detailAvatarLerpTime; // 0xA88
		private Vector3 _detailAvatarCurrPos; // 0xA8C
		private Vector3 _detailAvatarTargetPos; // 0xA98
		private ulong _lerpAvatarGuid; // 0xAA8
		private DetailAvatarLerpState _avatarLerpType; // 0xAB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _lerpCurve; // 0xAB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _teamScenePosFromCamera; // 0xAC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _teamCamLookFowardScale; // 0xACC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _teamPosCalcTime; // 0xAD0
		private float _teamAvatarMinDist; // 0xAD4
		private Coroutine _detailToTeamCameraCoroutine; // 0xAD8
		private int currIndex; // 0xAE0
		private Coroutine currAdjustingCoroutine; // 0xAE8
		private Vector3 currAdjustVector; // 0xAF0
		private Vector3 maxAdjustVector; // 0xAFC
		private float currTime; // 0xB08
		// [Header] // 0x00000001897962B0-0x0000000189796300
		[SerializeField] // 0x00000001897962B0-0x0000000189796300
		private Vector3 _weaponDefaultPos; // 0xB0C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _weaponDefaultLookAt; // 0xB18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _weaponGroundY; // 0xB24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _avatarGroundY; // 0xB28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _weaponRootOffset; // 0xB2C
		private ShowType _lastShowType; // 0xB38
		private Vector3 _lastWeaponContainerPos; // 0xB3C
		private GadgetEntity _weaponEntity; // 0xB48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _weaponCamOffset; // 0xB50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _charDisappearDelay; // 0xB5C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _replaceWeaponCamMoveVec; // 0xB60
		private WeaponItem _weaponItem; // 0xB70
		private const string EQUIP_LEVEL_UP_EFFECT = "ART/Effect/UI/Character/Eff_UI_Weapon_Intensify_Fly_Twice"; // Metadata: 0x00B11974
		private GameObject _equipLvUpEffectPrefab; // 0xB78
		private List<GameObject> _equipLvUpEffects; // 0xB80
		private List<Vector3> _equipEffectPosList; // 0xB88
		private const string EQUIP_BREAK_THROUGH_EFFECT_PATH = "ART/Effect/UI/Character/Eff_UI_Weapon_Breakthrough"; // Metadata: 0x00B119B1
		private GameObject _equipBreakThroughEffect; // 0xB90
		private const string EQUIP_AWAKEN_EFFECT_PATH = "ART/Effect/UI/Character/Eff_UI_Equip_AwakenUp_Twice"; // Metadata: 0x00B119E7
		private GameObject _equipAwakenEffect; // 0xB98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _equipEffectRoot; // 0xBA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _innerCircleR; // 0xBA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _outerCircleR; // 0xBAC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _equipEffectVelocity; // 0xBB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _equipEffectSpeedCurve; // 0xBB8
		private bool _updateEquipEffect; // 0xBC0
		private int _aliveEquipEffect; // 0xBC4
		private static int _weaponHitColorId; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _lvEffectMaxTime; // 0xBC8
		private float _lvEffectCurrTime; // 0xBCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _startEffectColor; // 0xBD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _endEffectColor; // 0xBE0
		private Color _currEffectColor; // 0xBF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _lvEffectLerpCurve; // 0xC00
	
		// Properties
		public Vector2 coopParallax { /* [XID] */ /* 0x0000000189A766B0-0x0000000189A766D0 */ set {} } // 0x000000018146B300-0x000000018146B400
		public MaterialPropertyBlock mpb { /* [XID] */ /* 0x00000001896ED9C0-0x00000001896ED9E0 */ get => default; } // 0x000000018146AB50-0x000000018146AC30 
		public Renderer skyboxRenderer { /* [XID] */ /* 0x00000001896F5150-0x00000001896F5170 */ get => default; } // 0x000000018146AEF0-0x000000018146AFA0 
		public AnimationCurve skyBoxColorLerpCurve { /* [XID] */ /* 0x00000001896FC9F0-0x00000001896FCA10 */ get => default; } // 0x000000018146AD90-0x000000018146AE40 
		public AnimationCurve skyBoxAlphaLerpCurve { /* [XID] */ /* 0x0000000189703E90-0x0000000189703EB0 */ get => default; } // 0x000000018146ACE0-0x000000018146AD90 
		public AnimationCurve skyBoxScaleLerpCurve { /* [XID] */ /* 0x000000018970B770-0x000000018970B790 */ get => default; } // 0x000000018146AE40-0x000000018146AEF0 
		public float maxLerpTime { /* [XID] */ /* 0x0000000189712FF0-0x0000000189713010 */ get => default; } // 0x000000018146A9F0-0x000000018146AAA0 
		public Camera avatarCamera { /* [XID] */ /* 0x000000018971A870-0x000000018971A890 */ get => default; } // 0x000000018146A8A0-0x000000018146A950 
		public Transform[] virtualCameraArray { /* [XID] */ /* 0x0000000189721BD0-0x0000000189721BF0 */ get => default; } // 0x000000018146AFA0-0x000000018146B040 
		public Transform[] lookAtObjectArray { /* [XID] */ /* 0x0000000189729200-0x0000000189729220 */ get => default; } // 0x000000018146A950-0x000000018146A9F0 
		public float minRotAngle { /* [XID] */ /* 0x0000000189730A80-0x0000000189730AA0 */ get => default; } // 0x000000018146AAA0-0x000000018146AB50 
		public float zoomScaleMin { /* [XID] */ /* 0x0000000189738390-0x00000001897383B0 */ get => default; } // 0x000000018146B250-0x000000018146B300 
		public float zoomScaleMax { /* [XID] */ /* 0x00000001897400D0-0x00000001897400F0 */ get => default; } // 0x000000018146B0F0-0x000000018146B1A0 
		public float zoomScaleMinAvtar { /* [XID] */ /* 0x00000001897474A0-0x00000001897474C0 */ get => default; } // 0x000000018146B1A0-0x000000018146B250 
		public float zoomDegree { /* [XID] */ /* 0x000000018974EBF0-0x000000018974EC10 */ get => default; } // 0x000000018146B040-0x000000018146B0F0 
		public bool showTeamAvatarDetail { /* [XID] */ /* 0x0000000189951320-0x0000000189951340 */ get => default; } // 0x000000018146AC30-0x000000018146ACE0 
	
		// Nested types
		private struct VirtualCameraMoveInfo // TypeDefIndex: 30895
		{
			// Fields
			public Vector3 camPos; // 0x00
			public Vector3 lookAtPos; // 0x0C
			public bool isLocal; // 0x18
		}
	
		public enum CodexShowType // TypeDefIndex: 30896
		{
			CutIn = 0,
			HomePage = 1,
			SubPage = 2,
			Home2Sub = 3,
			SelectNextSlot = 4
		}
	
		[Serializable]
		public struct CodexSlotMaterialConfig // TypeDefIndex: 30897
		{
			// Fields
			public CodexPageType codexType; // 0x00
			public string iconName; // 0x08
			public float channel; // 0x10
		}
	
		public enum ShowType // TypeDefIndex: 30898
		{
			None = 0,
			Avatar = 1,
			Weapon = 2,
			Team = 3,
			WeaponDetail = 4,
			Relic = 5,
			AvatarPreview = 6,
			BattlePass = 7,
			Appearance = 8,
			Codex = 9,
			Coop = 10
		}
	
		public enum ShowSubType // TypeDefIndex: 30899
		{
			Avatar = 0,
			Weapon = 1,
			Relic = 2,
			Skill = 3,
			Talent = 5,
			Fetters = 6,
			StarUp = 7,
			FlyCloak = 8
		}
	
		public enum SceneUiState // TypeDefIndex: 30900
		{
			Init = 0,
			CutTo = 1,
			Ready = 2
		}
	
		private enum RelicLerpState // TypeDefIndex: 30901
		{
			None = 0,
			CharacterToRelic = 1,
			RelicToCharacter = 2,
			ToRelicDetail = 3,
			BackRelicDetail = 4,
			SelectNearestRelic = 5
		}
	
		private enum DetailAvatarLerpState // TypeDefIndex: 30902
		{
			None = 0,
			TeamToDetail = 1,
			DetailToTeam = 2,
			PreviewToDetail = 3,
			DetailToPreview = 4
		}
	
		// Constructors
		public MonoSceneUISetup() {} // 0x0000000181469210-0x000000018146A8A0
		static MonoSceneUISetup() {} // 0x00000001814690C0-0x0000000181469210
	
		// Methods
		// [XID] // 0x00000001898215E0-0x0000000189821600
		public void DoShowAppearanceTab(ShowSubType subType) {} // 0x0000000181445A30-0x0000000181445BD0
		// [XID] // 0x0000000189828BD0-0x0000000189828BF0
		private void DoShowAppearanceFlycloak() {} // 0x000000018144D250-0x000000018144D410
		// [XID] // 0x0000000189830000-0x0000000189830020
		private void DelayShowAvatarManekinEntity() {} // 0x00000001814439A0-0x0000000181443A90
		// [XID] // 0x0000000189837780-0x00000001898377A0
		public void CharacterToAppearance() {} // 0x00000001814421B0-0x00000001814422A0
		// [XID] // 0x000000018983EE50-0x000000018983EE70
		public void AppearanceToCharacter() {} // 0x000000018143DBA0-0x000000018143DD60
		// [XID] // 0x0000000189846450-0x0000000189846470
		private void UpdateAppearance() {} // 0x000000018143F260-0x000000018143F3A0
		// [XID] // 0x000000018984DA20-0x000000018984DA40
		private void PlayFashionSwitchEffect() {} // 0x000000018144BB80-0x000000018144BD30
		// [XID] // 0x0000000189854AA0-0x0000000189854AC0
		private void UnloadyFashionSwitchEffect() {} // 0x0000000181458E50-0x0000000181458FA0
		// [XID] // 0x000000018985C300-0x000000018985C320
		public void ChangtManekinFlycloak(uint id) {} // 0x0000000181441F50-0x00000001814421B0
		// [XID] // 0x0000000189863C40-0x0000000189863C60
		private void ShowManekinFlycloak() {} // 0x000000018144E850-0x000000018144E920
		// [XID] // 0x000000018986AF50-0x000000018986AF70
		private void HideManekinFlycloak() {} // 0x000000018144FB90-0x000000018144FC60
		// [XID] // 0x0000000189872320-0x0000000189872340
		public void ShowBattlePass() {} // 0x0000000181462BA0-0x0000000181462FE0
		// [XID] // 0x0000000189879F90-0x0000000189879FB0
		public void UnloadBattlePass() {} // 0x0000000181466DB0-0x0000000181466EB0
		// [XID] // 0x00000001898810D0-0x00000001898810F0
		public void ShowBattlePassWeapon(WeaponExcelConfig weaponConfig) {} // 0x0000000181462730-0x0000000181462BA0
		// [XID] // 0x00000001898886A0-0x00000001898886C0
		public void UnloadBattlePassWeapon() {} // 0x0000000181466CC0-0x0000000181466DB0
		// [XID] // 0x000000018988FA80-0x000000018988FAA0
		private void PushCamMoveInfo(VirtualCameraMoveInfo moveInfo) {} // 0x0000000181452850-0x0000000181452950
		// [XID] // 0x0000000189896F60-0x0000000189896F80
		private VirtualCameraMoveInfo PopCamMoveInfo() => default; // 0x000000018144B620-0x000000018144B780
		// [XID] // 0x000000018989E4C0-0x000000018989E4E0
		public void ShowCodex(bool isSubPage) {} // 0x0000000181463E40-0x00000001814642F0
		// [XID] // 0x00000001898A5FA0-0x00000001898A5FC0
		public void UnloadCodex() {} // 0x00000001814675D0-0x00000001814679A0
		// [XID] // 0x00000001898AD570-0x00000001898AD590
		public void LoadCodexDirectly() {} // 0x0000000181455260-0x00000001814553A0
		// [XID] // 0x00000001898B4AF0-0x00000001898B4B10
		public void UnloadCodexDirectly() {} // 0x0000000181466EB0-0x00000001814670F0
		// [XID] // 0x00000001898BC680-0x00000001898BC6A0
		public void LoadCodexModel() {} // 0x0000000181455500-0x0000000181455850
		// [XID] // 0x00000001898C3C40-0x00000001898C3C60
		public void LoadCodexSkybox() {} // 0x0000000181455D00-0x0000000181455E60
		// [XID] // 0x00000001898CB480-0x00000001898CB4A0
		public void LoadCodexSkyboxDirectly() {} // 0x0000000181455850-0x0000000181455D00
		// [XID] // 0x00000001898D2BD0-0x00000001898D2BF0
		public void LoadCodexSlot() {} // 0x00000001814565D0-0x0000000181456A30
		// [XID] // 0x00000001898DA4E0-0x00000001898DA500
		public void LoadCodexSlotParticle() {} // 0x0000000181455E60-0x00000001814565D0
		// [XID] // 0x00000001898E21B0-0x00000001898E21D0
		public void LoadCodexEffect() {} // 0x00000001814553A0-0x0000000181455500
		// [XID] // 0x00000001898E9D90-0x00000001898E9DB0
		public void DestroyCodexModel() {} // 0x00000001814449E0-0x0000000181444B50
		// [XID] // 0x00000001898F14C0-0x00000001898F14E0
		public void DestroyCodexSkybox() {} // 0x0000000181444B50-0x0000000181444CB0
		// [XID] // 0x00000001898F8C60-0x00000001898F8C80
		public void DestroyCodexSlot() {} // 0x0000000181444D90-0x0000000181444F00
		// [XID] // 0x0000000189900620-0x0000000189900640
		public void DestroyCodexSlotParticle() {} // 0x0000000181444CB0-0x0000000181444D90
		// [XID] // 0x0000000189907D90-0x0000000189907DB0
		public void DestroyCodexEffect() {} // 0x0000000181444880-0x00000001814449E0
		// [XID] // 0x000000018990F4F0-0x000000018990F510
		private void SetCodexGroundAlpha() {} // 0x000000018145CC80-0x000000018145CE90
		// [XID] // 0x0000000189916F70-0x0000000189916F90
		public void SetOnDragCodexSlot(bool onDrag, Vector2 pos, float deltaX = 0f /* Metadata: 0x00B116A8 */) {} // 0x00000001814605B0-0x0000000181460780
		// [XID] // 0x000000018991E6D0-0x000000018991E6F0
		private void RotateCodexSlot(float deltaDegree) {} // 0x000000018145B260-0x000000018145B360
		// [XID] // 0x0000000189925EF0-0x0000000189925F10
		private void UpdateCodex() {} // 0x0000000181450AB0-0x0000000181450F40
		// [XID] // 0x000000018992D4C0-0x000000018992D4E0
		private void UpdateCodexSlotRotation() {} // 0x000000018144C420-0x000000018144D100
		// [XID] // 0x0000000189934A70-0x0000000189934A90
		private void SetCodexBookSwipeSpeed(float diff, bool isFinal = false /* Metadata: 0x00B116AC */) {} // 0x000000018144A050-0x000000018144A250
		// [XID] // 0x000000018993C540-0x000000018993C560
		private void TriggerCodexAnimator(int i) {} // 0x000000018143E9B0-0x000000018143EB80
		// [XID] // 0x0000000189943B90-0x0000000189943BB0
		private void RefreshCodexSlotPosition(int i) {} // 0x0000000181456A30-0x0000000181456D40
		// [XID] // 0x000000018994B090-0x000000018994B0B0
		private void SetTargetCodexSlot() {} // 0x000000018145ADC0-0x000000018145AFD0
		// [XID] // 0x0000000189952A80-0x0000000189952AA0
		private float CaculateSlotAngle(int index) => default; // 0x000000018143E160-0x000000018143E4D0
		// [XID] // 0x0000000189959FF0-0x000000018995A010
		private void OnCodexSlotClick(Vector2 pos) {} // 0x000000018144F470-0x000000018144F700
		// [XID] // 0x0000000189961A20-0x0000000189961A40
		private void OnCodexSlotSelect(MonoCodexSlot slot) {} // 0x0000000181445FB0-0x0000000181446220
		// [XID] // 0x00000001899690D0-0x00000001899690F0
		private void ShowCodexSubPage(CodexPageType type) {} // 0x0000000181449650-0x0000000181449A30
		// [XID] // 0x0000000189970AF0-0x0000000189970B10
		public void UpdateCodexFromHome2Sub(int index) {} // 0x0000000181467F50-0x0000000181468670
		// [XID] // 0x0000000189978530-0x0000000189978550
		private void RotateToSelectCodexSlot(int index) {} // 0x000000018144B320-0x000000018144B4E0
		// [XID] // 0x000000018997F5F0-0x000000018997F610
		public void SelectNextCodexSlot(bool prev) {} // 0x0000000181460290-0x00000001814603C0
		// [XID] // 0x0000000189986F40-0x0000000189986F60
		public void OnCodexSlotSelectBtnClick() {} // 0x000000018145BCF0-0x000000018145BE00
		// [XID] // 0x000000018998EA30-0x000000018998EA50
		public void UpdateCodexFromSub2Home() {} // 0x0000000181468670-0x0000000181468D50
		// [XID] // 0x0000000189996630-0x0000000189996650
		public CodexSlotMaterialConfig GetCodexSlotMaterialConfig(CodexPageType type) => default; // 0x000000018144AC80-0x000000018144AF20
		// [XID] // 0x000000018999E090-0x000000018999E0B0
		private string GetCodexSubPageName(CodexPageType type) => default; // 0x000000018143E620-0x000000018143E7E0
		// [XID] // 0x00000001899A5AF0-0x00000001899A5B10
		public void ShowCodexWeapon(WeaponExcelConfig config) {} // 0x0000000181463D90-0x0000000181463E40
		// [XID] // 0x00000001899AD1D0-0x00000001899AD1F0
		public void ChangeCodexWeaponModel(WeaponExcelConfig config) {} // 0x0000000181441090-0x0000000181441650
		// [XID] // 0x00000001899B49B0-0x00000001899B49D0
		private void UpdateCodexWeaponEffectsLight() {} // 0x00000001814490D0-0x0000000181449300
		// [XID] // 0x00000001899BC080-0x00000001899BC0A0
		public void ChangeCodexWeaponTexture(bool firstShowAwakenTexture, WeaponExcelConfig config) {} // 0x0000000181441650-0x0000000181441790
		// [XID] // 0x00000001899C3B70-0x00000001899C3B90
		public void UnloadCodexWeapon() {} // 0x00000001814674E0-0x00000001814675D0
		// [XID] // 0x00000001899CB1D0-0x00000001899CB1F0
		public void UnloadCodexWeaponEffect() {} // 0x0000000181467380-0x00000001814674E0
		// [XID] // 0x00000001899D26E0-0x00000001899D2700
		private void OnCodexWeaponEntityReady(EvtEntityReadyPost evt) {} // 0x000000018144AAA0-0x000000018144AC80
		// [XID] // 0x00000001899D9E30-0x00000001899D9E50
		private void SetCodexWeaponEntity(BaseEntity baseEntity) {} // 0x000000018143EB80-0x000000018143ED70
		// [XID] // 0x00000001899E16D0-0x00000001899E16F0
		public void ShowCodexReliquary(ReliquaryExcelConfig config, uint rankLevel) {} // 0x0000000181463280-0x0000000181463D90
		// [XID] // 0x00000001899E8D40-0x00000001899E8D60
		public void UnloadCodexReliquary() {} // 0x0000000181467250-0x0000000181467380
		// [XID] // 0x00000001899F06C0-0x00000001899F06E0
		public void ShowCodexCreature(string modelPath, AnimalCodexType type = AnimalCodexType.CODEX_ANIMAL /* Metadata: 0x00B116AD */) {} // 0x0000000181462FE0-0x0000000181463280
		// [XID] // 0x00000001899F7CE0-0x00000001899F7D00
		private void loadCodexCreature(string path, AnimalCodexType type) {} // 0x0000000181445E10-0x0000000181445FB0
		// [XID] // 0x00000001899FF330-0x00000001899FF350
		private void OnCodexCreatureLoaded(ulong pathHash, bool loadSucceeded, uint handle, GameObject obj) {} // 0x000000018144A710-0x000000018144AAA0
		// [XID] // 0x0000000189A06B50-0x0000000189A06B70
		private void UnloadCodexCreature() {} // 0x000000018145AB50-0x000000018145ADC0
		// [XID] // 0x0000000189A0E260-0x0000000189A0E280
		public void UnloadCodexMonsterEffect() {} // 0x00000001814670F0-0x0000000181467250
		// [XID] // 0x0000000189A15860-0x0000000189A15880
		private void UpdateCodexCreature() {} // 0x000000018144C030-0x000000018144C420
		// [XID] // 0x0000000189A1CD00-0x0000000189A1CD20
		public void MoveCameraForCodexCreatureDetails(AnimalCodexType type) {} // 0x0000000181457D40-0x0000000181457F80
		// [XID] // 0x0000000189A24240-0x0000000189A24260
		public void MoveCameraForCodexCreature() {} // 0x0000000181457F80-0x0000000181458220
		// [XID] // 0x0000000189A2B6B0-0x0000000189A2B6D0
		public void SetCodexCreatureGroundY(AnimalCodexType type) {} // 0x00000001814603C0-0x00000001814604D0
		// [XID] // 0x0000000189A32D00-0x0000000189A32D20
		private Vector3 CalCameraPosByResolution() => default; // 0x0000000181447C60-0x0000000181447EF0
		public T GetUIScenePlugin<T>(UIScenePluginType pluginType)
			where T : BaseUIScenePlugin => default;
		// [XID] // 0x0000000189A3A590-0x0000000189A3A5B0
		public void RemoveUIScenePlugin(UIScenePluginType pluginType) {} // 0x000000018145FC70-0x000000018145FD60
		// [XID] // 0x0000000189A41EE0-0x0000000189A41F00
		private BaseUIScenePlugin CreateUIScenePlugin(UIScenePluginType pluginType) => default; // 0x0000000181454A70-0x0000000181454C20
		// [XID] // 0x0000000189A494B0-0x0000000189A494D0
		private void InitPlugins() {} // 0x0000000181448F10-0x0000000181448FE0
		// [XID] // 0x0000000189A50DC0-0x0000000189A50DE0
		private void ClearPlugins() {} // 0x000000018144E920-0x000000018144EAB0
		// [XID] // 0x0000000189A582E0-0x0000000189A58300
		private void UpdatePlugins() {} // 0x0000000181443A90-0x0000000181443C10
		// [XID] // 0x0000000189A5FDC0-0x0000000189A5FDE0
		private void EnablePlugins() {} // 0x0000000181454000-0x0000000181454180
		// [XID] // 0x0000000189A67A60-0x0000000189A67A80
		private void DisablePlugins() {} // 0x0000000181457AD0-0x0000000181457C50
		// [XID] // 0x0000000189A6EE70-0x0000000189A6EE90
		private void Destroy() {} // 0x0000000181440780-0x0000000181440820
		// [XID] // 0x0000000189A7DFE0-0x0000000189A7E000
		public void ShowCoop(ElementType elementType) {} // 0x00000001814642F0-0x0000000181464770
		// [XID] // 0x0000000189A85960-0x0000000189A85980
		private void ResetCoopCameraData() {} // 0x0000000181440C00-0x0000000181440DC0
		// [XID] // 0x0000000189A8D240-0x0000000189A8D260
		private SkyBoxType GetSkyBoxType(ElementType elementType) => default; // 0x000000018145C880-0x000000018145C9A0
		// [XID] // 0x0000000189A94780-0x0000000189A947A0
		private void ClearCoop() {} // 0x0000000181447660-0x0000000181447810
		// [XID] // 0x0000000189A9C060-0x0000000189A9C080
		public void UnloadCoop() {} // 0x00000001814679A0-0x0000000181467AA0
		// [XID] // 0x0000000189AA3730-0x0000000189AA3750
		private void UpdateCoop() {} // 0x0000000181457290-0x0000000181457560
		// [XID] // 0x0000000189AAADD0-0x0000000189AAADF0
		private bool IsCameraInCoopRange(Vector2 pos) => default; // 0x00000001814481F0-0x0000000181448330
		// [XID] // 0x0000000189AB2780-0x0000000189AB27A0
		public void Awake() {} // 0x000000018143DD60-0x000000018143DF80
		// [XID] // 0x0000000189ABA250-0x0000000189ABA270
		public void OnEnable() {} // 0x000000018145C040-0x000000018145C350
		// [XID] // 0x0000000189AC1B80-0x0000000189AC1BA0
		public void OnDisable() {} // 0x000000018145BE00-0x000000018145C040
		// [XID] // 0x0000000189AC9110-0x0000000189AC9130
		public void ShowAvatar(Action onAvatarLoaded = null) {} // 0x0000000181462410-0x0000000181462730
		// [XID] // 0x0000000189AD0B60-0x0000000189AD0B80
		public void ShowAvatarPreview(AvatarDataItem avatarDataItem) {} // 0x0000000181462060-0x0000000181462410
		// [IDTag] // 0x0000000189AD8780-0x0000000189AD87C0
		// [XID] // 0x0000000189AD8780-0x0000000189AD87C0
		private void LoadAvatarEntity(AvatarDataItem avatarDataItem) {} // 0x0000000181446220-0x00000001814464F0
		// [IDTag] // 0x0000000189AE30C0-0x0000000189AE3100
		// [XID] // 0x0000000189AE30C0-0x0000000189AE3100
		private void LoadAvatarEntity(uint avatarConfigId) {} // 0x00000001814464F0-0x0000000181446770
		// [XID] // 0x0000000189AEDB70-0x0000000189AEDB90
		private void SetAvatarManekinEntity(BaseEntity baseEntity) {} // 0x000000018144BE20-0x000000018144C030
		// [XID] // 0x0000000189AF53C0-0x0000000189AF53E0
		private void SetAvatarEquipEntity(BaseEntity baseEntity) {} // 0x00000001814577F0-0x0000000181457AD0
		// [XID] // 0x0000000189AFC910-0x0000000189AFC930
		private void ShowAvatarManekinEntity(BaseEntity baseEntity) {} // 0x000000018143ED70-0x000000018143EE60
		// [XID] // 0x0000000189B040B0-0x0000000189B040D0
		private void HideAvatarManekinEntity(BaseEntity baseEntity) {} // 0x000000018145A110-0x000000018145A1F0
		// [XID] // 0x0000000189B0B930-0x0000000189B0B950
		private void OnAvatarManekinReady(EvtEntityReadyPost evt) {} // 0x000000018143EE60-0x000000018143EF30
		// [XID] // 0x0000000189B12E20-0x0000000189B12E40
		private void LoadModelFinish() {} // 0x000000018143CC00-0x000000018143CD70
		// [XID] // 0x0000000189B1A4F0-0x0000000189B1A510
		public void SetCurrCameraByAvatarCamera() {} // 0x00000001814604D0-0x00000001814605B0
		// [XID] // 0x0000000189B219D0-0x0000000189B219F0
		public void UnloadAvatar() {} // 0x0000000181466B60-0x0000000181466CC0
		// [XID] // 0x0000000189B29180-0x0000000189B291A0
		public void UnloadAvatarPreview() {} // 0x0000000181466A10-0x0000000181466B60
		// [XID] // 0x0000000189B30530-0x0000000189B30550
		protected void ClearCurrManekin() {} // 0x000000018144E130-0x000000018144E220
		// [XID] // 0x0000000189B37E50-0x0000000189B37E70
		public void DoShowAvatarTab(ShowSubType subType) {} // 0x0000000181445BD0-0x0000000181445E10
		// [XID] // 0x0000000189B3F780-0x0000000189B3F7A0
		private void DoShowAvatarWeapon() {} // 0x000000018143BD20-0x000000018143BEF0
		// [XID] // 0x0000000189B470E0-0x0000000189B47100
		private void DoShowAvatarRelic() {} // 0x000000018145C9A0-0x000000018145CC80
		// [XID] // 0x0000000189B4E7E0-0x0000000189B4E800
		private void DoShowAvatarSkill() {} // 0x000000018144B780-0x000000018144B940
		// [XID] // 0x0000000189B56040-0x0000000189B56060
		private void DoShowAvatarTalent() {} // 0x00000001814473E0-0x0000000181447660
		// [XID] // 0x0000000189B5D920-0x0000000189B5D940
		private void DoShowAvatarDefault() {} // 0x00000001814489B0-0x0000000181448B80
		// [XID] // 0x0000000189B64E80-0x0000000189B64EA0
		private void DoShowAvatarFetter() {} // 0x000000018145A980-0x000000018145AB50
		// [XID] // 0x0000000189B6C480-0x0000000189B6C4A0
		private void DissolveAvatar() {} // 0x0000000181448FE0-0x00000001814490D0
		// [XID] // 0x0000000189B73BB0-0x0000000189B73BD0
		private void ResetTrigger(int triggerNameID) {} // 0x000000018144A3A0-0x000000018144A710
		// [XID] // 0x0000000189B7B1C0-0x0000000189B7B1E0
		private void SetManekinAnimaterTab(int tabID) {} // 0x000000018144F0D0-0x000000018144F2F0
		// [XID] // 0x0000000189B82B70-0x0000000189B82B90
		private void ResetModel() {} // 0x0000000181451710-0x0000000181451A20
		// [XID] // 0x0000000189B8A1A0-0x0000000189B8A1C0
		private bool IsHeadControllerWaiting(BaseEntity entity) => default; // 0x00000001814571B0-0x0000000181457290
		// [XID] // 0x0000000189B917E0-0x0000000189B91800
		private void InitHeadController(BaseEntity entity) {} // 0x000000018144B940-0x000000018144BAC0
		// [XID] // 0x0000000189B98BC0-0x0000000189B98BE0
		private void ResetHeadController(BaseEntity entity, ManekinHeadControllerStatus status) {} // 0x000000018144E760-0x000000018144E850
		// [XID] // 0x0000000189B9FEE0-0x0000000189B9FF00
		public void RotateModelByDelta(float xDeltaDegree, float yDeltaDegree) {} // 0x000000018145FE20-0x000000018145FF40
		// [XID] // 0x0000000189BA77C0-0x0000000189BA77E0
		private float GetCurrentHeightAdjust(float distance) => default; // 0x0000000181450F40-0x00000001814511C0
		// [XID] // 0x0000000189BAEAF0-0x0000000189BAEB10
		public float GetHeightAdjust(BodyType type) => default; // 0x000000018144AF20-0x000000018144B140
		// [XID] // 0x0000000189BB6220-0x0000000189BB6240
		private void UpdateCamera() {} // 0x0000000181447AE0-0x0000000181447C60
		// [XID] // 0x0000000189BBD820-0x0000000189BBD840
		private void UpdateCharacterLight() {} // 0x000000018143C5F0-0x000000018143C7B0
		// [XID] // 0x0000000189BC5590-0x0000000189BC55B0
		private void ShowElementEffect(ElementType elementType, bool showElemEffect = true /* Metadata: 0x00B116B1 */, bool showEnterEffect = false /* Metadata: 0x00B116B2 */, Vector3? effectPos = default) {} // 0x0000000181440130-0x0000000181440510
		// [XID] // 0x0000000189BCCFC0-0x0000000189BCCFE0
		private void PlayElementEffect(GameObject effect, bool showElemEffect = true /* Metadata: 0x00B116B3 */, bool showEnterEffect = false /* Metadata: 0x00B116B4 */, Vector3? effectPos = default) {} // 0x0000000181453250-0x0000000181453570
		// [XID] // 0x0000000189BD4580-0x0000000189BD45A0
		private void UnloadElementEffect() {} // 0x000000018144FC60-0x0000000181450010
		// [XID] // 0x0000000189BDC0B0-0x0000000189BDC0D0
		private void SetEffectDicActive(bool active) {} // 0x0000000181454760-0x0000000181454A70
		// [XID] // 0x00000001895E8890-0x00000001895E88B0
		private void Update() {} // 0x0000000181468D50-0x0000000181468FF0
		// [XID] // 0x00000001895F0120-0x00000001895F0140
		private void UpdateStyle() {} // 0x000000018143DF80-0x000000018143E160
		// [XID] // 0x00000001895F7BD0-0x00000001895F7BF0
		private void UpdateCharacterAnim() {} // 0x000000018144D100-0x000000018144D250
		// [XID] // 0x00000001895FEF10-0x00000001895FEF30
		private void UpdateCharacterAnimForAvatarPreview() {} // 0x00000001814515C0-0x0000000181451710
		// [XID] // 0x0000000189606770-0x0000000189606790
		private bool RanTriggerCharacterAnim() => default; // 0x0000000181457560-0x00000001814577F0
		// [XID] // 0x000000018960E110-0x000000018960E130
		private void UpdateSkyboxAlpha() {} // 0x0000000181451430-0x00000001814515C0
		// [XID] // 0x0000000189615780-0x00000001896157A0
		private void SetAvatarDitherAlphaValue() {} // 0x000000018143BEF0-0x000000018143C500
		// [XID] // 0x000000018961CF60-0x000000018961CF80
		public void ZoomCamera(float deltaPinch) {} // 0x0000000181468FF0-0x00000001814690C0
		// [XID] // 0x00000001896244B0-0x00000001896244D0
		public void PreSetupAvatar() {} // 0x000000018145E0C0-0x000000018145EDB0
		// [XID] // 0x000000018962BB60-0x000000018962BB80
		public void PreSetupAvatarPreview(AvatarDataItem avatarDataItem) {} // 0x000000018145DD20-0x000000018145E0C0
		// [XID] // 0x00000001896336D0-0x00000001896336F0
		private void UpdateUIScenePos() {} // 0x0000000181442B60-0x0000000181443160
		// [XID] // 0x000000018963AF70-0x000000018963AF90
		private void UpdateCutIn() {} // 0x0000000181454180-0x0000000181454610
		// [XID] // 0x0000000189642680-0x00000001896426A0
		private void RefreshStyleSetting(AvatarDataItem avatarData) {} // 0x000000018145BA70-0x000000018145BCF0
		// [XID] // 0x0000000189649D90-0x0000000189649DB0
		private void ResetElementTypeAndStyle(AvatarDataItem dataItem) {} // 0x0000000181453570-0x0000000181453700
		// [XID] // 0x00000001896514B0-0x00000001896514D0
		public void ShowAvatarOld() {} // 0x0000000181461CF0-0x0000000181462060
		// [XID] // 0x0000000189658C90-0x0000000189658CB0
		public void BeforeShowAvatar() {} // 0x000000018143FD40-0x0000000181440130
		// [XID] // 0x00000001896603C0-0x00000001896603E0
		public void BeforeShowAvatarPreview(AvatarDataItem avatarDataItem) {} // 0x000000018143FB70-0x000000018143FD40
		// [XID] // 0x0000000189667D80-0x0000000189667DA0
		public void ResetIdleTriggerTimerForPreview() {} // 0x000000018145FD60-0x000000018145FE20
		// [XID] // 0x000000018966F7F0-0x000000018966F810
		private void UpdateGround() {} // 0x000000018143D1F0-0x000000018143D420
		// [XID] // 0x0000000189677140-0x0000000189677160
		private void UpdateGroundAlpha() {} // 0x0000000181452350-0x00000001814526E0
		// [XID] // 0x000000018967E6F0-0x000000018967E710
		private void UpdateCameraReflection() {} // 0x0000000181440820-0x0000000181440A40
		// [XID] // 0x0000000189685F20-0x0000000189685F40
		public ShowType GetSceneUIType() => default; // 0x000000018144B280-0x000000018144B320
		// [XID] // 0x000000018968DD50-0x000000018968DD70
		public ShowSubType GetSceneUISubType() => default; // 0x000000018144B1E0-0x000000018144B280
		// [XID] // 0x00000001896956E0-0x0000000189695700
		public SceneUiState GetSceneState() => default; // 0x000000018144B140-0x000000018144B1E0
		// [XID] // 0x000000018969CCF0-0x000000018969CD10
		private void UpdateOpenEffect() {} // 0x0000000181452A10-0x0000000181452C50
		// [XID] // 0x00000001896A4040-0x00000001896A4060
		private void SetSkillPageElementEffect(bool active) {} // 0x0000000181443160-0x0000000181443220
		// [XID] // 0x00000001896AB620-0x00000001896AB640
		private void LoadSkillPageElementEffect() {} // 0x0000000181451A20-0x0000000181451CB0
		// [XID] // 0x00000001896B2830-0x00000001896B2850
		private void UnloadSkillPageElementEffect() {} // 0x0000000181440B40-0x0000000181440C00
		// [XID] // 0x00000001896B9F50-0x00000001896B9F70
		private void CheckCameraSceneType() {} // 0x0000000181447EF0-0x00000001814480D0
		// [XID] // 0x00000001896C1250-0x00000001896C1270
		private void CloseFog() {} // 0x0000000181452950-0x0000000181452A10
		// [XID] // 0x00000001896C8950-0x00000001896C8970
		public bool IsManekinEntityReady() => default; // 0x0000000181450440-0x0000000181450500
		// [XID] // 0x00000001896D0300-0x00000001896D0320
		private void BindGetCameraRotateCenterFunc() {} // 0x0000000181457C50-0x0000000181457D40
		// [XID] // 0x00000001896D7860-0x00000001896D7880
		private Vector3 GetCameraRotateCenterInAvatarPage(Vector3 targetPos) => default; // 0x000000018145C600-0x000000018145C880
		// [XID] // 0x00000001896DF040-0x00000001896DF060
		private void BindGetCameraFinalPosFunc() {} // 0x000000018144BD30-0x000000018144BE20
		// [XID] // 0x00000001896E64B0-0x00000001896E64D0
		private Vector3 GetCameraFinalPosInAvatarPage(Vector3 cameraLocalPos, float cameraZoomDist) => default; // 0x0000000181452C50-0x0000000181453080
		// [XID] // 0x0000000189756300-0x0000000189756320
		public void MoveStoryAndVoiceCam(bool toOrBack) {} // 0x0000000181458220-0x00000001814583F0
		// [XID] // 0x000000018975D6A0-0x000000018975D6C0
		private void SetupRelicRotation() {} // 0x0000000181443C10-0x0000000181443E40
		// [XID] // 0x0000000189764D30-0x0000000189764D50
		private void InitRelicScale() {} // 0x00000001814526E0-0x0000000181452850
		// [XID] // 0x000000018976C790-0x000000018976C7B0
		private void ResetRelicEffectPathDic() {} // 0x000000018144D4F0-0x000000018144DB90
		// [XID] // 0x0000000189773C50-0x0000000189773C70
		public void RefreshRelicRotation() {} // 0x000000018145F8E0-0x000000018145F980
		// [XID] // 0x000000018977B300-0x000000018977B320
		private void ResetRelicRoot() {} // 0x000000018143D070-0x000000018143D1F0
		// [IDTag] // 0x0000000189782E20-0x0000000189782E60
		// [XID] // 0x0000000189782E20-0x0000000189782E60
		private void SetRelicEffect(int index, EquipType type) {} // 0x000000018144ECF0-0x000000018144EF80
		// [IDTag] // 0x000000018978D290-0x000000018978D2D0
		// [XID] // 0x000000018978D290-0x000000018978D2D0
		private void SetRelicEffect(int index, ReliquaryItem item) {} // 0x000000018144EAB0-0x000000018144ECF0
		// [XID] // 0x0000000189797C70-0x0000000189797C90
		private void ShowRelicEffect(int index, uint rankLevel) {} // 0x0000000181446CE0-0x00000001814473E0
		// [XID] // 0x000000018979F950-0x000000018979F970
		private void ShowLevelText(int index, uint levelToShow) {} // 0x0000000181446940-0x0000000181446CE0
		// [XID] // 0x00000001897A6F50-0x00000001897A6F70
		private void UnloadRelicEffect() {} // 0x00000001814506F0-0x0000000181450AB0
		// [XID] // 0x00000001897AE890-0x00000001897AE8B0
		private void InitRelicPrefab() {} // 0x000000018143F160-0x000000018143F260
		// [XID] // 0x00000001897B67D0-0x00000001897B67F0
		private void UnloadRelicPrefab() {} // 0x000000018145B790-0x000000018145BA70
		// [XID] // 0x00000001897BE610-0x00000001897BE630
		private void SetRelicImage(int index, ReliquaryItem relicItem) {} // 0x00000001814483D0-0x00000001814488D0
		// [XID] // 0x00000001897C5CC0-0x00000001897C5CE0
		private string GetNoneRelicImagePath(EquipType type) => default; // 0x000000018143F020-0x000000018143F160
		// [XID] // 0x00000001897CD4E0-0x00000001897CD500
		private void SetRelicClickEffectActive(bool active) {} // 0x0000000181453080-0x0000000181453250
		// [XID] // 0x00000001897D4B00-0x00000001897D4B20
		private void RotateRelic(float deltaDegree) {} // 0x000000018143C500-0x000000018143C5F0
		// [XID] // 0x00000001897DC180-0x00000001897DC1A0
		private void UpdateRelicRotation() {} // 0x000000018144DB90-0x000000018144DE80
		// [XID] // 0x00000001897E3AD0-0x00000001897E3AF0
		private void CalculateLevelTextVisibleViaAngle(MonoRelicLevelTextSlot slot) {} // 0x000000018145A1F0-0x000000018145A980
		// [XID] // 0x00000001897EB760-0x00000001897EB780
		public void SetOnDragRelic(bool onDrag, Vector2 pos, float deltaX = 0f /* Metadata: 0x00B116B5 */) {} // 0x0000000181460780-0x00000001814608F0
		// [XID] // 0x00000001897F3000-0x00000001897F3020
		public void SetOnDrag(bool onDrag, Vector2 pos, float deltaX = 0f /* Metadata: 0x00B116B9 */) {} // 0x00000001814608F0-0x00000001814609F0
		// [XID] // 0x00000001897FA870-0x00000001897FA890
		private void OnRelicClick(Vector2 pos) {} // 0x000000018145AFD0-0x000000018145B260
		// [XID] // 0x0000000189801EC0-0x0000000189801EE0
		private bool OnRelicSlotSelect(MonoRelicSlot relicSlot) => default; // 0x0000000181447810-0x0000000181447AE0
		// [IDTag] // 0x00000001898092F0-0x0000000189809330
		// [XID] // 0x00000001898092F0-0x0000000189809330
		public void TurnToRelic(EquipType equipType) {} // 0x00000001814668D0-0x0000000181466A10
		// [IDTag] // 0x00000001898138C0-0x0000000189813900
		// [XID] // 0x00000001898138C0-0x0000000189813900
		public void TurnToRelic(MonoRelicSlot relicSlot) {} // 0x0000000181466790-0x00000001814668D0
		// [XID] // 0x000000018981E3D0-0x000000018981E3F0
		private Vector3 CalcVecterPosScale(Vector3 vec) => default; // 0x0000000181448CB0-0x0000000181448E00
		// [XID] // 0x0000000189825860-0x0000000189825880
		public void ChangeRelic(ReliquaryItem relicItem, EquipType equipType, bool changeSkybox = true /* Metadata: 0x00B116BD */) {} // 0x0000000181441790-0x0000000181441A40
		// [IDTag] // 0x000000018982D040-0x000000018982D080
		// [XID] // 0x000000018982D040-0x000000018982D080
		public void ShowRelicDetail(ReliquaryItem relicItem, AvatarDataItem avatarDataItem = null) {} // 0x0000000181464770-0x0000000181464F60
		// [XID] // 0x0000000189837760-0x0000000189837780
		public void UnloadRelicDetail() {} // 0x0000000181467AA0-0x0000000181467B50
		// [IDTag] // 0x000000018983EE10-0x000000018983EE50
		// [XID] // 0x000000018983EE10-0x000000018983EE50
		private void ShowRelicDetail(MonoRelicSlot relicSlot) {} // 0x0000000181440510-0x0000000181440780
		// [XID] // 0x0000000189848FB0-0x0000000189848FD0
		public void CharacterToRelicNew(ReliquaryItem item) {} // 0x00000001814422A0-0x00000001814425E0
		// [XID] // 0x0000000189850790-0x00000001898507B0
		public void RelicToCharacterNew() {} // 0x000000018145F980-0x000000018145FC70
		// [XID] // 0x0000000189857B40-0x0000000189857B60
		public void BackRelicDetail() {} // 0x000000018143F3A0-0x000000018143F570
		// [XID] // 0x000000018985EC10-0x000000018985EC30
		private void UpdateRelicRootNew() {} // 0x0000000181443E40-0x0000000181444440
		// [XID] // 0x0000000189866390-0x00000001898663B0
		private void SetRelicArrayActive(int index) {} // 0x0000000181454C20-0x0000000181454E40
		// [XID] // 0x000000018986DCC0-0x000000018986DCE0
		private void PlayRelicClickEffect(int index) {} // 0x0000000181454610-0x0000000181454760
		// [XID] // 0x0000000189875020-0x0000000189875040
		public void PlaySelectRelicClickEffect() {} // 0x000000018145D990-0x000000018145DA40
		// [XID] // 0x000000018987CCD0-0x000000018987CCF0
		private void MoveRelicReplaceCam(bool toOrBack) {} // 0x0000000181458FA0-0x0000000181459160
		// [XID] // 0x0000000189883C70-0x0000000189883C90
		private void SetRelicRedPoint(int index, EquipType type) {} // 0x000000018143B8F0-0x000000018143BD20
		// [XID] // 0x000000018988B310-0x000000018988B330
		public void SelectNearestRelicSlot(bool leftOrRight) {} // 0x000000018145FF40-0x0000000181460290
		// [XID] // 0x0000000189892A50-0x0000000189892A70
		private void UpdateRelicSelect() {} // 0x0000000181453700-0x0000000181453AA0
		// [XID] // 0x000000018989A0D0-0x000000018989A0F0
		private void UnselectRelicSlot() {} // 0x00000001814488D0-0x00000001814489B0
		// [XID] // 0x00000001898A1350-0x00000001898A1370
		public bool OnRelicSelectBtnClick(bool needStopRelicCoroutine = true /* Metadata: 0x00B116BE */) => default; // 0x000000018145C350-0x000000018145C510
		// [XID] // 0x00000001898A8C00-0x00000001898A8C20
		private int FindNearsestRelicIndex() => default; // 0x000000018144DE80-0x000000018144E130
		// [XID] // 0x00000001898B0560-0x00000001898B0580
		public void CanShowLevelText(bool isShow) {} // 0x0000000181440FE0-0x0000000181441090
		// [XID] // 0x00000001898B7B30-0x00000001898B7B50
		public void ShowStarUp() {} // 0x0000000181465550-0x00000001814656C0
		// [XID] // 0x00000001898BF140-0x00000001898BF160
		public void StarUpClose() {} // 0x00000001814660F0-0x0000000181466200
		// [XID] // 0x00000001898C6AE0-0x00000001898C6B00
		public void ShowStarUpEffect() {} // 0x0000000181465480-0x0000000181465550
		// [XID] // 0x00000001898CE0C0-0x00000001898CE0E0
		private void RefreshTalentStar() {} // 0x000000018144B4E0-0x000000018144B620
		// [XID] // 0x00000001898D5B30-0x00000001898D5B50
		private void LoadTalentStarObjectToRoot(AvatarDataItem avatarDataItem) {} // 0x0000000181453AA0-0x0000000181454000
		// [XID] // 0x00000001898DD7C0-0x00000001898DD7E0
		private void LoadTalentStarPrefab() {} // 0x000000018145A020-0x000000018145A110
		// [XID] // 0x00000001898E4FD0-0x00000001898E4FF0
		private void UnloadTalentStarPrefab() {} // 0x0000000181449A30-0x0000000181449D50
		// [XID] // 0x00000001898EC880-0x00000001898EC8A0
		private void SetTalentStarRootActive(bool active) {} // 0x0000000181440A40-0x0000000181440B40
		// [XID] // 0x00000001898F4290-0x00000001898F42B0
		public void SetTalentStarLinesColor(int index, bool isUnlock) {} // 0x00000001814609F0-0x0000000181460D20
		// [XID] // 0x00000001898FBA00-0x00000001898FBA20
		private void AddTalentStarToStarPanel() {} // 0x0000000181459750-0x000000018145A020
		// [XID] // 0x0000000189903410-0x0000000189903430
		private void DetachTalentStarFromParent() {} // 0x0000000181443670-0x00000001814439A0
		// [XID] // 0x000000018990A960-0x000000018990A980
		public void MoveTalentCameraToStar(int index) {} // 0x00000001814583F0-0x0000000181458780
		// [XID] // 0x00000001899125F0-0x0000000189912610
		public void SetTalentStarMaxEffect(int index, ElementType elemType) {} // 0x0000000181460D20-0x0000000181461150
		// [XID] // 0x0000000189919EC0-0x0000000189919EE0
		public void BackTalentCameraToDefault() {} // 0x000000018143F570-0x000000018143F760
		// [XID] // 0x0000000189921700-0x0000000189921720
		public void FadeInOrOutTalentBg(bool inOrOut, bool useDefaultAlpha = false /* Metadata: 0x00B116BF */) {} // 0x0000000181449300-0x0000000181449650
		// [XID] // 0x0000000189928E20-0x0000000189928E40
		private void UpdateTalentBgAlpha() {} // 0x0000000181454E40-0x0000000181455260
		// [XID] // 0x0000000189930370-0x0000000189930390
		private void SetTalentBgActive(bool active) {} // 0x000000018145B590-0x000000018145B790
		// [XID] // 0x0000000189937830-0x0000000189937850
		private void StartUpdateTalentStarScale(Vector3 targetScale) {} // 0x0000000181449D50-0x000000018144A050
		[DebuggerHidden] // 0x000000018993F350-0x000000018993F390
		// [XID] // 0x000000018993F350-0x000000018993F390
		private IEnumerator UpdateTalentStarScale(Transform trans, Vector3 startScale, Vector3 targetScale, float startTime = 0f /* Metadata: 0x00B116C0 */) => default; // 0x000000018144F2F0-0x000000018144F470
		// [XID] // 0x00000001899498F0-0x0000000189949910
		public void PlayTalentLevelUpEffect(int index) {} // 0x000000018145DA40-0x000000018145DD20
		// [XID] // 0x0000000189958910-0x0000000189958930
		public void PreSetupTeam(TeamPageStyle style) {} // 0x000000018145EDB0-0x000000018145F4C0
		// [XID] // 0x000000018995FF90-0x000000018995FFB0
		private void UpdateTeamCutIn() {} // 0x000000018143D420-0x000000018143D9E0
		// [XID] // 0x0000000189967A30-0x0000000189967A50
		private void TeamSceneSetupOld() {} // 0x0000000181448B80-0x0000000181448CB0
		// [XID] // 0x000000018996EBB0-0x000000018996EBD0
		public void SetupTeamAvatarPos(RectTransform[] teamAvatarBtns) {} // 0x0000000181461B30-0x0000000181461CF0
		// [XID] // 0x0000000189976790-0x00000001899767B0
		public void ShowTeamAvatar(ulong avatarGuid, int index, bool isTeam = true /* Metadata: 0x00B116C4 */) {} // 0x00000001814656C0-0x0000000181465880
		// [XID] // 0x000000018997DBD0-0x000000018997DBF0
		private BaseEntity ReactivateTeamManekin(ulong avatarGuid, int index) => default; // 0x000000018143CD70-0x000000018143D070
		// [XID] // 0x0000000189985580-0x00000001899855A0
		private BaseEntity CreateTeamManekin(ulong avatarGuid, int index, AvatarDataItem avatarDataItem) => default; // 0x0000000181443220-0x0000000181443670
		// [XID] // 0x000000018998D370-0x000000018998D390
		private void OnTeamManekinReady(BaseEntity baseEntity) {} // 0x000000018144D410-0x000000018144D4F0
		// [XID] // 0x0000000189994E10-0x0000000189994E30
		private void OnTeamManekinEquipReady(BaseEntity baseEntity) {} // 0x000000018144E220-0x000000018144E440
		// [XID] // 0x000000018999C6B0-0x000000018999C6D0
		private void SetTeamAvatar(ref BaseEntity entity, ulong guid) {} // 0x0000000181450010-0x0000000181450440
		// [XID] // 0x00000001899A4120-0x00000001899A4140
		private Vector3 CalcTeamAvatarPos(Vector3 uiPos, int index) => default; // 0x000000018143C7B0-0x000000018143CC00
		// [IDTag] // 0x00000001899ABAF0-0x00000001899ABB30
		// [XID] // 0x00000001899ABAF0-0x00000001899ABB30
		private Vector3 CalcLocalVecterPos(Vector3 worldPos) => default; // 0x0000000181459160-0x0000000181459490
		// [XID] // 0x00000001899B5E20-0x00000001899B5E40
		public void SetTeamEntityDicActive(bool active) {} // 0x0000000181461360-0x0000000181461800
		// [XID] // 0x00000001899BDB40-0x00000001899BDB60
		public void DeactivateTeamEntityExcept(List<ulong> guids) {} // 0x0000000181444440-0x0000000181444880
		// [XID] // 0x00000001899C5280-0x00000001899C52A0
		public void SetTeamEntityDicOnlyActive(ulong guid) {} // 0x0000000181461800-0x0000000181461A10
		// [XID] // 0x00000001899CC950-0x00000001899CC970
		public void ShowSelectedAvatar(ulong avatarGuid, int index) {} // 0x0000000181465060-0x0000000181465480
		// [XID] // 0x00000001899D3FF0-0x00000001899D4010
		public void ShowTeamChangeAvatarEffect(ulong avatarGuid, int index) {} // 0x0000000181465880-0x0000000181465AD0
		// [XID] // 0x00000001899DB560-0x00000001899DB580
		public void SetTeamCameraToDefault() {} // 0x0000000181461150-0x0000000181461360
		// [XID] // 0x00000001899E2C40-0x00000001899E2C60
		public void UnloadTeamEntities() {} // 0x0000000181467B50-0x0000000181467DE0
		// [XID] // 0x00000001899EA370-0x00000001899EA390
		private void CheckLastRemoveAvatar(ulong newGuid) {} // 0x0000000181440DC0-0x0000000181440FE0
		// [XID] // 0x00000001899F1D40-0x00000001899F1D60
		private void ShowTeamEffect(bool show) {} // 0x0000000181446770-0x0000000181446940
		// [XID] // 0x00000001899F9580-0x00000001899F95A0
		public void ShowTeamSelectionEffect(int index) {} // 0x0000000181465AD0-0x0000000181465D00
		// [XID] // 0x0000000189A008A0-0x0000000189A008C0
		public void SetTeamSelectionEffectActive(bool active) {} // 0x0000000181461A10-0x0000000181461B30
		// [XID] // 0x0000000189A08180-0x0000000189A081A0
		public void AdjustTeamSelectionEffect(bool down = true /* Metadata: 0x00B116C5 */) {} // 0x000000018143D9E0-0x000000018143DBA0
		[DebuggerHidden] // 0x0000000189A0F550-0x0000000189A0F590
		// [XID] // 0x0000000189A0F550-0x0000000189A0F590
		private IEnumerator AdjustCoroutine(bool down) => default; // 0x000000018145C510-0x000000018145C600
		// [XID] // 0x0000000189A19BD0-0x0000000189A19BF0
		private void UnloadTeamEffect() {} // 0x00000001814511C0-0x0000000181451430
		// [XID] // 0x0000000189A21200-0x0000000189A21220
		public void MoveTeamAvatar(ulong guid, Vector2 pointerPos) {} // 0x0000000181458780-0x0000000181458CB0
		// [XID] // 0x0000000189A28830-0x0000000189A28850
		public void TeamToDetail(ulong avatarGuid, int index) {} // 0x0000000181466200-0x0000000181466790
		// [XID] // 0x0000000189A2FE10-0x0000000189A2FE30
		public void PreviewToDetail(AvatarDataItem avatarDataItem) {} // 0x000000018145F4C0-0x000000018145F810
		// [XID] // 0x0000000189A377E0-0x0000000189A37800
		public void DetailToTeam(ulong avatarGuid, int index) {} // 0x0000000181445340-0x0000000181445A30
		// [XID] // 0x0000000189A3EF30-0x0000000189A3EF50
		public void DetailToPreview(AvatarDataItem avatarDataItem) {} // 0x0000000181444F00-0x0000000181445340
		// [XID] // 0x0000000189A465B0-0x0000000189A465D0
		private void UpdateDetailAvatarPos() {} // 0x000000018144F700-0x000000018144FB90
		// [XID] // 0x0000000189A4DDA0-0x0000000189A4DDC0
		public void ShowWeaponDetail(WeaponItem weaponItem) {} // 0x0000000181465D00-0x00000001814660F0
		// [XID] // 0x0000000189A555B0-0x0000000189A555D0
		private void SetupWeaponView(GameObject weaponGo) {} // 0x000000018144E440-0x000000018144E760
		// [XID] // 0x0000000189A5CEB0-0x0000000189A5CED0
		public void UnloadWeaponDetail() {} // 0x0000000181467DE0-0x0000000181467F50
		// [XID] // 0x0000000189A64730-0x0000000189A64750
		public void ChangeWeaponModel(WeaponItem weaponItem) {} // 0x0000000181441A40-0x0000000181441F50
		// [XID] // 0x0000000189A6BFD0-0x0000000189A6BFF0
		private void SetWeaponEntity(BaseEntity baseEntity) {} // 0x0000000181450500-0x00000001814506F0
		// [XID] // 0x0000000189A736A0-0x0000000189A736C0
		private void OnWeaponEntityReady(EvtEntityReadyPost evt) {} // 0x0000000181456D40-0x0000000181456EC0
		// [XID] // 0x0000000189A7B240-0x0000000189A7B260
		public void CharacterToWeaponDetail(WeaponItem weaponItem) {} // 0x00000001814425E0-0x0000000181442B60
		// [XID] // 0x0000000189A82960-0x0000000189A82980
		public void BackToAvatar() {} // 0x000000018143F760-0x000000018143FB70
		// [XID] // 0x0000000189A8A370-0x0000000189A8A390
		public void RefreshModelWeapon() {} // 0x000000018145F810-0x000000018145F8E0
		// [XID] // 0x0000000189A91AF0-0x0000000189A91B10
		public void ShowSelectWeapon(WeaponItem weaponItem) {} // 0x0000000181464F60-0x0000000181465060
		// [IDTag] // 0x0000000189A995E0-0x0000000189A99620
		// [XID] // 0x0000000189A995E0-0x0000000189A99620
		private Vector3 CalcLocalVecterPos(Vector3 worldPos, Transform trans) => default; // 0x0000000181459490-0x0000000181459750
		// [XID] // 0x0000000189AA3710-0x0000000189AA3730
		public void MoveWeaponReplaceCam(bool toOrBack) {} // 0x0000000181458CB0-0x0000000181458E50
		// [XID] // 0x0000000189AAADB0-0x0000000189AAADD0
		private void LoadEquipLvUpEffectPrefab() {} // 0x00000001814480D0-0x00000001814481F0
		// [XID] // 0x0000000189AB2760-0x0000000189AB2780
		private void UnloadEquipLvUpEffectPrefab() {} // 0x000000018143E7E0-0x000000018143E9B0
		// [XID] // 0x0000000189ABA230-0x0000000189ABA250
		public void PlayEquipLevelUpEffect(int effectNum, bool weaponOrRelic) {} // 0x000000018145D210-0x000000018145D8E0
		// [XID] // 0x0000000189AC1B60-0x0000000189AC1B80
		private Vector3 GetEffectRandomStartPos() => default; // 0x000000018144EF80-0x000000018144F0D0
		// [XID] // 0x0000000189AC90F0-0x0000000189AC9110
		private Vector3 GetLocalPosOffset(Vector3 offset, Transform trans) => default; // 0x0000000181456F40-0x00000001814571B0
		// [XID] // 0x0000000189AD0B40-0x0000000189AD0B60
		private void UpdateLevelUpEffectsPos() {} // 0x0000000181451CB0-0x0000000181452350
		// [XID] // 0x0000000189AD8760-0x0000000189AD8780
		public void PlayLevelUpEffect() {} // 0x000000018145D8E0-0x000000018145D990
		// [XID] // 0x0000000189AE03C0-0x0000000189AE03E0
		private void UpdateLevelUpEffectsLight() {} // 0x000000018145B360-0x000000018145B590
		// [XID] // 0x0000000189AE7970-0x0000000189AE7990
		public void PlayAwakenMaxEffect() {} // 0x000000018145CE90-0x000000018145D050
		// [XID] // 0x0000000189AEF670-0x0000000189AEF690
		private void UnloadEquipAwakenEffectPrefab() {} // 0x000000018144A250-0x000000018144A3A0
		// [XID] // 0x0000000189AF6B90-0x0000000189AF6BB0
		public void PlayBreakThrowEffect() {} // 0x000000018145D050-0x000000018145D210
		// [XID] // 0x0000000189AFE0C0-0x0000000189AFE0E0
		private void UnloadEquipBreakThrowPrefab() {} // 0x000000018143E4D0-0x000000018143E620
	}
}
