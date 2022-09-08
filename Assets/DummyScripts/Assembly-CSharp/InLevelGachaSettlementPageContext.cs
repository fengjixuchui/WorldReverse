/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelGachaSettlementPageContext : BasePageContext, IGachaConversionParent // TypeDefIndex: 29805
{
	// Fields
	private MonoInLevelGachaSettlementPage _pageMono; // 0x190
	private bool _isShowTime; // 0x198
	public ShowType type; // 0x19C
	public int showIndex; // 0x1A0
	public bool isAfterCutscene; // 0x1A4
	private int showButton; // 0x1A8
	private ulong curInitTime; // 0x1B0
	private List<MonoGachaItemSlot> _gachaItemSlots; // 0x1B8
	private List<MonoGachaItemPoster> _gachaPosterSlots; // 0x1C0
	private Coroutine _showItemCoroutine; // 0x1C8
	private int _currItemIndex; // 0x1D0
	private List<SimpleItemStruct> _cacheTransItems; // 0x1D8
	private InLevelGachaGroupContext _gachaContext; // 0x1E0
	private RenderTexture _savedImageTexture; // 0x1E8

	// Nested types
	public enum ShowType // TypeDefIndex: 29806
	{
		Mode3D = 0,
		Mode2D_Once_Settle = 1,
		Mode2D_Ten_One = 2,
		Mode2D_Ten_Settle = 3
	}

	// Constructors
	public InLevelGachaSettlementPageContext() {} // Dummy constructor
	public InLevelGachaSettlementPageContext(InLevelGachaGroupContext gachaContext) {} // 0x00000001849E2350-0x00000001849E24D0

	// Methods
	// [XID] // 0x0000000189913ED0-0x0000000189913EF0
	public override void SetupView() {} // 0x00000001849E2270-0x00000001849E2350
	// [XID] // 0x000000018991B8C0-0x000000018991B8E0
	public void Refresh() {} // 0x00000001849DC740-0x00000001849DCC20
	// [XID] // 0x0000000189922E40-0x0000000189922E60
	public override void ClearView() {} // 0x00000001849DD5F0-0x00000001849DD730
	// [XID] // 0x000000018992A6F0-0x000000018992A710
	protected override void BindViewCallbacks() {} // 0x00000001849DCF80-0x00000001849DD130
	// [XID] // 0x0000000189931CA0-0x0000000189931CC0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001849E18E0-0x00000001849E1A50
	// [XID] // 0x00000001899396E0-0x0000000189939700
	public void ShowOneItem(int index, bool isSettle) {} // 0x00000001849DF5C0-0x00000001849DFA60
	// [XID] // 0x0000000189940970-0x0000000189940990
	private void NextItem() {} // 0x00000001849DF450-0x00000001849DF5C0
	// [XID] // 0x00000001899482B0-0x00000001899482D0
	private void SkipItem() {} // 0x00000001849DD4D0-0x00000001849DD5F0
	// [XID] // 0x000000018994F9B0-0x000000018994F9D0
	private bool IsAvatarItem(uint itemId) => default; // 0x00000001849E0C90-0x00000001849E0DF0
	// [XID] // 0x0000000189956FB0-0x0000000189956FD0
	private int CompareGachaItem(GachaItem item1, GachaItem item2) => default; // 0x00000001849DCD30-0x00000001849DCF80
	// [XID] // 0x000000018995EAE0-0x000000018995EB00
	private int CompareSimpleGachaItem(SimpleItemStruct item1, SimpleItemStruct item2) => default; // 0x00000001849E14C0-0x00000001849E15D0
	// [XID] // 0x0000000189966220-0x0000000189966240
	public void ShowAllItems() {} // 0x00000001849DDE60-0x00000001849DE880
	// [XID] // 0x000000018996D6C0-0x000000018996D6E0
	private void InitItems() {} // 0x00000001849E09E0-0x00000001849E0C90
	// [XID] // 0x0000000189975260-0x0000000189975280
	private void ShowConversion() {} // 0x00000001849E1A50-0x00000001849E1D20
	// [XID] // 0x000000018997C3E0-0x000000018997C400
	public void ShowConversionDlg() {} // 0x00000001849E15D0-0x00000001849E1740
	// [XID] // 0x0000000189984100-0x0000000189984120
	public void HideConversionDlg() {} // 0x00000001849DECC0-0x00000001849DEE30
	// [XID] // 0x000000018998BCB0-0x000000018998BCD0
	public override void SetActive(bool enabled) {} // 0x00000001849E1D20-0x00000001849E2270
	[DebuggerHidden] // 0x0000000189993860-0x00000001899938A0
	// [XID] // 0x0000000189993860-0x00000001899938A0
	private IEnumerator ShowPoster() => default; // 0x00000001849DCC20-0x00000001849DCD30
	[DebuggerHidden] // 0x000000018999E1D0-0x000000018999E210
	// [XID] // 0x000000018999E1D0-0x000000018999E210
	private IEnumerator ShowItems() => default; // 0x00000001849E1740-0x00000001849E1850
	// [XID] // 0x00000001899A8C10-0x00000001899A8C30
	public void BackPage() {} // 0x00000001849E08B0-0x00000001849E09E0
	// [XID] // 0x00000001899B0530-0x00000001899B0550
	private void ShowTransItems() {} // 0x00000001849DD130-0x00000001849DD260
	// [XID] // 0x00000001899B7860-0x00000001899B7880
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001849E0700-0x00000001849E0850
	// [XID] // 0x00000001899BF200-0x00000001899BF220
	private bool HandleOnePassItemInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001849DFA60-0x00000001849DFC40
	// [XID] // 0x00000001899C6C00-0x00000001899C6C20
	private bool HandleOneItemInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001849DD8C0-0x00000001849DDE60
	// [XID] // 0x00000001899CE140-0x00000001899CE160
	private bool HandleAllItemsInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001849DFCA0-0x00000001849E0700
	// [XID] // 0x00000001899D5920-0x00000001899D5940
	private void RefreshCurrentPosterItem(MonoGachaItemPoster slot, bool prev) {} // 0x00000001849E0F40-0x00000001849E1260
	// [XID] // 0x00000001899DCC30-0x00000001899DCC50
	private void RefreshCurrentItem(MonoGachaItemSlot slot, bool prev) {} // 0x00000001849DE880-0x00000001849DEB70
	// [XID] // 0x00000001899E4870-0x00000001899E4890
	private void ClearCurrentItem(MonoGridScroller scroller) {} // 0x00000001849DF1E0-0x00000001849DF450
	// [XID] // 0x00000001899EBC60-0x00000001899EBC80
	private void RefreshScrollSelectState(RectTransform trans, bool selected) {} // 0x00000001849DD730-0x00000001849DD8C0
	// [XID] // 0x00000001899F3730-0x00000001899F3750
	private bool Is4or5Star(int showIndex) => default; // 0x00000001849DEB70-0x00000001849DECC0
	// [XID] // 0x00000001899FB050-0x00000001899FB070
	private void ShowSharePanel(bool show) {} // 0x00000001849E1260-0x00000001849E1460
	// [XID] // 0x0000000189A022A0-0x0000000189A022C0
	private void TakePhotograph() {} // 0x00000001849DD3D0-0x00000001849DD4D0
	// [XID] // 0x0000000189A09A90-0x0000000189A09AB0
	private void OnTakePhotograph() {} // 0x00000001849DEF40-0x00000001849DF1E0
	// [XID] // 0x0000000189A11230-0x0000000189A11250
	private void ShowMarks(bool show) {} // 0x00000001849DD260-0x00000001849DD3D0
	// [XID] // 0x0000000189A18600-0x0000000189A18620
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001849E0DF0-0x00000001849E0F40
}

