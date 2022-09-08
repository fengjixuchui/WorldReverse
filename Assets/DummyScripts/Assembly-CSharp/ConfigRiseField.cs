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
public class ConfigRiseField : ConfigForceField, IAutoAllocRecycle // TypeDefIndex: 18926
{
	// Fields
	private SimpleSafeFloat cdminRawNum; // 0x60
	private SimpleSafeFloat cdmaxRawNum; // 0x64
	private SimpleSafeFloat vminRawNum; // 0x68
	private SimpleSafeFloat vmaxRawNum; // 0x6C
	private SimpleSafeFloat hminRawNum; // 0x70
	private SimpleSafeFloat hmaxRawNum; // 0x74
	private SimpleSafeFloat attenuationRawNum; // 0x78
	private MoleMole.Config.Vector _box; // 0x7C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseShape _shape; // 0x88

	// Properties
	public float cdmin { /* [XID] */ /* 0x0000000189714BB0-0x0000000189714BD0 */ get => default; /* [XID] */ /* 0x000000018971C540-0x000000018971C560 */ private set {} } // 0x00000001835A2E70-0x00000001835A2F50 0x00000001835A07F0-0x00000001835A08D0
	public float cdmax { /* [XID] */ /* 0x0000000189A5AF80-0x0000000189A5AFA0 */ get => default; /* [XID] */ /* 0x000000018972B150-0x000000018972B170 */ private set {} } // 0x00000001835A2010-0x00000001835A20F0 0x00000001835A2D90-0x00000001835A2E70
	public float vmin { /* [XID] */ /* 0x0000000189A9A820-0x0000000189A9A840 */ get => default; /* [XID] */ /* 0x000000018973A110-0x000000018973A130 */ private set {} } // 0x00000001835A2150-0x00000001835A2230 0x00000001835A39D0-0x00000001835A3AB0
	public float vmax { /* [XID] */ /* 0x0000000189741C40-0x0000000189741C60 */ get => default; /* [XID] */ /* 0x0000000189749540-0x0000000189749560 */ private set {} } // 0x00000001835A0AF0-0x00000001835A0BD0 0x00000001835A09B0-0x00000001835A0A90
	public float hmin { /* [XID] */ /* 0x0000000189750960-0x0000000189750980 */ get => default; /* [XID] */ /* 0x0000000189757E10-0x0000000189757E30 */ private set {} } // 0x00000001835A27E0-0x00000001835A28C0 0x00000001835A3610-0x00000001835A36F0
	public float hmax { /* [XID] */ /* 0x000000018975F930-0x000000018975F950 */ get => default; /* [XID] */ /* 0x0000000189766EA0-0x0000000189766EC0 */ private set {} } // 0x00000001835A2700-0x00000001835A27E0 0x00000001835A19C0-0x00000001835A1AA0
	public float attenuation { /* [XID] */ /* 0x000000018976E3C0-0x000000018976E3E0 */ get => default; /* [XID] */ /* 0x0000000189775CE0-0x0000000189775D00 */ private set {} } // 0x00000001835A2920-0x00000001835A2A00 0x00000001835A1D30-0x00000001835A1E10
	public MoleMole.Config.Vector box { /* [XID] */ /* 0x000000018977D480-0x000000018977D4A0 */ get => default; /* [XID] */ /* 0x0000000189784DC0-0x0000000189784DE0 */ private set {} } // 0x00000001835A08D0-0x00000001835A09B0 0x00000001835A3900-0x00000001835A39D0
	public ConfigBaseShape shape { /* [XID] */ /* 0x0000000189A3D0F0-0x0000000189A3D110 */ get => default; /* [XID] */ /* 0x00000001897938A0-0x00000001897938C0 */ private set {} } // 0x00000001835A0BD0-0x00000001835A0C80 0x00000001835A1590-0x00000001835A1640

	// Constructors
	public ConfigRiseField() {} // 0x00000001835A3B50-0x00000001835A3BB0

	// Methods
	// [XID] // 0x000000018979BAD0-0x000000018979BAF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835A36F0-0x00000001835A3900
	// [XID] // 0x00000001897A2F60-0x00000001897A2F80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835A2CB0-0x00000001835A2D90
	// [XID] // 0x00000001897AA580-0x00000001897AA5A0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB3DB */) => default; // 0x00000001835A2620-0x00000001835A2700
	// [XID] // 0x00000001897B1FF0-0x00000001897B2010
	public override int GetHashNum() => default; // 0x00000001835A0720-0x00000001835A07F0
	// [XID] // 0x00000001897B99F0-0x00000001897B9A10
	public override void InitEmpty() {} // 0x00000001835A1E10-0x00000001835A1F90
	[BlackList] // 0x00000001897C1A70-0x00000001897C1AB0
	// [XID] // 0x00000001897C1A70-0x00000001897C1AB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001835A1640-0x00000001835A19C0
	// [XID] // 0x00000001897CBFB0-0x00000001897CBFD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018359F5D0-0x00000001835A0090
	[BlackList] // 0x00000001897D3940-0x00000001897D3980
	// [XID] // 0x00000001897D3940-0x00000001897D3980
	public static new ConfigRiseField ParseFromJson(JSONNode node) => default; // 0x00000001835A2A00-0x00000001835A2C50
	// [XID] // 0x00000001897DE170-0x00000001897DE190
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3DC */, bool useObjectPool = false /* Metadata: 0x00AFB3E0 */) => default; // 0x00000001835A2320-0x00000001835A2620
	// [XID] // 0x00000001897E5B70-0x00000001897E5B90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3E1 */, bool useObjectPool = false /* Metadata: 0x00AFB3E5 */) => default; // 0x00000001835A0D00-0x00000001835A1490
	// [XID] // 0x00000001897ED5B0-0x00000001897ED5D0
	public static new ConfigRiseField ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3E6 */, bool useObjectPool = false /* Metadata: 0x00AFB3EA */) => default; // 0x00000001835A1AA0-0x00000001835A1CC0
	[BlackList] // 0x00000001897F4D70-0x00000001897F4DB0
	// [XID] // 0x00000001897F4D70-0x00000001897F4DB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835A0090-0x00000001835A0360
	// [XID] // 0x00000001897FF4D0-0x00000001897FF4F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835A2F50-0x00000001835A3610
	[BlackList] // 0x0000000189806C30-0x0000000189806C70
	// [XID] // 0x0000000189806C30-0x0000000189806C70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835A2230-0x00000001835A2320
	[BlackList] // 0x00000001898111C0-0x0000000189811200
	// [XID] // 0x00000001898111C0-0x0000000189811200
	public override void AutoAllocTypeFields() {} // 0x00000001835A0360-0x00000001835A0400
	[BlackList] // 0x000000018981BC20-0x000000018981BC60
	// [XID] // 0x000000018981BC20-0x000000018981BC60
	public override void AutoRecycleTypeFields() {} // 0x00000001835A0400-0x00000001835A0600
	[BlackList] // 0x0000000189826090-0x00000001898260D0
	// [XID] // 0x0000000189826090-0x00000001898260D0
	public override void ReturnToObjectPool() {} // 0x00000001835A3AB0-0x00000001835A3B50
}

