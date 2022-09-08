/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class InLevelData // TypeDefIndex: 19508
{
	// Fields
	public static ulong FROMBACK_LIMIT_DURATION; // 0x00
	public static float FROMBACK_LIMIT_RATIO; // 0x08
	public static float DELAY_RECONNECT_BASE_DURATION; // 0x0C
	public static float FROMBACK_RECONNECT_DURATION; // 0x10
	public static float FORCE_RECONNECT_DURATION; // 0x14
	public static float MALL_LIMITSHOW_DAYS; // 0x18
	public static float GRASS_TILE_ELEMENT_REACTION_POS_OFFSET; // 0x1C
	public static float MONSTER_RECORD_DIS; // 0x20
	public static float MONSTER_RECORD_ANGLE; // 0x24
	public static float PING_DURATION; // 0x28
	public static int PLAYING_TIMEOUT_COUNT; // 0x2C
	public static uint BIGWORLD_SCENE_ID; // 0x30
	public static float ELEMENT_OVERLOAD_MAX; // 0x34
	public static float ELEMENT_OVERLOAD_REDUCE; // 0x38
	public static float ELEMENT_TXT_SHOW_DISTANCE; // 0x3C
	public static int LIMIT_QUALITY_ONDROP; // 0x40
	public static float PURGE_DECREMENT; // 0x44
	public static float AVATAR_PICKUP_RANGE; // 0x48
	public static float AVATAR_ENERGY_PICKUP_RANGE; // 0x4C
	public static float AVATAR_ENERGY_STAY_TIME; // 0x50
	public static float ONE_DAY_IN_MINUTE; // 0x54
	public static float CHANGE_AVATAR_CD; // 0x58
	public static uint MALEPLAYER_ID; // 0x5C
	public static uint FEMALEPLAYER_ID; // 0x60
	public static uint CAMERA_ID; // 0x64
	public static uint TEAM_ID; // 0x68
	public static uint MPLEVEL_ID; // 0x6C
	public static uint GRASS_ID; // 0x70
	public static uint WATER_ID; // 0x74
	public static float AVATAR_FORCE_DRAG_COUNT; // 0x78
	public static float AVATAR_FORCE_DRAG_DIST; // 0x7C
	public static int TERRAIN_LAYER; // 0x80
	public static int SCENE_PROP_LAYER; // 0x84
	public static int SCENE_PROP_IGNORE_CAMERA_LAYER; // 0x88
	public static int SCENE_PROP_TEMP_LAYER; // 0x8C
	public static int SCENE_PROP_TRIGGER_LAYER; // 0x90
	public static int IK_LAYER; // 0x94
	public static int HITBOX_LAYER; // 0x98
	public static int WATER_LAYER; // 0x9C
	public static int OCCLUDER_LAYER; // 0xA0
	public static int CHARACTER_LAYER; // 0xA4
	public static int CHARACTER_COMBINE_LAYER; // 0xA8
	public static int CHARACTER_PUSHING_LAYER; // 0xAC
	public static int CHARACTER_PUSHING_EXTRA_LAYER; // 0xB0
	public static int BULLET_TRIGGER_LAYER; // 0xB4
	public static int INTEE_TARGET_LAYER; // 0xB8
	public static int INTEE_TRIGGER_LAYER; // 0xBC
	public static readonly Vector3 CREATE_INIT_POS; // 0xC0
	public static readonly Vector3 CREATE_INIT_FORWARD; // 0xCC
	public static float MIN_COLLIDER_RADIUS; // 0xD8
	public const float LIMIT_TRANS_LEN = 60f; // Metadata: 0x00AFC942
	public const float TIME_SLOW_RATIO = 0.05f; // Metadata: 0x00AFC946
	public const float TIME_ZERO_RATIO = 1E-07f; // Metadata: 0x00AFC94A
	public const float ENTITY_RIGIDBODY_MASS_CAP = 1000f; // Metadata: 0x00AFC94E
	public static Transform ENTITY_DUMMY_ROOT; // 0xE0
	public static Transform ENTITY_NON_DUMMY_ROOT; // 0xE8
	public static Transform ENTITY_RIGIDBODY_ROOT; // 0xF0
	public static Transform WORLD_ATTACH_POINT_ROOT; // 0xF8
	public static Transform AVATAR_ENTITY_ROOT; // 0x100
	public static Transform MONSTER_ENTITY_ROOT; // 0x108
	public static Transform BULLET_ENTITY_ROOT; // 0x110
	public static Transform NPC_ENTITY_ROOT; // 0x118
	public static Transform GATHER_ENTITY_ROOT; // 0x120
	public static Transform GADGET_ENTITY_ROOT; // 0x128
	public static Transform OTHER_ENTITY_ROOT; // 0x130
	public static Transform EQUIP_ENTITY_ROOT; // 0x138
	public static Transform MONSTEREQUIP_ENTITY_ROOT; // 0x140
	public static string ABILITY_WATER_AREA; // 0x148
	public static string MODIFIER_WATER_AREA; // 0x150
	public static string ABILITY_THUNDER_AREA; // 0x158
	public static string ABILITY_RAIN; // 0x160
	public static string MODIFIER_RAIN; // 0x168
	public static string ABILITY_WATCHER_SYSTEM_NAME; // 0x170
	public static string COMMON_ICE_FROZEN_DIE_EFFECT_PATTERN_NAME; // 0x178
	public static string COMMON_BURNNING_DIE_EFFECT_PATTERN_NAME; // 0x180
	public static string COMMON_PETRIFATION_DIE_EFFECT_PATTERN_NAME; // 0x188
	public static string COMMON_BROKEN_DIE_EFFECT_PATTERN_NAME; // 0x190
	public static string LARGE_SCALE_MONSTER_PREDICATED_POINT; // 0x198
	public const int ENTITY_DENY_LOCK_ON_STACK_CAPACITY = 4; // Metadata: 0x00AFC952
	public const int ENTITY_DENY_LOCK_ON_COMBAT_IX = 0; // Metadata: 0x00AFC956
	public const int ENTITY_DENY_LOCK_ON_SUPPORT_IX = 1; // Metadata: 0x00AFC95A
	public const int ENTITY_DENY_LOCK_ON_ABILITY_IX = 2; // Metadata: 0x00AFC95E
	public const int ENTITY_INVINCIBLE_STACK_CAPACITY = 4; // Metadata: 0x00AFC962
	public const int ENTITY_INVINCIBLE_COMBAT_IX = 0; // Metadata: 0x00AFC966
	public const int ENTITY_INVINCIBLE_ABILITY_IX = 1; // Metadata: 0x00AFC96A
	public const int ENTITY_LOCKHP_STACK_CAPACITY = 4; // Metadata: 0x00AFC96E
	public const int ENTITY_LOCKHP_COMBAT_IX = 0; // Metadata: 0x00AFC972
	public const int ENTITY_LOCKHP_ABILITY_IX = 1; // Metadata: 0x00AFC976
	public const int ENTITY_IS_GHOST_TO_ALLIED_STACK_CAPACITY = 4; // Metadata: 0x00AFC97A
	public const int ENTITY_IS_GHOST_TO_ALLIED_COMBAT_IX = 0; // Metadata: 0x00AFC97E
	public const int ENTITY_IS_GHOST_TO_ALLIED_ABILITY_IX = 1; // Metadata: 0x00AFC982
	public const int ENTITY_IS_GHOST_TO_ENMEY_STACK_CAPACITY = 4; // Metadata: 0x00AFC986
	public const int ENTITY_IS_GHOST_TO_ENMEY_COMBAT_IX = 0; // Metadata: 0x00AFC98A
	public const int ENTITY_IS_GHOST_TO_ENMEY_ABILITY_IX = 1; // Metadata: 0x00AFC98E
	public const int ENTITY_CAN_TRIGGER_BULLET_STACK_CAPACITY = 2; // Metadata: 0x00AFC992
	public const int ENTITY_CAN_TRIGGER_BULLET_COMBAT_IX = 0; // Metadata: 0x00AFC996
	public const int ENTITY_CAN_TRIGGER_BULLET_ABILITY_IX = 1; // Metadata: 0x00AFC99A
	public const int ENTITY_DENY_ELEMENT_STICK_CAPACITY = 2; // Metadata: 0x00AFC99E
	public const int ENTITY_DENY_ELEMENT_STICK_COMBAT_IX = 0; // Metadata: 0x00AFC9A2
	public const int ENTITY_DENY_ELEMENT_STICK_ABILITY_IX = 1; // Metadata: 0x00AFC9A6
	public const int AVATAR_SET_ACTIVE_CAPACITY = 3; // Metadata: 0x00AFC9AA
	public const int AVATAR_SET_ACTIVE_CAPACITY_DEFAULT = 0; // Metadata: 0x00AFC9AE
	public const int AVATAR_SET_ACTIVE_CAPACITY_INTERACTION = 1; // Metadata: 0x00AFC9B2
	public const int ENTITY_SET_VISIABLE_NORMAL_IX = 0; // Metadata: 0x00AFC9B6
	public const int ENTITY_SET_VISIABLE_ABILITY_ACTION_IX = 1; // Metadata: 0x00AFC9BA
	public const int ENTITY_SET_VISIABLE_INTERACTION_IX = 2; // Metadata: 0x00AFC9BE
	public const int ENTITY_SET_VISIABLE_EQUIP_IX = 3; // Metadata: 0x00AFC9C2
	public const int ENTITY_SET_VISIABLE_DITHER_IX = 4; // Metadata: 0x00AFC9C6
	public const int ENTITY_SET_VISIABLE_LUA_ACTOR_IX = 5; // Metadata: 0x00AFC9CA
	public const int ENTITY_SET_VISIABLE_FOLLOW_MOVE_IX = 6; // Metadata: 0x00AFC9CE
	public const int ENTITY_SET_VISIABLE_CUTSCENE_IX = 7; // Metadata: 0x00AFC9D2
	public const int ENTITY_SET_VISIABLE_EDITOR_IX = 8; // Metadata: 0x00AFC9D6
	public const int ENTITY_SET_VISIABLE_PHOTOGRAPH_IX = 9; // Metadata: 0x00AFC9DA
	public const int ENTITY_SET_VISIABLE_AVATAR_FOLLOW_ROUTE_IX = 10; // Metadata: 0x00AFC9DE
	public const int ENTITY_SET_VISIABLE_BEFORE_ENTITY_READY = 11; // Metadata: 0x00AFC9E2
	public const int ENTITY_SET_VISIABLE_ABILITY_GALLARY_IX = 12; // Metadata: 0x00AFC9E6
	public const int FORCE_SLOW_MOVE_NORMAL_IX = 0; // Metadata: 0x00AFC9EA
	public const int FORCE_SLOW_MOVE_LUATASK_IX = 1; // Metadata: 0x00AFC9EE
	public const int FORCE_SLOW_MOVE_CAMERALOOK_IX = 2; // Metadata: 0x00AFC9F2
	public const int CAMERA_DISPLACEMENT_ENABLE_TALK = 0; // Metadata: 0x00AFC9F6
	public const int CAMERA_DISPLACEMENT_ENABLE_CUTSCENE = 1; // Metadata: 0x00AFC9FA
	public const int SHAKEMANAGER_IGNORESHAKE_TIMELINE_IX = 0; // Metadata: 0x00AFC9FE
	public const int BAN_ENTITY_MARK_ABILITY_ACTION_IX = 0; // Metadata: 0x00AFCA02
	public const int BAN_ENTITY_MARK_GALLERY_IX = 1; // Metadata: 0x00AFCA06
	public const int SHOW_ENTITY_MARK_EFFECT_ABILITY_ACTION_IX = 0; // Metadata: 0x00AFCA0A
	public const int ENTITY_SET_VISIABLE_MAX_IX = 31; // Metadata: 0x00AFCA0E
	public const int ENTITY_MASS_LAYER_RATIO = 0; // Metadata: 0x00AFCA12
	public const int ENTITY_MASS_ABILITY_RATIO = 1; // Metadata: 0x00AFCA16
	public static string EQUIP_PART_1; // 0x1A0
	public static string EQUIP_PART_2; // 0x1A8
	public static string EQUIP_PART_3; // 0x1B0
	public static string EQUIP_PART_4; // 0x1B8
	public static string SHEATH_POINT; // 0x1C0
	public static float GLOBAL_DIE_DELAY_TIME; // 0x1C8
	private static uint _peerId; // 0x1CC
	public static uint hostPeerId; // 0x1D0
	private static bool _hasOtherPlayerArround; // 0x1D4
	public const float SPRINT_TOLERATED_DELAY = 0.2f; // Metadata: 0x00AFCA1A
	public static bool PauseGameLevelLoading; // 0x1D5
	public static float CLIMB_MIN_STAMINA; // 0x1D8
	public static float DASH_BS_COST_STAMINA; // 0x1DC
	public static float CROUCH_ROLL_COST_STAMINA; // 0x1E0
	private const string DUMP_LOADING_ASSET = "dumpLoadingAsset"; // Metadata: 0x00AFCA1E
	private const string LOAD_INLEVEL_FROM_BIN = "loadInLevelFromBin"; // Metadata: 0x00AFCA32

	// Properties
	public static uint peerId { /* [XID] */ /* 0x00000001897DC870-0x00000001897DC890 */ get; /* [XID] */ /* 0x00000001897E4270-0x00000001897E4290 */ set; } // 0x000000018387CF90-0x000000018387D060 0x000000018387CD40-0x000000018387CEC0
	public static bool hasOtherPlayerArround { /* [XID] */ /* 0x00000001897EBD80-0x00000001897EBDA0 */ get; /* [XID] */ /* 0x00000001897F3710-0x00000001897F3730 */ set; } // 0x000000018387AE80-0x000000018387AFB0 0x000000018387CC70-0x000000018387CD40
	public static bool hasOtherRemotePlayerArround { /* [XID] */ /* 0x00000001897FB070-0x00000001897FB090 */ get; } // 0x000000018387B1C0-0x000000018387B350 
	public static bool HasGameLevelLoadFinished { /* [XID] */ /* 0x00000001897052F0-0x0000000189705310 */ get; /* [XID] */ /* 0x0000000189809960-0x0000000189809980 */ set; } // 0x000000018387B0F0-0x000000018387B1C0 0x000000018387CEC0-0x000000018387CF90
	public static bool dumpLoadingAsset { /* [XID] */ /* 0x00000001898110A0-0x00000001898110C0 */ get; /* [XID] */ /* 0x0000000189818C10-0x0000000189818C30 */ set; } // 0x000000018387AFB0-0x000000018387B050 0x000000018387CB30-0x000000018387CBD0
	public static bool loadInLevelFromBin { /* [XID] */ /* 0x00000001898204F0-0x0000000189820510 */ get; /* [XID] */ /* 0x0000000189827B40-0x0000000189827B60 */ set; } // 0x000000018387CBD0-0x000000018387CC70 0x000000018387B050-0x000000018387B0F0

	// Nested types
	public enum DamageType // TypeDefIndex: 19509
	{
		Physical = 0,
		Fire = 1,
		Electric = 2,
		Ice = 3,
		Biology = 4
	}

	public enum HitFailedType // TypeDefIndex: 19510
	{
		HitEntityNotEnemy = 0,
		HitStage = 1,
		HitNothing = 2
	}

	// Constructors
	static InLevelData() {} // 0x000000018387D060-0x000000018387D5F0

	// Methods
	// [XID] // 0x00000001897BED70-0x00000001897BED90
	public static void InitLayer() {} // 0x000000018387C800-0x000000018387CB30
	// [XID] // 0x00000001897C6360-0x00000001897C6380
	public static void Init() {} // 0x000000018387B350-0x000000018387C720
	// [XID] // 0x00000001897CDBA0-0x00000001897CDBC0
	private static void InitEntityRoot() {} // 0x000000018387A020-0x000000018387AE80
	// [XID] // 0x00000001897D5070-0x00000001897D5090
	public static void Clear() {} // 0x000000018387C720-0x000000018387C800
}

