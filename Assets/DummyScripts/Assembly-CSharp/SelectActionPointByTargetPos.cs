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
public class SelectActionPointByTargetPos : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17887
{
	// Fields
	private SimpleSafeFloat distanceRawNum; // 0x10

	// Properties
	public float distance { /* [XID] */ /* 0x00000001895F5330-0x00000001895F5350 */ get => default; /* [XID] */ /* 0x00000001895FC930-0x00000001895FC950 */ private set {} } // 0x0000000184A30570-0x0000000184A30650 0x0000000184A323C0-0x0000000184A324A0

	// Constructors
	public SelectActionPointByTargetPos() {} // 0x0000000184A32B90-0x0000000184A32CA0

	// Methods
	// [XID] // 0x00000001896042D0-0x00000001896042F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A329F0-0x0000000184A32AF0
	// [XID] // 0x000000018960BA80-0x000000018960BAA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A32750-0x0000000184A32800
	// [XID] // 0x0000000189613080-0x00000001896130A0
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8039 */) => default; // 0x0000000184A32280-0x0000000184A32360
	// [XID] // 0x000000018961A880-0x000000018961A8A0
	public override int GetHashNum() => default; // 0x0000000184A30E00-0x0000000184A30ED0
	// [XID] // 0x0000000189621E80-0x0000000189621EA0
	public override void InitEmpty() {} // 0x0000000184A31CE0-0x0000000184A31DB0
	[BlackList] // 0x0000000189629870-0x00000001896298B0
	// [XID] // 0x0000000189629870-0x00000001896298B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A312E0-0x0000000184A31660
	// [XID] // 0x0000000189634090-0x00000001896340B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A30650-0x0000000184A308A0
	[BlackList] // 0x000000018963B920-0x000000018963B960
	// [XID] // 0x000000018963B920-0x000000018963B960
	public static new SelectActionPointByTargetPos ParseFromJson(JSONNode node) => default; // 0x0000000184A324A0-0x0000000184A326F0
	// [XID] // 0x0000000189645F40-0x0000000189645F60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF803A */, bool useObjectPool = false /* Metadata: 0x00AF803E */) => default; // 0x0000000184A31F80-0x0000000184A32280
	// [XID] // 0x000000018964D820-0x000000018964D840
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF803F */, bool useObjectPool = false /* Metadata: 0x00AF8043 */) => default; // 0x0000000184A30FB0-0x0000000184A311E0
	// [XID] // 0x0000000189654F80-0x0000000189654FA0
	public static new SelectActionPointByTargetPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8044 */, bool useObjectPool = false /* Metadata: 0x00AF8048 */) => default; // 0x0000000184A319C0-0x0000000184A31BE0
	[BlackList] // 0x000000018965C7C0-0x000000018965C800
	// [XID] // 0x000000018965C7C0-0x000000018965C800
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A308A0-0x0000000184A30B70
	// [XID] // 0x0000000189666EF0-0x0000000189666F10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A32800-0x0000000184A329F0
	[BlackList] // 0x000000018966E640-0x000000018966E680
	// [XID] // 0x000000018966E640-0x000000018966E680
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A31E90-0x0000000184A31F80
	// [XID] // 0x00000001896794F0-0x0000000189679510
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x0000000184A31660-0x0000000184A319C0
	[BlackList] // 0x0000000189680BE0-0x0000000189680C20
	// [XID] // 0x0000000189680BE0-0x0000000189680C20
	public override void AutoAllocTypeFields() {} // 0x0000000184A30B70-0x0000000184A30C10
	[BlackList] // 0x000000018968B6F0-0x000000018968B730
	// [XID] // 0x000000018968B6F0-0x000000018968B730
	public override void AutoRecycleTypeFields() {} // 0x0000000184A30C10-0x0000000184A30CE0
	[BlackList] // 0x0000000189696250-0x0000000189696290
	// [XID] // 0x0000000189696250-0x0000000189696290
	public override void ReturnToObjectPool() {} // 0x0000000184A32AF0-0x0000000184A32B90
}

