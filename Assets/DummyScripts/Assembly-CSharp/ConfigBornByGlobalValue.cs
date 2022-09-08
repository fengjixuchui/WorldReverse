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
public class ConfigBornByGlobalValue : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17868
{
	// Fields
	private string _positionKey; // 0x38
	private string _directionKey; // 0x40

	// Properties
	public string positionKey { /* [XID] */ /* 0x0000000189B62590-0x0000000189B625B0 */ get => default; /* [XID] */ /* 0x0000000189B6A150-0x0000000189B6A170 */ private set {} } // 0x00000001851E3220-0x00000001851E32C0 0x00000001851E4460-0x00000001851E4510
	public string directionKey { /* [XID] */ /* 0x0000000189B02740-0x0000000189B02760 */ get => default; /* [XID] */ /* 0x0000000189B78D20-0x0000000189B78D40 */ private set {} } // 0x00000001851E4D00-0x00000001851E4DA0 0x00000001851E3E60-0x00000001851E3F10

	// Constructors
	public ConfigBornByGlobalValue() {} // 0x00000001851E51E0-0x00000001851E5240

	// Methods
	// [XID] // 0x0000000189B80210-0x0000000189B80230
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851E5030-0x00000001851E5140
	// [XID] // 0x0000000189B87CC0-0x0000000189B87CE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851E4C00-0x00000001851E4D00
	// [XID] // 0x0000000189B8EE50-0x0000000189B8EE70
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF7F99 */) => default; // 0x00000001851E4810-0x00000001851E48F0
	// [XID] // 0x0000000189B96360-0x0000000189B96380
	public override int GetHashNum() => default; // 0x00000001851E3530-0x00000001851E3600
	// [XID] // 0x0000000189B9D880-0x0000000189B9D8A0
	public override void InitEmpty() {} // 0x00000001851E41A0-0x00000001851E4290
	[BlackList] // 0x0000000189BA52F0-0x0000000189BA5330
	// [XID] // 0x0000000189BA52F0-0x0000000189BA5330
	public override bool FromJson(JSONNode node) => default; // 0x00000001851E3AE0-0x00000001851E3E60
	// [XID] // 0x0000000189BAF440-0x0000000189BAF460
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851E2C40-0x00000001851E2F50
	[BlackList] // 0x0000000189BB6AD0-0x0000000189BB6B10
	// [XID] // 0x0000000189BB6AD0-0x0000000189BB6B10
	public static new ConfigBornByGlobalValue ParseFromJson(JSONNode node) => default; // 0x00000001851E4950-0x00000001851E4BA0
	// [XID] // 0x0000000189BC1820-0x0000000189BC1840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F9A */, bool useObjectPool = false /* Metadata: 0x00AF7F9E */) => default; // 0x00000001851E4510-0x00000001851E4810
	// [XID] // 0x0000000189BC8E80-0x0000000189BC8EA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F9F */, bool useObjectPool = false /* Metadata: 0x00AF7FA3 */) => default; // 0x00000001851E36E0-0x00000001851E39E0
	// [XID] // 0x0000000189BD0690-0x0000000189BD06B0
	public static new ConfigBornByGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7FA4 */, bool useObjectPool = false /* Metadata: 0x00AF7FA8 */) => default; // 0x00000001851E3F10-0x00000001851E4130
	[BlackList] // 0x0000000189BD7C90-0x0000000189BD7CD0
	// [XID] // 0x0000000189BD7C90-0x0000000189BD7CD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851E2F50-0x00000001851E3220
	// [XID] // 0x00000001895E78F0-0x00000001895E7910
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851E4DA0-0x00000001851E5030
	[BlackList] // 0x00000001895EF240-0x00000001895EF280
	// [XID] // 0x00000001895EF240-0x00000001895EF280
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851E4370-0x00000001851E4460
	[BlackList] // 0x00000001895F99C0-0x00000001895F9A00
	// [XID] // 0x00000001895F99C0-0x00000001895F9A00
	public override void AutoAllocTypeFields() {} // 0x00000001851E32C0-0x00000001851E3360
	[BlackList] // 0x00000001896042F0-0x0000000189604330
	// [XID] // 0x00000001896042F0-0x0000000189604330
	public override void AutoRecycleTypeFields() {} // 0x00000001851E3360-0x00000001851E3410
	[BlackList] // 0x000000018960EAC0-0x000000018960EB00
	// [XID] // 0x000000018960EAC0-0x000000018960EB00
	public override void ReturnToObjectPool() {} // 0x00000001851E5140-0x00000001851E51E0
}

