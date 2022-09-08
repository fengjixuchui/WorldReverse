/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SystemOpenUIConfig : IAutoAllocRecycle // TypeDefIndex: 15936
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _icon_path; // 0x18
	protected uint _descTextMapHash; // 0x20
	protected SimpleSafeUInt32 tutorial_idRawNum; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899DC190-0x00000001899DC1B0 */ get => default; /* [XID] */ /* 0x00000001899E3A10-0x00000001899E3A30 */ protected set {} } // 0x00000001837BA710-0x00000001837BA7E0 0x00000001837B9C20-0x00000001837B9D00
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001899EAEA0-0x00000001899EAEC0 */ get => default; /* [XID] */ /* 0x00000001899F2AC0-0x00000001899F2AE0 */ protected set {} } // 0x00000001837B9120-0x00000001837B91C0 0x00000001837BA2F0-0x00000001837BA3A0
	public string name { /* [XID] */ /* 0x00000001899FA0B0-0x00000001899FA0D0 */ get => default; } // 0x00000001837BA7E0-0x00000001837BA960 
	public string icon_path { /* [XID] */ /* 0x0000000189A01430-0x0000000189A01450 */ get => default; /* [XID] */ /* 0x0000000189A08D70-0x0000000189A08D90 */ protected set {} } // 0x00000001837BA3A0-0x00000001837BA440 0x00000001837BA440-0x00000001837BA4F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A10370-0x0000000189A10390 */ get => default; /* [XID] */ /* 0x0000000189A178F0-0x0000000189A17910 */ protected set {} } // 0x00000001837BA250-0x00000001837BA2F0 0x00000001837B91C0-0x00000001837B9270
	public string desc { /* [XID] */ /* 0x0000000189A1EFB0-0x0000000189A1EFD0 */ get => default; } // 0x00000001837B9AA0-0x00000001837B9C20 
	public uint tutorial_id { /* [XID] */ /* 0x0000000189A265E0-0x0000000189A26600 */ get => default; /* [XID] */ /* 0x0000000189A2D910-0x0000000189A2D930 */ protected set {} } // 0x00000001837B99D0-0x00000001837B9AA0 0x00000001837BA4F0-0x00000001837BA5D0

	// Constructors
	public SystemOpenUIConfig() {} // 0x00000001837BAA00-0x00000001837BAA60

	// Methods
	// [IDTag] // 0x0000000189A354D0-0x0000000189A35510
	// [XID] // 0x0000000189A354D0-0x0000000189A35510
	public virtual bool ParseFromLine(string line) => default; // 0x00000001837B9610-0x00000001837B99D0
	// [IDTag] // 0x0000000189A3FBC0-0x0000000189A3FC00
	// [XID] // 0x0000000189A3FBC0-0x0000000189A3FC00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837B9270-0x00000001837B9610
	// [XID] // 0x0000000189A4A060-0x0000000189A4A080
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BA4 */, bool useObjectPool = false /* Metadata: 0x00AF2BA8 */) => default; // 0x00000001837B9D00-0x00000001837BA250
	[BlackList] // 0x0000000189A519F0-0x0000000189A51A30
	// [XID] // 0x0000000189A519F0-0x0000000189A51A30
	public virtual void AutoAllocTypeFields() {} // 0x00000001837B8F90-0x00000001837B9030
	[BlackList] // 0x0000000189A5C3E0-0x0000000189A5C420
	// [XID] // 0x0000000189A5C3E0-0x0000000189A5C420
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837B9030-0x00000001837B9120
	[BlackList] // 0x0000000189A66BC0-0x0000000189A66C00
	// [XID] // 0x0000000189A66BC0-0x0000000189A66C00
	public virtual void ReturnToObjectPool() {} // 0x00000001837BA960-0x00000001837BAA00
	[BlackList] // 0x0000000189A71180-0x0000000189A711C0
	// [XID] // 0x0000000189A71180-0x0000000189A711C0
	public virtual void OnPoolAllocated() {} // 0x00000001837BA670-0x00000001837BA710
	[BlackList] // 0x0000000189A7BD00-0x0000000189A7BD40
	// [XID] // 0x0000000189A7BD00-0x0000000189A7BD40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837BA5D0-0x00000001837BA670
}

