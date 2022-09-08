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
public class CoopSavePoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17762
{
	// Fields
	private uint _id; // 0x10
	private bool _isEnd; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AB1C60-0x0000000189AB1C80 */ get => default; /* [XID] */ /* 0x0000000189AB8F50-0x0000000189AB8F70 */ private set {} } // 0x0000000181572D10-0x0000000181572DB0 0x0000000181572420-0x00000001815724D0
	public bool isEnd { /* [XID] */ /* 0x0000000189AC0AB0-0x0000000189AC0AD0 */ get => default; /* [XID] */ /* 0x0000000189AC8450-0x0000000189AC8470 */ private set {} } // 0x00000001815722E0-0x0000000181572380 0x00000001815724D0-0x0000000181572580

	// Constructors
	public CoopSavePoint() {} // 0x0000000181572E50-0x0000000181572EC0

	// Methods
	// [XID] // 0x0000000189ACFBD0-0x0000000189ACFBF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181572AC0-0x0000000181572BD0
	// [XID] // 0x0000000189AD78E0-0x0000000189AD7900
	public void InitEmpty() {} // 0x0000000181572380-0x0000000181572420
	[BlackList] // 0x0000000189ADF3D0-0x0000000189ADF410
	// [XID] // 0x0000000189ADF3D0-0x0000000189ADF410
	public bool FromJson(JSONNode node) => default; // 0x0000000181571F60-0x00000001815722E0
	// [XID] // 0x0000000189AE9970-0x0000000189AE9990
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181571680-0x0000000181571900
	// [XID] // 0x0000000189AF1710-0x0000000189AF1730
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B4D */, bool useObjectPool = false /* Metadata: 0x00AF7B51 */) => default; // 0x0000000181572580-0x0000000181572880
	// [XID] // 0x0000000189AF8DD0-0x0000000189AF8DF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B52 */, bool useObjectPool = false /* Metadata: 0x00AF7B56 */) => default; // 0x0000000181571D10-0x0000000181571F60
	[BlackList] // 0x0000000189B002D0-0x0000000189B00310
	// [XID] // 0x0000000189B002D0-0x0000000189B00310
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181571900-0x0000000181571BD0
	// [XID] // 0x0000000189B0AA80-0x0000000189B0AAA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181572880-0x0000000181572AC0
	[BlackList] // 0x0000000189B12200-0x0000000189B12240
	// [XID] // 0x0000000189B12200-0x0000000189B12240
	public virtual void AutoAllocTypeFields() {} // 0x0000000181571BD0-0x0000000181571C70
	[BlackList] // 0x0000000189B1C910-0x0000000189B1C950
	// [XID] // 0x0000000189B1C910-0x0000000189B1C950
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181571C70-0x0000000181571D10
	[BlackList] // 0x0000000189B26EA0-0x0000000189B26EE0
	// [XID] // 0x0000000189B26EA0-0x0000000189B26EE0
	public virtual void ReturnToObjectPool() {} // 0x0000000181572DB0-0x0000000181572E50
	[BlackList] // 0x0000000189B30FF0-0x0000000189B31030
	// [XID] // 0x0000000189B30FF0-0x0000000189B31030
	public virtual void OnPoolAllocated() {} // 0x0000000181572C70-0x0000000181572D10
	[BlackList] // 0x0000000189B3B6D0-0x0000000189B3B710
	// [XID] // 0x0000000189B3B6D0-0x0000000189B3B710
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181572BD0-0x0000000181572C70
}

