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

public class ItemGotDialogContext : BaseAutoCloseDialogContext // TypeDefIndex: 29177
{
	// Fields
	protected MonoItemGotDialog _dialogMono; // 0x180
	protected List<SimpleItemStruct> _itemList; // 0x188
	protected List<SimpleItemStruct> _bonusList; // 0x190
	protected bool _showStar; // 0x198
	protected const string BONUS_TIPS_PATH = "ART/UI/Menus/Widget/BagItemSlot_Tag"; // Metadata: 0x00B0ED4C
	protected GameObject _loadGO; // 0x1A0
	protected uint _bonusHandler; // 0x1A8
	protected List<GameObject> _bonusGameObjectList; // 0x1B0
	protected bool _showBonusTip; // 0x1B8

	// Constructors
	public ItemGotDialogContext() {} // Dummy constructor
	public ItemGotDialogContext(List<SimpleItemStruct> itemList, bool showStar = false /* Metadata: 0x00B0ED4A */, List<SimpleItemStruct> bonusList = null, bool showBonusTip = false /* Metadata: 0x00B0ED4B */) {} // 0x000000018320DDE0-0x000000018320DF10

	// Methods
	// [XID] // 0x000000018960B520-0x000000018960B540
	public override void SetupView() {} // 0x000000018320DCE0-0x000000018320DDE0
	// [XID] // 0x00000001896128F0-0x0000000189612910
	public override void ClearView() {} // 0x000000018320D130-0x000000018320D2F0
	// [XID] // 0x000000018961A260-0x000000018961A280
	protected override void BindViewCallbacks() {} // 0x000000018320D010-0x000000018320D130
	// [XID] // 0x00000001896217B0-0x00000001896217D0
	protected void SetItemGotView() {} // 0x000000018320D9C0-0x000000018320DCE0
	// [XID] // 0x0000000189629080-0x00000001896290A0
	private void RefreshItemSlot(Transform trans, int index) {} // 0x000000018320D2F0-0x000000018320D8A0
}

