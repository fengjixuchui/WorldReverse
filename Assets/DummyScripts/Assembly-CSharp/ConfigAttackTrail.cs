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
public class ConfigAttackTrail : ConfigSimpleAttackPattern, IAutoAllocRecycle // TypeDefIndex: 17536
{
	// Fields
	private string _trailName; // 0x40
	private string _trailStartName; // 0x48

	// Properties
	public string trailName { /* [XID] */ /* 0x00000001898657B0-0x00000001898657D0 */ get => default; /* [XID] */ /* 0x000000018986CC90-0x000000018986CCB0 */ private set {} } // 0x000000018365BC70-0x000000018365BD10 0x000000018365B760-0x000000018365B810
	public string trailStartName { /* [XID] */ /* 0x0000000189874160-0x0000000189874180 */ get => default; /* [XID] */ /* 0x000000018987BC40-0x000000018987BC60 */ private set {} } // 0x000000018365CB50-0x000000018365CBF0 0x000000018365CA40-0x000000018365CAF0

	// Constructors
	public ConfigAttackTrail() {} // 0x000000018365D3E0-0x000000018365D440

	// Methods
	// [XID] // 0x0000000189882DF0-0x0000000189882E10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018365D230-0x000000018365D340
	// [XID] // 0x000000018988A650-0x000000018988A670
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018365CEA0-0x000000018365CFA0
	// [XID] // 0x0000000189891AC0-0x0000000189891AE0
	public override ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF7219 */) => default; // 0x000000018365C960-0x000000018365CA40
	// [XID] // 0x0000000189899410-0x0000000189899430
	public override int GetHashNum() => default; // 0x000000018365B690-0x000000018365B760
	// [XID] // 0x00000001898A0670-0x00000001898A0690
	public override void InitEmpty() {} // 0x000000018365C3A0-0x000000018365C490
	[BlackList] // 0x00000001898A7D10-0x00000001898A7D50
	// [XID] // 0x00000001898A7D10-0x00000001898A7D50
	public override bool FromJson(JSONNode node) => default; // 0x000000018365BD90-0x000000018365C110
	// [XID] // 0x00000001898B24D0-0x00000001898B24F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018365AE40-0x000000018365B150
	[BlackList] // 0x00000001898BA240-0x00000001898BA280
	// [XID] // 0x00000001898BA240-0x00000001898BA280
	public static new ConfigAttackTrail ParseFromJson(JSONNode node) => default; // 0x000000018365CBF0-0x000000018365CE40
	// [XID] // 0x00000001898C46C0-0x00000001898C46E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF721A */, bool useObjectPool = false /* Metadata: 0x00AF721E */) => default; // 0x000000018365C660-0x000000018365C960
	// [XID] // 0x00000001898CBCB0-0x00000001898CBCD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF721F */, bool useObjectPool = false /* Metadata: 0x00AF7223 */) => default; // 0x000000018365B8F0-0x000000018365BBF0
	// [XID] // 0x00000001898D3590-0x00000001898D35B0
	public static new ConfigAttackTrail ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7224 */, bool useObjectPool = false /* Metadata: 0x00AF7228 */) => default; // 0x000000018365C110-0x000000018365C330
	[BlackList] // 0x00000001898DACE0-0x00000001898DAD20
	// [XID] // 0x00000001898DACE0-0x00000001898DAD20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018365B150-0x000000018365B420
	// [XID] // 0x00000001898E5B80-0x00000001898E5BA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018365CFA0-0x000000018365D230
	[BlackList] // 0x00000001898ED4A0-0x00000001898ED4E0
	// [XID] // 0x00000001898ED4A0-0x00000001898ED4E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018365C570-0x000000018365C660
	[BlackList] // 0x00000001898F7E70-0x00000001898F7EB0
	// [XID] // 0x00000001898F7E70-0x00000001898F7EB0
	public override void AutoAllocTypeFields() {} // 0x000000018365B420-0x000000018365B4C0
	[BlackList] // 0x00000001899026E0-0x0000000189902720
	// [XID] // 0x00000001899026E0-0x0000000189902720
	public override void AutoRecycleTypeFields() {} // 0x000000018365B4C0-0x000000018365B570
	[BlackList] // 0x000000018990CE50-0x000000018990CE90
	// [XID] // 0x000000018990CE50-0x000000018990CE90
	public override void ReturnToObjectPool() {} // 0x000000018365D340-0x000000018365D3E0
}

