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
public class ConfigMusicStimulusHandler : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18746
{
	// Fields
	private MusicStimulus _stimulus; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _transitions; // 0x18

	// Properties
	public MusicStimulus stimulus { /* [XID] */ /* 0x00000001898367D0-0x00000001898367F0 */ get => default; /* [XID] */ /* 0x000000018983DB80-0x000000018983DBA0 */ private set {} } // 0x0000000182F5FFE0-0x0000000182F60080 0x0000000182F5F4D0-0x0000000182F5F580
	public ConfigMusicTransitions transitions { /* [XID] */ /* 0x00000001898453B0-0x00000001898453D0 */ get => default; /* [XID] */ /* 0x000000018984C8A0-0x000000018984C8C0 */ private set {} } // 0x0000000182F5F650-0x0000000182F5F6F0 0x0000000182F5EF80-0x0000000182F5F030

	// Constructors
	public ConfigMusicStimulusHandler() {} // 0x0000000182F60F30-0x0000000182F60F90

	// Methods
	// [XID] // 0x00000001898539A0-0x00000001898539C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F60C30-0x0000000182F60D50
	// [XID] // 0x000000018985B470-0x000000018985B490
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F60820-0x0000000182F608F0
	// [XID] // 0x0000000189862A10-0x0000000189862A30
	public virtual ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAACD */) => default; // 0x0000000182F60540-0x0000000182F60620
	// [XID] // 0x0000000189869E20-0x0000000189869E40
	public virtual int GetHashNum() => default; // 0x0000000182F5F580-0x0000000182F5F650
	// [XID] // 0x0000000189871230-0x0000000189871250
	public virtual void InitEmpty() {} // 0x0000000182F60080-0x0000000182F60150
	[BlackList] // 0x0000000189878B70-0x0000000189878BB0
	// [XID] // 0x0000000189878B70-0x0000000189878BB0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000182F5F9C0-0x0000000182F5FD40
	// [XID] // 0x0000000189882C30-0x0000000189882C50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182F5ECA0-0x0000000182F5EF80
	[BlackList] // 0x000000018988A430-0x000000018988A470
	// [XID] // 0x000000018988A430-0x000000018988A470
	public static ConfigMusicStimulusHandler ParseFromJson(JSONNode node) => default; // 0x0000000182F60620-0x0000000182F60820
	// [XID] // 0x00000001898949B0-0x00000001898949D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAACE */, bool useObjectPool = false /* Metadata: 0x00AFAAD2 */) => default; // 0x0000000182F60240-0x0000000182F60540
	// [XID] // 0x000000018989BE80-0x000000018989BEA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAD3 */, bool useObjectPool = false /* Metadata: 0x00AFAAD7 */) => default; // 0x0000000182F5F6F0-0x0000000182F5F9C0
	// [XID] // 0x00000001898A3500-0x00000001898A3520
	public static ConfigMusicStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAD8 */, bool useObjectPool = false /* Metadata: 0x00AFAADC */) => default; // 0x0000000182F5FD40-0x0000000182F5FF10
	[BlackList] // 0x00000001898AA8A0-0x00000001898AA8E0
	// [XID] // 0x00000001898AA8A0-0x00000001898AA8E0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F5F030-0x0000000182F5F300
	// [XID] // 0x00000001898B5210-0x00000001898B5230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F609D0-0x0000000182F60C30
	[BlackList] // 0x00000001898BCD00-0x00000001898BCD40
	// [XID] // 0x00000001898BCD00-0x00000001898BCD40
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F60150-0x0000000182F60240
	// [XID] // 0x00000001898C74A0-0x00000001898C74C0
	public void BuildGameParamMask(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x0000000182F608F0-0x0000000182F609D0
	// [XID] // 0x00000001898CEA70-0x00000001898CEA90
	public virtual bool Match(MusicStimulus stimulus, IStimulusParameter parameter) => default; // 0x0000000182F5FF10-0x0000000182F5FFE0
	[BlackList] // 0x00000001898D63A0-0x00000001898D63E0
	// [XID] // 0x00000001898D63A0-0x00000001898D63E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182F5F300-0x0000000182F5F3A0
	[BlackList] // 0x00000001898E10A0-0x00000001898E10E0
	// [XID] // 0x00000001898E10A0-0x00000001898E10E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182F5F3A0-0x0000000182F5F4D0
	[BlackList] // 0x00000001898EBAB0-0x00000001898EBAF0
	// [XID] // 0x00000001898EBAB0-0x00000001898EBAF0
	public virtual void ReturnToObjectPool() {} // 0x0000000182F60E90-0x0000000182F60F30
	[BlackList] // 0x00000001898F63E0-0x00000001898F6420
	// [XID] // 0x00000001898F63E0-0x00000001898F6420
	public virtual void OnPoolAllocated() {} // 0x0000000182F60DF0-0x0000000182F60E90
	[BlackList] // 0x0000000189900D50-0x0000000189900D90
	// [XID] // 0x0000000189900D50-0x0000000189900D90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182F60D50-0x0000000182F60DF0
}

