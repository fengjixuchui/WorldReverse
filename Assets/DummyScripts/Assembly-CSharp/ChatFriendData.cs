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

public class ChatFriendData : IComparable<ChatFriendData> // TypeDefIndex: 28468
{
	// Fields
	public uint uid; // 0x10
	public ChatFriendTab tab; // 0x18
	public bool hasNew; // 0x20
	public ChatChannel channel; // 0x24
	public ChatExcelConfig config; // 0x28

	// Constructors
	public ChatFriendData() {} // Dummy constructor
	public ChatFriendData(uint currUid, ChatChannel currChannel) {} // 0x0000000180F85220-0x0000000180F85340

	// Methods
	// [XID] // 0x000000018995EC60-0x000000018995EC80
	public int CompareTo(ChatFriendData data) => default; // 0x0000000180F85100-0x0000000180F85220
}

