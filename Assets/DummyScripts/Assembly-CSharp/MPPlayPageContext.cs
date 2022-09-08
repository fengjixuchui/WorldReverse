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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MPPlayPageContext : BasePageContext // TypeDefIndex: 29230
{
	// Fields
	private MonoMPPlayPage _pageMono; // 0x190
	private uint _playId; // 0x198
	private ShopMaterial _shopMaterial; // 0x19C
	private GameObject _shopMaterialPrefab; // 0x1A8
	private uint _shopMaterialHandler; // 0x1B0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0EE53
	private float _lastUpdateTime; // 0x1B4
	private MpPlayMatchExcelConfig _mpPlayMatchExcelConfig; // 0x1B8
	private MpPlayGroupExcelConfig _mpPlayGroupExcelConfig; // 0x1C0
	private MpPlayTextDataExcelConfig _mpPlayTextExcelConfig; // 0x1C8
	private bool _isMatching; // 0x1D0
	private MpPlayShowType _showType; // 0x1D4
	private uint _resinCost; // 0x1D8
	private uint _materialCostId; // 0x1DC
	private uint _materialCostNum; // 0x1E0
	private bool _hasBuff; // 0x1E4
	private bool _hasUpAvatar; // 0x1E5
	private List<uint> _upAvatarList; // 0x1E8
	private bool _hasCourseBtn; // 0x1F0
	private List<IdCountStrConfig> _rewardPreviewList; // 0x1F8
	private MessagePushPageContext _pushPage; // 0x200
	private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x208

	// Constructors
	public MPPlayPageContext() {} // Dummy constructor
	public MPPlayPageContext(uint playId) {} // 0x0000000182D926C0-0x0000000182D928A0

	// Methods
	// [XID] // 0x00000001896A1520-0x00000001896A1540
	public override void SetupView() {} // 0x0000000182D924C0-0x0000000182D925F0
	// [XID] // 0x00000001896A89E0-0x00000001896A8A00
	protected override void OnEnable() {} // 0x0000000182D91D70-0x0000000182D91E10
	// [XID] // 0x00000001896AFB60-0x00000001896AFB80
	public override void UpdateView() {} // 0x0000000182D925F0-0x0000000182D926C0
	// [XID] // 0x00000001896B74B0-0x00000001896B74D0
	public override void ClearView() {} // 0x0000000182D8ED40-0x0000000182D8EE90
	// [XID] // 0x00000001896BE600-0x00000001896BE620
	protected override void BindViewCallbacks() {} // 0x0000000182D8E8B0-0x0000000182D8EB10
	// [XID] // 0x00000001896C5EB0-0x00000001896C5ED0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182D91E10-0x0000000182D92150
	// [XID] // 0x00000001896CD580-0x00000001896CD5A0
	private void ResetData() {} // 0x0000000182D91470-0x0000000182D91570
	// [XID] // 0x00000001896D49F0-0x00000001896D4A10
	private void RefreshData() {} // 0x0000000182D8F530-0x0000000182D8FC20
	// [XID] // 0x00000001896DC070-0x00000001896DC090
	private void RefreshView() {} // 0x0000000182D90310-0x0000000182D90FB0
	// [XID] // 0x00000001896E37C0-0x00000001896E37E0
	private void RefreshMatchingData() {} // 0x0000000182D91570-0x0000000182D916B0
	// [XID] // 0x00000001896EAC50-0x00000001896EAC70
	private void RefreshMatchingView() {} // 0x0000000182D8EB10-0x0000000182D8ED40
	// [XID] // 0x00000001896F1FC0-0x00000001896F1FE0
	private void RefreshMatchTimeView() {} // 0x0000000182D91750-0x0000000182D91A30
	// [XID] // 0x00000001896F99A0-0x00000001896F99C0
	private void OnStartBtnClick() {} // 0x0000000182D91010-0x0000000182D911B0
	// [XID] // 0x00000001897011F0-0x0000000189701210
	private void OnStartSingleBtnClick() {} // 0x0000000182D91A90-0x0000000182D91CE0
	// [XID] // 0x00000001897088A0-0x00000001897088C0
	private void OnCancelBtnClick() {} // 0x0000000182D8E760-0x0000000182D8E8B0
	// [XID] // 0x0000000189710190-0x00000001897101B0
	private void OnCourseBtnClick() {} // 0x0000000182D8F340-0x0000000182D8F4A0
	// [XID] // 0x00000001897175B0-0x00000001897175D0
	private void InitResinView() {} // 0x0000000182D92150-0x0000000182D924C0
	// [XID] // 0x000000018971F070-0x000000018971F090
	private void RefreshResinView() {} // 0x0000000182D8EE90-0x0000000182D8F050
	// [XID] // 0x0000000189726670-0x0000000189726690
	private void RefreshBuffItem(Transform trans, int index) {} // 0x0000000182D8FC20-0x0000000182D8FF40
	// [XID] // 0x000000018972DB90-0x000000018972DBB0
	private void RefreshRewardPreviewItems(Transform trans, int index) {} // 0x0000000182D8F0B0-0x0000000182D8F340
	// [XID] // 0x0000000189735350-0x0000000189735370
	private void RefreshUpAvatarItems(Transform trans, int index) {} // 0x0000000182D91210-0x0000000182D91470
	// [XID] // 0x000000018973CDB0-0x000000018973CDD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D8FFA0-0x0000000182D90310
}

