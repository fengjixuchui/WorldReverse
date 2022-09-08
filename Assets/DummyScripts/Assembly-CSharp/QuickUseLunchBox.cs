/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseLunchBox : QuickWidgetBase // TypeDefIndex: 31356
{
	// Fields
	private ConfigWidgetLunchBox _oldJsonConfig; // 0x28
	private LCWidget _lcWidget; // 0x30
	private DateTime _curTime; // 0x38
	private DateTime _targetTime; // 0x48
	private bool _shouldRefresh; // 0x58
	private WidgetSystemModule.LunchBoxType _currentState; // 0x5C

	// Properties
	private static string OLD_JSON_CONFIG_PATH { /* [XID] */ /* 0x0000000189A96070-0x0000000189A96090 */ get => default; } // 0x0000000182A00ED0-0x0000000182A00F70 
	private BagItemSlot curHpMaterial { /* [XID] */ /* 0x0000000189AA4DE0-0x0000000189AA4E00 */ get => default; } // 0x0000000182A02C70-0x0000000182A02D50 
	private BagItemSlot curReviveMaterial { /* [XID] */ /* 0x0000000189AAC670-0x0000000189AAC690 */ get => default; } // 0x0000000182A03090-0x0000000182A03170 
	private uint curHpMaterialId { /* [XID] */ /* 0x0000000189AB3E50-0x0000000189AB3E70 */ get => default; } // 0x0000000182A02B90-0x0000000182A02C70 
	private uint curReviveMaterialId { /* [XID] */ /* 0x0000000189ABBBB0-0x0000000189ABBBD0 */ get => default; } // 0x0000000182A02AB0-0x0000000182A02B90 
	private WidgetSystemModule.LunchBoxType currentState { /* [XID] */ /* 0x0000000189AF0DC0-0x0000000189AF0DE0 */ get => default; /* [XID] */ /* 0x0000000189AF82D0-0x0000000189AF82F0 */ set {} } // 0x0000000182A02D50-0x0000000182A02DF0 0x0000000182A00E20-0x0000000182A00ED0

	// Constructors
	public QuickUseLunchBox() {} // 0x0000000182A03650-0x0000000182A03710

	// Methods
	// [XID] // 0x0000000189A9D5C0-0x0000000189A9D5E0
	protected override void Build(uint materialId, ConfigBaseWidgetToy baseConfig) {} // 0x0000000182A013A0-0x0000000182A019D0
	// [XID] // 0x0000000189AC3320-0x0000000189AC3340
	public override LCWidgetBagActionPara DoBag(LCWidget lcWidget) => default; // 0x0000000182A00BA0-0x0000000182A00E20
	// [XID] // 0x0000000189ACAA60-0x0000000189ACAA80
	public override void DoBagPostAction(LCWidget lcWidget, bool success, WidgetSlotOp op) {} // 0x0000000182A03270-0x0000000182A03350
	// [XID] // 0x0000000189AD24A0-0x0000000189AD24C0
	public override void InitOnAttach(WidgetSlotTag tag) {} // 0x0000000182A03170-0x0000000182A03270
	// [XID] // 0x0000000189AD9F70-0x0000000189AD9F90
	public override LCWidgetButtonActionPara DoActionPanel(LCWidget lcWidget) => default; // 0x0000000182A011E0-0x0000000182A013A0
	// [XID] // 0x0000000189AE18B0-0x0000000189AE18D0
	public override void Tick(float inDeltaTime) {} // 0x0000000182A01AD0-0x0000000182A01BA0
	// [XID] // 0x0000000189AE9060-0x0000000189AE9080
	public override void TickActionPanel(MonoQuickUseButton monoButton) {} // 0x0000000182A00F70-0x0000000182A010E0
	// [XID] // 0x0000000189AFF9C0-0x0000000189AFF9E0
	public override BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x0000000182A020C0-0x0000000182A02180
	// [XID] // 0x0000000189B06F90-0x0000000189B06FB0
	public override void InitButtonGrp(MonoQuickUseButton button) {} // 0x0000000182A02F00-0x0000000182A03090
	// [XID] // 0x0000000189B0E790-0x0000000189B0E7B0
	public override void GetActionPanelNumGrp(GameObject numGrp, SimpleText text) {} // 0x0000000182A02340-0x0000000182A02580
	// [XID] // 0x0000000189B15B70-0x0000000189B15B90
	public override string GetBagPageButtonText(LCWidget lcWidget) => default; // 0x0000000182A019D0-0x0000000182A01AD0
	// [XID] // 0x0000000189B1D2B0-0x0000000189B1D2D0
	private void CheckLunchBoxShowState() {} // 0x0000000182A03350-0x0000000182A03650
	// [XID] // 0x0000000189B24AD0-0x0000000189B24AF0
	private bool TryUseHpLunchBox() => default; // 0x0000000182A02580-0x0000000182A02AB0
	// [XID] // 0x0000000189B2BF80-0x0000000189B2BFA0
	private bool TryUseReviveLunchBox() => default; // 0x0000000182A01C20-0x0000000182A020C0
}

