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

namespace MoleMole
{
	[Serializable]
	public class UserLocalDataItem // TypeDefIndex: 19578
	{
		// Fields
		public bool showCDText; // 0x10
		public List<ulong> lastTeamList; // 0x18
		public HashSet<ulong> newBagItems; // 0x20
		public List<ulong> _newBagItemList; // 0x28
		public HashSet<ulong> bagChestBoxGuid; // 0x30
		public List<ulong> _bagChestBoxGuid; // 0x38
		public HashSet<ulong> bagFurnitureFormulaGuid; // 0x40
		public List<ulong> _bagFurnitureFormulaGuid; // 0x48
		public HashSet<uint> furnitureMakeUnTouchedId; // 0x50
		public List<uint> _furnitureMakeUnTouchedId; // 0x58
		public List<uint> trackingMainQuestIDList; // 0x60
		public List<uint> newCombineList; // 0x68
		public List<uint> newForgeList; // 0x70
		public HashSet<uint> avatarStorySet; // 0x78
		public List<uint> _avatarStoryList; // 0x80
		public HashSet<uint> avatarVoiceSet; // 0x88
		public List<uint> _avatarVoiceList; // 0x90
		public Dictionary<uint, bool> displayOrderDict; // 0x98
		public List<uint> _displayOrderList; // 0xA0
		public List<bool> _displayOrderViewList; // 0xA8
		public Dictionary<uint, uint> forgeLastAvatarDic; // 0xB0
		public List<uint> _forgeLastAvatarKeyList; // 0xB8
		public List<uint> _forgeLastAvatarValueList; // 0xC0
		public Dictionary<uint, uint> synthesisLastAvatarDic; // 0xC8
		public List<uint> _synthesisLastAvatarKeyList; // 0xD0
		public List<uint> _synthesisLastAvatarValueList; // 0xD8
		public Dictionary<uint, uint> cookingLastAvatarDic; // 0xE0
		public List<uint> _cookingLastAvatarKeyList; // 0xE8
		public List<uint> _cookingLastAvatarValueList; // 0xF0
		public HashSet<uint> browsedArenaChallengeLevelMap; // 0xF8
		public List<uint> _browsedArenaChallengeLevelListMap; // 0x100
		public HashSet<uint> browsedArenaChallengeLevel; // 0x108
		public List<uint> _browsedArenaChallengeLevelList; // 0x110
		public HashSet<uint> browsedMistTrialLevel; // 0x118
		public List<uint> _browsedMistTrialList; // 0x120
		public HashSet<uint> explorationShowedIDs; // 0x128
		public List<uint> _explorationShowedIDList; // 0x130
		public HashSet<uint> explorationActivityShowedIDs; // 0x138
		public List<uint> _explorationActivityShowedIDList; // 0x140
		public HashSet<uint> explorationChallengeShowedIDs; // 0x148
		public List<uint> _explorationChallengeShowedIDList; // 0x150
		public List<uint> openedH5ActivityScheduleIdList; // 0x158
		public int lastOpenedExplorationActivityID; // 0x160
		public List<uint> redPointList; // 0x168
		public bool showedMistTrialInstruction; // 0x170
		public int lastSeaLampOpenedQuestIndex; // 0x174
		public bool showFinishedEntranceFloor; // 0x178
		public bool equipSelectIsAsceRelic; // 0x179
		public SortType equipSelectSortTypeWeapon; // 0x17C
		public bool equipSelectIsAsceWeapon; // 0x180
		public SortType bagSortTypeRelic; // 0x184
		public bool bagIsAsceRelic; // 0x188
		public SortType bagSortTypeWeapon; // 0x18C
		public bool bagIsAsceWeapon; // 0x190
		public uint navigationID; // 0x194
		public MarkManager.NavigationType navigationType; // 0x198
		public uint lastNavigationID; // 0x19C
		public MarkManager.NavigationType lastNavigationType; // 0x1A0
		public List<uint> taskTrackList; // 0x1A8
		public Dictionary<uint, bool> newMainIdList; // 0x1B0
		public List<uint> openedActivityScheduleIdList; // 0x1B8
		public Dictionary<uint, bool> questRedPointList; // 0x1C0
		public List<uint> _questRedPointList; // 0x1C8
		public List<bool> _questRedPointBoolList; // 0x1D0
		public Dictionary<uint, string> activityRedPointShow; // 0x1D8
		public List<uint> _activityRedPointShowIdList; // 0x1E0
		public List<string> _activityRedPointShowDateTime; // 0x1E8
		public uint firstEnterAsterPageScheduleId; // 0x1F0
		public bool blockQuestLoading; // 0x1F4
		public bool monthlyCardAnimShown; // 0x1F5
		public uint firstEnterDragonSpineScheduleId; // 0x1F8
		public bool doNotShowLockTip; // 0x1FC
		public bool blessingCameraPageShown; // 0x1FD
		public uint firstEnterChannerSlabLevelScheduleId; // 0x200
		public uint fleurFairBalloonMark; // 0x204
		public uint fleurFairFallMark; // 0x208
		public uint[] lanternRiteEntranceSectionIds; // 0x210
		public List<uint> lanternRiteFinishedMiniQuestIds; // 0x218
		public bool lanternRiteContractTouch; // 0x220
		public List<uint> fleurFairDungeonMiniGameList; // 0x228
		public List<uint> ChannellerSlabNewBuffMaskList; // 0x230
		public List<uint> ChannellerSlabViewedBuffList; // 0x238
		public bool ChannellerSlabCharRewardViewed; // 0x240
		public bool enableAutoTalk; // 0x241
		public int uiBorderOffset; // 0x244
		public uint lastSeenDjinnWeekend; // 0x248
		public bool isUsingJoypad; // 0x24C
		public string joypadGUID; // 0x250
		public uint lastTalkingFriend; // 0x258
		public uint lastTalkingChannel; // 0x25C
		public List<uint> recentTalkingFriend; // 0x260
		public int lastEffigyDailyIndex; // 0x268
		public List<uint> mechanciusMapList; // 0x270
		public List<uint> mechanciusGearList; // 0x278
		public bool firstOpenMechanicusEntry; // 0x280
		public List<uint> widgetHasCheckIDList; // 0x288
		public int lastSelectMechanicusDifficultLevelIndex; // 0x290
		public uint waterSpriteActivityStoryReadProgress; // 0x294
		public uint waterSpriteActivityRegionSearchProgress; // 0x298
		public Dictionary<uint, uint> homeWorldDyestuffChosen; // 0x2A0
		public List<uint> _homeWorldDyestuffChosenKeyList; // 0x2A8
		public List<uint> _homeWorldDyestuffChosenValueList; // 0x2B0
		public bool activityHomeworldFirstClickGoto; // 0x2B8
	
