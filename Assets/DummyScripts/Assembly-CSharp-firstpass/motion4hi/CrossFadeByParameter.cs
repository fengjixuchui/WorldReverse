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
	public class CrossFadeByParameter : CrossFadeBase // TypeDefIndex: 9384
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool _inTransition; // 0xB8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _paramNames; // 0xC0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimatorControllerParameterType[] _paramTypes; // 0xC8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _paramNameHashs; // 0xD0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _paramRefBools; // 0xD8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float[] _paramRefFloats; // 0xE0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _paramRefInts; // 0xE8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _paramRefParams; // 0xF0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _paramRefParamHashs; // 0xF8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public CrossFadeComparison[] _paramComparisons; // 0x100
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimatorTiming[] _paramTimings; // 0x108
		protected AnimatorController _cont; // 0x110
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool _enableSpecialCondition; // 0x118
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _specialParamNames; // 0x120
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _specialParamNameHashs; // 0x128
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimatorControllerParameterType[] _specialParamTypes; // 0x130
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _specialParamRefBools; // 0x138
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float[] _specialParamRefFloats; // 0x140
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _specialParamRefInts; // 0x148
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _specialParamRefParams; // 0x150
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _specialParamRefParamHashs; // 0x158
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public CrossFadeComparison[] _specialParamComparisons; // 0x160
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimatorTiming[] _specialParamTimings; // 0x168
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float[] _specialParamFadeLength; // 0x170
		private static int _timeHash; // 0x00
		private static int _wrapTimeHash; // 0x04
		private static int _stateTimeHash; // 0x08
		private static int _normalizedTimeHash; // 0x0C
		private static int _wrapNormalizedTimeHash; // 0x10
		private static int _toSurfaceHash; // 0x14
		private static int _upDotSurfaceNormalHash; // 0x18
		private static int _velocityHash; // 0x1C
		private static int _velocityNCHash; // 0x20
		private static int _velocityYHash; // 0x24
		private static int _velocityNCYHash; // 0x28
		private static int _randomHash; // 0x2C
		private static int _phaseHash; // 0x30
	
		// Constructors
		public CrossFadeByParameter() {} // 0x00000001853CCB10-0x00000001853CCB80
		static CrossFadeByParameter() {} // 0x00000001853CC900-0x00000001853CCB10
	
		// Methods
		// [XID] // 0x00000001896A5130-0x00000001896A5150
		public override void OnBeforeSerialize() {} // 0x00000001853CAD50-0x00000001853CADF0
		// [XID] // 0x00000001896ACA60-0x00000001896ACA80
		public override void OnAfterDeserialize() {} // 0x00000001853CAC30-0x00000001853CAD50
		// [XID] // 0x000000018987F5D0-0x000000018987F5F0
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x00000001853CB1A0-0x00000001853CB3D0
		// [IDTag] // 0x0000000189886C40-0x0000000189886C80
		// [XID] // 0x0000000189886C40-0x0000000189886C80
		private int CheckSpecialCondition(Animator animator, ref AnimatorStateInfo stateInfo) => default; // 0x00000001853C90D0-0x00000001853C97E0
		// [IDTag] // 0x0000000189890E00-0x0000000189890E40
		// [XID] // 0x0000000189890E00-0x0000000189890E40
		private static int CheckSpecialCondition(Animator animator, ref AnimatorStateInfo stateInfo, CrossFadeByParameterConfig config, AnimatorController _cont) => default; // 0x00000001853C97E0-0x00000001853C9E10
		// [IDTag] // 0x000000018989B550-0x000000018989B590
		// [XID] // 0x000000018989B550-0x000000018989B590
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x00000001853CAF10-0x00000001853CB1A0
		// [IDTag] // 0x00000001898A5B70-0x00000001898A5BB0
		// [XID] // 0x00000001898A5B70-0x00000001898A5BB0
		public static void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, CrossFadeByParameterConfig config, AnimatorController _cont) {} // 0x00000001853CADF0-0x00000001853CAF10
		// [XID] // 0x00000001898B0210-0x00000001898B0230
		public static bool CompareInt(CrossFadeComparison Cmp, int v, int refV) => default; // 0x00000001853C9F20-0x00000001853CA020
		// [XID] // 0x0000000189914320-0x0000000189914340
		public static bool CompareFloat(CrossFadeComparison Cmp, float v, float refV) => default; // 0x00000001853C9E10-0x00000001853C9F20
		// [XID] // 0x00000001896E0290-0x00000001896E02B0
		private static float GetAnimatorFloat(Animator animator, ref AnimatorStateInfo stateInfo, string paramName, AnimatorController cont, int paramNameHash) => default; // 0x00000001853CA430-0x00000001853CA890
		// [XID] // 0x00000001898C6760-0x00000001898C6780
		private static float GetAnimatorFloatRunTime(Animator animator, ref AnimatorStateInfo stateInfo, AnimatorController cont, int paramNameHash) => default; // 0x00000001853CA020-0x00000001853CA430
		// [XID] // 0x00000001898CDE00-0x00000001898CDE20
		private static int GetAnimatorInt(Animator animator, ref AnimatorStateInfo stateInfo, string paramName, AnimatorController cont, int paramNameHash) => default; // 0x00000001853CAA30-0x00000001853CAC30
		// [XID] // 0x00000001898D5770-0x00000001898D5790
		private static int GetAnimatorIntRunTime(Animator animator, ref AnimatorStateInfo stateInfo, AnimatorController cont, int paramNameHash) => default; // 0x00000001853CA890-0x00000001853CAA30
		// [IDTag] // 0x00000001898DD130-0x00000001898DD170
		// [XID] // 0x00000001898DD130-0x00000001898DD170
		public void UpdateBehaviour(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, bool isCurrent) {} // 0x00000001853CB5F0-0x00000001853CBFF0
		// [IDTag] // 0x00000001898E8060-0x00000001898E80A0
		// [XID] // 0x00000001898E8060-0x00000001898E80A0
		public static void UpdateBehaviour(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, bool isCurrent, CrossFadeByParameterConfig config, AnimatorController _cont) {} // 0x00000001853CBFF0-0x00000001853CC900
	}
}
