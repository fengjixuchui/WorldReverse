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

public sealed class InLevelGachaConversionDialogContext : BaseDialogContext // TypeDefIndex: 29550
{
	// Fields
	private MonoInLevelGachaConversionDialog _dialogMono; // 0x178
	private List<MonoGachaItemSlot> _gachaItemSlots; // 0x180
	private IGachaConversionParent _parentPage; // 0x188
	private List<uint> _transItemID; // 0x190
	private List<uint> _transItemCount; // 0x198
	private List<bool> _transItemNew; // 0x1A0
	private List<uint> _transAddItemID; // 0x1A8
	private List<uint> _transAddItemCount; // 0x1B0
	private List<bool> _transAddItemNew; // 0x1B8
	private InLevelGachaGroupContext _gachaContext; // 0x1C0

	// Constructors
	public InLevelGachaConversionDialogContext() {} // Dummy constructor
	public InLevelGachaConversionDialogContext(InLevelGachaGroupContext gachaContext, IGachaConversionParent parent) {} // 0x0000000183BD9B80-0x0000000183BD9D60

	// Methods
	// [XID] // 0x000000018971D7F0-0x000000018971D810
	public override void SetupView() {} // 0x0000000183BD9A90-0x0000000183BD9B80
	// [XID] // 0x0000000189724BB0-0x0000000189724BD0
	public override void ClearView() {} // 0x0000000183BD8420-0x0000000183BD8620
	// [XID] // 0x000000018972C3E0-0x000000018972C400
	protected override void BindViewCallbacks() {} // 0x0000000183BD8320-0x0000000183BD8420
	// [XID] // 0x0000000189733AE0-0x0000000189733B00
	private void InitItems() {} // 0x0000000183BD8EE0-0x0000000183BD9A30
	// [XID] // 0x000000018973B220-0x000000018973B240
	private void OnChange(Transform trans, int index) {} // 0x0000000183BD8620-0x0000000183BD8B40
	// [XID] // 0x0000000189742BD0-0x0000000189742BF0
	private void OnItemClick(int index) {} // 0x0000000183BD8B40-0x0000000183BD8D70
	// [XID] // 0x000000018974A8B0-0x000000018974A8D0
	public void BackPage() {} // 0x0000000183BD8E30-0x0000000183BD8EE0
}

