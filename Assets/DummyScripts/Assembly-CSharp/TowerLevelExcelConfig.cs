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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TowerLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16199
{
	// Fields
	protected SimpleSafeUInt32 levelIdRawNum; // 0x10
	protected SimpleSafeUInt32 levelGroupIdRawNum; // 0x14
	protected SimpleSafeUInt32 levelIndexRawNum; // 0x18
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected TowerCondition[] _conds; // 0x20
	protected string[] _towerBuffConfigStrList; // 0x28
	protected SimpleSafeUInt32 dailyRewardIdRawNum; // 0x30
	protected SimpleSafeUInt32 firstPassRewardIdRawNum; // 0x34
	protected SimpleSafeUInt32 monsterLevelRawNum; // 0x38
	protected SimpleSafeUInt32[] _firstMonsterList; // 0x40
	protected SimpleSafeUInt32[] _secondMonsterList; // 0x48

	// Properties
	public uint levelId { /* [XID] */ /* 0x000000018965CAE0-0x000000018965CB00 */ get => default; /* [XID] */ /* 0x0000000189663FA0-0x0000000189663FC0 */ protected set {} } // 0x0000000182D18260-0x0000000182D18330 0x0000000182D1A300-0x0000000182D1A3E0
	public uint levelGroupId { /* [XID] */ /* 0x000000018966B680-0x000000018966B6A0 */ get => default; /* [XID] */ /* 0x0000000189673440-0x0000000189673460 */ protected set {} } // 0x0000000182D1B4B0-0x0000000182D1B580 0x0000000182D1A0A0-0x0000000182D1A180
	public uint levelIndex { /* [XID] */ /* 0x000000018967AC40-0x000000018967AC60 */ get => default; /* [XID] */ /* 0x0000000189682590-0x00000001896825B0 */ protected set {} } // 0x0000000182D1AFD0-0x0000000182D1B0A0 0x0000000182D1B140-0x0000000182D1B220
	public uint dungeonId { /* [XID] */ /* 0x0000000189689F50-0x0000000189689F70 */ get => default; /* [XID] */ /* 0x0000000189691CF0-0x0000000189691D10 */ protected set {} } // 0x0000000182D1B300-0x0000000182D1B3D0 0x0000000182D1B790-0x0000000182D1B870
	public TowerCondition[] conds { /* [XID] */ /* 0x0000000189699220-0x0000000189699240 */ get => default; /* [XID] */ /* 0x00000001896A0750-0x00000001896A0770 */ protected set {} } // 0x0000000182D1B0A0-0x0000000182D1B140 0x0000000182D1A250-0x0000000182D1A300
	public string[] towerBuffConfigStrList { /* [XID] */ /* 0x00000001896A7C80-0x00000001896A7CA0 */ get => default; /* [XID] */ /* 0x00000001896AF090-0x00000001896AF0B0 */ protected set {} } // 0x0000000182D1A490-0x0000000182D1A530 0x0000000182D185E0-0x0000000182D18690
	public uint dailyRewardId { /* [XID] */ /* 0x00000001896B6620-0x00000001896B6640 */ get => default; /* [XID] */ /* 0x00000001896BD920-0x00000001896BD940 */ protected set {} } // 0x0000000182D1A5D0-0x0000000182D1A6A0 0x0000000182D1B220-0x0000000182D1B300
	public uint firstPassRewardId { /* [XID] */ /* 0x00000001896C50F0-0x00000001896C5110 */ get => default; /* [XID] */ /* 0x00000001896CC6F0-0x00000001896CC710 */ protected set {} } // 0x0000000182D1A180-0x0000000182D1A250 0x0000000182D18690-0x0000000182D18770
	public uint monsterLevel { /* [XID] */ /* 0x00000001896D39A0-0x00000001896D39C0 */ get => default; /* [XID] */ /* 0x00000001896DB440-0x00000001896DB460 */ protected set {} } // 0x0000000182D1B580-0x0000000182D1B650 0x0000000182D1B3D0-0x0000000182D1B4B0
	public SimpleSafeUInt32[] firstMonsterList { /* [XID] */ /* 0x00000001896E2B60-0x00000001896E2B80 */ get => default; /* [XID] */ /* 0x00000001896EA120-0x00000001896EA140 */ protected set {} } // 0x0000000182D1A530-0x0000000182D1A5D0 0x0000000182D18330-0x0000000182D183E0
	public SimpleSafeUInt32[] secondMonsterList { /* [XID] */ /* 0x00000001896F11A0-0x00000001896F11C0 */ get => default; /* [XID] */ /* 0x00000001896F8A60-0x00000001896F8A80 */ protected set {} } // 0x0000000182D1A000-0x0000000182D1A0A0 0x0000000182D1A3E0-0x0000000182D1A490

	// Constructors
	public TowerLevelExcelConfig() {} // 0x0000000182D1B910-0x0000000182D1B970

	// Methods
	// [IDTag] // 0x0000000189700260-0x00000001897002A0
	// [XID] // 0x0000000189700260-0x00000001897002A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D19350-0x0000000182D1A000
	// [IDTag] // 0x000000018970AB60-0x000000018970ABA0
	// [XID] // 0x000000018970AB60-0x000000018970ABA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D18770-0x0000000182D19350
	// [XID] // 0x0000000189714FF0-0x0000000189715010
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33F2 */, bool useObjectPool = false /* Metadata: 0x00AF33F6 */) => default; // 0x0000000182D1A6A0-0x0000000182D1AFD0
	[BlackList] // 0x000000018971CAE0-0x000000018971CB20
	// [XID] // 0x000000018971CAE0-0x000000018971CB20
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D183E0-0x0000000182D18480
	[BlackList] // 0x0000000189727180-0x00000001897271C0
	// [XID] // 0x0000000189727180-0x00000001897271C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D18480-0x0000000182D185E0
	[BlackList] // 0x00000001897315C0-0x0000000189731600
	// [XID] // 0x00000001897315C0-0x0000000189731600
	public virtual void ReturnToObjectPool() {} // 0x0000000182D1B870-0x0000000182D1B910
	[BlackList] // 0x000000018973BEE0-0x000000018973BF20
	// [XID] // 0x000000018973BEE0-0x000000018973BF20
	public virtual void OnPoolAllocated() {} // 0x0000000182D1B6F0-0x0000000182D1B790
	[BlackList] // 0x0000000189746760-0x00000001897467A0
	// [XID] // 0x0000000189746760-0x00000001897467A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D1B650-0x0000000182D1B6F0
}

