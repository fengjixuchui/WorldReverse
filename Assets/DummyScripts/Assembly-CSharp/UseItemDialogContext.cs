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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseItemDialogContext : BaseDialogContext // TypeDefIndex: 29343
{
	// Fields
	private MonoUseItemDialog _dialogMono; // 0x178
	private uint _itemId; // 0x180
	private MaterialGrpWidgetContext _materialWidget; // 0x188

	// Constructors
	public UseItemDialogContext() {} // Dummy constructor
	public UseItemDialogContext(uint itemId) {} // 0x00000001822BF690-0x00000001822BF760

	// Methods
	// [XID] // 0x00000001897E8270-0x00000001897E8290
	public override void SetupView() {} // 0x00000001822BF5B0-0x00000001822BF690
	// [XID] // 0x00000001897EFF90-0x00000001897EFFB0
	public override void ClearView() {} // 0x00000001822BE190-0x00000001822BE240
	// [XID] // 0x00000001897F7720-0x00000001897F7740
	protected override void BindViewCallbacks() {} // 0x00000001822BE000-0x00000001822BE190
	// [XID] // 0x00000001897FEE10-0x00000001897FEE30
	public override bool OnNotify(Notify ntf) => default; // 0x00000001822BF420-0x00000001822BF5B0
	// [XID] // 0x0000000189806590-0x00000001898065B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001822BE6A0-0x00000001822BEBA0
	// [XID] // 0x000000018980DCB0-0x000000018980DCD0
	private void RefreshItemView() {} // 0x00000001822BEBA0-0x00000001822BEF30
	// [XID] // 0x0000000189815430-0x0000000189815450
	private void OnItemSlotClick() {} // 0x00000001822BDDD0-0x00000001822BDEA0
	// [XID] // 0x000000018981CE50-0x000000018981CE70
	private void OnOKBtnClick() {} // 0x00000001822BE330-0x00000001822BE6A0
	// [XID] // 0x0000000189824230-0x0000000189824250
	private uint GetMaxUseCount(ItemConfig itemConfig) => default; // 0x00000001822BF220-0x00000001822BF390
	// [XID] // 0x000000018982BCC0-0x000000018982BCE0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001822BF050-0x00000001822BF1C0
	// [XID] // 0x0000000189833250-0x0000000189833270
	private void SetupShopMaterialWidget() {} // 0x00000001822BDEA0-0x00000001822BE000
	// [XID] // 0x000000018983A700-0x000000018983A720
	private void CloseShopMaterialWidget() {} // 0x00000001822BEF90-0x00000001822BF050
}

