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
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseExpDialogContext : UseMaterialDialogContext // TypeDefIndex: 29342
{
	// Fields
	private static readonly uint[] _expMaterials; // 0x00
	private uint _currLevel; // 0x1A0
	private uint _currExp; // 0x1A4
	private uint _currBreakLevel; // 0x1A8
	private uint _maxLevel; // 0x1AC
	private uint _postLevel; // 0x1B0
	private uint _expAddOne; // 0x1B4
	private uint _expAddTotle; // 0x1B8
	private int _coinToUse; // 0x1BC
	private List<Tuple<BagItemSlot, uint>> _breakNeedList; // 0x1C0

	// Constructors
	public UseExpDialogContext() {} // Dummy constructor
	public UseExpDialogContext(AvatarDataItem target) {} // 0x000000018261D4B0-0x000000018261D590
	static UseExpDialogContext() {} // 0x000000018261D410-0x000000018261D4B0

	// Methods
	// [XID] // 0x0000000189785DB0-0x0000000189785DD0
	public override void SetupView() {} // 0x000000018261D220-0x000000018261D410
	// [XID] // 0x000000018978D490-0x000000018978D4B0
	protected override void BindViewCallbacks() {} // 0x000000018261B4E0-0x000000018261B580
	// [XID] // 0x0000000189794810-0x0000000189794830
	protected override void UpdateUseableMaterial() {} // 0x000000018261B920-0x000000018261BE70
	// [XID] // 0x000000018979CCA0-0x000000018979CCC0
	protected override void RefreshUsePreview() {} // 0x000000018261B1F0-0x000000018261B3F0
	// [XID] // 0x00000001897A4100-0x00000001897A4120
	private void ShowBreakMaterialDialog() {} // 0x000000018261C720-0x000000018261CC30
	// [XID] // 0x00000001897AB660-0x00000001897AB680
	private void CalcPostLevelAndExp() {} // 0x000000018261C510-0x000000018261C720
	// [XID] // 0x00000001897B34B0-0x00000001897B34D0
	protected override void OnUseMaterialChanged(int index) {} // 0x000000018261BFE0-0x000000018261C2C0
	// [XID] // 0x00000001897BB390-0x00000001897BB3B0
	protected override void OnRefresh() {} // 0x000000018261B580-0x000000018261B7C0
	// [XID] // 0x00000001897C2B90-0x00000001897C2BB0
	protected override void ShowHelp() {} // 0x000000018261B3F0-0x000000018261B4E0
	// [XID] // 0x00000001897CA3F0-0x00000001897CA410
	protected override void Use() {} // 0x000000018261C2C0-0x000000018261C510
	// [XID] // 0x00000001897D1A30-0x00000001897D1A50
	private void RealUse() {} // 0x000000018261CD50-0x000000018261CFF0
	// [XID] // 0x00000001897D98B0-0x00000001897D98D0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018261D080-0x000000018261D160
	// [XID] // 0x00000001897E0C30-0x00000001897E0C50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018261BED0-0x000000018261BFE0
}

