/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StopWatchUtil // TypeDefIndex: 31980
{
	// Fields
	public static Stopwatch quickStopWatch; // 0x00
	public static Dictionary<string, Stopwatch> stopwatchs; // 0x08

	// Constructors
	public StopWatchUtil() {} // 0x00000001842E8C10-0x00000001842E8C70

	// Methods
	// [IDTag] // 0x00000001897A9D40-0x00000001897A9D80
	// [XID] // 0x00000001897A9D40-0x00000001897A9D80
	public static void QuickStart(Action action, int count = 1 /* Metadata: 0x00B13A76 */, string introduction = null, bool printInfo = false /* Metadata: 0x00B13A7A */) {} // 0x00000001842E8080-0x00000001842E8190
	// [IDTag] // 0x00000001897B4FC0-0x00000001897B5000
	// [XID] // 0x00000001897B4FC0-0x00000001897B5000
	public static void QuickStart(bool printInfo = true /* Metadata: 0x00B13A7B */) {} // 0x00000001842E8190-0x00000001842E82D0
	// [XID] // 0x00000001897BFCE0-0x00000001897BFD00
	public static void QuickStopAndPrint(string introduction = null) {} // 0x00000001842E82D0-0x00000001842E8590
	// [XID] // 0x00000001897C7530-0x00000001897C7550
	public static void Start(string name, bool printInfo = true /* Metadata: 0x00B13A7C */) {} // 0x00000001842E7C10-0x00000001842E7FA0
	// [XID] // 0x00000001897CE880-0x00000001897CE8A0
	public static void StopAndPrint(string name, string introduction = null) {} // 0x00000001842E86B0-0x00000001842E8960
	// [XID] // 0x00000001897D6040-0x00000001897D6060
	private static void InternalLog(string message) {} // 0x00000001842E8A80-0x00000001842E8B40
	// [XID] // 0x00000001897DD920-0x00000001897DD940
	private static void InternalLogFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001842E7FA0-0x00000001842E8080
	// [XID] // 0x00000001897ECDA0-0x00000001897ECDC0
	public static void StartWithTag(string name) {} // 0x00000001842E8960-0x00000001842E8A80
	// [XID] // 0x00000001897F45F0-0x00000001897F4610
	public static void StopWithTag(string name) {} // 0x00000001842E8590-0x00000001842E86B0
	// [XID] // 0x00000001897FC020-0x00000001897FC040
	public static string GetTimeLogTag(string name) => default; // 0x00000001842E8B40-0x00000001842E8C10
}

