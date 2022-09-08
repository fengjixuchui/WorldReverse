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

public sealed class AddResinDialogContext : BaseDialogContext // TypeDefIndex: 28763
{
	// Fields
	private MonoAddResinDialog _dialogMono; // 0x178
	private List<ResinSourceType> _resinSourceTypes; // 0x180
	private int _selectedIndex; // 0x188
	private MaterialGrpWidgetContext _materialWidget; // 0x190
	private MonoBagProxySlot _lastSelectedItem; // 0x198
	private string _remainingTimeStr; // 0x1A0

	// Nested types
	public enum ResinSourceType // TypeDefIndex: 28764
	{
		HCoin = 201,
		ResinCard = 1204,
		FragileResin = 107009,
		TimingResin = 107012
	}

	// Constructors
	public AddResinDialogContext() {} // 0x00000001842599D0-0x0000000184259A90

	// Methods
	// [XID] // 0x0000000189A4E020-0x0000000189A4E040
	public override void SetupView() {} // 0x00000001842598F0-0x00000001842599D0
	// [XID] // 0x0000000189A55750-0x0000000189A55770
	private void RefreshView() {} // 0x00000001842590F0-0x00000001842592F0
	// [XID] // 0x0000000189A5D0D0-0x0000000189A5D0F0
	private void OnSelectItem(Transform trans, int index) {} // 0x0000000184257540-0x0000000184257FA0
	// [XID] // 0x0000000189A64970-0x0000000189A64990
	private int GetResinGainFromConfig(MaterialExcelConfig matConfig) => default; // 0x0000000184258500-0x0000000184258740
	// [XID] // 0x0000000189A6C190-0x0000000189A6C1B0
	private string GetRemainingTimeString() => default; // 0x00000001842572F0-0x0000000184257540
	// [XID] // 0x0000000189A73900-0x0000000189A73920
	private void CalcResinSourceTypes() {} // 0x0000000184258C20-0x0000000184258E70
	// [XID] // 0x0000000189A7B480-0x0000000189A7B4A0
	private void RefreshResinSources(Transform trans, int index) {} // 0x00000001842588E0-0x0000000184258BC0
	// [XID] // 0x0000000189A82B40-0x0000000189A82B60
	public override void ClearView() {} // 0x0000000184258740-0x0000000184258850
	// [XID] // 0x0000000189A8A510-0x0000000189A8A530
	protected override void BindViewCallbacks() {} // 0x0000000184257FA0-0x0000000184258160
	// [XID] // 0x0000000189A91D10-0x0000000189A91D30
	private void OnOkBtn() {} // 0x0000000184258160-0x0000000184258500
	// [XID] // 0x0000000189A997C0-0x0000000189A997E0
	private void ByResinByHCoin() {} // 0x0000000184259350-0x0000000184259670
	// [XID] // 0x0000000189AA0830-0x0000000189AA0850
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184259820-0x00000001842598F0
	// [XID] // 0x0000000189AA7E30-0x0000000189AA7E50
	private void SetupShopMaterialWidget() {} // 0x00000001842571A0-0x00000001842572F0
	// [XID] // 0x0000000189AAF900-0x0000000189AAF920
	private void CloseShopMaterialWidget() {} // 0x0000000184259670-0x0000000184259730
	// [XID] // 0x0000000189AB71D0-0x0000000189AB71F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184258E70-0x00000001842590F0
}

