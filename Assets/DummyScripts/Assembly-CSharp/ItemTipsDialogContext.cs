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

public sealed class ItemTipsDialogContext : BaseDialogContext // TypeDefIndex: 29186
{
	// Fields
	private BagItemSlot _bagItemSlot; // 0x178
	private BagItem _bagItem; // 0x180
	private uint _dungeonID; // 0x188
	private MonoItemTipsDialog _dialogMono; // 0x190
	private List<string> _dungeonNameList; // 0x198
	private Dictionary<string, List<uint>> _dungeonNameToIDsDict; // 0x1A0
	private List<string> _textList; // 0x1A8
	private int _currIndex; // 0x1B0

	// Properties
	public BagItemSlot bagItemSlot { /* [XID] */ /* 0x00000001896E37E0-0x00000001896E3800 */ get => default; /* [XID] */ /* 0x00000001896EAC70-0x00000001896EAC90 */ set {} } // 0x0000000181E92490-0x0000000181E92540 0x0000000181E923C0-0x0000000181E92490
	public BagItem bagItem { /* [XID] */ /* 0x00000001896F1FE0-0x00000001896F2000 */ get => default; /* [XID] */ /* 0x00000001896F99C0-0x00000001896F99E0 */ set {} } // 0x0000000181E916A0-0x0000000181E91750 0x0000000181E92AC0-0x0000000181E92B70

	// Constructors
	public ItemTipsDialogContext() {} // 0x0000000181E944B0-0x0000000181E94600

	// Methods
	// [XID] // 0x0000000189701210-0x0000000189701230
	public override void SetupView() {} // 0x0000000181E94350-0x0000000181E944B0
	// [XID] // 0x00000001897088C0-0x00000001897088E0
	protected override void BindViewCallbacks() {} // 0x0000000181E922C0-0x0000000181E923C0
	// [XID] // 0x00000001897101B0-0x00000001897101D0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E92BD0-0x0000000181E92FF0
	// [XID] // 0x00000001897175D0-0x00000001897175F0
	private void RefreshItemSource(BagItem item) {} // 0x0000000181E931D0-0x0000000181E93DC0
	// [XID] // 0x000000018971F090-0x000000018971F0B0
	private void RefreshSourceDungeonListItem(Transform trans, int index) {} // 0x0000000181E925D0-0x0000000181E92AC0
	// [XID] // 0x0000000189726690-0x00000001897266B0
	protected override void RegisterHandlePacket() {} // 0x0000000181E942A0-0x0000000181E94350
	// [XID] // 0x000000018972DBB0-0x000000018972DBD0
	public override bool OnPacket(Packet packet) => default; // 0x0000000181E93E20-0x0000000181E93F20
	// [XID] // 0x0000000189735370-0x0000000189735390
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x0000000181E93F20-0x0000000181E942A0
	// [XID] // 0x000000018973CDD0-0x000000018973CDF0
	private void OnDungeonEntry(uint dungeonID) {} // 0x0000000181E91750-0x0000000181E91A80
	// [XID] // 0x0000000189744390-0x00000001897443B0
	private void IterateList(bool up, bool isFocus = true /* Metadata: 0x00B0EDA6 */) {} // 0x0000000181E91AE0-0x0000000181E92070
	// [XID] // 0x000000018974BFF0-0x000000018974C010
	private void OnCurrSourceListRowClick() {} // 0x0000000181E92FF0-0x0000000181E931D0
	// [XID] // 0x0000000189753330-0x0000000189753350
	private void RefreshShowStateBySelectChange(MonoSourceListRow item) {} // 0x0000000181E92070-0x0000000181E92240
}

