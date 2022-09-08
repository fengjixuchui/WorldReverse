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
public class ConfigSurroundBulletMove : ConfigBulletMove, IAutoAllocRecycle // TypeDefIndex: 18612
{
	// Fields
	private bool _clockwise; // 0x58
	private SimpleSafeFloat radiusRawNum; // 0x5C
	private bool _traceOnYAxis; // 0x60
	private bool _destroyWhenTargetDie; // 0x61

	// Properties
	public bool clockwise { /* [XID] */ /* 0x00000001896DDE40-0x00000001896DDE60 */ get => default; /* [XID] */ /* 0x00000001896E5410-0x00000001896E5430 */ private set {} } // 0x000000018228C870-0x000000018228C910 0x000000018228B1C0-0x000000018228B270
	public float radius { /* [XID] */ /* 0x00000001896ECA40-0x00000001896ECA60 */ get => default; /* [XID] */ /* 0x00000001896F41E0-0x00000001896F4200 */ private set {} } // 0x000000018228CA20-0x000000018228CB00 0x000000018228D0A0-0x000000018228D180
	public bool traceOnYAxis { /* [XID] */ /* 0x00000001896FBA70-0x00000001896FBA90 */ get => default; /* [XID] */ /* 0x0000000189702FD0-0x0000000189702FF0 */ private set {} } // 0x000000018228BEA0-0x000000018228BF40 0x000000018228CFF0-0x000000018228D0A0
	public bool destroyWhenTargetDie { /* [XID] */ /* 0x000000018970A6A0-0x000000018970A6C0 */ get => default; /* [XID] */ /* 0x0000000189712130-0x0000000189712150 */ private set {} } // 0x000000018228B6C0-0x000000018228B760 0x000000018228B7E0-0x000000018228B890

	// Constructors
	public ConfigSurroundBulletMove() {} // 0x000000018228D220-0x000000018228D280

	// Methods
	// [XID] // 0x00000001897197F0-0x0000000189719810
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018228CEA0-0x000000018228CFF0
	// [XID] // 0x0000000189720D70-0x0000000189720D90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018228C970-0x000000018228CA20
	// [XID] // 0x0000000189728430-0x0000000189728450
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA5C5 */) => default; // 0x000000018228C4E0-0x000000018228C5C0
	// [XID] // 0x000000018972FB90-0x000000018972FBB0
	public override int GetHashNum() => default; // 0x000000018228B010-0x000000018228B0E0
	// [XID] // 0x00000001897375C0-0x00000001897375E0
	public override void InitEmpty() {} // 0x000000018228BF40-0x000000018228C010
	[BlackList] // 0x000000018973F020-0x000000018973F060
	// [XID] // 0x000000018973F020-0x000000018973F060
	public override bool FromJson(JSONNode node) => default; // 0x000000018228B890-0x000000018228BC10
	// [XID] // 0x00000001897495E0-0x0000000189749600
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018228A5F0-0x000000018228AAA0
	[BlackList] // 0x0000000189750AA0-0x0000000189750AE0
	// [XID] // 0x0000000189750AA0-0x0000000189750AE0
	public static new ConfigSurroundBulletMove ParseFromJson(JSONNode node) => default; // 0x000000018228C620-0x000000018228C870
	// [XID] // 0x000000018975AF00-0x000000018975AF20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5C6 */, bool useObjectPool = false /* Metadata: 0x00AFA5CA */) => default; // 0x000000018228C1E0-0x000000018228C4E0
	// [XID] // 0x00000001897628B0-0x00000001897628D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5CB */, bool useObjectPool = false /* Metadata: 0x00AFA5CF */) => default; // 0x000000018228B270-0x000000018228B640
	// [XID] // 0x0000000189769EB0-0x0000000189769ED0
	public static new ConfigSurroundBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5D0 */, bool useObjectPool = false /* Metadata: 0x00AFA5D4 */) => default; // 0x000000018228BC10-0x000000018228BE30
	[BlackList] // 0x0000000189771670-0x00000001897716B0
	// [XID] // 0x0000000189771670-0x00000001897716B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018228AAA0-0x000000018228AD70
	// [XID] // 0x000000018977BC40-0x000000018977BC60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018228CB00-0x000000018228CEA0
	[BlackList] // 0x0000000189783610-0x0000000189783650
	// [XID] // 0x0000000189783610-0x0000000189783650
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018228C0F0-0x000000018228C1E0
	[BlackList] // 0x000000018978DBD0-0x000000018978DC10
	// [XID] // 0x000000018978DBD0-0x000000018978DC10
	public override void AutoAllocTypeFields() {} // 0x000000018228AD70-0x000000018228AE10
	[BlackList] // 0x00000001897983C0-0x0000000189798400
	// [XID] // 0x00000001897983C0-0x0000000189798400
	public override void AutoRecycleTypeFields() {} // 0x000000018228AE10-0x000000018228AEF0
	[BlackList] // 0x00000001897A2FA0-0x00000001897A2FE0
	// [XID] // 0x00000001897A2FA0-0x00000001897A2FE0
	public override void ReturnToObjectPool() {} // 0x000000018228D180-0x000000018228D220
}

