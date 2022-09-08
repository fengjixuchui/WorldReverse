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
public class ConfigDefaultAbilities : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18103
{
	// Fields
	private string _monterEliteAbilityName; // 0x10
	private string[] _nonHumanoidMoveAbilities; // 0x18
	private string[] _levelDefaultAbilities; // 0x20
	private string[] _levelElementAbilities; // 0x28
	private string[] _levelItemAbilities; // 0x30
	private string[] _levelSBuffAbilities; // 0x38
	private string[] _dungeonAbilities; // 0x40
	private string[] _defaultTeamAbilities; // 0x48
	private string[] _defaultMPLevelAbilities; // 0x50
	private string[] _defaultAvatarAbilities; // 0x58

	// Properties
	public string monterEliteAbilityName { /* [XID] */ /* 0x000000018963ABF0-0x000000018963AC10 */ get => default; /* [XID] */ /* 0x0000000189B461E0-0x0000000189B46200 */ private set {} } // 0x0000000183C50630-0x0000000183C506D0 0x0000000183C4FF50-0x0000000183C50000
	public string[] nonHumanoidMoveAbilities { /* [XID] */ /* 0x0000000189B4D790-0x0000000189B4D7B0 */ get => default; /* [XID] */ /* 0x0000000189B54F90-0x0000000189B54FB0 */ private set {} } // 0x0000000183C50F40-0x0000000183C50FE0 0x0000000183C508B0-0x0000000183C50960
	public string[] levelDefaultAbilities { /* [XID] */ /* 0x0000000189B5C990-0x0000000189B5C9B0 */ get => default; /* [XID] */ /* 0x0000000189B64010-0x0000000189B64030 */ private set {} } // 0x0000000183C51130-0x0000000183C511D0 0x0000000183C500B0-0x0000000183C50160
	public string[] levelElementAbilities { /* [XID] */ /* 0x000000018965FFF0-0x0000000189660010 */ get => default; /* [XID] */ /* 0x0000000189B72DB0-0x0000000189B72DD0 */ private set {} } // 0x0000000183C506D0-0x0000000183C50770 0x0000000183C50E90-0x0000000183C50F40
	public string[] levelItemAbilities { /* [XID] */ /* 0x0000000189B7A350-0x0000000189B7A370 */ get => default; /* [XID] */ /* 0x0000000189B81B30-0x0000000189B81B50 */ private set {} } // 0x0000000183C4F540-0x0000000183C4F5E0 0x0000000183C50000-0x0000000183C500B0
	public string[] levelSBuffAbilities { /* [XID] */ /* 0x0000000189B891D0-0x0000000189B891F0 */ get => default; /* [XID] */ /* 0x0000000189B907B0-0x0000000189B907D0 */ private set {} } // 0x0000000183C50770-0x0000000183C50810 0x0000000183C4F690-0x0000000183C4F740
	public string[] dungeonAbilities { /* [XID] */ /* 0x0000000189B97C60-0x0000000189B97C80 */ get => default; /* [XID] */ /* 0x0000000189B9EF90-0x0000000189B9EFB0 */ private set {} } // 0x0000000183C4F4A0-0x0000000183C4F540 0x0000000183C504E0-0x0000000183C50590
	public string[] defaultTeamAbilities { /* [XID] */ /* 0x0000000189BA68E0-0x0000000189BA6900 */ get => default; /* [XID] */ /* 0x0000000189BADAA0-0x0000000189BADAC0 */ private set {} } // 0x0000000183C50FE0-0x0000000183C51080 0x0000000183C4F5E0-0x0000000183C4F690
	public string[] defaultMPLevelAbilities { /* [XID] */ /* 0x00000001899B1740-0x00000001899B1760 */ get => default; /* [XID] */ /* 0x0000000189BBCA30-0x0000000189BBCA50 */ private set {} } // 0x0000000183C50810-0x0000000183C508B0 0x0000000183C50960-0x0000000183C50A10
	public string[] defaultAvatarAbilities { /* [XID] */ /* 0x0000000189BC46A0-0x0000000189BC46C0 */ get => default; /* [XID] */ /* 0x0000000189BCC020-0x0000000189BCC040 */ private set {} } // 0x0000000183C50590-0x0000000183C50630 0x0000000183C51080-0x0000000183C51130

	// Constructors
	public ConfigDefaultAbilities() {} // 0x0000000183C51DC0-0x0000000183C51E20

	// Methods
	// [XID] // 0x0000000189BD35B0-0x0000000189BD35D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C51A00-0x0000000183C51BE0
	// [XID] // 0x0000000189BDAEA0-0x0000000189BDAEC0
	public void InitEmpty() {} // 0x0000000183C50A10-0x0000000183C50B90
	[BlackList] // 0x00000001895E7890-0x00000001895E78D0
	// [XID] // 0x00000001895E7890-0x00000001895E78D0
	public bool FromJson(JSONNode node) => default; // 0x0000000183C50160-0x0000000183C504E0
	// [XID] // 0x00000001895F2070-0x00000001895F2090
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183C4E6D0-0x0000000183C4F070
	// [XID] // 0x00000001895F9980-0x00000001895F99A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B1D */, bool useObjectPool = false /* Metadata: 0x00AF8B21 */) => default; // 0x0000000183C50B90-0x0000000183C50E90
	// [XID] // 0x0000000189601080-0x00000001896010A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B22 */, bool useObjectPool = false /* Metadata: 0x00AF8B26 */) => default; // 0x0000000183C4F740-0x0000000183C4FF50
	[BlackList] // 0x0000000189608A90-0x0000000189608AD0
	// [XID] // 0x0000000189608A90-0x0000000189608AD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C4F070-0x0000000183C4F340
	// [XID] // 0x0000000189613020-0x0000000189613040
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C511D0-0x0000000183C51A00
	[BlackList] // 0x000000018961A800-0x000000018961A840
	// [XID] // 0x000000018961A800-0x000000018961A840
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C4F340-0x0000000183C4F3E0
	[BlackList] // 0x0000000189624C70-0x0000000189624CB0
	// [XID] // 0x0000000189624C70-0x0000000189624CB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C4F3E0-0x0000000183C4F4A0
	[BlackList] // 0x000000018962F700-0x000000018962F740
	// [XID] // 0x000000018962F700-0x000000018962F740
	public virtual void ReturnToObjectPool() {} // 0x0000000183C51D20-0x0000000183C51DC0
	[BlackList] // 0x000000018963A0B0-0x000000018963A0F0
	// [XID] // 0x000000018963A0B0-0x000000018963A0F0
	public virtual void OnPoolAllocated() {} // 0x0000000183C51C80-0x0000000183C51D20
	[BlackList] // 0x00000001896446D0-0x0000000189644710
	// [XID] // 0x00000001896446D0-0x0000000189644710
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C51BE0-0x0000000183C51C80
}

