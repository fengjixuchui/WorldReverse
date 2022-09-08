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

public class MainPageChatBubbleDisplayer : IChatDataListener // TypeDefIndex: 28476
{
	// Fields
	private readonly string ChatBubblePath; // 0x10
	private uint handle; // 0x18
	private GameObject ChatBubblePrefab; // 0x20
	private TextGenerator _generator; // 0x28
	private int _countVisible; // 0x30
	private List<MonoMPTeamBtn> teamBtnList; // 0x38
	private Dictionary<uint, GameObject> bubbleDictionary; // 0x40
	private string chatToShow; // 0x48

	// Properties
	public List<MonoMPTeamBtn> TeamBtnList { /* [XID] */ /* 0x0000000189AC4E40-0x0000000189AC4E60 */ set {} } // 0x0000000182200D20-0x0000000182200DD0

	// Constructors
	public MainPageChatBubbleDisplayer() {} // 0x0000000182201930-0x00000001822019D0

	// Methods
	// [XID] // 0x0000000189ACC480-0x0000000189ACC4A0
	public void Init(List<MonoMPTeamBtn> teamList) {} // 0x0000000182200DD0-0x0000000182200F10
	// [XID] // 0x0000000189AD4100-0x0000000189AD4120
	public void Terminate() {} // 0x00000001822016C0-0x0000000182201930
	// [XID] // 0x0000000189ADBB00-0x0000000189ADBB20
	void MoleMole.IChatDataListener.PushChatData(List<ChatInfo> listChatInfo) {} // 0x0000000182201610-0x00000001822016C0
	// [XID] // 0x0000000189AE3480-0x0000000189AE34A0
	void MoleMole.IChatDataListener.AddChatData(ChatChannel channel, ChatInfo chatInfo, int msgType) {} // 0x0000000182200F10-0x0000000182201540
	// [XID] // 0x0000000189AEADF0-0x0000000189AEAE10
	bool MoleMole.IChatDataListener.CheckChannel(ChatChannel channel, uint id) => default; // 0x0000000182201540-0x0000000182201610
}

