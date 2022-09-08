/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	public class CrossFadeBase : IdentifiedStateMachineBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 9380
	{
		// Fields
		public bool _fadeOnPhase; // 0x38
		public float _fadePrependTime; // 0x3C
		public float _fadeLength; // 0x40
		public string _nextState; // 0x48
		public bool _enableMultiNextState; // 0x50
		public string[] _nextStates; // 0x58
		public string _multiNextStateSelector; // 0x60
		public int _multiNextStateSelectorHash; // 0x68
		public bool _validOnCurrent; // 0x6C
		public bool _validOnNext; // 0x6D
		public bool _allowInterrupt; // 0x6E
		public int _priority; // 0x70
		public bool _allowInterruptCurrent; // 0x74
		public bool _allowInterruptNext; // 0x75
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimatorTiming _tgtTiming; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int _tgtTimeTag; // 0x7C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string _tgtTimeParamName; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _tgtTime; // 0x88
		public string _tgtZone; // 0x90
		public FadeMirror _mirrorMode; // 0x98
		public int _tgtMatchCustomData; // 0x9C
		public AnimationPhaseType _tgtMatchPhaseType; // 0xA0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public ZoneConfig[] _zoneConfigArray; // 0xA8
		protected bool _passTrigger; // 0xB0
		protected bool _isCurrent; // 0xB1
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool _exterpolateRootMotionAtFrameZero; // 0xB2
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public RootMotionBlendMode _rootMotionBlendMode; // 0xB4
	
		// Nested types
		public enum FadeMirror // TypeDefIndex: 9381
		{
			Auto = 0,
			DoNotMirror = 1,
			MirrorOnly = 2,
			Opposite = 3,
			DoNotChange = 4,
			DoNotSet = 5
		}
	
		[Serializable]
		public class ZoneConfig : ISerializationCallbackReceiver // TypeDefIndex: 9382
		{
			// Fields
			public bool _enabled; // 0x10
			public float _fadeLength; // 0x14
			public int _priority; // 0x18
			public FadeMirror _mirrorMode; // 0x1C
			public AnimatorTiming _tgtTiming; // 0x20
			public int _tgtTimeTag; // 0x24
			public string _tgtTimeParamName; // 0x28
			public float _tgtTime; // 0x30
	
			// Constructors
			public ZoneConfig() {} // 0x00000001853EA350-0x00000001853EA4D0
	
			// Methods
			// [XID] // 0x0000000189798D90-0x0000000189798DB0
			public void OnBeforeSerialize() {} // 0x00000001853EA2B0-0x00000001853EA350
			// [XID] // 0x00000001897A0C80-0x00000001897A0CA0
			public void OnAfterDeserialize() {} // 0x00000001853EA1E0-0x00000001853EA2B0
			// [IDTag] // 0x00000001897A82D0-0x00000001897A8310
			// [XID] // 0x00000001897A82D0-0x00000001897A8310
			public void CopyFrom(CrossFadeBase cf) {} // 0x00000001853EA000-0x00000001853EA0F0
			// [IDTag] // 0x00000001897B2D80-0x00000001897B2DC0
			// [XID] // 0x00000001897B2D80-0x00000001897B2DC0
			public void CopyFrom(ZoneConfig cf) {} // 0x00000001853E9F10-0x00000001853EA000
			// [XID] // 0x00000001898E3100-0x00000001898E3120
			public void CopyTo(CrossFadeBase cf) {} // 0x00000001853EA0F0-0x00000001853EA1E0
		}
	
		// Constructors
		public CrossFadeBase() {} // 0x00000001853C89F0-0x00000001853C8AC0
	
		// Methods
		// [XID] // 0x00000001897588B0-0x00000001897588D0
		public virtual void OnBeforeSerialize() {} // 0x00000001853C86F0-0x00000001853C8790
		// [XID] // 0x0000000189760600-0x0000000189760620
		public virtual void OnAfterDeserialize() {} // 0x00000001853C85D0-0x00000001853C86F0
		// [XID] // 0x00000001899D1FD0-0x00000001899D1FF0
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x00000001853C8790-0x00000001853C8940
		// [IDTag] // 0x000000018976F020-0x000000018976F060
		// [XID] // 0x000000018976F020-0x000000018976F060
		public bool CanTransition(Animator animator, AnimatorStateInfo state) => default; // 0x00000001853C7160-0x00000001853C7320
		// [IDTag] // 0x00000001897799C0-0x0000000189779A00
		// [XID] // 0x00000001897799C0-0x0000000189779A00
		public static bool CanTransition(bool isCurrent, CrossFadeByParameterConfig config) => default; // 0x00000001853C7090-0x00000001853C7160
		// [IDTag] // 0x00000001897842B0-0x00000001897842F0
		// [XID] // 0x00000001897842B0-0x00000001897842F0
		public bool CrossFade(AnimatorController cont, AnimatorStateInfo currState, float fadeLength) => default; // 0x00000001853C7320-0x00000001853C7C50
		// [IDTag] // 0x000000018978E780-0x000000018978E7C0
		// [XID] // 0x000000018978E780-0x000000018978E7C0
		public static bool CrossFade(AnimatorController cont, AnimatorStateInfo currState, float fadeLength, CrossFadeByParameterConfig config) => default; // 0x00000001853C7C50-0x00000001853C85D0
	}
}
