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

public sealed class BlessingItemGotDialogContext : BaseDialogContext // TypeDefIndex: 29181
{
	// Fields
	private MonoItemGotBigDialog _dialogMono; // 0x178
	private ItemSource _source; // 0x180
	private Dictionary<uint, uint> _photoDic; // 0x188
	private List<uint> _photoIdList; // 0x190

	// Nested types
	public enum ItemSource // TypeDefIndex: 29182
	{
		Scan = 0,
		Friend = 1
	}

	// Constructors
	public BlessingItemGotDialogContext() {} // Dummy constructor
	public BlessingItemGotDialogContext(Dictionary<uint, uint> photoDic, ItemSource source) {} // 0x000000018334F2D0-0x000000018334F400

	// Methods
	// [XID] // 0x000000018968AE00-0x000000018968AE20
	public override void SetupView() {} // 0x000000018334F150-0x000000018334F2D0
	// [XID] // 0x0000000189692AD0-0x0000000189692AF0
	protected override void BindViewCallbacks() {} // 0x000000018334EAD0-0x000000018334EBD0
	// [XID] // 0x0000000189699DE0-0x0000000189699E00
	private void SetItemGotView() {} // 0x000000018334EE70-0x000000018334F150
	// [XID] // 0x00000001896A1540-0x00000001896A1560
	private void RefreshItemSlot(Transform trans, int index) {} // 0x000000018334EBD0-0x000000018334EDB0
}

