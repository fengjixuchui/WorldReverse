/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct DeviceAction : IEmptyInitable, IHashable // TypeDefIndex: 19104
{
	// Fields
	private string _keyboardTouch; // 0x00
	private string _keyboardMouse; // 0x08
	private string _joypad; // 0x10

	// Properties
	public string keyboardTouch { /* [XID] */ /* 0x000000018969D610-0x000000018969D630 */ get => default; /* [XID] */ /* 0x00000001896A46A0-0x00000001896A46C0 */ private set {} } // 0x0000000181518A70-0x0000000181518B30 0x0000000181518B30-0x0000000181518BE0
	public string keyboardMouse { /* [XID] */ /* 0x00000001896ABE50-0x00000001896ABE70 */ get => default; /* [XID] */ /* 0x00000001896B3090-0x00000001896B30B0 */ private set {} } // 0x000000018151A180-0x000000018151A190 0x0000000181519720-0x0000000181519810
	public string joypad { /* [XID] */ /* 0x00000001896BA7F0-0x00000001896BA810 */ get => default; /* [XID] */ /* 0x00000001896C1920-0x00000001896C1940 */ private set {} } // 0x00000001815186E0-0x00000001815189C0 0x00000001815194B0-0x00000001815195A0

	// Methods
	// [IDTag] // 0x00000001896C9030-0x00000001896C9070
	// [XID] // 0x00000001896C9030-0x00000001896C9070
	public bool Equals(DeviceAction otherVal) => default; // 0x0000000181519CB0-0x0000000181519FA0
	// [IDTag] // 0x00000001896D3300-0x00000001896D3340
	// [XID] // 0x00000001896D3300-0x00000001896D3340
	public override bool Equals(object other) => default; // 0x0000000181519060-0x00000001815193F0
	// [XID] // 0x00000001896DDD60-0x00000001896DDD80
	public override int GetHashCode() => default; // 0x00000001815195A0-0x0000000181519660
	// [XID] // 0x00000001896E5350-0x00000001896E5370
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018151A0D0-0x000000018151A180
	// [XID] // 0x00000001896EC8E0-0x00000001896EC900
	public void InitEmpty() {} // 0x0000000181519810-0x0000000181519B20
	[BlackList] // 0x00000001896F4120-0x00000001896F4160
	// [XID] // 0x00000001896F4120-0x00000001896F4160
	public bool FromJson(JSONNode node) => default; // 0x00000001815193F0-0x00000001815194B0
	// [XID] // 0x000000018988B120-0x000000018988B140
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181518630-0x00000001815186E0
	// [XID] // 0x0000000189705DC0-0x0000000189705DE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1E3 */, bool useObjectPool = false /* Metadata: 0x00AFC1E7 */) => default; // 0x0000000181519B20-0x0000000181519CB0
	// [XID] // 0x000000018961B440-0x000000018961B460
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1E8 */, bool useObjectPool = false /* Metadata: 0x00AFC1EC */) => default; // 0x0000000181518F40-0x0000000181519060
	[BlackList] // 0x0000000189714B70-0x0000000189714BB0
	// [XID] // 0x0000000189714B70-0x0000000189714BB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001815189C0-0x0000000181518A70
	// [XID] // 0x000000018971F650-0x000000018971F670
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181519FA0-0x000000018151A0D0
}

