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
public class BlessingScanPicExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15032
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 grantRewardCostRawNum; // 0x14
	protected string _iconName; // 0x18
	protected uint _nameTextMapHash; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898D81A0-0x00000001898D81C0 */ get => default; /* [XID] */ /* 0x00000001898E0020-0x00000001898E0040 */ protected set {} } // 0x0000000181DA5A20-0x0000000181DA5AF0 0x0000000181DA5120-0x0000000181DA5200
	public uint grantRewardCost { /* [XID] */ /* 0x00000001898E7B10-0x00000001898E7B30 */ get => default; /* [XID] */ /* 0x00000001898EF1E0-0x00000001898EF200 */ protected set {} } // 0x0000000181DA5050-0x0000000181DA5120 0x0000000181DA56B0-0x0000000181DA5790
	public string iconName { /* [XID] */ /* 0x00000001898F6AE0-0x00000001898F6B00 */ get => default; /* [XID] */ /* 0x00000001898FE1E0-0x00000001898FE200 */ protected set {} } // 0x0000000181DA5840-0x0000000181DA58E0 0x0000000181DA5AF0-0x0000000181DA5BA0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189905A80-0x0000000189905AA0 */ get => default; /* [XID] */ /* 0x000000018990D370-0x000000018990D390 */ protected set {} } // 0x0000000181DA4940-0x0000000181DA49E0 0x0000000181DA5790-0x0000000181DA5840
	public string name { /* [XID] */ /* 0x0000000189914A60-0x0000000189914A80 */ get => default; } // 0x0000000181DA5BA0-0x0000000181DA5D20 

	// Constructors
	public BlessingScanPicExcelConfig() {} // 0x0000000181DA5DC0-0x0000000181DA5E20

	// Methods
	// [IDTag] // 0x000000018991C720-0x000000018991C760
	// [XID] // 0x000000018991C720-0x000000018991C760
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181DA49E0-0x0000000181DA4D30
	// [IDTag] // 0x0000000189926DA0-0x0000000189926DE0
	// [XID] // 0x0000000189926DA0-0x0000000189926DE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181DA4D30-0x0000000181DA5050
	// [XID] // 0x0000000189931280-0x00000001899312A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEF0 */, bool useObjectPool = false /* Metadata: 0x00AEFEF4 */) => default; // 0x0000000181DA5200-0x0000000181DA56B0
	[BlackList] // 0x0000000189938750-0x0000000189938790
	// [XID] // 0x0000000189938750-0x0000000189938790
	public virtual void AutoAllocTypeFields() {} // 0x0000000181DA47B0-0x0000000181DA4850
	[BlackList] // 0x0000000189942E30-0x0000000189942E70
	// [XID] // 0x0000000189942E30-0x0000000189942E70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181DA4850-0x0000000181DA4940
	[BlackList] // 0x000000018994D670-0x000000018994D6B0
	// [XID] // 0x000000018994D670-0x000000018994D6B0
	public virtual void ReturnToObjectPool() {} // 0x0000000181DA5D20-0x0000000181DA5DC0
	[BlackList] // 0x0000000189957F80-0x0000000189957FC0
	// [XID] // 0x0000000189957F80-0x0000000189957FC0
	public virtual void OnPoolAllocated() {} // 0x0000000181DA5980-0x0000000181DA5A20
	[BlackList] // 0x0000000189962AB0-0x0000000189962AF0
	// [XID] // 0x0000000189962AB0-0x0000000189962AF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181DA58E0-0x0000000181DA5980
}

