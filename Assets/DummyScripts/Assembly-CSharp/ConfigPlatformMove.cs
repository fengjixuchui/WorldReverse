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
public class ConfigPlatformMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18592
{
	// Fields
	private SimpleSafeFloat AvatarTriggerEventDistanceRawNum; // 0x18
	private bool _IsMovingWater; // 0x1C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRoute _route; // 0x20
	private MovePlatformDelayType _delayType; // 0x28

	// Properties
	public float AvatarTriggerEventDistance { /* [XID] */ /* 0x0000000189B46120-0x0000000189B46140 */ get => default; /* [XID] */ /* 0x0000000189B4D710-0x0000000189B4D730 */ private set {} } // 0x0000000184BFC990-0x0000000184BFCA70 0x0000000184BFC4B0-0x0000000184BFC590
	public bool IsMovingWater { /* [XID] */ /* 0x0000000189B54ED0-0x0000000189B54EF0 */ get => default; /* [XID] */ /* 0x0000000189B5C910-0x0000000189B5C930 */ private set {} } // 0x0000000184BFC150-0x0000000184BFC1F0 0x0000000184BFD810-0x0000000184BFD8C0
	public ConfigRoute route { /* [XID] */ /* 0x00000001896F4DE0-0x00000001896F4E00 */ get => default; /* [XID] */ /* 0x0000000189B6B730-0x0000000189B6B750 */ private set {} } // 0x0000000184BFC410-0x0000000184BFC4B0 0x0000000184BFC600-0x0000000184BFC6B0
	public MovePlatformDelayType delayType { /* [XID] */ /* 0x0000000189B72CF0-0x0000000189B72D10 */ get => default; /* [XID] */ /* 0x0000000189B7A290-0x0000000189B7A2B0 */ private set {} } // 0x0000000184BFB750-0x0000000184BFB7F0 0x0000000184BFD600-0x0000000184BFD6B0

	// Constructors
	public ConfigPlatformMove() {} // 0x0000000184BFD960-0x0000000184BFDA00

	// Methods
	// [XID] // 0x0000000189B819F0-0x0000000189B81A10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BFD6B0-0x0000000184BFD810
	// [XID] // 0x0000000189B89110-0x0000000189B89130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184BFD160-0x0000000184BFD240
	// [XID] // 0x0000000189B90750-0x0000000189B90770
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA51B */) => default; // 0x0000000184BFCD70-0x0000000184BFCE50
	// [XID] // 0x0000000189B97B20-0x0000000189B97B40
	public override int GetHashNum() => default; // 0x0000000184BFB680-0x0000000184BFB750
	// [XID] // 0x0000000189B9EE90-0x0000000189B9EEB0
	public override void InitEmpty() {} // 0x0000000184BFC6B0-0x0000000184BFC7C0
	[BlackList] // 0x0000000189BA6760-0x0000000189BA67A0
	// [XID] // 0x0000000189BA6760-0x0000000189BA67A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184BFBDD0-0x0000000184BFC150
	// [XID] // 0x0000000189BB0E50-0x0000000189BB0E70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184BFABA0-0x0000000184BFB080
	[BlackList] // 0x0000000189BB7FE0-0x0000000189BB8020
	// [XID] // 0x0000000189BB7FE0-0x0000000189BB8020
	public static new ConfigPlatformMove ParseFromJson(JSONNode node) => default; // 0x0000000184BFCEB0-0x0000000184BFD100
	// [XID] // 0x0000000189BC2FD0-0x0000000189BC2FF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA51C */, bool useObjectPool = false /* Metadata: 0x00AFA520 */) => default; // 0x0000000184BFCA70-0x0000000184BFCD70
	// [XID] // 0x0000000189BCA850-0x0000000189BCA870
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA521 */, bool useObjectPool = false /* Metadata: 0x00AFA525 */) => default; // 0x0000000184BFB8D0-0x0000000184BFBCD0
	// [XID] // 0x0000000189BD1E40-0x0000000189BD1E60
	public static new ConfigPlatformMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA526 */, bool useObjectPool = false /* Metadata: 0x00AFA52A */) => default; // 0x0000000184BFC1F0-0x0000000184BFC410
	[BlackList] // 0x0000000189BD94C0-0x0000000189BD9500
	// [XID] // 0x0000000189BD94C0-0x0000000189BD9500
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BFB080-0x0000000184BFB350
	// [XID] // 0x00000001895E9070-0x00000001895E9090
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BFD240-0x0000000184BFD600
	[BlackList] // 0x00000001895F0880-0x00000001895F08C0
	// [XID] // 0x00000001895F0880-0x00000001895F08C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184BFC8A0-0x0000000184BFC990
	[BlackList] // 0x00000001895FB090-0x00000001895FB0D0
	// [XID] // 0x00000001895FB090-0x00000001895FB0D0
	public override void AutoAllocTypeFields() {} // 0x0000000184BFB350-0x0000000184BFB3F0
	[BlackList] // 0x0000000189605690-0x00000001896056D0
	// [XID] // 0x0000000189605690-0x00000001896056D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184BFB3F0-0x0000000184BFB560
	[BlackList] // 0x0000000189610190-0x00000001896101D0
	// [XID] // 0x0000000189610190-0x00000001896101D0
	public override void ReturnToObjectPool() {} // 0x0000000184BFD8C0-0x0000000184BFD960
}

