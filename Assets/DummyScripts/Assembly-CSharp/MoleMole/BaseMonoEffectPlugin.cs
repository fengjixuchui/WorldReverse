/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x0000000189BBC7E0-0x0000000189BBC850
	[TickWithFrameDeltaTime] // 0x0000000189BBC7E0-0x0000000189BBC850
	public abstract class BaseMonoEffectPlugin : MonoBehaviour // TypeDefIndex: 19668
	{
		// Fields
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EffectPluginType effectPluginType; // 0x18
		protected MonoEffect _effect; // 0x20
		private static System.Type _baseMonoEffectPluginType; // 0x00
		private static BindingFlags _bindingFlags; // 0x08
		private static Dictionary<System.Type, EffectPluginMetaInfo> _effectPluginMetaInfo; // 0x10
	
		// Nested types
		[Serializable]
		public class EffectPluginDynamicFloat // TypeDefIndex: 19669
		{
			// Fields
			public float scaled; // 0x10
			public bool autoSmooth; // 0x14
			public float smmothVaue; // 0x18
			public string globalValueKey; // 0x20
			public float originalValue; // 0x28
			private float _currentValue; // 0x2C
			private DynamicActorValue<SafeFloat> _targetValue; // 0x30
	
			// Properties
			public float Value { /* [XID] */ /* 0x0000000189666BD0-0x0000000189666BF0 */ get => default; /* [XID] */ /* 0x000000018966E260-0x000000018966E280 */ set {} } // 0x0000000181AEB8C0-0x0000000181AEB980 0x0000000181AEBA30-0x0000000181AEBDB0
			public float TargetValue { /* [XID] */ /* 0x0000000189675FE0-0x0000000189676000 */ get => default; /* [XID] */ /* 0x000000018967D900-0x000000018967D920 */ set {} } // 0x0000000181AEB7B0-0x0000000181AEB8C0 0x0000000181AEB980-0x0000000181AEBA30
	
			// Constructors
			public EffectPluginDynamicFloat() {} // Dummy constructor
			public EffectPluginDynamicFloat(string key, float value) {} // 0x0000000181AEB700-0x0000000181AEB7B0
	
			// Methods
			// [XID] // 0x0000000189684EC0-0x0000000189684EE0
			public void UpdateByAbility(ActorAbilityPlugin plugin, float deltaTime) {} // 0x0000000181AEB530-0x0000000181AEB700
			// [XID] // 0x000000018968CA40-0x000000018968CA60
			public void Clear() {} // 0x0000000181AEB480-0x0000000181AEB530
		}
	
		public struct EffectPluginMetaInfo // TypeDefIndex: 19670
		{
			// Fields
			public bool hasInit; // 0x00
			public bool hasClear; // 0x01
			public bool hasEnabled; // 0x02
			public bool hasDisabled; // 0x03
			public bool hasTick; // 0x04
			public bool hasLateTick; // 0x05
			public bool hasIsToBeDeallocated; // 0x06
			public bool hasDestroied; // 0x07
			public bool hasDeallocate; // 0x08
			public bool hasSetStopped; // 0x09
			public bool hasEmittingStopped; // 0x0A
		}
	
		// Constructors
		protected BaseMonoEffectPlugin() {} // 0x0000000181ACDBD0-0x0000000181ACDC30
		static BaseMonoEffectPlugin() {} // 0x0000000181ACDAF0-0x0000000181ACDBD0
	
		// Methods
		// [XID] // 0x00000001897E7DF0-0x00000001897E7E10
		public virtual void SetTargetDir(Vector3 dir) {} // 0x0000000181ACD8C0-0x0000000181ACD980
		// [XID] // 0x0000000189BDACC0-0x0000000189BDACE0
		public virtual void SetTargetPos(Vector3 pos) {} // 0x0000000181ACD980-0x0000000181ACDA40
		// [XID] // 0x00000001895E75D0-0x00000001895E75F0
		public virtual void SetMoveToTarget(BaseEntity toEntity) {} // 0x0000000181ACD760-0x0000000181ACD810
		// [XID] // 0x00000001895EEEA0-0x00000001895EEEC0
		public virtual void SetFollowParentTarget(Transform parent) {} // 0x0000000181ACD600-0x0000000181ACD6B0
		// [XID] // 0x00000001895F68E0-0x00000001895F6900
		public virtual void SetLookAtParentTarget(Transform parent) {} // 0x0000000181ACD6B0-0x0000000181ACD760
		// [XID] // 0x00000001895FDCA0-0x00000001895FDCC0
		public virtual void SetSyncTimeScaleTargetAnimator(Animator animator) {} // 0x0000000181ACD810-0x0000000181ACD8C0
		// [XID] // 0x0000000189605490-0x00000001896054B0
		public virtual void Awaked() {} // 0x0000000181ACC600-0x0000000181ACC6B0
		// [XID] // 0x000000018960CE80-0x000000018960CEA0
		public virtual void Init() {} // 0x0000000181ACD230-0x0000000181ACD2D0
		// [XID] // 0x0000000189A977B0-0x0000000189A977D0
		public virtual void Clear() {} // 0x0000000181ACC6B0-0x0000000181ACC750
		// [XID] // 0x00000001898C67B0-0x00000001898C67D0
		public virtual void Enabled() {} // 0x0000000181ACC890-0x0000000181ACC930
		// [XID] // 0x0000000189623440-0x0000000189623460
		public virtual void Disabled() {} // 0x0000000181ACC7F0-0x0000000181ACC890
		// [XID] // 0x000000018962AC60-0x000000018962AC80
		public virtual void Tick(float inDeltaTime) {} // 0x0000000181ACDA40-0x0000000181ACDAF0
		// [XID] // 0x0000000189632360-0x0000000189632380
		public virtual void LateTick(float inDeltaTime) {} // 0x0000000181ACD370-0x0000000181ACD420
		// [XID] // 0x0000000189639E50-0x0000000189639E70
		public virtual bool IsToBeDeallocated() => default; // 0x0000000181ACD2D0-0x0000000181ACD370
		// [XID] // 0x0000000189641320-0x0000000189641340
		public virtual void OnDeallocate() {} // 0x0000000181ACD420-0x0000000181ACD4C0
		// [XID] // 0x0000000189648CE0-0x0000000189648D00
		public virtual void Destroied() {} // 0x0000000181ACC750-0x0000000181ACC7F0
		// [XID] // 0x00000001896502C0-0x00000001896502E0
		public virtual void OnSetEffectStop() {} // 0x0000000181ACD560-0x0000000181ACD600
		// [XID] // 0x0000000189657C10-0x0000000189657C30
		public virtual void OnEmittingStopped() {} // 0x0000000181ACD4C0-0x0000000181ACD560
		// [XID] // 0x000000018965F320-0x000000018965F340
		public static EffectPluginMetaInfo GetEffectPluginMetaInfo(System.Type pluginType) => default; // 0x0000000181ACC930-0x0000000181ACD230
	}
}
