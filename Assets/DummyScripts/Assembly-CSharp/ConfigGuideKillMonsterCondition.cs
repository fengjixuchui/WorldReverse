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
public class ConfigGuideKillMonsterCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18252
{
	// Fields
	private bool _spawnNew; // 0x20
	private SimpleSafeUInt32 monsterIDRawNum; // 0x24
	private SimpleSafeUInt32 monsterLevelRawNum; // 0x28
	private MoleMole.Config.Vector _monsterPos; // 0x2C
	private SimpleSafeFloat monsterYawRawNum; // 0x38

	// Properties
	public bool spawnNew { /* [XID] */ /* 0x0000000189765590-0x00000001897655B0 */ get => default; /* [XID] */ /* 0x000000018976CEE0-0x000000018976CF00 */ private set {} } // 0x0000000182F3F660-0x0000000182F3F700 0x0000000182F3F4E0-0x0000000182F3F590
	public uint monsterID { /* [XID] */ /* 0x0000000189774370-0x0000000189774390 */ get => default; /* [XID] */ /* 0x000000018977BC80-0x000000018977BCA0 */ private set {} } // 0x0000000182F3F590-0x0000000182F3F660 0x0000000182F3FE10-0x0000000182F3FEF0
	public uint monsterLevel { /* [XID] */ /* 0x0000000189783690-0x00000001897836B0 */ get => default; /* [XID] */ /* 0x000000018978AD80-0x000000018978ADA0 */ private set {} } // 0x0000000182F40DD0-0x0000000182F40EA0 0x0000000182F40990-0x0000000182F40A70
	public MoleMole.Config.Vector monsterPos { /* [XID] */ /* 0x0000000189792380-0x00000001897923A0 */ get => default; /* [XID] */ /* 0x0000000189799910-0x0000000189799930 */ private set {} } // 0x0000000182F405C0-0x0000000182F406A0 0x0000000182F408C0-0x0000000182F40990
	public float monsterYaw { /* [XID] */ /* 0x00000001897A17A0-0x00000001897A17C0 */ get => default; /* [XID] */ /* 0x00000001897A9020-0x00000001897A9040 */ private set {} } // 0x0000000182F407E0-0x0000000182F408C0 0x0000000182F41590-0x0000000182F41670

	// Constructors
	public ConfigGuideKillMonsterCondition() {} // 0x0000000182F41710-0x0000000182F41770

	// Methods
	// [XID] // 0x00000001897B08C0-0x00000001897B08E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F41400-0x0000000182F41590
	// [XID] // 0x00000001897B8580-0x00000001897B85A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F40D20-0x0000000182F40DD0
	// [XID] // 0x00000001897C0620-0x00000001897C0640
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9193 */) => default; // 0x0000000182F406A0-0x0000000182F40780
	// [XID] // 0x00000001897C7ED0-0x00000001897C7EF0
	public override int GetHashNum() => default; // 0x0000000182F3EE70-0x0000000182F3EF40
	// [XID] // 0x00000001897CF270-0x00000001897CF290
	public override void InitEmpty() {} // 0x0000000182F3FFA0-0x0000000182F400F0
	[BlackList] // 0x00000001897D6A60-0x00000001897D6AA0
	// [XID] // 0x00000001897D6A60-0x00000001897D6AA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F3F800-0x0000000182F3FB80
	// [XID] // 0x00000001897E1380-0x00000001897E13A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F3E260-0x0000000182F3E8A0
	[BlackList] // 0x00000001897E8BD0-0x00000001897E8C10
	// [XID] // 0x00000001897E8BD0-0x00000001897E8C10
	public static new ConfigGuideKillMonsterCondition ParseFromJson(JSONNode node) => default; // 0x0000000182F40A70-0x0000000182F40CC0
	// [XID] // 0x00000001897F3850-0x00000001897F3870
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9194 */, bool useObjectPool = false /* Metadata: 0x00AF9198 */) => default; // 0x0000000182F402C0-0x0000000182F405C0
	// [XID] // 0x00000001897FB1B0-0x00000001897FB1D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9199 */, bool useObjectPool = false /* Metadata: 0x00AF919D */) => default; // 0x0000000182F3F020-0x0000000182F3F4E0
	// [XID] // 0x0000000189802640-0x0000000189802660
	public static new ConfigGuideKillMonsterCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF919E */, bool useObjectPool = false /* Metadata: 0x00AF91A2 */) => default; // 0x0000000182F3FB80-0x0000000182F3FDA0
	[BlackList] // 0x0000000189809B70-0x0000000189809BB0
	// [XID] // 0x0000000189809B70-0x0000000189809BB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F3E8A0-0x0000000182F3EB70
	// [XID] // 0x0000000189814130-0x0000000189814150
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F40F20-0x0000000182F41400
	[BlackList] // 0x000000018981BCA0-0x000000018981BCE0
	// [XID] // 0x000000018981BCA0-0x000000018981BCE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F401D0-0x0000000182F402C0
	// [XID] // 0x00000001898261F0-0x0000000189826210
	public override bool Ready(object body = null) => default; // 0x0000000182F3FEF0-0x0000000182F3FFA0
	[BlackList] // 0x000000018982D7A0-0x000000018982D7E0
	// [XID] // 0x000000018982D7A0-0x000000018982D7E0
	public override void AutoAllocTypeFields() {} // 0x0000000182F3EB70-0x0000000182F3EC10
	[BlackList] // 0x0000000189837DA0-0x0000000189837DE0
	// [XID] // 0x0000000189837DA0-0x0000000189837DE0
	public override void AutoRecycleTypeFields() {} // 0x0000000182F3EC10-0x0000000182F3ED50
	[BlackList] // 0x0000000189842580-0x00000001898425C0
	// [XID] // 0x0000000189842580-0x00000001898425C0
	public override void ReturnToObjectPool() {} // 0x0000000182F41670-0x0000000182F41710
}

