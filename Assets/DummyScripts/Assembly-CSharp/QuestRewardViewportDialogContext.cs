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

public sealed class QuestRewardViewportDialogContext : BaseDialogContext // TypeDefIndex: 29245
{
	// Fields
	private MonoQuestRewardViewportDialog _dialogMono; // 0x178
	private List<SimpleItemStruct> _itemList; // 0x180
	private List<SimpleItemStruct>[] _itemLists; // 0x188
	private ItemGetReason _itemGetReason; // 0x190
	private List<GameObject> _itemObjectList; // 0x198
	private const int MAX_RANK_LEVEL = 5; // Metadata: 0x00B0EEBC
	private static GameObject[] _itemPrefabs; // 0x00
	private static string[] _itemPrefabPaths; // 0x08
	private float _time; // 0x1A0
	private bool _startUpdate; // 0x1A4
	public Action<List<SimpleItemStruct>[], ItemGetReason> closeCallbackAction; // 0x1A8

	// Constructors
	public QuestRewardViewportDialogContext() {} // Dummy constructor
	public QuestRewardViewportDialogContext(List<SimpleItemStruct>[] itemLists, ItemGetReason itemGetReason) {} // 0x0000000183B4FBC0-0x0000000183B4FD30
	static QuestRewardViewportDialogContext() {} // 0x0000000183B4F960-0x0000000183B4FBC0

	// Methods
	// [XID] // 0x000000018985C4A0-0x000000018985C4C0
	public override void SetupView() {} // 0x0000000183B4F660-0x0000000183B4F7A0
	// [XID] // 0x0000000189863E00-0x0000000189863E20
	public override void UpdateView() {} // 0x0000000183B4F7A0-0x0000000183B4F960
	// [XID] // 0x000000018986B150-0x000000018986B170
	private void RefreshItem() {} // 0x0000000183B4EDA0-0x0000000183B4F060
	// [XID] // 0x0000000189872500-0x0000000189872520
	private GameObject GetItemPrefab(uint rankLevel) => default; // 0x0000000183B4F120-0x0000000183B4F400
	// [XID] // 0x000000018987A170-0x000000018987A190
	public override void ClearView() {} // 0x0000000183B4EA10-0x0000000183B4EDA0
	// [XID] // 0x0000000189881310-0x0000000189881330
	protected override void OnDisable() {} // 0x0000000183B4F520-0x0000000183B4F5C0
	// [XID] // 0x00000001898888E0-0x0000000189888900
	protected override void OnEnable() {} // 0x0000000183B4F5C0-0x0000000183B4F660
}

