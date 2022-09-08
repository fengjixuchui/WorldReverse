/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMiniGameContext : BasePageContext // TypeDefIndex: 29074
{
	// Fields
	private const string TAB_PATH = "ART/UI/Atlas/ButtonIcon/"; // Metadata: 0x00B0EB2C
	private string[] TAB_NAMES; // 0x190
	private MonoFleurFairMiniGamePage _pageMono; // 0x198
	private MonoFleurFairMiniGame _gameMono; // 0x1A0
	private ActivityInfo _activityInfo; // 0x1A8
	private int _selectedTabIndex; // 0x1B0
	private int _forceTabIndex; // 0x1B4
	private bool _isOpened; // 0x1B8
	private bool _questFinished; // 0x1B9
	private List<ShopMaterial> _shopMaterialsList; // 0x1C0
	private GameObject _shopMaterialPrefab; // 0x1C8
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0EB48
	private uint _shopMaterialHandler; // 0x1D0
	private List<uint> _level_ids; // 0x1D8
	private List<uint> _watcherList; // 0x1E0
	private int MiniGameHash; // 0x1E8

	// Properties
	public EFleurFairMiniGame MiniGameType { /* [XID] */ /* 0x0000000189954020-0x0000000189954060 */ get; /* [XID] */ /* 0x000000018995EB80-0x000000018995EBC0 */ private set; } // 0x0000000183853F60-0x0000000183853FC0 0x0000000183852D30-0x0000000183852DA0

	// Constructors
	public FleurFairMiniGameContext(int miniGameIndex) {} // 0x0000000183854570-0x0000000183854800
	public FleurFairMiniGameContext() {} // 0x0000000183854300-0x0000000183854570

	// Methods
	// [XID] // 0x0000000189969310-0x0000000189969330
	public override void SetupView() {} // 0x00000001838541B0-0x0000000183854300
	// [XID] // 0x0000000189970DD0-0x0000000189970DF0
	public override void ClearView() {} // 0x0000000183850570-0x0000000183850660
	// [XID] // 0x0000000189978710-0x0000000189978730
	private void SetTabInfo() {} // 0x0000000183851220-0x00000001838514A0
	// [XID] // 0x000000018997F810-0x000000018997F830
	protected override void OnEnable() {} // 0x0000000183853A60-0x0000000183853BD0
	// [XID] // 0x00000001899871C0-0x00000001899871E0
	protected override void BindRedPoints() {} // 0x0000000183850090-0x00000001838501B0
	// [XID] // 0x000000018998EC50-0x000000018998EC70
	private void CheckRedPoints_Tabs(int index = -1 /* Metadata: 0x00B0EB28 */) {} // 0x0000000183850660-0x00000001838508B0
	// [XID] // 0x0000000189996830-0x0000000189996850
	private void CheckRedPoints_NewTag() {} // 0x000000018384FCA0-0x000000018384FF40
	// [XID] // 0x000000018999E330-0x000000018999E350
	private void CheckRedPoints_Reward() {} // 0x0000000183853050-0x00000001838531F0
	// [XID] // 0x00000001899A5CF0-0x00000001899A5D10
	protected override void BindViewCallbacks() {} // 0x00000001838501B0-0x00000001838504B0
	// [XID] // 0x00000001899AD390-0x00000001899AD3B0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183853BD0-0x0000000183853D90
	// [XID] // 0x00000001899B4C10-0x00000001899B4C30
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000183852DA0-0x0000000183852EA0
	// [XID] // 0x00000001899BC310-0x00000001899BC330
	private void UpdateActivity(uint activityId) {} // 0x00000001838538A0-0x00000001838539D0
	// [XID] // 0x00000001899C3CF0-0x00000001899C3D10
	private void Refresh(bool setup) {} // 0x000000018384F490-0x000000018384F660
	// [IDTag] // 0x00000001899CB410-0x00000001899CB450
	// [XID] // 0x00000001899CB410-0x00000001899CB450
	private void OnTabClicked(int tabIndex) {} // 0x0000000183850D10-0x0000000183850E00
	// [IDTag] // 0x00000001899D59E0-0x00000001899D5A20
	// [XID] // 0x00000001899D59E0-0x00000001899D5A20
	private void OnTabClicked(int tabIndex, bool clickByUser) {} // 0x0000000183850E00-0x0000000183851220
	// [XID] // 0x00000001899DFED0-0x00000001899DFEF0
	private void RefreshContent() {} // 0x00000001838525B0-0x0000000183852D30
	// [XID] // 0x00000001899E78C0-0x00000001899E78E0
	private void RefreshMissionRow(Transform trans, int index) {} // 0x0000000183853250-0x00000001838538A0
	// [XID] // 0x00000001899EEE30-0x00000001899EEE50
	private uint GetBaseNewTagRedPoint() => default; // 0x00000001838514A0-0x00000001838515B0
	// [XID] // 0x00000001899F6750-0x00000001899F6770
	private int GetMissionState(FleurFairMinigameInfo gameInfo, uint gameID) => default; // 0x000000018384F870-0x000000018384F9E0
	// [XID] // 0x00000001899FDCD0-0x00000001899FDCF0
	private int GetRewardState(FleurFairMiniGameExcelConfig excelData) => default; // 0x000000018384F660-0x000000018384F870
	// [XID] // 0x0000000189A05670-0x0000000189A05690
	private uint GetBestScore(FleurFairMinigameInfo gameInfo) => default; // 0x000000018384FF40-0x0000000183850090
	// [XID] // 0x0000000189A0C9B0-0x0000000189A0C9D0
	private ActivityWatcherInfo GetWatcherInfo(uint watcherID) => default; // 0x0000000183853FC0-0x00000001838541B0
	// [XID] // 0x0000000189A14300-0x0000000189A14320
	private void OnClickLevelDetail(int index) {} // 0x00000001838521E0-0x0000000183852400
	// [XID] // 0x0000000189A1B570-0x0000000189A1B590
	private void OnClickReceiveAll(int index) {} // 0x00000001838509D0-0x0000000183850C80
	// [XID] // 0x0000000189A22EF0-0x0000000189A22F10
	private void OnClickLevelReward(int index) {} // 0x0000000183853D90-0x0000000183853F60
	// [XID] // 0x0000000189A2A180-0x0000000189A2A1A0
	private void UpdateMaterialsList() {} // 0x00000001838515B0-0x0000000183851960
	// [XID] // 0x0000000189A31600-0x0000000189A31620
	private void OnClickGotoQuest() {} // 0x0000000183852EA0-0x0000000183853050
	// [XID] // 0x0000000189A390D0-0x0000000189A390F0
	private void OnClickCourse() {} // 0x0000000183852400-0x00000001838525B0
	// [XID] // 0x0000000189A408B0-0x0000000189A408D0
	private void ToPrevTab() {} // 0x00000001838504B0-0x0000000183850570
	// [XID] // 0x0000000189A47F30-0x0000000189A47F50
	private void ToNextTab() {} // 0x00000001838508B0-0x0000000183850970
	// [XID] // 0x0000000189A4F6F0-0x0000000189A4F710
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001838519C0-0x0000000183852030
	// [XID] // 0x0000000189A56E10-0x0000000189A56E30
	private void CheckJoypadBtns() {} // 0x000000018384F9E0-0x000000018384FC40
	// [XID] // 0x0000000189A5E940-0x0000000189A5E960
	private void OnClickGoto() {} // 0x0000000183852090-0x00000001838521E0
}

