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
public class DisplayItemExcelConfig : ItemConfig, IAutoAllocRecycle // TypeDefIndex: 15493
{
	// Fields
	protected uint _typeDescTextMapHash; // 0x48
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x4C
	protected DisplayItemType _displayType; // 0x50
	protected SimpleSafeUInt32 paramRawNum; // 0x54

	// Properties
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeDescTextMapHash { /* [XID] */ /* 0x00000001898832B0-0x00000001898832D0 */ get => default; /* [XID] */ /* 0x000000018988A9F0-0x000000018988AA10 */ protected set {} } // 0x0000000182A12E10-0x0000000182A12EB0 0x0000000182A13CF0-0x0000000182A13DA0
	public string typeDesc { /* [XID] */ /* 0x0000000189891EC0-0x0000000189891EE0 */ get => default; } // 0x0000000182A13AC0-0x0000000182A13C40 
	public uint rankLevel { /* [XID] */ /* 0x0000000189899850-0x0000000189899870 */ get => default; /* [XID] */ /* 0x00000001898A0910-0x00000001898A0930 */ protected set {} } // 0x0000000182A12CB0-0x0000000182A12D80 0x0000000182A12BD0-0x0000000182A12CB0
	public DisplayItemType displayType { /* [XID] */ /* 0x00000001898A7FF0-0x00000001898A8010 */ get => default; /* [XID] */ /* 0x00000001898AFAD0-0x00000001898AFAF0 */ protected set {} } // 0x0000000182A119D0-0x0000000182A11A70 0x0000000182A13C40-0x0000000182A13CF0
	public uint param { /* [XID] */ /* 0x00000001898B7070-0x00000001898B7090 */ get => default; /* [XID] */ /* 0x00000001898BE820-0x00000001898BE840 */ protected set {} } // 0x0000000182A13EE0-0x0000000182A13FB0 0x0000000182A13E00-0x0000000182A13EE0

	// Constructors
	public DisplayItemExcelConfig() {} // 0x0000000182A14050-0x0000000182A140B0

	// Methods
	// [IDTag] // 0x00000001898C5FB0-0x00000001898C5FF0
	// [XID] // 0x00000001898C5FB0-0x00000001898C5FF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A11AD0-0x0000000182A12340
	// [IDTag] // 0x00000001898D0A60-0x00000001898D0AA0
	// [XID] // 0x00000001898D0A60-0x00000001898D0AA0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A12340-0x0000000182A12BD0
	// [XID] // 0x00000001898DB060-0x00000001898DB080
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C43 */, bool useObjectPool = false /* Metadata: 0x00AF1C47 */) => default; // 0x0000000182A12F10-0x0000000182A13AC0
	[BlackList] // 0x00000001898E2D60-0x00000001898E2DA0
	// [XID] // 0x00000001898E2D60-0x00000001898E2DA0
	public override void AutoAllocTypeFields() {} // 0x0000000182A117A0-0x0000000182A11840
	[BlackList] // 0x00000001898ED840-0x00000001898ED880
	// [XID] // 0x00000001898ED840-0x00000001898ED880
	public override void AutoRecycleTypeFields() {} // 0x0000000182A11840-0x0000000182A11930
	[BlackList] // 0x00000001898F82B0-0x00000001898F82F0
	// [XID] // 0x00000001898F82B0-0x00000001898F82F0
	public override void ReturnToObjectPool() {} // 0x0000000182A13FB0-0x0000000182A14050
}

