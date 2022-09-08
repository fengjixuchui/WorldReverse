/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MainPageChatDataMgr // TypeDefIndex: 28460
{
	// Fields
	public const int DEFAULT_CAPACITY = 16; // Metadata: 0x00B0D885
	private MainPageChatDataStruct[] _list; // 0x18
	private MainPageChatDataStruct[] _listTemp; // 0x20

	// Properties
	public int Count { /* [XID] */ /* 0x0000000189AF86F0-0x0000000189AF8730 */ get; /* [XID] */ /* 0x0000000189B02C20-0x0000000189B02C60 */ private set; } // 0x0000000182B6C7D0-0x0000000182B6C830 0x0000000182B6BF60-0x0000000182B6BFC0
	public int Head { /* [XID] */ /* 0x0000000189B0D3A0-0x0000000189B0D3E0 */ get; /* [XID] */ /* 0x0000000189B17620-0x0000000189B17660 */ private set; } // 0x0000000182B6C520-0x0000000182B6C580 0x0000000182B6C830-0x0000000182B6C890
	public int Rear { /* [XID] */ /* 0x0000000189B21D60-0x0000000189B21D80 */ get => default; } // 0x0000000182B6C580-0x0000000182B6C6C0 

	// Constructors
	public MainPageChatDataMgr() {} // Dummy constructor
	public MainPageChatDataMgr(int capacity = 16 /* Metadata: 0x00B0D881 */) {} // 0x0000000182B6CD40-0x0000000182B6CE80

	// Methods
	// [XID] // 0x0000000189B293E0-0x0000000189B29400
	public void Clear() {} // 0x0000000182B6BFC0-0x0000000182B6C1B0
	// [XID] // 0x0000000189B307F0-0x0000000189B30810
	public string GetShowText(int index) => default; // 0x0000000182B6C890-0x0000000182B6CA10
	// [XID] // 0x0000000189B38090-0x0000000189B380B0
	public void RemoveAllByUid(uint uid) {} // 0x0000000182B6C1B0-0x0000000182B6C520
	// [XID] // 0x0000000189B3FAC0-0x0000000189B3FAE0
	public void AddChatMessage(ChatChannel channel, ChatInfo chatInfo) {} // 0x0000000182B6CA10-0x0000000182B6CD40
	// [XID] // 0x0000000189B47300-0x0000000189B47320
	private int GetFixedIndex(int index) => default; // 0x0000000182B6C6C0-0x0000000182B6C7D0
}

