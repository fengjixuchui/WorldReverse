/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class TimeUtil // TypeDefIndex: 31990
{
	// Fields
	private static bool debugTime; // 0x00
	private static DateTime _testNow; // 0x08
	public static DateTime StartConstTime; // 0x18
	private static ulong _sceneBeginTimeStamp; // 0x28
	private static bool _isLevelTimePaused; // 0x30
	private static bool _isPlayerTimePaused; // 0x31
	private static ulong _threadMsTimeStamp; // 0x38
	private static TimeSpan _serverTimeSpan; // 0x40
	private static TimeSpan _levelTimeSpan; // 0x48
	private static TimeSpan _levelPausedTimeSpan; // 0x50
	private static TimeSpan _playerTimeSpan; // 0x58
	private static TimeSpan _playerPausedTimeSpan; // 0x60
	private static int _LastCalcTimeStampFrame; // 0x68
	private static ulong _CurrentNowSceneTimeStamp; // 0x70
	private static ulong _PredictNextSceneTimeStamp; // 0x78

	// Properties
	public static DateTime Now { /* [XID] */ /* 0x00000001898C0B70-0x00000001898C0B90 */ get; } // 0x0000000184745A90-0x0000000184745C40 
	public static ulong NowTimeStamp { /* [XID] */ /* 0x0000000189A44B00-0x0000000189A44B20 */ get; } // 0x0000000184745C40-0x0000000184745EE0 
	public static ulong LocalNowMsTimeStamp { /* [XID] */ /* 0x00000001898CFE60-0x00000001898CFE80 */ get; } // 0x0000000184747DF0-0x0000000184747F70 
	public static ulong LocalNowTimeStamp { /* [XID] */ /* 0x00000001898D7410-0x00000001898D7430 */ get; } // 0x00000001847461C0-0x0000000184746340 
	public static ulong ServerNowMsTimeStamp { /* [XID] */ /* 0x00000001898DF140-0x00000001898DF160 */ get; } // 0x0000000184746E90-0x0000000184747040 
	public static DateTime ServerNowTime { /* [XID] */ /* 0x00000001898E6BA0-0x00000001898E6BC0 */ get; } // 0x0000000184745EE0-0x0000000184746030 
	public static ulong ThreadMsTimeStamp { /* [XID] */ /* 0x00000001898EE210-0x00000001898EE230 */ get; } // 0x0000000184746DC0-0x0000000184746E90 
	public static ulong PlayerChangeTime { /* [XID] */ /* 0x00000001898F5A50-0x00000001898F5A70 */ get; } // 0x00000001847484A0-0x0000000184748570 
	public static ulong LevelLogicTimeStamp { /* [XID] */ /* 0x00000001898FD240-0x00000001898FD260 */ get; } // 0x00000001847455A0-0x00000001847457F0 
	public static ulong PlayerLogicTimeStamp { /* [XID] */ /* 0x0000000189904B20-0x0000000189904B40 */ get; } // 0x0000000184747460-0x00000001847476B0 
	public static ulong NowSceneTimeStamp { /* [XID] */ /* 0x000000018990C380-0x000000018990C3A0 */ get; } // 0x00000001847476B0-0x0000000184747950 
	public static ulong PredictNextSceneTimeStamp { /* [XID] */ /* 0x0000000189913B70-0x0000000189913B90 */ get; } // 0x00000001847471C0-0x0000000184747460 

	// Constructors
	static TimeUtil() {} // 0x0000000184748570-0x00000001847487B0

	// Methods
	// [XID] // 0x000000018991B5B0-0x000000018991B5D0
	private static int GetTargetSingleFrameTime() => default; // 0x0000000184746100-0x00000001847461C0
	// [XID] // 0x0000000189922B30-0x0000000189922B50
	public static void InitBeforeThread() {} // 0x0000000184748320-0x00000001847483F0
	// [XID] // 0x000000018992A490-0x000000018992A4B0
	public static void SetServerCurTime(ulong serverStamp, uint rtt) {} // 0x0000000184747040-0x00000001847471C0
	// [XID] // 0x00000001899319C0-0x00000001899319E0
	public static void SetLevelLogicTime(ulong levelLogicStamp, ulong revcTime, uint rtt, bool isPaused) {} // 0x00000001847457F0-0x0000000184745A90
	// [XID] // 0x00000001899394A0-0x00000001899394C0
	public static void SetPlayerLogicTime(ulong playerLogicStamp, ulong revcTime, uint rtt, bool isPaused) {} // 0x0000000184748080-0x0000000184748320
	// [XID] // 0x0000000189940770-0x0000000189940790
	public static void ClearServerTimeSpan() {} // 0x00000001847464E0-0x0000000184746720
	// [XID] // 0x0000000189948010-0x0000000189948030
	public static void SetSceneCurTime(ulong timestamp) {} // 0x0000000184746030-0x0000000184746100
	// [XID] // 0x000000018994F7F0-0x000000018994F810
	public static uint floatToUintTime(float time) => default; // 0x00000001847483F0-0x00000001847484A0
	// [XID] // 0x0000000189956D30-0x0000000189956D50
	public static float GetSystemTime() => default; // 0x0000000184746340-0x00000001847464E0
	// [XID] // 0x000000018995E880-0x000000018995E8A0
	public static void SplitTime(uint sec, out uint h, out uint m, out uint s) {
		h = default;
		m = default;
		s = default;
	} // 0x0000000184747F70-0x0000000184748080
	// [XID] // 0x0000000189965FC0-0x0000000189965FE0
	public static void CalEndTimeSeconds(uint targetTimeStamp, out int totalSeconds) {
		totalSeconds = default;
	} // 0x0000000184746720-0x00000001847467F0
	// [XID] // 0x000000018996D440-0x000000018996D460
	public static string ActivityLeftTimeToString(uint expireTime, bool showActivityExpireText = true /* Metadata: 0x00B13AA9 */) => default; // 0x00000001847468C0-0x0000000184746BF0
	// [XID] // 0x0000000189975060-0x0000000189975080
	public static bool IsActivityExpired(uint expireTime) => default; // 0x00000001847467F0-0x00000001847468C0
	// [XID] // 0x000000018997C220-0x000000018997C240
	public static string ActivityUnLockTimeToString(uint unlockTime, string unlockFormat) => default; // 0x0000000184747950-0x0000000184747C20
	// [XID] // 0x0000000189983EF0-0x0000000189983F10
	public static string FormatTicksToMDY(long ticks) => default; // 0x0000000184747C20-0x0000000184747DF0
	// [XID] // 0x000000018998BA80-0x000000018998BAA0
	public static string FormatTicksToISOYMD(long ticks) => default; // 0x0000000184746BF0-0x0000000184746DC0
}

