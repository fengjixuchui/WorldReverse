/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public sealed class BuglyAgent // TypeDefIndex: 6745
{
	// Fields
	private static bool _isInitialized; // 0x08
	private static LogSeverity _autoReportLogLevel; // 0x0C
	private static int _crashReporterType; // 0x10
	private static bool _debugMode; // 0x14
	private static bool _autoQuitApplicationAfterReport; // 0x15
	private static readonly int EXCEPTION_TYPE_UNCAUGHT; // 0x18
	private static readonly int EXCEPTION_TYPE_CAUGHT; // 0x1C
	private static readonly string _pluginVersion; // 0x20
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler; // 0x28
	private static bool _uncaughtAutoReportOnce; // 0x30

	// Properties
	public static string PluginVersion { get => default; } // 0x00000001864D26C0-0x00000001864D2750 
	public static bool IsInitialized { get => default; } // 0x00000001864D2630-0x00000001864D26C0 
	public static bool AutoQuitApplicationAfterReport { get => default; } // 0x00000001864D25A0-0x00000001864D2630 

	// Events
	private static event LogCallbackDelegate _LogCallbackEventHandler;

	// Nested types
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type); // TypeDefIndex: 6746; 0x00000001864DE5C0-0x00000001864DE8B0

	// Constructors
	public BuglyAgent() {} // 0x00000001864D1CB0-0x00000001864D1D10
	static BuglyAgent() {} // 0x00000001864D1BB0-0x00000001864D1CB0

	// Methods
	public static void ConfigCrashReporter(int type, int logLevel) {} // 0x00000001864CEAF0-0x00000001864CEBB0
	public static void InitWithAppId(string appId) {} // 0x00000001864CF300-0x00000001864CF500
	public static void EnableExceptionHandler() {} // 0x00000001864CF180-0x00000001864CF2B0
	public static void RegisterLogCallback(LogCallbackDelegate handler) {} // 0x00000001864CF670-0x00000001864CF790
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler) {} // 0x00000001864CFBF0-0x00000001864CFD20
	public static void ReportException(Exception e, string message) {} // 0x00000001864CF9F0-0x00000001864CFBA0
	public static void ReportException(string name, string message, string stackTrace) {} // 0x00000001864CF790-0x00000001864CF9A0
	public static void UnregisterLogCallback(LogCallbackDelegate handler) {} // 0x00000001864D00D0-0x00000001864D01A0
	public static void SetUserId(string userId) {} // 0x00000001864CFF00-0x00000001864D0080
	public static void SetScene(int sceneId) {} // 0x00000001864CFD20-0x00000001864CFEB0
	public static void AddSceneData(string key, string value) {} // 0x00000001864CE800-0x00000001864CE9D0
	public static void ConfigDebugMode(bool enable) {} // 0x00000001864CEBB0-0x00000001864CED40
	public static void ConfigAutoQuitApplication(bool autoQuit) {} // 0x00000001864CE9D0-0x00000001864CEA60
	public static void ConfigAutoReportLogLevel(LogSeverity level) {} // 0x00000001864CEA60-0x00000001864CEAF0
	public static void ConfigDefault(string channel, string version, string user, long delay) {} // 0x00000001864CED90-0x00000001864CEFE0
	public static void DebugLog(string tag, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001864CEFE0-0x00000001864CF130
	public static void PrintLog(LogSeverity level, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001864CF550-0x00000001864CF670
	private static void InitBuglyAgent(string appId) {} // 0x00000001864CF2B0-0x00000001864CF300
	private static void ConfigDefaultBeforeInit(string channel, string version, string user, long delay) {} // 0x00000001864CED40-0x00000001864CED90
	private static void EnableDebugMode(bool enable) {} // 0x00000001864CF130-0x00000001864CF180
	private static void SetUserInfo(string userInfo) {} // 0x00000001864D0080-0x00000001864D00D0
	private static void ReportException(int type, string name, string message, string stackTrace, bool quitProgram) {} // 0x00000001864CF9A0-0x00000001864CF9F0
	private static void SetCurrentScene(int sceneId) {} // 0x00000001864CFBA0-0x00000001864CFBF0
	private static void AddKeyAndValueInScene(string key, string value) {} // 0x00000001864CE7B0-0x00000001864CE800
	private static void AddExtraDataWithException(string key, string value) {} // 0x00000001864CE760-0x00000001864CE7B0
	private static void LogRecord(LogSeverity level, string message) {} // 0x00000001864CF500-0x00000001864CF550
	private static void SetUnityVersion() {} // 0x00000001864CFEB0-0x00000001864CFF00
	private static void _SetCrashReporterType(int type) {} // 0x00000001864D1890-0x00000001864D1920
	private static void _SetCrashReporterLogLevel(int logLevel) {} // 0x00000001864D1840-0x00000001864D1890
	private static void _RegisterExceptionHandler() {} // 0x00000001864D1550-0x00000001864D1840
	private static void _UnregisterExceptionHandler() {} // 0x00000001864D1920-0x00000001864D1BB0
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type) {} // 0x00000001864D1150-0x00000001864D1370
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args) {} // 0x00000001864D1370-0x00000001864D1550
	private static void _HandleException(Exception e, string message, bool uncaught) {} // 0x00000001864D01A0-0x00000001864D07F0
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace) {} // 0x00000001864D1D10-0x00000001864D2480
	private static void _HandleException(LogSeverity logLevel, string name, string message, string stackTrace, bool uncaught) {} // 0x00000001864D07F0-0x00000001864D1150
}

