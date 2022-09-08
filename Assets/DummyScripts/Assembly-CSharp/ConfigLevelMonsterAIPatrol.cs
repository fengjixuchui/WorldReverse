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
public class ConfigLevelMonsterAIPatrol : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18494
{
	// Fields
	private SimpleSafeUInt32 aiPatrolGroupIdRawNum; // 0x10
	private bool _aiPatrolIsLeader; // 0x14
	private Point2D _aiPatrolOffset; // 0x18

	// Properties
	public uint aiPatrolGroupId { /* [XID] */ /* 0x0000000189B3FFE0-0x0000000189B40000 */ get => default; /* [XID] */ /* 0x0000000189B47820-0x0000000189B47840 */ private set {} } // 0x0000000184B8AB60-0x0000000184B8AC30 0x0000000184B8B3B0-0x0000000184B8B490
	public bool aiPatrolIsLeader { /* [XID] */ /* 0x0000000189B4EF50-0x0000000189B4EF70 */ get => default; /* [XID] */ /* 0x0000000189B56950-0x0000000189B56970 */ private set {} } // 0x0000000184B8A7D0-0x0000000184B8A870 0x0000000184B8B530-0x0000000184B8B5E0
	public Point2D aiPatrolOffset { /* [XID] */ /* 0x0000000189B5E180-0x0000000189B5E1A0 */ get => default; /* [XID] */ /* 0x0000000189B65640-0x0000000189B65660 */ private set {} } // 0x0000000184B8B490-0x0000000184B8B530 0x0000000184B8A720-0x0000000184B8A7D0

	// Constructors
	public ConfigLevelMonsterAIPatrol() {} // 0x0000000184B8BC00-0x0000000184B8BCA0

	// Methods
	// [XID] // 0x0000000189B6CC00-0x0000000189B6CC20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B8B8F0-0x0000000184B8BA20
	// [XID] // 0x0000000189B743B0-0x0000000189B743D0
	public void InitEmpty() {} // 0x0000000184B8AFB0-0x0000000184B8B0B0
	[BlackList] // 0x0000000189B7B9F0-0x0000000189B7BA30
	// [XID] // 0x0000000189B7B9F0-0x0000000189B7BA30
	public bool FromJson(JSONNode node) => default; // 0x0000000184B8AC30-0x0000000184B8AFB0
	// [XID] // 0x0000000189B86500-0x0000000189B86520
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B89F60-0x0000000184B8A2E0
	// [XID] // 0x0000000189B8D550-0x0000000189B8D570
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F59 */, bool useObjectPool = false /* Metadata: 0x00AF9F5D */) => default; // 0x0000000184B8B0B0-0x0000000184B8B3B0
	// [XID] // 0x0000000189B94B50-0x0000000189B94B70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F5E */, bool useObjectPool = false /* Metadata: 0x00AF9F62 */) => default; // 0x0000000184B8A870-0x0000000184B8AB60
	[BlackList] // 0x0000000189B9C240-0x0000000189B9C280
	// [XID] // 0x0000000189B9C240-0x0000000189B9C280
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B8A2E0-0x0000000184B8A5B0
	// [XID] // 0x0000000189BA67C0-0x0000000189BA67E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B8B5E0-0x0000000184B8B8F0
	[BlackList] // 0x0000000189BADA20-0x0000000189BADA60
	// [XID] // 0x0000000189BADA20-0x0000000189BADA60
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B8A5B0-0x0000000184B8A650
	[BlackList] // 0x0000000189BB8020-0x0000000189BB8060
	// [XID] // 0x0000000189BB8020-0x0000000189BB8060
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B8A650-0x0000000184B8A720
	[BlackList] // 0x0000000189BC3010-0x0000000189BC3050
	// [XID] // 0x0000000189BC3010-0x0000000189BC3050
	public virtual void ReturnToObjectPool() {} // 0x0000000184B8BB60-0x0000000184B8BC00
	[BlackList] // 0x0000000189BCD780-0x0000000189BCD7C0
	// [XID] // 0x0000000189BCD780-0x0000000189BCD7C0
	public virtual void OnPoolAllocated() {} // 0x0000000184B8BAC0-0x0000000184B8BB60
	[BlackList] // 0x0000000189BD7B70-0x0000000189BD7BB0
	// [XID] // 0x0000000189BD7B70-0x0000000189BD7BB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B8BA20-0x0000000184B8BAC0
}

