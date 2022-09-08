/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ExtensionMethods // TypeDefIndex: 31541
{
	// Fields
	private const int ListDefaultCapacity = 4; // Metadata: 0x00B128DC
	private const int ListMaxCapacity = 2146435071; // Metadata: 0x00B128E0
	private const float ListCapacityFactor = 1.6f; // Metadata: 0x00B128E4

	// Nested types
	public class Vector2Comparer : IEqualityComparer<Vector2> // TypeDefIndex: 31542
	{
		// Constructors
		public Vector2Comparer() {} // 0x000000018464C6E0-0x000000018464C800

		// Methods
		// [XID] // 0x00000001898A8AC0-0x00000001898A8AE0
		public bool Equals(Vector2 v1, Vector2 v2) => default; // 0x000000018464C4D0-0x000000018464C630
		// [XID] // 0x00000001898B0470-0x00000001898B0490
		public int GetHashCode(Vector2 obj) => default; // 0x000000018464C630-0x000000018464C6E0
	}

	// Methods
	public static T[] Add<T>(T[] array, T obj) => default;

	// Extension methods
	// [XID] // 0x0000000189A097F0-0x0000000189A09830
	public static void SetPositionX(this Transform transform, float x) {} // 0x00000001846656E0-0x0000000184665800
	// [XID] // 0x0000000189A140E0-0x0000000189A14120
	public static void SetPositionY(this Transform transform, float y) {} // 0x0000000184663330-0x0000000184663440
	// [XID] // 0x0000000189A1E1C0-0x0000000189A1E200
	public static void SetPositionZ(this Transform transform, float z) {} // 0x0000000184663A00-0x0000000184663B10
	// [XID] // 0x0000000189A28720-0x0000000189A28760
	public static void AddPositionX(this Transform transform, float x) {} // 0x000000018465F4A0-0x000000018465F5A0
	// [XID] // 0x0000000189A32BD0-0x0000000189A32C10
	public static void AddPositionY(this Transform transform, float y) {} // 0x00000001846607B0-0x00000001846608B0
	// [XID] // 0x0000000189A3D520-0x0000000189A3D560
	public static void AddPositionZ(this Transform transform, float z) {} // 0x0000000184663D10-0x0000000184663E10
	// [XID] // 0x0000000189A47CF0-0x0000000189A47D30
	public static void SubPositionX(this Transform transform, float x) {} // 0x0000000184661800-0x00000001846618C0
	// [XID] // 0x0000000189A52260-0x0000000189A522A0
	public static void SubPositionY(this Transform transform, float y) {} // 0x00000001846653A0-0x0000000184665460
	// [XID] // 0x0000000189A5CDB0-0x0000000189A5CDF0
	public static void SubPositionZ(this Transform transform, float z) {} // 0x000000018465F5A0-0x000000018465F660
	// [XID] // 0x0000000189A67980-0x0000000189A679C0
	public static void SetPlatformPosition(this Transform transform, Vector3 pos) {} // 0x00000001846648A0-0x00000001846649D0
	// [XID] // 0x0000000189A71E80-0x0000000189A71EC0
	public static Vector3 ToVector3(this MoleMole.Config.Vector vec) => default; // 0x00000001846621F0-0x0000000184662340
	// [XID] // 0x0000000189A7C880-0x0000000189A7C8C0
	public static MoleMole.Config.Vector ToVector(this Vector3 vec3) => default; // 0x000000018465F2A0-0x000000018465F3E0
	// [XID] // 0x0000000189A87200-0x0000000189A87240
	public static Vector3 ProjLine(this Vector3 point, Vector3 start, Vector3 end) => default; // 0x0000000184664620-0x00000001846648A0
	// [XID] // 0x0000000189A919C0-0x0000000189A91A00
	public static Transform AddChildFromPrefab(this Transform trans, Transform prefab, string name = null) => default; // 0x000000018465FFE0-0x0000000184660190
	// [XID] // 0x0000000189A9BF80-0x0000000189A9BFC0
	public static void DestroyChildren(this Transform trans) {} // 0x0000000184664D10-0x0000000184664E70
	// [XID] // 0x0000000189AA6670-0x0000000189AA66B0
	public static void SetParentAndReset(this Transform trans, Transform parent) {} // 0x0000000184661C20-0x0000000184661D80
	// [XID] // 0x0000000189AB1290-0x0000000189AB12D0
	public static GameObject SetLayer(this GameObject go, int layer, bool setChildren = false /* Metadata: 0x00B128C5 */) => default; // 0x0000000184660570-0x00000001846606F0
	// [XID] // 0x0000000189ABBB70-0x0000000189ABBBB0
	public static GameObject SetLayerWithAllChildren(this GameObject go, int layer) => default; // 0x000000018465F720-0x000000018465F890
	// [XID] // 0x0000000189AC6480-0x0000000189AC64C0
	public static bool HasDirectChild(this Transform parent, Transform child) => default; // 0x0000000184662520-0x0000000184662660
	// [XID] // 0x0000000189AD0A60-0x0000000189AD0AA0
	public static Transform FindChildWithName(this Transform trans, string name) => default; // 0x0000000184664AC0-0x0000000184664D10
	// [XID] // 0x0000000189ADB740-0x0000000189ADB780
	public static Transform FindChildContainsName(this Transform trans, string name) => default; // 0x0000000184660BC0-0x0000000184660E30
	// [XID] // 0x0000000189AE6330-0x0000000189AE6370
	public static string GetRelativePath(this Transform trans, Transform baseTransform = null) => default; // 0x00000001846609C0-0x0000000184660BC0
	// [XID] // 0x0000000189AF0D80-0x0000000189AF0DC0
	public static Transform GetOrCreateChild(this Transform trans, string name) => default; // 0x0000000184660190-0x00000001846602E0
	public static T GetOrAddComponent<T>(this Transform trans)
		where T : Component => default;
	// [XID] // 0x0000000189B029C0-0x0000000189B02A00
	public static void SetLocalPositionX(this Transform transform, float x) {} // 0x00000001846618C0-0x00000001846619E0
	// [XID] // 0x0000000189B0CFA0-0x0000000189B0CFE0
	public static void SetLocalPositionY(this Transform transform, float y) {} // 0x00000001846608B0-0x00000001846609C0
	// [XID] // 0x0000000189B170C0-0x0000000189B17100
	public static void SetLocalPositionZ(this Transform transform, float z) {} // 0x0000000184660EF0-0x0000000184661000
	// [XID] // 0x0000000189B218F0-0x0000000189B21930
	public static void AddLocalPositionX(this Transform transform, float x) {} // 0x00000001846612D0-0x00000001846613D0
	// [XID] // 0x0000000189B2BF40-0x0000000189B2BF80
	public static void AddLocalPositionY(this Transform transform, float y) {} // 0x0000000184663540-0x0000000184663640
	// [XID] // 0x0000000189B36430-0x0000000189B36470
	public static void AddLocalPositionZ(this Transform transform, float z) {} // 0x0000000184662D30-0x0000000184662E30
	// [XID] // 0x0000000189B40E30-0x0000000189B40E70
	public static void SubLocalPositionX(this Transform transform, float x) {} // 0x0000000184661D80-0x0000000184661E40
	// [XID] // 0x0000000189B4B640-0x0000000189B4B680
	public static void SubLocalPositionY(this Transform transform, float y) {} // 0x00000001846606F0-0x00000001846607B0
	// [XID] // 0x0000000189B55FA0-0x0000000189B55FE0
	public static void SubLocalPositionZ(this Transform transform, float z) {} // 0x0000000184660E30-0x0000000184660EF0
	// [XID] // 0x0000000189B60920-0x0000000189B60960
	public static void SetLocalScaleX(this Transform transform, float x) {} // 0x00000001846655C0-0x00000001846656E0
	// [XID] // 0x0000000189B6AEC0-0x0000000189B6AF00
	public static void SetLocalScaleY(this Transform transform, float y) {} // 0x0000000184662A60-0x0000000184662B70
	// [XID] // 0x0000000189B75270-0x0000000189B752B0
	public static void SetLocalScaleZ(this Transform transform, float z) {} // 0x0000000184665070-0x0000000184665180
	// [XID] // 0x0000000189B7F810-0x0000000189B7F850
	public static void AddLocalScaleX(this Transform transform, float x) {} // 0x00000001846615F0-0x00000001846616F0
	// [XID] // 0x0000000189B8A130-0x0000000189B8A170
	public static void AddLocalScaleY(this Transform transform, float y) {} // 0x0000000184663440-0x0000000184663540
	// [XID] // 0x0000000189B94400-0x0000000189B94440
	public static void AddLocalScaleZ(this Transform transform, float z) {} // 0x000000018465FC40-0x000000018465FD40
	// [XID] // 0x0000000189B9E6E0-0x0000000189B9E720
	public static void SubLocalScaleX(this Transform transform, float x) {} // 0x0000000184662340-0x0000000184662400
	// [XID] // 0x0000000189BA8B90-0x0000000189BA8BD0
	public static void SubLocalScaleY(this Transform transform, float y) {} // 0x000000018465F980-0x000000018465FA40
	// [XID] // 0x0000000189BB31E0-0x0000000189BB3220
	public static void SubLocalScaleZ(this Transform transform, float z) {} // 0x0000000184662B70-0x0000000184662C30
	// [XID] // 0x0000000189BBD7E0-0x0000000189BBD820
	public static void SetLocalEulerAnglesX(this Transform transform, float x) {} // 0x0000000184662400-0x0000000184662520
	// [XID] // 0x0000000189BC8460-0x0000000189BC84A0
	public static void SetLocalEulerAnglesY(this Transform transform, float y) {} // 0x00000001846616F0-0x0000000184661800
	// [XID] // 0x0000000189BD2CE0-0x0000000189BD2D20
	public static void SetLocalEulerAnglesZ(this Transform transform, float z) {} // 0x00000001846641B0-0x0000000184664300
	// [XID] // 0x0000000189BDD600-0x0000000189BDD640
	public static void AddLocalEulerAnglesX(this Transform transform, float x) {} // 0x00000001846620F0-0x00000001846621F0
	// [XID] // 0x00000001895ED0B0-0x00000001895ED0F0
	public static void AddLocalEulerAnglesY(this Transform transform, float y) {} // 0x0000000184662C30-0x0000000184662D30
	// [XID] // 0x00000001895F7B50-0x00000001895F7B90
	public static void AddLocalEulerAnglesZ(this Transform transform, float z) {} // 0x0000000184665800-0x0000000184665900
	// [XID] // 0x0000000189602000-0x0000000189602040
	public static void SubLocalEulerAnglesX(this Transform transform, float x) {} // 0x00000001846640F0-0x00000001846641B0
	// [XID] // 0x000000018960C810-0x000000018960C850
	public static void SubLocalEulerAnglesY(this Transform transform, float y) {} // 0x00000001846603A0-0x0000000184660460
	// [XID] // 0x0000000189616BB0-0x0000000189616BF0
	public static void SubLocalEulerAnglesZ(this Transform transform, float z) {} // 0x000000018465F3E0-0x000000018465F4A0
	// [XID] // 0x00000001896214F0-0x0000000189621530
	public static void SetAlpha(this UnityEngine.Material material, float a) {} // 0x00000001846619E0-0x0000000184661B40
	// [XID] // 0x000000018962BA90-0x000000018962BAD0
	public static void SetStartAlpha(this ParticleSystem particleSystem, float a) {} // 0x0000000184661E40-0x00000001846620F0
	public static void RemoveAllNulls<T>(this IList<T?> ls)
		where T : struct {}
	public static void RemoveAllNulls<T>(this IList<T> ls) {}
	// [XID] // 0x0000000189645720-0x0000000189645760
	public static void AddNoNull(this IList<AsyncJob> ls, AsyncJob job) {} // 0x0000000184665460-0x00000001846655C0
	public static bool CheckIsAllNulls<T>(this IList<T?> ls)
		where T : struct => default;
	public static bool CheckIsAllNulls<T>(this IList<T> ls) => default;
	public static void RemoveNullKeys<T1, T2>(this Dictionary<T1, T2> dict)
		where T1 : Component {}
	public static void Merge<T1, T2>(this IDictionary<T1, T2> first, IDictionary<T1, T2> second, bool overrideIfSameKey = false /* Metadata: 0x00B128C6 */) {}
	public static bool TryAdd<T1, T2>(this IDictionary<T1, T2> dict, T1 t1, T2 t2) => default;
	public static int SeekAddPosition<T>(this List<T> ls)
		where T : class => default;
	public static int SeekAddPosition<T>(this List<T?> ls)
		where T : struct => default;
	// [XID] // 0x00000001896847C0-0x0000000189684800
	public static int SeekAddPosition(this List<int> ls) => default; // 0x0000000184660460-0x0000000184660570
	public static void ExpandToInclude<T>(this List<T> ls, int ix)
		where T : class {}
	public static void EnsureCapacity<T>(this List<T> list, int minSize) {}
	public static void Resize<T>(this List<T> list, int sz, T c = default) {}
	public static void ResizeWithNew<T>(this List<T> list, int sz, T c = default)
		where T : new() {}
	public static bool Contains<T>(this T[] array, T obj, IEqualityComparer<T> comparer = null) => default;
	public static bool HasDifferences<T>(this IEnumerable<T> set1, IEnumerable<T> set2, List<T> extraPart = null, List<T> missingPart = null) => default;
	public static T ToEnum<T>(this string value, T defaultValue = default) => default;
	// [XID] // 0x00000001896C2B60-0x00000001896C2BA0
	public static bool ContainsLayer(this LayerMask layerMask, int layer) => default; // 0x000000018465F130-0x000000018465F1F0
	// [IDTag] // 0x00000001896CD2B0-0x00000001896CD300
	// [XID] // 0x00000001896CD2B0-0x00000001896CD300
	public static bool HasBitSet(this byte mask, int n) => default; // 0x0000000184662FF0-0x0000000184663110
	// [IDTag] // 0x00000001896DA7E0-0x00000001896DA830
	// [XID] // 0x00000001896DA7E0-0x00000001896DA830
	public static bool HasBitSet(this ushort mask, int n) => default; // 0x0000000184663220-0x0000000184663330
	// [IDTag] // 0x00000001896E7A00-0x00000001896E7A50
	// [XID] // 0x00000001896E7A00-0x00000001896E7A50
	public static bool HasBitSet(this uint mask, int n) => default; // 0x0000000184662EE0-0x0000000184662FF0
	// [IDTag] // 0x00000001896F5080-0x00000001896F50D0
	// [XID] // 0x00000001896F5080-0x00000001896F50D0
	public static bool HasBitSet(this ulong mask, int n) => default; // 0x0000000184663110-0x0000000184663220
	// [XID] // 0x0000000189702780-0x00000001897027C0
	public static bool ContainsState(this AbilityState abilityState, AbilityState targetState) => default; // 0x000000018465F1F0-0x000000018465F2A0
	// [XID] // 0x000000018970D010-0x000000018970D050
	public static bool ContainsStates(this AbilityState abilityState, AbilityState[] targetStates) => default; // 0x0000000184663640-0x0000000184663730
	// [IDTag] // 0x0000000189717320-0x0000000189717370
	// [XID] // 0x0000000189717320-0x0000000189717370
	public static void SetTriggerNoWarning(this Animator animator, string name) {} // 0x0000000184663820-0x0000000184663910
	// [IDTag] // 0x0000000189724980-0x00000001897249D0
	// [XID] // 0x0000000189724980-0x00000001897249D0
	public static void SetTriggerNoWarning(this Animator animator, int id) {} // 0x0000000184663910-0x0000000184663A00
	// [IDTag] // 0x00000001897321E0-0x0000000189732230
	// [XID] // 0x00000001897321E0-0x0000000189732230
	public static void ResetTriggerNoWarning(this Animator animator, string name) {} // 0x0000000184662660-0x0000000184662750
	// [IDTag] // 0x0000000189740000-0x0000000189740050
	// [XID] // 0x0000000189740000-0x0000000189740050
	public static void ResetTriggerNoWarning(this Animator animator, int id) {} // 0x0000000184662750-0x0000000184662840
	// [IDTag] // 0x000000018974D540-0x000000018974D590
	// [XID] // 0x000000018974D540-0x000000018974D590
	public static void SetBoolNoWarning(this Animator animator, string name, bool value) {} // 0x0000000184662950-0x0000000184662A60
	// [IDTag] // 0x000000018975A410-0x000000018975A460
	// [XID] // 0x000000018975A410-0x000000018975A460
	public static void SetBoolNoWarning(this Animator animator, int id, bool value) {} // 0x0000000184662840-0x0000000184662950
	// [IDTag] // 0x0000000189767CC0-0x0000000189767D10
	// [XID] // 0x0000000189767CC0-0x0000000189767D10
	public static void SetIntegerNoWarning(this Animator animator, string name, int value) {} // 0x0000000184663F20-0x0000000184664030
	// [IDTag] // 0x0000000189775320-0x0000000189775370
	// [XID] // 0x0000000189775320-0x0000000189775370
	public static void SetIntegerNoWarning(this Animator animator, int id, int value) {} // 0x0000000184663E10-0x0000000184663F20
	// [IDTag] // 0x0000000189782D70-0x0000000189782DC0
	// [XID] // 0x0000000189782D70-0x0000000189782DC0
	public static void SetFloatNoWarning(this Animator animator, string name, float value, float dampTime = 0f /* Metadata: 0x00B128C7 */, float deltaTime = 0f /* Metadata: 0x00B128CB */) {} // 0x000000018465FD40-0x000000018465FE90
	// [IDTag] // 0x0000000189790230-0x0000000189790280
	// [XID] // 0x0000000189790230-0x0000000189790280
	public static void SetFloatNoWarning(this Animator animator, int id, float value, float dampTime = 0f /* Metadata: 0x00B128CF */, float deltaTime = 0f /* Metadata: 0x00B128D3 */) {} // 0x000000018465FE90-0x000000018465FFE0
	// [IDTag] // 0x000000018979E340-0x000000018979E390
	// [XID] // 0x000000018979E340-0x000000018979E390
	public static bool GetTriggerNoWarning(this Animator animator, string name) => default; // 0x0000000184663C10-0x0000000184663D10
	// [IDTag] // 0x00000001897AB310-0x00000001897AB360
	// [XID] // 0x00000001897AB310-0x00000001897AB360
	public static bool GetTriggerNoWarning(this Animator animator, int id) => default; // 0x0000000184663B10-0x0000000184663C10
	// [IDTag] // 0x00000001897B9130-0x00000001897B9180
	// [XID] // 0x00000001897B9130-0x00000001897B9180
	public static bool GetBoolNoWarning(this Animator animator, int id) => default; // 0x000000018465FA40-0x000000018465FB40
	// [IDTag] // 0x00000001897C75D0-0x00000001897C7620
	// [XID] // 0x00000001897C75D0-0x00000001897C7620
	public static bool GetBoolNoWarning(this Animator animator, string name) => default; // 0x000000018465FB40-0x000000018465FC40
	// [IDTag] // 0x00000001897D49C0-0x00000001897D4A10
	// [XID] // 0x00000001897D49C0-0x00000001897D4A10
	public static int GetIntegerNoWarning(this Animator animator, string name) => default; // 0x0000000184664F70-0x0000000184665070
	// [IDTag] // 0x00000001897E22D0-0x00000001897E2320
	// [XID] // 0x00000001897E22D0-0x00000001897E2320
	public static int GetIntegerNoWarning(this Animator animator, int id) => default; // 0x0000000184664E70-0x0000000184664F70
	// [IDTag] // 0x00000001897EFC00-0x00000001897EFC50
	// [XID] // 0x00000001897EFC00-0x00000001897EFC50
	public static float GetFloatNoWarning(this Animator animator, string name) => default; // 0x0000000184665290-0x00000001846653A0
	// [IDTag] // 0x00000001897FD4B0-0x00000001897FD500
	// [XID] // 0x00000001897FD4B0-0x00000001897FD500
	public static float GetFloatNoWarning(this Animator animator, int id) => default; // 0x0000000184665180-0x0000000184665290
	// [XID] // 0x000000018980AAA0-0x000000018980AAE0
	public static void GetBindPose(this SkinnedMeshRenderer smr, Dictionary<Transform, Matrix4x4> bindPoseMap) {} // 0x0000000184664300-0x0000000184664530
	// [XID] // 0x0000000189815060-0x00000001898150A0
	public static void ResetAllSkinnedMeshToBindpose(this Transform transform, Dictionary<Transform, Matrix4x4> bindPoseMap) {} // 0x0000000184661000-0x0000000184661150
	// [XID] // 0x000000018981FCD0-0x000000018981FD10
	public static void Replay(this Animation animation, string name, float time = 0f /* Metadata: 0x00B128D7 */) {} // 0x0000000184661150-0x00000001846612D0
	// [XID] // 0x000000018982A2B0-0x000000018982A2F0
	public static void Destroy(this UnityEngine.Object obj) {} // 0x00000001846602E0-0x00000001846603A0
	// [XID] // 0x0000000189834720-0x0000000189834760
	public static Transform RandomChild(this Transform t) => default; // 0x0000000184663730-0x0000000184663820
	// [XID] // 0x000000018983ECF0-0x000000018983ED30
	public static void DestroyImmediate(this UnityEngine.Object obj) {} // 0x0000000184664030-0x00000001846640F0
	public static T GetOrAddComponent<T>(this GameObject go)
		where T : Component => default;
	// [XID] // 0x00000001898506B0-0x00000001898506F0
	public static Mesh GetMesh(this MeshFilter meshFilter) => default; // 0x00000001846649D0-0x0000000184664AC0
	// [XID] // 0x000000018985ACE0-0x000000018985AD20
	public static ElementType UIType(this ElementType elementType) => default; // 0x0000000184662E30-0x0000000184662EE0
	// [XID] // 0x0000000189864ED0-0x0000000189864F10
	public static void Clear(this StringBuilder value, bool clearMemory = true /* Metadata: 0x00B128DB */) {} // 0x0000000184661B40-0x0000000184661C20
	// [XID] // 0x000000018986F2D0-0x000000018986F310
	public static int GetStringHashCode(this StringBuilder value) => default; // 0x000000018465F890-0x000000018465F980
	// [XID] // 0x0000000189879EB0-0x0000000189879EF0
	public static bool ElapseMillisecondsOverThreshold(this Stopwatch stopwatch, float threshold) => default; // 0x0000000184664530-0x0000000184664620
	// [XID] // 0x0000000189883B70-0x0000000189883BB0
	public static bool Empty(this ICollection c) => default; // 0x000000018465F660-0x000000018465F720
	// [IDTag] // 0x000000018988DF70-0x000000018988DFC0
	// [XID] // 0x000000018988DF70-0x000000018988DFC0
	public static void SetText(this UnityEngine.UI.Text textComp, string str) {} // 0x00000001846614F0-0x00000001846615F0
	// [IDTag] // 0x000000018989B730-0x000000018989B780
	// [XID] // 0x000000018989B730-0x000000018989B780
	public static void SetText(this UnityEngine.UI.Text textComp, object obj) {} // 0x00000001846613D0-0x00000001846614F0
}

