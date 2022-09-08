/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole.AsyncNetwork;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GameDebugMonitor // TypeDefIndex: 27720
{
	// Fields
	private const int ProfilerRecordSizeDefault = 3; // Metadata: 0x00B0CCF0
	private const int ProfilerRecordDelayDefault = 10; // Metadata: 0x00B0CCF4
	private static IConnection _recordConnection; // 0x00
	private static int _recordFPS; // 0x08
	private static int _recordSkipFrameCount; // 0x0C
	private static int _recordSkipFrameCounter; // 0x10
	private static int _recordDelay; // 0x14

	// Properties
	public static int profilerRecordSize { get; /* [XID] */ /* 0x000000018975F5F0-0x000000018975F630 */ private set; } // 0x0000000181C71550-0x0000000181C715E0 0x0000000181C715E0-0x0000000181C71670

	// Constructors
	public GameDebugMonitor() {} // 0x0000000181C71720-0x0000000181C71780
	static GameDebugMonitor() {} // 0x0000000181C71670-0x0000000181C71720

	// Methods
	// [XID] // 0x0000000189769AC0-0x0000000189769AE0
	public static void GetGameInfo() {} // 0x0000000181C6FCF0-0x0000000181C6FF20
	// [XID] // 0x00000001897710F0-0x0000000189771110
	public static string GetGameInfoString() => default; // 0x0000000181C70F50-0x0000000181C71140
	// [XID] // 0x0000000189778950-0x0000000189778970
	public static void AddGameInfo(StringBuilder buffer) {} // 0x0000000181C6FF20-0x0000000181C701E0
	// [XID] // 0x000000018977FEA0-0x000000018977FEC0
	public static void GetLuaDetail() {} // 0x0000000181C70AC0-0x0000000181C70CF0
	// [XID] // 0x0000000189787740-0x0000000189787760
	public static void StartProfilerRecord(int recordSize) {} // 0x0000000181C71200-0x0000000181C712F0
	// [XID] // 0x000000018978EDF0-0x000000018978EE10
	public static void StopProfilerRecord() {} // 0x0000000181C701E0-0x0000000181C702B0
	// [XID] // 0x00000001897965D0-0x00000001897965F0
	public static void GetProfilerRecord() {} // 0x0000000181C71140-0x0000000181C71200
	// [XID] // 0x000000018979E670-0x000000018979E690
	public static void StartProfilerRecordAutoSave(int fps, int frameCount = 30 /* Metadata: 0x00B0CCEC */) {} // 0x0000000181C70CF0-0x0000000181C70E50
	// [XID] // 0x00000001897A5E20-0x00000001897A5E40
	public static void StopProfilerRecordAutoSave() {} // 0x0000000181C70E50-0x0000000181C70F50
	// [XID] // 0x00000001897AD3A0-0x00000001897AD3C0
	public static void Tick() {} // 0x0000000181C70560-0x0000000181C707D0
	// [XID] // 0x00000001897B5430-0x00000001897B5450
	public static void ExecuteCommand(string command) {} // 0x0000000181C702B0-0x0000000181C703B0
	// [XID] // 0x00000001897BD0C0-0x00000001897BD0E0
	private static void SendProfilerRecord(IConnection connection) {} // 0x0000000181C707D0-0x0000000181C70AC0
	// [XID] // 0x00000001897C4440-0x00000001897C4460
	private static void ResetRecordState() {} // 0x0000000181C6FC10-0x0000000181C6FCF0
	// [XID] // 0x00000001897CBBE0-0x00000001897CBC00
	private static void AddProfilerRecord(StringBuilder buffer) {} // 0x0000000181C712F0-0x0000000181C71550
	// [XID] // 0x00000001897D3510-0x00000001897D3530
	private static void SaveProfilerRecord() {} // 0x0000000181C703B0-0x0000000181C70560
}

