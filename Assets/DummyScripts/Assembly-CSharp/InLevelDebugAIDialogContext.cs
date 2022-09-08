/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugAIDialogContext : BaseDialogContext // TypeDefIndex: 28584
{
	// Fields
	private static int monsterCreateNum; // 0x00
	private static int monsterCreateLevel; // 0x04
	private static int monsterCreateYOffset; // 0x08
	private static uint monsterLockSkillId; // 0x0C
	private static Color BUTTON_PLAYER_SELECTED; // 0x10
	private static Color BUTTON_PLAYER_UNSELECTED; // 0x20
	private static Color BUTTON_MONSTER_SELECTED; // 0x30
	private static Color BUTTON_MONSTER_UNSELECTED; // 0x40
	private static Color BUTTON_DIAGNOSIS_SELECTED; // 0x50
	private static Color BUTTON_DIAGNOSIS_UNSELECTED; // 0x60
	private InLevelDebugAIInfoDialogContext _infoPanel; // 0x178
	public const int MAX_ARROW_NUM = 30; // Metadata: 0x00B0D93C
	public const float UI_RADIUS = 250f; // Metadata: 0x00B0D940
	public const float COLLECTING_RANGE = 80f; // Metadata: 0x00B0D944
	private Transform _arrowGroupTrans; // 0x180
	private GameObject _arrowBase; // 0x188
	private uint _currentPick; // 0x190
	private uint _nearestMonsterID; // 0x194
	private float _nearestMonsterDist; // 0x198
	private GameObject _avatarArrow; // 0x1A0
	private BaseEntity _avatarEntity; // 0x1A8
	private Dictionary<uint, AITargetUnit> _targetList; // 0x1B0
	private List<uint> _removeList; // 0x1B8
	private Color COLOR_ARROW_SELECTED; // 0x1C0
	private Color COLOR_ARROW_UNSELECTED; // 0x1D0
	private float _nextCollectTime; // 0x1E0
	public int keyPickIndex; // 0x1E4
	public List<AITargetUnit> _manualPickList; // 0x1E8
	private static bool applyFilterFriendly; // 0x70
	private static TaregetFilterType filterType; // 0x74
	private const float AFFIX_ITEM_SIZE = 70f; // Metadata: 0x00B0D948
	private UnityEngine.UI.Text _affixInfoText; // 0x1F0
	private GameObject _exampleAffixItem; // 0x1F8
	private Image _affixInfoBackImage; // 0x200
	private Transform _affixSelectedImage; // 0x208
	private Transform _affixTakedContent; // 0x210
	private Transform _affixStoreContent; // 0x218
	private Toggle _isEliteToggle; // 0x220
	private List<Transform> _affixForMoveTrans; // 0x228
	private static List<uint> _takedAffixIDs; // 0x78
	private List<uint> _curSelectedBornAffixIDs; // 0x230
	private static List<GameObject> _affixItemList; // 0x80
	private uint _lastAffixClickID; // 0x238
	private float _lastAffixClickTime; // 0x23C

	// Nested types
	public class AITargetUnit // TypeDefIndex: 28585
	{
		// Fields
		public bool isLost; // 0x10
		public BaseEntity entity; // 0x18
		public GameObject arrow; // 0x20
		public QuickTap tap; // 0x28

		// Constructors
		public AITargetUnit() {} // 0x00000001832B1D20-0x00000001832B1D80

		// Methods
		// [XID] // 0x0000000189875480-0x00000001898754A0
		public void Recycle() {} // 0x00000001832B1BD0-0x00000001832B1D20
	}

	private enum TaregetFilterType // TypeDefIndex: 28586
	{
		None = 0,
		Monster = 1,
		NPC = 2,
		Gadget = 3
	}

	// Constructors
	public InLevelDebugAIDialogContext() {} // 0x000000018329D630-0x000000018329D8B0
	static InLevelDebugAIDialogContext() {} // 0x000000018329D340-0x000000018329D630

	// Methods
	// [XID] // 0x00000001896F0A10-0x00000001896F0A30
	public override void Init() {} // 0x00000001832988C0-0x00000001832989F0
	// [XID] // 0x00000001896F8200-0x00000001896F8220
	public override void CloseDialog() {} // 0x00000001832953C0-0x0000000183295490
	// [XID] // 0x00000001896FFB60-0x00000001896FFB80
	public override void SetupView() {} // 0x000000018329D080-0x000000018329D180
	// [XID] // 0x0000000189707230-0x0000000189707250
	private void SetupSelectFilterDrop() {} // 0x000000018329C9B0-0x000000018329CC30
	// [XID] // 0x000000018970EAD0-0x000000018970EAF0
	private void SetupMonsterDrop() {} // 0x000000018329C0B0-0x000000018329C3B0
	// [XID] // 0x0000000189715EB0-0x0000000189715ED0
	public void SetupInfoPanel() {} // 0x000000018329CC30-0x000000018329CDF0
	// [XID] // 0x000000018971D910-0x000000018971D930
	private void SetupSelectionArea() {} // 0x0000000183294BB0-0x0000000183294D50
	// [XID] // 0x0000000189724D30-0x0000000189724D50
	public override void ClearView() {} // 0x0000000183293BF0-0x0000000183294570
	// [XID] // 0x000000018972C4E0-0x000000018972C500
	private void InitEvents() {} // 0x0000000183296C40-0x00000001832988C0
	// [XID] // 0x0000000189733C40-0x0000000189733C60
	public override bool OnNotify(Notify ntf) => default; // 0x000000018329C8A0-0x000000018329C9B0
	// [XID] // 0x000000018973B360-0x000000018973B380
	private void OnQuestionMark() {} // 0x000000018329A020-0x000000018329A0C0
	// [XID] // 0x0000000189742CD0-0x0000000189742CF0
	private void OnAIDiagnosis() {} // 0x0000000183298A50-0x0000000183298CD0
	// [XID] // 0x000000018974A9F0-0x000000018974AA10
	private void OnReturn() {} // 0x00000001832965C0-0x0000000183296670
	// [XID] // 0x0000000189751AD0-0x0000000189751AF0
	private void OnSpawnAI() {} // 0x000000018329B4C0-0x000000018329B930
	// [XID] // 0x00000001897590C0-0x00000001897590E0
	private void OnSpawnAIClose() {} // 0x0000000183292430-0x00000001832924F0
	// [XID] // 0x0000000189760D10-0x0000000189760D30
	private void CreateMonsters(uint cID, uint level, bool isElite, List<uint> affixList) {} // 0x000000018329BCD0-0x000000018329C0B0
	// [XID] // 0x0000000189768070-0x0000000189768090
	private void OnMonsterDropChanged(int index) {} // 0x000000018329BB30-0x000000018329BCD0
	// [XID] // 0x000000018976F640-0x000000018976F660
	private void OnMonsterNumChanged(float num) {} // 0x0000000183296920-0x0000000183296AF0
	// [XID] // 0x0000000189776FC0-0x0000000189776FE0
	private void OnMonsterlevelChanged(string level) {} // 0x000000018329B130-0x000000018329B2D0
	// [XID] // 0x000000018977E6C0-0x000000018977E6E0
	private void OnMonsterYOffsetChanged(string yOffset) {} // 0x0000000183293040-0x00000001832931E0
	// [XID] // 0x0000000189785E70-0x0000000189785E90
	private void OnAI() {} // 0x00000001832924F0-0x00000001832926F0
	// [XID] // 0x000000018978D510-0x000000018978D530
	private void OnInfoPanel() {} // 0x0000000183294A60-0x0000000183294BB0
	// [XID] // 0x0000000189794950-0x0000000189794970
	private void OnThreatPanel() {} // 0x0000000183296670-0x0000000183296730
	// [XID] // 0x000000018979CD60-0x000000018979CD80
	private void OnPlayerGod() {} // 0x0000000183295490-0x00000001832956B0
	// [XID] // 0x00000001897A41C0-0x00000001897A41E0
	private void OnMonsterGod() {} // 0x000000018329A0C0-0x000000018329A2E0
	// [XID] // 0x00000001897AB720-0x00000001897AB740
	private void OnMonsterSkill() {} // 0x0000000183292750-0x0000000183292930
	// [XID] // 0x00000001897B3570-0x00000001897B3590
	private void OnKillAll() {} // 0x000000018329C3B0-0x000000018329C470
	// [XID] // 0x00000001897BB470-0x00000001897BB490
	private void OnPlayerInvisible() {} // 0x0000000183294850-0x0000000183294A60
	// [XID] // 0x00000001897C2CD0-0x00000001897C2CF0
	private void OnMonsterLockSkill() {} // 0x000000018329CDF0-0x000000018329D080
	// [XID] // 0x00000001897CA4D0-0x00000001897CA4F0
	private void OnMonsterLockSkillIdChanged(string skillId) {} // 0x0000000183296B50-0x0000000183296C40
	// [XID] // 0x00000001897D1AF0-0x00000001897D1B10
	public override void UpdateView() {} // 0x000000018329D180-0x000000018329D340
	// [XID] // 0x00000001897D99F0-0x00000001897D9A10
	public override void Destroy() {} // 0x0000000183294D50-0x0000000183294F50
	// [XID] // 0x00000001897E0CD0-0x00000001897E0CF0
	private void Collecting(bool force = false /* Metadata: 0x00B0D93B */) {} // 0x0000000183293280-0x0000000183293BF0
	// [XID] // 0x00000001897E8330-0x00000001897E8350
	private void UpdateIconPosition() {} // 0x000000018329A4F0-0x000000018329ACF0
	// [XID] // 0x00000001897F0050-0x00000001897F0070
	private void On_TouchStart(Gesture gesture) {} // 0x0000000183296440-0x00000001832965C0
	// [XID] // 0x00000001897F7800-0x00000001897F7820
	private void OnTouchPick(uint newTarID) {} // 0x0000000183296020-0x0000000183296280
	// [XID] // 0x00000001897FEEF0-0x00000001897FEF10
	private void AutoPick() {} // 0x0000000183296280-0x0000000183296440
	// [XID] // 0x0000000189806690-0x00000001898066B0
	public void ManualPick(bool left) {} // 0x000000018329ACF0-0x000000018329B130
	// [XID] // 0x000000018980DDD0-0x000000018980DDF0
	private void OnSelectPrevAI() {} // 0x00000001832931E0-0x0000000183293280
	// [XID] // 0x00000001898154F0-0x0000000189815510
	private void OnSelectNextAI() {} // 0x0000000183294F50-0x0000000183294FF0
	// [XID] // 0x000000018981CF30-0x000000018981CF50
	private void OnSelectFilterFriendly() {} // 0x000000018329B930-0x000000018329BB30
	// [XID] // 0x00000001898242D0-0x00000001898242F0
	private void OnSelectFilterByType() {} // 0x0000000183298CD0-0x0000000183298E50
	// [XID] // 0x000000018982BDA0-0x000000018982BDC0
	private void OnShowAffix() {} // 0x0000000183296730-0x00000001832968C0
	// [XID] // 0x0000000189833330-0x0000000189833350
	private void OnSelecetedMonsterBornAffixChanged(MonsterExcelConfig config) {} // 0x000000018329A2E0-0x000000018329A4F0
	// [XID] // 0x000000018983A7A0-0x000000018983A7C0
	private void AffixAndEliteClear() {} // 0x0000000183299A60-0x000000018329A020
	// [XID] // 0x0000000189841E20-0x0000000189841E40
	private void AffixAndEliteInitEvents() {} // 0x00000001832956B0-0x0000000183296020
	// [XID] // 0x00000001898492F0-0x0000000189849310
	private void OnAffixItemValueChanged(GameObject temp, bool isOn) {} // 0x0000000183298EB0-0x0000000183299A00
	// [XID] // 0x0000000189850A90-0x0000000189850AB0
	private void RefreshBornAffix() {} // 0x0000000183292930-0x0000000183293040
	// [XID] // 0x0000000189857E80-0x0000000189857EA0
	private void OnAffixAdd() {} // 0x000000018329C470-0x000000018329C810
	// [XID] // 0x000000018985EF90-0x000000018985EFB0
	private void OnAffixRemove() {} // 0x0000000183294FF0-0x00000001832953C0
	// [XID] // 0x0000000189866750-0x0000000189866770
	private void ReCalcContentSize() {} // 0x0000000183294570-0x0000000183294850
	// [XID] // 0x000000018986E050-0x000000018986E070
	private List<uint> CalcAffixListForSpwan() => default; // 0x000000018329B2D0-0x000000018329B4C0
}

