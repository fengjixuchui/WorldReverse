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
public class ShopRotateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16113
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 rotateIdRawNum; // 0x14
	protected SimpleSafeUInt32 itemIdRawNum; // 0x18
	protected SimpleSafeUInt32 rotateOrderRawNum; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AF1A10-0x0000000189AF1A30 */ get => default; /* [XID] */ /* 0x0000000189AF91D0-0x0000000189AF91F0 */ protected set {} } // 0x00000001821BAF90-0x00000001821BB060 0x00000001821BA630-0x00000001821BA710
	public uint rotateId { /* [XID] */ /* 0x0000000189B006F0-0x0000000189B00710 */ get => default; /* [XID] */ /* 0x0000000189B07CD0-0x0000000189B07CF0 */ protected set {} } // 0x00000001821BB060-0x00000001821BB130 0x00000001821BAC90-0x00000001821BAD70
	public uint itemId { /* [XID] */ /* 0x0000000189B0F510-0x0000000189B0F530 */ get => default; /* [XID] */ /* 0x0000000189B16810-0x0000000189B16830 */ protected set {} } // 0x00000001821B9E10-0x00000001821B9EE0 0x00000001821BA550-0x00000001821BA630
	public uint rotateOrder { /* [XID] */ /* 0x0000000189B1DF30-0x0000000189B1DF50 */ get => default; /* [XID] */ /* 0x0000000189B257A0-0x0000000189B257C0 */ protected set {} } // 0x00000001821BABC0-0x00000001821BAC90 0x00000001821BAD70-0x00000001821BAE50

	// Constructors
	public ShopRotateExcelConfig() {} // 0x00000001821BB1D0-0x00000001821BB230

	// Methods
	// [IDTag] // 0x0000000189B2CC30-0x0000000189B2CC70
	// [XID] // 0x0000000189B2CC30-0x0000000189B2CC70
	public virtual bool ParseFromLine(string line) => default; // 0x00000001821B9EE0-0x00000001821BA230
	// [IDTag] // 0x0000000189B37230-0x0000000189B37270
	// [XID] // 0x0000000189B37230-0x0000000189B37270
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001821BA230-0x00000001821BA550
	// [XID] // 0x0000000189B41DB0-0x0000000189B41DD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF318B */, bool useObjectPool = false /* Metadata: 0x00AF318F */) => default; // 0x00000001821BA710-0x00000001821BABC0
	[BlackList] // 0x0000000189B496E0-0x0000000189B49720
	// [XID] // 0x0000000189B496E0-0x0000000189B49720
	public virtual void AutoAllocTypeFields() {} // 0x00000001821B9C60-0x00000001821B9D00
	[BlackList] // 0x0000000189B53B60-0x0000000189B53BA0
	// [XID] // 0x0000000189B53B60-0x0000000189B53BA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001821B9D00-0x00000001821B9E10
	[BlackList] // 0x0000000189B5E680-0x0000000189B5E6C0
	// [XID] // 0x0000000189B5E680-0x0000000189B5E6C0
	public virtual void ReturnToObjectPool() {} // 0x00000001821BB130-0x00000001821BB1D0
	[BlackList] // 0x0000000189B68D60-0x0000000189B68DA0
	// [XID] // 0x0000000189B68D60-0x0000000189B68DA0
	public virtual void OnPoolAllocated() {} // 0x00000001821BAEF0-0x00000001821BAF90
	[BlackList] // 0x0000000189B730F0-0x0000000189B73130
	// [XID] // 0x0000000189B730F0-0x0000000189B73130
	public virtual void OnBeforePoolRecycled() {} // 0x00000001821BAE50-0x00000001821BAEF0
}

