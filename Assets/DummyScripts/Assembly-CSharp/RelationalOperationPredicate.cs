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
public class RelationalOperationPredicate : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17176
{
	// Fields
	private RelationalOperator _logic; // 0x18

	// Properties
	public RelationalOperator logic { /* [XID] */ /* 0x00000001896FA330-0x00000001896FA350 */ get => default; /* [XID] */ /* 0x0000000189701AA0-0x0000000189701AC0 */ private set {} } // 0x000000018330CAF0-0x000000018330CB90 0x000000018330C320-0x000000018330C3D0

	// Constructors
	public RelationalOperationPredicate() {} // 0x000000018330D280-0x000000018330D2E0

	// Methods
	// [XID] // 0x00000001897093C0-0x00000001897093E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018330D0F0-0x000000018330D1E0
	// [XID] // 0x0000000189710C90-0x0000000189710CB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018330CE40-0x000000018330CEF0
	// [XID] // 0x0000000189717F30-0x0000000189717F50
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF65A7 */) => default; // 0x000000018330C9B0-0x000000018330CA90
	// [XID] // 0x000000018971F8D0-0x000000018971F8F0
	public override int GetHashNum() => default; // 0x000000018330B8A0-0x000000018330B970
	// [XID] // 0x0000000189726F00-0x0000000189726F20
	public override void InitEmpty() {} // 0x000000018330C440-0x000000018330C4E0
	[BlackList] // 0x000000018972E470-0x000000018972E4B0
	// [XID] // 0x000000018972E470-0x000000018972E4B0
	public override bool FromJson(JSONNode node) => default; // 0x000000018330BD80-0x000000018330C100
	// [XID] // 0x0000000189738C30-0x0000000189738C50
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018330B140-0x000000018330B360
	[BlackList] // 0x0000000189740A60-0x0000000189740AA0
	// [XID] // 0x0000000189740A60-0x0000000189740AA0
	public static new RelationalOperationPredicate ParseFromJson(JSONNode node) => default; // 0x000000018330CB90-0x000000018330CDE0
	// [XID] // 0x000000018974B2E0-0x000000018974B300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65A8 */, bool useObjectPool = false /* Metadata: 0x00AF65AC */) => default; // 0x000000018330C6B0-0x000000018330C9B0
	// [XID] // 0x00000001897523B0-0x00000001897523D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65AD */, bool useObjectPool = false /* Metadata: 0x00AF65B1 */) => default; // 0x000000018330BA50-0x000000018330BC80
	// [XID] // 0x00000001897598C0-0x00000001897598E0
	public static new RelationalOperationPredicate ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65B2 */, bool useObjectPool = false /* Metadata: 0x00AF65B6 */) => default; // 0x000000018330C100-0x000000018330C320
	[BlackList] // 0x00000001897614F0-0x0000000189761530
	// [XID] // 0x00000001897614F0-0x0000000189761530
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018330B360-0x000000018330B630
	// [XID] // 0x000000018976BA40-0x000000018976BA60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018330CEF0-0x000000018330D0F0
	[BlackList] // 0x0000000189772EC0-0x0000000189772F00
	// [XID] // 0x0000000189772EC0-0x0000000189772F00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018330C5C0-0x000000018330C6B0
	[BlackList] // 0x000000018977D800-0x000000018977D840
	// [XID] // 0x000000018977D800-0x000000018977D840
	public override void AutoAllocTypeFields() {} // 0x000000018330B630-0x000000018330B6D0
	[BlackList] // 0x0000000189787F40-0x0000000189787F80
	// [XID] // 0x0000000189787F40-0x0000000189787F80
	public override void AutoRecycleTypeFields() {} // 0x000000018330B6D0-0x000000018330B780
	[BlackList] // 0x0000000189792560-0x00000001897925A0
	// [XID] // 0x0000000189792560-0x00000001897925A0
	public override void ReturnToObjectPool() {} // 0x000000018330D1E0-0x000000018330D280
}

