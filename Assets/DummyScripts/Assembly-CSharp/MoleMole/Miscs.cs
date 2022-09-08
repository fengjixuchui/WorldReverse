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
using Dest.Math;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public static class Miscs // TypeDefIndex: 31603
	{
		// Fields
		public static int[] EMPTY_INTS; // 0x00
		public static string[] EMPTY_STRINGS; // 0x08
		public static ulong EMPTY_PATH_HASH; // 0x10
		private static RaycastHit[] raycastHits; // 0x18
		private const float RAYCAST_PULL_BACK = 1f; // Metadata: 0x00B13431
		private const float RAYCAST_DOWN_DISTANCE = 10f; // Metadata: 0x00B13435
		private const int HEIGHTMAP_SIZE = 2; // Metadata: 0x00B13439
		private const float HEIGHTMAP_SCAN_BOX_WIDTH = 0.3f; // Metadata: 0x00B1343D
		private const float HEIGHTMAP_SCAN_BOX_HEIGHT = 10f; // Metadata: 0x00B13441
		private static ProjectedHeightmap _heightMap; // 0x20
		private static Camera _mainCanvasCamera; // 0x28
		private static List<string> _codes; // 0x30
		public static System.Random ranSystem; // 0x38
		public const float EPSILON = 0.0001f; // Metadata: 0x00B13445
		public static string SPECIAL_WATER_SURFACE; // 0x40
		private static int _staticSceneLayerMask; // 0x48
		private static int _sceneLayerMask; // 0x4C
		private static int _sceneTriggerLayerMask; // 0x50
		private static int _sceneLayerMaskWithWater; // 0x54
		private static int _groundLayerMaskWithoutTemp; // 0x58
		private static int _bulletHitLayerMask; // 0x5C
		private static int _characterLayerMask; // 0x60
		private static int _sceneCameraLayerMask; // 0x64
		private static int _sceneCameraLayerMaskWithWater; // 0x68
		private static string postfix; // 0x70
		private static string origin_postfix; // 0x78
		private static string subName; // 0x80
		private static string subFullName; // 0x88
		private static string subVFullName; // 0x90
		private static string subAniFullName; // 0x98
		private static string commonOutputPattern; // 0xA0
		private static string anyPattern; // 0xA8
		private static string cutsceneFilePattern; // 0xB0
		private static string cameraAniFilePattern; // 0xB8
		private static string emotionFilePattern; // 0xC0
		private static string physiqueName; // 0xC8
		private static string physiquePattern; // 0xD0
		private static string assetPattern; // 0xD8
		private static SortTargetsNearestComparer _sortTargetsNearestComparer; // 0xE0
		private static SortTargetsHigherScoreComparer _sortTargetsHigherScoreComparer; // 0xE8
		public const ushort HalfShortMax = 32767; // Metadata: 0x00B13449
		public const short HalfShort8Max = 128; // Metadata: 0x00B1344B
		private static ConfigChannel _configChannel; // 0xF0
		public static Dictionary<int, string> DeviceGenerationName; // 0xF8
		private static GameObject _scenePropRoot; // 0x100
		private static GameObject _uiDummyRoot; // 0x108
		private static GameObject _uiSceneRoot; // 0x110
		private static GameObject _pluginRoot; // 0x118
		private static GameObject _stageRoot; // 0x120
		private static object lockObj; // 0x130
		public static string[] entityDropPoints; // 0x138
	
		// Properties
		public static Camera mainCanvasCamera { /* [XID] */ /* 0x000000018985ACC0-0x000000018985ACE0 */ get; /* [XID] */ /* 0x0000000189862150-0x0000000189862170 */ set; } // 0x0000000181180450-0x0000000181180520 0x00000001811805B0-0x0000000181180680
		public static Transform ScenePropRoot { /* [XID] */ /* 0x0000000189903310-0x0000000189903330 */ get; } // 0x000000018117FD10-0x000000018117FEB0 
		public static Transform UIDummyRoot { /* [XID] */ /* 0x000000018990A880-0x000000018990A8A0 */ get; } // 0x0000000181180050-0x00000001811802B0 
		public static Transform UISceneRoot { /* [XID] */ /* 0x0000000189912490-0x00000001899124B0 */ get; } // 0x00000001811802B0-0x0000000181180450 
		public static Transform PluginRoot { /* [XID] */ /* 0x0000000189919DB0-0x0000000189919DD0 */ get; } // 0x000000018117FB70-0x000000018117FD10 
		public static Transform StageRoot { /* [XID] */ /* 0x0000000189921620-0x0000000189921640 */ get; } // 0x000000018117FEB0-0x0000000181180050 
		public static byte[] robotCheckLoginInputData { /* [XID] */ /* 0x00000001899646A0-0x00000001899646E0 */ private get; /* [XID] */ /* 0x000000018996EAF0-0x000000018996EB30 */ set; } // 0x0000000181180520-0x00000001811805B0 0x0000000181180680-0x00000001811808B0
	
		// Nested types
		private class SortTargetsNearestComparer : IComparer<ActorAbilityPlugin.AbilityAttackTarget> // TypeDefIndex: 31604
		{
			// Constructors
			public SortTargetsNearestComparer() {} // 0x0000000184C7E510-0x0000000184C7E570
	
			// Methods
			// [XID] // 0x0000000189A930C0-0x0000000189A930E0
			public int Compare(ActorAbilityPlugin.AbilityAttackTarget l, ActorAbilityPlugin.AbilityAttackTarget r) => default; // 0x0000000184C7E400-0x0000000184C7E510
		}
	
		private class SortTargetsHigherScoreComparer : IComparer<ActorAbilityPlugin.AbilityAttackTarget> // TypeDefIndex: 31605
		{
			// Constructors
			public SortTargetsHigherScoreComparer() {} // 0x0000000184C7E3A0-0x0000000184C7E400
	
			// Methods
			// [XID] // 0x0000000189A9AB10-0x0000000189A9AB30
			public int Compare(ActorAbilityPlugin.AbilityAttackTarget l, ActorAbilityPlugin.AbilityAttackTarget r) => default; // 0x0000000184C7E200-0x0000000184C7E3A0
		}
	
		public enum VersionStringType // TypeDefIndex: 31606
		{
			Full = 0,
			Project = 1,
			Resource = 2
		}
	
		public enum ChangeAvatarFailType // TypeDefIndex: 31607
		{
			NONE = 0,
			FAIL_AIM = 1,
			FAIL_CLIMB = 2,
			FAIL_FLY = 3,
			FAIL_JUMP = 4,
			FAIL_LADDER = 5,
			FAIL_SWIM = 6,
			FAIL_IN_PROCESS = 7,
			FAIL_LEVEL_FORBIDDEN = 8,
			FAIL_TARGETAVATAR = 9,
			FAIL_PERFORM = 10,
			FAIL_DEAD = 11,
			FAIL_COOLDOWN = 12
		}
	
		public struct ScopeUnityProfilerSample : IDisposable // TypeDefIndex: 31608
		{
			// Constructors
			public ScopeUnityProfilerSample(string sampleName) {} // 0x0000000184C7E1F0-0x0000000184C7E200
	
			// Methods
			// [XID] // 0x0000000189AA1DD0-0x0000000189AA1DF0
			public void Dispose() {} // 0x0000000184C7E150-0x0000000184C7E1F0
		}
	
		public enum ServerType // TypeDefIndex: 31609
		{
			None = 0,
			USA = 1,
			EUR = 2
		}
	
		public enum MediumDownloadDialogType // TypeDefIndex: 31610
		{
			NewComerLogin = 1,
			ProficientLogin = 2,
			NewComerFinishQuest = 3,
			CarrierNetwork = 4
		}
	
		public enum ReportEventType // TypeDefIndex: 31611
		{
			DownloadReport = 100001,
			GameQAReport = 100002,
			WarningAlarm = 100003
		}
	
		public enum DownloadReportActionType // TypeDefIndex: 31612
		{
			DownloadChoice = 1011,
			DownloadResult = 1012
		}
	
		// Constructors
		static Miscs() {} // 0x000000018117F360-0x000000018117FB70
	
		// Methods
		// [XID] // 0x00000001899DF7A0-0x00000001899DF7C0
		public static Collider GetColliderFromGameObjectByLayer(GameObject gameObject, int layer) => default; // 0x00000001811634D0-0x0000000181163620
		// [XID] // 0x0000000189667AF0-0x0000000189667B10
		public static void AddGameObjectEntityIdentifer(uint handle, GameObject prefab) {} // 0x000000018114E4C0-0x000000018114E5B0
		// [XID] // 0x00000001897C26C0-0x00000001897C26E0
		public static void ResetGameObjectEntityIdentifer(uint handle, GameObject prefab) {} // 0x0000000181178CB0-0x0000000181178DA0
		// [XID] // 0x00000001895FBD50-0x00000001895FBD70
		public static void RemoveGameObjectEntityIdentifer(GameObject prefab) {} // 0x0000000181178BD0-0x0000000181178CB0
		// [XID] // 0x00000001897DC080-0x00000001897DC0A0
		public static BaseEntity GetEntityFromGameObejct(GameObject gameObject) => default; // 0x00000001811658A0-0x0000000181165980
		// [XID] // 0x00000001897E3890-0x00000001897E38B0
		public static GameObject GetIdentiferGameObject(GameObject gameObject) => default; // 0x0000000181167BF0-0x0000000181167CD0
		// [XID] // 0x00000001897EB5E0-0x00000001897EB600
		public static float SphereDistanceSquare(Vector3 pos1, Vector3 pos2) => default; // 0x000000018117D800-0x000000018117D920
		// [IDTag] // 0x00000001897F2F40-0x00000001897F2F80
		// [XID] // 0x00000001897F2F40-0x00000001897F2F80
		public static float CalcCurrentGroundHeight(float x, float z) => default; // 0x000000018114E910-0x000000018114EA10
		// [XID] // 0x00000001897FD470-0x00000001897FD490
		public static float CalcCurrentWaterHeight(Vector3 pos, float rayUpLength = 2f /* Metadata: 0x00B133F0 */, float rayDetectLength = 4f /* Metadata: 0x00B133F4 */) => default; // 0x000000018114F0D0-0x000000018114F230
		// [XID] // 0x0000000189804A40-0x0000000189804A60
		public static float CalcCurrentGroundWaterHeight(float x, float z) => default; // 0x000000018114EEB0-0x000000018114EFB0
		// [XID] // 0x000000018980C090-0x000000018980C0B0
		public static float CalcCurrentHeightByLayer(float x, float z, int layer) => default; // 0x000000018114EFB0-0x000000018114F0D0
		// [IDTag] // 0x0000000189813760-0x00000001898137A0
		// [XID] // 0x0000000189813760-0x00000001898137A0
		public static float CalcCurrentGroundHeight(float x, float z, float rayStartHeight, float rayDetectLength, int layer) => default; // 0x000000018114E5B0-0x000000018114E910
		// [IDTag] // 0x000000018981E2A0-0x000000018981E2E0
		// [XID] // 0x000000018981E2A0-0x000000018981E2E0
		public static bool RaycastTest(Ray ray, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, int layermask, Color color, bool drawLine = false /* Metadata: 0x00B133F8 */) {
			normal = default;
			hitPoint = default;
			hitDistance = default;
			return default;
		} // 0x0000000181177D50-0x0000000181177F60
		// [IDTag] // 0x0000000189828AD0-0x0000000189828B10
		// [XID] // 0x0000000189828AD0-0x0000000189828B10
		public static bool RaycastTest(Ray ray, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, out int hitTriangleIndex, int layermask, Color color, bool drawLine = false /* Metadata: 0x00B133F9 */) {
			normal = default;
			hitPoint = default;
			hitDistance = default;
			hitTriangleIndex = default;
			return default;
		} // 0x0000000181177B40-0x0000000181177D50
		// [IDTag] // 0x0000000189832FB0-0x0000000189832FF0
		// [XID] // 0x0000000189832FB0-0x0000000189832FF0
		public static bool RaycastTest(Ray ray, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, out int hitTriangleIndex, out Collider collider, int layermask, Color color, float drawDuration = 0f /* Metadata: 0x00B133FA */) {
			normal = default;
			hitPoint = default;
			hitDistance = default;
			hitTriangleIndex = default;
			collider = default;
			return default;
		} // 0x0000000181177F60-0x0000000181178590
		// [XID] // 0x000000018983D450-0x000000018983D470
		public static bool RaycastSimpleTest(Ray ray, float detectLength, int layermask, Color color, float drawDuration = 0f /* Metadata: 0x00B133FE */) => default; // 0x00000001811779C0-0x0000000181177B40
		// [XID] // 0x0000000189844CB0-0x0000000189844CD0
		public static int RaycastAllTest(Ray ray, float detectLength, out RaycastHit[] raycastHitsOut, int layermask, Color color, float drawDuration = 0f /* Metadata: 0x00B13402 */) {
			raycastHitsOut = default;
			return default;
		} // 0x0000000181177670-0x00000001811779C0
		// [XID] // 0x000000018984C070-0x000000018984C090
		public static Vector3 CalcCurrentGroundNorm(Vector3 pos) => default; // 0x000000018114EA10-0x000000018114EEB0
		// [XID] // 0x0000000189853170-0x0000000189853190
		public static Vector3 GetRealTargetCamPos(Vector3 originPos, Vector3 targetPos, Camera cam) => default; // 0x00000001811701F0-0x0000000181170740
		public static T GetLogicComponentFromEntity<T>(uint runtimeID, int metaTypeID)
			where T : LCBase => default;
		public static T GetVisualComponentFromEntity<T>(uint runtimeID, int metaTypeID)
			where T : VCBase => default;
		// [XID] // 0x0000000189869630-0x0000000189869650
		public static void ParseAnimatorEventEntry(ConfigAnimatorEventPattern patternConfig) {} // 0x0000000181176400-0x0000000181176550
		// [XID] // 0x0000000189870870-0x0000000189870890
		public static AnimatorEventEntry[] ConvertToAnimatorEventEntries(AnimatorEvent[] animatorEvents) => default; // 0x0000000181155290-0x0000000181155460
		// [XID] // 0x0000000189878300-0x0000000189878320
		public static AnimatorEvent[] ConvertToAnimatorEvents(AnimatorEventEntry[] entries) => default; // 0x0000000181155B30-0x0000000181155CE0
		// [IDTag] // 0x000000018987F7B0-0x000000018987F7F0
		// [XID] // 0x000000018987F7B0-0x000000018987F7F0
		public static ConfigAnimatorEventPattern ConvertToAnimatorEventPattern(ConfigAnimatorEventPatternFullInspector animatorEventPatternFI) => default; // 0x0000000181155A40-0x0000000181155B30
		// [IDTag] // 0x0000000189889BC0-0x0000000189889C00
		// [XID] // 0x0000000189889BC0-0x0000000189889C00
		public static void ConvertToAnimatorEventPattern(ConfigAnimatorEventPatternFullInspector animatorEventPatternFI, ConfigAnimatorEventPattern config) {} // 0x0000000181155750-0x0000000181155A40
		// [XID] // 0x00000001898941F0-0x0000000189894210
		public static ConfigAnimatorEventPatternFullInspector ConvertToAnimatorEventPatternFullInspector(ConfigAnimatorEventPattern patternConfig) => default; // 0x0000000181155460-0x0000000181155750
		// [XID] // 0x0000000189A53790-0x0000000189A537B0
		public static DieStateFlag GetDieStateFlag(PlayerDieType dieType) => default; // 0x0000000181165330-0x00000001811653F0
		// [IDTag] // 0x00000001898CB3A0-0x00000001898CB3E0
		// [XID] // 0x00000001898CB3A0-0x00000001898CB3E0
		public static Vector ToProto(Vector3 refVec, Vector protoVec) => default; // 0x000000018117DA00-0x000000018117DB30
		// [IDTag] // 0x00000001898D5A40-0x00000001898D5A80
		// [XID] // 0x00000001898D5A40-0x00000001898D5A80
		public static ShapeBox ToProto(Box3 box3, ShapeBox protoBox) => default; // 0x000000018117DB30-0x000000018117DDE0
		// [IDTag] // 0x00000001898EE270-0x00000001898EE2B0
		// [XID] // 0x00000001898EE270-0x00000001898EE2B0
		public static Vector3Int ToProto(Vector3 refVec, Vector3Int protoVec) => default; // 0x000000018117DDE0-0x000000018117DF40
		// [IDTag] // 0x00000001898F8BA0-0x00000001898F8BE0
		// [XID] // 0x00000001898F8BA0-0x00000001898F8BE0
		public static MathQuaternion ToProto(Quaternion refQuaternion, MathQuaternion protoQ) => default; // 0x000000018117DF40-0x000000018117E080
		public static Dictionary<TKey, TValue> FromPbcMapToDictionary<TKey, TValue>(MapField<TKey, TValue> pbcMap) => default;
		public static List<T> SampleList<T>(List<T> input, int num) => default;
		public static List<T> ListRandom<T>(List<T> myList) => default;
		// [XID] // 0x000000018992A4B0-0x000000018992A4D0
		public static string EncryptUID(uint uid) => default; // 0x0000000181156DD0-0x0000000181156FE0
		// [XID] // 0x00000001899319E0-0x0000000189931A00
		public static string ConvertToDebugString(IDictionary inDict) => default; // 0x0000000181155CE0-0x0000000181156290
		// [XID] // 0x0000000189940790-0x00000001899407B0
		public static Vector2 GetXZ(Vector3 vec) => default; // 0x0000000181172E10-0x0000000181172F00
		// [XID] // 0x0000000189948030-0x0000000189948050
		public static float GetLerpRatioValue(float value, float lastValue) => default; // 0x0000000181168400-0x00000001811684D0
		// [XID] // 0x00000001897FD170-0x00000001897FD190
		public static float GetEuler0To360(float value) => default; // 0x0000000181165980-0x0000000181165A50
		// [XID] // 0x0000000189956D90-0x0000000189956DB0
		public static float To360Angle(float f) => default; // 0x000000018117D920-0x000000018117DA00
		// [XID] // 0x000000018995E8A0-0x000000018995E8C0
		public static bool IsSameAngle(float a, float b, float epsilon = 0.0001f /* Metadata: 0x00B13406 */) => default; // 0x00000001811745D0-0x0000000181174700
		// [XID] // 0x0000000189965FE0-0x0000000189966000
		public static float Lerp(float v1, float v2, float speed) => default; // 0x0000000181174A20-0x0000000181174B70
		// [XID] // 0x000000018996D4A0-0x000000018996D4C0
		public static float ColliderDistanceAlongAxis(Collider collider, Vector3 axis, out Vector3 dotAxis) {
			dotAxis = default;
			return default;
		} // 0x0000000181153D40-0x00000001811544A0
		public static int ArrayRefCountOf<T>(T[] arr, T element)
			where T : class => default;
		// [XID] // 0x0000000189B2D300-0x0000000189B2D320
		public static string GetGadgetName(BaseEntity entity) => default; // 0x00000001811662D0-0x0000000181166430
		// [XID] // 0x000000018997C240-0x000000018997C260
		public static string GetGadgetInteractionTitle(BaseEntity entity) => default; // 0x0000000181165BE0-0x00000001811662D0
		// [XID] // 0x000000018998E8F0-0x000000018998E910
		public static bool IsInLoadingScene() => default; // 0x0000000181174000-0x0000000181174100
		// [XID] // 0x00000001899964D0-0x00000001899964F0
		public static uint GetTimeStampFromDateTime(DateTime datetime) => default; // 0x0000000181172110-0x0000000181172270
		// [XID] // 0x000000018999DFD0-0x000000018999DFF0
		public static DateTime GetDateTimeFromTimeStamp(uint timeStamp) => default; // 0x0000000181164B00-0x0000000181164C10
		// [XID] // 0x00000001899A5A30-0x00000001899A5A50
		public static string GetLocalizedDateTime(uint timeStamp) => default; // 0x00000001811684D0-0x00000001811688B0
		// [XID] // 0x00000001899AD0B0-0x00000001899AD0D0
		public static DateTime GetDateTimeFromMilliTimeStamp(ulong timeStamp) => default; // 0x00000001811649E0-0x0000000181164B00
		// [XID] // 0x00000001899B48F0-0x00000001899B4910
		public static string GetTransformPath(Transform trans, Transform parent = null) => default; // 0x0000000181172350-0x0000000181172430
		public static bool ArrayContains<T>(T[] array, T element) => default;
		// [XID] // 0x00000001899BBF80-0x00000001899BBFA0
		public static string GetDebugAbilityEntityName(LCAbility lcAbility) => default; // 0x0000000181164C10-0x0000000181164E60
		// [XID] // 0x00000001899C3AB0-0x00000001899C3AD0
		public static void InitLayerMask() {} // 0x0000000181173260-0x0000000181173550
		// [XID] // 0x00000001899CB0D0-0x00000001899CB0F0
		public static bool IsHitScene(int layer, bool ignoreWater = false /* Metadata: 0x00B1340A */) => default; // 0x0000000181173E20-0x0000000181173F40
		// [XID] // 0x00000001899D25E0-0x00000001899D2600
		public static bool IsNoClimbTag(Collider col, int triangleIndex) => default; // 0x0000000181174290-0x0000000181174390
		// [XID] // 0x00000001899D9CC0-0x00000001899D9CE0
		public static bool IsHitEntity(int layer) => default; // 0x0000000181173D50-0x0000000181173E20
		// [XID] // 0x00000001899E15D0-0x00000001899E15F0
		public static int GetHitLayerMask() => default; // 0x0000000181167980-0x0000000181167A50
		// [XID] // 0x00000001899E8CA0-0x00000001899E8CC0
		public static int GetSceneLayerMask() => default; // 0x0000000181170E20-0x0000000181170EF0
		// [XID] // 0x000000018961E3A0-0x000000018961E3C0
		public static int GetSceneCameraLayerMask() => default; // 0x0000000181170BB0-0x0000000181170C80
		// [XID] // 0x00000001899F7C40-0x00000001899F7C60
		public static int GetStaticSceneLayerMask() => default; // 0x00000001811714A0-0x0000000181171570
		// [XID] // 0x00000001899FF230-0x00000001899FF250
		public static int GetHitSceneLayerMask() => default; // 0x0000000181167A50-0x0000000181167B20
		// [XID] // 0x0000000189A06A70-0x0000000189A06A90
		public static SceneObjTag GetSceneObjTag(Collider col, int triangleIndex) => default; // 0x0000000181170EF0-0x0000000181170FC0
		// [XID] // 0x0000000189A0E160-0x0000000189A0E180
		public static int GetOccluderLayerMask() => default; // 0x0000000181169470-0x0000000181169540
		// [XID] // 0x00000001898797E0-0x0000000189879800
		public static int GetWaterLayerMask() => default; // 0x0000000181172D40-0x0000000181172E10
		// [XID] // 0x0000000189A1CC20-0x0000000189A1CC40
		public static int GetSceneGroundLayerMask() => default; // 0x0000000181170D50-0x0000000181170E20
		// [XID] // 0x0000000189A24180-0x0000000189A241A0
		public static int GetSceneGroundLayerMaskWithoutTemp() => default; // 0x0000000181170C80-0x0000000181170D50
		// [XID] // 0x0000000189A2B5D0-0x0000000189A2B5F0
		public static int GetCameraLayerMask() => default; // 0x0000000181163330-0x0000000181163400
		// [XID] // 0x0000000189B246E0-0x0000000189B24700
		public static int GetIKSceneLayerMask() => default; // 0x0000000181167B20-0x0000000181167BF0
		// [XID] // 0x0000000189A3A4B0-0x0000000189A3A4D0
		public static int GetCharacterLayerMask() => default; // 0x0000000181163400-0x00000001811634D0
		// [XID] // 0x0000000189A41DB0-0x0000000189A41DD0
		public static int GetBulletHitLayerMask() => default; // 0x0000000181163140-0x0000000181163210
		// [XID] // 0x0000000189A493C0-0x0000000189A493E0
		public static float ProtoInt2Float(PropValue propValue) => default; // 0x0000000181176E70-0x0000000181176F80
		// [XID] // 0x0000000189A50CE0-0x0000000189A50D00
		public static double ProtoLong2Double(long value, uint type) => default; // 0x0000000181176F80-0x0000000181177090
		// [IDTag] // 0x0000000189A581E0-0x0000000189A58220
		// [XID] // 0x0000000189A581E0-0x0000000189A58220
		public static int ProtoFloat2Int(float num, PropType type) => default; // 0x0000000181176BF0-0x0000000181176CC0
		// [XID] // 0x0000000189A62BF0-0x0000000189A62C10
		public static FightPropType ElemTypeToProto(ElementType type) => default; // 0x0000000181156AB0-0x0000000181156BC0
		// [XID] // 0x0000000189A6A810-0x0000000189A6A830
		public static FightPropType ElemTypeToProtoMax(ElementType type) => default; // 0x00000001811569A0-0x0000000181156AB0
		// [XID] // 0x0000000189BAB9F0-0x0000000189BABA10
		public static ElementType ProtoToElemType(FightPropType type) => default; // 0x0000000181177090-0x00000001811771D0
		// [XID] // 0x0000000189A79B00-0x0000000189A79B20
		public static bool IsEnergyType(FightPropType type) => default; // 0x0000000181173A60-0x0000000181173B70
		// [IDTag] // 0x0000000189A80F80-0x0000000189A80FC0
		// [XID] // 0x0000000189A80F80-0x0000000189A80FC0
		public static int ProtoFloat2Int(float num, FightPropType type) => default; // 0x0000000181176CC0-0x0000000181176E70
		// [XID] // 0x0000000189792D40-0x0000000189792D60
		public static bool CheckTargetAttackable(BaseEntity attacker, BaseEntity target) => default; // 0x0000000181151F30-0x0000000181152070
		// [XID] // 0x0000000189A930E0-0x0000000189A93100
		public static bool IsValidPath(string assetPath) => default; // 0x00000001811747E0-0x0000000181174960
		// [XID] // 0x0000000189A9AB30-0x0000000189A9AB50
		public static bool IsEmptyPath(ulong assetPathHash) => default; // 0x0000000181173990-0x0000000181173A60
		// [XID] // 0x0000000189AA1DF0-0x0000000189AA1E10
		private static bool CheckAssetPattern(string assetPath) => default; // 0x0000000181151090-0x0000000181151430
		// [XID] // 0x0000000189AA92F0-0x0000000189AA9310
		private static string GetCommonPattern(string name, bool hasAni = true /* Metadata: 0x00B1340B */) => default; // 0x0000000181163620-0x00000001811644E0
		// [XID] // 0x0000000189AB1270-0x0000000189AB1290
		private static string GenerateAniamtionPattern(string ppf, string animn) => default; // 0x0000000181158790-0x0000000181159C60
		// [XID] // 0x0000000189AB8560-0x0000000189AB8580
		private static string GenerateAnimationClipFbxPattern(bool isClip) => default; // 0x0000000181159C60-0x000000018115ACB0
		// [XID] // 0x0000000189AC01A0-0x0000000189AC01C0
		private static string GenerateOriginPattern() => default; // 0x000000018115ACB0-0x000000018115ED50
		// [XID] // 0x0000000189AC7BC0-0x0000000189AC7BE0
		private static string GetPrefabPattern(string name) => default; // 0x000000018116FC50-0x000000018116FF10
		// [XID] // 0x0000000189ACF160-0x0000000189ACF180
		private static string GetAvatarEquipPattern(string name) => default; // 0x0000000181162040-0x00000001811626E0
		// [XID] // 0x0000000189AD6F70-0x0000000189AD6F90
		private static string GenerateStreamPattern() => default; // 0x000000018115ED50-0x0000000181161FA0
		// [XID] // 0x0000000189ADE990-0x0000000189ADE9B0
		public static string CheckAbilityTalentConfigs() => default; // 0x00000001811505E0-0x0000000181151090
		// [XID] // 0x0000000189AE6310-0x0000000189AE6330
		private static void CheckUnlockTalentParamInAbility(ConfigAbility ability, HashSet<string> validTalentParams, StringBuilder errorLog) {} // 0x0000000181152070-0x00000001811524C0
		// [XID] // 0x0000000189AEDAA0-0x0000000189AEDAC0
		private static void CheckUnlockTalentParamInMixins(string abilityName, ConfigAbilityMixin[] mixins, HashSet<string> validTalentParams, StringBuilder errorLog) {} // 0x00000001811526D0-0x0000000181152A30
		// [XID] // 0x0000000189AF5310-0x0000000189AF5330
		private static void CheckUnlockTalentParamInModifier(string abilityName, ConfigAbilityModifier modifier, HashSet<string> validTalentParams, StringBuilder errorLog) {} // 0x0000000181152A30-0x0000000181152CE0
		// [XID] // 0x0000000189AFC870-0x0000000189AFC890
		private static void CheckUnlockTalentParamInActions(string abilityName, ConfigAbilityAction[] actions, HashSet<string> validTalentParams, StringBuilder errorLog) {} // 0x00000001811524C0-0x00000001811526D0
		// [XID] // 0x0000000189B03F90-0x0000000189B03FB0
		private static void CheckUnlockTalentParamInPredicates(string abilityName, ConfigAbilityPredicate[] predicates, HashSet<string> validTalentParams, StringBuilder errorLog) {} // 0x0000000181152CE0-0x0000000181153270
		// [XID] // 0x0000000189B0B810-0x0000000189B0B830
		public static float ComputeElemBallEnergy(uint configID, float energy) => default; // 0x00000001811544A0-0x0000000181154880
		// [XID] // 0x0000000189B12D80-0x0000000189B12DA0
		private static LCAbility CheckAbilityComAvailable(LCAbility target, bool includeGhost = false /* Metadata: 0x00B1340C */) => default; // 0x0000000181150510-0x00000001811505E0
		// [XID] // 0x00000001896F7D50-0x00000001896F7D70
		private static BaseEntity CheckEntityAvailable(BaseEntity target, bool includeGhost = false /* Metadata: 0x00B1340D */) => default; // 0x0000000181151CD0-0x0000000181151DA0
		// [XID] // 0x0000000189B218D0-0x0000000189B218F0
		public static LCAbility[] FilterTargetArray(LCAbility[] targets, bool includeGhost = false /* Metadata: 0x00B1340E */) => default; // 0x0000000181156FE0-0x0000000181157150
		// [XID] // 0x0000000189B29040-0x0000000189B29060
		public static void SelectShapeTargets(SelectTargetsByShape selectTargets, ActorAbility instancedAbility, ActorModifier instancedModifier, LCAbility self, BaseEntity other, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs, ref Vector3 logicCenter, ref BaseShape2d shape) {
			outTargetLs = default;
		} // 0x000000018117B890-0x000000018117C3E0
		// [XID] // 0x0000000189A479D0-0x0000000189A479F0
		public static void SelectEquipTargets(SelectTargetsByEquipParts selectEquipTargets, LCAbility self, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117A570-0x000000018117A790
		// [XID] // 0x0000000189829D90-0x0000000189829DB0
		public static void SelectChildrenTargets(SelectTargetsByChildren selectChildrenTargets, BaseEntity entity, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117A310-0x000000018117A570
		// [XID] // 0x0000000189B3F680-0x0000000189B3F6A0
		public static void SelectTagTargets(SelectTargetsByTag selectTagTargets, BaseEntity entity, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117C3E0-0x000000018117C610
		// [XID] // 0x000000018984D6F0-0x000000018984D710
		public static bool CheckSelfGroupTarget(SelectTargetsBySelfGroup selectSelfGroupTargets, uint selfMarkFlag, uint targetMarkFlag) => default; // 0x0000000181151DA0-0x0000000181151F30
		// [XID] // 0x0000000189B4E760-0x0000000189B4E780
		public static void SelectSelfGroupTargets(SelectTargetsBySelfGroup selectSelfGroupTargets, BaseEntity entity, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117B110-0x000000018117B890
		// [XID] // 0x0000000189B55F80-0x0000000189B55FA0
		public static void SelectLCTriggerTargets(SelectTargetsByLCTrigger selectTargetsByLCTrigger, BaseEntity self, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117A960-0x000000018117AC30
		// [XID] // 0x00000001898881D0-0x00000001898881F0
		public static void SelectLCTriggerAllTargets(SelectTargetsByLCTriggerAll selectTargetsByLCTriggerAll, BaseEntity self, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTargetLs = default;
		} // 0x000000018117A790-0x000000018117A960
		// [XID] // 0x00000001898F8950-0x00000001898F8970
		public static void SortTargets(SelectTargetsSortType sortType, Vector3 centerForNearest, LCBaseCombat combatForHigherScore, BaseShape2d shapeForHigherScore, ref List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {} // 0x000000018117D2B0-0x000000018117D800
		// [XID] // 0x0000000189B6C440-0x0000000189B6C460
		public static void SelectNormalTarget(AbilityTargetting selectTarget, LCAbility self, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, out ActorAbilityPlugin.AbilityAttackTarget outTarget, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTarget = default;
			outTargetLs = default;
		} // 0x000000018117AC30-0x000000018117AEB0
		// [XID] // 0x0000000189B73B30-0x0000000189B73B50
		public static void SelectPredicateTarget(AbilityTargetting selectTarget, BaseEntity target, BaseEntity self, ActorAbility instancedAbility, ActorModifier instancedModifier, out BaseEntity outTarget) {
			outTarget = default;
		} // 0x000000018117AEB0-0x000000018117B110
		// [XID] // 0x00000001896F0380-0x00000001896F03A0
		private static void ResolveAbilityTargetting(AbilityTargetting abilityTargetting, BaseEntity target, BaseEntity self, BaseEntity caster, BaseEntity other, uint applierID, out ActorAbilityPlugin.AbilityAttackTarget outTarget, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
			outTarget = default;
			outTargetLs = default;
		} // 0x0000000181178DA0-0x0000000181179E50
		// [IDTag] // 0x0000000189B82B10-0x0000000189B82B50
		// [XID] // 0x0000000189B82B10-0x0000000189B82B50
		public static void GetPositionByBornType(ConfigBornType configBornType, IAbilityActionContainer instance, BaseEntity targetEntity, BaseEntity selfEntity, out Vector3 bornPos, out Quaternion bornRot) {
			bornPos = default;
			bornRot = default;
		} // 0x0000000181169D40-0x0000000181169F10
		// [XID] // 0x0000000189B8CBF0-0x0000000189B8CC10
		public static void EmergencyDvalinPatch(BaseEntity selfEntity, ActorModifier instancedModifier, ref Vector3 bornPos) {} // 0x0000000181156BC0-0x0000000181156DD0
		// [XID] // 0x0000000189B943E0-0x0000000189B94400
		public static Vector3 GetPositionForElementReaction(BaseEntity target, int hitPos) => default; // 0x000000018116FA00-0x000000018116FC50
		// [IDTag] // 0x0000000189B9BAF0-0x0000000189B9BB30
		// [XID] // 0x0000000189B9BAF0-0x0000000189B9BB30
		public static void GetPositionByBornType(ConfigBornType configBornType, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEvent evt, BaseEntity targetEntity, ActorAbilityPlugin.AbilityAttackTarget? attackTarget, BaseEntity selfEntity, out Vector3 bornPos, out Quaternion bornRot) {
			bornPos = default;
			bornRot = default;
		} // 0x0000000181169F10-0x000000018116FA00
		// [XID] // 0x0000000189BA60B0-0x0000000189BA60D0
		public static void GetEffectTargetDir(BaseEvent evt, BaseEntity targetEntity, out Vector3 targetDir) {
			targetDir = default;
		} // 0x00000001811656F0-0x00000001811658A0
		// [XID] // 0x0000000189BAD340-0x0000000189BAD360
		public static void RandomBornPos(ref Vector3 bornPos, Vector3 forward, Vector3 up, ActorAbility instancedAbility, BornRandom config) {} // 0x00000001811771D0-0x0000000181177670
		// [XID] // 0x00000001897CE790-0x00000001897CE7B0
		public static bool IsAnimalConfigID(BaseEntity entity) => default; // 0x0000000181173700-0x00000001811737C0
		// [XID] // 0x0000000189748A20-0x0000000189748A40
		public static Vector3? GetBulletAimPosOnTarget(BaseEntity entity) => default; // 0x00000001811627F0-0x0000000181162D00
		// [XID] // 0x0000000189BC3DE0-0x0000000189BC3E00
		public static Transform GetBulletAimTransOnTarget(BaseEntity entity) => default; // 0x0000000181162D00-0x0000000181163140
		// [XID] // 0x0000000189BB5F10-0x0000000189BB5F30
		public static bool GetNearestHitPos(Vector3 selfPos, BaseEntity targetEntity, out int index, out Vector3 hitPos) {
			index = default;
			hitPos = default;
			return default;
		} // 0x0000000181168EC0-0x00000001811692B0
		// [XID] // 0x0000000189ABCF10-0x0000000189ABCF30
		public static WWWForm CreateWWWForm(Dictionary<string, string> formDict) => default; // 0x0000000181156540-0x0000000181156740
		[DebuggerHidden] // 0x0000000189BDA380-0x0000000189BDA3C0
		// [XID] // 0x0000000189BDA380-0x0000000189BDA3C0
		public static IEnumerator WWWRequestWithTimeOut(string url, Action<string> callback, Action timeOutCallback, float timeoutSecond = 5f /* Metadata: 0x00B1340F */, byte[] postData = null, Dictionary<string, string> headers = null, Dictionary<string, string> formDict = null, bool needDispose = true /* Metadata: 0x00B13413 */, Action<string> errorCallBack = null) => default; // 0x000000018117F1C0-0x000000018117F360
		[DebuggerHidden] // 0x00000001895EA170-0x00000001895EA1C0
		// [IDTag] // 0x00000001895EA170-0x00000001895EA1C0
		// [XID] // 0x00000001895EA170-0x00000001895EA1C0
		public static IEnumerator WWWRequestWithRetry(string url, Action<string> callback, Action timeOutCallback, byte[] postData = null, Dictionary<string, string> headers = null, Dictionary<string, string> formDict = null, float timeoutSecond = 5f /* Metadata: 0x00B13414 */, int retryTime = 3 /* Metadata: 0x00B13418 */) => default; // 0x000000018117F040-0x000000018117F1C0
		[DebuggerHidden] // 0x00000001895F7B00-0x00000001895F7B50
		// [IDTag] // 0x00000001895F7B00-0x00000001895F7B50
		// [XID] // 0x00000001895F7B00-0x00000001895F7B50
		public static IEnumerator WWWRequestWithRetry(List<string> urlList, Action<string> callback, Action timeOutCallback, byte[] postData = null, Dictionary<string, string> headers = null, Dictionary<string, string> formDict = null, float timeoutSecond = 5f /* Metadata: 0x00B1341C */, int retryTime = 3 /* Metadata: 0x00B13420 */, Action<string> updateServerUrl = null) => default; // 0x000000018117EE90-0x000000018117F040
		// [XID] // 0x0000000189A6A6C0-0x0000000189A6A6E0
		public static string GetP4Version(VersionStringType type = VersionStringType.Full /* Metadata: 0x00B13424 */) => default; // 0x0000000181169540-0x0000000181169BD0
		// [XID] // 0x0000000189A71B50-0x0000000189A71B70
		public static string GetGameVersion() => default; // 0x00000001811667F0-0x0000000181166960
		// [XID] // 0x0000000189613D90-0x0000000189613DB0
		public static void GetGameVersionAndChangelist(out string gameVer, out string engineCL, out string clientCL, out string resourceCL, out string silenceCL, out string dataCL) {
			gameVer = default;
			engineCL = default;
			clientCL = default;
			resourceCL = default;
			silenceCL = default;
			dataCL = default;
		} // 0x0000000181166430-0x00000001811667F0
		// [XID] // 0x000000018961B760-0x000000018961B780
		public static string GetUniversalGameVersion() => default; // 0x0000000181172620-0x0000000181172920
		public static T GetPrivateProperty<T>(object instance, string propertyname) => default;
		public static T GetPrivateField<T>(object instance, string fieldname) => default;
		public static T CallPrivateMethod<T>(object instance, string name, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] param) => default;
		// [XID] // 0x000000018989F540-0x000000018989F560
		public static void SetBindPose(Dictionary<Transform, Matrix4x4> bindPoseMap) {} // 0x000000018117C610-0x000000018117CDB0
		// [XID] // 0x0000000189663330-0x0000000189663350
		public static bool CanAvatarDoPhotograph(AvatarEntity entity) => default; // 0x000000018114F520-0x000000018114F740
		// [XID] // 0x000000018966ADD0-0x000000018966ADF0
		public static bool CanPlayMusicGame() => default; // 0x0000000181150300-0x0000000181150510
		// [IDTag] // 0x00000001896729D0-0x0000000189672A10
		// [XID] // 0x00000001896729D0-0x0000000189672A10
		public static bool CanChangeAvatarEntity(AvatarEntity entity, uint configId, ref ChangeAvatarFailType failType) => default; // 0x000000018114FE30-0x0000000181150300
		// [IDTag] // 0x000000018967D0F0-0x000000018967D130
		// [XID] // 0x000000018967D0F0-0x000000018967D130
		public static bool CanChangeAvatarEntity(AvatarEntity entity, AvatarEntity targetEntity, AvatarDataItem targetData, ref ChangeAvatarFailType failType) => default; // 0x000000018114FAB0-0x000000018114FE30
		// [XID] // 0x0000000189687BF0-0x0000000189687C10
		public static void ShowChangeAvatarFailMessage(ChangeAvatarFailType failType) {} // 0x000000018117D0B0-0x000000018117D2B0
		// [XID] // 0x000000018968F5F0-0x000000018968F610
		public static bool IsMale(BodyType type) => default; // 0x0000000181174100-0x00000001811741B0
		// [XID] // 0x0000000189697010-0x0000000189697030
		public static bool ShouldUseMPAbility() => default; // 0x000000018117CFD0-0x000000018117D0B0
		// [XID] // 0x000000018969E530-0x000000018969E550
		public static BaseEntity GetValidEntity(uint runtimeID) => default; // 0x0000000181172C30-0x0000000181172D40
		// [XID] // 0x000000018997C170-0x000000018997C190
		public static ActorAbility GetInstancedAbility(BaseEntity entity, uint instancedAbilityId) => default; // 0x0000000181167F80-0x0000000181168120
		// [XID] // 0x000000018972BF70-0x000000018972BF90
		public static ActorModifier GetInstancedModifier(BaseEntity entity, int instancedModifierId, bool isServerBuff) => default; // 0x0000000181168120-0x00000001811682E0
		// [XID] // 0x00000001896B4450-0x00000001896B4470
		public static bool IsAvatarRangeAttack(AvatarEntity entity) => default; // 0x00000001811737C0-0x00000001811738D0
		// [XID] // 0x000000018998B7E0-0x000000018998B800
		public static bool IsModifierMuteRemote(BaseEntity entity, ConfigAbilityModifier modifierConfig) => default; // 0x00000001811741B0-0x0000000181174290
		// [XID] // 0x00000001896C2B40-0x00000001896C2B60
		public static void ForceReplaceAvatarPos(BaseEntity playerEntity, BaseEntity changeEntity, bool replacePos, Vector3 pos, Quaternion rot, bool needPlayShowUp = false /* Metadata: 0x00B13428 */) {} // 0x0000000181157150-0x0000000181157470
		// [XID] // 0x00000001896CA0C0-0x00000001896CA0E0
		public static void OnAvatarRaplaced(BaseEntity playerEntity, BaseEntity changeEntity) {} // 0x00000001811760B0-0x00000001811761D0
		// [XID] // 0x00000001896D1750-0x00000001896D1770
		public static BodyMaterialType MaterialName2Type(string name) => default; // 0x0000000181175370-0x00000001811754B0
		// [XID] // 0x00000001896D8F50-0x00000001896D8F70
		public static bool CheckAvatarCanUpgrade(AvatarDataItem avatarData) => default; // 0x0000000181151820-0x0000000181151CD0
		// [XID] // 0x00000001896E07D0-0x00000001896E07F0
		public static bool CheckAvatarCanPromote(AvatarDataItem avatarData) => default; // 0x0000000181151430-0x0000000181151820
		// [XID] // 0x00000001896E79E0-0x00000001896E7A00
		public static bool CanBeHitInMultiplayer(uint attackerRuntimeID, uint attackeeRuntimeID) => default; // 0x000000018114F740-0x000000018114FAB0
		// [XID] // 0x00000001896EF050-0x00000001896EF070
		public static void RecoverServerAnimatorParameterList(BaseEntity entity, RepeatedField<AnimatorParameterValueInfoPair> animatorParaList) {} // 0x0000000181178590-0x0000000181178780
		// [XID] // 0x00000001896F6B40-0x00000001896F6B60
		public static void RecoverServerEntityRendererVisible(BaseEntity entity, EntityRendererChangedInfo rendererInfo) {} // 0x0000000181178940-0x0000000181178AA0
		// [XID] // 0x00000001896FE390-0x00000001896FE3B0
		public static void RecoverServerEntityAttackTarget(BaseEntity entity, uint targetId) {} // 0x0000000181178780-0x0000000181178860
		// [XID] // 0x00000001897055A0-0x00000001897055C0
		public static void RecoverServerEntityPoseParameter(BaseEntity entity, RepeatedField<AnimatorParameterValueInfoPair> poseParaList) {} // 0x0000000181178860-0x0000000181178940
		// [XID] // 0x0000000189AE5FC0-0x0000000189AE5FE0
		public static Vector3 MultiplyVector3(Vector3 v1, Vector3 v2) => default; // 0x0000000181175E30-0x0000000181175F90
		// [XID] // 0x0000000189714440-0x0000000189714460
		public static Vector3 DivideVector3(Vector3 a, Vector3 b) => default; // 0x0000000181156800-0x00000001811569A0
		// [XID] // 0x000000018971BC30-0x000000018971BC50
		public static void PauseLevelTime(bool enable, TimeScaleType type) {} // 0x0000000181176550-0x0000000181176740
		// [XID] // 0x0000000189722F40-0x0000000189722F60
		public static void PauseRemoteLevelTime(bool enable) {} // 0x0000000181176740-0x0000000181176950
		// [XID] // 0x000000018972AAE0-0x000000018972AB00
		public static int GetServerTimeZone() => default; // 0x0000000181171360-0x00000001811714A0
		// [IDTag] // 0x00000001897321A0-0x00000001897321E0
		// [XID] // 0x00000001897321A0-0x00000001897321E0
		public static Transform GetTargetLockPointTrans(BaseEntity targetEntity, string lockPoint) => default; // 0x0000000181171F80-0x0000000181172110
		// [IDTag] // 0x000000018973CB70-0x000000018973CBB0
		// [XID] // 0x000000018973CB70-0x000000018973CBB0
		public static Transform GetTargetLockPointTrans(BaseEntity targetEntity, uint lockPointIndex) => default; // 0x0000000181171E00-0x0000000181171F80
		// [XID] // 0x0000000189747460-0x0000000189747480
		public static AssetJobPriority Magnitude2Piroity(float magitude, Vector3 objPos, SECTR_LayerType type) => default; // 0x00000001811751C0-0x0000000181175370
		public static bool CompareList<T>(IList<T> lst1, IList<T> lst2, IEqualityComparer<T> comparer) => default;
		// [XID] // 0x00000001897562A0-0x00000001897562C0
		public static void GenLevelRect(ref Rect levelRect) {} // 0x0000000181158320-0x0000000181158430
		// [XID] // 0x000000018975D600-0x000000018975D620
		public static Vector3 GenWorldPos(Vector2 levelMapPos) => default; // 0x0000000181158670-0x0000000181158790
		// [IDTag] // 0x0000000189764C70-0x0000000189764CB0
		// [XID] // 0x0000000189764C70-0x0000000189764CB0
		public static void GenLevelPos(ref Vector2 pos) {} // 0x0000000181158270-0x0000000181158320
		// [XID] // 0x000000018976F280-0x000000018976F2A0
		public static Vector2 GenVec2LevelPos(Vector2 pos) => default; // 0x0000000181158590-0x0000000181158670
		// [IDTag] // 0x0000000189776C80-0x0000000189776CC0
		// [XID] // 0x0000000189776C80-0x0000000189776CC0
		public static Vector2 GenLevelPos(Vector3 worldPos) => default; // 0x0000000181158180-0x0000000181158270
		// [XID] // 0x00000001897817D0-0x00000001897817F0
		public static void GenLevelRot(ref Vector3 euler) {} // 0x0000000181158430-0x00000001811584E0
		// [XID] // 0x0000000189788CD0-0x0000000189788CF0
		public static void GenMiniSouthRot(ref Vector3 euler) {} // 0x00000001811584E0-0x0000000181158590
		// [IDTag] // 0x00000001897901D0-0x0000000189790210
		// [XID] // 0x00000001897901D0-0x0000000189790210
		public static float GenLevelMapRot(float worldEulerAngleY) => default; // 0x0000000181157FA0-0x0000000181158050
		// [IDTag] // 0x000000018979B360-0x000000018979B3A0
		// [XID] // 0x000000018979B360-0x000000018979B3A0
		public static Vector3 GenLevelMapRot(Vector3 worldEulerAngles) => default; // 0x0000000181158050-0x0000000181158180
		// [XID] // 0x0000000189706A60-0x0000000189706A80
		public static long Pos2LongID(int x, int y, int z) => default; // 0x0000000181176B00-0x0000000181176BF0
		// [XID] // 0x00000001897ACFC0-0x00000001897ACFE0
		public static Vector3 LongID2Pos(long id) => default; // 0x0000000181175080-0x00000001811751C0
		// [IDTag] // 0x00000001897B5000-0x00000001897B5040
		// [XID] // 0x00000001897B5000-0x00000001897B5040
		public static int Pos2ID(int x, int y) => default; // 0x0000000181176A40-0x0000000181176B00
		// [XID] // 0x00000001897BFD60-0x00000001897BFD80
		public static Vector2 ID2Vec2(int id) => default; // 0x0000000181173040-0x0000000181173130
		// [IDTag] // 0x00000001897C7570-0x00000001897C75B0
		// [XID] // 0x00000001897C7570-0x00000001897C75B0
		public static int Pos2ID(int x, int y, int z) => default; // 0x0000000181176950-0x0000000181176A40
		// [XID] // 0x00000001897D1770-0x00000001897D1790
		public static Vector3 ID2Vec3(int id) => default; // 0x0000000181173130-0x0000000181173260
		// [XID] // 0x00000001897D9510-0x00000001897D9530
		public static ConfigChannel GetConfigChannel() => default; // 0x00000001811645E0-0x00000001811648D0
		// [XID] // 0x00000001897E08F0-0x00000001897E0910
		private static ConfigChannel LoadChannelConfigBlk() => default; // 0x0000000181174C50-0x0000000181175080
		// [XID] // 0x00000001897E7FF0-0x00000001897E8010
		public static string GetSystemInfoOperatingSystem() => default; // 0x00000001811719D0-0x0000000181171A70
		// [XID] // 0x00000001897EFBE0-0x00000001897EFC00
		public static string GetSystemDeviceName() => default; // 0x0000000181171610-0x00000001811716B0
		// [XID] // 0x00000001897F7420-0x00000001897F7440
		public static string GetSystemDeviceModel() => default; // 0x0000000181171570-0x0000000181171610
		// [XID] // 0x00000001897FEB20-0x00000001897FEB40
		public static string GetSystemGraphicsDeviceName() => default; // 0x00000001811716B0-0x0000000181171750
		// [XID] // 0x0000000189806240-0x0000000189806260
		public static GraphicsDeviceType GetSystemGraphicsDeviceType() => default; // 0x0000000181171750-0x00000001811717F0
		// [XID] // 0x000000018980D910-0x000000018980D930
		public static string GetSystemGraphicsDeviceVendor() => default; // 0x00000001811717F0-0x0000000181171890
		// [XID] // 0x0000000189815000-0x0000000189815020
		public static string GetSystemGraphicsDeviceVersion() => default; // 0x0000000181171890-0x0000000181171930
		// [XID] // 0x000000018981CB00-0x000000018981CB20
		public static int GetSystemGraphicsMemorySize() => default; // 0x0000000181171930-0x00000001811719D0
		// [XID] // 0x0000000189823F90-0x0000000189823FB0
		public static int GetSystemProcessorCount() => default; // 0x0000000181171A70-0x0000000181171B10
		// [XID] // 0x000000018982B9D0-0x000000018982B9F0
		public static int GetSystemProcessorFrequency() => default; // 0x0000000181171B10-0x0000000181171BB0
		// [XID] // 0x0000000189832F90-0x0000000189832FB0
		public static string GetSystemProcessorType() => default; // 0x0000000181171BB0-0x0000000181171C50
		// [XID] // 0x000000018983E850-0x000000018983E870
		public static int GetSystemSystemMemorySize() => default; // 0x0000000181171C50-0x0000000181171CF0
		// [XID] // 0x00000001898419D0-0x00000001898419F0
		public static string GetSystemVersion() => default; // 0x0000000181171CF0-0x0000000181171E00
		// [XID] // 0x0000000189848E90-0x0000000189848EB0
		public static string GetDeviceName() => default; // 0x0000000181165220-0x0000000181165330
		// [XID] // 0x0000000189850690-0x00000001898506B0
		public static string GetCPS() => default; // 0x0000000181163210-0x0000000181163330
		// [XID] // 0x0000000189776C00-0x0000000189776C20
		public static string GetServerName() => default; // 0x0000000181170FC0-0x0000000181171140
		// [XID] // 0x000000018985EB50-0x000000018985EB70
		public static uint GetNetworkIP() => default; // 0x00000001811692B0-0x0000000181169470
		// [XID] // 0x00000001898662D0-0x00000001898662F0
		public static Dictionary<string, string> GetHeadersAdditionInfo(string url) => default; // 0x0000000181167840-0x0000000181167980
		// [XID] // 0x000000018986DC00-0x000000018986DC20
		public static string GetUUID() => default; // 0x0000000181172530-0x0000000181172620
		// [XID] // 0x0000000189874EF0-0x0000000189874F10
		public static int GetLanguageType() => default; // 0x00000001811682E0-0x0000000181168400
		// [XID] // 0x000000018987CC00-0x000000018987CC20
		public static string GetDeviceInfo() => default; // 0x0000000181164E60-0x0000000181165220
		// [XID] // 0x0000000189883B50-0x0000000189883B70
		public static RuntimePlatform GetApplicationPlatform() => default; // 0x0000000181161FA0-0x0000000181162040
		// [XID] // 0x000000018988B270-0x000000018988B290
		public static string GetCurrentPlatformName() => default; // 0x00000001811648D0-0x00000001811649E0
		// [XID] // 0x00000001898928B0-0x00000001898928D0
		public static string GetBuildTargetName() => default; // 0x00000001811626E0-0x00000001811627F0
		// [XID] // 0x000000018989A030-0x000000018989A050
		public static void InitValideDevice(JSONNode deviceList) {} // 0x0000000181173550-0x00000001811735F0
		// [XID] // 0x00000001898A12D0-0x00000001898A12F0
		public static bool IsValideDevice() => default; // 0x0000000181174960-0x0000000181174A20
		// [XID] // 0x00000001898A8AA0-0x00000001898A8AC0
		public static string GetValidDeviceName() => default; // 0x0000000181172B90-0x0000000181172C30
		// [XID] // 0x00000001898B0400-0x00000001898B0420
		public static string GetInValidDeviceDlgTitle() => default; // 0x0000000181167E60-0x0000000181167F80
		// [XID] // 0x00000001898B7A70-0x00000001898B7A90
		public static string GetInValidDeviceDlgContent() => default; // 0x0000000181167CD0-0x0000000181167E60
		// [XID] // 0x00000001898BF030-0x00000001898BF050
		public static string GetUrlExtInfo() => default; // 0x0000000181172920-0x0000000181172B90
		// [XID] // 0x00000001898C69C0-0x00000001898C69E0
		public static string GetGlobalDispatchUrl(string url, bool isGlobal) => default; // 0x0000000181166960-0x0000000181167070
		// [XID] // 0x00000001898CDFB0-0x00000001898CDFD0
		public static bool HandleRegionConfig(string regionConfig) => default; // 0x0000000181172F00-0x0000000181173040
		// [XID] // 0x00000001898D5A20-0x00000001898D5A40
		public static bool IsCloudGame() => default; // 0x00000001811738D0-0x0000000181173990
		// [XID] // 0x00000001897C88D0-0x00000001897C88F0
		public static PlatformType GetServerPlatformType() => default; // 0x0000000181171140-0x00000001811712B0
		// [XID] // 0x00000001898E4F30-0x00000001898E4F50
		public static uint GetPlayerAccountType() => default; // 0x0000000181169BD0-0x0000000181169D40
		// [XID] // 0x00000001898EC7E0-0x00000001898EC800
		public static string GetServerTag(ServerType server) => default; // 0x00000001811712B0-0x0000000181171360
		// [XID] // 0x00000001898F41F0-0x00000001898F4210
		public static string GetGlobalServer() => default; // 0x0000000181167400-0x0000000181167840
		// [XID] // 0x00000001898FB940-0x00000001898FB960
		public static string GetGlobalServerZone(string name) => default; // 0x0000000181167070-0x0000000181167400
		// [XID] // 0x0000000189928D40-0x0000000189928D60
		public static void DestroyGameObject(GameObject go) {} // 0x0000000181156740-0x0000000181156800
		// [XID] // 0x0000000189930270-0x0000000189930290
		public static void ScaleMeshRenders(GameObject __parent_cs1, MeshRenderer __meshes_csl, float scaleMultiplier) {} // 0x000000018117A000-0x000000018117A250
		// [XID] // 0x0000000189937730-0x0000000189937750
		public static void ScaleParticles(GameObject __parent_cs1, ParticleSystem __particles_cs1, float scaleMultiplier) {} // 0x000000018117A250-0x000000018117A310
		// [XID] // 0x000000018993F210-0x000000018993F230
		public static void ScaleCurve(AnimationCurve curve, float scaleMultiplier) {} // 0x0000000181179E50-0x000000018117A000
		// [XID] // 0x0000000189946800-0x0000000189946820
		public static int GetExpCostCoinNum(uint exp, QualityType quality) => default; // 0x0000000181165A50-0x0000000181165BE0
		// [XID] // 0x000000018994DEE0-0x000000018994DF00
		public static uint MutiplyFloatAndUint(RoundType roundType, float f, uint num) => default; // 0x0000000181175F90-0x00000001811760B0
		// [XID] // 0x0000000189955540-0x0000000189955560
		public static string CalcMD5(byte[] bytes) => default; // 0x000000018114F230-0x000000018114F3B0
		// [XID] // 0x000000018995CFC0-0x000000018995CFE0
		public static string ClacHmacSha1Sign(string key, string text) => default; // 0x0000000181153270-0x0000000181153570
		// [XID] // 0x000000018984D520-0x000000018984D540
		public static byte[] GetRobotCheckLoginOutput() => default; // 0x0000000181170740-0x0000000181170810
		// [XID] // 0x00000001899812F0-0x0000000189981310
		private static byte[] GetRobotCheckOutput(byte[] input) => default; // 0x0000000181170810-0x0000000181170BB0
		// [XID] // 0x0000000189988AC0-0x0000000189988AE0
		private static void OnReportRsp(string str) {} // 0x00000001811761D0-0x0000000181176400
		// [XID] // 0x0000000189A79570-0x0000000189A79590
		public static Dictionary<string, object> CreateReport(ReportEventType eventType, Dictionary<string, object> content) => default; // 0x0000000181156290-0x0000000181156540
		// [XID] // 0x0000000189997D90-0x0000000189997DB0
		public static void MediumDownloadResultReport(long deltaSize, long downloadedSize, string reason, bool completed) {} // 0x0000000181175950-0x0000000181175E30
		// [XID] // 0x000000018999F520-0x000000018999F540
		public static void MediumDownloadChoiceReport(MediumDownloadDialogType type, int choice, long size) {} // 0x00000001811754B0-0x0000000181175950
		// [IDTag] // 0x00000001899A7030-0x00000001899A7070
		// [XID] // 0x00000001899A7030-0x00000001899A7070
		public static void ClientReport(string jsonStr, string customUrl = "" /* Metadata: 0x00B13429 */) {} // 0x00000001811536A0-0x0000000181153D40
		// [IDTag] // 0x00000001899B1B00-0x00000001899B1B40
		// [XID] // 0x00000001899B1B00-0x00000001899B1B40
		public static void ClientReport(List<Dictionary<string, object>> dataList, string customUrl = "" /* Metadata: 0x00B1342D */) {} // 0x0000000181153570-0x00000001811536A0
		// [XID] // 0x00000001899BBF60-0x00000001899BBF80
		public static bool GetLogicResult(LogicType logicType, List<bool> valueList) => default; // 0x00000001811688B0-0x0000000181168EC0
		// [XID] // 0x00000001899C3A90-0x00000001899C3AB0
		private static int GetTrueValueCount(List<bool> valueList, int startIndex, int endIndex) => default; // 0x0000000181172430-0x0000000181172530
		// [XID] // 0x00000001899CB0B0-0x00000001899CB0D0
		public static bool RelationalOperate(RelationalOperator opt, uint a, uint b) => default; // 0x0000000181178AA0-0x0000000181178BD0
		// [XID] // 0x00000001899D25C0-0x00000001899D25E0
		public static bool GetCompareResult(OrderingType orderingType, int value1, int value2) => default; // 0x00000001811644E0-0x00000001811645E0
		// [XID] // 0x00000001899D9CA0-0x00000001899D9CC0
		public static bool GetDropPos(BaseEntity entity, ref Vector3 pos) => default; // 0x00000001811654D0-0x00000001811656F0
		// [IDTag] // 0x00000001899E1590-0x00000001899E15D0
		// [XID] // 0x00000001899E1590-0x00000001899E15D0
		public static string ConcatString(string s1, string s2) => default; // 0x00000001811549F0-0x0000000181154B20
		// [IDTag] // 0x00000001899EB8E0-0x00000001899EB920
		// [XID] // 0x00000001899EB8E0-0x00000001899EB920
		public static string ConcatString(string s1, string s2, string s3) => default; // 0x0000000181154E80-0x0000000181154FE0
		// [IDTag] // 0x00000001899F6430-0x00000001899F6470
		// [XID] // 0x00000001899F6430-0x00000001899F6470
		public static string ConcatString(string s1, string s2, string s3, string s4) => default; // 0x0000000181155110-0x0000000181155290
		// [IDTag] // 0x0000000189A00740-0x0000000189A00780
		// [XID] // 0x0000000189A00740-0x0000000189A00780
		public static string ConcatString(string s1, string s2, string s3, string s4, string s5) => default; // 0x0000000181154CE0-0x0000000181154E80
		// [IDTag] // 0x0000000189A0AF70-0x0000000189A0AFB0
		// [XID] // 0x0000000189A0AF70-0x0000000189A0AFB0
		public static string ConcatString(string s1, string s2, string s3, string s4, string s5, string s6) => default; // 0x0000000181154B20-0x0000000181154CE0
		// [IDTag] // 0x0000000189A15720-0x0000000189A15760
		// [XID] // 0x0000000189A15720-0x0000000189A15760
		public static string ConcatString(string s1, uint ui2) => default; // 0x0000000181154FE0-0x0000000181155110
		// [IDTag] // 0x0000000189A1F9B0-0x0000000189A1F9F0
		// [XID] // 0x0000000189A1F9B0-0x0000000189A1F9F0
		public static string ConcatString(string s1, uint ui2, string s3, uint ui4) => default; // 0x0000000181154880-0x00000001811549F0
		// [XID] // 0x0000000189A29E70-0x0000000189A29E90
		public static void SetUnloadCPUVertexDataForSkinnedMesh(bool value) {} // 0x000000018117CF30-0x000000018117CFD0
		[DebuggerHidden] // 0x0000000189A313C0-0x0000000189A31400
		// [XID] // 0x0000000189A313C0-0x0000000189A31400
		public static IEnumerator LimitTimeCoroutine(IEnumerator enumerator, SliceFrameWatch loadWatcher) => default; // 0x0000000181174B70-0x0000000181174C50
		// [XID] // 0x0000000189A3BAD0-0x0000000189A3BAF0
		public static void TryToDownloadFullRes() {} // 0x000000018117E080-0x000000018117E2A0
		// [XID] // 0x0000000189A43700-0x0000000189A43720
		public static void TryToDownloadPreRes() {} // 0x000000018117E2A0-0x000000018117E550
		// [XID] // 0x0000000189A4ABF0-0x0000000189A4AC10
		public static long GetDownloadResourceSize() => default; // 0x00000001811653F0-0x00000001811654D0
		// [XID] // 0x0000000189A52240-0x0000000189A52260
		public static long GetTotalResourceSize() => default; // 0x0000000181172270-0x0000000181172350
		// [XID] // 0x0000000189A59C00-0x0000000189A59C20
		public static bool IsGuest() => default; // 0x0000000181173B70-0x0000000181173D50
		// [XID] // 0x0000000189A613A0-0x0000000189A613C0
		public static bool IsHost() => default; // 0x0000000181173F40-0x0000000181174000
	
		// Extension methods
		// [IDTag] // 0x00000001898A2C60-0x00000001898A2CB0
		// [XID] // 0x00000001898A2C60-0x00000001898A2CB0
		public static Vector3 FromProto(this Vector protoVec) => default; // 0x0000000181157D00-0x0000000181157E40
		// [IDTag] // 0x00000001898B0420-0x00000001898B0470
		// [XID] // 0x00000001898B0420-0x00000001898B0470
		public static Vector3 FromProto(this Vector3Int protoVec) => default; // 0x0000000181157B90-0x0000000181157D00
		// [IDTag] // 0x00000001898BD9F0-0x00000001898BDA40
		// [XID] // 0x00000001898BD9F0-0x00000001898BDA40
		public static Quaternion FromProto(this MathQuaternion protoQ) => default; // 0x0000000181157E40-0x0000000181157FA0
		// [IDTag] // 0x00000001898E07A0-0x00000001898E07F0
		// [XID] // 0x00000001898E07A0-0x00000001898E07F0
		public static Box3 FromProto(this ShapeBox protoBox) => default; // 0x0000000181157470-0x0000000181157B90
		// [XID] // 0x0000000189903330-0x0000000189903370
		public static bool IsActivated(this Renderer r) => default; // 0x00000001811735F0-0x0000000181173700
		// [XID] // 0x000000018990DC40-0x000000018990DC80
		public static bool IsRendering(this Renderer r) => default; // 0x0000000181174500-0x00000001811745D0
		// [XID] // 0x00000001899183A0-0x00000001899183E0
		public static bool IsSameTypeOrSubClassTypeOf(this System.Type subType, System.Type baseType) => default; // 0x0000000181174700-0x00000001811747E0
		public static T AddAndReturnElement<T>(this List<T> list, T inElement) => default;
		public static string ToDebugString<TKey, TValue>(this Dictionary<TKey, TValue> inDict) => default;
		// [XID] // 0x0000000189983F10-0x0000000189983F50
		public static bool IsNoneParent(this RectTransform rectTransform) => default; // 0x0000000181174390-0x0000000181174500
		// [XID] // 0x000000018962A470-0x000000018962A4B0
		public static void SetPrivateFieldEx(this object instance, string fieldname, object value) {} // 0x000000018117CDB0-0x000000018117CF30
		// [XID] // 0x0000000189634FF0-0x0000000189635030
		public static object GetPrivateField(this object instance, string fieldname) => default; // 0x000000018116FF10-0x0000000181170090
		// [XID] // 0x000000018963F5E0-0x000000018963F620
		public static object GetPrivateProperty(this object instance, string propertyname) => default; // 0x0000000181170090-0x00000001811701F0
		// [XID] // 0x0000000189649D10-0x0000000189649D50
		public static object CallPrivateMethod(this object instance, string name, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] param) => default; // 0x000000018114F3B0-0x000000018114F520
		public static bool Contains<T>(this List<T> lst, T item, IEqualityComparer<T> comparer) => default;
	}
}
