/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemGotBigDialogContext : ItemGotDialogContext // TypeDefIndex: 29179
{
	// Fields
	private string _titleText; // 0x1C0
	private string _reasonText; // 0x1C8
	private string _tipsText; // 0x1D0
	private uint _orderId; // 0x1D8
	private EffectType _effectType; // 0x1DC

	// Properties
	public List<SimpleItemStruct> itemList { /* [XID] */ /* 0x0000000189647120-0x0000000189647140 */ set {} } // 0x0000000184BF9780-0x0000000184BF9830

	// Nested types
	public enum EffectType // TypeDefIndex: 29180
	{
		Default = 0,
		BlessingPhoto = 1,
		ExploreSuccess = 2
	}

	// Constructors
	public ItemGotBigDialogContext() {} // Dummy constructor
	public ItemGotBigDialogContext(List<SimpleItemStruct> itemList, bool showStar = true /* Metadata: 0x00B0ED73 */, string reasonText = null, string bottomTipsText = null, uint orderId = 0 /* Metadata: 0x00B0ED74 */, EffectType effectType = EffectType.Default /* Metadata: 0x00B0ED78 */) {} // 0x0000000184BFA840-0x0000000184BFA970
	public ItemGotBigDialogContext(string titleText = null, string reasonText = null, string bottomTipsText = null, uint orderId = 0 /* Metadata: 0x00B0ED7C */, bool showBonusTips = false /* Metadata: 0x00B0ED80 */, bool showStar = true /* Metadata: 0x00B0ED81 */, EffectType effectType = EffectType.Default /* Metadata: 0x00B0ED82 */, List<SimpleItemStruct> itemList = null, List<SimpleItemStruct> bonusList = null) {} // 0x0000000184BFA970-0x0000000184BFAAC0

	// Methods
	// [XID] // 0x000000018964E7F0-0x000000018964E810
	public override void SetupView() {} // 0x0000000184BFA3F0-0x0000000184BFA840
	// [XID] // 0x0000000189655FE0-0x0000000189656000
	public override void ClearView() {} // 0x0000000184BF9A20-0x0000000184BF9AD0
	// [XID] // 0x000000018965D7C0-0x000000018965D7E0
	protected override void BindViewCallbacks() {} // 0x0000000184BF9830-0x0000000184BF9A20
	// [XID] // 0x0000000189664EE0-0x0000000189664F00
	public override void CloseDialog() {} // 0x0000000184BF9B30-0x0000000184BF9C20
	// [XID] // 0x000000018966C520-0x000000018966C540
	protected override void OnEnable() {} // 0x0000000184BFA350-0x0000000184BFA3F0
	// [XID] // 0x00000001896743C0-0x00000001896743E0
	private void SetupItemGotEffect() {} // 0x0000000184BF9620-0x0000000184BF9780
	// [XID] // 0x000000018967BBA0-0x000000018967BBC0
	private void ReleaseItemGotEffect() {} // 0x0000000184BFA130-0x0000000184BFA290
	// [XID] // 0x0000000189683290-0x00000001896832B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184BF9D10-0x0000000184BFA0D0
}

