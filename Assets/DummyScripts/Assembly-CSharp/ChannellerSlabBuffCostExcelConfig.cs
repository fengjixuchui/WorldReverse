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
public class ChannellerSlabBuffCostExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15046
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected QualityType _buffQualityType; // 0x14
	protected SimpleSafeUInt32 buffCostRawNum; // 0x18
	protected SimpleSafeUInt32 itemIDRawNum; // 0x1C
	protected uint _descTextMapHash; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189935770-0x0000000189935790 */ get => default; /* [XID] */ /* 0x000000018993D2D0-0x000000018993D2F0 */ protected set {} } // 0x00000001835BDD50-0x00000001835BDE20 0x00000001835BD200-0x00000001835BD2E0
	public QualityType buffQualityType { /* [XID] */ /* 0x00000001899449C0-0x00000001899449E0 */ get => default; /* [XID] */ /* 0x000000018994BFA0-0x000000018994BFC0 */ protected set {} } // 0x00000001835BC780-0x00000001835BC820 0x00000001835BDA80-0x00000001835BDB30
	public uint buffCost { /* [XID] */ /* 0x0000000189953630-0x0000000189953650 */ get => default; /* [XID] */ /* 0x000000018995ADF0-0x000000018995AE10 */ protected set {} } // 0x00000001835BD9B0-0x00000001835BDA80 0x00000001835BDB30-0x00000001835BDC10
	public uint itemID { /* [XID] */ /* 0x0000000189962A90-0x0000000189962AB0 */ get => default; /* [XID] */ /* 0x0000000189969DC0-0x0000000189969DE0 */ protected set {} } // 0x00000001835BCFB0-0x00000001835BD080 0x00000001835BD830-0x00000001835BD910
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189971B60-0x0000000189971B80 */ get => default; /* [XID] */ /* 0x0000000189979410-0x0000000189979430 */ protected set {} } // 0x00000001835BD910-0x00000001835BD9B0 0x00000001835BC6D0-0x00000001835BC780
	public string desc { /* [XID] */ /* 0x0000000189980540-0x0000000189980560 */ get => default; } // 0x00000001835BD080-0x00000001835BD200 

	// Constructors
	public ChannellerSlabBuffCostExcelConfig() {} // 0x00000001835BDEC0-0x00000001835BDF20

	// Methods
	// [IDTag] // 0x0000000189987E90-0x0000000189987ED0
	// [XID] // 0x0000000189987E90-0x0000000189987ED0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001835BCBD0-0x00000001835BCFB0
	// [IDTag] // 0x0000000189992C10-0x0000000189992C50
	// [XID] // 0x0000000189992C10-0x0000000189992C50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835BC820-0x00000001835BCBD0
	// [XID] // 0x000000018999D5B0-0x000000018999D5D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF55 */, bool useObjectPool = false /* Metadata: 0x00AEFF59 */) => default; // 0x00000001835BD2E0-0x00000001835BD830
	[BlackList] // 0x00000001899A4E50-0x00000001899A4E90
	// [XID] // 0x00000001899A4E50-0x00000001899A4E90
	public virtual void AutoAllocTypeFields() {} // 0x00000001835BC530-0x00000001835BC5D0
	[BlackList] // 0x00000001899AF850-0x00000001899AF890
	// [XID] // 0x00000001899AF850-0x00000001899AF890
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835BC5D0-0x00000001835BC6D0
	[BlackList] // 0x00000001899B9D70-0x00000001899B9DB0
	// [XID] // 0x00000001899B9D70-0x00000001899B9DB0
	public virtual void ReturnToObjectPool() {} // 0x00000001835BDE20-0x00000001835BDEC0
	[BlackList] // 0x00000001899C4940-0x00000001899C4980
	// [XID] // 0x00000001899C4940-0x00000001899C4980
	public virtual void OnPoolAllocated() {} // 0x00000001835BDCB0-0x00000001835BDD50
	[BlackList] // 0x00000001899CEEE0-0x00000001899CEF20
	// [XID] // 0x00000001899CEEE0-0x00000001899CEF20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835BDC10-0x00000001835BDCB0
}

