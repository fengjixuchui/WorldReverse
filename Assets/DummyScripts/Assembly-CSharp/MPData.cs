/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MPData // TypeDefIndex: 21694
{
	// Fields
	public const short ANIMATOR_STATE_SYNC_SELF_TRANSITION_ENCODED_NORMALIZED_TIME = -32768; // Metadata: 0x00AFFC2C
	public const float SYNC_FIRST_ENTER_THRESHOLD = 0.5f; // Metadata: 0x00AFFC2E
	public const float REMOTE_RUSH_MOVE_POS_THRESHOLD = 0.5f; // Metadata: 0x00AFFC32
	public const float ABILITY_INVOKE_FLUSH_INTERVAL = 0.1f; // Metadata: 0x00AFFC36
	public static HashSet<System.Type> MPTotallyLocalActionWhiteList; // 0x00
	public static HashSet<System.Type> MPSyncAbilityStateActionWhiteList; // 0x08
	public static HashSet<System.Type> MPServerInvalidModifierActionBlackList; // 0x10
	public static HashSet<System.Type> MPSendInvokeEntryImmediatelyList; // 0x18
	public static HashSet<System.Type> MPSinglePlayerSyncAbilityActionWhiteList; // 0x20
	public static HashSet<string> MPSinglePlayerNotSyncModfiers; // 0x28
	public static Dictionary<System.Type, int> MixinEventHandlePriorityDiction; // 0x30
	public static int BaseMixinEventHandlePriority; // 0x38

	// Constructors
	static MPData() {} // 0x00000001831F2B90-0x00000001831F38F0
}

