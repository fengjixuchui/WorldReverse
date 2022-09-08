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
public class ConfigDirectionByAttackTarget : ConfigBornDirectionType, IAutoAllocRecycle // TypeDefIndex: 17836
{
	// Fields
	private SimpleSafeFloat speedForPredictiveRawNum; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DirectionTarDistanceScatter _scatter; // 0x40

	// Properties
	public float speedForPredictive { /* [XID] */ /* 0x00000001896D5BD0-0x00000001896D5BF0 */ get => default; /* [XID] */ /* 0x0000000189B47960-0x0000000189B47980 */ private set {} } // 0x000000018325B5A0-0x000000018325B680 0x000000018325CC90-0x000000018325CD70
	public DirectionTarDistanceScatter scatter { /* [XID] */ /* 0x0000000189B4F0B0-0x0000000189B4F0D0 */ get => default; /* [XID] */ /* 0x0000000189B56A90-0x0000000189B56AB0 */ private set {} } // 0x000000018325C0D0-0x000000018325C170 0x000000018325CD70-0x000000018325CE20

	// Constructors
	public ConfigDirectionByAttackTarget() {} // 0x000000018325D2A0-0x000000018325D300

	// Methods
	// [XID] // 0x0000000189B5E2E0-0x0000000189B5E300
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018325D0D0-0x000000018325D200
	// [XID] // 0x0000000189B65820-0x0000000189B65840
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018325CBB0-0x000000018325CC90
	// [XID] // 0x0000000189B6CDE0-0x0000000189B6CE00
	public override ConfigBornDirectionType Clone(bool useObjectPool = false /* Metadata: 0x00AF7E89 */) => default; // 0x000000018325C7C0-0x000000018325C8A0
	// [XID] // 0x0000000189B74590-0x0000000189B745B0
	public override int GetHashNum() => default; // 0x000000018325B470-0x000000018325B540
	// [XID] // 0x0000000189B7BBB0-0x0000000189B7BBD0
	public override void InitEmpty() {} // 0x000000018325C1E0-0x000000018325C2F0
	[BlackList] // 0x0000000189B834A0-0x0000000189B834E0
	// [XID] // 0x0000000189B834A0-0x0000000189B834E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018325BB30-0x000000018325BEB0
	// [XID] // 0x0000000189B8D6F0-0x0000000189B8D710
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018325AB00-0x000000018325AE70
	[BlackList] // 0x0000000189B94CD0-0x0000000189B94D10
	// [XID] // 0x0000000189B94CD0-0x0000000189B94D10
	public static new ConfigDirectionByAttackTarget ParseFromJson(JSONNode node) => default; // 0x000000018325C900-0x000000018325CB50
	// [XID] // 0x0000000189B9F090-0x0000000189B9F0B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E8A */, bool useObjectPool = false /* Metadata: 0x00AF7E8E */) => default; // 0x000000018325C4C0-0x000000018325C7C0
	// [XID] // 0x0000000189BA6940-0x0000000189BA6960
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E8F */, bool useObjectPool = false /* Metadata: 0x00AF7E93 */) => default; // 0x000000018325B700-0x000000018325BA30
	// [XID] // 0x0000000189BADB20-0x0000000189BADB40
	public static new ConfigDirectionByAttackTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E94 */, bool useObjectPool = false /* Metadata: 0x00AF7E98 */) => default; // 0x000000018325BEB0-0x000000018325C0D0
	[BlackList] // 0x0000000189BB52D0-0x0000000189BB5310
	// [XID] // 0x0000000189BB52D0-0x0000000189BB5310
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018325AE70-0x000000018325B140
	// [XID] // 0x0000000189BBF8B0-0x0000000189BBF8D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018325CE20-0x000000018325D0D0
	[BlackList] // 0x0000000189BC7500-0x0000000189BC7540
	// [XID] // 0x0000000189BC7500-0x0000000189BC7540
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018325C3D0-0x000000018325C4C0
	[BlackList] // 0x0000000189BD2000-0x0000000189BD2040
	// [XID] // 0x0000000189BD2000-0x0000000189BD2040
	public override void AutoAllocTypeFields() {} // 0x000000018325B140-0x000000018325B1E0
	[BlackList] // 0x0000000189BDC8C0-0x0000000189BDC900
	// [XID] // 0x0000000189BDC8C0-0x0000000189BDC900
	public override void AutoRecycleTypeFields() {} // 0x000000018325B1E0-0x000000018325B350
	[BlackList] // 0x00000001895EC3D0-0x00000001895EC410
	// [XID] // 0x00000001895EC3D0-0x00000001895EC410
	public override void ReturnToObjectPool() {} // 0x000000018325D200-0x000000018325D2A0
}

