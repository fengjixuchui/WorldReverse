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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlossomTalkExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15279
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 refreshIdRawNum; // 0x14
	protected SimpleSafeUInt32 groupIdRawNum; // 0x18
	protected SimpleSafeUInt32[] _talkId; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x000000018969F0D0-0x000000018969F0F0 */ get => default; /* [XID] */ /* 0x00000001896A6570-0x00000001896A6590 */ protected set {} } // 0x00000001810FAEB0-0x00000001810FAF80 0x00000001810FA630-0x00000001810FA710
	public uint refreshId { /* [XID] */ /* 0x00000001896ADA70-0x00000001896ADA90 */ get => default; /* [XID] */ /* 0x00000001896B52D0-0x00000001896B52F0 */ protected set {} } // 0x00000001810FA560-0x00000001810FA630 0x00000001810FA480-0x00000001810FA560
	public uint groupId { /* [XID] */ /* 0x00000001896BC460-0x00000001896BC480 */ get => default; /* [XID] */ /* 0x00000001896C3B00-0x00000001896C3B20 */ protected set {} } // 0x00000001810FABC0-0x00000001810FAC90 0x00000001810FAC90-0x00000001810FAD70
	public SimpleSafeUInt32[] talkId { /* [XID] */ /* 0x00000001896CAFF0-0x00000001896CB010 */ get => default; /* [XID] */ /* 0x00000001896D2580-0x00000001896D25A0 */ protected set {} } // 0x00000001810FAF80-0x00000001810FB020 0x00000001810F99D0-0x00000001810F9A80

	// Constructors
	public BlossomTalkExcelConfig() {} // 0x00000001810FB0C0-0x00000001810FB120

	// Methods
	// [IDTag] // 0x00000001896DA010-0x00000001896DA050
	// [XID] // 0x00000001896DA010-0x00000001896DA050
	public virtual bool ParseFromLine(string line) => default; // 0x00000001810F9F60-0x00000001810FA480
	// [IDTag] // 0x00000001896E4590-0x00000001896E45D0
	// [XID] // 0x00000001896E4590-0x00000001896E45D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001810F9A80-0x00000001810F9F60
	// [XID] // 0x00000001896EE7F0-0x00000001896EE810
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0618 */, bool useObjectPool = false /* Metadata: 0x00AF061C */) => default; // 0x00000001810FA710-0x00000001810FABC0
	[BlackList] // 0x00000001896F6060-0x00000001896F60A0
	// [XID] // 0x00000001896F6060-0x00000001896F60A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001810F9830-0x00000001810F98D0
	[BlackList] // 0x0000000189700460-0x00000001897004A0
	// [XID] // 0x0000000189700460-0x00000001897004A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001810F98D0-0x00000001810F99D0
	[BlackList] // 0x000000018970AC40-0x000000018970AC80
	// [XID] // 0x000000018970AC40-0x000000018970AC80
	public virtual void ReturnToObjectPool() {} // 0x00000001810FB020-0x00000001810FB0C0
	[BlackList] // 0x0000000189715150-0x0000000189715190
	// [XID] // 0x0000000189715150-0x0000000189715190
	public virtual void OnPoolAllocated() {} // 0x00000001810FAE10-0x00000001810FAEB0
	[BlackList] // 0x000000018971FC70-0x000000018971FCB0
	// [XID] // 0x000000018971FC70-0x000000018971FCB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001810FAD70-0x00000001810FAE10
}

