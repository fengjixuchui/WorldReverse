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
public class ConfigAIBrownianMotionSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17486
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBrownianMotionData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIBrownianMotionData> _specification; // 0x30

	// Properties
	public ConfigAIBrownianMotionData defaultSetting { /* [XID] */ /* 0x0000000189B6CEE0-0x0000000189B6CF00 */ get => default; /* [XID] */ /* 0x0000000189B74670-0x0000000189B74690 */ private set {} } // 0x00000001827FDF00-0x00000001827FDFA0 0x00000001827FBD40-0x00000001827FBDF0
	public Dictionary<SimpleSafeInt32, ConfigAIBrownianMotionData> specification { /* [XID] */ /* 0x0000000189B7BC90-0x0000000189B7BCB0 */ get => default; /* [XID] */ /* 0x0000000189B83580-0x0000000189B835A0 */ private set {} } // 0x00000001827FC3F0-0x00000001827FC490 0x00000001827FD960-0x00000001827FDA10

	// Constructors
	public ConfigAIBrownianMotionSetting() {} // 0x00000001827FE440-0x00000001827FE4C0

	// Methods
	// [XID] // 0x0000000189B8A9F0-0x0000000189B8AA10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827FE280-0x00000001827FE3A0
	// [XID] // 0x0000000189B91FC0-0x0000000189B91FE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001827FDE00-0x00000001827FDF00
	// [XID] // 0x0000000189B99440-0x0000000189B99460
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF703B */) => default; // 0x00000001827FDA10-0x00000001827FDAF0
	// [XID] // 0x0000000189BA0910-0x0000000189BA0930
	public override int GetHashNum() => default; // 0x00000001827FC7A0-0x00000001827FC870
	// [XID] // 0x0000000189BA8050-0x0000000189BA8070
	public override void InitEmpty() {} // 0x00000001827FD3A0-0x00000001827FD490
	[BlackList] // 0x0000000189BAF500-0x0000000189BAF540
	// [XID] // 0x0000000189BAF500-0x0000000189BAF540
	public override bool FromJson(JSONNode node) => default; // 0x00000001827FCD90-0x00000001827FD110
	// [XID] // 0x0000000189BB99E0-0x0000000189BB9A00
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827FBDF0-0x00000001827FC120
	[BlackList] // 0x0000000189BC1920-0x0000000189BC1960
	// [XID] // 0x0000000189BC1920-0x0000000189BC1960
	public static new ConfigAIBrownianMotionSetting ParseFromJson(JSONNode node) => default; // 0x00000001827FDB50-0x00000001827FDDA0
	// [XID] // 0x0000000189BCC0E0-0x0000000189BCC100
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF703C */, bool useObjectPool = false /* Metadata: 0x00AF7040 */) => default; // 0x00000001827FD660-0x00000001827FD960
	// [XID] // 0x0000000189BD3730-0x0000000189BD3750
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7041 */, bool useObjectPool = false /* Metadata: 0x00AF7045 */) => default; // 0x00000001827FC950-0x00000001827FCC90
	// [XID] // 0x0000000189BDB080-0x0000000189BDB0A0
	public static new ConfigAIBrownianMotionSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7046 */, bool useObjectPool = false /* Metadata: 0x00AF704A */) => default; // 0x00000001827FD110-0x00000001827FD330
	[BlackList] // 0x00000001895E79B0-0x00000001895E79F0
	// [XID] // 0x00000001895E79B0-0x00000001895E79F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827FC120-0x00000001827FC3F0
	// [XID] // 0x00000001895F2190-0x00000001895F21B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827FDFA0-0x00000001827FE280
	[BlackList] // 0x00000001895F9AC0-0x00000001895F9B00
	// [XID] // 0x00000001895F9AC0-0x00000001895F9B00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827FD570-0x00000001827FD660
	[BlackList] // 0x0000000189604350-0x0000000189604390
	// [XID] // 0x0000000189604350-0x0000000189604390
	public override void AutoAllocTypeFields() {} // 0x00000001827FC490-0x00000001827FC530
	[BlackList] // 0x000000018960EB40-0x000000018960EB80
	// [XID] // 0x000000018960EB40-0x000000018960EB80
	public override void AutoRecycleTypeFields() {} // 0x00000001827FC530-0x00000001827FC680
	[BlackList] // 0x0000000189619400-0x0000000189619440
	// [XID] // 0x0000000189619400-0x0000000189619440
	public override void ReturnToObjectPool() {} // 0x00000001827FE3A0-0x00000001827FE440
}

