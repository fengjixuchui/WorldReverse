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
public class ConfigCharacter : ConfigEntity, IAutoAllocRecycle // TypeDefIndex: 18022
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombat _combat; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEquipController _equipController; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _abilities; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigBaseStateLayer> _stateLayers; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFace _face; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPartController _partControl; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBillboard _billboard; // 0x88
	private string[] _bindEmotions; // 0x90

	// Properties
	public ConfigCombat combat { /* [XID] */ /* 0x00000001896B7BF0-0x00000001896B7C10 */ get => default; /* [XID] */ /* 0x00000001896BEBB0-0x00000001896BEBD0 */ private set {} } // 0x00000001815BB890-0x00000001815BB930 0x00000001815BC190-0x00000001815BC240
	public ConfigEquipController equipController { /* [XID] */ /* 0x00000001896C6630-0x00000001896C6650 */ get => default; /* [XID] */ /* 0x00000001896CDB50-0x00000001896CDB70 */ private set {} } // 0x00000001815BC010-0x00000001815BC0B0 0x00000001815BD2D0-0x00000001815BD380
	public ConfigEntityAbilityEntry[] abilities { /* [XID] */ /* 0x00000001896D5140-0x00000001896D5160 */ get => default; /* [XID] */ /* 0x00000001896DC720-0x00000001896DC740 */ private set {} } // 0x00000001815BB780-0x00000001815BB820 0x00000001815BD000-0x00000001815BD0B0
	public Dictionary<string, ConfigBaseStateLayer> stateLayers { /* [XID] */ /* 0x00000001896E4050-0x00000001896E4070 */ get => default; /* [XID] */ /* 0x00000001896EB500-0x00000001896EB520 */ private set {} } // 0x00000001815BA450-0x00000001815BA4F0 0x00000001815BC2A0-0x00000001815BC350
	public ConfigFace face { /* [XID] */ /* 0x00000001896F2850-0x00000001896F2870 */ get => default; /* [XID] */ /* 0x00000001896FA170-0x00000001896FA190 */ private set {} } // 0x00000001815BB930-0x00000001815BB9D0 0x00000001815BA5A0-0x00000001815BA650
	public ConfigPartController partControl { /* [XID] */ /* 0x0000000189701940-0x0000000189701960 */ get => default; /* [XID] */ /* 0x0000000189709200-0x0000000189709220 */ private set {} } // 0x00000001815BC7B0-0x00000001815BC860 0x00000001815BCF50-0x00000001815BD000
	public ConfigBillboard billboard { /* [XID] */ /* 0x0000000189710A30-0x0000000189710A50 */ get => default; /* [XID] */ /* 0x0000000189717DB0-0x0000000189717DD0 */ private set {} } // 0x00000001815BA4F0-0x00000001815BA5A0 0x00000001815BB080-0x00000001815BB130
	public string[] bindEmotions { /* [XID] */ /* 0x00000001896408F0-0x0000000189640910 */ get => default; /* [XID] */ /* 0x0000000189726D80-0x0000000189726DA0 */ private set {} } // 0x00000001815BB6D0-0x00000001815BB780 0x00000001815BA6B0-0x00000001815BA760

	// Constructors
	public ConfigCharacter() {} // 0x00000001815BD420-0x00000001815BD480

	// Methods
	// [XID] // 0x000000018972E370-0x000000018972E390
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001815BD0B0-0x00000001815BD2D0
	// [XID] // 0x0000000189735A20-0x0000000189735A40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001815BC600-0x00000001815BC7B0
	// [XID] // 0x000000018973D5F0-0x000000018973D610
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF86F3 */) => default; // 0x00000001815BC0B0-0x00000001815BC190
	// [XID] // 0x0000000189744AD0-0x0000000189744AF0
	public override int GetHashNum() => default; // 0x00000001815BA380-0x00000001815BA450
	// [XID] // 0x000000018974C7C0-0x000000018974C7E0
	public override void InitEmpty() {} // 0x00000001815BB9D0-0x00000001815BBB40
	[BlackList] // 0x0000000189753AA0-0x0000000189753AE0
	// [XID] // 0x0000000189753AA0-0x0000000189753AE0
	public override bool FromJson(JSONNode node) => default; // 0x00000001815BB130-0x00000001815BB4B0
	// [XID] // 0x000000018975DF30-0x000000018975DF50
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001815B9330-0x00000001815B9BC0
	[BlackList] // 0x0000000189765690-0x00000001897656D0
	// [XID] // 0x0000000189765690-0x00000001897656D0
	public static new ConfigCharacter ParseFromJson(JSONNode node) => default; // 0x00000001815BC350-0x00000001815BC5A0
	// [XID] // 0x000000018976FDF0-0x000000018976FE10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86F4 */, bool useObjectPool = false /* Metadata: 0x00AF86F8 */) => default; // 0x00000001815BBD10-0x00000001815BC010
	// [XID] // 0x0000000189777590-0x00000001897775B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86F9 */, bool useObjectPool = false /* Metadata: 0x00AF86FD */) => default; // 0x00000001815BA7E0-0x00000001815BAF80
	// [XID] // 0x000000018977ECC0-0x000000018977ECE0
	public static new ConfigCharacter ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86FE */, bool useObjectPool = false /* Metadata: 0x00AF8702 */) => default; // 0x00000001815BB4B0-0x00000001815BB6D0
	[BlackList] // 0x0000000189786600-0x0000000189786640
	// [XID] // 0x0000000189786600-0x0000000189786640
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001815B9BC0-0x00000001815B9E90
	// [XID] // 0x0000000189790AF0-0x0000000189790B10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001815BC860-0x00000001815BCF50
	[BlackList] // 0x0000000189798480-0x00000001897984C0
	// [XID] // 0x0000000189798480-0x00000001897984C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001815BBC20-0x00000001815BBD10
	[BlackList] // 0x00000001897A30C0-0x00000001897A3100
	// [XID] // 0x00000001897A30C0-0x00000001897A3100
	public override void AutoAllocTypeFields() {} // 0x00000001815B9E90-0x00000001815B9F30
	[BlackList] // 0x00000001897AD770-0x00000001897AD7B0
	// [XID] // 0x00000001897AD770-0x00000001897AD7B0
	public override void AutoRecycleTypeFields() {} // 0x00000001815B9F30-0x00000001815BA260
	[BlackList] // 0x00000001897B8680-0x00000001897B86C0
	// [XID] // 0x00000001897B8680-0x00000001897B86C0
	public override void ReturnToObjectPool() {} // 0x00000001815BD380-0x00000001815BD420
}

