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

public sealed class QuestRewardDialogContext : BaseDialogContext // TypeDefIndex: 29244
{
	// Fields
	private MonoQuestRewardDialog _dialogMono; // 0x178
	private ItemGetReason _itemGetReason; // 0x180
	private List<SimpleItemStruct> _itemList; // 0x188
	private Queue<MonoSimpleItem> _itemFadeInQueue; // 0x190
	private Queue<MonoSimpleItem> _itemFadeOutQueue; // 0x198
	private Dictionary<int, float> _fadeTimeDic; // 0x1A0
	private int _curItemIndex; // 0x1A8
	private float _curFadeInTime; // 0x1AC
	private List<SimpleItemStruct> _itemHQList; // 0x1B0
	private Queue<MonoSimpleItem> _itemHQFadeInQueue; // 0x1B8
	private Queue<MonoSimpleItem> _itemHQFadeOutQueue; // 0x1C0
	private Dictionary<int, float> _fadeTimeHQDic; // 0x1C8
	private int _curHQItemIndex; // 0x1D0
	private float _curHQFadeInTime; // 0x1D4
	private bool _startUpdate; // 0x1D8

	// Constructors
	public QuestRewardDialogContext() {} // Dummy constructor
	public QuestRewardDialogContext(List<SimpleItemStruct> itemList, ItemGetReason itemGetReason) {} // 0x0000000182961080-0x00000001829612A0
	public QuestRewardDialogContext(List<SimpleItemStruct> itemList, List<SimpleItemStruct> itemHQList, ItemGetReason itemGetReason) {} // 0x00000001829612A0-0x00000001829614B0

	// Methods
	// [XID] // 0x00000001897FC350-0x00000001897FC370
	public override void SetupView() {} // 0x0000000182960CC0-0x0000000182960E70
	// [XID] // 0x00000001898037D0-0x00000001898037F0
	public override void UpdateView() {} // 0x0000000182960E70-0x0000000182961080
	// [XID] // 0x000000018980AD80-0x000000018980ADA0
	public override void ClearView() {} // 0x000000018295F670-0x000000018295FA30
	// [XID] // 0x0000000189812350-0x0000000189812370
	private void UpdateFadeIn() {} // 0x0000000182960170-0x00000001829603B0
	// [XID] // 0x0000000189819F00-0x0000000189819F20
	private void UpdateHQFadeIn() {} // 0x0000000182960580-0x00000001829607C0
	// [XID] // 0x0000000189821700-0x0000000189821720
	private void UpdateFadeOut() {} // 0x00000001829607C0-0x0000000182960990
	// [XID] // 0x0000000189828D70-0x0000000189828D90
	private void UpdateHQFadeOut() {} // 0x00000001829603B0-0x0000000182960580
	// [XID] // 0x0000000189830140-0x0000000189830160
	private void UpdateItemList() {} // 0x000000018295FA90-0x000000018295FD40
	// [XID] // 0x00000001898378E0-0x0000000189837900
	private void UpdateHQItemList() {} // 0x000000018295FE00-0x00000001829600B0
	// [XID] // 0x000000018983EFF0-0x000000018983F010
	public void AddItems(List<SimpleItemStruct> itemList, List<SimpleItemStruct> itemHQList = null) {} // 0x0000000182960990-0x0000000182960B10
	// [XID] // 0x0000000189846630-0x0000000189846650
	protected override void OnDisable() {} // 0x0000000182960B10-0x0000000182960BD0
	// [XID] // 0x000000018984DBA0-0x000000018984DBC0
	protected override void OnEnable() {} // 0x0000000182960BD0-0x0000000182960CC0
	// [XID] // 0x0000000189854CE0-0x0000000189854D00
	private void OnPrefabLoadFinish() {} // 0x000000018295F5D0-0x000000018295F670
}

