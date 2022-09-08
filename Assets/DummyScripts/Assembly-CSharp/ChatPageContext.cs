/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatPageContext : BaseDialogContext // TypeDefIndex: 28464
{
	// Fields
	public bool needCheckBound; // 0x178
	private bool _passCheck; // 0x179
	private bool _inMain; // 0x17A
	private bool _needCheckStart; // 0x17B
	public ChatChannel _currChannel; // 0x17C
	private uint _targetUid; // 0x180
	private MonoInLevelChatPage _pageMono; // 0x188
	private ChatDataItemList _chatDataList; // 0x190
	private ChatRecentFriends _chatRecentFriends; // 0x198
	private bool isDraging; // 0x1A0
	private MonoPS4IMEProxy _proxy; // 0x1A8
	private Transform _currentFocusTarget; // 0x1B0
	private bool _checkCloseError; // 0x1B8
	private float _currCheckTime; // 0x1BC
	private float _maxTime; // 0x1C0
	private float _currCheckActive; // 0x1C4
	private float _checkActiveInterval; // 0x1C8

	// Properties
	public bool NeedCheckStart { /* [XID] */ /* 0x0000000189724D90-0x0000000189724DB0 */ set {} } // 0x0000000182493280-0x0000000182493330
	public bool NoChatContentTips { /* [XID] */ /* 0x000000018972C540-0x000000018972C560 */ set {} } // 0x0000000182497260-0x0000000182497360

	// Constructors
	public ChatPageContext() {} // Dummy constructor
	public ChatPageContext(ChatChannel defaultChannel = ChatChannel.ChannelTest /* Metadata: 0x00B0D88E */, bool inMain = true /* Metadata: 0x00B0D892 */) {} // 0x000000018249CB90-0x000000018249CCE0

	// Methods
	// [XID] // 0x000000018971D970-0x000000018971D990
	public bool IsTalkingTo(ChatChannel channel, uint uid) => default; // 0x00000001824931A0-0x0000000182493280
	// [XID] // 0x0000000189733CA0-0x0000000189733CC0
	public void CheckInitChannel() {} // 0x0000000182493330-0x0000000182493640
	// [XID] // 0x000000018973B3C0-0x000000018973B3E0
	public void InitChannel(ChatChannel channel, uint uid) {} // 0x0000000182497D30-0x0000000182497E40
	// [XID] // 0x0000000189742D30-0x0000000189742D50
	public override void SetupView() {} // 0x000000018249BBF0-0x000000018249C830
	// [XID] // 0x000000018974AA50-0x000000018974AA70
	private void OnBeginDrag() {} // 0x0000000182498780-0x0000000182498820
	// [XID] // 0x0000000189751B30-0x0000000189751B50
	private void OnEndDrag() {} // 0x000000018249B030-0x000000018249B0F0
	// [XID] // 0x0000000189759120-0x0000000189759140
	public void TryRemoveTalkTarget(uint uid) {} // 0x0000000182496E10-0x0000000182496F40
	// [XID] // 0x0000000189760D70-0x0000000189760D90
	public void TryTalkTarget(uint uid, bool forceAdd = false /* Metadata: 0x00B0D893 */, ChatChannel channel = ChatChannel.ChannelNone /* Metadata: 0x00B0D894 */) {} // 0x0000000182498C50-0x0000000182498D70
	// [XID] // 0x00000001897680D0-0x00000001897680F0
	public void TryAddTalkTarget(uint uid) {} // 0x0000000182494020-0x0000000182494150
	// [XID] // 0x000000018976F6A0-0x000000018976F6C0
	private void RefreshJoypadButton() {} // 0x0000000182497760-0x0000000182497860
	// [XID] // 0x0000000189777020-0x0000000189777040
	public void RefreshTalkContent(ChatFriendData chatFriendData) {} // 0x0000000182498D70-0x0000000182499160
	// [XID] // 0x000000018977E740-0x000000018977E760
	private void RefreshTitle(ChatChannel channel, uint uid) {} // 0x0000000182497E40-0x0000000182498360
	// [XID] // 0x0000000189785EF0-0x0000000189785F10
	public void OnReturnPressed() {} // 0x000000018249BAB0-0x000000018249BBF0
	// [XID] // 0x000000018978D590-0x000000018978D5B0
	public void ResetPos() {} // 0x000000018249B180-0x000000018249B5E0
	// [XID] // 0x00000001897949D0-0x00000001897949F0
	public void SetBackColor(bool isInMain = true /* Metadata: 0x00B0D898 */) {} // 0x000000018249AF20-0x000000018249B030
	// [XID] // 0x000000018979CE00-0x000000018979CE20
	private void OnInputTextChanged(string inputText) {} // 0x0000000182494D90-0x0000000182494F30
	// [XID] // 0x00000001897A4220-0x00000001897A4240
	private void OnNativeInputTextChanged(string text) {} // 0x0000000182495240-0x00000001824953C0
	// [XID] // 0x00000001897AB780-0x00000001897AB7A0
	private bool CheckNameStringValid(string name) => default; // 0x00000001824949C0-0x0000000182494B50
	// [XID] // 0x00000001897B35D0-0x00000001897B35F0
	private void FocusOnInputField() {} // 0x000000018249A140-0x000000018249A440
	// [XID] // 0x00000001897BB510-0x00000001897BB530
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001824974B0-0x0000000182497690
	// [XID] // 0x00000001897C2D30-0x00000001897C2D50
	private void TryRefreshActiveSendBtn() {} // 0x0000000182496F40-0x0000000182497160
	// [XID] // 0x00000001897CA530-0x00000001897CA550
	private void CheckBtnMoreShown() {} // 0x00000001824953C0-0x00000001824954F0
	// [XID] // 0x00000001897D1B50-0x00000001897D1B70
	private void SetJoypadState(int state, bool force) {} // 0x00000001824991D0-0x0000000182499CB0
	// [XID] // 0x00000001897D9A50-0x00000001897D9A70
	private void ClearFocusTarget() {} // 0x0000000182497AF0-0x0000000182497C70
	// [XID] // 0x00000001897E0D30-0x00000001897E0D50
	private Transform FindNextFocusTarget(bool prev) => default; // 0x0000000182498360-0x0000000182498780
	// [XID] // 0x00000001897E83B0-0x00000001897E83D0
	private bool HandleChatOperationInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018249B910-0x000000018249BAB0
	// [XID] // 0x00000001897F0090-0x00000001897F00B0
	public void RefreshPlayerSocialDetail(uint uid) {} // 0x0000000182493640-0x0000000182493820
	// [XID] // 0x00000001897F7840-0x00000001897F7860
	private bool HandleScrollInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182499DB0-0x000000018249A060
	// [XID] // 0x00000001897FEF30-0x00000001897FEF50
	private bool HandleNormalInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001824954F0-0x0000000182495FA0
	// [XID] // 0x00000001898066D0-0x00000001898066F0
	private bool HandleQuickInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182495FA0-0x00000001824963E0
	// [XID] // 0x000000018980DE10-0x000000018980DE30
	private bool HandleEmojiInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018249A440-0x000000018249A9A0
	// [XID] // 0x0000000189815530-0x0000000189815550
	private void OnScrollerValueChanged(Vector2 scrollerValue) {} // 0x0000000182496BD0-0x0000000182496C80
	// [XID] // 0x000000018981CF70-0x000000018981CF90
	public override void ClearView() {} // 0x0000000182494B50-0x0000000182494D90
	// [XID] // 0x0000000189824310-0x0000000189824330
	protected override void BindViewCallbacks() {} // 0x0000000182493890-0x0000000182494020
	// [XID] // 0x000000018982BDE0-0x000000018982BE00
	private void OpenMore() {} // 0x00000001824950E0-0x0000000182495240
	// [XID] // 0x0000000189833370-0x0000000189833390
	private void CloseMore() {} // 0x0000000182496680-0x0000000182496770
	// [XID] // 0x000000018983A7E0-0x000000018983A800
	public void OnClickRemoveCurrTalkingTarget() {} // 0x0000000182496C80-0x0000000182496E10
	// [XID] // 0x0000000189841E60-0x0000000189841E80
	private void BlockCurrTarget() {} // 0x0000000182496770-0x0000000182496810
	// [XID] // 0x0000000189849330-0x0000000189849350
	private void OpenAddFriendDialog() {} // 0x0000000182497160-0x0000000182497260
	// [XID] // 0x0000000189850AD0-0x0000000189850AF0
	private void ReadNewMessage() {} // 0x000000018249A060-0x000000018249A140
	// [XID] // 0x0000000189857EC0-0x0000000189857EE0
	private void ToggleEmoji(bool open) {} // 0x00000001824968A0-0x0000000182496B60
	// [XID] // 0x000000018985EFD0-0x000000018985EFF0
	private void OnInitEmojiSlot(Transform trans, int index) {} // 0x00000001824963E0-0x0000000182496680
	// [XID] // 0x0000000189866790-0x00000001898667B0
	private void ToggleQuickChat(bool open) {} // 0x0000000182498820-0x0000000182498AE0
	// [XID] // 0x000000018986E090-0x000000018986E0B0
	private void OnInitQuickChatSlot(Transform trans, int index) {} // 0x0000000182494250-0x0000000182494470
	// [XID] // 0x00000001898754C0-0x00000001898754E0
	private void Talk(string content = "" /* Metadata: 0x00B0D899 */) {} // 0x0000000182494470-0x0000000182494950
	// [XID] // 0x000000018987CFD0-0x000000018987CFF0
	private void TalkEmoji(int index) {} // 0x000000018249A9A0-0x000000018249AAB0
	// [XID] // 0x0000000189883F90-0x0000000189883FB0
	public void CheckUnread() {} // 0x0000000182494F30-0x00000001824950E0
	// [XID] // 0x000000018988B6D0-0x000000018988B6F0
	public void StartCheckErrorBubble() {} // 0x0000000182494150-0x0000000182494250
	// [XID] // 0x0000000189892DD0-0x0000000189892DF0
	public void EndErrorBubble() {} // 0x0000000182497360-0x0000000182497450
	// [XID] // 0x000000018989A450-0x000000018989A470
	public override void UpdateView() {} // 0x000000018249C830-0x000000018249CB90
	// [XID] // 0x00000001898A1670-0x00000001898A1690
	public override bool OnNotify(Notify ntf) => default; // 0x000000018249B5E0-0x000000018249B910
	// [XID] // 0x00000001898A8F20-0x00000001898A8F40
	private void LoadChannelAndTargetUid() {} // 0x0000000182498B50-0x0000000182498C50
	// [XID] // 0x00000001898B0860-0x00000001898B0880
	private void SaveChannelAndTargetUid() {} // 0x0000000182499CB0-0x0000000182499DB0
	// [XID] // 0x00000001898B7EB0-0x00000001898B7ED0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x000000018249AAB0-0x000000018249AB90
	// [XID] // 0x00000001898BF580-0x00000001898BF5A0
	private void SetBlockChatImg(uint uid) {} // 0x000000018249AB90-0x000000018249AEC0
}

