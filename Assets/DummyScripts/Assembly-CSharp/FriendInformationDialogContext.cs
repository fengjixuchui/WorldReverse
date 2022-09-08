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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FriendInformationDialogContext : BaseDialogContext, FilterReceiver // TypeDefIndex: 29106
{
	// Fields
	private MonoFriendInformationDialog _dialogMono; // 0x178
	private FriendInformationDialogType _type; // 0x180
	private FriendInformationDialogType _forceType; // 0x184
	private SocialDetailStruct _socialDetail; // 0x188
	private bool _inEditPanel; // 0x1F8
	private List<editType> _editTypeList; // 0x200
	private List<ulong> _previewList; // 0x208
	private List<uint> _modifyShowAvatarList; // 0x210
	private List<uint> _selfShowAvatarList; // 0x218
	private bool _isShowAvatar; // 0x220
	private const int MAX_AVATAR_SHOW_NUM = 8; // Metadata: 0x00B0EBED
	private uint _selectedAvatarId; // 0x224
	private bool _isSendMsg; // 0x228
	private int _selectAvatarIdx; // 0x22C
	private FriendInformationSubTabType _subTabType; // 0x230
	private AvatarSequenceSelectDialogContext _avatarSelectDialog; // 0x238
	private List<ulong> _avatarSelectedGuid; // 0x240
	private SignatureEditDialogContext _signatureEditDialog; // 0x248
	private const int MAX_NAMECARD_SHOW_NUM = 9; // Metadata: 0x00B0EBF1
	private const string EMPTY_NAMECARD_ICON_NAME = "UI_NameCardIcon_Add"; // Metadata: 0x00B0EBF5

	// Nested types
	private enum editType // TypeDefIndex: 29107
	{
		CHANGE_REMARK_NAME = 0,
		REMOVE_FRIEND = 1,
		BLOCK_CHAT = 2,
		BLACKLIST = 3,
		REPORT_PLAYER = 4,
		EDIT_HEAD_PORTRAIT = 5,
		EDIT_NAMECARD = 6,
		EDIT_NAME = 7,
		EDIT_BIRTHDAY = 8,
		EDIT_SIGNATURE = 9,
		COPY_UID = 10
	}

	// Constructors
	public FriendInformationDialogContext() {} // Dummy constructor
	public FriendInformationDialogContext(SocialDetailStruct socialDetail, FriendInformationDialogType forceType = FriendInformationDialogType.NONE /* Metadata: 0x00B0EBE5 */) {} // 0x0000000182C1F0D0-0x0000000182C1F270

	// Methods
	// [XID] // 0x000000018983C0D0-0x000000018983C0F0
	public override void SetupView() {} // 0x0000000182C1EEB0-0x0000000182C1F0D0
	// [XID] // 0x00000001898436E0-0x0000000189843700
	protected override void OnEnable() {} // 0x0000000182C1E4E0-0x0000000182C1E590
	// [XID] // 0x000000018984AC40-0x000000018984AC60
	public override void ClearView() {} // 0x0000000182C17570-0x0000000182C17650
	// [XID] // 0x0000000189851FA0-0x0000000189851FC0
	private void ClearAvatarData() {} // 0x0000000182C17650-0x0000000182C17880
	// [XID] // 0x0000000189859860-0x0000000189859880
	protected override void BindViewCallbacks() {} // 0x0000000182C16550-0x0000000182C16910
	// [XID] // 0x00000001898609E0-0x0000000189860A00
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182C1E680-0x0000000182C1E840
	// [XID] // 0x0000000189868110-0x0000000189868130
	public static FriendInformationDialogType DetermineDialogType(FriendInformationDialogType forceType, SocialDetailStruct socialDetail) => default; // 0x0000000182C1AA60-0x0000000182C1AC80
	// [XID] // 0x000000018986F6D0-0x000000018986F6F0
	private void OnGetFriendShowAvatarInfo(uint uid) {} // 0x0000000182C1B2C0-0x0000000182C1B5C0
	// [XID] // 0x0000000189876C80-0x0000000189876CA0
	private void TryOpenCharacterPage() {} // 0x0000000182C1E250-0x0000000182C1E4E0
	// [XID] // 0x000000018987E780-0x000000018987E7A0
	private void SetAvatarBtnEnable(bool enable) {} // 0x0000000182C154C0-0x0000000182C156C0
	// [XID] // 0x0000000189885B70-0x0000000189885B90
	private void OnRefreshRemarkname(SetFriendRemarkNameRsp rsp) {} // 0x0000000182C158A0-0x0000000182C15AA0
	// [XID] // 0x000000018988CE60-0x000000018988CE80
	private void OnUpdatePlayerShowAvatarList() {} // 0x0000000182C16910-0x0000000182C16C00
	// [XID] // 0x0000000189894550-0x0000000189894570
	private void OnRefreshSignature() {} // 0x0000000182C1A570-0x0000000182C1A740
	// [XID] // 0x000000018989BB20-0x000000018989BB40
	private void TryRefreshSelfInfo() {} // 0x0000000182C18AD0-0x0000000182C18BD0
	// [XID] // 0x00000001898A2F90-0x00000001898A2FB0
	private void SetupSocialInfo() {} // 0x0000000182C1D8B0-0x0000000182C1E1C0
	// [XID] // 0x00000001898AA470-0x00000001898AA490
	private void SetupButtonState() {} // 0x0000000182C18310-0x0000000182C18480
	// [XID] // 0x00000001898B1E70-0x00000001898B1E90
	private void SetupStrangerButtonState() {} // 0x0000000182C1A820-0x0000000182C1AA60
	// [XID] // 0x00000001898B9B10-0x00000001898B9B30
	private void SetupFriendButtonState() {} // 0x0000000182C19E60-0x0000000182C1A2D0
	// [XID] // 0x00000001898C0EF0-0x00000001898C0F10
	private void SetupRequestButtonState() {} // 0x0000000182C15130-0x0000000182C153C0
	// [XID] // 0x00000001898C8830-0x00000001898C8850
	private void SetupSelfButtonState() {} // 0x0000000182C19000-0x0000000182C193D0
	// [XID] // 0x00000001898D01E0-0x00000001898D0200
	private void SetupBlackListButtonState() {} // 0x0000000182C1CE40-0x0000000182C1D030
	// [XID] // 0x00000001898D7770-0x00000001898D7790
	private void SetupEditPanel() {} // 0x0000000182C14A20-0x0000000182C15130
	// [XID] // 0x00000001898DF4C0-0x00000001898DF4E0
	private void SetupAvatarPanel() {} // 0x0000000182C1B850-0x0000000182C1BC30
	// [XID] // 0x00000001898E6E80-0x00000001898E6EA0
	private void RefreshSelfAvatarList() {} // 0x0000000182C1B080-0x0000000182C1B2C0
	// [XID] // 0x00000001898EE650-0x00000001898EE670
	private void RefreshAvatatItem(Transform trans, int index) {} // 0x0000000182C1D290-0x0000000182C1D570
	// [XID] // 0x00000001898F5DE0-0x00000001898F5E00
	private void RefreshSelfAvatatItem(Transform trans, int index) {} // 0x0000000182C16160-0x0000000182C163C0
	// [XID] // 0x00000001898FD620-0x00000001898FD640
	private void OnAvatarSelect(int index) {} // 0x0000000182C18C80-0x0000000182C18E70
	// [XID] // 0x0000000189904EE0-0x0000000189904F00
	private void EditorAvatarShowList() {} // 0x0000000182C1C0D0-0x0000000182C1C410
	// [XID] // 0x000000018990C6E0-0x000000018990C700
	private void OnSelectorChange(Transform trans, int index) {} // 0x0000000182C17880-0x0000000182C17A10
	// [XID] // 0x0000000189913F90-0x0000000189913FB0
	private void OnSelectorChangeForLast(Transform trans, int index) {} // 0x0000000182C17E00-0x0000000182C17F90
	// [XID] // 0x000000018991B9C0-0x000000018991B9E0
	private void RefreshEditBtn(Transform trans, int index) {} // 0x0000000182C19530-0x0000000182C19E60
	// [XID] // 0x0000000189922F40-0x0000000189922F60
	private void OnToggleChanged(bool isOn) {} // 0x0000000182C1A740-0x0000000182C1A820
	// [XID] // 0x000000018992A770-0x000000018992A790
	private void SetToggleText(bool isShow) {} // 0x0000000182C1D030-0x0000000182C1D160
	// [XID] // 0x0000000189931D70-0x0000000189931D90
	private void OnCloseBtnClick() {} // 0x0000000182C15F50-0x0000000182C16070
	// [XID] // 0x0000000189939780-0x00000001899397A0
	private void OnEditBtnClick() {} // 0x0000000182C1CA60-0x0000000182C1CB00
	// [XID] // 0x0000000189940A50-0x0000000189940A70
	private void OnEditReturnBtnClick() {} // 0x0000000182C1D690-0x0000000182C1D730
	// [XID] // 0x0000000189948310-0x0000000189948330
	private void EditHeadPortrait() {} // 0x0000000182C153C0-0x0000000182C154C0
	// [XID] // 0x000000018994FA10-0x000000018994FA30
	private void EditNameCard() {} // 0x0000000182C1D7B0-0x0000000182C1D8B0
	// [XID] // 0x0000000189957050-0x0000000189957070
	private void EditName() {} // 0x0000000182C156C0-0x0000000182C157C0
	// [XID] // 0x000000018995EB60-0x000000018995EB80
	private void EditBirthday() {} // 0x0000000182C1AC80-0x0000000182C1AD80
	// [XID] // 0x0000000189966260-0x0000000189966280
	private void CopyUid() {} // 0x0000000182C18810-0x0000000182C18990
	// [XID] // 0x000000018996D700-0x000000018996D720
	private void EditSignature() {} // 0x0000000182C1B6C0-0x0000000182C1B850
	// [XID] // 0x00000001899752A0-0x00000001899752C0
	private void ShowEditPanel(bool show) {} // 0x0000000182C18990-0x0000000182C18AD0
	// [XID] // 0x000000018997C460-0x000000018997C480
	private void OnFriendAddBtnClick() {} // 0x0000000182C16070-0x0000000182C16160
	// [XID] // 0x0000000189984180-0x00000001899841A0
	private void DeleteFriend() {} // 0x0000000182C1A480-0x0000000182C1A570
	// [XID] // 0x000000018998BCF0-0x000000018998BD10
	private void OnFriendAddRejectBtnClick() {} // 0x0000000182C15E30-0x0000000182C15F50
	// [XID] // 0x00000001899938C0-0x00000001899938E0
	private void OnFriendAddAcceptBtnClick() {} // 0x0000000182C1E840-0x0000000182C1E970
	// [XID] // 0x000000018999B1A0-0x000000018999B1C0
	private void OnRequestEnterWorldBtnClick() {} // 0x0000000182C1BC30-0x0000000182C1BE30
	// [XID] // 0x00000001899A29A0-0x00000001899A29C0
	private void AddInBlockChatList() {} // 0x0000000182C18E70-0x0000000182C19000
	// [XID] // 0x00000001899AA2C0-0x00000001899AA2E0
	private void RemoveFromBlockChatList() {} // 0x0000000182C1BE30-0x0000000182C1C0D0
	// [XID] // 0x00000001899B1CF0-0x00000001899B1D10
	private void AddInBlacklist() {} // 0x0000000182C163C0-0x0000000182C16550
	// [XID] // 0x00000001899B9030-0x00000001899B9050
	private void RemoveFromBlacklist() {} // 0x0000000182C1B5C0-0x0000000182C1B6C0
	// [XID] // 0x00000001899C08F0-0x00000001899C0910
	private void ChangeRemarkName() {} // 0x0000000182C1E970-0x0000000182C1EA90
	// [XID] // 0x00000001899C8140-0x00000001899C8160
	private void ReportPlayer() {} // 0x0000000182C1D160-0x0000000182C1D290
	// [XID] // 0x00000001899CFAC0-0x00000001899CFAE0
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x0000000182C1C560-0x0000000182C1C9B0
	// [XID] // 0x00000001899D6E90-0x00000001899D6EB0
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x0000000182C1C9B0-0x0000000182C1CA60
	// [XID] // 0x00000001899DE460-0x00000001899DE480
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x0000000182C1C410-0x0000000182C1C4C0
	// [XID] // 0x00000001899E6100-0x00000001899E6120
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x0000000182C1C4C0-0x0000000182C1C560
	// [XID] // 0x00000001899ED4F0-0x00000001899ED510
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EBE9 */) {} // 0x0000000182C1E590-0x0000000182C1E680
	// [XID] // 0x00000001899F5060-0x00000001899F5080
	private void RefreshScrollerSlotFocus(int index, bool isFocus) {} // 0x0000000182C17C50-0x0000000182C17E00
	// [XID] // 0x00000001899FC630-0x00000001899FC650
	private void FocusScrollerSlot(int currIndex) {} // 0x0000000182C1CCF0-0x0000000182C1CE40
	// [XID] // 0x0000000189A03C20-0x0000000189A03C40
	private void FocusNavRegion(string regionName) {} // 0x0000000182C1CBF0-0x0000000182C1CCF0
	// [XID] // 0x0000000189A0B130-0x0000000189A0B150
	private void ResetAvatarScroller() {} // 0x0000000182C17A10-0x0000000182C17AF0
	// [XID] // 0x0000000189A12A60-0x0000000189A12A80
	private void CheckSelectAvatar() {} // 0x0000000182C15BE0-0x0000000182C15E30
	// [XID] // 0x0000000189A19C50-0x0000000189A19C70
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C1A330-0x0000000182C1A420
	// [XID] // 0x0000000189A212E0-0x0000000189A21300
	public bool HandleEditPanelInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C16C00-0x0000000182C17050
	// [XID] // 0x0000000189A28900-0x0000000189A28920
	public bool HandleDefaultInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C1EA90-0x0000000182C1EE00
	// [XID] // 0x0000000189A2FF30-0x0000000189A2FF50
	private void ShowMainPage() {} // 0x0000000182C18BD0-0x0000000182C18C80
	// [XID] // 0x0000000189A37940-0x0000000189A37960
	private void ShowNameCard() {} // 0x0000000182C14970-0x0000000182C14A20
	// [XID] // 0x0000000189A3F070-0x0000000189A3F090
	private void ToPrevTab() {} // 0x0000000182C17400-0x0000000182C17500
	// [XID] // 0x0000000189A46730-0x0000000189A46750
	private void ToNextTab() {} // 0x0000000182C17AF0-0x0000000182C17BF0
	// [XID] // 0x0000000189A4DF40-0x0000000189A4DF60
	private void RefreshSubTab(FriendInformationSubTabType type) {} // 0x0000000182C146A0-0x0000000182C14970
	// [XID] // 0x0000000189A556B0-0x0000000189A556D0
	private void SetSubTabFocus() {} // 0x0000000182C1ADF0-0x0000000182C1B080
	// [XID] // 0x0000000189A5D030-0x0000000189A5D050
	private MonoUIContainer GetSubTabBtn(FriendInformationSubTabType type) => default; // 0x0000000182C1CB00-0x0000000182C1CBF0
	// [XID] // 0x0000000189A648D0-0x0000000189A648F0
	private void SetupNameCardPanel() {} // 0x0000000182C17F90-0x0000000182C18310
	// [XID] // 0x0000000189A6C0F0-0x0000000189A6C110
	private void RefreshNameCardItem(Transform trans, int index) {} // 0x0000000182C17050-0x0000000182C17400
	// [XID] // 0x0000000189A73860-0x0000000189A73880
	private void EditorNameCardShowList() {} // 0x0000000182C15AA0-0x0000000182C15BE0
	// [XID] // 0x0000000189A7B3A0-0x0000000189A7B3C0
	private void OnUpdatePlayerShowNameCardList() {} // 0x0000000182C193D0-0x0000000182C19530
}

