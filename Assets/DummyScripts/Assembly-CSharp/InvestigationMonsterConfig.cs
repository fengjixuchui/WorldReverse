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
public class InvestigationMonsterConfig : IAutoAllocRecycle // TypeDefIndex: 15772
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _monsterIdList; // 0x18
	protected SimpleSafeUInt32[] _groupIdList; // 0x20
	protected SimpleSafeUInt32 unlockParentQuestIdRawNum; // 0x28
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x2C
	protected InvestigationMonsterMapMarkCreateType _mapMarkCreateType; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected InvestigationMonsterMapMarkCreateCondition _mapMarkCreateCondition; // 0x38
	protected MonsterCategory _monsterCategory; // 0x40
	protected uint _nameTextMapHash; // 0x44
	protected string _icon; // 0x48
	protected uint _descTextMapHash; // 0x50
	protected uint _lockDescTextMapHash; // 0x54
	protected SimpleSafeUInt32[] _occupiedQuestIdList; // 0x58

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897DCE30-0x00000001897DCE50 */ get => default; /* [XID] */ /* 0x00000001897E4770-0x00000001897E4790 */ protected set {} } // 0x0000000184E631C0-0x0000000184E63290 0x0000000184E61C20-0x0000000184E61D00
	public uint cityId { /* [XID] */ /* 0x00000001897EC320-0x00000001897EC340 */ get => default; /* [XID] */ /* 0x00000001897F3CD0-0x00000001897F3CF0 */ protected set {} } // 0x0000000184E62F00-0x0000000184E62FD0 0x0000000184E616B0-0x0000000184E61790
	public SimpleSafeUInt32[] monsterIdList { /* [XID] */ /* 0x00000001897FB6F0-0x00000001897FB710 */ get => default; /* [XID] */ /* 0x0000000189802B00-0x0000000189802B20 */ protected set {} } // 0x0000000184E5F5A0-0x0000000184E5F640 0x0000000184E62FD0-0x0000000184E63080
	public SimpleSafeUInt32[] groupIdList { /* [XID] */ /* 0x000000018980A130-0x000000018980A150 */ get => default; /* [XID] */ /* 0x0000000189811760-0x0000000189811780 */ protected set {} } // 0x0000000184E62D10-0x0000000184E62DB0 0x0000000184E61F30-0x0000000184E61FE0
	public uint unlockParentQuestId { /* [XID] */ /* 0x00000001898193D0-0x00000001898193F0 */ get => default; /* [XID] */ /* 0x0000000189820BB0-0x0000000189820BD0 */ protected set {} } // 0x0000000184E61920-0x0000000184E619F0 0x0000000184E61D00-0x0000000184E61DE0
	public uint rewardPreviewId { /* [XID] */ /* 0x0000000189828180-0x00000001898281A0 */ get => default; /* [XID] */ /* 0x000000018982F440-0x000000018982F460 */ protected set {} } // 0x0000000184E615E0-0x0000000184E616B0 0x0000000184E61790-0x0000000184E61870
	public InvestigationMonsterMapMarkCreateType mapMarkCreateType { /* [XID] */ /* 0x0000000189836CF0-0x0000000189836D10 */ get => default; /* [XID] */ /* 0x000000018983E160-0x000000018983E180 */ protected set {} } // 0x0000000184E63290-0x0000000184E63330 0x0000000184E61E80-0x0000000184E61F30
	public InvestigationMonsterMapMarkCreateCondition mapMarkCreateCondition { /* [XID] */ /* 0x00000001898458F0-0x0000000189845910 */ get => default; /* [XID] */ /* 0x000000018984CEE0-0x000000018984CF00 */ protected set {} } // 0x0000000184E61DE0-0x0000000184E61E80 0x0000000184E61B70-0x0000000184E61C20
	public MonsterCategory monsterCategory { /* [XID] */ /* 0x0000000189853FC0-0x0000000189853FE0 */ get => default; /* [XID] */ /* 0x000000018985B9D0-0x000000018985B9F0 */ protected set {} } // 0x0000000184E5F640-0x0000000184E5F6E0 0x0000000184E62DB0-0x0000000184E62E60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189862FB0-0x0000000189862FD0 */ get => default; /* [XID] */ /* 0x000000018986A420-0x000000018986A440 */ protected set {} } // 0x0000000184E5F500-0x0000000184E5F5A0 0x0000000184E62BB0-0x0000000184E62C60
	public string name { /* [XID] */ /* 0x0000000189871870-0x0000000189871890 */ get => default; } // 0x0000000184E63330-0x0000000184E634B0 
	public string icon { /* [XID] */ /* 0x0000000189879130-0x0000000189879150 */ get => default; /* [XID] */ /* 0x00000001898806E0-0x0000000189880700 */ protected set {} } // 0x0000000184E5F290-0x0000000184E5F330 0x0000000184E62C60-0x0000000184E62D10
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189887C80-0x0000000189887CA0 */ get => default; /* [XID] */ /* 0x000000018988F000-0x000000018988F020 */ protected set {} } // 0x0000000184E62B10-0x0000000184E62BB0 0x0000000184E5F6E0-0x0000000184E5F790
	public string desc { /* [XID] */ /* 0x0000000189896500-0x0000000189896520 */ get => default; } // 0x0000000184E619F0-0x0000000184E61B70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint lockDescTextMapHash { /* [XID] */ /* 0x000000018989DB00-0x000000018989DB20 */ get => default; /* [XID] */ /* 0x00000001898A5400-0x00000001898A5420 */ protected set {} } // 0x0000000184E61540-0x0000000184E615E0 0x0000000184E5F790-0x0000000184E5F840
	public string lockDesc { /* [XID] */ /* 0x00000001898AC9C0-0x00000001898AC9E0 */ get => default; } // 0x0000000184E5F840-0x0000000184E5F9C0 
	public SimpleSafeUInt32[] occupiedQuestIdList { /* [XID] */ /* 0x00000001898B3E80-0x00000001898B3EA0 */ get => default; /* [XID] */ /* 0x00000001898BBB30-0x00000001898BBB50 */ protected set {} } // 0x0000000184E62E60-0x0000000184E62F00 0x0000000184E61870-0x0000000184E61920

	// Constructors
	public InvestigationMonsterConfig() {} // 0x0000000184E63550-0x0000000184E635B0

	// Methods
	// [IDTag] // 0x00000001898C3040-0x00000001898C3080
	// [XID] // 0x00000001898C3040-0x00000001898C3080
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184E5F9C0-0x0000000184E607F0
	// [IDTag] // 0x00000001898CD6E0-0x00000001898CD720
	// [XID] // 0x00000001898CD6E0-0x00000001898CD720
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184E607F0-0x0000000184E61540
	// [XID] // 0x00000001898D8080-0x00000001898D80A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2597 */, bool useObjectPool = false /* Metadata: 0x00AF259B */) => default; // 0x0000000184E61FE0-0x0000000184E62B10
	[BlackList] // 0x00000001898DFF00-0x00000001898DFF40
	// [XID] // 0x00000001898DFF00-0x00000001898DFF40
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E5F330-0x0000000184E5F3D0
	[BlackList] // 0x00000001898EA9B0-0x00000001898EA9F0
	// [XID] // 0x00000001898EA9B0-0x00000001898EA9F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E5F3D0-0x0000000184E5F500
	[BlackList] // 0x00000001898F5040-0x00000001898F5080
	// [XID] // 0x00000001898F5040-0x00000001898F5080
	public virtual void ReturnToObjectPool() {} // 0x0000000184E634B0-0x0000000184E63550
	[BlackList] // 0x00000001898FF910-0x00000001898FF950
	// [XID] // 0x00000001898FF910-0x00000001898FF950
	public virtual void OnPoolAllocated() {} // 0x0000000184E63120-0x0000000184E631C0
	[BlackList] // 0x0000000189909FA0-0x0000000189909FE0
	// [XID] // 0x0000000189909FA0-0x0000000189909FE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184E63080-0x0000000184E63120
}

