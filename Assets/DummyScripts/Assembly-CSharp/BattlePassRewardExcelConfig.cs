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
public class BattlePassRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15252
{
	// Fields
	protected SimpleSafeUInt32 indexIdRawNum; // 0x10
	protected SimpleSafeUInt32 levelRawNum; // 0x14
	protected SimpleSafeUInt32[] _freeRewardIdList; // 0x18
	protected SimpleSafeUInt32[] _paidRewardIdList; // 0x20
	protected bool _showUp; // 0x28

	// Properties
	public uint indexId { /* [XID] */ /* 0x000000018968BA70-0x000000018968BA90 */ get => default; /* [XID] */ /* 0x00000001896936C0-0x00000001896936E0 */ protected set {} } // 0x0000000184716C20-0x0000000184716CF0 0x00000001847156A0-0x0000000184715780
	public uint level { /* [XID] */ /* 0x000000018969A9B0-0x000000018969A9D0 */ get => default; /* [XID] */ /* 0x00000001896A2440-0x00000001896A2460 */ protected set {} } // 0x0000000184716B50-0x0000000184716C20 0x0000000184716A70-0x0000000184716B50
	public SimpleSafeUInt32[] freeRewardIdList { /* [XID] */ /* 0x00000001896A9620-0x00000001896A9640 */ get => default; /* [XID] */ /* 0x00000001896B0730-0x00000001896B0750 */ protected set {} } // 0x00000001847163C0-0x0000000184716460 0x0000000184716460-0x0000000184716510
	public SimpleSafeUInt32[] paidRewardIdList { /* [XID] */ /* 0x00000001896B8130-0x00000001896B8150 */ get => default; /* [XID] */ /* 0x00000001896BF210-0x00000001896BF230 */ protected set {} } // 0x0000000184716CF0-0x0000000184716D90 0x0000000184716D90-0x0000000184716E40
	public bool showUp { /* [XID] */ /* 0x00000001896C6A90-0x00000001896C6AB0 */ get => default; /* [XID] */ /* 0x00000001896CE1D0-0x00000001896CE1F0 */ protected set {} } // 0x0000000184715780-0x0000000184715820 0x0000000184716E40-0x0000000184716EF0

	// Constructors
	public BattlePassRewardExcelConfig() {} // 0x00000001847170D0-0x0000000184717130

	// Methods
	// [IDTag] // 0x00000001896D57A0-0x00000001896D57E0
	// [XID] // 0x00000001896D57A0-0x00000001896D57E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184715820-0x0000000184715E10
	// [IDTag] // 0x00000001896DFF40-0x00000001896DFF80
	// [XID] // 0x00000001896DFF40-0x00000001896DFF80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184715E10-0x00000001847163C0
	// [XID] // 0x00000001896EA380-0x00000001896EA3A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0541 */, bool useObjectPool = false /* Metadata: 0x00AF0545 */) => default; // 0x0000000184716510-0x0000000184716A70
	[BlackList] // 0x00000001896F12A0-0x00000001896F12E0
	// [XID] // 0x00000001896F12A0-0x00000001896F12E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184715510-0x00000001847155B0
	[BlackList] // 0x00000001896FBFD0-0x00000001896FC010
	// [XID] // 0x00000001896FBFD0-0x00000001896FC010
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847155B0-0x00000001847156A0
	[BlackList] // 0x00000001897063C0-0x0000000189706400
	// [XID] // 0x00000001897063C0-0x0000000189706400
	public virtual void ReturnToObjectPool() {} // 0x0000000184717030-0x00000001847170D0
	[BlackList] // 0x0000000189710F30-0x0000000189710F70
	// [XID] // 0x0000000189710F30-0x0000000189710F70
	public virtual void OnPoolAllocated() {} // 0x0000000184716F90-0x0000000184717030
	[BlackList] // 0x000000018971B620-0x000000018971B660
	// [XID] // 0x000000018971B620-0x000000018971B660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184716EF0-0x0000000184716F90
}

