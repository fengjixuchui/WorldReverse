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
public class ConfigWidgetLunchBox : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19133
{
	// Fields
	private SimpleSafeUInt32[] _reviveMaterials; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWidgetLunchBoxHealMaterial _healMaterials; // 0x38

	// Properties
	public SimpleSafeUInt32[] reviveMaterials { /* [XID] */ /* 0x000000018967A6E0-0x000000018967A700 */ get => default; /* [XID] */ /* 0x0000000189682030-0x0000000189682050 */ private set {} } // 0x0000000184002040-0x00000001840020E0 0x0000000184002BF0-0x0000000184002CA0
	public ConfigWidgetLunchBoxHealMaterial healMaterials { /* [XID] */ /* 0x0000000189689A50-0x0000000189689A70 */ get => default; /* [XID] */ /* 0x0000000189691810-0x0000000189691830 */ private set {} } // 0x00000001840032D0-0x0000000184003370 0x0000000184002160-0x0000000184002210

	// Constructors
	public ConfigWidgetLunchBox() {} // 0x0000000184003D10-0x0000000184003D70

	// Methods
	// [XID] // 0x0000000189698D80-0x0000000189698DA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184003B40-0x0000000184003C70
	// [XID] // 0x00000001896A02F0-0x00000001896A0310
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184003760-0x0000000184003860
	// [XID] // 0x00000001896A76C0-0x00000001896A76E0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC2ED */) => default; // 0x0000000184003370-0x0000000184003450
	// [XID] // 0x00000001896AEC10-0x00000001896AEC30
	public override int GetHashNum() => default; // 0x0000000184001F10-0x0000000184001FE0
	// [XID] // 0x00000001896B6300-0x00000001896B6320
	public override void InitEmpty() {} // 0x0000000184002D10-0x0000000184002E00
	[BlackList] // 0x00000001896BD580-0x00000001896BD5C0
	// [XID] // 0x00000001896BD580-0x00000001896BD5C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184002650-0x00000001840029D0
	// [XID] // 0x00000001896C7B50-0x00000001896C7B70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184001610-0x0000000184001940
	[BlackList] // 0x00000001896CF510-0x00000001896CF550
	// [XID] // 0x00000001896CF510-0x00000001896CF550
	public static new ConfigWidgetLunchBox ParseFromJson(JSONNode node) => default; // 0x00000001840034B0-0x0000000184003700
	// [XID] // 0x00000001896D9770-0x00000001896D9790
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2EE */, bool useObjectPool = false /* Metadata: 0x00AFC2F2 */) => default; // 0x0000000184002FD0-0x00000001840032D0
	// [XID] // 0x00000001896E0ED0-0x00000001896E0EF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2F3 */, bool useObjectPool = false /* Metadata: 0x00AFC2F7 */) => default; // 0x0000000184002210-0x0000000184002550
	// [XID] // 0x00000001896E8160-0x00000001896E8180
	public static new ConfigWidgetLunchBox ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2F8 */, bool useObjectPool = false /* Metadata: 0x00AFC2FC */) => default; // 0x00000001840029D0-0x0000000184002BF0
	[BlackList] // 0x00000001896EF800-0x00000001896EF840
	// [XID] // 0x00000001896EF800-0x00000001896EF840
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184001940-0x0000000184001C10
	// [XID] // 0x00000001896F9F50-0x00000001896F9F70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184003860-0x0000000184003B40
	[BlackList] // 0x0000000189701640-0x0000000189701680
	// [XID] // 0x0000000189701640-0x0000000189701680
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184002EE0-0x0000000184002FD0
	[BlackList] // 0x000000018970BD50-0x000000018970BD90
	// [XID] // 0x000000018970BD50-0x000000018970BD90
	public override void AutoAllocTypeFields() {} // 0x0000000184001C10-0x0000000184001CB0
	[BlackList] // 0x0000000189716400-0x0000000189716440
	// [XID] // 0x0000000189716400-0x0000000189716440
	public override void AutoRecycleTypeFields() {} // 0x0000000184001CB0-0x0000000184001DF0
	[BlackList] // 0x0000000189720C50-0x0000000189720C90
	// [XID] // 0x0000000189720C50-0x0000000189720C90
	public override void ReturnToObjectPool() {} // 0x0000000184003C70-0x0000000184003D10
}

