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
public class ConfigMusicGame : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18776
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicGameKey[] _button_sequence; // 0x10
	private SimpleSafeInt32 instrumentRawNum; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _playMusicEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stopMusicEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pauseMusicEvent; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _resumeMusicEvent; // 0x38
	private bool _autoPlay; // 0x40

	// Properties
	public ConfigMusicGameKey[] button_sequence { /* [XID] */ /* 0x00000001898CBA30-0x00000001898CBA50 */ get => default; /* [XID] */ /* 0x00000001898D3210-0x00000001898D3230 */ private set {} } // 0x000000018454E870-0x000000018454E910 0x000000018454DE30-0x000000018454DEE0
	public int instrument { /* [XID] */ /* 0x00000001898DAB00-0x00000001898DAB20 */ get => default; /* [XID] */ /* 0x00000001898E29E0-0x00000001898E2A00 */ private set {} } // 0x000000018454E5A0-0x000000018454E670 0x000000018454ECB0-0x000000018454ED90
	public ConfigWwiseString playMusicEvent { /* [XID] */ /* 0x00000001898EA450-0x00000001898EA470 */ get => default; /* [XID] */ /* 0x00000001898F1C10-0x00000001898F1C30 */ private set {} } // 0x000000018454EE40-0x000000018454EEE0 0x000000018454E300-0x000000018454E3B0
	public ConfigWwiseString stopMusicEvent { /* [XID] */ /* 0x00000001898F9390-0x00000001898F93B0 */ get => default; /* [XID] */ /* 0x0000000189900CF0-0x0000000189900D10 */ private set {} } // 0x000000018454DEE0-0x000000018454DF80 0x000000018454E3B0-0x000000018454E460
	public ConfigWwiseString pauseMusicEvent { /* [XID] */ /* 0x00000001899084B0-0x00000001899084D0 */ get => default; /* [XID] */ /* 0x000000018990FBF0-0x000000018990FC10 */ private set {} } // 0x000000018454EC10-0x000000018454ECB0 0x000000018454D700-0x000000018454D7B0
	public ConfigWwiseString resumeMusicEvent { /* [XID] */ /* 0x00000001899176C0-0x00000001899176E0 */ get => default; /* [XID] */ /* 0x000000018991ED00-0x000000018991ED20 */ private set {} } // 0x000000018454E460-0x000000018454E500 0x000000018454E7C0-0x000000018454E870
	public bool autoPlay { /* [XID] */ /* 0x0000000189926640-0x0000000189926660 */ get => default; /* [XID] */ /* 0x000000018992DD30-0x000000018992DD50 */ private set {} } // 0x000000018454E500-0x000000018454E5A0 0x000000018454ED90-0x000000018454EE40

	// Constructors
	public ConfigMusicGame() {} // 0x000000018454F860-0x000000018454F8C0

	// Methods
	// [XID] // 0x00000001899350D0-0x00000001899350F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018454F4A0-0x000000018454F680
	// [XID] // 0x000000018993CC90-0x000000018993CCB0
	public void InitEmpty() {} // 0x000000018454E670-0x000000018454E7C0
	[BlackList] // 0x00000001899442A0-0x00000001899442E0
	// [XID] // 0x00000001899442A0-0x00000001899442E0
	public bool FromJson(JSONNode node) => default; // 0x000000018454DF80-0x000000018454E300
	// [XID] // 0x000000018994E840-0x000000018994E860
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018454C950-0x000000018454D0E0
	// [XID] // 0x0000000189955EA0-0x0000000189955EC0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABDF */, bool useObjectPool = false /* Metadata: 0x00AFABE3 */) => default; // 0x000000018454E910-0x000000018454EC10
	// [XID] // 0x000000018995D9D0-0x000000018995D9F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABE4 */, bool useObjectPool = false /* Metadata: 0x00AFABE8 */) => default; // 0x000000018454D7B0-0x000000018454DE30
	[BlackList] // 0x0000000189965170-0x00000001899651B0
	// [XID] // 0x0000000189965170-0x00000001899651B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018454D0E0-0x000000018454D3B0
	// [XID] // 0x000000018996F3E0-0x000000018996F400
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018454EEE0-0x000000018454F4A0
	[BlackList] // 0x0000000189977060-0x00000001899770A0
	// [XID] // 0x0000000189977060-0x00000001899770A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018454D3B0-0x000000018454D450
	[BlackList] // 0x0000000189981A00-0x0000000189981A40
	// [XID] // 0x0000000189981A00-0x0000000189981A40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018454D450-0x000000018454D700
	[BlackList] // 0x000000018998C210-0x000000018998C250
	// [XID] // 0x000000018998C210-0x000000018998C250
	public virtual void ReturnToObjectPool() {} // 0x000000018454F7C0-0x000000018454F860
	[BlackList] // 0x0000000189996C80-0x0000000189996CC0
	// [XID] // 0x0000000189996C80-0x0000000189996CC0
	public virtual void OnPoolAllocated() {} // 0x000000018454F720-0x000000018454F7C0
	[BlackList] // 0x00000001899A1770-0x00000001899A17B0
	// [XID] // 0x00000001899A1770-0x00000001899A17B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018454F680-0x000000018454F720
}

