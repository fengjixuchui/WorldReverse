/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCMarkBillboardPlugin : VCBaseBillboardPlugin // TypeDefIndex: 12164
{
	// Fields
	public static readonly string QUEST_ARROW_PREPAB_PATH; // 0x00
	public static readonly string QUEST_TARGET_PREPAB_PATH; // 0x08
	private const string QUEST_MARK_LOCATION_PREFAB = "ART/UI/Menus/Widget/InLevel/Billboard/QuestMark_Location"; // Metadata: 0x00AEB602
	private const string MARK_PREFAB_DIR_PATH = "ART/UI/Menus/Widget/InLevel/Billboard/"; // Metadata: 0x00AEB63E
	private const string DEFAULT_MARK_PREFAB_NAME = "QuestMark"; // Metadata: 0x00AEB668
	private const string GENERAL_MARK_PREPAB_PATH = "ART/UI/Menus/Widget/InLevel/Billboard/GeneralMark"; // Metadata: 0x00AEB675
	private GameObject _mark; // 0x88
	private Animator _animator; // 0x90
	private MarkBillboardType _type; // 0x98
	private MarkbillboardState _state; // 0x9C
	private float _fadeOutFinishTime; // 0xA0
	private SpriteLoadProxy _iconProxy; // 0xA8
	private TrackingGroup _markGroup; // 0xB0
	private AsyncJob _jobProxyMark; // 0xC0
	private string _currResPath; // 0xD0
	private uint _markHandle; // 0xD8
	private bool _isLoading; // 0xDC
	private string _curShowName; // 0xE0
	private string _curShowTitle; // 0xE8
	private bool _isHaveIcon; // 0xF0
	private bool _isHaveName; // 0xF1
	private bool _isHaveTitle; // 0xF2
	private bool _isCanShowName; // 0xF3
	private bool _isCanShowTitle; // 0xF4
	private bool _isCurIconShow; // 0xF5
	private bool _isCurNameShow; // 0xF6
	private MonoGeneralMark _monoGeneralMark; // 0x100
	private bool _isEnabled; // 0x108
	private bool _currActive; // 0x109
	private Action invokeSetNameLightActive; // 0x110
	private const float LIGHT_WAITING_TIME = 1f; // Metadata: 0x00AEB6AA
	private Coroutine fadingOutCoroutine; // 0x118
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _enableHideOnMove; // 0x120
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _toHideVelocityThreshold; // 0x124
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _toShowVelocityThreshold; // 0x128
	private float _lastTime; // 0x12C
	private Vector3 _lastPosition; // 0x130
	private bool _hide; // 0x13C
	private string _iconName; // 0x140
	private bool _hideOnOverlap; // 0x148
	private int _effectIndex; // 0x14C
	private string _effectPattern; // 0x150
	private Vector3 _effectPosition; // 0x158
	private bool _isEffectDisable; // 0x164
	private bool _isEffectAttach; // 0x165

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898B7430-0x00000001898B7450 */ get => default; } // 0x00000001814E7860-0x00000001814E7900 
	public bool isIconShow { /* [XID] */ /* 0x00000001898BEBC0-0x00000001898BEC00 */ get; /* [XID] */ /* 0x00000001898C96A0-0x00000001898C96E0 */ private set; } // 0x00000001814E5740-0x00000001814E57A0 0x00000001814E69F0-0x00000001814E6A60
	public bool isNameShow { /* [XID] */ /* 0x00000001898D3C30-0x00000001898D3C70 */ get; /* [XID] */ /* 0x00000001898DEC70-0x00000001898DECB0 */ private set; } // 0x00000001814E3200-0x00000001814E3260 0x00000001814E4380-0x00000001814E43F0
	public bool isTitleShow { /* [XID] */ /* 0x00000001898E9770-0x00000001898E97B0 */ get; /* [XID] */ /* 0x00000001898F3CA0-0x00000001898F3CE0 */ private set; } // 0x00000001814E5E40-0x00000001814E5EA0 0x00000001814E4AA0-0x00000001814E4B10
	public override bool isActive { /* [XID] */ /* 0x00000001899A39C0-0x00000001899A39E0 */ get => default; } // 0x00000001814E70F0-0x00000001814E72C0 
	public override bool isValid { /* [XID] */ /* 0x00000001899AB4F0-0x00000001899AB510 */ get => default; } // 0x00000001814E5D40-0x00000001814E5E40 
	public bool enableHideOnMove { /* [XID] */ /* 0x00000001899EE4D0-0x00000001899EE4F0 */ set {} } // 0x00000001814E5B00-0x00000001814E5BB0

	// Nested types
	private enum MarkBillboardType // TypeDefIndex: 12165
	{
		QuestNPC = 0,
		QuestLocation = 1,
		GeneralMark = 2
	}

	private enum MarkbillboardState // TypeDefIndex: 12166
	{
		Normal = 0,
		FadeOut = 1
	}

	// Constructors
	public VCMarkBillboardPlugin() {} // 0x00000001814E76F0-0x00000001814E7860
	static VCMarkBillboardPlugin() {} // 0x00000001814E7670-0x00000001814E76F0

	// Methods
	// [XID] // 0x00000001898FE600-0x00000001898FE620
	public override void Init() {} // 0x00000001814E59C0-0x00000001814E5B00
	// [XID] // 0x0000000189905D40-0x0000000189905D60
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001814E34A0-0x00000001814E3580
	// [XID] // 0x0000000189BAA300-0x0000000189BAA320
	private void SetNameLightActive(bool active) {} // 0x00000001814E58B0-0x00000001814E59C0
	// [XID] // 0x0000000189914E50-0x0000000189914E70
	private void SetNameState(bool active) {} // 0x00000001814E3B50-0x00000001814E3C80
	// [XID] // 0x000000018991CA90-0x000000018991CAB0
	private void InvokeSetNameLightActive() {} // 0x00000001814E5810-0x00000001814E58B0
	// [XID] // 0x00000001899242F0-0x0000000189924310
	public override void Tick(float deltaTime) {} // 0x00000001814E7540-0x00000001814E7670
	// [XID] // 0x000000018992B7A0-0x000000018992B7C0
	public override void OnEnable() {} // 0x00000001814E7370-0x00000001814E7420
	// [XID] // 0x0000000189932F80-0x0000000189932FA0
	public override void OnDisable() {} // 0x00000001814E72C0-0x00000001814E7370
	// [XID] // 0x000000018993A840-0x000000018993A860
	public override void Destroy() {} // 0x00000001814E39B0-0x00000001814E3AA0
	// [XID] // 0x00000001899418D0-0x00000001899418F0
	public void SetNameText(string name, bool force) {} // 0x00000001814E4620-0x00000001814E4840
	// [XID] // 0x0000000189B43D10-0x0000000189B43D30
	public void SetTitleText(string title, bool force, bool checkChange = false /* Metadata: 0x00AEB5FE */) {} // 0x00000001814E4840-0x00000001814E4AA0
	// [XID] // 0x0000000189950C70-0x0000000189950C90
	public void AddQuestMark(string resPath, string iconName, TrackingGroup markGroup = default) {} // 0x00000001814E6450-0x00000001814E6610
	// [XID] // 0x0000000189958430-0x0000000189958450
	private void OnMarkPrefabLoaded(GameObject markInstance, uint handle) {} // 0x00000001814E4150-0x00000001814E4380
	// [XID] // 0x000000018995FAF0-0x000000018995FB10
	private void OnBillboardRequired() {} // 0x00000001814E6B10-0x00000001814E70F0
	// [XID] // 0x0000000189967410-0x0000000189967430
	public void AddQuestLocationMark(string resourcePath = null, bool showQuestPoint = false /* Metadata: 0x00AEB5FF */, TrackingGroup markGroup = default) {} // 0x00000001814E3580-0x00000001814E3800
	// [XID] // 0x000000018996E680-0x000000018996E6A0
	private void TryReplaceQuestMarkIcon(string iconName) {} // 0x00000001814E3310-0x00000001814E34A0
	// [XID] // 0x0000000189976130-0x0000000189976150
	private void SetIconImage(Sprite icon) {} // 0x00000001814E6610-0x00000001814E6720
	// [XID] // 0x0000000189BD6F70-0x0000000189BD6F90
	private void UpdateNameText() {} // 0x00000001814E6720-0x00000001814E6880
	// [XID] // 0x0000000189984FC0-0x0000000189984FE0
	private string GetRealTitleStr() => default; // 0x00000001814E2FC0-0x00000001814E30B0
	// [XID] // 0x0000000189601D70-0x0000000189601D90
	private void UpdateTitleText(bool isChange) {} // 0x00000001814E30B0-0x00000001814E3200
	// [XID] // 0x00000001899948A0-0x00000001899948C0
	public void RemoveQuestMark(bool force = false /* Metadata: 0x00AEB600 */) {} // 0x00000001814E2550-0x00000001814E2820
	// [XID] // 0x00000001897888A0-0x00000001897888C0
	private void RecycleMark() {} // 0x00000001814E4B10-0x00000001814E4FA0
	// [XID] // 0x00000001899B2F50-0x00000001899B2F70
	public override void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x00000001814E5120-0x00000001814E55F0
	// [XID] // 0x00000001899BA0B0-0x00000001899BA0D0
	private void MarkFadeIn() {} // 0x00000001814E55F0-0x00000001814E5740
	// [XID] // 0x0000000189689100-0x0000000189689120
	private void ClearFadingOut() {} // 0x00000001814E6150-0x00000001814E6250
	// [XID] // 0x00000001899C9020-0x00000001899C9040
	private void DoShowMark(bool show) {} // 0x00000001814E3C80-0x00000001814E3E30
	// [XID] // 0x00000001899D0B60-0x00000001899D0B80
	private void CheckMarkShow(bool onStart) {} // 0x00000001814E2930-0x00000001814E2B50
	// [XID] // 0x00000001899D7F50-0x00000001899D7F70
	private void MarkFadeOut(bool keepEffect = false /* Metadata: 0x00AEB601 */) {} // 0x00000001814E2E60-0x00000001814E2FC0
	// [XID] // 0x00000001899DF560-0x00000001899DF580
	private void NameFadeIn() {} // 0x00000001814E6250-0x00000001814E63E0
	// [XID] // 0x00000001899E70F0-0x00000001899E7110
	private void NameFadeOut() {} // 0x00000001814E4FA0-0x00000001814E5120
	// [XID] // 0x00000001899F5E00-0x00000001899F5E20
	private void CheckVelocity() {} // 0x00000001814E43F0-0x00000001814E4620
	// [XID] // 0x00000001899FD4B0-0x00000001899FD4D0
	public void AddGeneralMark(string iconName) {} // 0x00000001814E2BC0-0x00000001814E2E60
	// [XID] // 0x0000000189A04B80-0x0000000189A04BA0
	public void ClearGeneralMark() {} // 0x00000001814E6A60-0x00000001814E6B10
	// [XID] // 0x0000000189A0C230-0x0000000189A0C250
	public void SetOverlapState(bool isOverlap) {} // 0x00000001814E3260-0x00000001814E3310
	// [XID] // 0x0000000189A13BB0-0x0000000189A13BD0
	private void ClearOverlapState() {} // 0x00000001814E3800-0x00000001814E38A0
	// [XID] // 0x0000000189A1AD70-0x0000000189A1AD90
	private void AttachEffect() {} // 0x00000001814E38A0-0x00000001814E3950
	// [XID] // 0x0000000189A22650-0x0000000189A22670
	private void DetachEffect() {} // 0x00000001814E7490-0x00000001814E7540
	// [XID] // 0x0000000189A299A0-0x0000000189A299C0
	private void UpdateEffectActive(bool refreshImmediate) {} // 0x00000001814E5BB0-0x00000001814E5D40
	// [XID] // 0x0000000189AF3950-0x0000000189AF3970
	private void RefreshEffect() {} // 0x00000001814E3F10-0x00000001814E4150
	// [XID] // 0x0000000189A38AB0-0x0000000189A38AD0
	private void ClearEffect() {} // 0x00000001814E3AA0-0x00000001814E3B50
	// [XID] // 0x0000000189A400A0-0x0000000189A400C0
	public void AddEffect(string effectPattern, Vector3 position) {} // 0x00000001814E68F0-0x00000001814E69F0
	// [XID] // 0x0000000189A47740-0x0000000189A47760
	private void CheckLayoutChanged() {} // 0x00000001814E5F00-0x00000001814E6150
}

