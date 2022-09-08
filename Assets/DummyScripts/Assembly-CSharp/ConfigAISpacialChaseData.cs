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
public class ConfigAISpacialChaseData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17463
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat chaseStartDistanceRawNum; // 0x14
	private SimpleSafeFloat chaseStopDistanceRawNum; // 0x18
	private SimpleSafeFloat yOffsetMinRawNum; // 0x1C
	private SimpleSafeFloat yOffsetMaxRawNum; // 0x20
	private SimpleSafeFloat segmentDistanceRawNum; // 0x24

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189B5B1B0-0x0000000189B5B1D0 */ get => default; /* [XID] */ /* 0x0000000189B62640-0x0000000189B62660 */ private set {} } // 0x0000000181C14750-0x0000000181C14820 0x0000000181C14820-0x0000000181C14900
	public float chaseStartDistance { /* [XID] */ /* 0x0000000189B6A250-0x0000000189B6A270 */ get => default; /* [XID] */ /* 0x0000000189B71910-0x0000000189B71930 */ private set {} } // 0x0000000181C151A0-0x0000000181C15280 0x0000000181C143A0-0x0000000181C14480
	public float chaseStopDistance { /* [XID] */ /* 0x0000000189B78D60-0x0000000189B78D80 */ get => default; /* [XID] */ /* 0x0000000189B80270-0x0000000189B80290 */ private set {} } // 0x0000000181C15A50-0x0000000181C15B30 0x0000000181C14D40-0x0000000181C14E20
	public float yOffsetMin { /* [XID] */ /* 0x0000000189B87D40-0x0000000189B87D60 */ get => default; /* [XID] */ /* 0x0000000189B8EF30-0x0000000189B8EF50 */ private set {} } // 0x0000000181C15890-0x0000000181C15970 0x0000000181C14670-0x0000000181C14750
	public float yOffsetMax { /* [XID] */ /* 0x0000000189B963E0-0x0000000189B96400 */ get => default; /* [XID] */ /* 0x0000000189B9D920-0x0000000189B9D940 */ private set {} } // 0x0000000181C15280-0x0000000181C15360 0x0000000181C15360-0x0000000181C15440
	public float segmentDistance { /* [XID] */ /* 0x0000000189BA53B0-0x0000000189BA53D0 */ get => default; /* [XID] */ /* 0x0000000189BAC4B0-0x0000000189BAC4D0 */ private set {} } // 0x0000000181C16280-0x0000000181C16360 0x0000000181C15970-0x0000000181C15A50

	// Constructors
	public ConfigAISpacialChaseData() {} // 0x0000000181C16400-0x0000000181C16520

	// Methods
	// [XID] // 0x0000000189BB3DF0-0x0000000189BB3E10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C15FD0-0x0000000181C16140
	// [XID] // 0x0000000189BBB3B0-0x0000000189BBB3D0
	public void InitEmpty() {} // 0x0000000181C15440-0x0000000181C15590
	[BlackList] // 0x0000000189BC31B0-0x0000000189BC31F0
	// [XID] // 0x0000000189BC31B0-0x0000000189BC31F0
	public bool FromJson(JSONNode node) => default; // 0x0000000181C14E20-0x0000000181C151A0
	// [XID] // 0x0000000189BCD960-0x0000000189BCD980
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C139E0-0x0000000181C140D0
	// [XID] // 0x0000000189BD4E30-0x0000000189BD4E50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F7B */, bool useObjectPool = false /* Metadata: 0x00AF6F7F */) => default; // 0x0000000181C15590-0x0000000181C15890
	// [XID] // 0x0000000189BDC9A0-0x0000000189BDC9C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F80 */, bool useObjectPool = false /* Metadata: 0x00AF6F84 */) => default; // 0x0000000181C14900-0x0000000181C14D40
	[BlackList] // 0x00000001895E9230-0x00000001895E9270
	// [XID] // 0x00000001895E9230-0x00000001895E9270
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C140D0-0x0000000181C143A0
	// [XID] // 0x00000001895F3950-0x00000001895F3970
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C15B30-0x0000000181C15FD0
	[BlackList] // 0x00000001895FB250-0x00000001895FB290
	// [XID] // 0x00000001895FB250-0x00000001895FB290
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C14480-0x0000000181C14520
	[BlackList] // 0x00000001896058F0-0x0000000189605930
	// [XID] // 0x00000001896058F0-0x0000000189605930
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C14520-0x0000000181C14670
	[BlackList] // 0x0000000189610430-0x0000000189610470
	// [XID] // 0x0000000189610430-0x0000000189610470
	public virtual void ReturnToObjectPool() {} // 0x0000000181C16360-0x0000000181C16400
	[BlackList] // 0x000000018961A940-0x000000018961A980
	// [XID] // 0x000000018961A940-0x000000018961A980
	public virtual void OnPoolAllocated() {} // 0x0000000181C161E0-0x0000000181C16280
	[BlackList] // 0x0000000189624D90-0x0000000189624DD0
	// [XID] // 0x0000000189624D90-0x0000000189624DD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C16140-0x0000000181C161E0
}

