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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class PersonalSceneJumpPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14981
{
	// Fields
	private SimpleSafeUInt32 tranSceneIdRawNum; // 0x60
	private string _titleTextID; // 0x68
	private MoleMole.Config.Vector _triggerSize; // 0x70
	private SimpleSafeFloat open_timeRawNum; // 0x7C
	private SimpleSafeFloat close_timeRawNum; // 0x80
	private bool _isHomeworldDoor; // 0x84

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189A850C0-0x0000000189A850E0 */ get => default; } // 0x00000001837AAAB0-0x00000001837AAB50 
	public uint tranSceneId { /* [XID] */ /* 0x0000000189A8CA30-0x0000000189A8CA50 */ get => default; /* [XID] */ /* 0x0000000189A93DD0-0x0000000189A93DF0 */ private set {} } // 0x00000001837AA500-0x00000001837AA5D0 0x00000001837AB060-0x00000001837AB140
	public string titleTextID { /* [XID] */ /* 0x000000018997D6A0-0x000000018997D6C0 */ get => default; /* [XID] */ /* 0x0000000189AA2CC0-0x0000000189AA2CE0 */ private set {} } // 0x00000001837AB730-0x00000001837AB7D0 0x00000001837ABA40-0x00000001837ABAF0
	public MoleMole.Config.Vector triggerSize { /* [XID] */ /* 0x0000000189AAA280-0x0000000189AAA2A0 */ get => default; /* [XID] */ /* 0x0000000189AB20A0-0x0000000189AB20C0 */ private set {} } // 0x00000001837AAF80-0x00000001837AB060 0x00000001837AB7D0-0x00000001837AB8A0
	public float open_time { /* [XID] */ /* 0x000000018989B4B0-0x000000018989B4D0 */ get => default; /* [XID] */ /* 0x0000000189AC0F30-0x0000000189AC0F50 */ private set {} } // 0x00000001837A83B0-0x00000001837A8490 0x00000001837A9240-0x00000001837A9320
	public float close_time { /* [XID] */ /* 0x0000000189AC88D0-0x0000000189AC88F0 */ get => default; /* [XID] */ /* 0x0000000189AD00D0-0x0000000189AD00F0 */ private set {} } // 0x00000001837A9A70-0x00000001837A9B50 0x00000001837A9B50-0x00000001837A9C30
	public bool isHomeworldDoor { /* [XID] */ /* 0x0000000189AD7E40-0x0000000189AD7E60 */ get => default; /* [XID] */ /* 0x0000000189ADFA70-0x0000000189ADFA90 */ private set {} } // 0x00000001837AB140-0x00000001837AB1F0 0x00000001837AA1A0-0x00000001837AA250

	// Constructors
	public PersonalSceneJumpPoint(MoleMole.Config.Vector pos, MoleMole.Config.Vector rot, uint gadgetId, bool isHomeworldDoor, string titleTextID, MoleMole.Config.Vector triggerSize) {} // 0x00000001837ABB90-0x00000001837ABC80
	public PersonalSceneJumpPoint() {} // 0x00000001837ABC80-0x00000001837ABCE0

	// Methods
	// [XID] // 0x0000000189AE7090-0x0000000189AE70B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837AB8A0-0x00000001837ABA40
	// [XID] // 0x0000000189AEECE0-0x0000000189AEED00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837AAE30-0x00000001837AAF10
	// [XID] // 0x0000000189AF6210-0x0000000189AF6230
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD78 */) => default; // 0x00000001837AA9C0-0x00000001837AAAB0
	// [XID] // 0x0000000189AFD890-0x0000000189AFD8B0
	public override int GetHashNum() => default; // 0x00000001837A9170-0x00000001837A9240
	// [XID] // 0x0000000189B05020-0x0000000189B05040
	public override void InitEmpty() {} // 0x00000001837AA2C0-0x00000001837AA420
	[BlackList] // 0x0000000189B0C750-0x0000000189B0C790
	// [XID] // 0x0000000189B0C750-0x0000000189B0C790
	public override bool FromJson(JSONNode node) => default; // 0x00000001837A9C30-0x00000001837A9FB0
	// [XID] // 0x0000000189B16A10-0x0000000189B16A30
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837A8490-0x00000001837A8B90
	[BlackList] // 0x0000000189B1E0D0-0x0000000189B1E110
	// [XID] // 0x0000000189B1E0D0-0x0000000189B1E110
	public static new PersonalSceneJumpPoint ParseFromJson(JSONNode node) => default; // 0x00000001837AABB0-0x00000001837AADD0
	// [XID] // 0x0000000189B287D0-0x0000000189B287F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD79 */, bool useObjectPool = false /* Metadata: 0x00AEFD7D */) => default; // 0x00000001837AA6C0-0x00000001837AA9C0
	// [XID] // 0x0000000189B2FB70-0x0000000189B2FB90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD7E */, bool useObjectPool = false /* Metadata: 0x00AEFD82 */) => default; // 0x00000001837A9400-0x00000001837A9970
	// [XID] // 0x0000000189B37570-0x0000000189B37590
	public static new PersonalSceneJumpPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD83 */, bool useObjectPool = false /* Metadata: 0x00AEFD87 */) => default; // 0x00000001837A9FB0-0x00000001837AA1A0
	[BlackList] // 0x0000000189B3EDE0-0x0000000189B3EE20
	// [XID] // 0x0000000189B3EDE0-0x0000000189B3EE20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837A8B90-0x00000001837A8E60
	// [XID] // 0x0000000189B498E0-0x0000000189B49900
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837AB1F0-0x00000001837AB730
	[BlackList] // 0x0000000189B50F40-0x0000000189B50F80
	// [XID] // 0x0000000189B50F40-0x0000000189B50F80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837AA5D0-0x00000001837AA6C0
	[BlackList] // 0x0000000189B5B750-0x0000000189B5B790
	// [XID] // 0x0000000189B5B750-0x0000000189B5B790
	public override void AutoAllocTypeFields() {} // 0x00000001837A8E60-0x00000001837A8F00
	[BlackList] // 0x0000000189B65DA0-0x0000000189B65DE0
	// [XID] // 0x0000000189B65DA0-0x0000000189B65DE0
	public override void AutoRecycleTypeFields() {} // 0x00000001837A8F00-0x00000001837A9050
	[BlackList] // 0x0000000189B70460-0x0000000189B704A0
	// [XID] // 0x0000000189B70460-0x0000000189B704A0
	public override void ReturnToObjectPool() {} // 0x00000001837ABAF0-0x00000001837ABB90
}

