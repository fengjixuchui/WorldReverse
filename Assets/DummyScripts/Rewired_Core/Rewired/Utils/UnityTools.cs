/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	public static class UnityTools // TypeDefIndex: 4385
	{
		// Fields
		private static UnityVersionClass fytgrcqicPYuVRynSPvNvWQqPdU; // 0x00
		private static UnityVersion HhUcfAfathuZdUwExEfjNlLUbqdE; // 0x08
		private static string dCeOGUzcRwLToVdfjhUVfEySoYkd; // 0x10
		private static Platform mLEjzCONQxewtfMqTzjCjXcnmAN; // 0x18
		private static EditorPlatform TAeiTQcgMAUjxnGidzESNBdrZfL; // 0x1C
		private static bool pUjXmoClaqAScEyXFQTGbMYIYhRD; // 0x20
		private static bool BMqYVQTBOGkiqBwYdORkfmZYOzj; // 0x21
		private static bool MdzHzTWTwuIKKMjMWYlflDgWlAN; // 0x22
		private static WebplayerPlatform hfpQRTMlbWHjpKZUTBjPrNSHOMN; // 0x24
		private static bool OzSzuYcbDfaEEwiiCrBdFnRMjLr; // 0x28
		private static bool LimXWHcwEYhzCjjnawXqqTFlURO; // 0x29
		private static bool DbYozYMNfhjihgvNvfHXjoSGDPga; // 0x2A
		private static bool NUqUTNPFCClnYFiEvnShrkLFsOx; // 0x2B
		private static bool SLODlNdbCtxSTcUIgdjDzktdwvk; // 0x2C
		private static bool hfwpMeuhAHjQlbHCfbEaJGafskXr; // 0x2D
		private static string JtLerAipovhaqKOSApGnjkThXzuM; // 0x30
		private static ScriptingBackend LmvbaryBoUUZyiBfMLUzUhumCJyC; // 0x38
		private static ScriptingAPILevel chsaHgOfWmfBIIUVLbuqIlhCMgZu; // 0x3C
		private static IExternalTools hpLdyFVMkPBycwhCIbjEeQSvAcHD; // 0x40
		private static bool CEOUfcZJBUPInVYkafUQiywkcdB; // 0x48
	
		// Properties
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static UnityVersionClass unityVersionObj { get; } // 0x00000001862FFA60-0x00000001862FFB20 
		public static UnityVersion unityVersion { get; } // 0x00000001862FFC10-0x00000001862FFCD0 
		public static string unityVersionString { get; } // 0x00000001862FFB20-0x00000001862FFC10 
		public static Platform platform { get; } // 0x00000001862FF8E0-0x00000001862FF9A0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static Platform effectivePlatform { get; } // 0x00000001862FEF10-0x00000001862FF050 
		public static EditorPlatform editorPlatform { get; } // 0x00000001862FEE50-0x00000001862FEF10 
		public static bool isEditor { get; } // 0x00000001862FF2E0-0x00000001862FF3A0 
		public static WebplayerPlatform webplayerPlatform { get; } // 0x00000001862FFCD0-0x00000001862FFD90 
		public static bool logToDebugLog { get; } // 0x00000001862FF640-0x00000001862FF8E0 
		public static bool isAndroidPlatform { get; } // 0x00000001862FF190-0x00000001862FF2E0 
		public static bool isIOSPlatform { get; } // 0x00000001862FF3A0-0x00000001862FF490 
		public static bool isStandalonePlatform { get; } // 0x00000001862FF520-0x00000001862FF640 
		public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull { get; } // 0x00000001862FFD90-0x00000001862FFE50 
		public static bool supportsUnityUIGraphicRaycastTarget { get; } // 0x00000001862FF9A0-0x00000001862FFA60 
		public static IExternalTools externalTools { get; } // 0x00000001862FF050-0x00000001862FF110 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isInitialized { get; } // 0x00000001862FF490-0x00000001862FF520 
		private static bool initialized { get; } // 0x00000001862FF110-0x00000001862FF190 
	
		// Nested types
		public enum UnityVersion // TypeDefIndex: 4386
		{
			UNITY_2_6 = 0,
			UNITY_2_6_1 = 1,
			UNITY_3_0 = 2,
			UNITY_3_0_0 = 3,
			UNITY_3_1 = 4,
			UNITY_3_2 = 5,
			UNITY_3_3 = 6,
			UNITY_3_4 = 7,
			UNITY_3_5 = 8,
			UNITY_3_5_2 = 9,
			UNITY_3_5_7 = 10,
			UNITY_3_MAX = 11,
			UNITY_4_0 = 12,
			UNITY_4_0_1 = 13,
			UNITY_4_1 = 14,
			UNITY_4_2 = 15,
			UNITY_4_3 = 16,
			UNITY_4_4 = 17,
			UNITY_4_5 = 18,
			UNITY_4_6 = 19,
			UNITY_4_6_3p1 = 20,
			UNITY_4_6_3p1Plus = 21,
			UNITY_4_7 = 22,
			UNITY_4_8 = 23,
			UNITY_4_9 = 24,
			UNITY_4_MAX = 25,
			UNITY_5_0 = 26,
			UNITY_5_0_0p1 = 27,
			UNITY_5_0_0p1Plus = 28,
			UNITY_5_0_1 = 29,
			UNITY_5_0_2 = 30,
			UNITY_5_1 = 31,
			UNITY_5_2 = 32,
			UNITY_5_3 = 33,
			UNITY_5_4 = 34,
			UNITY_5_5 = 35,
			UNITY_5_6 = 36,
			UNITY_5_7 = 37,
			UNITY_5_8 = 38,
			UNITY_5_9 = 39,
			UNITY_5_MAX = 40,
			UNITY_2017_0 = 41,
			UNITY_2017_1 = 42,
			UNITY_2017_2 = 43,
			UNITY_2017_3 = 44,
			UNITY_2017_4 = 45,
			UNITY_2017_5 = 46,
			UNITY_2017_6 = 47,
			UNITY_2017_7 = 48,
			UNITY_2017_8 = 49,
			UNITY_2017_9 = 50,
			UNITY_2017_MAX = 51,
			UNITY_2018_0 = 52,
			UNITY_2018_1 = 53,
			UNITY_2018_2 = 54,
			UNITY_2018_3 = 55,
			UNITY_2018_4 = 56,
			UNITY_2018_5 = 57,
			UNITY_2018_6 = 58,
			UNITY_2018_7 = 59,
			UNITY_2018_8 = 60,
			UNITY_2018_9 = 61,
			UNITY_2018_MAX = 62,
			UNITY_2019_0 = 63,
			UNITY_2019_1 = 64,
			UNITY_2019_2 = 65,
			UNITY_2019_3 = 66,
			UNITY_2019_4 = 67,
			UNITY_2019_5 = 68,
			UNITY_2019_6 = 69,
			UNITY_2019_7 = 70,
			UNITY_2019_8 = 71,
			UNITY_2019_9 = 72,
			UNITY_2019_MAX = 73,
			UNITY_2020_0 = 74,
			UNITY_2020_1 = 75,
			UNITY_2020_2 = 76,
			UNITY_2020_3 = 77,
			UNITY_2020_4 = 78,
			UNITY_2020_5 = 79,
			UNITY_2020_6 = 80,
			UNITY_2020_7 = 81,
			UNITY_2020_8 = 82,
			UNITY_2020_9 = 83,
			UNITY_2020_MAX = 84,
			UNITY_2021_0 = 85,
			UNITY_2021_1 = 86,
			UNITY_2021_2 = 87,
			UNITY_2021_3 = 88,
			UNITY_2021_4 = 89,
			UNITY_2021_5 = 90,
			UNITY_2021_6 = 91,
			UNITY_2021_7 = 92,
			UNITY_2021_8 = 93,
			UNITY_2021_9 = 94,
			UNITY_2021_MAX = 95,
			Unknown = 1000
		}
	
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		internal class UnityVersionClass // TypeDefIndex: 4387
		{
			// Fields
			public readonly int major; // 0x10
			public readonly int minor; // 0x14
			public readonly int maintenance; // 0x18
			public readonly pOyAbQrKJnQPftllxDYGOAPUHHOF type; // 0x1C
			public readonly int build; // 0x20
	
			// Nested types
			public enum pOyAbQrKJnQPftllxDYGOAPUHHOF // TypeDefIndex: 4388
			{
				YTgToBVNxXcoaDwoDBQufCSlYO = 0,
				TfFsLkpvDhvxrDkyfUuZBDQXiKj = 1,
				rTBzurrqanuhBDdLablUSJpWRhq = 2
			}
	
			// Constructors
			public UnityVersionClass() {} // Dummy constructor
			public UnityVersionClass(string versionString) {} // 0x0000000186300A20-0x0000000186300DE0
	
			// Methods
			public override string ToString() => default; // 0x00000001863006F0-0x0000000186300A20
			private string tLQPCoMAxRrphBINKosQsrBMTbq(pOyAbQrKJnQPftllxDYGOAPUHHOF param_0000928b) => default; // 0x0000000186301060-0x0000000186301120
			public override bool Equals(object obj) => default; // 0x0000000186300210-0x0000000186300330
			public override int GetHashCode() => default; // 0x0000000186300330-0x00000001863003A0
			public static bool operator <(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300FE0-0x0000000186301060
			public static bool operator >(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300EE0-0x0000000186300F60
			public static bool operator >=(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300E60-0x0000000186300EE0
			public static bool operator ==(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300DE0-0x0000000186300E60
			public static bool operator !=(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300F60-0x0000000186300FE0
			public static int Comparison(UnityVersionClass a, UnityVersionClass b) => default; // 0x0000000186300030-0x0000000186300210
			public static bool IsValidVersionString(string versionString) => default; // 0x00000001863003A0-0x0000000186300640
			private static int KBRGUEOMFtbGRrICreKzHJyIBdJc(pOyAbQrKJnQPftllxDYGOAPUHHOF param_0000929a) => default; // 0x0000000186300640-0x00000001863006F0
		}
	
		// Constructors
		static UnityTools() {} // 0x00000001862FE900-0x00000001862FE960
	
		// Methods
		private static bool KrDkfUaKgwLlTBDBOttdhpqHjPa() => default; // 0x00000001862FD3B0-0x00000001862FD540
		internal static void YJaAHaimrHWIfKrgfWxeihnqrcza(Platform param_0000924c, EditorPlatform param_0000924d, bool param_0000924e, WebplayerPlatform param_0000924f, ScriptingBackend param_00009250, ScriptingAPILevel param_00009251, IExternalTools param_00009252) {} // 0x00000001862FE5A0-0x00000001862FE900
		public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr) => default; // 0x00000001862FCC10-0x00000001862FD1A0
		private static bool SFQgSbAOcwfGbOcXMxDlclCscMr(string param_00009255, out int param_00009256) {
			param_00009256 = default;
			return default;
		} // 0x00000001862FE2D0-0x00000001862FE420
		private static void lWdmAJAIMqiZQEGIVKRiGFuFfHLp() {} // 0x00000001862FFE50-0x0000000186300030
		private static UnityVersion NjMuvNfRaYDYhNACGHKVBJKdfBaT(string param_00009257) => default; // 0x00000001862FD540-0x00000001862FE2D0
		private static void cBMTcrrzWasOCZKCFzXdUGhCFCk() {} // 0x00000001862FE960-0x00000001862FEE50
		public static List<string> GetCurrentPlatformResourecesDLLPaths() => default; // 0x00000001862FC250-0x00000001862FC430
		public static T GetComponent<T>(Transform transform)
			where T : class => default;
		public static T GetComponent<T>(Component component)
			where T : class => default;
		public static T GetComponent<T>(GameObject gameObject)
			where T : class => default;
		public static T GetComponentInChildren<T>(GameObject gameObject)
			where T : class => default;
		public static T GetComponentInChildren<T>(Transform transform)
			where T : class => default;
		public static T GetComponentInSelfOrChildren<T>(GameObject gameObject)
			where T : class => default;
		public static T GetComponentInSelfOrParents<T>(GameObject gameObject)
			where T : class => default;
		public static T GetComponentInSelfOrParents<T>(Transform transform)
			where T : class => default;
		public static List<T> GetComponentsInSelfAndChildren<T>(Component component)
			where T : class => default;
		public static List<T> GetComponentsInSelfAndChildren<T>(GameObject gameObject)
			where T : class => default;
		public static int GetComponents<T>(Transform transform, List<T> results, bool append)
			where T : class => default;
		public static int GetComponents<T>(GameObject gameObject, List<T> results, bool append)
			where T : class => default;
		public static int GetComponentsInSelfAndChildren<T>(Transform transform, List<T> results, bool append)
			where T : class => default;
		public static int GetComponentsInParents<T>(Transform transform, List<T> results, bool append)
			where T : class => default;
		public static int GetComponentsInParents<T>(GameObject gameObject, List<T> results, bool append)
			where T : class => default;
		public static bool IsActiveAndEnabled(Component component) => default; // 0x00000001862FCA90-0x00000001862FCC10
		public static T Instantiate<T>(UnityEngine.Object original, Transform parent, bool instantiateInWorldSpace)
			where T : UnityEngine.Object => default;
		public static T Instantiate<T>(UnityEngine.Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace)
			where T : UnityEngine.Object => default;
		public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point) => default; // 0x00000001862FE420-0x00000001862FE5A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool IsObjectInScene<T>(T @object)
			where T : UnityEngine.Object => default;
		public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex) => default; // 0x00000001862FC6C0-0x00000001862FC760
		public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex) => default; // 0x00000001862FC430-0x00000001862FC6C0
		public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex) => default; // 0x00000001862FC9F0-0x00000001862FCA90
		public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex) => default; // 0x00000001862FC760-0x00000001862FC9F0
		public static bool IsValidUnityJoystickName(string name) => default; // 0x00000001862FD1A0-0x00000001862FD3B0
		public static AnimationCurve Copy(AnimationCurve orig) => default; // 0x00000001862FC130-0x00000001862FC250
		public static bool IsNullOrDestroyed<T>(T @object)
			where T : class => default;
		private static T wmXslAXzQdCqhpIpRtlCsLfDCSgh<T>(T param_00009289)
			where T : class => default;
	}
}
