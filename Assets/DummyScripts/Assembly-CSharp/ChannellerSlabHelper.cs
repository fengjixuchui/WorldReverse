/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ChannellerSlabHelper // TypeDefIndex: 30026
{
	// Fields
	private static Color BuffPurpleColor; // 0x00
	private static Color BuffBlueColor; // 0x10
	private static Color BuffGreenColor; // 0x20

	// Constructors
	static ChannellerSlabHelper() {} // 0x00000001849BC930-0x00000001849BCA20

	// Methods
	// [XID] // 0x00000001898EB460-0x00000001898EB480
	public static ChannelerSlabChallengeStage GetStageInfo(uint stageId) => default; // 0x00000001849BC6A0-0x00000001849BC930
	// [XID] // 0x00000001898F2B80-0x00000001898F2BA0
	public static uint GetStageBuffCount(uint stageId) => default; // 0x00000001849BA550-0x00000001849BA7A0
	// [IDTag] // 0x00000001898FA350-0x00000001898FA390
	// [XID] // 0x00000001898FA350-0x00000001898FA390
	public static ChannelerSlabChallenge GetChallenge(uint stageId, int waveIndex) => default; // 0x00000001849BB370-0x00000001849BB460
	// [IDTag] // 0x0000000189904D60-0x0000000189904DA0
	// [XID] // 0x0000000189904D60-0x0000000189904DA0
	public static ChannelerSlabChallenge GetChallenge(ChannelerSlabChallengeStage stageInfo, int waveIndex) => default; // 0x00000001849BB460-0x00000001849BB580
	// [IDTag] // 0x000000018990F610-0x000000018990F650
	// [XID] // 0x000000018990F610-0x000000018990F650
	public static ChannelerSlabCamp GetCamp(uint stageId, int waveIndex, int campIndex) => default; // 0x00000001849BC250-0x00000001849BC350
	// [IDTag] // 0x000000018991A080-0x000000018991A0C0
	// [XID] // 0x000000018991A080-0x000000018991A0C0
	public static ChannelerSlabCamp GetCamp(ChannelerSlabChallenge challenge, int campIndex) => default; // 0x00000001849BC130-0x00000001849BC250
	// [XID] // 0x0000000189924830-0x0000000189924850
	public static int GetActivedCampIndex(uint stageId, int waveIndex) => default; // 0x00000001849B85B0-0x00000001849B86A0
	// [XID] // 0x000000018992BDE0-0x000000018992BE00
	public static bool IsStageOpen(uint stageId) => default; // 0x00000001849BC050-0x00000001849BC130
	// [XID] // 0x0000000189933310-0x0000000189933330
	public static bool IsLoopDungeonOpen() => default; // 0x00000001849BAFF0-0x00000001849BB0D0
	// [XID] // 0x000000018993AEA0-0x000000018993AEC0
	public static int GetCurLoopDungeonIndex() => default; // 0x00000001849B8040-0x00000001849B8210
	// [XID] // 0x0000000189941F10-0x0000000189941F30
	public static ChannellerSlabLoopDungeonStageInfo GetLoopDungeonStageInfo() => default; // 0x00000001849BB770-0x00000001849BB890
	// [XID] // 0x00000001899499F0-0x0000000189949A10
	public static ChannellerSlabLoopDungeonInfo GetLoopDungeonInfo(uint loopDungeonIndex) => default; // 0x00000001849BB580-0x00000001849BB770
	// [XID] // 0x0000000189951400-0x0000000189951420
	public static uint GetLoopDungeonScore() => default; // 0x00000001849B9A50-0x00000001849B9BF0
	// [XID] // 0x0000000189958A50-0x0000000189958A70
	public static bool IsLoopDungeonRewardTaken(uint loopDungeonRewardId) => default; // 0x00000001849B9030-0x00000001849B9170
	// [XID] // 0x0000000189960090-0x00000001899600B0
	public static bool IsOneOffDungeonOpen(uint stageId) => default; // 0x00000001849B9D40-0x00000001849B9E20
	// [XID] // 0x0000000189967B30-0x0000000189967B50
	public static bool IsOneOffDungeonDone(uint stageId) => default; // 0x00000001849B93A0-0x00000001849B94B0
	// [XID] // 0x000000018996ECF0-0x000000018996ED10
	public static ChannellerSlabBuffSchemeInfo GetBuffSchemeInfo(bool isMPScheme) => default; // 0x00000001849BBEB0-0x00000001849BC050
	// [XID] // 0x00000001899768F0-0x0000000189976910
	public static void GetAllBuff(bool isNormal, ref List<uint> buffList) {} // 0x00000001849BA7A0-0x00000001849BAA30
	// [XID] // 0x000000018997DD10-0x000000018997DD30
	public static bool HasBuff() => default; // 0x00000001849B89B0-0x00000001849B8B30
	// [XID] // 0x00000001899856C0-0x00000001899856E0
	public static bool HasEquipedBuff(bool isMultiPlayerScheme) => default; // 0x00000001849B8B30-0x00000001849B8D80
	// [XID] // 0x000000018998D490-0x000000018998D4B0
	public static bool IsNewBuff(uint buffId) => default; // 0x00000001849BACF0-0x00000001849BAE20
	// [XID] // 0x0000000189994F10-0x0000000189994F30
	public static void RemoveBuffNewTag(uint buffId) {} // 0x00000001849BC350-0x00000001849BC480
	// [XID] // 0x000000018999C7F0-0x000000018999C810
	public static bool IsBuffBeViewed(uint buffId) => default; // 0x00000001849BBD80-0x00000001849BBEB0
	// [XID] // 0x00000001899A4280-0x00000001899A42A0
	public static void RemoveViewdBuff() {} // 0x00000001849BA190-0x00000001849BA430
	// [XID] // 0x00000001899ABC40-0x00000001899ABC60
	private static bool GetStoreValue(uint buffId, ref List<uint> dataList) => default; // 0x00000001849BB250-0x00000001849BB370
	// [XID] // 0x00000001899B3590-0x00000001899B35B0
	private static void SetStoreValue(uint buffId, ref List<uint> dataList) {} // 0x00000001849B8210-0x00000001849B8370
	// [XID] // 0x00000001899BA950-0x00000001899BA970
	public static void GetEquipedBuff(bool isMultiPlayerScheme, ref List<uint> equipedList) {} // 0x00000001849B86A0-0x00000001849B89B0
	// [XID] // 0x00000001899C2270-0x00000001899C2290
	public static int BuffSortFunc(uint left, uint right) => default; // 0x00000001849BABC0-0x00000001849BACF0
	// [XID] // 0x00000001899C99A0-0x00000001899C99C0
	public static uint GetEquipedPurpleBuffCount(bool isMPScheme) => default; // 0x00000001849B8370-0x00000001849B85B0
	// [XID] // 0x00000001899D11B0-0x00000001899D11D0
	public static uint GetEquipedNormalBuffCount(bool isMPScheme) => default; // 0x00000001849B9170-0x00000001849B93A0
	// [XID] // 0x00000001899D86A0-0x00000001899D86C0
	public static uint GetBuffEquipedSlot(bool isMPScheme, uint buffId) => default; // 0x00000001849BC480-0x00000001849BC6A0
	// [XID] // 0x00000001899DFD50-0x00000001899DFD70
	public static uint GetBuffBySlot(bool isMPScheme, uint slotId) => default; // 0x00000001849B9710-0x00000001849B9850
	// [XID] // 0x00000001899E7760-0x00000001899E7780
	public static uint GetEmptyNormalSlot(bool isMPScheme) => default; // 0x00000001849B9BF0-0x00000001849B9D40
	// [XID] // 0x00000001899EED10-0x00000001899EED30
	public static bool IsSlotEquiped(bool isMPScheme, uint slot) => default; // 0x00000001849BA430-0x00000001849BA550
	// [XID] // 0x00000001899F65D0-0x00000001899F65F0
	public static uint CalcUsedEnergy(ChannellerSlabBuffSchemeInfo schemeInfo) => default; // 0x00000001849B9E20-0x00000001849BA020
	// [XID] // 0x00000001899FDB10-0x00000001899FDB30
	public static uint GetMaxEnergy(bool isMPScheme) => default; // 0x00000001849BA020-0x00000001849BA190
	// [XID] // 0x0000000189A05550-0x0000000189A05570
	public static bool IsFriendAvatarAssisted(uint friendUid, uint avatarId) => default; // 0x00000001849B8D80-0x00000001849B9030
	// [XID] // 0x0000000189A0C870-0x0000000189A0C890
	public static uint GetAssistAvatar(int index) => default; // 0x00000001849B94B0-0x00000001849B9710
	// [XID] // 0x0000000189A141E0-0x0000000189A14200
	public static bool HasFriendAvatarToAssist() => default; // 0x00000001849BB890-0x00000001849BBD80
	// [XID] // 0x0000000189A1B450-0x0000000189A1B470
	public static bool HasAvatarToInvite() => default; // 0x00000001849B9850-0x00000001849B9A50
	// [XID] // 0x0000000189A22D50-0x0000000189A22D70
	public static bool IsSlabQuestFinished() => default; // 0x00000001849BB0D0-0x00000001849BB250
	// [XID] // 0x0000000189A2A020-0x0000000189A2A040
	public static uint FilterItemID(uint buffID) => default; // 0x00000001849BAE20-0x00000001849BAFF0
	// [XID] // 0x0000000189A31500-0x0000000189A31520
	public static Color GetColor(QualityType quality) => default; // 0x00000001849BAA30-0x00000001849BABC0
}

