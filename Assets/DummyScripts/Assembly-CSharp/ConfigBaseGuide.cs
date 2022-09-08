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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigBaseGuide : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18191
{
	// Constructors
	public ConfigBaseGuide() {} // 0x0000000183A9AB10-0x0000000183A9AB70

	// Methods
	// [XID] // 0x0000000189A6F6A0-0x0000000189A6F6C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A9A880-0x0000000183A9A930
	// [XID] // 0x0000000189A76E70-0x0000000189A76E90
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A9A720-0x0000000183A9A7D0
	// [XID] // 0x0000000189A7E960-0x0000000189A7E980
	public virtual ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF8FB9 */) => default; // 0x0000000183A9A440-0x0000000183A9A520
	// [XID] // 0x0000000189A861D0-0x0000000189A861F0
	public virtual int GetHashNum() => default; // 0x0000000183A998B0-0x0000000183A99980
	// [XID] // 0x0000000189A8DAF0-0x0000000189A8DB10
	public virtual void InitEmpty() {} // 0x0000000183A99FB0-0x0000000183A9A050
	[BlackList] // 0x0000000189A95090-0x0000000189A950D0
	// [XID] // 0x0000000189A95090-0x0000000189A950D0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183A99A60-0x0000000183A99DE0
	// [XID] // 0x0000000189A9F810-0x0000000189A9F830
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A993F0-0x0000000183A994A0
	[BlackList] // 0x0000000189AA70E0-0x0000000189AA7120
	// [XID] // 0x0000000189AA70E0-0x0000000189AA7120
	public static ConfigBaseGuide ParseFromJson(JSONNode node) => default; // 0x0000000183A9A520-0x0000000183A9A720
	// [XID] // 0x0000000189AB1B80-0x0000000189AB1BA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FBA */, bool useObjectPool = false /* Metadata: 0x00AF8FBE */) => default; // 0x0000000183A9A140-0x0000000183A9A440
	// [XID] // 0x0000000189AB8EB0-0x0000000189AB8ED0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FBF */, bool useObjectPool = false /* Metadata: 0x00AF8FC3 */) => default; // 0x0000000183A99980-0x0000000183A99A60
	// [XID] // 0x0000000189AC0930-0x0000000189AC0950
	public static ConfigBaseGuide ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FC4 */, bool useObjectPool = false /* Metadata: 0x00AF8FC8 */) => default; // 0x0000000183A99DE0-0x0000000183A99FB0
	[BlackList] // 0x0000000189AC8350-0x0000000189AC8390
	// [XID] // 0x0000000189AC8350-0x0000000189AC8390
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A994A0-0x0000000183A99770
	// [XID] // 0x0000000189AD2DC0-0x0000000189AD2DE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A9A7D0-0x0000000183A9A880
	[BlackList] // 0x0000000189ADA860-0x0000000189ADA8A0
	// [XID] // 0x0000000189ADA860-0x0000000189ADA8A0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A9A050-0x0000000183A9A140
	[BlackList] // 0x0000000189AE5500-0x0000000189AE5540
	// [XID] // 0x0000000189AE5500-0x0000000189AE5540
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A99770-0x0000000183A99810
	[BlackList] // 0x0000000189AEFF50-0x0000000189AEFF90
	// [XID] // 0x0000000189AEFF50-0x0000000189AEFF90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A99810-0x0000000183A998B0
	[BlackList] // 0x0000000189AFA5C0-0x0000000189AFA600
	// [XID] // 0x0000000189AFA5C0-0x0000000189AFA600
	public virtual void ReturnToObjectPool() {} // 0x0000000183A9AA70-0x0000000183A9AB10
	[BlackList] // 0x0000000189B04900-0x0000000189B04940
	// [XID] // 0x0000000189B04900-0x0000000189B04940
	public virtual void OnPoolAllocated() {} // 0x0000000183A9A9D0-0x0000000183A9AA70
	[BlackList] // 0x0000000189B0F0B0-0x0000000189B0F0F0
	// [XID] // 0x0000000189B0F0B0-0x0000000189B0F0F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A9A930-0x0000000183A9A9D0
}

