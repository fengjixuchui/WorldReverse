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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class QuickWidgetBase // TypeDefIndex: 31364
{
	// Fields
	private List<WidgetSlotTag> _slotTags; // 0x20

	// Properties
	public uint MaterialId { /* [XID] */ /* 0x00000001897350D0-0x0000000189735110 */ get; /* [XID] */ /* 0x0000000189740070-0x00000001897400B0 */ private set; } // 0x000000018339EF80-0x000000018339EFE0 0x000000018339EFE0-0x000000018339F040
	public ConfigBaseWidgetToy JsonConfig { /* [XID] */ /* 0x000000018974A680-0x000000018974A6C0 */ get; /* [XID] */ /* 0x0000000189754BF0-0x0000000189754C30 */ private set; } // 0x000000018339F5D0-0x000000018339F630 0x000000018339EF20-0x000000018339EF80
	public List<WidgetSlotTag> SlotTags { /* [XID] */ /* 0x000000018975F190-0x000000018975F1B0 */ get; } // 0x000000018339F630-0x000000018339F6D0 

	// Constructors
	protected QuickWidgetBase() {} // 0x000000018339F880-0x000000018339F910

	// Methods
	// [XID] // 0x00000001897665B0-0x00000001897665D0
	protected virtual void Build(uint materialId, ConfigBaseWidgetToy baseConfig) {} // 0x000000018339E620-0x000000018339E6E0
	// [XID] // 0x000000018976DC70-0x000000018976DC90
	public virtual void InitOnAttach(WidgetSlotTag tag) {} // 0x000000018339F6D0-0x000000018339F7B0
	// [XID] // 0x00000001897753A0-0x00000001897753C0
	public virtual void ClearOnUnAttach(WidgetSlotTag tag) {} // 0x000000018339E970-0x000000018339EA50
	// [XID] // 0x000000018977CC10-0x000000018977CC30
	public virtual string GetBagPageButtonText(LCWidget lcWidget) => default; // 0x000000018339E7B0-0x000000018339E8C0
	// [XID] // 0x0000000189784650-0x0000000189784670
	public virtual LCWidgetBagActionPara DoBag(LCWidget lcWidget) => default; // 0x000000018339DC30-0x000000018339DD00
	// [XID] // 0x000000018978BC40-0x000000018978BC60
	public virtual void DoBagPostAction(LCWidget lcWidget, bool success, WidgetSlotOp op) {} // 0x000000018339F7B0-0x000000018339F880
	// [XID] // 0x00000001897930F0-0x0000000189793110
	public virtual LCWidgetButtonActionPara DoActionPanel(LCWidget lcWidget) => default; // 0x000000018339E4D0-0x000000018339E620
	// [XID] // 0x000000018979B3A0-0x000000018979B3C0
	public virtual void DoActionPanelPostAction(LCWidget lcWidget, bool success, object additionalPara = null) {} // 0x000000018339F500-0x000000018339F5D0
	// [XID] // 0x00000001897A2840-0x00000001897A2860
	public virtual void Tick(float inDeltaTime) {} // 0x000000018339E8C0-0x000000018339E970
	// [XID] // 0x00000001897A9D80-0x00000001897A9DA0
	public virtual bool OnNotify(Notify ntf) => default; // 0x000000018339E6E0-0x000000018339E7B0
	// [XID] // 0x00000001897B1770-0x00000001897B1790
	public virtual bool OnEvent(BaseEvent evt) => default; // 0x000000018339F270-0x000000018339F320
	// [XID] // 0x00000001897B91A0-0x00000001897B91C0
	public virtual void InitButtonGrp(MonoQuickUseButton button) {} // 0x000000018339F320-0x000000018339F500
	// [XID] // 0x00000001897C12C0-0x00000001897C12E0
	public virtual void GetActionPanelNumGrp(GameObject numGrp, SimpleText text) {} // 0x000000018339ECE0-0x000000018339EF20
	// [XID] // 0x000000018976ABD0-0x000000018976ABF0
	public virtual BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x000000018339EB50-0x000000018339EC20
	// [XID] // 0x00000001897D0340-0x00000001897D0360
	public virtual void TickActionPanel(MonoQuickUseButton monoButton) {} // 0x000000018339E420-0x000000018339E4D0
	// [XID] // 0x00000001897D7FE0-0x00000001897D8000
	public virtual bool ShouldActionButtonShow(ActionPanelState state) => default; // 0x000000018339EA50-0x000000018339EB50
	// [XID] // 0x00000001897DF120-0x00000001897DF140
	public bool CanBeEquipped() => default; // 0x000000018339EC20-0x000000018339ECE0
	// [XID] // 0x00000001897E6A20-0x00000001897E6A40
	public void BuildConfig(uint materialId, ConfigBaseWidgetToy baseConfig) {} // 0x000000018339F040-0x000000018339F270
	// [XID] // 0x00000001897EE550-0x00000001897EE570
	protected bool GeneralCheck(uint materialId) => default; // 0x000000018339DD00-0x000000018339E420
}

