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

public sealed class InLevelPlayerLevelPageContext : BasePageContext // TypeDefIndex: 29923
{
	// Fields
	private MonoInLevelPlayerLevelPage _pageMono; // 0x190
	private int _playerLevel; // 0x198
	private int _selectIndex; // 0x19C
	private Dictionary<uint, int> _gotRewardLevelDic; // 0x1A0
	private List<LevelRewardStruct> _rewardList; // 0x1A8
	private bool _showOnly; // 0x1B0
	private int _currRewardIndex; // 0x1B4
	private static readonly string[] _separators; // 0x00
	private static readonly string[] _childSep; // 0x08
	private List<GameObject> _validChildren; // 0x1B8
	private uint _lastClickedTime; // 0x1C0

	// Nested types
	public struct LevelRewardStruct // TypeDefIndex: 29924
	{
		// Fields
		public uint id; // 0x00
		public bool isQuest; // 0x04
	}

	// Constructors
	public InLevelPlayerLevelPageContext() {} // Dummy constructor
	public InLevelPlayerLevelPageContext(bool showOnly) {} // 0x0000000182E7C180-0x0000000182E7C2A0
	static InLevelPlayerLevelPageContext() {} // 0x0000000182E7C010-0x0000000182E7C180

	// Methods
	// [XID] // 0x000000018974A850-0x000000018974A870
	public override void SetupView() {} // 0x0000000182E7BE40-0x0000000182E7C010
	// [XID] // 0x0000000189751950-0x0000000189751970
	public override void ClearView() {} // 0x0000000182E782B0-0x0000000182E783C0
	// [XID] // 0x0000000189758F60-0x0000000189758F80
	protected override void BindViewCallbacks() {} // 0x0000000182E77AA0-0x0000000182E77CA0
	// [XID] // 0x0000000189760BD0-0x0000000189760BF0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182E7BD40-0x0000000182E7BE40
	// [XID] // 0x0000000189767E70-0x0000000189767E90
	private void RefreshRewardView() {} // 0x0000000182E7AF20-0x0000000182E7B0B0
	// [XID] // 0x000000018976F460-0x000000018976F480
	private void RefreshPlayerLevelRewardList() {} // 0x0000000182E77700-0x0000000182E77AA0
	// [XID] // 0x0000000189776EA0-0x0000000189776EC0
	private int GetFirstShowIndex() => default; // 0x0000000182E79DD0-0x0000000182E79F60
	// [XID] // 0x000000018977E560-0x000000018977E580
	private void RefreshPlayerLevelSlot(Transform trans, int index) {} // 0x0000000182E77CA0-0x0000000182E781B0
	// [XID] // 0x0000000189785CD0-0x0000000189785CF0
	private void OnPlayerLevelSlotClick(int index) {} // 0x0000000182E786C0-0x0000000182E79CB0
	// [XID] // 0x000000018978D3F0-0x000000018978D410
	private void DestoryValidChildren() {} // 0x0000000182E79CB0-0x0000000182E79DD0
	// [XID] // 0x0000000189794770-0x0000000189794790
	private void SetButtonStyle(LevelRewardStruct levelStruct) {} // 0x0000000182E7A630-0x0000000182E7AD60
	// [XID] // 0x000000018979CC00-0x000000018979CC20
	private void OnLevelSlotInShowRange(Transform trans, float value) {} // 0x0000000182E7B0B0-0x0000000182E7B260
	// [XID] // 0x00000001897A4060-0x00000001897A4080
	private void OnFetchBtnClick() {} // 0x0000000182E7BB60-0x0000000182E7BD40
	// [XID] // 0x00000001897AB5C0-0x00000001897AB5E0
	private void OnGotoBtnClick() {} // 0x0000000182E7B260-0x0000000182E7B670
	// [XID] // 0x00000001897B3410-0x00000001897B3430
	private void OnItemAddedNotify(List<SimpleItemStruct> itemList) {} // 0x0000000182E781B0-0x0000000182E782B0
	// [XID] // 0x00000001897BB2F0-0x00000001897BB310
	private void OnCurrRewardClick() {} // 0x0000000182E7A3F0-0x0000000182E7A630
	// [XID] // 0x00000001897C2AD0-0x00000001897C2AF0
	private void ClearRewardSelected(int index) {} // 0x0000000182E7B8F0-0x0000000182E7BAD0
	// [XID] // 0x00000001897CA310-0x00000001897CA330
	private void IterateReward(bool left) {} // 0x0000000182E783C0-0x0000000182E786C0
	// [XID] // 0x00000001897D1970-0x00000001897D1990
	private bool CanScrollTip(Vector2 delta) => default; // 0x0000000182E7AD60-0x0000000182E7AF20
	// [XID] // 0x00000001897D9790-0x00000001897D97B0
	private void ScrollContext(InputActionEvent actionEvent) {} // 0x0000000182E7B670-0x0000000182E7B890
	// [XID] // 0x00000001897E0B50-0x00000001897E0B70
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182E7A050-0x0000000182E7A390
}

