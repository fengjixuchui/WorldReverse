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
public class ConfigAIReactActionPointSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17434
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIReactActionPointData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIReactActionPointData> _specification; // 0x30

	// Properties
	public ConfigAIReactActionPointData defaultSetting { /* [XID] */ /* 0x0000000189BBE250-0x0000000189BBE270 */ get => default; /* [XID] */ /* 0x0000000189BC5F40-0x0000000189BC5F60 */ private set {} } // 0x0000000183BD7630-0x0000000183BD76D0 0x0000000183BD5470-0x0000000183BD5520
	public Dictionary<SimpleSafeInt32, ConfigAIReactActionPointData> specification { /* [XID] */ /* 0x0000000189BCD980-0x0000000189BCD9A0 */ get => default; /* [XID] */ /* 0x0000000189BD4E50-0x0000000189BD4E70 */ private set {} } // 0x0000000183BD5B20-0x0000000183BD5BC0 0x0000000183BD7090-0x0000000183BD7140

	// Constructors
	public ConfigAIReactActionPointSetting() {} // 0x0000000183BD7B70-0x0000000183BD7BF0

	// Methods
	// [XID] // 0x0000000189BDC9C0-0x0000000189BDC9E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183BD79B0-0x0000000183BD7AD0
	// [XID] // 0x00000001895E9270-0x00000001895E9290
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183BD7530-0x0000000183BD7630
	// [XID] // 0x00000001895F09E0-0x00000001895F0A00
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E77 */) => default; // 0x0000000183BD7140-0x0000000183BD7220
	// [XID] // 0x00000001895F8390-0x00000001895F83B0
	public override int GetHashNum() => default; // 0x0000000183BD5ED0-0x0000000183BD5FA0
	// [XID] // 0x00000001895FF8F0-0x00000001895FF910
	public override void InitEmpty() {} // 0x0000000183BD6AD0-0x0000000183BD6BC0
	[BlackList] // 0x0000000189607100-0x0000000189607140
	// [XID] // 0x0000000189607100-0x0000000189607140
	public override bool FromJson(JSONNode node) => default; // 0x0000000183BD64C0-0x0000000183BD6840
	// [XID] // 0x0000000189611B00-0x0000000189611B20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183BD5520-0x0000000183BD5850
	[BlackList] // 0x0000000189619440-0x0000000189619480
	// [XID] // 0x0000000189619440-0x0000000189619480
	public static new ConfigAIReactActionPointSetting ParseFromJson(JSONNode node) => default; // 0x0000000183BD7280-0x0000000183BD74D0
	// [XID] // 0x0000000189623700-0x0000000189623720
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E78 */, bool useObjectPool = false /* Metadata: 0x00AF6E7C */) => default; // 0x0000000183BD6D90-0x0000000183BD7090
	// [XID] // 0x000000018962B060-0x000000018962B080
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E7D */, bool useObjectPool = false /* Metadata: 0x00AF6E81 */) => default; // 0x0000000183BD6080-0x0000000183BD63C0
	// [XID] // 0x0000000189632780-0x00000001896327A0
	public static new ConfigAIReactActionPointSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E82 */, bool useObjectPool = false /* Metadata: 0x00AF6E86 */) => default; // 0x0000000183BD6840-0x0000000183BD6A60
	[BlackList] // 0x000000018963A250-0x000000018963A290
	// [XID] // 0x000000018963A250-0x000000018963A290
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183BD5850-0x0000000183BD5B20
	// [XID] // 0x00000001896448D0-0x00000001896448F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183BD76D0-0x0000000183BD79B0
	[BlackList] // 0x000000018964C130-0x000000018964C170
	// [XID] // 0x000000018964C130-0x000000018964C170
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183BD6CA0-0x0000000183BD6D90
	[BlackList] // 0x00000001896566F0-0x0000000189656730
	// [XID] // 0x00000001896566F0-0x0000000189656730
	public override void AutoAllocTypeFields() {} // 0x0000000183BD5BC0-0x0000000183BD5C60
	[BlackList] // 0x0000000189660E90-0x0000000189660ED0
	// [XID] // 0x0000000189660E90-0x0000000189660ED0
	public override void AutoRecycleTypeFields() {} // 0x0000000183BD5C60-0x0000000183BD5DB0
	[BlackList] // 0x000000018966B560-0x000000018966B5A0
	// [XID] // 0x000000018966B560-0x000000018966B5A0
	public override void ReturnToObjectPool() {} // 0x0000000183BD7AD0-0x0000000183BD7B70
}

