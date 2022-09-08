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

public sealed class LCWidget : LCBase // TypeDefIndex: 11776
{
	// Fields
	private Dictionary<WidgetSlotTag, QuickWidgetBase> _slot; // 0x130
	private Dictionary<uint, uint> _waitDoBagResultDict; // 0x138
	private Dictionary<uint, uint> _waitDoActionPanelResultDict; // 0x140
	private bool[] _buttonFlags; // 0x148

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189618120-0x0000000189618140 */ get => default; } // 0x00000001826FCBA0-0x00000001826FCC40 
	public bool[] ButtonFlags { /* [XID] */ /* 0x000000018968D450-0x000000018968D470 */ get => default; } // 0x00000001826FB4E0-0x00000001826FB590 
	public WidgetActionButtonState CurrentActionPanelState { /* [XID] */ /* 0x0000000189695020-0x0000000189695060 */ get; /* [XID] */ /* 0x000000018969F5A0-0x000000018969F5E0 */ set; } // 0x00000001826FB910-0x00000001826FB970 0x00000001826FB590-0x00000001826FB600

	// Nested types
	public enum ActionPanelCmd // TypeDefIndex: 11777
	{
		RefreshAll = 0,
		RefreshNum = 1,
		Count = 2
	}

	// Constructors
	public LCWidget() {} // 0x00000001826FCA60-0x00000001826FCBA0

	// Methods
	// [XID] // 0x0000000189615350-0x0000000189615370
	private void FetchCurrentSlot() {} // 0x00000001826FBE30-0x00000001826FC0B0
	// [XID] // 0x000000018961CAA0-0x000000018961CAC0
	public void SetSlot(WidgetSlotTag tag, uint materialId, WidgetSlotOp operation) {} // 0x00000001826FC420-0x00000001826FC740
	// [XID] // 0x0000000189640910-0x0000000189640930
	public override void Init() {} // 0x00000001826FB970-0x00000001826FBA10
	// [XID] // 0x000000018962B730-0x000000018962B750
	public override void OnEntityReady() {} // 0x00000001826FC740-0x00000001826FC7E0
	// [XID] // 0x0000000189632F50-0x0000000189632F70
	public override void Destroy() {} // 0x00000001826FA9B0-0x00000001826FAA50
	// [XID] // 0x000000018963AA70-0x000000018963AA90
	protected override void Tick(float inDeltaTime) {} // 0x00000001826FC890-0x00000001826FCA60
	// [XID] // 0x0000000189642170-0x0000000189642190
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001826FC7E0-0x00000001826FC890
	// [XID] // 0x0000000189649940-0x0000000189649960
	public override bool IsActive() => default; // 0x00000001826FBA10-0x00000001826FBAF0
	// [XID] // 0x0000000189651060-0x0000000189651080
	public bool OnNotify(Notify ntf) => default; // 0x00000001826FACE0-0x00000001826FAF00
	// [XID] // 0x00000001896587D0-0x00000001896587F0
	public QuickWidgetBase GetCurrentEquippedWidget() => default; // 0x00000001826FA3E0-0x00000001826FA4F0
	// [XID] // 0x000000018965FDE0-0x000000018965FE00
	public QuickWidgetBase GetCurrentAttachAvatarWidget() => default; // 0x00000001826FBC40-0x00000001826FBD50
	// [XID] // 0x0000000189667900-0x0000000189667920
	public bool DoBag(uint materialId) => default; // 0x00000001826FA4F0-0x00000001826FA770
	// [XID] // 0x000000018966F100-0x000000018966F120
	public bool DoActionPanel() => default; // 0x00000001826FAA50-0x00000001826FACE0
	// [XID] // 0x0000000189676A70-0x0000000189676A90
	public void ForceUnEquip() {} // 0x00000001826FC250-0x00000001826FC420
	// [XID] // 0x000000018967E300-0x000000018967E320
	public void OnDoBagAttachResponse(uint materialId, bool success, WidgetSlotOp op) {} // 0x00000001826FB600-0x00000001826FB800
	// [XID] // 0x0000000189685A90-0x0000000189685AB0
	public void OnActionPanelResponse(uint materialId, bool success, object additionalPara = null) {} // 0x00000001826FB170-0x00000001826FB420
	// [XID] // 0x00000001896A9AC0-0x00000001896A9AE0
	public void SetCurrentActionPanel(WidgetActionButtonState type) {} // 0x00000001826FB010-0x00000001826FB0F0
	// [XID] // 0x00000001896B0A80-0x00000001896B0AA0
	public void AddActionPanelCmd(ActionPanelCmd cmd) {} // 0x00000001826FB800-0x00000001826FB910
	// [XID] // 0x00000001896B8550-0x00000001896B8570
	public void ClearFlag() {} // 0x00000001826FA7E0-0x00000001826FA8E0
	// [XID] // 0x00000001896BF600-0x00000001896BF620
	public void SetActionPanelNumGrp(GameObject numGrp, SimpleText text) {} // 0x00000001826FBAF0-0x00000001826FBBE0
	// [XID] // 0x00000001897721D0-0x00000001897721F0
	public BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x00000001826FB420-0x00000001826FB4E0
	// [XID] // 0x00000001896CE660-0x00000001896CE680
	public void TickActionPanel(MonoQuickUseButton monoButton) {} // 0x00000001826FA8E0-0x00000001826FA9B0
	// [XID] // 0x00000001896D5B50-0x00000001896D5B70
	public bool CheckQuickUseButtonShouldShow(ActionPanelState state) => default; // 0x00000001826FBD50-0x00000001826FBE30
	// [XID] // 0x00000001896DD010-0x00000001896DD030
	public string GetBagPageButtonText(uint materialId) => default; // 0x00000001826FAF00-0x00000001826FB010
	// [XID] // 0x00000001896E49D0-0x00000001896E49F0
	public void InitButtonGrp(MonoQuickUseButton button) {} // 0x00000001826FC0B0-0x00000001826FC180
}

