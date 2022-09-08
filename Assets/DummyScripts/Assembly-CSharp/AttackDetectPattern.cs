/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AttackDetectPattern // TypeDefIndex: 31375
{
	// Fields
	private const int NON_ALLOC_CACHE_SIZE = 100; // Metadata: 0x00B125FE
	private const int SCENE_PROP_CACHE_SIZE = 100; // Metadata: 0x00B12602
	private static List<CollisionResult> realAttackResults; // 0x00
	private static List<CollisionResult> filteredRealAttackResults; // 0x08
	private static Queue<List<CollisionResult>> scenePropResultPool; // 0x10
	private static int scenePropResultListCount; // 0x18
	private static Dictionary<uint, int> filterCREntities; // 0x20

	// Nested types
	private enum AttackCirclePart // TypeDefIndex: 31376
	{
		UP = 0,
		MIDDLE = 1,
		DOWN = 2
	}

	// Constructors
	static AttackDetectPattern() {} // 0x00000001829121B0-0x0000000182912390

	// Methods
	// [XID] // 0x00000001899A7090-0x00000001899A70B0
	public static bool CheckCanHitScene(ConfigBaseAttackPattern config, bool checkWaterLayer, BaseEntity ownerEntity, BaseEntity targetEntity, ActorAbility instancedAbility, BaseEvent evt) => default; // 0x000000018290BDC0-0x000000018290C7B0
	// [XID] // 0x00000001899AE9C0-0x00000001899AE9E0
	public static BaseEntity CreateAttackPhysicalUnit(string animEventId, ConfigBaseAttackPattern attackPattern, Dictionary<TargetType, ConfigAttackInfo> attackInfoDic, BaseEntity ownerEntity, BaseEntity targetEntity, AbilityIdentifier? abilityIdentifier = default, bool ignoreCheckCanBeHitInMP = false /* Metadata: 0x00B125FA */, BaseEvent evt = null) => default; // 0x0000000182905390-0x0000000182906780
	// [XID] // 0x0000000189BC7DE0-0x0000000189BC7E00
	private static void FanCylinderDetectAttack(Vector3 initPos, Quaternion initRotation, BaseEntity ownerEntity, ConfigBaseAttackPattern attackPattern, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, ref AttackResultContext resultContext) {} // 0x0000000182906FA0-0x0000000182908BB0
	// [XID] // 0x00000001899BDA80-0x00000001899BDAA0
	private static void ShpereCollisionDetectAttack(Vector3 initPos, BaseEntity ownerEntity, ConfigBaseAttackPattern attackPattern, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, ref AttackResultContext resultContext) {} // 0x000000018290D2F0-0x000000018290DB90
	// [XID] // 0x00000001899C5180-0x00000001899C51A0
	private static void BoxCollisionDetectAttack(Vector3 initPos, Quaternion initRotation, BaseEntity ownerEntity, ConfigBaseAttackPattern attackPattern, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, ref AttackResultContext resultContext) {} // 0x000000018290DB90-0x000000018290EFD0
	// [XID] // 0x0000000189B46C60-0x0000000189B46C80
	private static void OnHittingScene(BaseEntity ownerEntity, Collider collider, Vector3 point, Vector3 direction, ConfigHitScene hitScene, ConfigAttackInfo attackInfo, string animEventId) {} // 0x0000000182910370-0x00000001829107D0
	// [XID] // 0x00000001899D3F70-0x00000001899D3F90
	private static void HandleSceneHitbox(BaseEntity ownerEntity, ConfigHitScene hitScene, ConfigAttackInfo attackInfo, string animEventId, List<CollisionResult> collisionResults) {} // 0x0000000182909C50-0x0000000182909EA0
	// [XID] // 0x00000001899DB4E0-0x00000001899DB500
	private static void FilterCollisionResults(ConfigBaseAttackPattern attackPattern, ConfigAttackInfo attackInfo, Vector3 centerPoint, List<CollisionResult> collisionResults) {} // 0x000000018290C7B0-0x000000018290D2F0
	// [XID] // 0x0000000189B91510-0x0000000189B91530
	private static bool IsElementTypeValidForSceneProp(ElementType attackElementType) => default; // 0x00000001829098F0-0x0000000182909990
	// [XID] // 0x00000001899EA2B0-0x00000001899EA2D0
	private static void DoAttackOnCollisionResults(ref AttackResultContext resultContext, ConfigBaseAttackPattern attackPattern, Dictionary<TargetType, ConfigAttackInfo> targetInfoMaps, BaseEntity ownerEntity, string animEventId, AbilityIdentifier? abilityIdentifier = default, bool ignoreCheckCanBeHitInMP = false /* Metadata: 0x00B125FB */) {} // 0x000000018290B480-0x000000018290BDC0
	// [XID] // 0x00000001899F1CC0-0x00000001899F1CE0
	private static Vector3 GetPartAttackPosition(AttackCirclePart part, Vector3 ownerEntityPosition) => default; // 0x0000000182906E70-0x0000000182906FA0
	// [XID] // 0x00000001899F94E0-0x00000001899F9500
	public static void GetAttackUnitBornType(ConfigBornType bornType, BaseEntity ownerEntity, BaseEntity targetEntity, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEvent evt, out Vector3 initPos, out Quaternion initRotation) {
		initPos = default;
		initRotation = default;
	} // 0x00000001829107D0-0x0000000182910B40
	// [XID] // 0x0000000189A007C0-0x0000000189A007E0
	public static bool IsCollisionDetectValid(Collider collider, BaseEntity entity, LCGadgetCombat combat) => default; // 0x00000001829069A0-0x0000000182906AA0
	// [XID] // 0x0000000189B28D30-0x0000000189B28D50
	public static bool IsAttackTagValid(string attackTag, BaseEntity entity) => default; // 0x000000018290B3A0-0x000000018290B480
	// [XID] // 0x0000000189784290-0x00000001897842B0
	public static bool OnAttack(ConfigAttackInfo attackInfo, BaseEntity ownerEntity, BaseEntity attackeeEntity, Vector3 hitPos, Vector3 hitForward, Collider collider, string animEventId, TargetType targetType, AbilityIdentifier? abilityIdentifier = default, bool ignoreCheckCanBeHitInMP = false /* Metadata: 0x00B125FC */) => default; // 0x0000000182908BB0-0x00000001829098F0
	// [XID] // 0x00000001897D7820-0x00000001897D7840
	public static bool OnAttackList(ConfigBaseAttackPattern attackPattern, ConfigAttackInfo attackInfo, BaseEntity ownerEntity, ref AttackResultContext resultContext, string animEventId, TargetType targetType, AbilityIdentifier? abilityIdentifier = default, bool ignoreCheckCanBeHitInMP = false /* Metadata: 0x00B125FD */) => default; // 0x0000000182909EA0-0x000000018290B3A0
	// [XID] // 0x00000001897A9AC0-0x00000001897A9AE0
	private static bool OnRealAttack(ConfigAttackInfo attackInfo, BaseEntity ownerEntity, BaseEntity attackeeEntity, Vector3 hitPos, Vector3 hitForward, Collider collider, string animEventId, TargetType targetType, AbilityIdentifier? abilityIdentifier, bool ignoreCheckCanBeHitInMP) => default; // 0x0000000182910B40-0x00000001829121B0
	// [XID] // 0x000000018984D600-0x000000018984D620
	private static bool OnRealAttackList(ConfigAttackInfo attackInfo, BaseEntity ownerEntity, ref AttackResultContext resultContext, string animEventId, TargetType targetType, AbilityIdentifier? abilityIdentifier, bool ignoreCheckCanBeHitInMP) => default; // 0x000000018290F0D0-0x0000000182910370
	// [XID] // 0x0000000189A2CD00-0x0000000189A2CD20
	private static void TriggerHittingOtherEvent(ConfigAttackInfo attackInfo, BaseEntity ownerEntity, Vector3 hitPos, Vector3 hitForward, Collider collider, TargetType targetType, BaseEntity attackeeEntity, string animEventId, AbilityIdentifier? abilityIdentifier, bool ignoreCheckCanBeHitInMP) {} // 0x0000000182906AA0-0x0000000182906E70
	// [XID] // 0x0000000189A34690-0x0000000189A346B0
	private static void TriggerHittingOtherListEvent(ConfigAttackInfo attackInfo, BaseEntity ownerEntity, ref AttackResultContext resultContext, string animEventId, TargetType targetType, AbilityIdentifier? abilityIdentifier, bool ignoreCheckCanBeHitInMP) {} // 0x0000000182909990-0x0000000182909C50
	// [XID] // 0x0000000189A3BB10-0x0000000189A3BB30
	private static List<CollisionResult> GetEmptyScenePropResultList() => default; // 0x0000000182906780-0x00000001829069A0
	// [XID] // 0x0000000189A43760-0x0000000189A43780
	private static void RecycleScenePropResultList(List<CollisionResult> resultList) {} // 0x000000018290EFD0-0x000000018290F0D0
}

