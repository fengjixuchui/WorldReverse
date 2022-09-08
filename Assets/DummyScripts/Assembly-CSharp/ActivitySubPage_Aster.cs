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

public sealed class ActivitySubPage_Aster : BaseSubPageContext // TypeDefIndex: 29379
{
	// Fields
	private ActivityInfo activityInfo; // 0x178
	private MonoActivityAsterSubPage _pageMono; // 0x180
	private uint _activityID; // 0x188
	private AsterActivityPerviewExcelConfig activityConfig; // 0x190
	private List<IdCountStrConfig> _rewardPreviewList; // 0x198
	private bool isOpen; // 0x1A0
	private List<ShopMaterial> _shopMaterialsList; // 0x1A8
	private GameObject _shopMaterialPrefab; // 0x1B0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F6AA
	private uint _shopMaterialHandler; // 0x1B8
	private uint _activityEndTime; // 0x1BC
	private ActivityAsterPageContent _asterPage; // 0x1C0
	private ActivityIntroduceDialog _activityIntroDialog; // 0x1C8

	// Constructors
	public ActivitySubPage_Aster() {} // Dummy constructor
	public ActivitySubPage_Aster(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183B04990-0x0000000183B04AE0

	// Methods
	// [XID] // 0x0000000189B91940-0x0000000189B91960
	public override void SetupView() {} // 0x0000000183B04760-0x0000000183B04990
	// [XID] // 0x0000000189B98D00-0x0000000189B98D20
	protected override void BindRedPoints() {} // 0x0000000183B028C0-0x0000000183B02A10
	// [XID] // 0x0000000189BA0120-0x0000000189BA0140
	private void Refresh() {} // 0x0000000183B01E60-0x0000000183B02600
	// [XID] // 0x0000000189BA7960-0x0000000189BA7980
	private void UpdateMaterialsList() {} // 0x0000000183B02F80-0x0000000183B03330
	// [XID] // 0x0000000189BAECF0-0x0000000189BAED10
	private void RefreshItemIcon(Transform trans, int index) {} // 0x0000000183B04300-0x0000000183B045F0
	// [XID] // 0x0000000189BB63E0-0x0000000189BB6400
	protected override void BindViewCallbacks() {} // 0x0000000183B02A10-0x0000000183B02C10
	// [XID] // 0x0000000189BBD9E0-0x0000000189BBDA00
	private void OnClickShop() {} // 0x0000000183B02D00-0x0000000183B02E90
	// [XID] // 0x0000000189BC5720-0x0000000189BC5740
	private void OnClickGoto() {} // 0x0000000183B03D60-0x0000000183B03F90
	// [XID] // 0x0000000189BCD140-0x0000000189BCD160
	private void OnClickDesc() {} // 0x0000000183B02680-0x0000000183B02860
	// [XID] // 0x0000000189BD4680-0x0000000189BD46A0
	public override void ClearView() {} // 0x0000000183B02C10-0x0000000183B02D00
	// [XID] // 0x0000000189BDC1F0-0x0000000189BDC210
	protected override void OnEnable() {} // 0x0000000183B04650-0x0000000183B04760
	// [XID] // 0x00000001895E8A30-0x00000001895E8A50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183B03390-0x0000000183B03D00
	// [XID] // 0x00000001895F0280-0x00000001895F02A0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000183B03F90-0x0000000183B04300
}

