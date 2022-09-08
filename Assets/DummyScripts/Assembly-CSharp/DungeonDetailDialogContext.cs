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

public sealed class DungeonDetailDialogContext : BaseDialogContext // TypeDefIndex: 28926
{
	// Fields
	private const uint COST_ITEM_ID = 106; // Metadata: 0x00B0E88A
	public DungeonExcelConfig dungeonConfig; // 0x178
	private MonoDungeonDetailDialog _dialogMono; // 0x180
	private List<IdCountStrConfig> _rewardList; // 0x188

	// Constructors
	public DungeonDetailDialogContext() {} // 0x0000000184AA4160-0x0000000184AA4210

	// Methods
	// [XID] // 0x00000001898D1580-0x00000001898D15A0
	public override void SetupView() {} // 0x0000000184AA3940-0x0000000184AA4160
	// [XID] // 0x00000001898D8DC0-0x00000001898D8DE0
	protected override void RegisterHandlePacket() {} // 0x0000000184AA3890-0x0000000184AA3940
	// [XID] // 0x00000001898E0AB0-0x00000001898E0AD0
	public override bool OnPacket(Packet packet) => default; // 0x0000000184AA3350-0x0000000184AA36E0
	// [XID] // 0x00000001898E85F0-0x00000001898E8610
	private void RefreshRewardList(uint rewardPreviewID) {} // 0x0000000184AA31D0-0x0000000184AA32F0
	// [XID] // 0x00000001898EFDD0-0x00000001898EFDF0
	private void RefreshRewardBagItem(Transform trans, int index) {} // 0x0000000184AA2F20-0x0000000184AA3140
	// [XID] // 0x00000001898F75D0-0x00000001898F75F0
	protected override void BindViewCallbacks() {} // 0x0000000184AA2890-0x0000000184AA2990
	// [XID] // 0x00000001898FED20-0x00000001898FED40
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184AA2A80-0x0000000184AA2F20
}

