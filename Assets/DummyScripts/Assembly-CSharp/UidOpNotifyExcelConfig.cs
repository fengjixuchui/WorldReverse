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
public class UidOpNotifyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16037
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _contentTextMapHash; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897A0510-0x00000001897A0530 */ get => default; /* [XID] */ /* 0x00000001897A7AC0-0x00000001897A7AE0 */ protected set {} } // 0x0000000182B9DBC0-0x0000000182B9DC90 0x0000000182B9D370-0x0000000182B9D450
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x00000001897AF550-0x00000001897AF570 */ get => default; /* [XID] */ /* 0x00000001897B7450-0x00000001897B7470 */ protected set {} } // 0x0000000182B9D9E0-0x0000000182B9DA80 0x0000000182B9D450-0x0000000182B9D500
	public string content { /* [XID] */ /* 0x00000001897BF2D0-0x00000001897BF2F0 */ get => default; } // 0x0000000182B9D860-0x0000000182B9D9E0 

	// Constructors
	public UidOpNotifyExcelConfig() {} // 0x0000000182B9DD30-0x0000000182B9DD90

	// Methods
	// [IDTag] // 0x00000001897C6900-0x00000001897C6940
	// [XID] // 0x00000001897C6900-0x00000001897C6940
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B9CEE0-0x0000000182B9D150
	// [IDTag] // 0x00000001897D0E30-0x00000001897D0E70
	// [XID] // 0x00000001897D0E30-0x00000001897D0E70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B9D150-0x0000000182B9D370
	// [XID] // 0x00000001897DB7B0-0x00000001897DB7D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E8C */, bool useObjectPool = false /* Metadata: 0x00AF2E90 */) => default; // 0x0000000182B9D500-0x0000000182B9D860
	[BlackList] // 0x00000001897E2FC0-0x00000001897E3000
	// [XID] // 0x00000001897E2FC0-0x00000001897E3000
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B9CD70-0x0000000182B9CE10
	[BlackList] // 0x00000001897EDAF0-0x00000001897EDB30
	// [XID] // 0x00000001897EDAF0-0x00000001897EDB30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B9CE10-0x0000000182B9CEE0
	[BlackList] // 0x00000001897F8440-0x00000001897F8480
	// [XID] // 0x00000001897F8440-0x00000001897F8480
	public virtual void ReturnToObjectPool() {} // 0x0000000182B9DC90-0x0000000182B9DD30
	[BlackList] // 0x0000000189802AA0-0x0000000189802AE0
	// [XID] // 0x0000000189802AA0-0x0000000189802AE0
	public virtual void OnPoolAllocated() {} // 0x0000000182B9DB20-0x0000000182B9DBC0
	[BlackList] // 0x000000018980CD90-0x000000018980CDD0
	// [XID] // 0x000000018980CD90-0x000000018980CDD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B9DA80-0x0000000182B9DB20
}

