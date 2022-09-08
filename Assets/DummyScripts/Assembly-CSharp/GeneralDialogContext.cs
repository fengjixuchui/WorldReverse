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
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GeneralDialogContext : BaseDialogContext // TypeDefIndex: 28719
{
	// Fields
	public string tagName; // 0x178
	public string title; // 0x180
	public string desc; // 0x188
	public string okBtnText; // 0x190
	public string cancelBtnText; // 0x198
	public string closeBtnText; // 0x1A0
	public Action<bool> buttonCallBack; // 0x1A8
	public Action<bool> clearViewCallBack; // 0x1B0
	public Action closeBtnCallBack; // 0x1B8
	public Action menuLeftBtnCallBack; // 0x1C0
	private bool _isOk; // 0x1C8
	private bool _closeByCloseBtn; // 0x1C9
	private bool _showCheckbox; // 0x1CA
	public string checkboxDesc; // 0x1D0
	public bool defaultCheckboxConfirmState; // 0x1D8
	public Action<bool> checkboxValueChangeCallback; // 0x1E0
	public bool showNormalCloseBtn; // 0x1E8
	public WaitForGeneralDialog yieldIns; // 0x1F0
	private MonoGeneralDialog _dialogMono; // 0x1F8
	protected GeneralDialogType _type; // 0x200
	private Action _onUpdate; // 0x208
	private MaterialGrpWidgetContext _materialWidget; // 0x210
	public List<ShopMaterial> shopMaterials; // 0x218

	// Nested types
	public enum GeneralDialogType // TypeDefIndex: 28720
	{
		DOUBLE_BUTTON = 0,
		SINGLE_BUTTON = 1
	}

	// Constructors
	public GeneralDialogContext() {} // Dummy constructor
	public GeneralDialogContext(GeneralDialogType type = GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E5BB */, UIType uiType = UIType.Dialog /* Metadata: 0x00B0E5BF */, bool isToggleDialog = false /* Metadata: 0x00B0E5C3 */) {} // 0x000000018343EDA0-0x000000018343EF70

	// Methods
	// [XID] // 0x00000001896E3820-0x00000001896E3840
	public override void SetupView() {} // 0x000000018343E750-0x000000018343ECF0
	// [XID] // 0x00000001896EAC90-0x00000001896EACB0
	private void InitCheckbox() {} // 0x000000018343E500-0x000000018343E750
	// [XID] // 0x00000001896F2020-0x00000001896F2040
	public void UpdateDescText(string desc) {} // 0x000000018343E180-0x000000018343E290
	// [XID] // 0x00000001896F9A00-0x00000001896F9A20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018343DA80-0x000000018343DC90
	// [XID] // 0x0000000189701250-0x0000000189701270
	protected override void BindViewCallbacks() {} // 0x000000018343D4F0-0x000000018343D6F0
	// [XID] // 0x0000000189708920-0x0000000189708940
	public void OnOKButtonCallBack() {} // 0x000000018343D8F0-0x000000018343D990
	// [XID] // 0x0000000189710210-0x0000000189710230
	public void OnCancelButtonCallBack() {} // 0x000000018343DE70-0x000000018343DF10
	// [XID] // 0x0000000189717630-0x0000000189717650
	public void OnBGClick(BaseEventData evtData = null) {} // 0x000000018343DF10-0x000000018343DFD0
	// [XID] // 0x000000018971F0D0-0x000000018971F0F0
	private void OnButtonClick(bool isOk) {} // 0x000000018343E050-0x000000018343E180
	// [XID] // 0x0000000189726730-0x0000000189726750
	public void RegisterUpdate(Action action) {} // 0x000000018343D1A0-0x000000018343D250
	// [XID] // 0x000000018972DC10-0x000000018972DC30
	public override void UpdateView() {} // 0x000000018343ECF0-0x000000018343EDA0
	// [XID] // 0x00000001897353D0-0x00000001897353F0
	public override void ClearView() {} // 0x000000018343D6F0-0x000000018343D7F0
	// [XID] // 0x000000018973CE30-0x000000018973CE50
	public void UpdateCancelButtonText(string text) {} // 0x000000018343E350-0x000000018343E4A0
	// [XID] // 0x00000001897443F0-0x0000000189744410
	public override void Destroy() {} // 0x000000018343D7F0-0x000000018343D8F0
	// [XID] // 0x000000018974C010-0x000000018974C030
	private void SetupShopMaterialWidget() {} // 0x000000018343D250-0x000000018343D480
	// [XID] // 0x0000000189753390-0x00000001897533B0
	private void CloseShopMaterialWidget() {} // 0x000000018343E290-0x000000018343E350
}

