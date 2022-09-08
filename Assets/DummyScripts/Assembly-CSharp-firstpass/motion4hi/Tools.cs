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
	public static class Tools // TypeDefIndex: 9394
	{
		// Fields
		public static float[] DegreeMasks; // 0x00
		public static string _disableSpeedWarping; // 0x08
		public static string _disableTimeWarping; // 0x10
		public static string _disableRRM; // 0x18
	
		// Nested types
		public delegate bool TraverseCb(GameObject go); // TypeDefIndex: 9395; 0x00000001853E9780-0x00000001853E99E0
	
		public delegate float FilterKeyCb(int tag, float t, float v); // TypeDefIndex: 9396; 0x00000001853CD290-0x00000001853CD490
	
		public delegate void StepCb(float t); // TypeDefIndex: 9397; 0x00000001853E1890-0x00000001853E1A20
	
		// Constructors
		static Tools() {} // 0x00000001853E8430-0x00000001853E8520
	
		// Methods
		// [XID] // 0x0000000189A70310-0x0000000189A70330
		public static float FixDegree(float inDeg) => default; // 0x00000001853E6130-0x00000001853E6220
		// [XID] // 0x0000000189A77B80-0x0000000189A77BA0
		public static Vector3 FixEuler(Vector3 inEuler) => default; // 0x00000001853E6220-0x00000001853E63A0
		// [XID] // 0x0000000189A7F0E0-0x0000000189A7F100
		public static GameObject FindGameObject(GameObject inRootGo, string inName) => default; // 0x00000001853E5FA0-0x00000001853E6130
		// [XID] // 0x0000000189AB0BA0-0x0000000189AB0BC0
		public static float LerpByTime(float value, float target, float increaseSpeed, float decreaseSpeed) => default; // 0x00000001853E6730-0x00000001853E68D0
		// [XID] // 0x0000000189927120-0x0000000189927140
		public static Vector3 FlattenVector(Vector3 v, Vector3 up) => default; // 0x00000001853E63A0-0x00000001853E6560
		// [XID] // 0x00000001899538B0-0x00000001899538D0
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) => default; // 0x00000001853E6AC0-0x00000001853E6DD0
		// [IDTag] // 0x0000000189AC7840-0x0000000189AC7880
		// [XID] // 0x0000000189AC7840-0x0000000189AC7880
		public static Vector3[] TransformArrayToPosition(Transform[] inTfArray) => default; // 0x00000001853E7FF0-0x00000001853E8160
		// [IDTag] // 0x0000000189AD20D0-0x0000000189AD2110
		// [XID] // 0x0000000189AD20D0-0x0000000189AD2110
		public static Vector3[] TransformArrayToPosition(Transform inRoot, Transform[] inTfArray) => default; // 0x00000001853E8160-0x00000001853E8330
		// [XID] // 0x0000000189ADCFD0-0x0000000189ADCFF0
		public static Matrix4x4 ConstructMatrix(Vector3 inRight, Vector3 inUp, Vector3 inForward) => default; // 0x00000001853E4880-0x00000001853E4B30
		// [XID] // 0x0000000189AE4700-0x0000000189AE4720
		public static Quaternion QuaternionFromMatrix(Matrix4x4 m) => default; // 0x00000001853E74C0-0x00000001853E78B0
		// [IDTag] // 0x0000000189AEBEB0-0x0000000189AEBEF0
		// [XID] // 0x0000000189AEBEB0-0x0000000189AEBEF0
		public static float CalcAnimatorStateWrapElapsedTime(AnimatorStateInfo state) => default; // 0x00000001853E3B90-0x00000001853E3CB0
		// [IDTag] // 0x0000000189AF6730-0x0000000189AF6770
		// [XID] // 0x0000000189AF6730-0x0000000189AF6770
		public static float CalcAnimatorStateWrapElapsedTime(AnimatorStateInfo stateInfo, float dt) => default; // 0x00000001853E3CB0-0x00000001853E3E20
		// [XID] // 0x0000000189B00D80-0x0000000189B00DA0
		public static float CalcAnimatorStateWrapNormalizedElapsedTime(AnimatorStateInfo state, float dt) => default; // 0x00000001853E3E20-0x00000001853E3F80
		// [IDTag] // 0x0000000189B08420-0x0000000189B08460
		// [XID] // 0x0000000189B08420-0x0000000189B08460
		public static void DrawAxisGizmo(Vector3 pos, Vector3 right, Vector3 up, Vector3 forward, float size) {} // 0x00000001853E50D0-0x00000001853E5460
		// [IDTag] // 0x0000000189B12C20-0x0000000189B12C60
		// [XID] // 0x0000000189B12C20-0x0000000189B12C60
		public static void DrawAxisGizmo(Vector3 pos, Quaternion rot, float size) {} // 0x00000001853E5460-0x00000001853E5890
		// [XID] // 0x00000001898B98D0-0x00000001898B98F0
		public static void DrawXAxisConstraint(Vector3 p, Quaternion q, float fromDeg, float toDeg, float size) {} // 0x00000001853E5A20-0x00000001853E5B20
		// [XID] // 0x0000000189935B60-0x0000000189935B80
		public static void DrawYAxisConstraint(Vector3 p, Quaternion q, float fromDeg, float toDeg, float size) {} // 0x00000001853E5B20-0x00000001853E5C20
		// [XID] // 0x000000018993D800-0x000000018993D820
		public static void DrawZAxisConstraint(Vector3 p, Quaternion q, float fromDeg, float toDeg, float size) {} // 0x00000001853E5C20-0x00000001853E5D20
		// [XID] // 0x0000000189B33090-0x0000000189B330B0
		public static void DrawCylinder(Vector3 pos, float radius, float height) {} // 0x00000001853E5890-0x00000001853E5970
		public static T[] GrowArray<T>(T[] inArray, int inAddNum) => default;
		public static T[] ExpandArrayAtIndex<T>(T[] inArray, int startIndex, int expandNum) => default;
		public static T[] FitArray<T>(T[] inArray, int inNewNum) => default;
		public static T[] RemoveFromArray<T>(T[] inArray, int removeIndex) => default;
		// [XID] // 0x0000000189B3AC30-0x0000000189B3AC50
		public static AnimationCurve AccumCurve(AnimationCurve inCurve) => default; // 0x00000001853E3130-0x00000001853E33F0
		// [XID] // 0x0000000189ADF470-0x0000000189ADF490
		public static short DegToShort(float deg) => default; // 0x00000001853E4B30-0x00000001853E4BF0
		// [XID] // 0x0000000189B49DD0-0x0000000189B49DF0
		public static float ShortToDeg(short shortAngle) => default; // 0x00000001853E7A70-0x00000001853E7B30
		// [XID] // 0x00000001899797E0-0x0000000189979800
		public static float DeltaDegree(float d0, float d1) => default; // 0x00000001853E4BF0-0x00000001853E4CF0
		// [IDTag] // 0x0000000189B58EE0-0x0000000189B58F20
		// [XID] // 0x0000000189B58EE0-0x0000000189B58F20
		public static float ApproachDegree(float curr, float tgt, float delta) => default; // 0x00000001853E3550-0x00000001853E3750
		// [XID] // 0x0000000189B63310-0x0000000189B63330
		public static float ApporachValue(float curr, float tgt, float delta) => default; // 0x00000001853E33F0-0x00000001853E3550
		// [IDTag] // 0x0000000189B6AC10-0x0000000189B6AC50
		// [XID] // 0x0000000189B6AC10-0x0000000189B6AC50
		public static float ApproachDegree(float curr, float tgt, float delta, int lastDirSign) => default; // 0x00000001853E3750-0x00000001853E3990
		// [XID] // 0x000000018998FCE0-0x000000018998FD00
		public static Vector3 ApproachEuler(Vector3 curr, Vector3 tgt, Vector3 delta) => default; // 0x00000001853E3990-0x00000001853E3B90
		// [IDTag] // 0x0000000189B7C490-0x0000000189B7C4D0
		// [XID] // 0x0000000189B7C490-0x0000000189B7C4D0
		public static float Sign(float a) => default; // 0x00000001853E7BF0-0x00000001853E7CF0
		// [IDTag] // 0x0000000189B87130-0x0000000189B87170
		// [XID] // 0x0000000189B87130-0x0000000189B87170
		public static int Sign(int a) => default; // 0x00000001853E7B30-0x00000001853E7BF0
		// [XID] // 0x000000018999F170-0x000000018999F190
		public static void TestCaseDegree() {} // 0x00000001853E7DF0-0x00000001853E7FF0
		// [XID] // 0x00000001899AE410-0x00000001899AE430
		public static void Step(StepCb stepCb, float length, float step = 0.016f /* Metadata: 0x00AE5832 */) {} // 0x00000001853E7CF0-0x00000001853E7DF0
		// [XID] // 0x0000000189BAA2E0-0x0000000189BAA300
		public static float DiscretizeDegree(float deg) => default; // 0x00000001853E4E50-0x00000001853E5020
		// [XID] // 0x0000000189BB1A80-0x0000000189BB1AA0
		public static Vector3 CalcTrajectory(float thetaDeg, float v0, float gravity, float airFriction, float t) => default; // 0x00000001853E42E0-0x00000001853E44C0
		// [XID] // 0x00000001899D3A40-0x00000001899D3A60
		public static Vector3 CalcTrajectoryD(float thetaDeg, float v0, float gravity, float airFriction, float t) => default; // 0x00000001853E3F80-0x00000001853E4140
		// [XID] // 0x00000001896D4DE0-0x00000001896D4E00
		public static float CalcTrajectoryTByY(float thetaDeg, float v0, float gravity, float airFriction, float y) => default; // 0x00000001853E4140-0x00000001853E42E0
		// [IDTag] // 0x0000000189BC7E90-0x0000000189BC7ED0
		// [XID] // 0x0000000189BC7E90-0x0000000189BC7ED0
		public static bool Compare(ValueComparison cmp, int v0, int v1) => default; // 0x00000001853E45D0-0x00000001853E46D0
		// [IDTag] // 0x0000000189BD2B00-0x0000000189BD2B40
		// [XID] // 0x0000000189BD2B00-0x0000000189BD2B40
		public static bool Compare(ValueComparison cmp, float v0, float v1) => default; // 0x00000001853E44C0-0x00000001853E45D0
		public static bool In<T>(T v, T[] cands) => default;
		// [XID] // 0x0000000189BDD330-0x0000000189BDD350
		public static Vector3 Lerp(Vector3 v0, Vector3 v1, float t) => default; // 0x00000001853E68D0-0x00000001853E6AC0
		// [XID] // 0x00000001899DB000-0x00000001899DB020
		public static float ConstraintDegree(float d0, float d1, float maxDelta) => default; // 0x00000001853E46D0-0x00000001853E4880
		// [XID] // 0x00000001895F13A0-0x00000001895F13C0
		public static Quaternion LookRotation(Vector3 forward, Vector3 up) => default; // 0x00000001853E6FC0-0x00000001853E71D0
		// [XID] // 0x00000001899F1550-0x00000001899F1570
		public static Quaternion DeltaRotation(Quaternion from, Quaternion to) => default; // 0x00000001853E4CF0-0x00000001853E4E50
		// [XID] // 0x00000001896002F0-0x0000000189600310
		public static bool MatchAnimationZone(string[] zoneArray, string stateName, float t, AnimationPhaseArray phaseArray) => default; // 0x00000001853E71D0-0x00000001853E74C0
		// [XID] // 0x0000000189607980-0x00000001896079A0
		public static Vector3? RaycastDown(Vector3 pos) => default; // 0x00000001853E78B0-0x00000001853E7A70
		// [XID] // 0x00000001896DC420-0x00000001896DC440
		public static void DrawAnimatedJoints(Vector3[] inJoints, Color inColor) {} // 0x00000001853E5020-0x00000001853E50D0
		// [XID] // 0x0000000189616A10-0x0000000189616A30
		public static void DrawJoints(Vector3[] inJoints, Color inColor) {} // 0x00000001853E5970-0x00000001853E5A20
		public static T LoadJSONConfig<T>(string jsonPath)
			where T : class => default;
		// [XID] // 0x000000018967B180-0x000000018967B1A0
		public static string LoadTextFileToString(string filePath) => default; // 0x00000001853E6DD0-0x00000001853E6FC0
		// [XID] // 0x00000001899E4B60-0x00000001899E4B80
		public static Color HexToColor(string hex) => default; // 0x00000001853E6560-0x00000001853E6730
		// [XID] // 0x000000018962D160-0x000000018962D180
		public static float Truncate(float d) => default; // 0x00000001853E8330-0x00000001853E8430
	
		// Extension methods
		// [XID] // 0x0000000189A86BE0-0x0000000189A86C20
		public static GameObject xChild(this GameObject inRootGo, string inName) => default; // 0x00000001853E8520-0x00000001853E86B0
		// [XID] // 0x0000000189A91640-0x0000000189A91680
		public static void xTraverseDown(this GameObject inRootGo, TraverseCb cb) {} // 0x00000001853E8930-0x00000001853E8AD0
		// [XID] // 0x0000000189A9BCF0-0x0000000189A9BD30
		public static void xTraverseUp(this GameObject go, TraverseCb cb) {} // 0x00000001853E8AD0-0x00000001853E8C80
		// [XID] // 0x0000000189AA6440-0x0000000189AA6480
		public static string xLongName(this GameObject go, GameObject endGo) => default; // 0x00000001853E86B0-0x00000001853E8930
		// [XID] // 0x0000000189B98780-0x0000000189B987C0
		public static void FilterKeys(this AnimationCurve curve, int tag, FilterKeyCb cb) {} // 0x00000001853E5D20-0x00000001853E5FA0
	}
}
