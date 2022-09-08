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

public sealed class HideandSeekPreviewDialogContext : BaseDialogContext // TypeDefIndex: 30112
{
	// Fields
	private FocusNavType _focusRegion; // 0x178
	private MonoHideandSeekPreviewDialog _pageMono; // 0x180
	private SimpleSafeUInt32[] _openMapList; // 0x188
	private SimpleSafeUInt32[] _chanllengeList; // 0x190
	private ActivityInfo activityInfo; // 0x198
	private ActivityHideAndSeekBasicConfig _config; // 0x1A0
	private List<MonoBtnTab> _pageTabList; // 0x1A8
	private ItemConfig itemConfig; // 0x1B0
	private int TAB_COUNT; // 0x1B8

	// Nested types
	private enum FocusNavType // TypeDefIndex: 30113
	{
		Left = 0,
		Right = 1
	}

	// Constructors
	public HideandSeekPreviewDialogContext() {} // 0x0000000181EDDB30-0x0000000181EDDC50

	// Methods
	// [XID] // 0x00000001897FC1D0-0x00000001897FC1F0
	public override void SetupView() {} // 0x0000000181EDDA50-0x0000000181EDDB30
	// [XID] // 0x00000001898036B0-0x00000001898036D0
	public override void ClearView() {} // 0x0000000181EDBA20-0x0000000181EDBAD0
	// [XID] // 0x000000018980AC60-0x000000018980AC80
	protected override void BindViewCallbacks() {} // 0x0000000181EDB910-0x0000000181EDBA20
	// [XID] // 0x0000000189812210-0x0000000189812230
	private void OnClickReturn() {} // 0x0000000181EDD970-0x0000000181EDDA50
	// [XID] // 0x0000000189819E20-0x0000000189819E40
	private void Refresh(bool setup) {} // 0x0000000181EDB600-0x0000000181EDB7B0
	// [XID] // 0x0000000189821620-0x0000000189821640
	private void SetupTabList() {} // 0x0000000181EDD850-0x0000000181EDD970
	// [XID] // 0x0000000189828C10-0x0000000189828C30
	private void RefreshTabItems(Transform trans, int index) {} // 0x0000000181EDC440-0x0000000181EDC650
	// [XID] // 0x0000000189830080-0x00000001898300A0
	private void OnClickTabMap(int index) {} // 0x0000000181EDBC30-0x0000000181EDBD60
	// [XID] // 0x0000000189837800-0x0000000189837820
	private void OnClickTabChallenge(int index) {} // 0x0000000181EDC2F0-0x0000000181EDC440
	// [XID] // 0x000000018983EED0-0x000000018983EEF0
	private void SetImageTabState(int index) {} // 0x0000000181EDCB30-0x0000000181EDCC80
	// [XID] // 0x00000001898464F0-0x0000000189846510
	private void UpdateTabArrow() {} // 0x0000000181EDB7B0-0x0000000181EDB910
	// [XID] // 0x000000018984DAE0-0x000000018984DB00
	private void RefreshMapScroller() {} // 0x0000000181EDC650-0x0000000181EDC8B0
	// [XID] // 0x0000000189854B80-0x0000000189854BA0
	private void RefreshScrollSelectState(RectTransform trans, bool selected) {} // 0x0000000181EDBAD0-0x0000000181EDBC30
	// [XID] // 0x000000018985C3E0-0x000000018985C400
	private void RefreshMapItems(Transform trans, int index) {} // 0x0000000181EDCEE0-0x0000000181EDD1C0
	// [XID] // 0x0000000189863D20-0x0000000189863D40
	private void OnClickMap(uint mapID) {} // 0x0000000181EDCC80-0x0000000181EDCE80
	// [XID] // 0x000000018986B030-0x000000018986B050
	private void RefreshChanllengeScroller() {} // 0x0000000181EDBF10-0x0000000181EDC050
	// [XID] // 0x0000000189872400-0x0000000189872420
	private void RefreshChanlleageItems(Transform trans, int index) {} // 0x0000000181EDC8B0-0x0000000181EDCB30
	// [XID] // 0x000000018987A010-0x000000018987A030
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B107F8 */) {} // 0x0000000181EDD660-0x0000000181EDD850
	// [XID] // 0x0000000189881190-0x00000001898811B0
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000181EDD1C0-0x0000000181EDD660
	// [XID] // 0x0000000189888780-0x00000001898887A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181EDC0B0-0x0000000181EDC290
}

