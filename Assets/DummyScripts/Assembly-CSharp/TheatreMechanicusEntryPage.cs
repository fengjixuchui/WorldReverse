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

public sealed class TheatreMechanicusEntryPage : BasePageContext // TypeDefIndex: 29952
{
	// Fields
	private MonoTheatreMechanicusEntryPage _pageMono; // 0x190
	private uint _selectDifficultLevel; // 0x198
	private int _selectDifficultIndex; // 0x19C
	private List<MechanicusDifficultyExcelConfig> difficultList; // 0x1A0
	private GameObject _shopMaterialPrefab; // 0x1A8
	private List<MonoShopMaterial> _shopMaterialsList; // 0x1B0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B102FB
	private uint _shopMaterialHandler; // 0x1B8
	private float _lastUpdateTime; // 0x1BC
	private MessagePushPageContext _pushPage; // 0x1C0
	private DungeonExcelConfig _dungeonConfig; // 0x1C8

	// Constructors
	public TheatreMechanicusEntryPage() {} // 0x00000001814123E0-0x00000001814124F0

	// Methods
	// [XID] // 0x00000001898C23C0-0x00000001898C23E0
	public override void SetupView() {} // 0x0000000181411DE0-0x0000000181412310
	// [XID] // 0x00000001898C9DE0-0x00000001898C9E00
	private void Refresh() {} // 0x000000018140D8F0-0x000000018140DD10
	// [XID] // 0x00000001898D1420-0x00000001898D1440
	public override void UpdateView() {} // 0x0000000181412310-0x00000001814123E0
	// [XID] // 0x00000001898D8CA0-0x00000001898D8CC0
	private void RefreshMatchTimeView() {} // 0x0000000181411130-0x00000001814113E0
	// [XID] // 0x00000001898E0970-0x00000001898E0990
	private void PlayerMatchInfoUpdate() {} // 0x0000000181411440-0x00000001814115E0
	// [XID] // 0x00000001898E84D0-0x00000001898E84F0
	private void UpdateMaterialsList() {} // 0x000000018140F680-0x000000018140FB30
	// [XID] // 0x00000001898EFC90-0x00000001898EFCB0
	private void UpdateMaterialCount() {} // 0x0000000181411BA0-0x0000000181411D30
	// [XID] // 0x00000001898F74D0-0x00000001898F74F0
	protected override void OnEnable() {} // 0x0000000181411670-0x0000000181411770
	// [XID] // 0x00000001898FEC00-0x00000001898FEC20
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181411770-0x0000000181411860
	// [XID] // 0x0000000189906380-0x00000001899063A0
	protected override void BindViewCallbacks() {} // 0x000000018140E0C0-0x000000018140E5F0
	// [XID] // 0x000000018990DE00-0x000000018990DE20
	protected override void BindRedPoints() {} // 0x000000018140DF80-0x000000018140E0C0
	// [XID] // 0x0000000189915590-0x00000001899155B0
	public void SetupDifficultList() {} // 0x000000018140FF40-0x0000000181410420
	// [XID] // 0x000000018991CFE0-0x000000018991D000
	private void OnRefreshItem(Transform trans, int index) {} // 0x0000000181410D60-0x0000000181410F60
	// [XID] // 0x00000001899248B0-0x00000001899248D0
	private void OnClickDifficultItem(int index) {} // 0x0000000181410610-0x0000000181410C80
	// [XID] // 0x000000018992BE20-0x000000018992BE40
	private void OnClickReturn() {} // 0x00000001814119C0-0x0000000181411BA0
	// [XID] // 0x0000000189933350-0x0000000189933370
	private void OnClickBtnDifficult() {} // 0x000000018140FB30-0x000000018140FCF0
	// [XID] // 0x000000018993AEE0-0x000000018993AF00
	private void OnClickBtnCloseDifficult() {} // 0x000000018140EC90-0x000000018140ED80
	// [XID] // 0x0000000189941F50-0x0000000189941F70
	private void OnClickBtnGadget() {} // 0x00000001814104A0-0x00000001814105B0
	// [XID] // 0x0000000189949A30-0x0000000189949A50
	private void OnClickBtnHandBook() {} // 0x000000018140EE10-0x000000018140EF20
	// [XID] // 0x0000000189951480-0x00000001899514A0
	private void OnClickBtnTrialLevel() {} // 0x000000018140EA70-0x000000018140EC30
	// [XID] // 0x0000000189958A90-0x0000000189958AB0
	private void OnClickBtnInstruction() {} // 0x000000018140DDF0-0x000000018140DF20
	// [XID] // 0x00000001899600D0-0x00000001899600F0
	private void OnClickBtnSinglePlayer() {} // 0x000000018140E5F0-0x000000018140E980
	// [XID] // 0x0000000189967B70-0x0000000189967B90
	private void OnClickBtnMultiPlayer() {} // 0x000000018140EF20-0x000000018140F4A0
	// [XID] // 0x000000018996ED30-0x000000018996ED50
	private void CheckMultiplayer() {} // 0x0000000181410F60-0x0000000181411130
	// [XID] // 0x0000000189976930-0x0000000189976950
	protected override void RegisterHandlePacket() {} // 0x0000000181411D30-0x0000000181411DE0
	// [XID] // 0x000000018997DD90-0x000000018997DDB0
	public override bool OnPacket(Packet packet) => default; // 0x0000000181411860-0x00000001814119C0
	// [XID] // 0x0000000189985700-0x0000000189985720
	private void ConfirmTeam(DungeonExcelConfig config, bool multiplayer = false /* Metadata: 0x00B102FA */) {} // 0x000000018140F4A0-0x000000018140F680
	// [XID] // 0x000000018998D4D0-0x000000018998D4F0
	private void OnCancelMatchButton() {} // 0x0000000181410C80-0x0000000181410D60
	// [XID] // 0x0000000189994F70-0x0000000189994F90
	public override void ClearView() {} // 0x000000018140E980-0x000000018140EA70
	// [XID] // 0x000000018999C850-0x000000018999C870
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018140FD50-0x000000018140FEE0
}

