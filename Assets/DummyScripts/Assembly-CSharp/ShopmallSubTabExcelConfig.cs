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
public class ShopmallSubTabExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16133
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected uint _subTagNameTextMapHash; // 0x14

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001898B57F0-0x00000001898B5810 */ get => default; /* [XID] */ /* 0x00000001898BD2A0-0x00000001898BD2C0 */ protected set {} } // 0x000000018297E5F0-0x000000018297E6C0 0x000000018297DF10-0x000000018297DFF0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subTagNameTextMapHash { /* [XID] */ /* 0x00000001898C4A00-0x00000001898C4A20 */ get => default; /* [XID] */ /* 0x00000001898CBF10-0x00000001898CBF30 */ protected set {} } // 0x000000018297ED90-0x000000018297EE30 0x000000018297EA20-0x000000018297EAD0
	public string subTagName { /* [XID] */ /* 0x00000001898D3710-0x00000001898D3730 */ get => default; } // 0x000000018297EAD0-0x000000018297EC50 

	// Constructors
	public ShopmallSubTabExcelConfig() {} // 0x000000018297EED0-0x000000018297EF30

	// Methods
	// [IDTag] // 0x00000001898DAF20-0x00000001898DAF60
	// [XID] // 0x00000001898DAF20-0x00000001898DAF60
	public virtual bool ParseFromLine(string line) => default; // 0x000000018297E160-0x000000018297E3D0
	// [IDTag] // 0x00000001898E5E60-0x00000001898E5EA0
	// [XID] // 0x00000001898E5E60-0x00000001898E5EA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018297E3D0-0x000000018297E5F0
	// [XID] // 0x00000001898F0880-0x00000001898F08A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3213 */, bool useObjectPool = false /* Metadata: 0x00AF3217 */) => default; // 0x000000018297E6C0-0x000000018297EA20
	[BlackList] // 0x00000001898F81D0-0x00000001898F8210
	// [XID] // 0x00000001898F81D0-0x00000001898F8210
	public virtual void AutoAllocTypeFields() {} // 0x000000018297DFF0-0x000000018297E090
	[BlackList] // 0x0000000189902A40-0x0000000189902A80
	// [XID] // 0x0000000189902A40-0x0000000189902A80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018297E090-0x000000018297E160
	[BlackList] // 0x000000018990D170-0x000000018990D1B0
	// [XID] // 0x000000018990D170-0x000000018990D1B0
	public virtual void ReturnToObjectPool() {} // 0x000000018297EE30-0x000000018297EED0
	[BlackList] // 0x0000000189917B60-0x0000000189917BA0
	// [XID] // 0x0000000189917B60-0x0000000189917BA0
	public virtual void OnPoolAllocated() {} // 0x000000018297ECF0-0x000000018297ED90
	[BlackList] // 0x00000001899223C0-0x0000000189922400
	// [XID] // 0x00000001899223C0-0x0000000189922400
	public virtual void OnBeforePoolRecycled() {} // 0x000000018297EC50-0x000000018297ECF0
}

