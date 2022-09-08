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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicUIntStimulusHandler : ConfigMusicParameterizedStimulusHandler, IAutoAllocRecycle // TypeDefIndex: 18752
{
	// Fields
	private SimpleSafeUInt32 uintParamRawNum; // 0x20

	// Properties
	public uint uintParam { /* [XID] */ /* 0x0000000189A6F620-0x0000000189A6F640 */ get => default; /* [XID] */ /* 0x0000000189A76DB0-0x0000000189A76DD0 */ private set {} } // 0x00000001837B3050-0x00000001837B3120 0x00000001837B4960-0x00000001837B4A40

	// Constructors
	public ConfigMusicUIntStimulusHandler() {} // 0x00000001837B4AE0-0x00000001837B4B40

	// Methods
	// [XID] // 0x0000000189A7E830-0x0000000189A7E850
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837B4870-0x00000001837B4960
	// [XID] // 0x0000000189A86110-0x0000000189A86130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837B4590-0x00000001837B4640
	// [XID] // 0x0000000189A8DA30-0x0000000189A8DA50
	public override ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAAFD */) => default; // 0x00000001837B41A0-0x00000001837B4280
	// [XID] // 0x0000000189A94F90-0x0000000189A94FB0
	public override int GetHashNum() => default; // 0x00000001837B2F80-0x00000001837B3050
	// [XID] // 0x0000000189A9C8F0-0x0000000189A9C910
	public override void InitEmpty() {} // 0x00000001837B3C00-0x00000001837B3CD0
	[BlackList] // 0x0000000189AA4000-0x0000000189AA4040
	// [XID] // 0x0000000189AA4000-0x0000000189AA4040
	public override bool FromJson(JSONNode node) => default; // 0x00000001837B3570-0x00000001837B38F0
	// [XID] // 0x0000000189AAE6A0-0x0000000189AAE6C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837B27B0-0x00000001837B2A10
	[BlackList] // 0x0000000189AB5F00-0x0000000189AB5F40
	// [XID] // 0x0000000189AB5F00-0x0000000189AB5F40
	public static new ConfigMusicUIntStimulusHandler ParseFromJson(JSONNode node) => default; // 0x00000001837B42E0-0x00000001837B4530
	// [XID] // 0x0000000189AC0890-0x0000000189AC08B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAFE */, bool useObjectPool = false /* Metadata: 0x00AFAB02 */) => default; // 0x00000001837B3EA0-0x00000001837B41A0
	// [XID] // 0x0000000189AC8270-0x0000000189AC8290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB03 */, bool useObjectPool = false /* Metadata: 0x00AFAB07 */) => default; // 0x00000001837B3200-0x00000001837B3470
	// [XID] // 0x0000000189ACFA30-0x0000000189ACFA50
	public static new ConfigMusicUIntStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB08 */, bool useObjectPool = false /* Metadata: 0x00AFAB0C */) => default; // 0x00000001837B38F0-0x00000001837B3B10
	[BlackList] // 0x0000000189AD76E0-0x0000000189AD7720
	// [XID] // 0x0000000189AD76E0-0x0000000189AD7720
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837B2A10-0x00000001837B2CE0
	// [XID] // 0x0000000189AE1FC0-0x0000000189AE1FE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837B4640-0x00000001837B4870
	[BlackList] // 0x0000000189AE97F0-0x0000000189AE9830
	// [XID] // 0x0000000189AE97F0-0x0000000189AE9830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837B3DB0-0x00000001837B3EA0
	// [XID] // 0x0000000189AF4390-0x0000000189AF43B0
	protected override bool MatchParameter(IStimulusParameter parameter) => default; // 0x00000001837B2630-0x00000001837B2730
	[BlackList] // 0x0000000189AFBAE0-0x0000000189AFBB20
	// [XID] // 0x0000000189AFBAE0-0x0000000189AFBB20
	public override void AutoAllocTypeFields() {} // 0x00000001837B2CE0-0x00000001837B2D80
	[BlackList] // 0x0000000189B06200-0x0000000189B06240
	// [XID] // 0x0000000189B06200-0x0000000189B06240
	public override void AutoRecycleTypeFields() {} // 0x00000001837B2D80-0x00000001837B2E60
	[BlackList] // 0x0000000189B10A10-0x0000000189B10A50
	// [XID] // 0x0000000189B10A10-0x0000000189B10A50
	public override void ReturnToObjectPool() {} // 0x00000001837B4A40-0x00000001837B4AE0
}

