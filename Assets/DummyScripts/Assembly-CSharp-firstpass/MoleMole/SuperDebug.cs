/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	[Skip] // 0x0000000189622900-0x0000000189622910
	public static class SuperDebug // TypeDefIndex: 10634
	{
		// Fields
		public static bool[] DEBUG_SWITCH; // 0x00
		public static string[] LOG_PREFIX; // 0x08
		public static string MOVE_LOG_FORMAT; // 0x10
		public const string MENU_ROOT = "SuperDebug"; // Metadata: 0x00AE7EA2
		public const int DEFAULT = 0; // Metadata: 0x00AE7EB0
		public const int LEVEL = 1; // Metadata: 0x00AE7EB4
		public const int EVENT = 2; // Metadata: 0x00AE7EB8
		public const int LUA = 3; // Metadata: 0x00AE7EBC
		public const int AI = 4; // Metadata: 0x00AE7EC0
		public const int ABILITY = 5; // Metadata: 0x00AE7EC4
		public const int NETWORK = 6; // Metadata: 0x00AE7EC8
		public const int ANIMATION = 7; // Metadata: 0x00AE7ECC
		public const int QA = 8; // Metadata: 0x00AE7ED0
		public const int ASSETBUNDLE = 9; // Metadata: 0x00AE7ED4
		public const int APNS = 10; // Metadata: 0x00AE7ED8
		public const int MP = 11; // Metadata: 0x00AE7EDC
		public const int CAMERA = 12; // Metadata: 0x00AE7EE0
		public const int HUMANOIDMOVE = 13; // Metadata: 0x00AE7EE4
		public const int IKMOVE = 14; // Metadata: 0x00AE7EE8
		public const int IKCLIMB = 15; // Metadata: 0x00AE7EEC
		public const int TESTMOVE = 16; // Metadata: 0x00AE7EF0
		public const int HUMANOIDMOVE_DEEP = 17; // Metadata: 0x00AE7EF4
		public const int AUDIO = 18; // Metadata: 0x00AE7EF8
		public const int ITEM = 19; // Metadata: 0x00AE7EFC
		public const int HUMANOIDMOVE_SYNC = 20; // Metadata: 0x00AE7F00
		public const int MOTION4HI = 21; // Metadata: 0x00AE7F04
		public const int UI = 22; // Metadata: 0x00AE7F08
		public const int QUEST = 23; // Metadata: 0x00AE7F0C
		public const int MOTION_AUTHORITY = 24; // Metadata: 0x00AE7F10
		public const int MOTION_REMOTE = 25; // Metadata: 0x00AE7F14
		public const int CUTSCENE = 26; // Metadata: 0x00AE7F18
		public const int MP_ABILITY = 27; // Metadata: 0x00AE7F1C
		public const int TALENT = 28; // Metadata: 0x00AE7F20
		public const int AIBETA = 29; // Metadata: 0x00AE7F24
		public const int MAP = 30; // Metadata: 0x00AE7F28
		public const int GIZMOS = 31; // Metadata: 0x00AE7F2C
		public const int MP_MODIFIER = 32; // Metadata: 0x00AE7F30
		public const int SCENE_PROP = 33; // Metadata: 0x00AE7F34
		public const int SERVER = 34; // Metadata: 0x00AE7F38
		public const int DRAW_MOVE_TASK = 35; // Metadata: 0x00AE7F3C
		public const int FORCE_DISABLE_MOVE_STACKTRACE = 36; // Metadata: 0x00AE7F40
		public const int MP_GADGET = 37; // Metadata: 0x00AE7F44
		public const int COMBINE_PACKET = 38; // Metadata: 0x00AE7F48
		public const int EFFECT = 39; // Metadata: 0x00AE7F4C
		public const int ELEMENT = 40; // Metadata: 0x00AE7F50
		public const int AVATAR = 41; // Metadata: 0x00AE7F54
		public const int AUTO_TEST = 42; // Metadata: 0x00AE7F58
		public const int MP_MASSIVE = 43; // Metadata: 0x00AE7F5C
		public const int SECTOR = 44; // Metadata: 0x00AE7F60
		public const int ACTION = 45; // Metadata: 0x00AE7F64
		public const int PRELOAD = 46; // Metadata: 0x00AE7F68
		public const int GADGET = 47; // Metadata: 0x00AE7F6C
		public const int SYNC_ANIMATOR = 48; // Metadata: 0x00AE7F70
		public const int MP_COMBAT = 49; // Metadata: 0x00AE7F74
		public const int CROWD_ANIM = 50; // Metadata: 0x00AE7F78
		public const int TARGETTING = 51; // Metadata: 0x00AE7F7C
		public const int SERVER_BUFF = 52; // Metadata: 0x00AE7F80
		public const int GRAPHIC_SETTING = 53; // Metadata: 0x00AE7F84
		public const int SERVER_ABILITY = 54; // Metadata: 0x00AE7F88
		public const int ENTITY_REUSE = 55; // Metadata: 0x00AE7F8C
		public const int PROTO = 56; // Metadata: 0x00AE7F90
		public const int HUMANOIDMOVE_SYNC_TASK_AUTHORITY = 57; // Metadata: 0x00AE7F94
		public const int HUMANOIDMOVE_SYNC_TASK_REMOTE = 58; // Metadata: 0x00AE7F98
		public const int IKCCD = 59; // Metadata: 0x00AE7F9C
		public const int MAX_STACK_DEPTH = 10; // Metadata: 0x00AE7FA0
		public const int START_STACK_DEPTH = 1; // Metadata: 0x00AE7FA4
		public static Action<string, string> sendToServerAction; // 0x18
		public static bool ENABLE_ALERT; // 0x20
		private static object _requestSync; // 0x28
		private static Queue<SuperDebugRequest> _superDebugRequests; // 0x30
		public static Action<string, string, LogType, bool, int, int, ErrorLevel, ErrorCategory, string> logToServerAction; // 0x38
	
		// Properties
		private static bool IsCurrentMainThread { /* [XID] */ /* 0x0000000189A1C5B0-0x0000000189A1C5D0 */ get; } // 0x00000001868BF190-0x00000001868BF230 
	
		// Nested types
		public enum LogRequestType // TypeDefIndex: 10635
		{
			LOG = 0,
			ASSERT = 1,
			WARNING = 2,
			ERROR = 3,
			VERY_IMPORTANT = 4,
			Alert = 5
		}
	
		public struct SuperDebugRequest // TypeDefIndex: 10636
		{
			// Fields
			public LogType logType; // 0x00
			public LogRequestType type; // 0x04
			public int subType; // 0x08
			public int category; // 0x0C
			public string log; // 0x10
			public string title; // 0x18
			public string[] usernames; // 0x20
			public string username; // 0x28
			public object message; // 0x30
			public object[] args; // 0x38
			public UnityEngine.Object context; // 0x40
			public bool stack; // 0x48
			public bool deduplicate; // 0x49
			public int errorCode; // 0x4C
			public int subErrorCode; // 0x50
			public ErrorLevel errorLevel; // 0x54
			public ErrorCategory errorCategory; // 0x58
			public string notifyUserName; // 0x60
		}
	
		public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 agr7, T8 arg8, T9 arg9); // TypeDefIndex: 10637; 0x00000000-0x00000000
	
		// Constructors
		static SuperDebug() {} // 0x00000001868BDCB0-0x00000001868BF190
	
		// Methods
		// [XID] // 0x000000018962A180-0x000000018962A1A0
		public static bool IsSwitchOn(int inChannel) => default; // 0x00000001868B4FC0-0x00000001868B5090
		// [XID] // 0x0000000189A15340-0x0000000189A15360
		public static bool CanLog(int category, int? logFlag = default) => default; // 0x00000001868B0630-0x00000001868B0970
		// [XID] // 0x00000001896393A0-0x00000001896393C0
		public static bool CanLogNoCategoryCheck(int? logFlag = default) => default; // 0x00000001868B0360-0x00000001868B0630
		// [Conditional] // 0x0000000189640880-0x00000001896408D0
		// [XID] // 0x0000000189640880-0x00000001896408D0
		public static void Break() {} // 0x00000001868B02D0-0x00000001868B0360
		// [Conditional] // 0x000000018964AFC0-0x000000018964B020
		// [IDTag] // 0x000000018964AFC0-0x000000018964B020
		// [XID] // 0x000000018964AFC0-0x000000018964B020
		public static void DrawLine(int type, Vector3 start, Vector3 end, Color? color = default, float duration = 1f /* Metadata: 0x00AE7DE3 */, bool depthTest = true /* Metadata: 0x00AE7DE7 */) {} // 0x00000001868B4010-0x00000001868B4260
		// [Conditional] // 0x0000000189658870-0x00000001896588E0
		// [IDTag] // 0x0000000189658870-0x00000001896588E0
		// [XID] // 0x0000000189658870-0x00000001896588E0
		public static void DrawLine(Vector3 start, Vector3 end, Color? color = default, float duration = 1f /* Metadata: 0x00AE7DE8 */, bool depthTest = true /* Metadata: 0x00AE7DEC */) {} // 0x00000001868B4260-0x00000001868B44C0
		// [Conditional] // 0x0000000189665EC0-0x0000000189665F20
		// [IDTag] // 0x0000000189665EC0-0x0000000189665F20
		// [XID] // 0x0000000189665EC0-0x0000000189665F20
		public static void DrawRay(Vector3 start, Vector3 direction, Color? color = default, float duration = 1f /* Metadata: 0x00AE7DED */, bool depthTest = true /* Metadata: 0x00AE7DF1 */) {} // 0x00000001868B44C0-0x00000001868B4700
		// [Conditional] // 0x0000000189673BE0-0x0000000189673C50
		// [IDTag] // 0x0000000189673BE0-0x0000000189673C50
		// [XID] // 0x0000000189673BE0-0x0000000189673C50
		public static void DrawRay(int type, Vector3 start, Vector3 direction, Color? color = default, float duration = 1f /* Metadata: 0x00AE7DF2 */, bool depthTest = true /* Metadata: 0x00AE7DF6 */) {} // 0x00000001868B4700-0x00000001868B4950
		// [Conditional] // 0x00000001896815A0-0x0000000189681600
		// [IDTag] // 0x00000001896815A0-0x0000000189681600
		// [XID] // 0x00000001896815A0-0x0000000189681600
		public static void DrawCircle(Vector3 center, float radius, Vector3? forward = default, int drawDensity = 10 /* Metadata: 0x00AE7DF7 */, Color? color = default, float duration = 1f /* Metadata: 0x00AE7DFB */, bool depthTest = true /* Metadata: 0x00AE7DFF */) {} // 0x00000001868B2AA0-0x00000001868B2D60
		// [Conditional] // 0x000000018968F1D0-0x000000018968F240
		// [IDTag] // 0x000000018968F1D0-0x000000018968F240
		// [XID] // 0x000000018968F1D0-0x000000018968F240
		public static void DrawCircle(int type, Vector3 center, float radius, Vector3? forward = default, int drawDensity = 10 /* Metadata: 0x00AE7E00 */, Color? color = default, float duration = 1f /* Metadata: 0x00AE7E04 */, bool depthTest = true /* Metadata: 0x00AE7E08 */) {} // 0x00000001868B31A0-0x00000001868B3470
		// [Conditional] // 0x000000018969C7B0-0x000000018969C810
		// [IDTag] // 0x000000018969C7B0-0x000000018969C810
		// [XID] // 0x000000018969C7B0-0x000000018969C810
		private static void DrawCircle(Vector3 center, float radius, Vector3 forward, int drawDensity, Color color, float duration, bool depthTest) {} // 0x00000001868B2D60-0x00000001868B31A0
		// [Conditional] // 0x00000001896A9B40-0x00000001896A9BB0
		// [IDTag] // 0x00000001896A9B40-0x00000001896A9BB0
		// [XID] // 0x00000001896A9B40-0x00000001896A9BB0
		public static void DrawFan(Vector3 center, float radius, Vector3 forward, float halfAngle, int drawDensity = 10 /* Metadata: 0x00AE7E09 */, Color? color = default, float duration = 1f /* Metadata: 0x00AE7E0D */, bool depthTest = true /* Metadata: 0x00AE7E11 */) {} // 0x00000001868B3AE0-0x00000001868B3D70
		// [Conditional] // 0x00000001896B6DA0-0x00000001896B6E10
		// [IDTag] // 0x00000001896B6DA0-0x00000001896B6E10
		// [XID] // 0x00000001896B6DA0-0x00000001896B6E10
		public static void DrawFan(int type, Vector3 center, float radius, Vector3 forward, float halfAngle, int drawDensity = 10 /* Metadata: 0x00AE7E12 */, Color? color = default, float duration = 1f /* Metadata: 0x00AE7E16 */, bool depthTest = true /* Metadata: 0x00AE7E1A */) {} // 0x00000001868B3D70-0x00000001868B4010
		// [Conditional] // 0x00000001896C3F80-0x00000001896C3FE0
		// [IDTag] // 0x00000001896C3F80-0x00000001896C3FE0
		// [XID] // 0x00000001896C3F80-0x00000001896C3FE0
		private static void DrawFan(Vector3 center, float radius, Vector3 forward, float halfAngle, int drawDensity, Color color, float duration, bool depthTest) {} // 0x00000001868B3470-0x00000001868B3AE0
		// [Conditional] // 0x00000001896D13A0-0x00000001896D1400
		// [IDTag] // 0x00000001896D13A0-0x00000001896D1400
		// [XID] // 0x00000001896D13A0-0x00000001896D1400
		public static void DrawBounds(Vector3 center, Vector3 size, Quaternion rotation, Color? color = default, float duration = 1f /* Metadata: 0x00AE7E1B */, bool depthTest = true /* Metadata: 0x00AE7E1F */) {} // 0x00000001868B0D30-0x00000001868B0FB0
		// [Conditional] // 0x00000001896DEC70-0x00000001896DECD0
		// [IDTag] // 0x00000001896DEC70-0x00000001896DECD0
		// [XID] // 0x00000001896DEC70-0x00000001896DECD0
		public static void DrawBounds(int type, Vector3 center, Vector3 size, Quaternion rotation, Color? color = default, float duration = 1f /* Metadata: 0x00AE7E20 */, bool depthTest = true /* Metadata: 0x00AE7E24 */) {} // 0x00000001868B0AA0-0x00000001868B0D30
		// [Conditional] // 0x00000001896EBED0-0x00000001896EBF30
		// [IDTag] // 0x00000001896EBED0-0x00000001896EBF30
		// [XID] // 0x00000001896EBED0-0x00000001896EBF30
		private static void DrawBounds(Vector3 center, Vector3 size, Quaternion rotation, Color color, float duration, bool depthTest) {} // 0x00000001868B0FB0-0x00000001868B2AA0
		// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
		public static void CheckDictionaryKey<K, V>(Dictionary<K, V> dict, K key) {}
		// [XID] // 0x0000000189658BF0-0x0000000189658C10
		public static void CloseAllDebugs() {} // 0x00000001868B0970-0x00000001868B0AA0
		// [XID] // 0x0000000189889B20-0x0000000189889B40
		public static void SetDebugSwitch(int index, bool enable) {} // 0x00000001868BC090-0x00000001868BC190
		// [IDTag] // 0x000000018970FCB0-0x000000018970FCF0
		// [XID] // 0x000000018970FCB0-0x000000018970FCF0
		private static void SuperDebugAlertInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BC360-0x00000001868BC4C0
		// [IDTag] // 0x000000018971A3E0-0x000000018971A420
		// [XID] // 0x000000018971A3E0-0x000000018971A420
		private static void SuperDebugAlertInternal(string username, string title, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BC190-0x00000001868BC360
		// [IDTag] // 0x000000018972BD60-0x000000018972BDA0
		// [XID] // 0x000000018972BD60-0x000000018972BDA0
		private static void SuperDebugAlertInternal(string[] usernames, string title, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BC4C0-0x00000001868BC690
		// [Conditional] // 0x000000018973E3A0-0x000000018973E400
		// [IDTag] // 0x000000018973E3A0-0x000000018973E400
		// [XID] // 0x000000018973E3A0-0x000000018973E400
		public static void Alert(string username, string content, string moreInfo = "" /* Metadata: 0x00AE7E25 */) {} // 0x00000001868AF7B0-0x00000001868AF870
		// [Conditional] // 0x000000018974B970-0x000000018974B9C0
		// [XID] // 0x000000018974B970-0x000000018974B9C0
		public static void AlertWithCallstack(string username, string content, string moreInfo = "" /* Metadata: 0x00AE7E29 */) {} // 0x00000001868AF630-0x00000001868AF6F0
		// [Conditional] // 0x0000000189755EA0-0x0000000189755F10
		// [IDTag] // 0x0000000189755EA0-0x0000000189755F10
		// [XID] // 0x0000000189755EA0-0x0000000189755F10
		public static void Alert(string[] usernames, string content, string moreInfo = "" /* Metadata: 0x00AE7E2D */) {} // 0x00000001868AF6F0-0x00000001868AF7B0
		// [Conditional] // 0x00000001897633A0-0x0000000189763400
		// [IDTag] // 0x00000001897633A0-0x0000000189763400
		// [XID] // 0x00000001897633A0-0x0000000189763400
		public static void AlertFormat(string username, string title, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF330-0x00000001868AF4C0
		// [Conditional] // 0x0000000189778050-0x00000001897780B0
		// [IDTag] // 0x0000000189778050-0x00000001897780B0
		// [XID] // 0x0000000189778050-0x00000001897780B0
		public static void AlertFormat(string username, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF1C0-0x00000001868AF330
		// [Conditional] // 0x000000018978CD80-0x000000018978CDF0
		// [IDTag] // 0x000000018978CD80-0x000000018978CDF0
		// [XID] // 0x000000018978CD80-0x000000018978CDF0
		public static void AlertFormat(string[] usernames, string title, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF030-0x00000001868AF1C0
		// [Conditional] // 0x00000001897A2300-0x00000001897A2370
		// [IDTag] // 0x00000001897A2300-0x00000001897A2370
		// [XID] // 0x00000001897A2300-0x00000001897A2370
		public static void AlertFormat(string[] usernames, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF4C0-0x00000001868AF630
		// [XID] // 0x00000001897B79D0-0x00000001897B79F0
		private static void SuperDebugAssertInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BC690-0x00000001868BC840
		// [Conditional] // 0x00000001897BF980-0x00000001897BF9D0
		// [XID] // 0x00000001897BF980-0x00000001897BF9D0
		public static void Assert(bool cond, string msg = null, UnityEngine.Object context = null) {} // 0x00000001868B00C0-0x00000001868B02D0
		// [XID] // 0x00000001897C9D20-0x00000001897C9D40
		private static void AssertInternal(string msg, UnityEngine.Object context) {} // 0x00000001868AFD40-0x00000001868AFE20
		// [Conditional] // 0x00000001897D13B0-0x00000001897D1400
		// [XID] // 0x00000001897D13B0-0x00000001897D1400
		public static void AssertFormat(bool cond, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AFB80-0x00000001868AFD40
		// [Conditional] // 0x00000001897E3680-0x00000001897E36D0
		// [XID] // 0x00000001897E3680-0x00000001897E36D0
		public static void AssertThrow(bool cond, string msg = null, UnityEngine.Object context = null) {} // 0x00000001868AFF00-0x00000001868B00C0
		// [XID] // 0x00000001897EE120-0x00000001897EE140
		private static void AssertThrowInternal(string msg, UnityEngine.Object context) {} // 0x00000001868AFE20-0x00000001868AFF00
		// [Conditional] // 0x00000001897F58C0-0x00000001897F5910
		// [XID] // 0x00000001897F58C0-0x00000001897F5910
		public static void AssertConcat(bool cond, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF9F0-0x00000001868AFB80
		// [XID] // 0x0000000189807880-0x00000001898078A0
		private static void AssertConcatInternal(params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868AF870-0x00000001868AF9F0
		// [XID] // 0x000000018980E050-0x000000018980E070
		private static void SuperDebugErrorInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BC840-0x00000001868BCB10
		// [Conditional] // 0x000000018981DF70-0x000000018981DFD0
		// [IDTag] // 0x000000018981DF70-0x000000018981DFD0
		// [XID] // 0x000000018981DF70-0x000000018981DFD0
		public static void LogError(string log) {} // 0x00000001868B6560-0x00000001868B66E0
		// [IDTag] // 0x000000018982B5F0-0x000000018982B630
		// [XID] // 0x000000018982B5F0-0x000000018982B630
		private static void LogErrorInternal(string log) {} // 0x00000001868B5FF0-0x00000001868B60C0
		// [Conditional] // 0x0000000189835AB0-0x0000000189835B10
		// [IDTag] // 0x0000000189835AB0-0x0000000189835B10
		// [XID] // 0x0000000189835AB0-0x0000000189835B10
		public static void LogError(object message, UnityEngine.Object context) {} // 0x00000001868B66E0-0x00000001868B6870
		// [IDTag] // 0x00000001898431D0-0x0000000189843210
		// [XID] // 0x00000001898431D0-0x0000000189843210
		private static void LogErrorInternal(object message, UnityEngine.Object context) {} // 0x00000001868B5D90-0x00000001868B5E70
		// [Conditional] // 0x000000018984D540-0x000000018984D5A0
		// [IDTag] // 0x000000018984D540-0x000000018984D5A0
		// [XID] // 0x000000018984D540-0x000000018984D5A0
		public static void LogErrorFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B5C00-0x00000001868B5D90
		// [IDTag] // 0x0000000189861950-0x0000000189861990
		// [XID] // 0x0000000189861950-0x0000000189861990
		private static void LogErrorFormatInternal(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B57F0-0x00000001868B58D0
		// [Conditional] // 0x00000001898735A0-0x00000001898735F0
		// [XID] // 0x00000001898735A0-0x00000001898735F0
		public static void Error(string msg = null) {} // 0x00000001868B4A10-0x00000001868B4B90
		// [XID] // 0x00000001895F0580-0x00000001895F05A0
		private static void ErrorInternal(string msg) {} // 0x00000001868B4950-0x00000001868B4A10
		// [Conditional] // 0x0000000189885250-0x00000001898852B0
		// [IDTag] // 0x0000000189885250-0x00000001898852B0
		// [XID] // 0x0000000189885250-0x00000001898852B0
		public static void LogError(int type, string log) {} // 0x00000001868B6220-0x00000001868B63B0
		// [IDTag] // 0x0000000189892340-0x0000000189892380
		// [XID] // 0x0000000189892340-0x0000000189892380
		private static void LogErrorInternal(int type, string log) {} // 0x00000001868B60C0-0x00000001868B6220
		// [Conditional] // 0x000000018989CA50-0x000000018989CAC0
		// [IDTag] // 0x000000018989CA50-0x000000018989CAC0
		// [XID] // 0x000000018989CA50-0x000000018989CAC0
		public static void LogError(int type, object message, UnityEngine.Object context) {} // 0x00000001868B63B0-0x00000001868B6560
		// [IDTag] // 0x00000001898A9EA0-0x00000001898A9EE0
		// [XID] // 0x00000001898A9EA0-0x00000001898A9EE0
		private static void LogErrorInternal(int type, object message, UnityEngine.Object context) {} // 0x00000001868B5E70-0x00000001868B5FF0
		// [Conditional] // 0x00000001898B4470-0x00000001898B44E0
		// [IDTag] // 0x00000001898B4470-0x00000001898B44E0
		// [XID] // 0x00000001898B4470-0x00000001898B44E0
		public static void LogErrorFormat(int type, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B5A50-0x00000001868B5C00
		// [IDTag] // 0x00000001898C9830-0x00000001898C9870
		// [XID] // 0x00000001898C9830-0x00000001898C9870
		private static void LogErrorFormatInternal(int type, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B58D0-0x00000001868B5A50
		// [Conditional] // 0x00000001898DB5C0-0x00000001898DB610
		// [XID] // 0x00000001898DB5C0-0x00000001898DB610
		public static void LogErrorConcat(int type, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B5660-0x00000001868B57F0
		// [XID] // 0x00000001898EDD90-0x00000001898EDDB0
		private static void LogErrorConcatInternal(int type, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B5440-0x00000001868B5660
		// [XID] // 0x00000001898FCDE0-0x00000001898FCE00
		private static void SuperDebugLogInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BCB10-0x00000001868BCE70
		// [Conditional] // 0x0000000189904780-0x00000001899047E0
		// [IDTag] // 0x0000000189904780-0x00000001899047E0
		// [XID] // 0x0000000189904780-0x00000001899047E0
		public static void Log(string log) {} // 0x00000001868B9E80-0x00000001868BA000
		// [IDTag] // 0x0000000189911F50-0x0000000189911F90
		// [XID] // 0x0000000189911F50-0x0000000189911F90
		private static void LogInternal(string log) {} // 0x00000001868B77A0-0x00000001868B7870
		// [Conditional] // 0x000000018991CB30-0x000000018991CBA0
		// [IDTag] // 0x000000018991CB30-0x000000018991CBA0
		// [XID] // 0x000000018991CB30-0x000000018991CBA0
		public static void Log(object message) {} // 0x00000001868BA190-0x00000001868BA310
		// [IDTag] // 0x000000018992A0A0-0x000000018992A0E0
		// [XID] // 0x000000018992A0A0-0x000000018992A0E0
		private static void LogInternal(object message) {} // 0x00000001868B7870-0x00000001868B7940
		// [Conditional] // 0x00000001899344E0-0x0000000189934540
		// [IDTag] // 0x00000001899344E0-0x0000000189934540
		// [XID] // 0x00000001899344E0-0x0000000189934540
		public static void LogFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B7100-0x00000001868B7290
		// [IDTag] // 0x0000000189949570-0x00000001899495B0
		// [XID] // 0x0000000189949570-0x00000001899495B0
		private static void LogFormatInternal(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B6C90-0x00000001868B6D70
		// [Conditional] // 0x000000018995B1B0-0x000000018995B210
		// [IDTag] // 0x000000018995B1B0-0x000000018995B210
		// [XID] // 0x000000018995B1B0-0x000000018995B210
		public static void LogFormat(UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B7290-0x00000001868B7440
		// [IDTag] // 0x0000000189970080-0x00000001899700C0
		// [XID] // 0x0000000189970080-0x00000001899700C0
		private static void LogFormatInternal(UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B6B90-0x00000001868B6C90
		// [Conditional] // 0x00000001899826B0-0x0000000189982720
		// [IDTag] // 0x00000001899826B0-0x0000000189982720
		// [XID] // 0x00000001899826B0-0x0000000189982720
		public static void Log(int category, string log) {} // 0x00000001868BA000-0x00000001868BA190
		// [IDTag] // 0x000000018998FD60-0x000000018998FDA0
		// [XID] // 0x000000018998FD60-0x000000018998FDA0
		private static void LogInternal(int category, string log) {} // 0x00000001868B7640-0x00000001868B77A0
		// [XID] // 0x000000018999AC30-0x000000018999AC50
		private static void LogHumanoidMoveInternal(int category, string log) {} // 0x00000001868B7440-0x00000001868B74E0
		// [Conditional] // 0x00000001899A23F0-0x00000001899A2460
		// [IDTag] // 0x00000001899A23F0-0x00000001899A2460
		// [XID] // 0x00000001899A23F0-0x00000001899A2460
		public static void Log(int category, object message) {} // 0x00000001868BA310-0x00000001868BA4A0
		// [IDTag] // 0x00000001899AFCF0-0x00000001899AFD30
		// [XID] // 0x00000001899AFCF0-0x00000001899AFD30
		private static void LogInternal(int category, object message) {} // 0x00000001868B74E0-0x00000001868B7640
		// [Conditional] // 0x00000001899BA210-0x00000001899BA280
		// [IDTag] // 0x00000001899BA210-0x00000001899BA280
		// [XID] // 0x00000001899BA210-0x00000001899BA280
		public static void LogFormat(int category, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B6D70-0x00000001868B6F20
		// [IDTag] // 0x00000001899CF4B0-0x00000001899CF4F0
		// [XID] // 0x00000001899CF4B0-0x00000001899CF4F0
		private static void LogFormatInternal(int category, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B6870-0x00000001868B69F0
		// [Conditional] // 0x00000001899E0F30-0x00000001899E0FA0
		// [IDTag] // 0x00000001899E0F30-0x00000001899E0FA0
		// [XID] // 0x00000001899E0F30-0x00000001899E0FA0
		public static void LogFormat(int category, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B6F20-0x00000001868B7100
		// [IDTag] // 0x00000001899F5EE0-0x00000001899F5F20
		// [XID] // 0x00000001899F5EE0-0x00000001899F5F20
		private static void LogFormatInternal(int category, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B69F0-0x00000001868B6B90
		// [Conditional] // 0x0000000189A07B60-0x0000000189A07BB0
		// [XID] // 0x0000000189A07B60-0x0000000189A07BB0
		public static void LogConcat(int category, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B52B0-0x00000001868B5440
		// [XID] // 0x0000000189A19830-0x0000000189A19850
		private static void LogConcatInternal(int category, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B5090-0x00000001868B52B0
		// [XID] // 0x0000000189A28180-0x0000000189A281A0
		public static void PrintMoveLog() {} // 0x00000001868BA4A0-0x00000001868BA530
		// [XID] // 0x0000000189A2B200-0x0000000189A2B220
		private static void RequestEnqueue(ref SuperDebugRequest request) {} // 0x00000001868BA530-0x00000001868BA720
		// [XID] // 0x0000000189B6B3C0-0x0000000189B6B3E0
		public static void FlushSuperDebugRequests() {} // 0x00000001868B4B90-0x00000001868B4FC0
		// [IDTag] // 0x0000000189A46140-0x0000000189A46180
		// [XID] // 0x0000000189A46140-0x0000000189A46180
		private static void RequestLog(LogRequestType logType, int subType, string log) {} // 0x00000001868BAA30-0x00000001868BABA0
		// [IDTag] // 0x0000000189A50980-0x0000000189A509C0
		// [XID] // 0x0000000189A50980-0x0000000189A509C0
		private static void RequestLog(LogRequestType logType, int subType, object message) {} // 0x00000001868BB890-0x00000001868BBA00
		// [IDTag] // 0x0000000189A5AEC0-0x0000000189A5AF00
		// [XID] // 0x0000000189A5AEC0-0x0000000189A5AF00
		private static void RequestLog(LogRequestType logType, int subType, object message, UnityEngine.Object context) {} // 0x00000001868BABA0-0x00000001868BAD20
		// [IDTag] // 0x0000000189A65AC0-0x0000000189A65B00
		// [XID] // 0x0000000189A65AC0-0x0000000189A65B00
		private static void RequestLog(LogRequestType logType, int subType, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BA720-0x00000001868BA8A0
		// [IDTag] // 0x0000000189A77A60-0x0000000189A77AA0
		// [XID] // 0x0000000189A77A60-0x0000000189A77AA0
		private static void RequestLog(LogRequestType logType, int subType, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BA8A0-0x00000001868BAA30
		// [IDTag] // 0x0000000189A89DA0-0x0000000189A89DE0
		// [XID] // 0x0000000189A89DA0-0x0000000189A89DE0
		private static void RequestLog(LogRequestType logType, int subType, int category, string log) {} // 0x00000001868BBC00-0x00000001868BBD80
		// [IDTag] // 0x0000000189A94250-0x0000000189A94290
		// [XID] // 0x0000000189A94250-0x0000000189A94290
		private static void RequestLog(LogRequestType logType, int subType, int category, object message) {} // 0x00000001868BB3E0-0x00000001868BB560
		// [IDTag] // 0x0000000189A9E990-0x0000000189A9E9D0
		// [XID] // 0x0000000189A9E990-0x0000000189A9E9D0
		private static void RequestLog(LogRequestType logType, int subType, int category, object message, UnityEngine.Object context) {} // 0x00000001868BBF00-0x00000001868BC090
		// [IDTag] // 0x0000000189AA8EB0-0x0000000189AA8EF0
		// [XID] // 0x0000000189AA8EB0-0x0000000189AA8EF0
		private static void RequestLog(LogRequestType logType, int subType, int category, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BAF10-0x00000001868BB0A0
		// [IDTag] // 0x0000000189ABB770-0x0000000189ABB7B0
		// [XID] // 0x0000000189ABB770-0x0000000189ABB7B0
		private static void RequestLog(LogRequestType logType, int subType, int category, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BB240-0x00000001868BB3E0
		// [IDTag] // 0x0000000189ACD760-0x0000000189ACD7A0
		// [XID] // 0x0000000189ACD760-0x0000000189ACD7A0
		private static void RequestLog(LogRequestType logType, int subType, string msg, UnityEngine.Object context) {} // 0x00000001868BBD80-0x00000001868BBF00
		// [IDTag] // 0x0000000189AD8210-0x0000000189AD8250
		// [XID] // 0x0000000189AD8210-0x0000000189AD8250
		private static void RequestLog(LogRequestType logType, int subType, LogType llogType, string title, bool stack, bool deduplicate, int errorCode = 0 /* Metadata: 0x00AE7E31 */, int subErrorCode = 0 /* Metadata: 0x00AE7E35 */, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AE7E39 */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AE7E3D */, string notifyUserName = "" /* Metadata: 0x00AE7E41 */) {} // 0x00000001868BBA00-0x00000001868BBC00
		// [IDTag] // 0x0000000189AE29A0-0x0000000189AE29E0
		// [XID] // 0x0000000189AE29A0-0x0000000189AE29E0
		private static void RequestLog(LogRequestType logType, int subType, int category, int subErrorCode, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BB700-0x00000001868BB890
		// [IDTag] // 0x0000000189AF4E60-0x0000000189AF4EA0
		// [XID] // 0x0000000189AF4E60-0x0000000189AF4EA0
		private static void RequestLog(LogRequestType logType, int subType, LogType llogType, bool stack, int errorCode = 0 /* Metadata: 0x00AE7E45 */, int subErrorCode = 0 /* Metadata: 0x00AE7E49 */, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AE7E4D */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AE7E51 */, string notifyUserName = "" /* Metadata: 0x00AE7E55 */, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BAD20-0x00000001868BAF10
		// [IDTag] // 0x0000000189B06C30-0x0000000189B06C70
		// [XID] // 0x0000000189B06C30-0x0000000189B06C70
		private static void RequestLog(LogRequestType logType, int subType, string title, string[] usernames, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BB560-0x00000001868BB700
		// [IDTag] // 0x0000000189B188D0-0x0000000189B18910
		// [XID] // 0x0000000189B188D0-0x0000000189B18910
		private static void RequestLog(LogRequestType logType, int subType, string title, string username, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BB0A0-0x00000001868BB240
		// [IDTag] // 0x0000000189B2A500-0x0000000189B2A540
		// [XID] // 0x0000000189B2A500-0x0000000189B2A540
		private static void LogToServer(LogType logType, string title, bool deduplicate, int errorCode, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AE7E59 */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AE7E5D */, string notifyUserName = "" /* Metadata: 0x00AE7E61 */, bool reportStack = true /* Metadata: 0x00AE7E65 */, int subErrorCode = 0 /* Metadata: 0x00AE7E66 */) {} // 0x00000001868B8180-0x00000001868B83C0
		// [IDTag] // 0x0000000189B34710-0x0000000189B34750
		// [XID] // 0x0000000189B34710-0x0000000189B34750
		private static void LogToServer(LogType logType, int errorCode, bool reportStack, int subErrorCode, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AE7E6A */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AE7E6E */, string notifyUserName = "" /* Metadata: 0x00AE7E72 */, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B7F60-0x00000001868B8180
		// [XID] // 0x0000000189B46BA0-0x0000000189B46BC0
		private static void SuperDebugVeryImportantInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BCE70-0x00000001868BD050
		// [IDTag] // 0x0000000189B4E3F0-0x0000000189B4E430
		// [XID] // 0x0000000189B4E3F0-0x0000000189B4E430
		private static void LogToServerInternal(bool stack, string title, LogType logType, bool deduplicate, int errorCode, int subErrorCode, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AE7E76 */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AE7E7A */, string notifyUserName = "" /* Metadata: 0x00AE7E7E */) {} // 0x00000001868B7CA0-0x00000001868B7F60
		// [IDTag] // 0x0000000189B58DE0-0x0000000189B58E20
		// [XID] // 0x0000000189B58DE0-0x0000000189B58E20
		private static void LogToServerInternal(bool stack, LogType logType, int errorCode, int subErrorCode, ErrorLevel errorLevel, ErrorCategory errorCategory, string notifyUserName, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B7940-0x00000001868B7CA0
		// [IDTag] // 0x0000000189B6AB10-0x0000000189B6AB50
		// [XID] // 0x0000000189B6AB10-0x0000000189B6AB50
		public static void VeryImportantLog(string msg = null, bool deduplicate = true /* Metadata: 0x00AE7E82 */, bool reportStack = true /* Metadata: 0x00AE7E83 */) {} // 0x00000001868BDB50-0x00000001868BDCB0
		// [IDTag] // 0x0000000189B74EB0-0x0000000189B74EF0
		// [XID] // 0x0000000189B74EB0-0x0000000189B74EF0
		public static void VeryImportantLog(bool reportStack, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BDA10-0x00000001868BDB50
		// [IDTag] // 0x0000000189B87010-0x0000000189B87050
		// [XID] // 0x0000000189B87010-0x0000000189B87050
		public static void VeryImportantAssert(bool cond, string msg = null, bool deduplicate = true /* Metadata: 0x00AE7E84 */) {} // 0x00000001868BD390-0x00000001868BD4C0
		// [IDTag] // 0x0000000189B91440-0x0000000189B91480
		// [XID] // 0x0000000189B91440-0x0000000189B91480
		public static void VeryImportantAssert(bool cond, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BD4C0-0x00000001868BD600
		// [IDTag] // 0x0000000189BA2DD0-0x0000000189BA2E10
		// [XID] // 0x0000000189BA2DD0-0x0000000189BA2E10
		public static void VeryImportantError(string msg, ErrorLevel errorLevel, ErrorCategory errorCategory, string notifyUserName = "" /* Metadata: 0x00AE7E85 */, bool deduplicate = true /* Metadata: 0x00AE7E89 */, int errorCode = 0 /* Metadata: 0x00AE7E8A */, int subErrorCode = 0 /* Metadata: 0x00AE7E8E */) {} // 0x00000001868BD710-0x00000001868BD8B0
		// [IDTag] // 0x0000000189BACF80-0x0000000189BACFC0
		// [XID] // 0x0000000189BACF80-0x0000000189BACFC0
		public static void VeryImportantError(ErrorLevel errorLevel, ErrorCategory errorCategory, int errorCode = 0 /* Metadata: 0x00AE7E92 */, int subErrorCode = 0 /* Metadata: 0x00AE7E96 */, string notifyUserName = "" /* Metadata: 0x00AE7E9A */, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BD8B0-0x00000001868BDA10
		// [IDTag] // 0x0000000189BBEA10-0x0000000189BBEA50
		// [XID] // 0x0000000189BBEA10-0x0000000189BBEA50
		public static void VeryImportantError(int errorCode = 0 /* Metadata: 0x00AE7E9E */, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868BD600-0x00000001868BD710
		// [XID] // 0x0000000189BD1110-0x0000000189BD1130
		private static void SuperDebugWarningInternal(int subType, ref SuperDebugRequest request) {} // 0x00000001868BD050-0x00000001868BD390
		// [Conditional] // 0x0000000189BD8790-0x0000000189BD87F0
		// [IDTag] // 0x0000000189BD8790-0x0000000189BD87F0
		// [XID] // 0x0000000189BD8790-0x0000000189BD87F0
		public static void LogWarning(string log) {} // 0x00000001868B9AF0-0x00000001868B9CD0
		// [IDTag] // 0x00000001895EB590-0x00000001895EB5D0
		// [XID] // 0x00000001895EB590-0x00000001895EB5D0
		private static void LogWarningInternal(string log) {} // 0x00000001868B95A0-0x00000001868B9670
		// [Conditional] // 0x00000001895F5D10-0x00000001895F5D80
		// [IDTag] // 0x00000001895F5D10-0x00000001895F5D80
		// [XID] // 0x00000001895F5D10-0x00000001895F5D80
		public static void LogWarning(object message, UnityEngine.Object context) {} // 0x00000001868B97D0-0x00000001868B9960
		// [IDTag] // 0x0000000189603440-0x0000000189603480
		// [XID] // 0x0000000189603440-0x0000000189603480
		private static void LogWarningInternal(object message, UnityEngine.Object context) {} // 0x00000001868B9340-0x00000001868B9420
		// [Conditional] // 0x000000018960DC70-0x000000018960DCD0
		// [IDTag] // 0x000000018960DC70-0x000000018960DCD0
		// [XID] // 0x000000018960DC70-0x000000018960DCD0
		public static void LogWarningFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8FD0-0x00000001868B9160
		// [IDTag] // 0x00000001896228C0-0x0000000189622900
		// [XID] // 0x00000001896228C0-0x0000000189622900
		private static void LogWarningFormatInternal(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8910-0x00000001868B89F0
		// [Conditional] // 0x0000000189634BC0-0x0000000189634C20
		// [IDTag] // 0x0000000189634BC0-0x0000000189634C20
		// [XID] // 0x0000000189634BC0-0x0000000189634C20
		public static void LogWarningFormat(UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8E20-0x00000001868B8FD0
		// [IDTag] // 0x0000000189649A40-0x0000000189649A80
		// [XID] // 0x0000000189649A40-0x0000000189649A80
		private static void LogWarningFormatInternal(UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B89F0-0x00000001868B8AF0
		// [Conditional] // 0x000000018965BA70-0x000000018965BAD0
		// [IDTag] // 0x000000018965BA70-0x000000018965BAD0
		// [XID] // 0x000000018965BA70-0x000000018965BAD0
		public static void LogWarning(int category, string log) {} // 0x00000001868B9960-0x00000001868B9AF0
		// [IDTag] // 0x0000000189669230-0x0000000189669270
		// [XID] // 0x0000000189669230-0x0000000189669270
		private static void LogWarningInternal(int category, string log) {} // 0x00000001868B9670-0x00000001868B97D0
		// [Conditional] // 0x0000000189673B80-0x0000000189673BE0
		// [IDTag] // 0x0000000189673B80-0x0000000189673BE0
		// [XID] // 0x0000000189673B80-0x0000000189673BE0
		public static void LogWarning(int category, object message, UnityEngine.Object context) {} // 0x00000001868B9CD0-0x00000001868B9E80
		// [IDTag] // 0x0000000189681560-0x00000001896815A0
		// [XID] // 0x0000000189681560-0x00000001896815A0
		private static void LogWarningInternal(int category, object message, UnityEngine.Object context) {} // 0x00000001868B9420-0x00000001868B95A0
		// [Conditional] // 0x000000018968BF90-0x000000018968C000
		// [IDTag] // 0x000000018968BF90-0x000000018968C000
		// [XID] // 0x000000018968BF90-0x000000018968C000
		public static void LogWarningFormat(int category, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8C70-0x00000001868B8E20
		// [IDTag] // 0x00000001896A0D80-0x00000001896A0DC0
		// [XID] // 0x00000001896A0D80-0x00000001896A0DC0
		private static void LogWarningFormatInternal(int category, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8AF0-0x00000001868B8C70
		// [Conditional] // 0x00000001896B21F0-0x00000001896B2260
		// [IDTag] // 0x00000001896B21F0-0x00000001896B2260
		// [XID] // 0x00000001896B21F0-0x00000001896B2260
		public static void LogWarningFormat(int category, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B9160-0x00000001868B9340
		// [IDTag] // 0x00000001896C7110-0x00000001896C7150
		// [XID] // 0x00000001896C7110-0x00000001896C7150
		private static void LogWarningFormatInternal(int category, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B8770-0x00000001868B8910
		// [Conditional] // 0x00000001896D8B20-0x00000001896D8B70
		// [XID] // 0x00000001896D8B20-0x00000001896D8B70
		public static void LogWarningConcat(int category, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B85E0-0x00000001868B8770
		// [XID] // 0x0000000189AEC560-0x0000000189AEC580
		private static void LogWarningConcatInternal(int category, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001868B83C0-0x00000001868B85E0
	}
}
