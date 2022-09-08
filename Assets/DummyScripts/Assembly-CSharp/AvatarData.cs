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
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AvatarData // TypeDefIndex: 19404
{
	// Fields
	public static int AVATAR_IDLE_TAG; // 0x00
	public static int AVATAR_RUN_TO_IDLE_TAG; // 0x04
	public static int AVATAR_RUN_TO_WALK_TAG; // 0x08
	public static int AVATAR_WALK_TAG; // 0x0C
	public static int AVATAR_WALK_TO_IDLE_TAG; // 0x10
	public static int AVATAR_RUN_TAG; // 0x14
	public static int AVATAR_SPRINT_TAG; // 0x18
	public static int AVATAR_CLIMB_TAG; // 0x1C
	public static int AVATAR_CLIMB_IDLE_TAG; // 0x20
	public static int AVATAR_JUMP_TAG; // 0x24
	public static int AVATAR_SLIP_LIT_TAG; // 0x28
	public static int AVATAR_SLIP_FACE_WALL_TAG; // 0x2C
	public static int AVATAR_SLIP_BACK_WALL_TAG; // 0x30
	public static int AVATAR_CLIMB_JUMP_TAG; // 0x34
	public static int AVATAR_GO_UPSTAIRS_TAG; // 0x38
	public static int AVATAR_RUNNING_TURN_TAG; // 0x3C
	public static int AVATAR_DROP_DOWN_LIT_TAG; // 0x40
	public static int AVATAR_DROP_DOWN_TAG; // 0x44
	public static int AVATAR_FALL_ON_GROUND_TAG; // 0x48
	public static int AVATAR_FALL_ON_GROUND_RUN_TAG; // 0x4C
	public static int AVATAR_FALL_ON_GROUND_SPRINT_TAG; // 0x50
	public static int AVATAR_JUMP_UP_WALL_FOR_STANDBY_TAG; // 0x54
	public static int AVATAR_JUMP_UP_WALL_READY_TAG; // 0x58
	public static int AVATAR_SPRINT_TO_IDLE_TAG; // 0x5C
	public static int AVATAR_SPRINT_TO_RUN_TAG; // 0x60
	public static int AVATAR_RUN_TO_SPRINT_TAG; // 0x64
	public static int AVATAR_BACK_STEP_TAG; // 0x68
	public static int AVATAR_PUT_AWAY_TAG; // 0x6C
	public static int AVATAR_PUT_AWAY_OVER_TAG; // 0x70
	public static int AVATAR_ANIMATOR_SLIPPING; // 0x74
	public static int AVATAR_ANIMATOR_MOTIONFLAG; // 0x78
	public static int AVATAR_ANIMATOR_CLIMBVER; // 0x7C
	public static int AVATAR_ANIMATOR_MOVEVECTORMAG; // 0x80
	public static int AVATAR_ANIMATOR_FACETOANGLE; // 0x84
	public static int AVATAR_FLY_TAG; // 0x88
	public static int AVATAR_FLY_START_TAG; // 0x8C
	public static int AVATAR_CLIMB_DOWN_TO_GROUND_TAG; // 0x90
	public static int AVATAR_SWIM_IDLE_TAG; // 0x94
	public static int AVATAR_SWIM_MOVE_TAG; // 0x98
	public static int AVATAR_SWIM_DASH_TAG; // 0x9C
	public static int AVATAR_SWIM_JUMP_TAG; // 0xA0
	public static int AVATAR_SWIM_JUMP_DROP_TAG; // 0xA4
	public static int AVATAR_SWIM_JUMP_TO_WATER_TAG; // 0xA8
	public static int AVATAR_LADDER_IDLE_TAG; // 0xAC
	public static int AVATAR_LADDER_MOVE_TAG; // 0xB0
	public static int AVATAR_LADDER_SLIP_TAG; // 0xB4
	public static int AVATAR_LADDER_SLIP_STOP_TAG; // 0xB8
	public static int AVATAR_STANDBY_TO_CLIMB_TAG; // 0xBC
	public static int AVATAR_TURN_DIR_TAG; // 0xC0
	public static int AVATAR_HIT_AIR_TAG; // 0xC4
	public static int AVATAR_HIT_H_TAG; // 0xC8
	public static int AVATAR_HIT_L_TAG; // 0xCC
	public static int AVATAR_SKILL_TAG; // 0xD0
	public static int AVATAR_NORMAL_ATTACK_TAG; // 0xD4
	public static int AVATAR_ATTACK_TAG; // 0xD8
	public static int AVATAR_MOVE_ATTACK_TAG; // 0xDC
	public static int AVATAR_AIR_ATTACK_TAG; // 0xE0
	public static int AVATAR_TAKE_PHOTOS_TAG; // 0xE4
	public static int AVATAR_CHANNEL_TAG; // 0xE8
	public static int AVATAR_MUSIC_GAME_TAG; // 0xEC
	public static int AVATAR_COMMON_NEED_SYNC_ANI_TAG; // 0xF0
	public static int AVATAR_CROUCH_IDLE_TAG; // 0xF4
	public static int AVATAR_CROUCH_MOVE_TAG; // 0xF8
	public static int AVATAR_CROUCH_ROLL_TAG; // 0xFC
	public static int AVATAR_DIE_TAG; // 0x100
	public static int AVATAR_PERFORM_SIT_DOWN_TAG; // 0x104
	public static int AVATAR_PERFORM_SIT_LOOP_TAG; // 0x108
	public static int AVATAR_PERFORM_SIT_UP_TAG; // 0x10C
	public static int AVATAR_PERFORM_STANDBY_SHOW_TAG; // 0x110
	public static int AVATAR_SUPPORT_TIME_DELAY; // 0x114
	public static HashSet<int>[] AVATAR_TAG_GROUPS; // 0x118
	private static Dictionary<ulong, ConfigAvatar> _avatarConfigs; // 0x120
	private static Dictionary<ulong, AvatarConfigPage> _avatarConfigPages; // 0x128

	// Nested types
	public enum AvatarTagGroup // TypeDefIndex: 19405
	{
		NormalMove = 0,
		Jump = 1,
		Climb = 2,
		Fly = 3,
		Slip = 4,
		Swim = 5,
		Ladder = 6,
		Hit = 7,
		Skill = 8,
		Die = 9,
		Crouch = 10,
		Perform = 11,
		Drop = 12
	}

	public class AvatarConfigPage : EntityConfigPageBase // TypeDefIndex: 19406
	{
		// Fields
		private static SerializeBinHandler _serializeBin; // 0x00
		private static SerializeJsonHandler _serializeJson; // 0x08
		private Action<object, ulong> _onSerializedAsync; // 0x58

		// Constructors
		public AvatarConfigPage() {} // 0x0000000183E19D70-0x0000000183E19E20
		static AvatarConfigPage() {} // 0x0000000183E19C40-0x0000000183E19D70

		// Methods
		// [XID] // 0x0000000189B416B0-0x0000000189B416D0
		public override AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish) => default; // 0x0000000183E19900-0x0000000183E19A60
		// [XID] // 0x0000000189B49060-0x0000000189B49080
		protected static ConfigMetaConfig.PathHash[] GetAvatarRegistryPathes() => default; // 0x0000000183E19470-0x0000000183E19550
		// [XID] // 0x0000000189B50660-0x0000000189B50680
		public ConfigAvatar GetAvatarConfig() => default; // 0x0000000183E19B40-0x0000000183E19C40
		// [XID] // 0x0000000189B57FC0-0x0000000189B57FE0
		protected override void LoadEntityConfig(ulong configHash) {} // 0x0000000183E19550-0x0000000183E19600
		// [XID] // 0x0000000189B5F940-0x0000000189B5F960
		public override ulong GetConfigHash() => default; // 0x0000000183E19A60-0x0000000183E19B40
		// [XID] // 0x0000000189B670E0-0x0000000189B67100
		private void LoadAvatarConfig(ulong configHash) {} // 0x0000000183E19230-0x0000000183E19470
		// [XID] // 0x0000000189B6E2E0-0x0000000189B6E300
		private static object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFC869 */) => default; // 0x0000000183E197B0-0x0000000183E19900
		// [XID] // 0x0000000189B75B10-0x0000000189B75B30
		private static object SerializeJson(JSONNode node) => default; // 0x0000000183E19130-0x0000000183E19230
		// [XID] // 0x0000000189B7CF60-0x0000000189B7CF80
		private void OnSerialized(object obj, ulong path, bool async = false /* Metadata: 0x00AFC86D */) {} // 0x0000000183E19600-0x0000000183E197B0
		// [XID] // 0x0000000189B84DF0-0x0000000189B84E10
		private void OnSerializedAsync(object obj, ulong path) {} // 0x0000000183E18FE0-0x0000000183E19130
	}

	// Constructors
	static AvatarData() {} // 0x0000000183E2A9B0-0x0000000183E2AA80

	// Methods
	// [XID] // 0x0000000189AEC840-0x0000000189AEC860
	public static void Init() {} // 0x0000000183E283E0-0x0000000183E29C10
	// [XID] // 0x0000000189AF4250-0x0000000189AF4270
	public static void ReloadFromFile() {} // 0x0000000183E29C10-0x0000000183E29D20
	// [XID] // 0x0000000189AFBA80-0x0000000189AFBAA0
	public static void CheckClear() {} // 0x0000000183E27BB0-0x0000000183E28030
	[DebuggerHidden] // 0x0000000189B03130-0x0000000189B03170
	// [XID] // 0x0000000189B03130-0x0000000189B03170
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC831 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183E2A410-0x0000000183E2A550
	// [XID] // 0x0000000189B0D910-0x0000000189B0D930
	public static ConfigAvatar GetAvatarConfig(ulong configPathHash) => default; // 0x0000000183E2A780-0x0000000183E2A9B0
	// [XID] // 0x00000001899C0560-0x00000001899C0580
	public static void PreloadAvatarConfig(BaseEntity entity, ulong configPathHash) {} // 0x0000000183E2A550-0x0000000183E2A780
	// [XID] // 0x0000000189844B70-0x0000000189844B90
	public static AsyncJob PreloadAvatarConfigAsyncWithJob(BaseEntity entity, ulong configPathHash, Action preloadedCallback) => default; // 0x0000000183E28030-0x0000000183E283E0
	// [XID] // 0x000000018998E6B0-0x000000018998E6D0
	public static void ReleasePreloadAvatarConfig(BaseEntity entity, ulong configPathHash) {} // 0x0000000183E2A0F0-0x0000000183E2A410
	// [XID] // 0x0000000189B2AF00-0x0000000189B2AF20
	public static string Dump() => default; // 0x0000000183E29D20-0x0000000183E2A0F0
}

