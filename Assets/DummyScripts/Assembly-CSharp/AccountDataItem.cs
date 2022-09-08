/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AccountDataItem : DataItem // TypeDefIndex: 21444
{
	// Fields
	public uint accountType; // 0x38
	public uint channelID; // 0x3C
	public bool isGuest; // 0x40
	public string accountUid; // 0x48
	public string accountToken; // 0x50
	public uint userId; // 0x58
	public uint regionId; // 0x5C
	public string deviceUUID; // 0x60
	public string onlineID; // 0x68
	public string psnID; // 0x70
	public uint nameCardID; // 0x78
	public string token; // 0x80
	public string nickName; // 0x88
	public ulong chooseAvatarGuid; // 0x90
	public ulong lastChangeAvatarTime; // 0x98
	public uint level; // 0xA0
	public uint exp; // 0xA4
	public uint maxExp; // 0xA8
	public uint fullCost; // 0xAC
	public bool isFirstLogin; // 0xB0
	public bool isFirstShare; // 0xB1
	public uint cookGrade; // 0xB4
	public Dictionary<uint, CookRecipeData> cookRecipeDic; // 0xB8
	public List<uint> compoundList; // 0xC0
	public Dictionary<uint, CompoundItemData> compoundItemDic; // 0xC8
	public List<uint> rewardLevelList; // 0xD0
	public Dictionary<uint, int> newCombineDic; // 0xD8
	public Dictionary<uint, int> newForgeDic; // 0xE0
	public uint currForgePoint; // 0xE8
	public HashSet<uint> unlockedCombineSet; // 0xF0
	public HashSet<uint> unlockedForgetSet; // 0xF8
	public uint headPortraitID; // 0x100
	public string signature; // 0x108
	public BirthdayStruct birthday; // 0x110
	public bool isShowAvatar; // 0x118
	public List<uint> showAvatarIdList; // 0x120
	public List<uint> showNameCardIdList; // 0x128
	public List<uint> ownedFlyCloakList; // 0x130
	public uint curAvatarEntityID; // 0x138

	// Properties
	public float currSpringVolume { /* [XID] */ /* 0x00000001898C4110-0x00000001898C4130 */ get => default; } // 0x0000000183D8DD00-0x0000000183D8DDC0 
	public bool autoUseSpring { /* [XID] */ /* 0x00000001898CB7F0-0x00000001898CB810 */ get => default; } // 0x0000000183D8DC40-0x0000000183D8DD00 
	public bool canGetPlayerLevelReward { /* [XID] */ /* 0x0000000189A2E270-0x0000000189A2E290 */ get => default; } // 0x0000000183D8DB60-0x0000000183D8DC40 
	public uint currentResin { /* [XID] */ /* 0x00000001898DA880-0x00000001898DA8A0 */ get => default; } // 0x0000000183D8CCF0-0x0000000183D8CDA0 
	public uint worldLevel { /* [XID] */ /* 0x0000000189752E70-0x0000000189752E90 */ get => default; } // 0x0000000183D8DAB0-0x0000000183D8DB60 
	public uint worldLevelLimit { /* [XID] */ /* 0x00000001898EA190-0x00000001898EA1B0 */ get => default; } // 0x0000000183D8CC40-0x0000000183D8CCF0 
	public uint worldLevelAdjustCD { /* [XID] */ /* 0x00000001898F19D0-0x00000001898F19F0 */ get => default; } // 0x0000000183D8CB90-0x0000000183D8CC40 

	// Constructors
	public AccountDataItem() {} // 0x0000000183D8E000-0x0000000183D8E140

	// Methods
	// [XID] // 0x000000018989E880-0x000000018989E8A0
	public void Init() {} // 0x0000000183D8CE80-0x0000000183D8CFF0
	// [XID] // 0x00000001898A63C0-0x00000001898A63E0
	public void InitNewMarkDic() {} // 0x0000000183D8C840-0x0000000183D8CB90
	// [XID] // 0x00000001898ADA30-0x00000001898ADA50
	public void SetFakeStamina() {} // 0x0000000183D8DDC0-0x0000000183D8E000
	// [XID] // 0x00000001898B4EC0-0x00000001898B4EE0
	protected override void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7D9 */) {} // 0x0000000183D8CFF0-0x0000000183D8DAB0
	// [XID] // 0x00000001898BC9D0-0x00000001898BC9F0
	protected override void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7DD */) {} // 0x0000000183D8CDA0-0x0000000183D8CE80
}

