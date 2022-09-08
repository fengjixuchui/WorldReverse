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
public class ConfigSong : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18771
{
	// Fields
	private SimpleSafeInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _switchValue; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicSyncTransitions _syncTransitions; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTimeTransitions _timeTransitions; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicStimulusHandler[] _stimulusHandlers; // 0x30
	private SimpleSafeInt32 ignoranceMaskRawNum; // 0x38

	// Properties
	public int id { /* [XID] */ /* 0x0000000189B53700-0x0000000189B53720 */ get => default; /* [XID] */ /* 0x0000000189B5AF30-0x0000000189B5AF50 */ private set {} } // 0x00000001839BF880-0x00000001839BF950 0x00000001839BE9F0-0x00000001839BEAD0
	public ConfigWwiseString switchValue { /* [XID] */ /* 0x0000000189A85700-0x0000000189A85720 */ get => default; /* [XID] */ /* 0x0000000189B6A030-0x0000000189B6A050 */ private set {} } // 0x00000001839BD940-0x00000001839BD9E0 0x00000001839BEDD0-0x00000001839BEE80
	public ConfigMusicSyncTransitions syncTransitions { /* [XID] */ /* 0x00000001896A53E0-0x00000001896A5400 */ get => default; /* [XID] */ /* 0x0000000189B78C40-0x0000000189B78C60 */ private set {} } // 0x00000001839BD8A0-0x00000001839BD940 0x00000001839BF4E0-0x00000001839BF590
	public ConfigMusicTimeTransitions timeTransitions { /* [XID] */ /* 0x000000018974D390-0x000000018974D3B0 */ get => default; /* [XID] */ /* 0x0000000189B87B60-0x0000000189B87B80 */ private set {} } // 0x00000001839BD9E0-0x00000001839BDA80 0x00000001839BEEE0-0x00000001839BEF90
	public ConfigMusicStimulusHandler[] stimulusHandlers { /* [XID] */ /* 0x0000000189B8ED50-0x0000000189B8ED70 */ get => default; /* [XID] */ /* 0x0000000189B96180-0x0000000189B961A0 */ private set {} } // 0x00000001839BD800-0x00000001839BD8A0 0x00000001839BF950-0x00000001839BFA00
	public int ignoranceMask { /* [XID] */ /* 0x0000000189B9D720-0x0000000189B9D740 */ get => default; /* [XID] */ /* 0x0000000189BA51B0-0x0000000189BA51D0 */ private set {} } // 0x00000001839BE4B0-0x00000001839BE580 0x00000001839BE050-0x00000001839BE130
	public MusicStimulus stimulusMask { /* [XID] */ /* 0x00000001895F3710-0x00000001895F3750 */ get; /* [XID] */ /* 0x00000001895FDDE0-0x00000001895FDE20 */ private set; } // 0x00000001839BE640-0x00000001839BE6A0 0x00000001839BEE80-0x00000001839BEEE0

	// Constructors
	public ConfigSong() {} // 0x00000001839BFAA0-0x00000001839BFB00

	// Methods
	// [XID] // 0x0000000189BAC290-0x0000000189BAC2B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839BF590-0x00000001839BF740
	// [XID] // 0x0000000189BB3B30-0x0000000189BB3B50
	public void InitEmpty() {} // 0x00000001839BE8A0-0x00000001839BE9F0
	[BlackList] // 0x0000000189BBB110-0x0000000189BBB150
	// [XID] // 0x0000000189BBB110-0x0000000189BBB150
	public bool FromJson(JSONNode node) => default; // 0x00000001839BE130-0x00000001839BE4B0
	// [XID] // 0x0000000189BC5CA0-0x0000000189BC5CC0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839BCB10-0x00000001839BD200
	// [XID] // 0x0000000189BCD720-0x0000000189BCD740
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABA1 */, bool useObjectPool = false /* Metadata: 0x00AFABA5 */) => default; // 0x00000001839BEAD0-0x00000001839BEDD0
	// [XID] // 0x0000000189BD4CD0-0x0000000189BD4CF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABA6 */, bool useObjectPool = false /* Metadata: 0x00AFABAA */) => default; // 0x00000001839BDA80-0x00000001839BE050
	[BlackList] // 0x0000000189BDC6E0-0x0000000189BDC720
	// [XID] // 0x0000000189BDC6E0-0x0000000189BDC720
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839BD200-0x00000001839BD4D0
	// [XID] // 0x00000001895EC210-0x00000001895EC230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839BEF90-0x00000001839BF4E0
	// [XID] // 0x0000000189B7C510-0x0000000189B7C530
	public bool HasIgnoranceFlag(MusicBehaviourIgnorance ignoranceflag) => default; // 0x00000001839BE580-0x00000001839BE640
	// [XID] // 0x0000000189610150-0x0000000189610170
	public void BuildMasks(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x00000001839BE6A0-0x00000001839BE8A0
	[BlackList] // 0x0000000189617410-0x0000000189617450
	// [XID] // 0x0000000189617410-0x0000000189617450
	public virtual void AutoAllocTypeFields() {} // 0x00000001839BD4D0-0x00000001839BD570
	[BlackList] // 0x0000000189621CA0-0x0000000189621CE0
	// [XID] // 0x0000000189621CA0-0x0000000189621CE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839BD570-0x00000001839BD800
	[BlackList] // 0x000000018962C3D0-0x000000018962C410
	// [XID] // 0x000000018962C3D0-0x000000018962C410
	public virtual void ReturnToObjectPool() {} // 0x00000001839BFA00-0x00000001839BFAA0
	[BlackList] // 0x0000000189637100-0x0000000189637140
	// [XID] // 0x0000000189637100-0x0000000189637140
	public virtual void OnPoolAllocated() {} // 0x00000001839BF7E0-0x00000001839BF880
	[BlackList] // 0x00000001896414A0-0x00000001896414E0
	// [XID] // 0x00000001896414A0-0x00000001896414E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839BF740-0x00000001839BF7E0
}

