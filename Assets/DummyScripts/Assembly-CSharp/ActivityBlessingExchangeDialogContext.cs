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

public sealed class ActivityBlessingExchangeDialogContext : BaseDialogContext // TypeDefIndex: 29486
{
	// Fields
	private MonoActivityBlessingExchangeDialog _dialogMono; // 0x178
	private List<IdCountStrConfig> _rewardPreviewList; // 0x180
	private List<uint> _albumList; // 0x188
	private MapField<uint, uint> _photoMap; // 0x190
	private bool _canExchange; // 0x198

	// Constructors
	public ActivityBlessingExchangeDialogContext() {} // 0x000000018160C5E0-0x000000018160C6E0

	// Methods
	// [XID] // 0x0000000189A2D000-0x0000000189A2D020
	public override void SetupView() {} // 0x000000018160C500-0x000000018160C5E0
	// [XID] // 0x0000000189A34A00-0x0000000189A34A20
	public override void ClearView() {} // 0x000000018160B540-0x000000018160B5E0
	// [XID] // 0x0000000189A3BDB0-0x0000000189A3BDD0
	protected override void BindViewCallbacks() {} // 0x000000018160AFC0-0x000000018160B1D0
	// [XID] // 0x0000000189A43A00-0x0000000189A43A20
	public override bool OnNotify(Notify ntf) => default; // 0x000000018160C3A0-0x000000018160C500
	// [XID] // 0x0000000189A4AE50-0x0000000189A4AE70
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018160BE40-0x000000018160BF40
	// [XID] // 0x0000000189A52570-0x0000000189A52590
	private void SetupReward() {} // 0x000000018160ACE0-0x000000018160AFC0
	// [XID] // 0x0000000189A59EC0-0x0000000189A59EE0
	private void RefreshRewardPreviewItem(Transform trans, int index) {} // 0x000000018160BB50-0x000000018160BE40
	// [XID] // 0x0000000189A61690-0x0000000189A616B0
	private void SetupBottom() {} // 0x000000018160ABE0-0x000000018160ACE0
	// [XID] // 0x0000000189A695D0-0x0000000189A695F0
	private void SetupAlbumPanel() {} // 0x000000018160B830-0x000000018160BB50
	// [XID] // 0x0000000189A70940-0x0000000189A70960
	private void RefreshPhoto(Transform trans, int index) {} // 0x000000018160B1D0-0x000000018160B540
	// [XID] // 0x0000000189A781F0-0x0000000189A78210
	private void SetupLimitInfo() {} // 0x000000018160C020-0x000000018160C2B0
	// [XID] // 0x0000000189A7F800-0x0000000189A7F820
	private void OnExchange() {} // 0x000000018160BF40-0x000000018160C020
	// [XID] // 0x0000000189A87520-0x0000000189A87540
	private void ShowReward() {} // 0x000000018160B5E0-0x000000018160B770
}

