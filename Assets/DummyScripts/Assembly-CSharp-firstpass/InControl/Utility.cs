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

namespace InControl
{
	public static class Utility // TypeDefIndex: 8005
	{
		// Fields
		public const float Epsilon = 1E-07f; // Metadata: 0x00ADF3B5
		private static Vector2[] circleVertexList; // 0x00
	
		// Properties
		internal static bool Is32Bit { /* [XID] */ /* 0x000000018983DD60-0x000000018983DD80 */ get; } // 0x0000000187B08E80-0x0000000187B08F20 
		internal static bool Is64Bit { /* [XID] */ /* 0x00000001896F37C0-0x00000001896F37E0 */ get; } // 0x0000000187B08F20-0x0000000187B08FC0 
	
		// Constructors
		static Utility() {} // 0x0000000187B08700-0x0000000187B08E80
	
		// Methods
		// [IDTag] // 0x0000000189BC0600-0x0000000189BC0640
		// [XID] // 0x0000000189BC0600-0x0000000189BC0640
		public static void DrawCircleGizmo(Vector2 center, float radius) {} // 0x0000000187B06040-0x0000000187B06300
		// [IDTag] // 0x0000000189BCB520-0x0000000189BCB560
		// [XID] // 0x0000000189BCB520-0x0000000189BCB560
		public static void DrawCircleGizmo(Vector2 center, float radius, Color color) {} // 0x0000000187B05F20-0x0000000187B06040
		// [IDTag] // 0x0000000189BD5820-0x0000000189BD5860
		// [XID] // 0x0000000189BD5820-0x0000000189BD5860
		public static void DrawOvalGizmo(Vector2 center, Vector2 size) {} // 0x0000000187B06300-0x0000000187B065F0
		// [IDTag] // 0x0000000189BE0090-0x0000000189BE00D0
		// [XID] // 0x0000000189BE0090-0x0000000189BE00D0
		public static void DrawOvalGizmo(Vector2 center, Vector2 size, Color color) {} // 0x0000000187B065F0-0x0000000187B06720
		// [IDTag] // 0x00000001895EFEB0-0x00000001895EFEF0
		// [XID] // 0x00000001895EFEB0-0x00000001895EFEF0
		public static void DrawRectGizmo(Rect rect) {} // 0x0000000187B06720-0x0000000187B06970
		// [IDTag] // 0x00000001895FA480-0x00000001895FA4C0
		// [XID] // 0x00000001895FA480-0x00000001895FA4C0
		public static void DrawRectGizmo(Rect rect, Color color) {} // 0x0000000187B06AA0-0x0000000187B06BC0
		// [IDTag] // 0x0000000189604D30-0x0000000189604D70
		// [XID] // 0x0000000189604D30-0x0000000189604D70
		public static void DrawRectGizmo(Vector2 center, Vector2 size) {} // 0x0000000187B06BC0-0x0000000187B06E00
		// [IDTag] // 0x000000018960F4D0-0x000000018960F510
		// [XID] // 0x000000018960F4D0-0x000000018960F510
		public static void DrawRectGizmo(Vector2 center, Vector2 size, Color color) {} // 0x0000000187B06970-0x0000000187B06AA0
		// [XID] // 0x000000018995FBB0-0x000000018995FBD0
		public static bool GameObjectIsCulledOnCurrentCamera(GameObject gameObject) => default; // 0x0000000187B06E00-0x0000000187B06EE0
		// [XID] // 0x0000000189621250-0x0000000189621270
		public static Color MoveColorTowards(Color color0, Color color1, float maxDelta) => default; // 0x0000000187B07A80-0x0000000187B07C80
		// [XID] // 0x00000001896CCE80-0x00000001896CCEA0
		public static float ApplyDeadZone(float value, float lowerDeadZone, float upperDeadZone) => default; // 0x0000000187B058D0-0x0000000187B05A10
		// [XID] // 0x0000000189A1D520-0x0000000189A1D540
		public static float ApplySmoothing(float thisValue, float lastValue, float deltaTime, float sensitivity) => default; // 0x0000000187B05A10-0x0000000187B05C10
		// [XID] // 0x0000000189638060-0x0000000189638080
		public static float ApplySnapping(float value, float threshold) => default; // 0x0000000187B05C10-0x0000000187B05CF0
		// [XID] // 0x000000018963F270-0x000000018963F290
		internal static bool TargetIsButton(InputControlType target) => default; // 0x0000000187B08080-0x0000000187B08140
		// [XID] // 0x0000000189646AC0-0x0000000189646AE0
		internal static bool TargetIsStandard(InputControlType target) => default; // 0x0000000187B08140-0x0000000187B08200
		// [XID] // 0x000000018964E3C0-0x000000018964E3E0
		internal static bool TargetIsAlias(InputControlType target) => default; // 0x0000000187B07FD0-0x0000000187B08080
		// [XID] // 0x0000000189655C60-0x0000000189655C80
		public static string ReadFromFile(string path) => default; // 0x0000000187B07ED0-0x0000000187B07FD0
		// [XID] // 0x0000000189A58DC0-0x0000000189A58DE0
		public static void WriteToFile(string path, string data) {} // 0x0000000187B085E0-0x0000000187B08700
		// [XID] // 0x0000000189664A50-0x0000000189664A70
		public static float Abs(float value) => default; // 0x0000000187B05740-0x0000000187B057F0
		// [IDTag] // 0x000000018966BFE0-0x000000018966C020
		// [XID] // 0x000000018966BFE0-0x000000018966C020
		public static bool Approximately(float v1, float v2) => default; // 0x0000000187B05CF0-0x0000000187B05DD0
		// [IDTag] // 0x0000000189676E10-0x0000000189676E50
		// [XID] // 0x0000000189676E10-0x0000000189676E50
		public static bool Approximately(Vector2 v1, Vector2 v2) => default; // 0x0000000187B05DD0-0x0000000187B05F20
		// [XID] // 0x0000000189681740-0x0000000189681760
		public static bool IsNotZero(float value) => default; // 0x0000000187B074D0-0x0000000187B075A0
		// [XID] // 0x00000001896891C0-0x00000001896891E0
		public static bool IsZero(float value) => default; // 0x0000000187B075A0-0x0000000187B07660
		// [XID] // 0x0000000189690D00-0x0000000189690D20
		public static bool AbsoluteIsOverThreshold(float value, float threshold) => default; // 0x0000000187B057F0-0x0000000187B058D0
		// [XID] // 0x0000000189698670-0x0000000189698690
		public static float NormalizeAngle(float angle) => default; // 0x0000000187B07D50-0x0000000187B07E30
		// [XID] // 0x000000018969FA30-0x000000018969FA50
		public static float VectorToAngle(Vector2 vector) => default; // 0x0000000187B08440-0x0000000187B085E0
		// [IDTag] // 0x00000001896A6BD0-0x00000001896A6C10
		// [XID] // 0x00000001896A6BD0-0x00000001896A6C10
		public static float Min(float v0, float v1) => default; // 0x0000000187B079C0-0x0000000187B07A80
		// [IDTag] // 0x00000001896B0B80-0x00000001896B0BC0
		// [XID] // 0x00000001896B0B80-0x00000001896B0BC0
		public static float Max(float v0, float v1) => default; // 0x0000000187B07800-0x0000000187B078C0
		// [IDTag] // 0x00000001896BB540-0x00000001896BB580
		// [XID] // 0x00000001896BB540-0x00000001896BB580
		public static float Min(float v0, float v1, float v2, float v3) => default; // 0x0000000187B078C0-0x0000000187B079C0
		// [IDTag] // 0x00000001896C59D0-0x00000001896C5A10
		// [XID] // 0x00000001896C59D0-0x00000001896C5A10
		public static float Max(float v0, float v1, float v2, float v3) => default; // 0x0000000187B07700-0x0000000187B07800
		// [IDTag] // 0x00000001896D0050-0x00000001896D0090
		// [XID] // 0x00000001896D0050-0x00000001896D0090
		internal static float ValueFromSides(float negativeSide, float positiveSide) => default; // 0x0000000187B08320-0x0000000187B08440
		// [IDTag] // 0x00000001896DA570-0x00000001896DA5B0
		// [XID] // 0x00000001896DA570-0x00000001896DA5B0
		internal static float ValueFromSides(float negativeSide, float positiveSide, bool invertSides) => default; // 0x0000000187B08200-0x0000000187B08320
		public static void ArrayResize<T>(ref T[] array, int capacity) {}
		public static void ArrayExpand<T>(ref T[] array, int capacity) {}
		// [XID] // 0x00000001896E4A90-0x00000001896E4AB0
		public static int NextPowerOfTwo(int value) => default; // 0x0000000187B07C80-0x0000000187B07D50
		// [XID] // 0x00000001896FAD90-0x00000001896FADB0
		public static string HKLM_GetString(string path, string key) => default; // 0x0000000187B07390-0x0000000187B074D0
		// [XID] // 0x0000000189702550-0x0000000189702570
		public static string GetWindowsVersion() => default; // 0x0000000187B06FB0-0x0000000187B07390
		// [XID] // 0x00000001897D6C20-0x00000001897D6C40
		public static int GetSystemBuildNumber() => default; // 0x0000000187B06EE0-0x0000000187B06FB0
		// [XID] // 0x00000001897116D0-0x00000001897116F0
		internal static void LoadScene(string sceneName) {} // 0x0000000187B07660-0x0000000187B07700
		// [XID] // 0x0000000189718C10-0x0000000189718C30
		internal static string PluginFileExtension() => default; // 0x0000000187B07E30-0x0000000187B07ED0
	}
}
