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

public class ChatDataItem // TypeDefIndex: 28453
{
	// Fields
	private ChatDataType _chatDataType; // 0x10
	public ChatData chatData; // 0x18
	public ChatDataItemStatus status; // 0x20
	public bool onTop; // 0x24
	private ChatDataItemList _list; // 0x28
	public GameObject relatedGo; // 0x30
	public MonoChatItemBase chatDataRenderer; // 0x38
	public bool needReducePlaceholder; // 0x40

	// Constructors
	public ChatDataItem() {} // 0x00000001821B6680-0x00000001821B66F0

	// Methods
	// [XID] // 0x00000001899A5D90-0x00000001899A5DB0
	public bool isShown() => default; // 0x00000001821B5F40-0x00000001821B6170
	// [XID] // 0x00000001899AD3F0-0x00000001899AD410
	public void SetStatus(ChatDataItemStatus newStatus) {} // 0x00000001821B63A0-0x00000001821B6680
	// [XID] // 0x00000001899B4C70-0x00000001899B4C90
	public void Init(ChatDataItemList list) {} // 0x00000001821B6170-0x00000001821B6220
	// [XID] // 0x00000001899BC3B0-0x00000001899BC3D0
	public void RefreshData(ChatData testData) {} // 0x00000001821B6220-0x00000001821B62E0
	// [XID] // 0x00000001899C3D30-0x00000001899C3D50
	public void OnGetGameObject(GameObject go) {} // 0x00000001821B62E0-0x00000001821B63A0
	// [XID] // 0x00000001899CB4D0-0x00000001899CB4F0
	public void Recycle() {} // 0x00000001821B5E40-0x00000001821B5F40
}

