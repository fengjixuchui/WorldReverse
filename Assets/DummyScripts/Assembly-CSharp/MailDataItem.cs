/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MailDataItem : IComparable<MailDataItem> // TypeDefIndex: 21550
{
	// Fields
	public bool isAttachmentGot; // 0x10
	public bool isRead; // 0x11
	public uint mailId; // 0x14
	public uint importance; // 0x18
	public uint sendTime; // 0x1C
	public uint expireTime; // 0x20
	public uint excelMailId; // 0x24
	public string title; // 0x28
	public string sender; // 0x30
	public string content; // 0x38
	public List<SimpleItemStruct> itemList; // 0x40
	public List<string> paramList; // 0x48

	// Properties
	public bool isStar { /* [XID] */ /* 0x0000000189760EF0-0x0000000189760F10 */ get => default; /* [XID] */ /* 0x0000000189768280-0x00000001897682A0 */ set {} } // 0x00000001824746F0-0x00000001824747A0 0x0000000182474630-0x00000001824746F0
	public bool isExpired { /* [XID] */ /* 0x000000018976F850-0x000000018976F870 */ get => default; } // 0x00000001824743C0-0x00000001824744A0 

	// Constructors
	public MailDataItem() {} // 0x0000000182474F60-0x0000000182475030

	// Methods
	// [XID] // 0x00000001897771B0-0x00000001897771D0
	public int CompareTo(MailDataItem y) => default; // 0x00000001824744A0-0x0000000182474630
	// [XID] // 0x000000018977E8E0-0x000000018977E900
	public MailDataItem FromProtocol(MailData mailData) => default; // 0x00000001824747A0-0x0000000182474B90
	// [XID] // 0x00000001897860A0-0x00000001897860C0
	private int CompareAttachItem(SimpleItemStruct x, SimpleItemStruct y) => default; // 0x0000000182474B90-0x0000000182474F60
}

