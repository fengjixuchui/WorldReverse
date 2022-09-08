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

public static class Formula // TypeDefIndex: 20523
{
	// Fields
	public const float ENBREAK_HALT_TIME_ADD = 0.06f; // Metadata: 0x00AFDB94

	// Methods
	// [XID] // 0x0000000189947060-0x0000000189947080
	public static void ResolveAttackResultByAttacker(BaseEntity attackerEntity, BaseEntity attackeeEntity, AttackResult attackResult) {} // 0x0000000185690390-0x00000001856905C0
	// [XID] // 0x000000018994E6C0-0x000000018994E6E0
	public static void ResolveAttackResultByAttackee(BaseEntity attackerEntity, BaseEntity attackeeEntity, AttackResult attackResult) {} // 0x000000018568FF50-0x0000000185690050
	// [XID] // 0x0000000189955CE0-0x0000000189955D00
	private static void CalcAttackResult(CombatProperty attackCombatProperty, CombatProperty defenseCombatProperty, AttackResult attackResult, BaseEntity attackerEntity, BaseEntity attackeeEntity) {} // 0x000000018568F2A0-0x000000018568FF50
	// [XID] // 0x000000018995D7C0-0x000000018995D7E0
	public static AttackResult.EndureBreakLevel CalcEndureBreak(uint attackerRuntimeID, BaseEntity attackeeEntity, AttackResult attackResult) => default; // 0x0000000185690DF0-0x00000001856912B0
	// [XID] // 0x0000000189964EB0-0x0000000189964ED0
	public static float CalcWeight(float weight, LCAbilityState abilityState) => default; // 0x0000000185690050-0x00000001856901B0
	// [XID] // 0x000000018965FF90-0x000000018965FFB0
	public static void CalcHitEffect(BaseEntity attackeeEntity, LCBaseCombat attackeeCombat, uint attackerID, AttackResult attackResult, bool isInAir, float groundDist, bool isInClimb) {} // 0x000000018568EAD0-0x000000018568F2A0
	// [XID] // 0x0000000189BC24A0-0x0000000189BC24C0
	public static float CalcTargetForwardToSelfAngle(BaseEntity target, BaseEntity self, bool isXZ) => default; // 0x0000000185690BA0-0x0000000185690DF0
	// [XID] // 0x000000018997B6B0-0x000000018997B6D0
	public static float CalcSelfForwardToTargetAngle(BaseEntity target, BaseEntity self, bool isXZ) => default; // 0x000000018568E880-0x000000018568EAD0
	// [XID] // 0x0000000189983150-0x0000000189983170
	public static float CalcHitEntityAngle(BaseEntity attackee, BaseEntity attacker, bool isXZ) => default; // 0x00000001856908B0-0x0000000185690990
	// [XID] // 0x000000018998A8A0-0x000000018998A8C0
	public static float CalcHitForceAngle(BaseEntity attackee, Vector3 hitDir, bool isXZ) => default; // 0x0000000185690990-0x0000000185690BA0
	// [XID] // 0x00000001899FC280-0x00000001899FC2A0
	public static void CalcHitHaltTime(BaseEntity attackeeEntity, AttackResult attackResult) {} // 0x00000001856905C0-0x0000000185690700
	// [XID] // 0x0000000189999F10-0x0000000189999F30
	public static void CalcAbilityFormula(AbilityFormula type, float inputValue, out float outputValue) {
		outputValue = default;
	} // 0x00000001856901B0-0x00000001856902E0
	// [XID] // 0x00000001899A1590-0x00000001899A15B0
	public static int GenerateCriticHash(uint attackerRuntimeID, uint attackeeRuntimeID, uint timeStamp, Vector3 hitPosition, uint attenuationCound) => default; // 0x0000000185690700-0x00000001856908B0
	// [XID] // 0x00000001899A8F80-0x00000001899A8FA0
	public static uint GenerateRandomNumber(uint seed, uint range) => default; // 0x00000001856912B0-0x0000000185691370
	// [XID] // 0x00000001899B0A30-0x00000001899B0A50
	public static uint XorShiftRNG32(uint seed) => default; // 0x00000001856902E0-0x0000000185690390
}

