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
public class CoopCGExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15462
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected SimpleSafeUInt32 unlockPointIdRawNum; // 0x18
	protected CoopCGType _cgType; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected CoopCondConfig[] _unlockCond; // 0x20
	protected byte _showImageHashPre; // 0x28
	protected uint _showImageHashSuffix; // 0x2C
	protected byte _showImageSmallHashPre; // 0x30
	protected uint _showImageSmallHashSuffix; // 0x34
	protected uint _cgNameTextMapHash; // 0x38
	protected uint _cgDesTextMapHash; // 0x3C
	protected SimpleSafeUInt32 sortIdRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899DF0F0-0x00000001899DF110 */ get => default; /* [XID] */ /* 0x00000001899E6D70-0x00000001899E6D90 */ protected set {} } // 0x0000000184585410-0x00000001845854E0 0x00000001845842D0-0x00000001845843B0
	public uint chapterId { /* [XID] */ /* 0x00000001899EE200-0x00000001899EE220 */ get => default; /* [XID] */ /* 0x00000001899F5A10-0x00000001899F5A30 */ protected set {} } // 0x00000001845839A0-0x0000000184583A70 0x00000001845828D0-0x00000001845829B0
	public uint unlockPointId { /* [XID] */ /* 0x00000001899FD190-0x00000001899FD1B0 */ get => default; /* [XID] */ /* 0x0000000189A04650-0x0000000189A04670 */ protected set {} } // 0x0000000184583CD0-0x0000000184583DA0 0x0000000184583A70-0x0000000184583B50
	public CoopCGType cgType { /* [XID] */ /* 0x0000000189A0BE90-0x0000000189A0BEB0 */ get => default; /* [XID] */ /* 0x0000000189A13760-0x0000000189A13780 */ protected set {} } // 0x0000000184585230-0x00000001845852D0 0x00000001845854E0-0x0000000184585590
	public CoopCondConfig[] unlockCond { /* [XID] */ /* 0x0000000189A1A870-0x0000000189A1A890 */ get => default; /* [XID] */ /* 0x0000000189A220F0-0x0000000189A22110 */ protected set {} } // 0x0000000184584CE0-0x0000000184584D80 0x00000001845840A0-0x0000000184584150
	public byte showImageHashPre { /* [XID] */ /* 0x0000000189A295A0-0x0000000189A295C0 */ get => default; /* [XID] */ /* 0x0000000189A30AF0-0x0000000189A30B10 */ protected set {} } // 0x0000000184584FA0-0x0000000184585040 0x0000000184583C20-0x0000000184583CD0
	public uint showImageHashSuffix { /* [XID] */ /* 0x0000000189A38570-0x0000000189A38590 */ get => default; /* [XID] */ /* 0x0000000189A3FD00-0x0000000189A3FD20 */ protected set {} } // 0x0000000184585190-0x0000000184585230 0x00000001845850E0-0x0000000184585190
	public ulong showImageHash { /* [XID] */ /* 0x0000000189A47370-0x0000000189A47390 */ get => default; } // 0x0000000184584E30-0x0000000184584F00 
	public byte showImageSmallHashPre { /* [XID] */ /* 0x0000000189A4EC10-0x0000000189A4EC30 */ get => default; /* [XID] */ /* 0x0000000189A56320-0x0000000189A56340 */ protected set {} } // 0x00000001845826B0-0x0000000184582750 0x0000000184584D80-0x0000000184584E30
	public uint showImageSmallHashSuffix { /* [XID] */ /* 0x0000000189A5DD40-0x0000000189A5DD60 */ get => default; /* [XID] */ /* 0x0000000189A65580-0x0000000189A655A0 */ protected set {} } // 0x0000000184585040-0x00000001845850E0 0x00000001845838F0-0x00000001845839A0
	public ulong showImageSmallHash { /* [XID] */ /* 0x0000000189A6CC80-0x0000000189A6CCA0 */ get => default; } // 0x0000000184583B50-0x0000000184583C20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cgNameTextMapHash { /* [XID] */ /* 0x0000000189A74410-0x0000000189A74430 */ get => default; /* [XID] */ /* 0x0000000189A7BE40-0x0000000189A7BE60 */ protected set {} } // 0x0000000184583E80-0x0000000184583F20 0x0000000184583FF0-0x00000001845840A0
	public string cgName { /* [XID] */ /* 0x0000000189A83820-0x0000000189A83840 */ get => default; } // 0x0000000184582750-0x00000001845828D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cgDesTextMapHash { /* [XID] */ /* 0x0000000189A8B020-0x0000000189A8B040 */ get => default; /* [XID] */ /* 0x0000000189A92850-0x0000000189A92870 */ protected set {} } // 0x0000000184584F00-0x0000000184584FA0 0x0000000184582430-0x00000001845824E0
	public string cgDes { /* [XID] */ /* 0x0000000189A9A240-0x0000000189A9A260 */ get => default; } // 0x0000000184584150-0x00000001845842D0 
	public uint sortId { /* [XID] */ /* 0x0000000189AA12E0-0x0000000189AA1300 */ get => default; /* [XID] */ /* 0x0000000189AA89C0-0x0000000189AA89E0 */ protected set {} } // 0x0000000184583F20-0x0000000184583FF0 0x0000000184583DA0-0x0000000184583E80

	// Constructors
	public CoopCGExcelConfig() {} // 0x0000000184585630-0x0000000184585690

	// Methods
	// [IDTag] // 0x0000000189AB0560-0x0000000189AB05A0
	// [XID] // 0x0000000189AB0560-0x0000000189AB05A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001845830F0-0x00000001845838F0
	// [IDTag] // 0x0000000189ABB2D0-0x0000000189ABB310
	// [XID] // 0x0000000189ABB2D0-0x0000000189ABB310
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845829B0-0x00000001845830F0
	// [XID] // 0x0000000189AC5B50-0x0000000189AC5B70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B2C */, bool useObjectPool = false /* Metadata: 0x00AF1B30 */) => default; // 0x00000001845843B0-0x0000000184584CE0
	[BlackList] // 0x0000000189ACD100-0x0000000189ACD140
	// [XID] // 0x0000000189ACD100-0x0000000189ACD140
	public virtual void AutoAllocTypeFields() {} // 0x00000001845824E0-0x0000000184582580
	[BlackList] // 0x0000000189AD7DA0-0x0000000189AD7DE0
	// [XID] // 0x0000000189AD7DA0-0x0000000189AD7DE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184582580-0x00000001845826B0
	[BlackList] // 0x0000000189AE24E0-0x0000000189AE2520
	// [XID] // 0x0000000189AE24E0-0x0000000189AE2520
	public virtual void ReturnToObjectPool() {} // 0x0000000184585590-0x0000000184585630
	[BlackList] // 0x0000000189AECE60-0x0000000189AECEA0
	// [XID] // 0x0000000189AECE60-0x0000000189AECEA0
	public virtual void OnPoolAllocated() {} // 0x0000000184585370-0x0000000184585410
	[BlackList] // 0x0000000189AF7980-0x0000000189AF79C0
	// [XID] // 0x0000000189AF7980-0x0000000189AF79C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845852D0-0x0000000184585370
}

