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
	[Serializable]
	public class AnimationPhaseArray // TypeDefIndex: 9358
	{
		// Fields
		public List<AnimationPhase> _phaseList; // 0x10
		public List<AnimationZone> _zoneList; // 0x18
		private Vector3[] _collectedStepRangeArray; // 0x20
		private static int _leftPlantHash; // 0x00
		private static int _rightPlantHash; // 0x04
	
		// Nested types
		public struct ZoneTime // TypeDefIndex: 9359
		{
			// Fields
			public int _shortNameHash; // 0x00
			public float _wrapTime; // 0x04
			public Vector2 _timeSpan; // 0x08
	
			// Methods
			// [XID] // 0x0000000189A31C60-0x0000000189A31C80
			public int Justify() => default; // 0x00000001853EA4D0-0x00000001853EA7B0
		}
	
		// Constructors
		public AnimationPhaseArray() {} // 0x000000018607BB00-0x000000018607BBC0
		static AnimationPhaseArray() {} // 0x000000018607BA60-0x000000018607BB00
	
		// Methods
		// [XID] // 0x000000018991B450-0x000000018991B470
		public AnimationPhaseArray Copy() => default; // 0x0000000186079630-0x0000000186079900
		// [XID] // 0x0000000189922920-0x0000000189922940
		public static bool CanBlendIn(AnimationPhaseBlend blend) => default; // 0x0000000186078F70-0x0000000186079020
		// [XID] // 0x000000018992A180-0x000000018992A1A0
		public static bool CanBlendOut(AnimationPhaseBlend blend) => default; // 0x0000000186079020-0x00000001860790D0
		// [XID] // 0x00000001897D7610-0x00000001897D7630
		public static bool MatchBlend(AnimationPhaseBlend b0, AnimationPhaseBlend b1) => default; // 0x000000018607AFB0-0x000000018607B130
		// [IDTag] // 0x0000000189938E00-0x0000000189938E40
		// [XID] // 0x0000000189938E00-0x0000000189938E40
		public static bool IsStep(AnimationPhaseType phaseType) => default; // 0x000000018607AA60-0x000000018607AB10
		// [XID] // 0x0000000189943630-0x0000000189943650
		public static bool IsStepStart(AnimationPhaseType phaseType) => default; // 0x000000018607A9B0-0x000000018607AA60
		// [XID] // 0x000000018994ACF0-0x000000018994AD10
		public static int StepToIndex(AnimationPhaseType stepType) => default; // 0x000000018607B5C0-0x000000018607B680
		// [XID] // 0x00000001899526A0-0x00000001899526C0
		public AnimationPhase Find(float t, AnimationPhaseBlend blend, params /* 0x000000018989F6F0-0x000000018989F700 */ AnimationPhaseType[] phaseTypes) => default; // 0x0000000186079AD0-0x0000000186079DC0
		// [IDTag] // 0x0000000189961510-0x0000000189961550
		// [XID] // 0x0000000189961510-0x0000000189961550
		public bool IsStep(float t, float len, bool loop, ref AnimationPhase outPhase) => default; // 0x000000018607AB10-0x000000018607AEE0
		// [XID] // 0x000000018996BB60-0x000000018996BB80
		public static AnimationPhaseType Mirror(AnimationPhaseType inType, bool inMirror) => default; // 0x000000018607B130-0x000000018607B220
		// [XID] // 0x00000001897E6550-0x00000001897E6570
		public static bool CalculateSourcePhase(out AnimationPhase outPhase, out float deltaTime, AnimationPhaseArray srcArray, string allowZoneName, float srcStdLength, bool srcLoop, float curNormalizedTime) {
			outPhase = default;
			deltaTime = default;
			return default;
		} // 0x0000000186078C30-0x0000000186078F70
		// [XID] // 0x00000001897EE0A0-0x00000001897EE0C0
		public static bool CalculateFutureStep(out AnimationPhase outPhase, out float deltaTime, AnimationPhaseArray inSrcArray, float inSrcLength, bool inSrcLoop, float inCurrTime) {
			outPhase = default;
			deltaTime = default;
			return default;
		} // 0x0000000186078950-0x0000000186078C30
		// [XID] // 0x00000001899827C0-0x00000001899827E0
		public static Vector3 CalculateCrossFade(AnimationPhaseArray srcArray, bool srcMirror, float srcStdLength, bool srcLoop, bool tgtLoop, AnimationPhaseArray tgtArray, bool tgtMirror, float tgtStdLength, string allowZoneName, string allowTargetZoneName, float curNormalizedTime, AnimationPhaseType tgtMatchPhaseType, int tgtMatchCustomData, float prependNormalizedTime) => default; // 0x0000000186078420-0x0000000186078950
		// [XID] // 0x00000001897E4150-0x00000001897E4170
		public void Ready() {} // 0x000000018607B220-0x000000018607B370
		// [XID] // 0x0000000189991900-0x0000000189991920
		public void Sort() {} // 0x000000018607B370-0x000000018607B5C0
		// [XID] // 0x00000001897DC750-0x00000001897DC770
		public bool TestZone(float time, string allowZoneName) => default; // 0x000000018607B7E0-0x000000018607B920
		// [IDTag] // 0x00000001899A0CD0-0x00000001899A0D10
		// [XID] // 0x00000001899A0CD0-0x00000001899A0D10
		public bool InZone(float time, string name) => default; // 0x000000018607A790-0x000000018607A870
		// [IDTag] // 0x00000001899AB810-0x00000001899AB850
		// [XID] // 0x00000001899AB810-0x00000001899AB850
		public bool InZone(float time, int nameHash) => default; // 0x000000018607A870-0x000000018607A9B0
		// [XID] // 0x00000001899B5BA0-0x00000001899B5BC0
		public bool TestZoneInNormalizedTime(float time, string allowZoneName, float stdLength) => default; // 0x000000018607B680-0x000000018607B7E0
		// [IDTag] // 0x00000001899BD470-0x00000001899BD4B0
		// [XID] // 0x00000001899BD470-0x00000001899BD4B0
		public bool InZoneInNormalizedTime(float time, string name, float stdLength) => default; // 0x000000018607A690-0x000000018607A790
		// [IDTag] // 0x00000001899C7D10-0x00000001899C7D50
		// [XID] // 0x00000001899C7D10-0x00000001899C7D50
		public bool InZoneInNormalizedTime(float time, int nameHash, float stdLength) => default; // 0x000000018607A530-0x000000018607A690
		// [XID] // 0x00000001897F5820-0x00000001897F5840
		public ZoneTime CalcZoneTime(int stateNameHash, float time, string name) => default; // 0x0000000186078210-0x0000000186078420
		// [IDTag] // 0x00000001899D9A80-0x00000001899D9AC0
		// [XID] // 0x00000001899D9A80-0x00000001899D9AC0
		public AnimationPhaseType GetFootStepType(Vector4 elapsed, bool isMirror, bool isLoop) => default; // 0x000000018607A320-0x000000018607A530
		// [IDTag] // 0x00000001899E41A0-0x00000001899E41E0
		// [XID] // 0x00000001899E41A0-0x00000001899E41E0
		public AnimationPhaseType GetFootStepType(out float stepElasped, Vector4 elapsed, bool isMirror, bool isLoop) {
			stepElasped = default;
			return default;
		} // 0x000000018607A110-0x000000018607A320
		// [XID] // 0x00000001897C2460-0x00000001897C2480
		public Vector2 GetFootAirRatio(Vector4 elapsed, bool isMirror) => default; // 0x0000000186079DC0-0x000000018607A110
		// [XID] // 0x00000001897A3A70-0x00000001897A3A90
		public Vector3[] CollectStepRangeArray() => default; // 0x00000001860790D0-0x0000000186079480
		// [XID] // 0x00000001899FD6B0-0x00000001899FD6D0
		public int CompareZone(float time, string name) => default; // 0x0000000186079480-0x0000000186079630
		// [XID] // 0x0000000189A05C50-0x0000000189A05C70
		public static float FindTag(AnimatorController cont, int stateHash, AnimationPhaseType tagType, int tagCustomData) => default; // 0x0000000186079900-0x0000000186079AD0
		// [XID] // 0x0000000189A0C3F0-0x0000000189A0C410
		public static AnimationPhaseArray LoadFromJSON(string json) => default; // 0x000000018607AEE0-0x000000018607AFB0
	}
}
