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
public class ConfigBornByTargetLinearPoint : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17897
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _linearOffset; // 0x38
	private bool _baseOnTarget; // 0x40
	private bool _linearXZ; // 0x41
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _linearMin; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _linearMax; // 0x50

	// Properties
	public DynamicFloat linearOffset { /* [XID] */ /* 0x0000000189A46ED0-0x0000000189A46EF0 */ get => default; /* [XID] */ /* 0x0000000189A4E7D0-0x0000000189A4E7F0 */ private set {} } // 0x0000000182A83210-0x0000000182A832B0 0x0000000182A83FB0-0x0000000182A84060
	public bool baseOnTarget { /* [XID] */ /* 0x0000000189A55EC0-0x0000000189A55EE0 */ get => default; /* [XID] */ /* 0x0000000189A5D860-0x0000000189A5D880 */ private set {} } // 0x0000000182A82480-0x0000000182A82520 0x0000000182A832B0-0x0000000182A83360
	public bool linearXZ { /* [XID] */ /* 0x0000000189A65000-0x0000000189A65020 */ get => default; /* [XID] */ /* 0x0000000189A6C7A0-0x0000000189A6C7C0 */ private set {} } // 0x0000000182A83A10-0x0000000182A83AB0 0x0000000182A84110-0x0000000182A841C0
	public DynamicFloat linearMin { /* [XID] */ /* 0x0000000189A740B0-0x0000000189A740D0 */ get => default; /* [XID] */ /* 0x0000000189A7BA20-0x0000000189A7BA40 */ private set {} } // 0x0000000182A83670-0x0000000182A83710 0x0000000182A84060-0x0000000182A84110
	public DynamicFloat linearMax { /* [XID] */ /* 0x0000000189A832E0-0x0000000189A83300 */ get => default; /* [XID] */ /* 0x0000000189A8ABC0-0x0000000189A8ABE0 */ private set {} } // 0x0000000182A82AD0-0x0000000182A82B70 0x0000000182A81C40-0x0000000182A81CF0

	// Constructors
	public ConfigBornByTargetLinearPoint() {} // 0x0000000182A84880-0x0000000182A84930

	// Methods
	// [XID] // 0x0000000189A923B0-0x0000000189A923D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A84640-0x0000000182A847E0
	// [XID] // 0x0000000189A99DE0-0x0000000189A99E00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A83EA0-0x0000000182A83FB0
	// [XID] // 0x0000000189AA0D40-0x0000000189AA0D60
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF8089 */) => default; // 0x0000000182A83AB0-0x0000000182A83B90
	// [XID] // 0x0000000189AA83C0-0x0000000189AA83E0
	public override int GetHashNum() => default; // 0x0000000182A823B0-0x0000000182A82480
	// [XID] // 0x0000000189AB00E0-0x0000000189AB0100
	public override void InitEmpty() {} // 0x0000000182A833D0-0x0000000182A834A0
	[BlackList] // 0x0000000189AB7830-0x0000000189AB7870
	// [XID] // 0x0000000189AB7830-0x0000000189AB7870
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A82C70-0x0000000182A82FF0
	// [XID] // 0x0000000189AC25A0-0x0000000189AC25C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A81710-0x0000000182A81C40
	[BlackList] // 0x0000000189AC9C60-0x0000000189AC9CA0
	// [XID] // 0x0000000189AC9C60-0x0000000189AC9CA0
	public static new ConfigBornByTargetLinearPoint ParseFromJson(JSONNode node) => default; // 0x0000000182A83BF0-0x0000000182A83E40
	// [XID] // 0x0000000189AD4840-0x0000000189AD4860
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF808A */, bool useObjectPool = false /* Metadata: 0x00AF808E */) => default; // 0x0000000182A83710-0x0000000182A83A10
	// [XID] // 0x0000000189ADC160-0x0000000189ADC180
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF808F */, bool useObjectPool = false /* Metadata: 0x00AF8093 */) => default; // 0x0000000182A82600-0x0000000182A82AD0
	// [XID] // 0x0000000189AE3B70-0x0000000189AE3B90
	public static new ConfigBornByTargetLinearPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8094 */, bool useObjectPool = false /* Metadata: 0x00AF8098 */) => default; // 0x0000000182A82FF0-0x0000000182A83210
	[BlackList] // 0x0000000189AEB3F0-0x0000000189AEB430
	// [XID] // 0x0000000189AEB3F0-0x0000000189AEB430
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A81CF0-0x0000000182A81FC0
	// [XID] // 0x0000000189AF5C70-0x0000000189AF5C90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A841C0-0x0000000182A84640
	[BlackList] // 0x0000000189AFD210-0x0000000189AFD250
	// [XID] // 0x0000000189AFD210-0x0000000189AFD250
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A83580-0x0000000182A83670
	[BlackList] // 0x0000000189B07870-0x0000000189B078B0
	// [XID] // 0x0000000189B07870-0x0000000189B078B0
	public override void AutoAllocTypeFields() {} // 0x0000000182A81FC0-0x0000000182A82060
	[BlackList] // 0x0000000189B12180-0x0000000189B121C0
	// [XID] // 0x0000000189B12180-0x0000000189B121C0
	public override void AutoRecycleTypeFields() {} // 0x0000000182A82060-0x0000000182A82290
	[BlackList] // 0x0000000189B1C890-0x0000000189B1C8D0
	// [XID] // 0x0000000189B1C890-0x0000000189B1C8D0
	public override void ReturnToObjectPool() {} // 0x0000000182A847E0-0x0000000182A84880
}

