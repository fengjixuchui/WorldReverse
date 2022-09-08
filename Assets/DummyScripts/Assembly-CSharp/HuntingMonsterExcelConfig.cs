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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class HuntingMonsterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15755
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected SimpleSafeUInt32 monsterIdRawNum; // 0x14
	protected SimpleSafeUInt32 associatedMonsterGroupIdRawNum; // 0x18
	protected HuntingMonsterFinishType _huntingFinishType; // 0x1C
	protected SimpleSafeUInt32[] _affix; // 0x20
	protected string _abilityGroup; // 0x28
	protected HuntingMonsterCreatePosType _createPosType; // 0x30
	protected SimpleSafeUInt32 levelRawNum; // 0x34
	protected SimpleSafeUInt32 reviseLevelIdRawNum; // 0x38
	protected SimpleSafeUInt32[] _cityList; // 0x40
	protected HuntingOfferDifficultyType _difficulty; // 0x48
	protected SimpleSafeUInt32 limitTimeRawNum; // 0x4C
	protected SimpleSafeUInt32 searchPointNumRawNum; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected HuntingRefreshCond[] _refreshCond; // 0x58
	protected SimpleSafeUInt32 initialPoseRawNum; // 0x60
	protected SimpleSafeUInt32[] _clueTextIdList; // 0x68
	protected uint _newsTextTextMapHash; // 0x70
	protected uint _traitTextTextMapHash; // 0x74

	// Properties
	public uint configId { /* [XID] */ /* 0x00000001897AF5F0-0x00000001897AF610 */ get => default; /* [XID] */ /* 0x00000001897B74F0-0x00000001897B7510 */ protected set {} } // 0x0000000184B014A0-0x0000000184B01570 0x0000000184B02B70-0x0000000184B02C50
	public uint monsterId { /* [XID] */ /* 0x00000001897BF3B0-0x00000001897BF3D0 */ get => default; /* [XID] */ /* 0x00000001897C6A20-0x00000001897C6A40 */ protected set {} } // 0x0000000184B01570-0x0000000184B01640 0x0000000184B01110-0x0000000184B011F0
	public uint associatedMonsterGroupId { /* [XID] */ /* 0x00000001897CE220-0x00000001897CE240 */ get => default; /* [XID] */ /* 0x00000001897D5730-0x00000001897D5750 */ protected set {} } // 0x0000000184AFE650-0x0000000184AFE720 0x0000000184AFE4D0-0x0000000184AFE5B0
	public HuntingMonsterFinishType huntingFinishType { /* [XID] */ /* 0x00000001897DCE50-0x00000001897DCE70 */ get => default; /* [XID] */ /* 0x00000001897E4790-0x00000001897E47B0 */ protected set {} } // 0x0000000184AFE950-0x0000000184AFE9F0 0x0000000184AFE1F0-0x0000000184AFE2A0
	public SimpleSafeUInt32[] affix { /* [XID] */ /* 0x00000001897EC340-0x00000001897EC360 */ get => default; /* [XID] */ /* 0x00000001897F3CF0-0x00000001897F3D10 */ protected set {} } // 0x0000000184B01400-0x0000000184B014A0 0x0000000184B02E70-0x0000000184B02F20
	public string abilityGroup { /* [XID] */ /* 0x00000001897FB710-0x00000001897FB730 */ get => default; /* [XID] */ /* 0x0000000189802B20-0x0000000189802B40 */ protected set {} } // 0x0000000184AFE720-0x0000000184AFE7C0 0x0000000184AFE7C0-0x0000000184AFE870
	public HuntingMonsterCreatePosType createPosType { /* [XID] */ /* 0x000000018980A150-0x000000018980A170 */ get => default; /* [XID] */ /* 0x0000000189811780-0x00000001898117A0 */ protected set {} } // 0x0000000184AFE5B0-0x0000000184AFE650 0x0000000184B03070-0x0000000184B03120
	public uint level { /* [XID] */ /* 0x00000001898193F0-0x0000000189819410 */ get => default; /* [XID] */ /* 0x0000000189820BD0-0x0000000189820BF0 */ protected set {} } // 0x0000000184B027A0-0x0000000184B02870 0x0000000184B026C0-0x0000000184B027A0
	public uint reviseLevelId { /* [XID] */ /* 0x00000001898281A0-0x00000001898281C0 */ get => default; /* [XID] */ /* 0x000000018982F460-0x000000018982F480 */ protected set {} } // 0x0000000184AFE9F0-0x0000000184AFEAC0 0x0000000184B02D90-0x0000000184B02E70
	public SimpleSafeUInt32[] cityList { /* [XID] */ /* 0x0000000189836D10-0x0000000189836D30 */ get => default; /* [XID] */ /* 0x000000018983E180-0x000000018983E1A0 */ protected set {} } // 0x0000000184B01360-0x0000000184B01400 0x0000000184B016F0-0x0000000184B017A0
	public HuntingOfferDifficultyType difficulty { /* [XID] */ /* 0x0000000189845910-0x0000000189845930 */ get => default; /* [XID] */ /* 0x000000018984CF00-0x000000018984CF20 */ protected set {} } // 0x0000000184B02620-0x0000000184B026C0 0x0000000184B02FC0-0x0000000184B03070
	public uint limitTime { /* [XID] */ /* 0x0000000189853FE0-0x0000000189854000 */ get => default; /* [XID] */ /* 0x000000018985B9F0-0x000000018985BA10 */ protected set {} } // 0x0000000184B01040-0x0000000184B01110 0x0000000184AFE870-0x0000000184AFE950
	public uint searchPointNum { /* [XID] */ /* 0x0000000189862FD0-0x0000000189862FF0 */ get => default; /* [XID] */ /* 0x000000018986A440-0x000000018986A460 */ protected set {} } // 0x0000000184B029F0-0x0000000184B02AC0 0x0000000184B00F60-0x0000000184B01040
	public HuntingRefreshCond[] refreshCond { /* [XID] */ /* 0x0000000189871890-0x00000001898718B0 */ get => default; /* [XID] */ /* 0x0000000189879150-0x0000000189879170 */ protected set {} } // 0x0000000184AFEAC0-0x0000000184AFEB60 0x0000000184AFE060-0x0000000184AFE110
	public uint initialPose { /* [XID] */ /* 0x0000000189880700-0x0000000189880720 */ get => default; /* [XID] */ /* 0x0000000189887CA0-0x0000000189887CC0 */ protected set {} } // 0x0000000184B011F0-0x0000000184B012C0 0x0000000184AFE110-0x0000000184AFE1F0
	public SimpleSafeUInt32[] clueTextIdList { /* [XID] */ /* 0x000000018988F020-0x000000018988F040 */ get => default; /* [XID] */ /* 0x0000000189896520-0x0000000189896540 */ protected set {} } // 0x0000000184B02F20-0x0000000184B02FC0 0x0000000184B02AC0-0x0000000184B02B70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint newsTextTextMapHash { /* [XID] */ /* 0x000000018989DB20-0x000000018989DB40 */ get => default; /* [XID] */ /* 0x00000001898A5420-0x00000001898A5440 */ protected set {} } // 0x0000000184B00D40-0x0000000184B00DE0 0x0000000184B01640-0x0000000184B016F0
	public string newsText { /* [XID] */ /* 0x00000001898AC9E0-0x00000001898ACA00 */ get => default; } // 0x0000000184B02870-0x0000000184B029F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint traitTextTextMapHash { /* [XID] */ /* 0x00000001898B3EA0-0x00000001898B3EC0 */ get => default; /* [XID] */ /* 0x00000001898BBB50-0x00000001898BBB70 */ protected set {} } // 0x0000000184B012C0-0x0000000184B01360 0x0000000184B017A0-0x0000000184B01850
	public string traitText { /* [XID] */ /* 0x00000001898C3080-0x00000001898C30A0 */ get => default; } // 0x0000000184B00DE0-0x0000000184B00F60 

	// Constructors
	public HuntingMonsterExcelConfig() {} // 0x0000000184B031C0-0x0000000184B03220

	// Methods
	// [IDTag] // 0x00000001898CAA20-0x00000001898CAA60
	// [XID] // 0x00000001898CAA20-0x00000001898CAA60
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184AFFBD0-0x0000000184B00D40
	// [IDTag] // 0x00000001898D5250-0x00000001898D5290
	// [XID] // 0x00000001898D5250-0x00000001898D5290
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184AFEB60-0x0000000184AFFBD0
	// [XID] // 0x00000001898DFF40-0x00000001898DFF60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2526 */, bool useObjectPool = false /* Metadata: 0x00AF252A */) => default; // 0x0000000184B01850-0x0000000184B02620
	[BlackList] // 0x00000001898E79F0-0x00000001898E7A30
	// [XID] // 0x00000001898E79F0-0x00000001898E7A30
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AFE2A0-0x0000000184AFE340
	[BlackList] // 0x00000001898F20F0-0x00000001898F2130
	// [XID] // 0x00000001898F20F0-0x00000001898F2130
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AFE340-0x0000000184AFE4D0
	[BlackList] // 0x00000001898FC790-0x00000001898FC7D0
	// [XID] // 0x00000001898FC790-0x00000001898FC7D0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B03120-0x0000000184B031C0
	[BlackList] // 0x0000000189907150-0x0000000189907190
	// [XID] // 0x0000000189907150-0x0000000189907190
	public virtual void OnPoolAllocated() {} // 0x0000000184B02CF0-0x0000000184B02D90
	[BlackList] // 0x00000001899118C0-0x0000000189911900
	// [XID] // 0x00000001899118C0-0x0000000189911900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B02C50-0x0000000184B02CF0
}

