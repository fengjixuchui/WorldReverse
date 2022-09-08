/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct MainPageChatDataStruct // TypeDefIndex: 28459
{
	// Fields
	private string _cachedShowText; // 0x00
	private ChatDataStruct _chatData; // 0x08

	// Properties
	public bool isClear { /* [XID] */ /* 0x0000000189ABD3F0-0x0000000189ABD410 */ get => default; } // 0x00000001836848E0-0x0000000183684910 
	public string showText { /* [XID] */ /* 0x0000000189AC4E60-0x0000000189AC4E80 */ get => default; } // 0x00000001836845A0-0x0000000183684660 

	// Methods
	// [XID] // 0x00000001897C5A50-0x00000001897C5A70
	public void Clear() {} // 0x0000000183684660-0x0000000183684730
	// [XID] // 0x0000000189AD4120-0x0000000189AD4140
	public bool isRelatedWith(uint uid) => default; // 0x0000000183684730-0x0000000183684820
	// [XID] // 0x0000000189ADBB20-0x0000000189ADBB40
	public void FromProto(ChatChannel channel, ChatInfo chatInfo) {} // 0x0000000183684820-0x00000001836848E0
}

