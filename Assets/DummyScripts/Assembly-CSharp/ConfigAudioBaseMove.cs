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
public class ConfigAudioBaseMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17560
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _moveRtpcKey; // 0x10
	private AudioPlatformMoveSettings[] _platformSettings; // 0x18
	private AudioPlatformMoveSettingsUsagePair[] _platformSettingUsageMapping; // 0x20
	private Dictionary<uint, uint> _platformMoveSettingsUsageIndex; // 0x28

	// Properties
	public ConfigWwiseString moveRtpcKey { /* [XID] */ /* 0x0000000189B91FA0-0x0000000189B91FC0 */ get => default; /* [XID] */ /* 0x0000000189B99420-0x0000000189B99440 */ private set {} } // 0x00000001831DB110-0x00000001831DB1B0 0x00000001831DB060-0x00000001831DB110
	public AudioPlatformMoveSettings[] platformSettings { /* [XID] */ /* 0x0000000189BA08F0-0x0000000189BA0910 */ get => default; /* [XID] */ /* 0x0000000189BA8030-0x0000000189BA8050 */ private set {} } // 0x00000001831DB350-0x00000001831DB3F0 0x00000001831DB7A0-0x00000001831DB850
	public AudioPlatformMoveSettingsUsagePair[] platformSettingUsageMapping { /* [XID] */ /* 0x0000000189BAF4E0-0x0000000189BAF500 */ get => default; /* [XID] */ /* 0x0000000189BB6B50-0x0000000189BB6B70 */ private set {} } // 0x00000001831DB2B0-0x00000001831DB350 0x00000001831DB6F0-0x00000001831DB7A0

	// Nested types
	private class PlatformMoveSettingsComparer : IComparer<AudioPlatformMoveSettings> // TypeDefIndex: 17561
	{
		// Constructors
		public PlatformMoveSettingsComparer() {} // 0x00000001831C49E0-0x00000001831C4A40

		// Methods
		// [XID] // 0x00000001896507F0-0x0000000189650810
		public int Compare(AudioPlatformMoveSettings x, AudioPlatformMoveSettings y) => default; // 0x00000001831C48B0-0x00000001831C49E0
	}

	// Constructors
	public ConfigAudioBaseMove() {} // 0x00000001831DC160-0x00000001831DC1C0

	// Methods
	// [XID] // 0x0000000189BBE1F0-0x0000000189BBE210
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831DBE40-0x00000001831DBF80
	// [XID] // 0x0000000189BC5EC0-0x0000000189BC5EE0
	public void InitEmpty() {} // 0x00000001831DB1B0-0x00000001831DB2B0
	[BlackList] // 0x0000000189BCD900-0x0000000189BCD940
	// [XID] // 0x0000000189BCD900-0x0000000189BCD940
	public bool FromJson(JSONNode node) => default; // 0x00000001831DACE0-0x00000001831DB060
	// [XID] // 0x0000000189BD7D70-0x0000000189BD7D90
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001831D9F50-0x00000001831DA310
	// [XID] // 0x0000000189BDF980-0x0000000189BDF9A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72F3 */, bool useObjectPool = false /* Metadata: 0x00AF72F7 */) => default; // 0x00000001831DB3F0-0x00000001831DB6F0
	// [XID] // 0x00000001895EC490-0x00000001895EC4B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72F8 */, bool useObjectPool = false /* Metadata: 0x00AF72FC */) => default; // 0x00000001831DA950-0x00000001831DACE0
	[BlackList] // 0x00000001895F38D0-0x00000001895F3910
	// [XID] // 0x00000001895F38D0-0x00000001895F3910
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001831DA310-0x00000001831DA5E0
	// [XID] // 0x00000001895FE0E0-0x00000001895FE100
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831DBAF0-0x00000001831DBE40
	// [XID] // 0x00000001896058D0-0x00000001896058F0
	public void SortPlatformSettingsById() {} // 0x00000001831D9E60-0x00000001831D9F50
	// [XID] // 0x000000018960D220-0x000000018960D240
	public void BuildPlatformSettingsUsageIndex() {} // 0x00000001831DA7B0-0x00000001831DA950
	// [XID] // 0x0000000189614920-0x0000000189614940
	public AudioPlatformMoveSettings GetMoveSettingsByPlatformGadgetId(uint gadgetId) => default; // 0x00000001831DB850-0x00000001831DBAF0
	[BlackList] // 0x000000018961C2A0-0x000000018961C2E0
	// [XID] // 0x000000018961C2A0-0x000000018961C2E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001831DA5E0-0x00000001831DA680
	[BlackList] // 0x0000000189626640-0x0000000189626680
	// [XID] // 0x0000000189626640-0x0000000189626680
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831DA680-0x00000001831DA7B0
	[BlackList] // 0x00000001896311C0-0x0000000189631200
	// [XID] // 0x00000001896311C0-0x0000000189631200
	public virtual void ReturnToObjectPool() {} // 0x00000001831DC0C0-0x00000001831DC160
	[BlackList] // 0x000000018963B9E0-0x000000018963BA20
	// [XID] // 0x000000018963B9E0-0x000000018963BA20
	public virtual void OnPoolAllocated() {} // 0x00000001831DC020-0x00000001831DC0C0
	[BlackList] // 0x0000000189645FE0-0x0000000189646020
	// [XID] // 0x0000000189645FE0-0x0000000189646020
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831DBF80-0x00000001831DC020
}

