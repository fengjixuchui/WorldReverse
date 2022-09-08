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
public class ConfigMusic : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18772
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _switchGroup; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _playEvent; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stopEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pauseEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _resumeEvent; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _duckEvent; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _unduckEvent; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _startTransitions; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicSyncTransitions _syncTransitions; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTimeTransitions _timeTransitions; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicStimulusHandler[] _stimulusHandlers; // 0x60

	// Properties
	public ConfigWwiseString switchGroup { /* [XID] */ /* 0x00000001896B0210-0x00000001896B0230 */ get => default; /* [XID] */ /* 0x00000001896B7A70-0x00000001896B7A90 */ private set {} } // 0x00000001851C8C00-0x00000001851C8CA0 0x00000001851C9D00-0x00000001851C9DB0
	public ConfigWwiseString playEvent { /* [XID] */ /* 0x0000000189AF9AA0-0x0000000189AF9AC0 */ get => default; /* [XID] */ /* 0x00000001896C6490-0x00000001896C64B0 */ private set {} } // 0x00000001851C9660-0x00000001851C9700 0x00000001851C8CA0-0x00000001851C8D50
	public ConfigWwiseString stopEvent { /* [XID] */ /* 0x00000001896CDAB0-0x00000001896CDAD0 */ get => default; /* [XID] */ /* 0x00000001896D5020-0x00000001896D5040 */ private set {} } // 0x00000001851C9B50-0x00000001851C9BF0 0x00000001851C7F70-0x00000001851C8020
	public ConfigWwiseString pauseEvent { /* [XID] */ /* 0x000000018967FE70-0x000000018967FE90 */ get => default; /* [XID] */ /* 0x00000001896E3F10-0x00000001896E3F30 */ private set {} } // 0x00000001851C9AB0-0x00000001851C9B50 0x00000001851C9700-0x00000001851C97B0
	public ConfigWwiseString resumeEvent { /* [XID] */ /* 0x000000018968F360-0x000000018968F380 */ get => default; /* [XID] */ /* 0x00000001896F2630-0x00000001896F2650 */ private set {} } // 0x00000001851CAAE0-0x00000001851CAB80 0x00000001851C8B50-0x00000001851C8C00
	public ConfigWwiseString duckEvent { /* [XID] */ /* 0x00000001896F9FD0-0x00000001896F9FF0 */ get => default; /* [XID] */ /* 0x0000000189701780-0x00000001897017A0 */ private set {} } // 0x00000001851C6780-0x00000001851C6820 0x00000001851C9180-0x00000001851C9230
	public ConfigWwiseString unduckEvent { /* [XID] */ /* 0x0000000189708F40-0x0000000189708F60 */ get => default; /* [XID] */ /* 0x0000000189710850-0x0000000189710870 */ private set {} } // 0x00000001851C7E30-0x00000001851C7ED0 0x00000001851C8D50-0x00000001851C8E00
	public ConfigMusicTransitions startTransitions { /* [XID] */ /* 0x0000000189717C10-0x0000000189717C30 */ get => default; /* [XID] */ /* 0x000000018971F6B0-0x000000018971F6D0 */ private set {} } // 0x00000001851C76F0-0x00000001851C7790 0x00000001851C7370-0x00000001851C7420
	public ConfigMusicSyncTransitions syncTransitions { /* [XID] */ /* 0x00000001897411E0-0x0000000189741200 */ get => default; /* [XID] */ /* 0x000000018972E1D0-0x000000018972E1F0 */ private set {} } // 0x00000001851C7ED0-0x00000001851C7F70 0x00000001851CA630-0x00000001851CA6E0
	public ConfigMusicTimeTransitions timeTransitions { /* [XID] */ /* 0x0000000189B142D0-0x0000000189B142F0 */ get => default; /* [XID] */ /* 0x000000018973D430-0x000000018973D450 */ private set {} } // 0x00000001851C8020-0x00000001851C80C0 0x00000001851C9C50-0x00000001851C9D00
	public ConfigMusicStimulusHandler[] stimulusHandlers { /* [XID] */ /* 0x00000001897448F0-0x0000000189744910 */ get => default; /* [XID] */ /* 0x000000018974C640-0x000000018974C660 */ private set {} } // 0x00000001851C7D90-0x00000001851C7E30 0x00000001851CAB80-0x00000001851CAC30
	public MusicStimulus stimulusMask { /* [XID] */ /* 0x0000000189795100-0x0000000189795140 */ get; /* [XID] */ /* 0x00000001897A01B0-0x00000001897A01F0 */ private set; } // 0x00000001851C9230-0x00000001851C9290 0x00000001851C9BF0-0x00000001851C9C50

	// Constructors
	public ConfigMusic() {} // 0x00000001851CACD0-0x00000001851CAD30

	// Methods
	// [XID] // 0x0000000189753900-0x0000000189753920
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851CA6E0-0x00000001851CA9A0
	// [XID] // 0x000000018975AE20-0x000000018975AE40
	public void InitEmpty() {} // 0x00000001851C94D0-0x00000001851C9660
	[BlackList] // 0x0000000189762870-0x00000001897628B0
	// [XID] // 0x0000000189762870-0x00000001897628B0
	public bool FromJson(JSONNode node) => default; // 0x00000001851C8E00-0x00000001851C9180
	// [XID] // 0x000000018976CEA0-0x000000018976CEC0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851C6820-0x00000001851C7370
	// [XID] // 0x0000000189774330-0x0000000189774350
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABAB */, bool useObjectPool = false /* Metadata: 0x00AFABAF */) => default; // 0x00000001851C97B0-0x00000001851C9AB0
	// [XID] // 0x000000018977BBA0-0x000000018977BBC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABB0 */, bool useObjectPool = false /* Metadata: 0x00AFABB4 */) => default; // 0x00000001851C80C0-0x00000001851C8B50
	[BlackList] // 0x0000000189783570-0x00000001897835B0
	// [XID] // 0x0000000189783570-0x00000001897835B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001851C7420-0x00000001851C76F0
	// [XID] // 0x000000018978DB70-0x000000018978DB90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851C9DB0-0x00000001851CA630
	// [XID] // 0x00000001897AA5C0-0x00000001897AA5E0
	public void BuildMasks(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x00000001851C9290-0x00000001851C94D0
	[BlackList] // 0x00000001897B2050-0x00000001897B2090
	// [XID] // 0x00000001897B2050-0x00000001897B2090
	public virtual void AutoAllocTypeFields() {} // 0x00000001851C7790-0x00000001851C7830
	[BlackList] // 0x00000001897BD4A0-0x00000001897BD4E0
	// [XID] // 0x00000001897BD4A0-0x00000001897BD4E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851C7830-0x00000001851C7D90
	[BlackList] // 0x00000001897C7E70-0x00000001897C7EB0
	// [XID] // 0x00000001897C7E70-0x00000001897C7EB0
	public virtual void ReturnToObjectPool() {} // 0x00000001851CAC30-0x00000001851CACD0
	[BlackList] // 0x00000001897D2110-0x00000001897D2150
	// [XID] // 0x00000001897D2110-0x00000001897D2150
	public virtual void OnPoolAllocated() {} // 0x00000001851CAA40-0x00000001851CAAE0
	[BlackList] // 0x00000001897DC8F0-0x00000001897DC930
	// [XID] // 0x00000001897DC8F0-0x00000001897DC930
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851CA9A0-0x00000001851CAA40
}

