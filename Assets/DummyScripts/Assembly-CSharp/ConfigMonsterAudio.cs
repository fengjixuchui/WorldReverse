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
public class ConfigMonsterAudio : ConfigCharacterAudio, IAutoAllocRecycle // TypeDefIndex: 18048
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _randomVariantSwitchGroup; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _randomVariantSwitchValues; // 0x40

	// Properties
	public ConfigWwiseString randomVariantSwitchGroup { /* [XID] */ /* 0x0000000189827CE0-0x0000000189827D00 */ get => default; /* [XID] */ /* 0x000000018982F080-0x000000018982F0A0 */ private set {} } // 0x000000018368D620-0x000000018368D6C0 0x000000018368C2B0-0x000000018368C360
	public ConfigWwiseString[] randomVariantSwitchValues { /* [XID] */ /* 0x0000000189836910-0x0000000189836930 */ get => default; /* [XID] */ /* 0x000000018983DCA0-0x000000018983DCC0 */ private set {} } // 0x000000018368CE70-0x000000018368CF10 0x000000018368C7A0-0x000000018368C850

	// Constructors
	public ConfigMonsterAudio() {} // 0x000000018368DF70-0x000000018368DFD0

	// Methods
	// [XID] // 0x0000000189845510-0x0000000189845530
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018368DDB0-0x000000018368DED0
	// [XID] // 0x000000018984C9A0-0x000000018984C9C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018368D9D0-0x000000018368DAD0
	// [XID] // 0x0000000189853A80-0x0000000189853AA0
	public override ConfigEntityAudio Clone(bool useObjectPool = false /* Metadata: 0x00AF87CD */) => default; // 0x000000018368D540-0x000000018368D620
	// [XID] // 0x000000018985B530-0x000000018985B550
	public override int GetHashNum() => default; // 0x000000018368C180-0x000000018368C250
	// [XID] // 0x0000000189862AB0-0x0000000189862AD0
	public override void InitEmpty() {} // 0x000000018368CF80-0x000000018368D070
	[BlackList] // 0x0000000189869F20-0x0000000189869F60
	// [XID] // 0x0000000189869F20-0x0000000189869F60
	public override bool FromJson(JSONNode node) => default; // 0x000000018368C8D0-0x000000018368CC50
	// [XID] // 0x00000001898740A0-0x00000001898740C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018368B880-0x000000018368BBB0
	[BlackList] // 0x000000018987BB40-0x000000018987BB80
	// [XID] // 0x000000018987BB40-0x000000018987BB80
	public static new ConfigMonsterAudio ParseFromJson(JSONNode node) => default; // 0x000000018368D720-0x000000018368D970
	// [XID] // 0x00000001898860A0-0x00000001898860C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87CE */, bool useObjectPool = false /* Metadata: 0x00AF87D2 */) => default; // 0x000000018368D240-0x000000018368D540
	// [XID] // 0x000000018988D380-0x000000018988D3A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87D3 */, bool useObjectPool = false /* Metadata: 0x00AF87D7 */) => default; // 0x000000018368C3E0-0x000000018368C720
	// [XID] // 0x0000000189894A30-0x0000000189894A50
	public static new ConfigMonsterAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87D8 */, bool useObjectPool = false /* Metadata: 0x00AF87DC */) => default; // 0x000000018368CC50-0x000000018368CE70
	[BlackList] // 0x000000018989BF60-0x000000018989BFA0
	// [XID] // 0x000000018989BF60-0x000000018989BFA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018368BBB0-0x000000018368BE80
	// [XID] // 0x00000001898A6760-0x00000001898A6780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018368DAD0-0x000000018368DDB0
	[BlackList] // 0x00000001898ADE90-0x00000001898ADED0
	// [XID] // 0x00000001898ADE90-0x00000001898ADED0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018368D150-0x000000018368D240
	[BlackList] // 0x00000001898B8500-0x00000001898B8540
	// [XID] // 0x00000001898B8500-0x00000001898B8540
	public override void AutoAllocTypeFields() {} // 0x000000018368BE80-0x000000018368BF20
	[BlackList] // 0x00000001898C2A80-0x00000001898C2AC0
	// [XID] // 0x00000001898C2A80-0x00000001898C2AC0
	public override void AutoRecycleTypeFields() {} // 0x000000018368BF20-0x000000018368C060
	[BlackList] // 0x00000001898CD380-0x00000001898CD3C0
	// [XID] // 0x00000001898CD380-0x00000001898CD3C0
	public override void ReturnToObjectPool() {} // 0x000000018368DED0-0x000000018368DF70
}

