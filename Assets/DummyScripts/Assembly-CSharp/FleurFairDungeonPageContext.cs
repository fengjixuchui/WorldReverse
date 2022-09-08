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

public sealed class FleurFairDungeonPageContext : BasePageContext // TypeDefIndex: 30069
{
	// Fields
	private MonoFleurFairDungeonPage _pageMono; // 0x190
	private ActivityInfo _activityInfo; // 0x198
	private int _lastTabIndex; // 0x1A0
	private const uint _questId = 7065601; // Metadata: 0x00B107C8
	private const uint _pointId = 265; // Metadata: 0x00B107CC
	private bool _isOpen; // 0x1A4
	private List<uint> _watcherList; // 0x1A8
	private List<FleurFairDungeonSectionInfo> _fleurFairDungeonSectionInfo; // 0x1B0
	private List<RewardItemConfig> _tempRewardList; // 0x1B8

	// Constructors
	public FleurFairDungeonPageContext() {} // 0x0000000183501FE0-0x00000001835020A0

	// Methods
	// [XID] // 0x0000000189638400-0x0000000189638420
	public override void SetupView() {} // 0x0000000183501EE0-0x0000000183501FE0
	// [XID] // 0x000000018963F840-0x000000018963F860
	public override void ClearView() {} // 0x00000001834FF210-0x00000001834FF2E0
	// [XID] // 0x0000000189647080-0x00000001896470A0
	protected override void BindViewCallbacks() {} // 0x00000001834FED00-0x00000001834FEF80
	// [XID] // 0x000000018964E790-0x000000018964E7B0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183501B50-0x0000000183501CF0
	// [XID] // 0x0000000189655FA0-0x0000000189655FC0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000183501410-0x0000000183501510
	// [XID] // 0x000000018965D760-0x000000018965D780
	protected override void OnEnable() {} // 0x0000000183501990-0x0000000183501A40
	// [XID] // 0x0000000189664E80-0x0000000189664EA0
	private void CheckPreviewRedPoint() {} // 0x0000000183501270-0x0000000183501410
	// [XID] // 0x000000018966C4C0-0x000000018966C4E0
	private void RefreshView(int tabIndex) {} // 0x00000001834FFEA0-0x0000000183500A70
	// [XID] // 0x0000000189674380-0x00000001896743A0
	private int SourtFunc(FleurFairDungeonSectionInfo a, FleurFairDungeonSectionInfo b) => default; // 0x00000001834FF100-0x00000001834FF210
	// [XID] // 0x000000018967BB00-0x000000018967BB20
	private void RefreshTabItem(Transform trans, int index) {} // 0x00000001834FF630-0x00000001834FFBF0
	// [XID] // 0x0000000189683210-0x0000000189683230
	private void SetTabState(int index, bool selected) {} // 0x00000001834FEF80-0x00000001834FF100
	// [XID] // 0x000000018968ACC0-0x000000018968ACE0
	private void OnTabButton(int tabIndex) {} // 0x0000000183500AD0-0x0000000183501270
	// [XID] // 0x00000001896929C0-0x00000001896929E0
	private ActivityWatcherInfo GetWatcherInfo(uint watcherId) => default; // 0x0000000183501CF0-0x0000000183501EE0
	// [XID] // 0x0000000189699D60-0x0000000189699D80
	private void RefreshRewardRow(Transform trans, int index) {} // 0x00000001834FE550-0x00000001834FED00
	// [XID] // 0x00000001896A1480-0x00000001896A14A0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001834FF2E0-0x00000001834FF530
	// [XID] // 0x00000001896A8960-0x00000001896A8980
	private void OnBtnGotoClick() {} // 0x00000001834FFBF0-0x00000001834FFE40
	// [XID] // 0x00000001896AFAE0-0x00000001896AFB00
	private void OnBtnTipClick() {} // 0x00000001834FE3E0-0x00000001834FE550
	// [XID] // 0x00000001896B7450-0x00000001896B7470
	private void OnBtnPreviewClick() {} // 0x0000000183501510-0x0000000183501680
	// [XID] // 0x00000001896BE580-0x00000001896BE5A0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B107C4 */) {} // 0x0000000183501A40-0x0000000183501B50
	// [XID] // 0x00000001896C5DB0-0x00000001896C5DD0
	private void CheckGetRewardButton() {} // 0x00000001835016E0-0x0000000183501900
}

