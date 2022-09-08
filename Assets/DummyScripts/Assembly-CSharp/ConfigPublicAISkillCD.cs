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
public class ConfigPublicAISkillCD : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18097
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeFloat minIntervalRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x00000001896AA750-0x00000001896AA770 */ get => default; /* [XID] */ /* 0x00000001896B17F0-0x00000001896B1810 */ private set {} } // 0x0000000184591EE0-0x0000000184591F80 0x00000001845914C0-0x0000000184591570
	public float minInterval { /* [XID] */ /* 0x00000001896B58C0-0x00000001896B58E0 */ get => default; /* [XID] */ /* 0x00000001896C05E0-0x00000001896C0600 */ private set {} } // 0x0000000184590630-0x0000000184590710 0x0000000184591970-0x0000000184591A50

	// Constructors
	public ConfigPublicAISkillCD() {} // 0x0000000184592020-0x0000000184592080

	// Methods
	// [XID] // 0x00000001896C7D50-0x00000001896C7D70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184591C90-0x0000000184591DA0
	// [XID] // 0x00000001896CF6B0-0x00000001896CF6D0
	public void InitEmpty() {} // 0x0000000184591570-0x0000000184591670
	[BlackList] // 0x00000001896D6940-0x00000001896D6980
	// [XID] // 0x00000001896D6940-0x00000001896D6980
	public bool FromJson(JSONNode node) => default; // 0x0000000184591140-0x00000001845914C0
	// [XID] // 0x00000001896E10B0-0x00000001896E10D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184590710-0x0000000184590A30
	// [XID] // 0x00000001896E8380-0x00000001896E83A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AE1 */, bool useObjectPool = false /* Metadata: 0x00AF8AE5 */) => default; // 0x0000000184591670-0x0000000184591970
	// [XID] // 0x00000001896EF9A0-0x00000001896EF9C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AE6 */, bool useObjectPool = false /* Metadata: 0x00AF8AEA */) => default; // 0x0000000184590E80-0x0000000184591140
	[BlackList] // 0x00000001896F7350-0x00000001896F7390
	// [XID] // 0x00000001896F7350-0x00000001896F7390
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184590A30-0x0000000184590D00
	// [XID] // 0x00000001897018E0-0x0000000189701900
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184591A50-0x0000000184591C90
	[BlackList] // 0x00000001897091C0-0x0000000189709200
	// [XID] // 0x00000001897091C0-0x0000000189709200
	public virtual void AutoAllocTypeFields() {} // 0x0000000184590D00-0x0000000184590DA0
	[BlackList] // 0x00000001897138A0-0x00000001897138E0
	// [XID] // 0x00000001897138A0-0x00000001897138E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184590DA0-0x0000000184590E80
	[BlackList] // 0x000000018971DFE0-0x000000018971E020
	// [XID] // 0x000000018971DFE0-0x000000018971E020
	public virtual void ReturnToObjectPool() {} // 0x0000000184591F80-0x0000000184592020
	[BlackList] // 0x0000000189728510-0x0000000189728550
	// [XID] // 0x0000000189728510-0x0000000189728550
	public virtual void OnPoolAllocated() {} // 0x0000000184591E40-0x0000000184591EE0
	[BlackList] // 0x0000000189732A80-0x0000000189732AC0
	// [XID] // 0x0000000189732A80-0x0000000189732AC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184591DA0-0x0000000184591E40
}

