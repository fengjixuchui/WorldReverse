/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	public class AnimatorController : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 9372
	{
		// Fields
		public Action<CrossFadeInfo> onCrossFadeTransition; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Int3[] _transitionProirities; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<int, List<Int3>> _transitionProiritiesDict; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<string, bool> _stateLoop; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _random; // 0x38
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool _disableNoFadeZone; // 0x3C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<StateMachineBehaviour, StateMachineBehaviourInfo> _currentBehaviour; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<CrossFadeByParameterConfig> _crossfadeConfigs; // 0x48
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<int, CrossFadeByParameterConfig[]> _configsDictionary; // 0x50
		public string[] _curveExtractionKeywords; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _stateNames; // 0x60
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _stateLoops; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] _stateHashes; // 0x70
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _stateMirros; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _stateHasMirrors; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _stateMirrorParams; // 0x88
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] _statePhaseJsonPathes; // 0x90
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public AnimationPhaseArray[] _statePhaseArrays; // 0x98
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float[] _stateDefaultDurations; // 0xA0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<string> _serializedParamConstraints; // 0xA8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<ParamConstraint> _paramConstraints; // 0xB0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] _stateTransitionedArray; // 0xB8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Int3 _cfTransition; // 0xC0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _cfParams; // 0xCC
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Animator _animator; // 0xD8
		private int _frame; // 0xE0
		public AnimatorControllerParameter[] _allParams; // 0xE8
		public Dictionary<int, AnimatorControllerParameterType> _allParamsTypeDictionary; // 0xF0
		public PropSpace _prop1Space; // 0xF8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverStepBorderNear0; // 0xFC
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverStepBorderNear1; // 0x108
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverStepBorderFar0; // 0x114
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverStepBorderFar1; // 0x120
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverJumpBorder0; // 0x12C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverJumpBorder1; // 0x138
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverPredictJumpPos; // 0x144
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverPredictStepInPos; // 0x150
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 _crossOverDecisionJumpPos; // 0x15C
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int _currentstateHash; // 0x168
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int _nextstateHash; // 0x16C
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _currentstateTime; // 0x170
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _nextstateTime; // 0x174
	
		// Properties
		public int Frame { /* [XID] */ /* 0x0000000189B8F9A0-0x0000000189B8F9C0 */ get => default; } // 0x00000001853C5AD0-0x00000001853C5B70 
		public AnimatorControllerParameter[] allParams { /* [XID] */ /* 0x0000000189B96F30-0x0000000189B96F50 */ get => default; } // 0x00000001853C5B70-0x00000001853C5C20 
	
		// Nested types
		public class CrossFadeInfo // TypeDefIndex: 9373
		{
			// Fields
			public object[] values; // 0x10
			public bool tryDoJump; // 0x18
			public int curMotionFlag; // 0x1C
			public int stateEnum; // 0x20
			public Vector3 pos; // 0x24
			public Quaternion rot; // 0x30
			public string curStateName; // 0x40
			public string nextStateName; // 0x48
			public bool curMirror; // 0x50
			public float curNormalizedTime; // 0x54
			public float curLength; // 0x58
			public float curTagTime; // 0x5C
			public bool nextMirror; // 0x60
			public float tgtNormalizedTime; // 0x64
			public float nextLength; // 0x68
			public float nextTagTime; // 0x6C
			public float deltaTime; // 0x70
			public AnimatorControllerParameter[] allParams; // 0x78
	
			// Constructors
			public CrossFadeInfo() {} // Dummy constructor
			public CrossFadeInfo(string curStateName, string nextStateName, bool curMirror, float curNormalizedTime, float curLength, float curTagTime, bool nextMirror, float tgtNormalizedTime, float nextLength, float nextTagTime, float deltaTime, AnimatorControllerParameter[] allParams) {} // 0x00000001853CCB80-0x00000001853CCC80
		}
	
		[Serializable]
		public class TransitionPriority : ISerializationCallbackReceiver // TypeDefIndex: 9374
		{
			// Fields
			public string _srcStateName; // 0x10
			public string _tgtStateName; // 0x18
			public int _priority; // 0x20
	
			// Constructors
			public TransitionPriority() {} // 0x00000001853E95F0-0x00000001853E9650
	
			// Methods
			// [XID] // 0x00000001896DA4D0-0x00000001896DA4F0
			public void OnBeforeSerialize() {} // 0x00000001853E9550-0x00000001853E95F0
			// [XID] // 0x0000000189709780-0x00000001897097A0
			public void OnAfterDeserialize() {} // 0x00000001853E9470-0x00000001853E9550
		}
	
		public struct StateMachineBehaviourInfo // TypeDefIndex: 9375
		{
			// Fields
			public int fullPathHash; // 0x00
			public int layerIndex; // 0x04
			public int count; // 0x08
	
			// Constructors
			public StateMachineBehaviourInfo(int layerIndex, int fullPathHash) {
				this.fullPathHash = default;
				this.layerIndex = default;
				count = default;
			} // 0x00000001853E1700-0x00000001853E1780
		}
	
		// Constructors
		public AnimatorController() {} // 0x00000001853C5990-0x00000001853C5AD0
	
		// Methods
		// [XID] // 0x00000001898BCBF0-0x00000001898BCC10
		public void OnBeforeSerialize() {} // 0x00000001853C49C0-0x00000001853C4A60
		// [XID] // 0x0000000189BA5DC0-0x0000000189BA5DE0
		public void OnAfterDeserialize() {} // 0x00000001853C48B0-0x00000001853C49C0
		// [XID] // 0x0000000189BAD120-0x0000000189BAD140
		public string StateName(int index) => default; // 0x00000001853C5400-0x00000001853C54E0
		// [IDTag] // 0x0000000189BB4900-0x0000000189BB4940
		// [XID] // 0x0000000189BB4900-0x0000000189BB4940
		public AnimationPhaseArray StatePhaseArray(int index) => default; // 0x00000001853C54E0-0x00000001853C55C0
		// [IDTag] // 0x0000000189BBEB90-0x0000000189BBEBD0
		// [XID] // 0x0000000189BBEB90-0x0000000189BBEBD0
		public AnimationPhaseArray StatePhaseArray(string name) => default; // 0x00000001853C55C0-0x00000001853C5690
		// [XID] // 0x0000000189BC9AC0-0x0000000189BC9AE0
		public static string[] SplitStateName(string inName) => default; // 0x00000001853C51F0-0x00000001853C5400
		// [XID] // 0x0000000189BD11F0-0x0000000189BD1210
		public string HashToName(int inHash) => default; // 0x00000001853C3D10-0x00000001853C3E00
		// [XID] // 0x0000000189BD88F0-0x0000000189BD8910
		public float HashToDuration(int inHash) => default; // 0x00000001853C3710-0x00000001853C3810
		// [XID] // 0x0000000189BE0050-0x0000000189BE0070
		public AnimationPhaseArray HashToPhaseArray(int hash) => default; // 0x00000001853C3E00-0x00000001853C3EF0
		// [IDTag] // 0x00000001895ECE00-0x00000001895ECE40
		// [XID] // 0x00000001895ECE00-0x00000001895ECE40
		public int HashToIndex(int inHash) => default; // 0x00000001853C3C00-0x00000001853C3D10
		// [XID] // 0x00000001895F76B0-0x00000001895F76D0
		public bool HashToHasMirror(int hash) => default; // 0x00000001853C3810-0x00000001853C3900
		// [XID] // 0x00000001895FEA50-0x00000001895FEA70
		public int NameToIndex(string inName) => default; // 0x00000001853C47F0-0x00000001853C48B0
		// [IDTag] // 0x0000000189606450-0x0000000189606490
		// [XID] // 0x0000000189606450-0x0000000189606490
		public int HashToIndex(string inName, AnimationPhaseType inPhase, bool inMatchExactly) => default; // 0x00000001853C3900-0x00000001853C3C00
		// [XID] // 0x0000000189A147C0-0x0000000189A147E0
		public void Serialize() {} // 0x00000001853C4EA0-0x00000001853C4F40
		// [XID] // 0x0000000189A23400-0x0000000189A23420
		public void UnSerialize() {} // 0x00000001853C5690-0x00000001853C5820
		// [IDTag] // 0x000000018961FC70-0x000000018961FCB0
		// [XID] // 0x000000018961FC70-0x000000018961FCB0
		public bool InZone(string zoneName, bool allowNext) => default; // 0x00000001853C44C0-0x00000001853C47F0
		// [IDTag] // 0x000000018962A260-0x000000018962A2A0
		// [XID] // 0x000000018962A260-0x000000018962A2A0
		public bool InZone(string zoneName) => default; // 0x00000001853C4270-0x00000001853C44C0
		// [XID] // 0x000000018989EA40-0x000000018989EA60
		public bool InNextZone(string zoneName) => default; // 0x00000001853C3EF0-0x00000001853C40D0
		// [IDTag] // 0x000000018963C300-0x000000018963C340
		// [XID] // 0x000000018963C300-0x000000018963C340
		public bool InZone(ref AnimatorStateInfo state, int nameHash) => default; // 0x00000001853C40D0-0x00000001853C4270
		// [XID] // 0x0000000189864B10-0x0000000189864B30
		public AnimationPhaseArray.ZoneTime CalcZoneTime(AnimatorStateInfo stateInfo, string zoneName) => default; // 0x00000001853C1450-0x00000001853C1610
		// [XID] // 0x000000018986C070-0x000000018986C090
		public AnimationPhaseArray.ZoneTime CalcCurrentZoneTime(string zoneName) => default; // 0x00000001853C1030-0x00000001853C1180
		// [XID] // 0x0000000189873510-0x0000000189873530
		public AnimationPhaseArray.ZoneTime CalcNextZoneTime(string zoneName) => default; // 0x00000001853C1300-0x00000001853C1450
		// [XID] // 0x000000018965D300-0x000000018965D320
		public AnimationPhaseArray.ZoneTime CalcMostValidZoneTime(string zoneName) => default; // 0x00000001853C1180-0x00000001853C1300
		// [XID] // 0x00000001896648D0-0x00000001896648F0
		public KeyValuePair<AnimationPhase, float> GetPhase(AnimatorStateInfo stateInfo) => default; // 0x00000001853C3280-0x00000001853C3590
		// [XID] // 0x00000001898A7060-0x00000001898A7080
		public AnimatorControllerParameter GetParameterByName(string inName) => default; // 0x00000001853C30E0-0x00000001853C3280
		// [XID] // 0x0000000189673CB0-0x0000000189673CD0
		private void Awake() {} // 0x00000001853C0530-0x00000001853C1030
		// [XID] // 0x0000000189890BA0-0x0000000189890BC0
		public bool HasParam(string paramName) => default; // 0x00000001853C3590-0x00000001853C3710
		// [XID] // 0x0000000189682C90-0x0000000189682CB0
		public bool GetMirrorByStateName(string stateName) => default; // 0x00000001853C2FA0-0x00000001853C30E0
		// [XID] // 0x00000001898D3D10-0x00000001898D3D30
		public void SetMirrorByStateName(string stateName, bool isMirror) {} // 0x00000001853C5090-0x00000001853C51F0
		// [XID] // 0x0000000189BA8590-0x0000000189BA85B0
		public bool GetMirrorByStateIndex(int stateIndex) => default; // 0x00000001853C2E60-0x00000001853C2FA0
		// [XID] // 0x00000001896998F0-0x0000000189699910
		public void SetMirrorByStateIndex(int stateIndex, bool isMirror) {} // 0x00000001853C4F40-0x00000001853C5090
		// [IDTag] // 0x00000001896A0EF0-0x00000001896A0F30
		// [XID] // 0x00000001896A0EF0-0x00000001896A0F30
		public bool CrossFade(AnimatorStateInfo currState, string nextStateName, string allowZoneName, float fadeLength, float tgtTime, bool ignoreZone, bool exterpolateRootMotionAtFrameZero, RootMotionBlendMode rootMotionBlendMode) => default; // 0x00000001853C1B70-0x00000001853C1EC0
		// [XID] // 0x00000001896AB180-0x00000001896AB1A0
		public bool CrossFadeInNormalizedTime(AnimatorStateInfo currState, string nextStateName, string allowZoneName, float fadeLength, float tgtTime, bool ignoreZone, bool exterpolateRootMotionAtFrameZero, RootMotionBlendMode rootMotionBlendMode) => default; // 0x00000001853C16D0-0x00000001853C1B70
		// [IDTag] // 0x00000001896B23F0-0x00000001896B2430
		// [XID] // 0x00000001896B23F0-0x00000001896B2430
		public bool CrossFade(AnimatorStateInfo currState, string nextStateName, string allowZoneName, string allowTargetZoneName, float fadeLength, bool fadeOnPhase, bool allowNextNonMirror, bool allowNextMirror, AnimationPhaseType tgtMatchPhaseType, int tgtMatchCustomData, float prependTime, bool exterpolateRootMotionAtFrameZero, RootMotionBlendMode rootMotionBlendMode) => default; // 0x00000001853C1EC0-0x00000001853C2E60
		// [XID] // 0x00000001896BCB40-0x00000001896BCB60
		public void ClearCfTranstion() {} // 0x00000001853C1610-0x00000001853C16D0
		// [XID] // 0x0000000189BB93E0-0x0000000189BB9400
		private void OnDrawGizmos() {} // 0x00000001853C4B20-0x00000001853C4EA0
		// [XID] // 0x00000001896CB4F0-0x00000001896CB510
		public void UpdateStateTime(int currentHash, int nextHash, float currentScale, float nextScale) {} // 0x00000001853C5820-0x00000001853C5990
		// [XID] // 0x00000001896D2AB0-0x00000001896D2AD0
		private void OnDisable() {} // 0x00000001853C4A60-0x00000001853C4B20
	}
}
