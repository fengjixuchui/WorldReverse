/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAIPatrolFollowSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17437
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIPatrolFollowData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIPatrolFollowData> _specification; // 0x30

	// Properties
	public ConfigAIPatrolFollowData defaultSetting { /* [XID] */ /* 0x0000000189753B80-0x0000000189753BA0 */ get => default; /* [XID] */ /* 0x000000018975B0C0-0x000000018975B0E0 */ private set {} } // 0x0000000183B57E10-0x0000000183B57EB0 0x0000000183B55C50-0x0000000183B55D00
	public Dictionary<SimpleSafeInt32, ConfigAIPatrolFollowData> specification { /* [XID] */ /* 0x0000000189762A90-0x0000000189762AB0 */ get => default; /* [XID] */ /* 0x000000018976A0F0-0x000000018976A110 */ private set {} } // 0x0000000183B56300-0x0000000183B563A0 0x0000000183B57870-0x0000000183B57920

	// Constructors
	public ConfigAIPatrolFollowSetting() {} // 0x0000000183B58350-0x0000000183B583D0

	// Methods
	// [XID] // 0x0000000189771950-0x0000000189771970
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B58190-0x0000000183B582B0
	// [XID] // 0x0000000189779040-0x0000000189779060
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B57D10-0x0000000183B57E10
	// [XID] // 0x00000001897807A0-0x00000001897807C0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E91 */) => default; // 0x0000000183B57920-0x0000000183B57A00
	// [XID] // 0x0000000189787F00-0x0000000189787F20
	public override int GetHashNum() => default; // 0x0000000183B566B0-0x0000000183B56780
	// [XID] // 0x000000018978F500-0x000000018978F520
	public override void InitEmpty() {} // 0x0000000183B572B0-0x0000000183B573A0
	[BlackList] // 0x0000000189796CB0-0x0000000189796CF0
	// [XID] // 0x0000000189796CB0-0x0000000189796CF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B56CA0-0x0000000183B57020
	// [XID] // 0x00000001897A1940-0x00000001897A1960
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B55D00-0x0000000183B56030
	[BlackList] // 0x00000001897A9200-0x00000001897A9240
	// [XID] // 0x00000001897A9200-0x00000001897A9240
	public static new ConfigAIPatrolFollowSetting ParseFromJson(JSONNode node) => default; // 0x0000000183B57A60-0x0000000183B57CB0
	// [XID] // 0x00000001897B3FF0-0x00000001897B4010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E92 */, bool useObjectPool = false /* Metadata: 0x00AF6E96 */) => default; // 0x0000000183B57570-0x0000000183B57870
	// [XID] // 0x00000001897BBCF0-0x00000001897BBD10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E97 */, bool useObjectPool = false /* Metadata: 0x00AF6E9B */) => default; // 0x0000000183B56860-0x0000000183B56BA0
	// [XID] // 0x00000001897C3570-0x00000001897C3590
	public static new ConfigAIPatrolFollowSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E9C */, bool useObjectPool = false /* Metadata: 0x00AF6EA0 */) => default; // 0x0000000183B57020-0x0000000183B57240
	[BlackList] // 0x00000001897CAD90-0x00000001897CADD0
	// [XID] // 0x00000001897CAD90-0x00000001897CADD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B56030-0x0000000183B56300
	// [XID] // 0x00000001897D53F0-0x00000001897D5410
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B57EB0-0x0000000183B58190
	[BlackList] // 0x00000001897DCAF0-0x00000001897DCB30
	// [XID] // 0x00000001897DCAF0-0x00000001897DCB30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B57480-0x0000000183B57570
	[BlackList] // 0x00000001897E7270-0x00000001897E72B0
	// [XID] // 0x00000001897E7270-0x00000001897E72B0
	public override void AutoAllocTypeFields() {} // 0x0000000183B563A0-0x0000000183B56440
	[BlackList] // 0x00000001897F22F0-0x00000001897F2330
	// [XID] // 0x00000001897F22F0-0x00000001897F2330
	public override void AutoRecycleTypeFields() {} // 0x0000000183B56440-0x0000000183B56590
	[BlackList] // 0x00000001897FCB00-0x00000001897FCB40
	// [XID] // 0x00000001897FCB00-0x00000001897FCB40
	public override void ReturnToObjectPool() {} // 0x0000000183B582B0-0x0000000183B58350
}

