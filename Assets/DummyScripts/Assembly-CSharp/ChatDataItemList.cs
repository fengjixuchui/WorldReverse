/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ChatDataItemList : IChatDataListener // TypeDefIndex: 28456
{
	// Fields
	public List<ChatDataItem> chatDataList; // 0x10
	public bool hasNewItem; // 0x18
	public List<GameObject> chatObjList; // 0x20
	public ChatChannel currChannel; // 0x28
	private uint _targetUid; // 0x2C
	public bool dirty; // 0x30
	private ChatPageContext _context; // 0x38
	public RectTransform contentRectTrans; // 0x40
	public RectTransform scrollerRectTrans; // 0x48
	public float scrollParentHeight; // 0x50
	public bool autoPop; // 0x54
	public bool goingUp; // 0x55
	public bool goingDown; // 0x56
	public readonly int PreloadCount; // 0x58
	public readonly int RefreshNewCount; // 0x5C
	private LayoutElement placeHolderUp; // 0x60
	private LayoutElement placeHolderDown; // 0x68
	public float contentPaddingSpace; // 0x70
	private int firstShown; // 0x74
	private int lastShown; // 0x78
	private float autoScrollLength; // 0x7C
	private float autoScrollSpeed; // 0x80
	private readonly float AUTO_SCROLL_TIME; // 0x84
	private readonly uint showTimeInterval; // 0x88
	private bool hyperSpeedMode; // 0x8C

	// Constructors
	public ChatDataItemList() {} // 0x0000000182FE5BE0-0x0000000182FE5D00

	// Methods
	// [XID] // 0x00000001899E8EE0-0x00000001899E8F00
	public void Init(ChatChannel channel, uint uid, RectTransform contentAnchor, RectTransform scroller, ChatPageContext context) {} // 0x0000000182FE3F70-0x0000000182FE4190
	// [XID] // 0x00000001899F0880-0x00000001899F08A0
	public void SetChannel(ChatChannel channel, uint uid) {} // 0x0000000182FE4610-0x0000000182FE4880
	// [XID] // 0x00000001899F7E80-0x00000001899F7EA0
	void MoleMole.IChatDataListener.PushChatData(List<ChatInfo> listChatInfo) {} // 0x0000000182FE4CE0-0x0000000182FE4E30
	// [XID] // 0x00000001899FF530-0x00000001899FF550
	private void RefreshChatData() {} // 0x0000000182FE39A0-0x0000000182FE3B80
	// [XID] // 0x0000000189A06DB0-0x0000000189A06DD0
	public void SetAutoPop(bool needAutoPop) {} // 0x0000000182FE59C0-0x0000000182FE5A80
	// [XID] // 0x0000000189A0E480-0x0000000189A0E4A0
	private void SetPivot(float newY) {} // 0x0000000182FE5A80-0x0000000182FE5BE0
	// [XID] // 0x0000000189A15A20-0x0000000189A15A40
	public void GotoNewMessage() {} // 0x0000000182FE3250-0x0000000182FE3490
	// [XID] // 0x0000000189A1CEE0-0x0000000189A1CF00
	public void CheckBound() {} // 0x0000000182FE4F70-0x0000000182FE50D0
	// [XID] // 0x0000000189A244C0-0x0000000189A244E0
	public void CheckPopUp() {} // 0x0000000182FE3C60-0x0000000182FE3E80
	// [XID] // 0x0000000189A2B8E0-0x0000000189A2B900
	public void CheckItemRecycle() {} // 0x0000000182FE4460-0x0000000182FE4610
	// [XID] // 0x0000000189A32F60-0x0000000189A32F80
	public void ResetPlaceHolder(bool up) {} // 0x0000000182FE3B80-0x0000000182FE3C60
	// [XID] // 0x0000000189A3A7D0-0x0000000189A3A7F0
	public void AdjustPlaceHolder(float value) {} // 0x0000000182FE4E30-0x0000000182FE4F70
	// [XID] // 0x0000000189A42180-0x0000000189A421A0
	public bool IsAutoMoving() => default; // 0x0000000182FE3E80-0x0000000182FE3F70
	// [XID] // 0x0000000189A49710-0x0000000189A49730
	private void CheckAutoScroll() {} // 0x0000000182FE35F0-0x0000000182FE39A0
	// [XID] // 0x0000000189A510A0-0x0000000189A510C0
	private void BookKeepChatItem() {} // 0x0000000182FE50D0-0x0000000182FE5770
	// [XID] // 0x0000000189A58660-0x0000000189A58680
	public void RefreshData() {} // 0x0000000182FE4370-0x0000000182FE4460
	// [XID] // 0x0000000189A60120-0x0000000189A60140
	private void DoAddChatData(ChatData chatData, bool checkShow = false /* Metadata: 0x00B0D877 */) {} // 0x0000000182FE3490-0x0000000182FE35F0
	// [XID] // 0x0000000189A67D80-0x0000000189A67DA0
	public int GetNewMsgCount() => default; // 0x0000000182FE4880-0x0000000182FE4A40
	// [XID] // 0x0000000189A6F190-0x0000000189A6F1B0
	private void CheckAddTimestamp(ChatInfo chatInfo, bool checkShow = false /* Metadata: 0x00B0D878 */) {} // 0x0000000182FE4190-0x0000000182FE4370
	// [XID] // 0x0000000189A76990-0x0000000189A769B0
	void MoleMole.IChatDataListener.AddChatData(ChatChannel channel, ChatInfo chatInfo, int msgType) {} // 0x0000000182FE4A40-0x0000000182FE4C00
	// [XID] // 0x0000000189A7E260-0x0000000189A7E280
	bool MoleMole.IChatDataListener.CheckChannel(ChatChannel channel, uint uid) => default; // 0x0000000182FE4C00-0x0000000182FE4CE0
	// [XID] // 0x0000000189A85C60-0x0000000189A85C80
	public void ClearData() {} // 0x0000000182FE57E0-0x0000000182FE59C0
	// [XID] // 0x0000000189A8D540-0x0000000189A8D560
	public void Unsubscribe() {} // 0x0000000182FE3170-0x0000000182FE3250
}

