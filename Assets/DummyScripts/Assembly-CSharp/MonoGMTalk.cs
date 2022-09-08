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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MonoGMTalk // TypeDefIndex: 27780
{
	// Fields
	private static uint _progress; // 0x00
	private static bool _stoped; // 0x04

	// Constructors
	static MonoGMTalk() {} // 0x000000018113F0F0-0x000000018113F150

	// Methods
	[DebuggerHidden] // 0x00000001895FF210-0x00000001895FF250
	// [XID] // 0x00000001895FF210-0x00000001895FF250
	private static IEnumerator MoveForward() => default; // 0x0000000181128CA0-0x0000000181128D50
	// [XID] // 0x0000000189609C50-0x0000000189609C70
	public static void ExecuteCommand(string content) {} // 0x00000001811259F0-0x0000000181125C40
	// [XID] // 0x0000000189611440-0x0000000189611460
	private static bool CheckGadgetPlay(string command) => default; // 0x0000000181126790-0x0000000181127A50
	// [XID] // 0x0000000189618E50-0x0000000189618E70
	private static void DebugPlayMusicCamera() {} // 0x0000000181125150-0x00000001811254A0
	// [XID] // 0x00000001896202F0-0x0000000189620310
	private static void DebugStopMusicCamera() {} // 0x000000018113D9E0-0x000000018113DAF0
	// [XID] // 0x0000000189627770-0x0000000189627790
	private static void CheakCommand(string command) {} // 0x00000001811292C0-0x000000018113D790
	// [XID] // 0x000000018962F230-0x000000018962F250
	private static void GenerateNPCPoses(int num, float rangeRadius, float npcRadius, Vector2[] pos) {} // 0x0000000181128450-0x00000001811287D0
	// [XID] // 0x0000000189636BF0-0x0000000189636C10
	private static float ComputeCurveValue(float src, GrowCurveType type, MonsterCurveExcelConfig curve) => default; // 0x0000000181125C40-0x0000000181125DF0
	// [XID] // 0x000000018963E160-0x000000018963E180
	private static float ComputeFinalValue(float src, FightPropType type, MonsterExcelConfig config, MonsterCurveExcelConfig curve) => default; // 0x0000000181126080-0x0000000181126250
	// [XID] // 0x0000000189645AF0-0x0000000189645B10
	public static void CreateTestMonster(uint monsterID, uint level, Vector3 initPos, float yaw, float scale = 1f /* Metadata: 0x00B0CDC8 */, bool isElite = false /* Metadata: 0x00B0CDCC */, List<uint> affixList = null, LCCharacterCombat.SummonInfo summonInfo = null, uint ownerID = 0 /* Metadata: 0x00B0CDCD */) {} // 0x000000018113E820-0x000000018113EF90
	// [XID] // 0x000000018964D300-0x000000018964D320
	public static uint CreateLocalTestMonster(uint monsterID, uint level, Vector3 initPos, float yaw, float scale = 1f /* Metadata: 0x00B0CDD1 */, bool isElite = false /* Metadata: 0x00B0CDD5 */, List<uint> affixList = null, LCCharacterCombat.SummonInfo summonInfo = null, uint ownerID = 0 /* Metadata: 0x00B0CDD6 */) => default; // 0x000000018113DC80-0x000000018113E820
	// [XID] // 0x0000000189654BA0-0x0000000189654BC0
	public static void CreateTestNpc(uint configID, Vector3 initPos, float yaw) {} // 0x0000000181128D50-0x0000000181128F40
	// [XID] // 0x000000018965C170-0x000000018965C190
	public static void CrateTestNpc9001() {} // 0x00000001811287D0-0x0000000181128C00
	// [XID] // 0x00000001896637F0-0x0000000189663810
	public static void CrateTestNpc9002() {} // 0x0000000181124BB0-0x0000000181124E00
	// [XID] // 0x000000018966B170-0x000000018966B190
	public static void CrateTestNpc9003() {} // 0x000000018113D790-0x000000018113D9E0
	// [XID] // 0x0000000189672D70-0x0000000189672D90
	public static void CreateTestGadget(uint configID, Vector3 initPos, float yaw, float scale = 1f /* Metadata: 0x00B0CDDA */) {} // 0x0000000181127B50-0x00000001811280F0
	// [XID] // 0x000000018967A430-0x000000018967A450
	public static void CreateTestItem(uint configID, Vector3 initPos, float yaw, float scale = 1f /* Metadata: 0x00B0CDDE */) {} // 0x0000000181125760-0x0000000181125930
	// [XID] // 0x0000000189681C80-0x0000000189681CA0
	public static void KillAllMonster() {} // 0x0000000181128F40-0x0000000181129270
	// [XID] // 0x00000001896896F0-0x0000000189689710
	public static void KillSelf() {} // 0x00000001811249A0-0x0000000181124BB0
	// [XID] // 0x0000000189691390-0x00000001896913B0
	public static void ChangeSkillNoCD() {} // 0x0000000181126250-0x0000000181126420
	// [XID] // 0x0000000189698B40-0x0000000189698B60
	public static void SwitchInfiniteStamina() {} // 0x0000000181124E00-0x0000000181125010
	// [XID] // 0x000000018969FF90-0x000000018969FFB0
	public static void LeaveCombat() {} // 0x0000000181127A50-0x0000000181127B50
	// [XID] // 0x00000001896A72D0-0x00000001896A72F0
	public static void LCAISwitch(bool isOn) {} // 0x000000018113EF90-0x000000018113F0F0
	// [XID] // 0x00000001896AE7D0-0x00000001896AE7F0
	public static void PlayerInvisibleSwitch(bool isOn) {} // 0x0000000181126630-0x0000000181126790
	// [XID] // 0x00000001896B5FF0-0x00000001896B6010
	public static GameObject GetRockBugObj() => default; // 0x00000001811254A0-0x0000000181125760
	// [XID] // 0x00000001896BD1B0-0x00000001896BD1D0
	public static void InvincibleSwitch(uint grp, bool isOn) {} // 0x00000001811280F0-0x0000000181128450
}