		// Constructors
		public UserLocalDataItem() {} // 0x00000001821A4070-0x00000001821A4AF0
	
		// Methods
		// [XID] // 0x0000000189A79550-0x0000000189A79570
		public void OnLoaded() {} // 0x00000001821A34F0-0x00000001821A3C70
		// [XID] // 0x0000000189924E20-0x0000000189924E40
		public void OnSaving() {} // 0x00000001821A2540-0x00000001821A34F0
		// [XID] // 0x000000018992C320-0x000000018992C340
		public bool GetRedPoint(RedPointId id) => default; // 0x00000001821A3EE0-0x00000001821A3FA0
		// [XID] // 0x00000001899338E0-0x0000000189933900
		public bool GetRedPointById(uint id) => default; // 0x00000001821A3FA0-0x00000001821A4070
		// [XID] // 0x000000018993B4D0-0x000000018993B4F0
		public void SetRedPointById(uint id) {} // 0x00000001821A3DF0-0x00000001821A3EE0
		// [XID] // 0x0000000189942590-0x00000001899425B0
		public void SetRedPoint(RedPointId id) {} // 0x00000001821A3C70-0x00000001821A3D20
		// [XID] // 0x0000000189949F20-0x0000000189949F40
		public void RemoveRedPoint(RedPointId id) {} // 0x00000001821A3D20-0x00000001821A3DF0
	}
}
