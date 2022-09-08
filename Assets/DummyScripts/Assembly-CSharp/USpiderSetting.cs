/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class USpiderSetting : BaseQAModule // TypeDefIndex: 28381
{
	// Fields
	public const string serverAddress = "http://hk4e-uspider.mihoyo.com:8888"; // Metadata: 0x00B0D63F
	public const string alarmReportUrl = "https://devlog-upload.mihoyo.com/client/event/dataUpload"; // Metadata: 0x00B0D666
	public const string overseaServerAddress = "http://overseauspider.yuanshen.com:8888"; // Metadata: 0x00B0D6A2
	public const string overseaAlarmReportUrl = "http://log-upload-os.mihoyo.com/crash/dataUpload"; // Metadata: 0x00B0D6CD
	public string filename; // 0x10
	public string crashlogPath; // 0x18
	public string resLogPath; // 0x20
	public string androidCrashPath; // 0x28
	public Settings sets; // 0x30
	private StreamReader reader; // 0x78

	// Nested types
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	public struct Settings // TypeDefIndex: 28382
	{
		// Fields
		public string serverAddress; // 0x00
		public string alarmReportUrl; // 0x08
		public string userName; // 0x10
		public string projectName; // 0x18
		public bool exception; // 0x20
		public bool error; // 0x21
		public bool assert; // 0x22
		public bool warning; // 0x23
		public bool log; // 0x24
		public bool crash; // 0x25
		public float fps; // 0x28
		public bool autoVideoRecording; // 0x2C
		public int autoVideoTime; // 0x30
		public float autoVideoRecordInterval; // 0x34
		public float lowFPSRecordInterval; // 0x38
		public bool screenShotManually; // 0x3C
		public bool lowFPSRecording; // 0x3D
		public bool description; // 0x3E
		public bool collectPCLog; // 0x3F
		public bool profiling; // 0x40
	}

	// Constructors
	public USpiderSetting() {} // 0x000000018458A150-0x000000018458A340

	// Methods
	// [XID] // 0x00000001895F1AF0-0x00000001895F1B10
	public void setProfilingModule(bool isOn) {} // 0x0000000184589B90-0x0000000184589CE0
	// [XID] // 0x00000001895F94B0-0x00000001895F94D0
	public void Save() {} // 0x000000018458A000-0x000000018458A150
	// [XID] // 0x0000000189600AE0-0x0000000189600B00
	public void Load() {} // 0x0000000184589CE0-0x0000000184589F50
	// [XID] // 0x0000000189608460-0x0000000189608480
	public void TurnOn4Smoke() {} // 0x0000000184589F50-0x000000018458A000
}

