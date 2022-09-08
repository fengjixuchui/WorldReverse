/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShopExchangeDialogContext : BaseDialogContext // TypeDefIndex: 29292
{
	// Fields
	private MonoShopExchangeDialog _dialogMono; // 0x178
	private int _maxExchangeNum; // 0x180
	private int _currMaterialNum; // 0x184
	private int _currExchangeNum; // 0x188
	private ShopMaterial _leftMaterial; // 0x18C
	private ShopMaterial _rightMaterial; // 0x194
	private MonoPS4IMEProxy _proxy; // 0x1A0
	private static readonly uint _selectMaterialAudio; // 0x00
	private SelectedMaterial _selectedMaterial; // 0x1A8
	private MaterialGrpWidgetContext _materialWidget; // 0x1B0

	// Properties
	private SelectedMaterial selectedMaterial { /* [XID] */ /* 0x00000001899967B0-0x00000001899967D0 */ get => default; /* [XID] */ /* 0x000000018999E2D0-0x000000018999E2F0 */ set {} } // 0x00000001841CB6A0-0x00000001841CB740 0x00000001841CC830-0x00000001841CCB00

	// Nested types
	private enum SelectedMaterial // TypeDefIndex: 29293
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	// Constructors
	public ShopExchangeDialogContext() {} // 0x00000001841CD690-0x00000001841CD750
	static ShopExchangeDialogContext() {} // 0x00000001841CD600-0x00000001841CD690

	// Methods
	// [XID] // 0x0000000189961C20-0x0000000189961C40
	public override void SetupView() {} // 0x00000001841CD0A0-0x00000001841CD600
	// [XID] // 0x00000001899692B0-0x00000001899692D0
	public override void ClearView() {} // 0x00000001841CBB20-0x00000001841CBC30
	// [XID] // 0x0000000189970D50-0x0000000189970D70
	protected override void BindViewCallbacks() {} // 0x00000001841CB280-0x00000001841CB6A0
	// [XID] // 0x0000000189978690-0x00000001899786B0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001841CCE80-0x00000001841CCF80
	// [XID] // 0x000000018997F7B0-0x000000018997F7D0
	private void SetInputValue(int value) {} // 0x00000001841CC540-0x00000001841CC680
	// [XID] // 0x0000000189987100-0x0000000189987120
	private void OnInputValueChanged(string text) {} // 0x00000001841CC680-0x00000001841CC830
	// [XID] // 0x000000018998EBD0-0x000000018998EBF0
	private void SetChangeNum(int num) {} // 0x00000001841CB740-0x00000001841CB9E0
	// [XID] // 0x00000001899A5C90-0x00000001899A5CB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001841CBE10-0x00000001841CC2D0
	// [XID] // 0x00000001899AD350-0x00000001899AD370
	private void ShowMaterialDetail(SelectedMaterial selected) {} // 0x00000001841CBA50-0x00000001841CBB20
	// [XID] // 0x00000001899B4BB0-0x00000001899B4BD0
	private void ShowLeftMaterialDetail() {} // 0x00000001841CC3A0-0x00000001841CC490
	// [XID] // 0x00000001899BC270-0x00000001899BC290
	private void ShowRightMaterialDetail() {} // 0x00000001841CBCC0-0x00000001841CBDB0
	// [XID] // 0x00000001899C3CB0-0x00000001899C3CD0
	private void DoExchange() {} // 0x00000001841CCC30-0x00000001841CCD90
	// [XID] // 0x00000001899CB3B0-0x00000001899CB3D0
	private int GetMaxHcoinExchangeNum() => default; // 0x00000001841CCF80-0x00000001841CD0A0
	// [XID] // 0x00000001899D28E0-0x00000001899D2900
	private void SetupShopMaterialWidget() {} // 0x00000001841CB080-0x00000001841CB210
	// [XID] // 0x00000001899D9FF0-0x00000001899DA010
	private void CloseShopMaterialWidget() {} // 0x00000001841CCB00-0x00000001841CCBC0
}

