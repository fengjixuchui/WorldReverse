/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AnimatorParamsData // TypeDefIndex: 19418
{
	// Fields
	public const string PARAM_CLIMB_HOR = "ClimbHor"; // Metadata: 0x00AFC894
	public const string PARAM_CLIMB_VER = "ClimbVer"; // Metadata: 0x00AFC8A0
	public static readonly int CLIMB; // 0x00
	public static readonly int STANDBY_TO_CLIMB; // 0x04
	public static readonly int CLIMB_JUMP; // 0x08
	public static readonly int CROUCH_ROLL; // 0x0C
	public static readonly int JUMP_OFF_WALL; // 0x10
	public static readonly int DROP_DOWN_LIT; // 0x14
	public static readonly int FALL_ON_GROUND_RUN; // 0x18
	public static readonly int FALL_ON_GROUND; // 0x1C
	public static readonly int FALL_SPEED_LEVEL; // 0x20
	public static readonly int FLY; // 0x24
	public static readonly int FLY_POSE; // 0x28
	public static readonly int JUMP_UP_WALL_READY; // 0x2C
	public static readonly int LADDER; // 0x30
	public static readonly int LADDER_SLIP; // 0x34
	public static readonly int LADDER_SLIP_STOP; // 0x38
	public static readonly int MOVE; // 0x3C
	public static readonly int CLIMB_DOWN; // 0x40
	public static readonly int SLIP_FACE_WALL; // 0x44
	public static readonly int SLIP_BACK_WALL; // 0x48
	public static readonly int SWIM_JUMP; // 0x4C
	public static readonly int SWIM; // 0x50
	public static readonly int SWIM_DASH; // 0x54
	public static readonly int SWIM_DASH_STOP; // 0x58
	public static readonly int UPSTAIRS; // 0x5C
	public static readonly int UPSTAIR_TO_MOVE; // 0x60
	public static readonly int JUMP; // 0x64
	public static readonly int JUMP_TYPE; // 0x68
	public static readonly int COMBAT_TO_JUMP; // 0x6C
	public static readonly int SLIPPING; // 0x70
	public static readonly int SPRINT_BS; // 0x74
	public static readonly int BACK_STEP; // 0x78
	public static readonly int COMBAT_TO_BACK_STEP; // 0x7C
	public static readonly int SWIM_POSE; // 0x80
	public static readonly int MOVE_JUMP_LEFT; // 0x84
	public static readonly int VANISH; // 0x88
	public static readonly int CLIMB_JUMP_ANGLE; // 0x8C
	public static readonly int CLIMB_JUMP_SUB; // 0x90
	public static readonly int CLIMB_HOR_MOVE0; // 0x94
	public static readonly int CLIMB_VER_MOVE0; // 0x98
	public static readonly int CLIMB_HOR_MOVE1; // 0x9C
	public static readonly int CLIMB_VER_MOVE1; // 0xA0
	public static readonly int CLINE; // 0xA4
	public static readonly int CLINE_IM; // 0xA8
	public static readonly int COMBAT_TO_SPRINTBS; // 0xAC
	public static readonly int CROUCH; // 0xB0
	public static readonly int UPSTAIR_POSE; // 0xB4
	public static readonly int UPSTAIR_POSE2; // 0xB8
	public static readonly int AT_UPSTAIRS; // 0xBC
	public static readonly int AT_CLIMB_MOVE_0; // 0xC0
	public static readonly int AT_CLIMB_MOVE_1; // 0xC4
	public static readonly int AT_CLIMB_IDLE; // 0xC8
	public static readonly int AT_LADDER_MOVE_0; // 0xCC
	public static readonly int AT_LADDER_MOVE_1; // 0xD0
	public static readonly int AT_LADDER_IDLE; // 0xD4
	public static readonly int NORMALIZED_TIME; // 0xD8
	public static readonly int MOTION_DIRECTION; // 0xDC
	public static readonly int MOTION_FLAG; // 0xE0
	public static readonly int CLIMB_HOR; // 0xE4
	public static readonly int CLIMB_VER; // 0xE8
	public static readonly int FREE_STYLE_TYPE; // 0xEC
	public static readonly int FREE_STYLE; // 0xF0
	public static readonly int FREE_STATE_TRIGGER; // 0xF4
	public static readonly int FREE_STYLE_DOING; // 0xF8
	public static readonly int FREE_STYLE_PARAM; // 0xFC
	public static readonly int FREE_LOOP_STATE; // 0x100
	public static readonly int HEAD_FREE_STYLE; // 0x104
	public static readonly int HEAD_FREE_STYLE_TYPE; // 0x108
	public static readonly int PERFORM_DOING; // 0x10C
	public static readonly int DO_PERFORM; // 0x110
	public static readonly int CANCEL_PERFORM; // 0x114
	public static readonly int PERFORM_ID; // 0x118
	public static readonly int PERFORM_STATE_TRIGGER; // 0x11C
	public static readonly int PERFORM_PARAM; // 0x120
	public static readonly int PERFORM_LOOP_STATE; // 0x124
	public static readonly int BORN_TRIGGER; // 0x128
	public static readonly int WEAPON_STATE_ID; // 0x12C
	public static readonly int NEXT_WEAPON_STATE_ID; // 0x130
	public static readonly int MOVE_ON_SURFACE; // 0x134
	public static readonly int STATE_FLY_HASH; // 0x138
	public static readonly int STATE_FLY_START_HASH; // 0x13C
	public static readonly int STATE_DISAPPEAR_HASH; // 0x140
	public static readonly int STATE_JUMP_UP_WALL_FOR_STANDBY_HASH; // 0x144
	public static readonly int STATE_SWIM_DILE_HASH; // 0x148
	public static readonly int STATE_RUN; // 0x14C
	public static readonly int STATE_RUN_TO_IDLE; // 0x150
	public static readonly int STATE_STANDBY; // 0x154
	public static readonly int STATE_STANDBY_WEAPON; // 0x158
	public static readonly int STATE_SIT01_LOOP; // 0x15C
	public static readonly int OPEN_CHEST; // 0x160
	public static readonly int APPEAR_DIRECTLY; // 0x164
	public static readonly int COMBAT_TO_SWIM; // 0x168
	public static readonly int SHOW_CHARACTER; // 0x16C
	public static readonly int DO_SKILL; // 0x170
	public static readonly int AIM_END; // 0x174
	public static readonly int SUPPORT_IN_TRIGGER; // 0x178
	public static readonly int DIE; // 0x17C
	public static readonly int HIT_FLAG; // 0x180
	public static readonly int BE_HIT; // 0x184
	public static readonly int BE_HIT_ANGLE; // 0x188
	public static readonly int BE_HIT_ANGLE_ABS; // 0x18C
	public static readonly int SHAKE_TRIGGER; // 0x190
	public static readonly int SHAKE_FLAG; // 0x194
	public static readonly int ACTIVE_TRIGGER; // 0x198
	public static readonly int IS_ACTIVE_START; // 0x19C
	public static readonly int INACTIVE_TRIGGER; // 0x1A0
	public static readonly int LEVEL; // 0x1A4
	public static readonly int HIT_AIR_2_HIT_DROP; // 0x1A8
	public static readonly int DIE_FLAG; // 0x1AC
	public static readonly int DISAPPEAR; // 0x1B0
	public static readonly int SKILL_ID; // 0x1B4
	public static readonly int RANDOM_VALUE; // 0x1B8
	public static readonly int IS_LOCAL_AVATAR; // 0x1BC
	public static readonly int DF_MODE; // 0x1C0
	public static readonly int COMBO_COUNT; // 0x1C4
	public static readonly int ABILITY_STATE_FLAG; // 0x1C8
	public static readonly int RANDOM_CYCLE_OFFSET; // 0x1CC
	public static readonly int IN_STATES_NEED_AIM_END; // 0x1D0
	public static readonly int AIM_WALK; // 0x1D4
	public static readonly int WEAPON; // 0x1D8
	public static readonly int INPUT_MOLD; // 0x1DC
	public static readonly int MOVE_SPEED_RATIO; // 0x1E0
	public static readonly int ATTACK_SPEED_RATIO; // 0x1E4
	public static readonly int FACE_TO_LR; // 0x1E8
	public static readonly int FACE_TO_FB; // 0x1EC
	public static readonly int STATE; // 0x1F0
	public static readonly int PUT_AWAY; // 0x1F4
	public static readonly int AUTO_HEAL_TRIGGER; // 0x1F8
	public static readonly int AUTO_HEAL_INTERRUPT; // 0x1FC
	public static readonly int STATE_EFF_ANI_GODDESS_STATE4_HASH; // 0x200
	public static readonly int VALID; // 0x204
	public static readonly int NAME; // 0x208
	public static readonly int TITLE; // 0x20C
	public static readonly int TITLE_CHANGE; // 0x210
	public static readonly int SHOW_ICON; // 0x214
	public static readonly int PLAY_DONE; // 0x218
	public static readonly int FLY_GROUND_CHECK; // 0x21C
	public static readonly int LEVEL_TRIGGER; // 0x220
	public static readonly int IS_REACH_LEVEL; // 0x224
	public static readonly int PLAY_TRIGGER; // 0x228
	public static readonly int IS_PLAY_DONE; // 0x22C
	public static readonly int FLYING; // 0x230
	public static readonly int IS_AUTHORITY; // 0x234
	public static readonly int WALK_SPEED; // 0x238
	public static readonly int AI_BORN; // 0x23C
	public static readonly int TARGET_RELATIVE_ANGLE_YAW; // 0x240
	public static readonly int TARGET_RELATIVE_ANGLE_YAWABS; // 0x244
	public static readonly int EQUIP01; // 0x248
	public static readonly int EQUIP02; // 0x24C
	public static readonly int ALERTNESS; // 0x250
	public static readonly int TACTIC; // 0x254
	public static readonly int RETURN_TO_BORN_PHASE; // 0x258
	public static readonly int LANDED; // 0x25C
	public static readonly int TARGET_DISTANCE_XZ; // 0x260
	public static readonly int TARGET_DISTANCE_Y; // 0x264
	public static readonly int POSE_ID; // 0x268
	public static readonly int RANDOM_POSE; // 0x26C
	public static readonly int SCARED; // 0x270
	public static readonly int LANDING_TOUCH_DOWN; // 0x274
	public static readonly int SCRIPTED_ROTATION_MODE; // 0x278
	public static readonly int SURROUND_BIGTURN; // 0x27C
	public static readonly int SURROUND_CLOCKWISE; // 0x280
	public static readonly int CRABMOVE_CLOCKWISE; // 0x284
	public static readonly int REACT_INTERRUPTED_TRIGGER; // 0x288
	public static readonly int SCENEUI_SHOW_CHARACTER; // 0x28C
	public static readonly int SCENEUI_SHOW_WEAPON; // 0x290
	public static readonly int SCENEUI_SHOW_RELIC; // 0x294
	public static readonly int SCENEUI_SHOW_SKILL; // 0x298
	public static readonly int SCENEUI_SHOW_TALENT; // 0x29C
	public static readonly int SCENEUI_SHOW_STORY; // 0x2A0
	public static readonly int SCENEUI_SHOW_FLYCLOAK; // 0x2A4
	public static readonly int SCENEUI_SHOW_TAB_ID; // 0x2A8
	public static readonly int GACHAUI_CUT_IN; // 0x2AC
	public static readonly int OPEN; // 0x2B0
	public static readonly int IN; // 0x2B4
	public static readonly int CLOSE; // 0x2B8
	public static readonly int FOCUS_ANGLE; // 0x2BC
	public static readonly int AIMING; // 0x2C0
	public static readonly int FAST_AIMING; // 0x2C4
	public static readonly int HEAD_HOR; // 0x2C8
	public static readonly int HEAD_VER; // 0x2CC
	public static readonly int MONSTER_HIT_L; // 0x2D0
	public static readonly int MONSTER_HIT_H; // 0x2D4
	public static readonly int MONSTER_HIT_AIR; // 0x2D8
	public static readonly int GADGET_STATE; // 0x2DC

	// Nested types
	public static class UI // TypeDefIndex: 19419
	{
		// Fields
		public static readonly int FADE_IN; // 0x00
		public static readonly int FADE_OUT; // 0x04
		public static readonly int FOCUS_ANIM_SHOW; // 0x08
		public static readonly int VALID; // 0x0C
		public static readonly int NORMAL; // 0x10
		public static readonly int HIGHLIGHTED; // 0x14
		public static readonly int PRESSED; // 0x18
		public static readonly int DISABLED; // 0x1C
		public static readonly int SELECTED; // 0x20
		public static readonly int ADD; // 0x24
		public static readonly int NO_QUEST; // 0x28
		public static readonly int SHOW; // 0x2C
		public static readonly int HIDE; // 0x30
		public static readonly int STATE; // 0x34
		public static readonly int FADE_IN_END; // 0x38
		public static readonly int FADE_OUT_END; // 0x3C
		public static readonly int POP; // 0x40
		public static readonly int START_FADE_IN; // 0x44
		public static readonly int TO_AVATAR; // 0x48
		public static readonly int TO_TEAM; // 0x4C
		public static readonly int NEW; // 0x50
		public static readonly int REPLACE; // 0x54
		public static readonly int COMPLETE; // 0x58
		public static readonly int FAIL; // 0x5C
		public static readonly int REMIND; // 0x60
		public static readonly int WHITE_CURTAIN; // 0x64
		public static readonly int IS_ON; // 0x68
		public static readonly int START; // 0x6C
		public static readonly int PROGRESS; // 0x70
		public static readonly int END; // 0x74
		public static readonly int SKIP_FADE_IN; // 0x78
		public static readonly int LIST_FADE_IN; // 0x7C
		public static readonly int LIST_FADE_OUT; // 0x80
		public static readonly int READY; // 0x84
		public static readonly int WARNING; // 0x88
		public static readonly int KORAN_TIPS; // 0x8C
		public static readonly int ACTIVE; // 0x90
		public static readonly int VIEWPORT_FADE_OUT; // 0x94
		public static readonly int QUALITY; // 0x98
		public static readonly int SUIT_1; // 0x9C
		public static readonly int SUIT_2; // 0xA0
		public static readonly int SHOCK; // 0xA4
		public static readonly int COUNTDOWN_WARNING; // 0xA8
		public static readonly int LOADING; // 0xAC
		public static readonly int AVAILABLE; // 0xB0
		public static readonly int UPDATE; // 0xB4
		public static readonly int ONLINE; // 0xB8
		public static readonly int TO_FRIEND_LIST; // 0xBC
		public static readonly int TO_FRIEND_ADD; // 0xC0
		public static readonly int TO_FRIEND_RECENTLY; // 0xC4
		public static readonly int RING_MAX; // 0xC8
		public static readonly int CONVERSION; // 0xCC
		public static readonly int SHOWITEMSLOT; // 0xD0
		public static readonly int SHOWITEMSLOT_SENIOR; // 0xD4
		public static readonly int SHOWITEMSLOT_SETTLEMENT; // 0xD8
		public static readonly int INSTOCK; // 0xDC
		public static readonly int TAB_RECHARGE; // 0xE0
		public static readonly int SHOW_BACK; // 0xE4
		public static readonly int LOCK; // 0xE8
		public static readonly int UNLOCK; // 0xEC
		public static readonly int REFRESH; // 0xF0
		public static readonly int NEXT; // 0xF4
		public static readonly int NOTAVALIABLE; // 0xF8
		public static readonly int OPEN_CARD; // 0xFC
		public static readonly int SKIP_ANIM; // 0x100
		public static readonly int SKIP_TOGGLE; // 0x104
		public static readonly int REWARDSTATE; // 0x108
		public static readonly int SWITCH_PREV; // 0x10C
		public static readonly int SWITCH_NEXT; // 0x110
		public static readonly int CAMPHIDE; // 0x114

		// Nested types
		public static class Activity // TypeDefIndex: 19420
		{
			// Fields
			public static readonly int TABSWITCH; // 0x00
			public static readonly int FADEINLONG; // 0x04
			public static readonly int FADEINSHORT; // 0x08
			public static readonly int SHOW; // 0x0C
			public static readonly int LOCKED; // 0x10
			public static readonly int PAUSE_FADEIN; // 0x14
			public static readonly int PAUSE_FADEOUT; // 0x18
			public static readonly int ACTION_POS; // 0x1C
			public static readonly int COMBO; // 0x20
			public static readonly int MISS; // 0x24
			public static readonly int PERFECT; // 0x28

			// Constructors
			static Activity() {} // 0x000000018485D460-0x000000018485D630
		}

		public static class MainPage // TypeDefIndex: 19421
		{
			// Fields
			public static readonly int REFRESH_DESC; // 0x00
			public static readonly int SHOW_TITLE; // 0x04
			public static readonly int MOVE; // 0x08

			// Constructors
			static MainPage() {} // 0x000000018485E850-0x000000018485E910
		}

		public static class DungeonChallenge // TypeDefIndex: 19422
		{
			// Fields
			public static readonly int START_FADE_IN; // 0x00
			public static readonly int COMPLETE_FADE_IN; // 0x04
			public static readonly int FAIL_FADE_IN; // 0x08
			public static readonly int CAN_SHOW_PROGRESS; // 0x0C
			public static readonly int HIDE_PROGRESS; // 0x10
			public static readonly int PROGRESS_UPDATE; // 0x14
			public static readonly int COMPLETE_NO_HINT; // 0x18

			// Constructors
			static DungeonChallenge() {} // 0x000000018485DB30-0x000000018485DC70
		}

		public static class DungeonSettle // TypeDefIndex: 19423
		{
			// Fields
			public static readonly int ACTIVE; // 0x00
			public static readonly int FIRST_ACTIVE; // 0x04

			// Constructors
			static DungeonSettle() {} // 0x000000018485EA50-0x000000018485EAF0
		}

		public static class CountDown // TypeDefIndex: 19424
		{
			// Fields
			public static readonly int ADD_TIME; // 0x00
			public static readonly int FLASH; // 0x04
			public static readonly int COUNT_DOWN; // 0x08

			// Constructors
			static CountDown() {} // 0x000000018485D630-0x000000018485D6F0
		}

		public static class MailOverview // TypeDefIndex: 19425
		{
			// Fields
			public static readonly int TOGGLE_BOOL; // 0x00
			public static readonly int DETAIL_FADE_IN; // 0x04

			// Constructors
			static MailOverview() {} // 0x000000018485DDA0-0x000000018485DE40
		}

		public static class BlockController // TypeDefIndex: 19426
		{
			// Fields
			public static readonly int LIFT_SPEED; // 0x00
			public static readonly int IS_END; // 0x04
			public static readonly int IS_LIFT; // 0x08
			public static readonly int RESTART; // 0x0C

			// Constructors
			static BlockController() {} // 0x000000018485CF60-0x000000018485D040
		}

		public static class EquipOverview // TypeDefIndex: 19427
		{
			// Fields
			public static readonly int STAR_UP; // 0x00
			public static readonly int ITEM_TIP; // 0x04
			public static readonly int AWAKEN; // 0x08
			public static readonly int LEVEL_UP; // 0x0C
			public static readonly int ITEM_FADE_IN; // 0x10
			public static readonly int ITEM_FADE_OUT; // 0x14
			public static readonly int ACTHIN_HIDE; // 0x18

			// Constructors
			static EquipOverview() {} // 0x000000018485F3B0-0x000000018485F4F0
		}

		public static class Character // TypeDefIndex: 19428
		{
			// Fields
			public static readonly int TALENT_DETAIL_FADE_IN; // 0x00
			public static readonly int TALENT_DETAIL_FADE_OUT; // 0x04
			public static readonly int SKILL_DETAIL_FADE_IN; // 0x08
			public static readonly int SKILL_DETAIL_FADE_OUT; // 0x0C
			public static readonly int TALENT_TAB; // 0x10
			public static readonly int TAB_BACK; // 0x14
			public static readonly int WEAPON_TAB; // 0x18
			public static readonly int RELIC_TAB; // 0x1C
			public static readonly int SKILL_TAB; // 0x20
			public static readonly int FETTERS_TAB; // 0x24
			public static readonly int MENU_HIDE; // 0x28
			public static readonly int FLY_CLOAK; // 0x2C
			public static readonly int SKIN; // 0x30

			// Constructors
			static Character() {} // 0x0000000184860140-0x0000000184860350
		}

		public static class CookingQTE // TypeDefIndex: 19429
		{
			// Fields
			public static readonly int SEL_ACTION; // 0x00
			public static readonly int QTE_ACTION; // 0x04
			public static readonly int PERFORM_1; // 0x08
			public static readonly int PERFORM_2; // 0x0C
			public static readonly int PERFORM_3; // 0x10
			public static readonly int PERFORM_4; // 0x14
			public static readonly int PERFORM_END; // 0x18
			public static readonly int SETTLEMENT; // 0x1C
			public static readonly int SETTLEMENT_FADE_OUT; // 0x20

			// Constructors
			static CookingQTE() {} // 0x000000018485F040-0x000000018485F1C0
		}

		public static class LoginScene // TypeDefIndex: 19430
		{
			// Fields
			public static readonly int OPENING; // 0x00
			public static readonly int LIFT; // 0x04

			// Constructors
			static LoginScene() {} // 0x000000018485E9B0-0x000000018485EA50
		}

		public static class Bag // TypeDefIndex: 19431
		{
			// Fields
			public static readonly int OPEN_TAB_DEFAULT; // 0x00
			public static readonly int OPEN_TAB_NO_ITEM; // 0x04
			public static readonly int TAB_FADE_IN; // 0x08
			public static readonly int TAB_NO_ITEM; // 0x0C
			public static readonly int DESTROY_ITEM_CHECK; // 0x10
			public static readonly int DESTROY_ITEM_HAS_MATERIAL_BACK; // 0x14

			// Constructors
			static Bag() {} // 0x000000018485FD50-0x000000018485FE70
		}

		public static class RepairSkyHarp // TypeDefIndex: 19432
		{
			// Fields
			public static readonly int REPAIR_1_0; // 0x00
			public static readonly int REPAIR_2_0; // 0x04
			public static readonly int REPAIR_1; // 0x08
			public static readonly int REPAIR_2; // 0x0C

			// Constructors
			static RepairSkyHarp() {} // 0x000000018485EDA0-0x000000018485EE80
		}

		public static class Map // TypeDefIndex: 19433
		{
			// Fields
			public static readonly int MAP_TAG_SHOW; // 0x00
			public static readonly int MAP_TAG_HIDE; // 0x04
			public static readonly int MAP_TAG_SELECT; // 0x08

			// Constructors
			static Map() {} // 0x000000018485D790-0x000000018485D850
		}

		public static class ForgingPage // TypeDefIndex: 19434
		{
			// Fields
			public static readonly int FORGING_STATE; // 0x00
			public static readonly int FORGING_CLICK; // 0x04

			// Constructors
			static ForgingPage() {} // 0x000000018485EE80-0x000000018485EF20
		}

		public static class HomeWorldBuildPage // TypeDefIndex: 19435
		{
			// Fields
			public static readonly int BUILD_STATE; // 0x00
			public static readonly int BUILD_CLICK; // 0x04
			public static readonly int SETTLEMENT; // 0x08
			public static readonly int SETTLEMENT_FADE_OUT; // 0x0C

			// Constructors
			static HomeWorldBuildPage() {} // 0x000000018485FFF0-0x00000001848600D0
		}

		public static class TeamPanel // TypeDefIndex: 19436
		{
			// Fields
			public static readonly int LEVELUP_ICONSLOT; // 0x00

			// Constructors
			static TeamPanel() {} // 0x00000001848600D0-0x0000000184860140
		}

		public static class AdventureHandbookPage // TypeDefIndex: 19437
		{
			// Fields
			public static readonly int TAB_TRAVELS; // 0x00
			public static readonly int TAB_EVENT; // 0x04
			public static readonly int TAB_DUNGEON; // 0x08
			public static readonly int TAB_MONSTER; // 0x0C
			public static readonly int MONSTER_DETAIL; // 0x10
			public static readonly int NEW_TRAVELS; // 0x14
			public static readonly int NO_TRAVELS; // 0x18

			// Constructors
			static AdventureHandbookPage() {} // 0x000000018485FB30-0x000000018485FC70
		}

		public static class MessagePushPage // TypeDefIndex: 19438
		{
			// Fields
			public static readonly int TAB_TO_FINISH; // 0x00
			public static readonly int TAB_TO_DISABLE; // 0x04
			public static readonly int TAB_TO_FINISH_SELECTED; // 0x08
			public static readonly int TAB_TO_NORMAL; // 0x0C

			// Constructors
			static MessagePushPage() {} // 0x000000018485D1E0-0x000000018485D2C0
		}

		public static class ActivitySeaLampPage // TypeDefIndex: 19439
		{
			// Fields
			public static readonly int TAB_SWITCH; // 0x00
			public static readonly int SHOW_BANNER; // 0x04
			public static readonly int SHOW_BG; // 0x08
			public static readonly int STORY_SWITCH_NEXT; // 0x0C
			public static readonly int STORY_SWITCH_PREV; // 0x10

			// Constructors
			static ActivitySeaLampPage() {} // 0x000000018485F4F0-0x000000018485F5F0
		}

		public static class TowerPage // TypeDefIndex: 19440
		{
			// Fields
			public static readonly int TAB_SWITCH; // 0x00
			public static readonly int SHOW_ACTION; // 0x04
			public static readonly int SWITCH; // 0x08
			public static readonly int FINISH; // 0x0C
			public static readonly int BTN_SWITCH_PREV; // 0x10
			public static readonly int BTN_SWITCH_NEXT; // 0x14
			public static readonly int HIGHLIGHT; // 0x18
			public static readonly int UNLOCK_HL; // 0x1C
			public static readonly int BLACK_HOLE; // 0x20

			// Constructors
			static TowerPage() {} // 0x000000018485F9B0-0x000000018485FB30
		}

		public static class BattlePassPage // TypeDefIndex: 19441
		{
			// Fields
			public static readonly int SHOW_CARD; // 0x00
			public static readonly int TAB_FADE_IN; // 0x04
			public static readonly int ADD_EXP; // 0x08
			public static readonly int UNLOCK; // 0x0C

			// Constructors
			static BattlePassPage() {} // 0x000000018485D380-0x000000018485D460
		}

		public static class ReunionPage // TypeDefIndex: 19442
		{
			// Fields
			public static readonly int TAB_SIGNIN; // 0x00
			public static readonly int TAB_TASK; // 0x04
			public static readonly int TAB_PRIVILEGE; // 0x08

			// Constructors
			static ReunionPage() {} // 0x000000018485F8F0-0x000000018485F9B0
		}

		public static class ScenePlay // TypeDefIndex: 19443
		{
			// Fields
			public static readonly int BLUE_OR_RED; // 0x00
			public static readonly int CARD_FADEIN; // 0x04
			public static readonly int SHOW_CARD; // 0x08
			public static readonly int INTERRUPT; // 0x0C

			// Constructors
			static ScenePlay() {} // 0x000000018485CD80-0x000000018485CE60
		}

		public static class ElementChargeBar // TypeDefIndex: 19444
		{
			// Fields
			public static readonly int CRUCIBLE; // 0x00
			public static readonly int CRUCIBLE_ADD; // 0x04
			public static readonly int ACTIVITY_ASTER; // 0x08
			public static readonly int ACTIVITY_ASTER_CUTDOWN; // 0x0C
			public static readonly int ACTIVITY_ASTER_ADD; // 0x10
			public static readonly int ACTIVITY_FLEURFAIR_ENERGYVALUE; // 0x14
			public static readonly int ACTIVITY_FLEURFAIR_CUTDOWN; // 0x18
			public static readonly int Element_Fire; // 0x1C

			// Constructors
			static ElementChargeBar() {} // 0x000000018485F6D0-0x000000018485F830
		}

		public static class TeamResonance // TypeDefIndex: 19445
		{
			// Fields
			public static readonly int ROW; // 0x00

			// Constructors
			static TeamResonance() {} // 0x000000018485ED30-0x000000018485EDA0
		}

		public static class MPPlay // TypeDefIndex: 19446
		{
			// Fields
			public static readonly int STATUS_SWITCH; // 0x00
			public static readonly int OPEN_CHEST; // 0x04
			public static readonly int IS_CHEST_OPENABLE; // 0x08

			// Constructors
			static MPPlay() {} // 0x000000018485F830-0x000000018485F8F0
		}

		public static class TalkDialog // TypeDefIndex: 19447
		{
			// Fields
			public static readonly int SHOW_TIPS; // 0x00
			public static readonly int COOP_NOTICE; // 0x04
			public static readonly int CONFIDENCE; // 0x08
			public static readonly int COOP_SELECT_FADE_IN; // 0x0C

			// Constructors
			static TalkDialog() {} // 0x000000018485FC70-0x000000018485FD50
		}

		public static class Codex // TypeDefIndex: 19448
		{
			// Fields
			public static readonly int OPEN; // 0x00
			public static readonly int FADE_IN; // 0x04
			public static readonly int FADE_OUT; // 0x08
			public static readonly int CLICK; // 0x0C
			public static readonly int SWIPE_SPEED; // 0x10
			public static readonly int SWIPE_RIGHT; // 0x14
			public static readonly int SWIPE_LEFT; // 0x18
			public static readonly int PREVIEW; // 0x1C
			public static readonly int PREVIEW_FADE_OUT; // 0x20
			public static readonly int LOCK; // 0x24

			// Constructors
			static Codex() {} // 0x000000018485D980-0x000000018485DB30
		}

		public static class Reputation // TypeDefIndex: 19449
		{
			// Fields
			public static readonly int SWITCH_PREV; // 0x00
			public static readonly int SWITCH_NEXT; // 0x04
			public static readonly int TAB_SWITCH; // 0x08
			public static readonly int ADD_EXP; // 0x0C

			// Constructors
			static Reputation() {} // 0x000000018485F5F0-0x000000018485F6D0
		}

		public static class EffigyChallenge // TypeDefIndex: 19450
		{
			// Fields
			public static readonly int FADEIN_TAB0; // 0x00
			public static readonly int FADEIN_TAB1; // 0x04

			// Constructors
			static EffigyChallenge() {} // 0x000000018485E910-0x000000018485E9B0
		}

		public static class ActivityTreasureHunt // TypeDefIndex: 19451
		{
			// Fields
			public static readonly int CHEST_LOCKED; // 0x00
			public static readonly int CHEST_NORMAL; // 0x04
			public static readonly int CHEST_OPEN; // 0x08
			public static readonly int BATTLE_ZONE; // 0x0C

			// Constructors
			static ActivityTreasureHunt() {} // 0x000000018485EAF0-0x000000018485EBD0
		}

		public static class BlessingPhoto // TypeDefIndex: 19452
		{
			// Fields
			public static readonly int PHOTO_FADE_IN; // 0x00
			public static readonly int PHOTO_FADE_OUT; // 0x04
			public static readonly int FOCUS_FADE_IN; // 0x08
			public static readonly int FOCUS_FADE_OUT; // 0x0C
			public static readonly int SHOW_TIPS; // 0x10

			// Constructors
			static BlessingPhoto() {} // 0x000000018485CE60-0x000000018485CF60
		}

		public static class TheatreMechanicus // TypeDefIndex: 19453
		{
			// Fields
			public static readonly int BUFF_SELECT; // 0x00
			public static readonly int VICTORY_BOOL; // 0x04
			public static readonly int TRAIL_BOOL; // 0x08
			public static readonly int LOCK; // 0x0C
			public static readonly int EXTEND_ADD; // 0x10
			public static readonly int EXTEND_MINUS; // 0x14
			public static readonly int SUIT1; // 0x18
			public static readonly int SUIT2; // 0x1C
			public static readonly int IS_SELF; // 0x20
			public static readonly int OWNER_SKIP; // 0x24
			public static readonly int PLAYER1_SKIP; // 0x28
			public static readonly int PLAYER2_SKIP; // 0x2C

			// Constructors
			static TheatreMechanicus() {} // 0x000000018485F1C0-0x000000018485F3B0
		}

		public static class LanternRite // TypeDefIndex: 19454
		{
			// Fields
			public static readonly int NEXT; // 0x00
			public static readonly int LOCK; // 0x04
			public static readonly int P2_FADEIN; // 0x08
			public static readonly int P2_ONCE_FADEIN; // 0x0C
			public static readonly int DOING; // 0x10

			// Constructors
			static LanternRite() {} // 0x000000018485D040-0x000000018485D140
		}

		public static class CoopPage // TypeDefIndex: 19455
		{
			// Fields
			public static readonly int OPEN_CARD; // 0x00
			public static readonly int POINT_STATE; // 0x04
			public static readonly int POINT_CHECK_AGAIN; // 0x08
			public static readonly int CURSOR_HIDE; // 0x0C
			public static readonly int POINY_HIDE; // 0x10
			public static readonly int SHOW_CG_TYPE; // 0x14

			// Constructors
			static CoopPage() {} // 0x000000018485EF20-0x000000018485F040
		}

		public static class FleurFairBalloon // TypeDefIndex: 19456
		{
			// Fields
			public static readonly int HINTS_ADD; // 0x00
			public static readonly int IS_ROTATE; // 0x04

			// Constructors
			static FleurFairBalloon() {} // 0x000000018485D140-0x000000018485D1E0
		}

		public static class FleurFairDungeon // TypeDefIndex: 19457
		{
			// Fields
			public static readonly int STATE_BOOL; // 0x00
			public static readonly int SHOW_CARD; // 0x04
			public static readonly int SHOW_REWARD; // 0x08
			public static readonly int SHOW_REWARD_CLICK; // 0x0C
			public static readonly int ACTIVATED; // 0x10
			public static readonly int ACTIVATED_SHOW; // 0x14
			public static readonly int DUNGEON_BUFF; // 0x18
			public static readonly int DUNGEON_RANDOM; // 0x1C
			public static readonly int DUNGEON_CONFIRM; // 0x20

			// Constructors
			static FleurFairDungeon() {} // 0x000000018485FE70-0x000000018485FFF0
		}

		public static class Homeworld // TypeDefIndex: 19458
		{
			// Fields
			public static readonly int NEW_STAGE; // 0x00
			public static readonly int NO_STAGE; // 0x04

			// Constructors
			static Homeworld() {} // 0x000000018485D6F0-0x000000018485D790
		}

		public static class HomeworldPosition // TypeDefIndex: 19459
		{
			// Fields
			public static readonly int GrpPicFadeIn; // 0x00
			public static readonly int GrpPicFadeOut; // 0x04
			public static readonly int GrpPicSwitch; // 0x08

			// Constructors
			static HomeworldPosition() {} // 0x000000018485D2C0-0x000000018485D380
		}

		public static class HideAndSeek // TypeDefIndex: 19460
		{
			// Fields
			public static readonly int ICON_ACTIVE; // 0x00
			public static readonly int IS_CAMP_HIDE; // 0x04
			public static readonly int FADE_IN_GRPCONTENT; // 0x08
			public static readonly int CARD_FADEIN; // 0x0C
			public static readonly int REWARD; // 0x10
			public static readonly int CAMP_HIDE; // 0x14
			public static readonly int FAILURE; // 0x18
			public static readonly int WIN; // 0x1C

			// Constructors
			static HideAndSeek() {} // 0x000000018485EBD0-0x000000018485ED30
		}

		// Constructors
		static UI() {} // 0x000000018485DE40-0x000000018485E850
	}

	// Constructors
	static AnimatorParamsData() {} // 0x000000018486B870-0x000000018486D300
}

