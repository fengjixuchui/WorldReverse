/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class IconUtils // TypeDefIndex: 31559
{
	// Fields
	public const string QUALITY_STAR_PREFAB_ROOT = "ART/UI/Menus/Widget/Item/StarQuality"; // Metadata: 0x00B1294F
	public const string PROPERTY_ICON_ATLAS_PATH = "ART/UI/Atlas/PropertyIcon/"; // Metadata: 0x00B12977
	public const string ITEM_ICON_PATH = "ART/UI/Atlas/ItemIcon/"; // Metadata: 0x00B12995
	public const string MALL_COL_ITEM_ICON_PATH = "ART/UI/Atlas/MallGiftBanner/"; // Metadata: 0x00B129AF
	public const string MALL_TAB_ICON_PATH = "ART/UI/Atlas/MallTabIcon/"; // Metadata: 0x00B129CF
	public const string MONSTER_ICON_PATH = "ART/UI/Atlas/MonsterIcon/"; // Metadata: 0x00B129EC
	public const string ANIMAL_ICON_PATH = "ART/UI/Atlas/AnimalIcon/"; // Metadata: 0x00B12A09
	public const string MONSTER_SMALL_ICON_PATH = "ART/UI/Atlas/MonsterSmallIcon/"; // Metadata: 0x00B12A25
	public const string ITEM_IMAGE_PATH = "ART/UI/Atlas/ItemImg/"; // Metadata: 0x00B12A47
	public const string ROMAN_NUM_IMAGE_PATH = "ART/UI/Atlas/RomanNumIcon/"; // Metadata: 0x00B12A60
	public const string AVATAR_SIDE_ICON_PATH = "ART/UI/Atlas/AvatarSideIcon/"; // Metadata: 0x00B12A7E
	public const string AVATAR_SKILL_ICON_PATH = "ART/UI/Atlas/SkillIcons/"; // Metadata: 0x00B12A9E
	public const string AVATAR_BUFF_ELEMENT_PRE_PATH = "ART/UI/Atlas/BuffElement/"; // Metadata: 0x00B12ABA
	public const string AVATAR_MAP_MARK_PRE_PATH = "ART/UI/Atlas/MapMark/"; // Metadata: 0x00B12AD7
	public const string CHAT_ICON_PATH = "ART/UI/Atlas/Chat/"; // Metadata: 0x00B12AF0
	public const string PHOTOGRAPH_POSE_PATH = "ART/UI/Atlas/PoseIcon/"; // Metadata: 0x00B12B06
	public const string TOWER_BUFF_ICON_PATH = "ART/UI/Atlas/TowerIcon/"; // Metadata: 0x00B12B20
	public const string ITEMTIPS_BG_PREFAB_PATH = "ART/UI/Atlas/ItemTipBg/"; // Metadata: 0x00B12B3B
	public const string PENDANT_ICON_PREFAB_PATH = "ART/UI/Atlas/PendantIcon/"; // Metadata: 0x00B12B56
	public const string INTEE_ICON_PREFAB_PATH = "ART/UI/Atlas/InteeIcon/"; // Metadata: 0x00B12B73
	public const string BAG_TAB_ICON_PREFAB_PATH = "ART/UI/Atlas/BagTabIcon/"; // Metadata: 0x00B12B8E
	public const string QUEST_TAB_ICON_PREFAB_PATH = "ART/UI/Atlas/QuestTabIcon/"; // Metadata: 0x00B12BAA
	public const string FRIEND_TAB_ICON_PREFAB_PATH = "ART/UI/Atlas/FriendTabIcon/"; // Metadata: 0x00B12BC8
	public const string TUTORIAL_IMAGE_PATH = "ART/UI/Atlas/TutorialPic/"; // Metadata: 0x00B12BE7
	public const string CODEX_VIEW_IMAGE_PATH = "ART/UI/Atlas/CodexSceneryImg/"; // Metadata: 0x00B12C04
	public const string CODEX_VIEW_PIC_PATH = "ART/UI/Atlas/CodexSceneryPic/"; // Metadata: 0x00B12C25
	public const string TALENT_ICON_PATH = "ART/UI/Atlas/TalentIcon/"; // Metadata: 0x00B12C46
	public const string READ_PIC_PREFAB_PATH = "ART/UI/Atlas/ReadPic/"; // Metadata: 0x00B12C62
	public const string INPUT_KEY_ICON_PATH = "ART/UI/Atlas/InputKeyIcon/"; // Metadata: 0x00B12C7B
	public const string GODDESS_UNLOCK_ICON_PATH = "ART/UI/Atlas/GoddessUnlock/"; // Metadata: 0x00B12C99
	public const string NPC_TOP_ICON_PATH = "ART/UI/Atlas/NpcTopIcon/"; // Metadata: 0x00B12CB8
	public const string PLAYER_ICON_PATH = "ART/UI/Atlas/ButtonIcon/"; // Metadata: 0x00B12CD4
	public const string TERRAIN_TEXTURE_PATH = "ART/UI/Atlas/UIMap/TerrainCell/"; // Metadata: 0x00B12CF0
	public const string TERRAIN_DEFAULT_MATERIAL_PATH = "ART/UI/UIMap/UICloudMask/Material/Eff_UI_MapBack_None"; // Metadata: 0x00B12D13
	public const string TERRAIN_MATERIAL_PATH = "ART/UI/UIMap/UICloudMask/Material/"; // Metadata: 0x00B12D4C
	public const string TERRAIN_MATERIAL_NAME = "Eff_UI_MapBack_{0}_{1}"; // Metadata: 0x00B12D72
	public const string DUNGEON_TYPE_ICON_PATH = "ART/UI/Atlas/DungeonTypeIcon/"; // Metadata: 0x00B12D8C
	public const string EVENT_ICON_PATH = "ART/UI/Atlas/EventIcon/"; // Metadata: 0x00B12DAD
	public const string EXPLORE_ICON_PATH = "ART/UI/Atlas/ExplorePic/"; // Metadata: 0x00B12DC8
	public const string EXPLORE_BG_PATH = "ART/UI/Atlas/ExploreBGPic/"; // Metadata: 0x00B12DE4
	public const string EMOJI_PATH = "ART/UI/Atlas/Emotion/"; // Metadata: 0x00B12E02
	public const string CHAPTER_ICON_PATH = "ART/UI/Atlas/ChapterIcon/"; // Metadata: 0x00B12E1B
	public const string INVESTIGATION_IAMGE_PATH = "ART/UI/Atlas/HandbookPic/"; // Metadata: 0x00B12E38
	public const string MESSAGE_PUSH_ICON_PATH = "ART/UI/Atlas/MessagePushIcon/"; // Metadata: 0x00B12E55
	public const string TOWER_FLOOR_ITEM_IMAGE_PATH = "ART/UI/Atlas/TowerPic/"; // Metadata: 0x00B12E76
	public const string DEFAULT_TERRAIN_TEXTURE_PATH = "ART/UI/UIMap/TerrainCell/UI_MapBack_None"; // Metadata: 0x00B12E90
	public const string DEFAULT_ICON_PATH = "ART/UI/Atlas/ItemIcon/UI_Icon_Item_Temp"; // Metadata: 0x00B12EBC
	public const string MALE_PLAYER_ICON = "UI_BtnIcon_PlayerBoy"; // Metadata: 0x00B12EE7
	public const string FEMALE_PLAYER_ICON = "UI_BtnIcon_PlayerGirl"; // Metadata: 0x00B12EFF
	public const string SYSTEMOPEN_ICON_PATH = "ART/UI/Atlas/SystemOpenIcon/"; // Metadata: 0x00B12F18
	public const string DUNGEON_PIC_PATH = "ART/UI/Atlas/DungeonPic/"; // Metadata: 0x00B12F38
	public const string ITEM_ICON_SMALL_PATH = "ART/UI/Atlas/ItemSmallIcon/"; // Metadata: 0x00B12F54
	public const string LOADING_TIPS_BG_PATH = "ART/UI/Atlas/LoadingPic/"; // Metadata: 0x00B12F73
	public const string TOWER_BUFF_PIC_PATH = "ART/UI/Atlas/TowerPic/"; // Metadata: 0x00B12F8F
	public const string BATTLEPASS_PREVIEW_IMAGE_PATH = "ART/UI/Atlas/BattlePassImg/"; // Metadata: 0x00B12FA9
	public const string AVATAR_ICON_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon"; // Metadata: 0x00B12FC8
	public const string GACHA_TYPE_ICON_PATH = "ART/UI/Atlas/GachaTypeIcon/"; // Metadata: 0x00B12FEA
	public const string ELEMENT_ICON_PATH = "ART/UI/Atlas/ElementIcons/"; // Metadata: 0x00B13009
	public const string NAMECARD_PIC_PATH = "ART/UI/Atlas/NameCardPic/"; // Metadata: 0x00B13027
	public const string GACHA_SLOT_IMG_PATH = "ART/UI/Atlas/GachaSlotImg/"; // Metadata: 0x00B13044
	public const string ACTIVITY_BG_IMG_PATH = "ART/UI/Atlas/ActivityBg/"; // Metadata: 0x00B13062
	public const string NET_STATE_IMG_PATH = "ART/UI/Atlas/NetstatIcon/"; // Metadata: 0x00B1307E
	public const string ACHIEVEMENT_ICON_PATH = "ART/UI/Atlas/AchievementIcon/"; // Metadata: 0x00B1309B
	public const string ACHIEVEMENT_ICON_SMALL_PATH = "ART/UI/Atlas/AchievementSmallIcon/"; // Metadata: 0x00B130BC
	public const string ACTIVITY_BUFF_ICON_PATH = "ART/UI/Atlas/ActivityBuffIcon/"; // Metadata: 0x00B130E2
	public const string REPUTATION_PIC_PATH = "ART/UI/Atlas/ReputationPic/"; // Metadata: 0x00B13104
	public const string REPUTATION_BG_PATH = "ART/UI/Atlas/ReputationBg/"; // Metadata: 0x00B13123
	public const string NPC_ICON_PATH = "ART/UI/Atlas/NPCIcon/"; // Metadata: 0x00B13141
	public const string MECHANICUS_MAP_ICON_PATH = "ART/UI/Atlas/TheatreMechanicusImg/"; // Metadata: 0x00B1315A
	public const string MECHANICUS_MAP_PIC_PATH = "ART/UI/Atlas/TheatreMechanicusPic/"; // Metadata: 0x00B13180
	public const string MECHANICUS_CARD_ICON_PATH = "ART/UI/Atlas/TheatreMechanicusIcon/"; // Metadata: 0x00B131A6
	public const string HOMEWORLD_TAB_ICON_PATH = "ART/UI/Atlas/HomeWorldTabIcon/"; // Metadata: 0x00B131CD
	public const string HOMEWORLD_ITEM_ICON_PATH = "ART/UI/Atlas/HomeWorldIcon/"; // Metadata: 0x00B131EF
	public const string HOMEWORLD_SUITE_ITEM_ICON_PATH = "ART/UI/Atlas/HomeworldSuitPic/"; // Metadata: 0x00B1320E
	public const string HOMEWORLD_ANIMAL_ITEM_ICON_PATH = "ART/UI/Atlas/AnimalIcon/"; // Metadata: 0x00B13230
	public const string HOMEWORLD_ITEM_MODULE_PATH = "ART/UI/Atlas/HomeWorldModule/"; // Metadata: 0x00B1324C
	public const string HOMEWORLD_ITEM_MODULE_PIC_PATH = "ART/UI/Atlas/HomeworldModulePic/"; // Metadata: 0x00B1326D
	private static Sprite _defaultSprite; // 0x00
	private static Sprite _defaultTerrainSprite; // 0x08
	private static uint _defaultSpriteHandle; // 0x10
	private static uint _defaultTerrainSpriteHandle; // 0x14
	public static bool DisableAsyncLoad; // 0x18
	public static bool needPreload; // 0x19
	private static List<SpriteLoadProxy> _allSpriteProxies; // 0x20
	public const string CONFIG_PATH = "Data/UI/IconConfig"; // Metadata: 0x00B13291
	public const string CONFIG_PATH_ESSENTIAL = "Data/UI/IconConfigEssential"; // Metadata: 0x00B132A7

	// Properties
	public static Sprite DefaultSprite { /* [XID] */ /* 0x0000000189788CF0-0x0000000189788D10 */ get; } // 0x000000018191CFF0-0x000000018191D0C0 
	public static Sprite DefaultTerrainSprite { /* [XID] */ /* 0x0000000189790210-0x0000000189790230 */ get; } // 0x000000018191D1B0-0x000000018191D280 

	// Constructors
	static IconUtils() {} // 0x000000018191D580-0x000000018191D670

	// Methods
	// [XID] // 0x0000000189631A20-0x0000000189631A40
	public static SpriteLoadProxy AllocateProxy() => default; // 0x000000018191D0C0-0x000000018191D1B0
	// [XID] // 0x000000018979F8B0-0x000000018979F8D0
	public static void DeallocateProxy(ref SpriteLoadProxy proxy) {} // 0x000000018191B800-0x000000018191B980
	// [XID] // 0x00000001897A6E10-0x00000001897A6E30
	public static void InitIconUtil() {} // 0x000000018191C6C0-0x000000018191CA50
	// [XID] // 0x00000001897AE7B0-0x00000001897AE7D0
	public static void UnloadAllSpriteAtlas() {} // 0x000000018191B610-0x000000018191B800
	// [XID] // 0x00000001897B66F0-0x00000001897B6710
	public static void ReleaseAllSprites() {} // 0x000000018191B4C0-0x000000018191B610
	// [XID] // 0x00000001897BE530-0x00000001897BE550
	public static Sprite LoadSprite(ulong pathHash, out uint handled) {
		handled = default;
		return default;
	} // 0x000000018191D280-0x000000018191D580
	// [XID] // 0x00000001897E2080-0x00000001897E20A0
	public static void DismissSprite(uint handled) {} // 0x000000018191BAD0-0x000000018191BB90
	// [XID] // 0x00000001897CD310-0x00000001897CD330
	public static AsyncJob LoadSpriteAsync(ulong spritePathHash, Action<Sprite, uint> onResult) => default; // 0x000000018191CB40-0x000000018191CDB0
	// [XID] // 0x00000001897D49A0-0x00000001897D49C0
	public static void BuildIconConfig(IconConfig config) {} // 0x000000018191BFC0-0x000000018191C6C0
	// [XID] // 0x00000001897DC0A0-0x00000001897DC0C0
	public static void BuildIconConfigEssential(IconConfig config) {} // 0x000000018191BB90-0x000000018191BFC0
	[DebuggerHidden] // 0x00000001897E38B0-0x00000001897E38F0
	// [XID] // 0x00000001897E38B0-0x00000001897E38F0
	public static IEnumerator PreloadCommonIcon() => default; // 0x000000018191CA50-0x000000018191CB40
	// [XID] // 0x0000000189B64CA0-0x0000000189B64CC0
	public static string GetElementBuffIconNameByElementType(ElementType elementType) => default; // 0x000000018191CDB0-0x000000018191CF10
	// [XID] // 0x00000001897F5C90-0x00000001897F5CB0
	public static string GetElementIconNameByElementType(ElementType elementType) => default; // 0x000000018191B980-0x000000018191BAD0
	// [XID] // 0x00000001897FD490-0x00000001897FD4B0
	public static string GetFightPropertyIconName(FightPropType fightPropType) => default; // 0x000000018191CF10-0x000000018191CFF0
}

