/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class LogRecorder : BaseQAModule // TypeDefIndex: 28367
	{
		// Fields
		public string api; // 0x10
		private string address; // 0x18
		private static int maxfailedcount; // 0x00
		private int failedCount; // 0x20
		private bool started; // 0x24
		private USpiderSetting setting; // 0x28
		private HashSet<int> recordedContent; // 0x30
		private HashSet<int> exceptionContent; // 0x38
		private string version; // 0x40
		private bool isWindows; // 0x48
		private int globalExceptionNum; // 0x4C
		private string deviceModel; // 0x50
		private string deviceName; // 0x58
		private string operatingSystem; // 0x60
		private ConfigChannel channelConfig; // 0x70
		private string alarmReportUrl; // 0x78
		private string errCode; // 0x80
		private string guid; // 0x88
		private string clientIp; // 0x90
		private string cpuInfo; // 0x98
		private string gpuInfo; // 0xA0
		private string memoryInfo; // 0xA8
		private string frameCount; // 0xB0
		private uint userId; // 0xB8
		private uint userIdForCrash; // 0xBC
		private uint avatarUserID; // 0xC0
		private List<data> WaitSendList; // 0xC8
		private Coroutine recorderCoroutine; // 0xD0
		private HttpWebRequest httpWebRequest; // 0xD8
	
		// Events
		public event QAStateChangedHandler OnQAStateChanged;
	
		// Nested types
		public delegate void QAStateChangedHandler(LogType type); // TypeDefIndex: 28368; 0x0000000183A46B20-0x0000000183A46CB0
	
		private class DataWithRequest // TypeDefIndex: 28369
		{
			// Fields
			public HttpWebRequest httpRequest; // 0x10
			public string filePath; // 0x18
	
			// Constructors
			public DataWithRequest() {} // 0x0000000183A272C0-0x0000000183A27320
		}
	
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private struct data // TypeDefIndex: 28370
		{
			// Fields
			public string userName; // 0x00
			public string time; // 0x08
			public string frame; // 0x10
			public string stackTrace; // 0x18
			public string logStr; // 0x20
			public string logType; // 0x28
			public string deviceName; // 0x30
			public string deviceModel; // 0x38
			public string operatingSystem; // 0x40
			public string version; // 0x48
			public string exceptionSerialNum; // 0x50
			public string pos; // 0x58
			public string guid; // 0x60
			public string errorCode; // 0x68
			public int errorCodeToPlatform; // 0x70
			public string serverName; // 0x78
			public int subErrorCode; // 0x80
			public uint uid; // 0x84
			public string cpuInfo; // 0x88
			public string gpuInfo; // 0x90
			public string memoryInfo; // 0x98
			public string clientIp; // 0xA0
			public string errorLevel; // 0xA8
			public string errorCategory; // 0xB0
			public string notifyUserName; // 0xB8
		}
	
		[Serializable]
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private struct PlatformReport // TypeDefIndex: 28371
		{
			// Fields
			public int applicationId; // 0x00
			public string applicationName; // 0x08
			public string msgID; // 0x10
			public string eventTime; // 0x18
			public int eventId; // 0x20
			public string eventName; // 0x28
			public UploadContent uploadContent; // 0x30
		}
	
		[Serializable]
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private struct UploadContent // TypeDefIndex: 28372
		{
			// Fields
			public int error_code; // 0x00
			public string message; // 0x08
			public uint user_id; // 0x10
			public ulong time; // 0x18
			public string stackTrace; // 0x20
			public int exceptionSerialNum; // 0x28
			public string frame; // 0x30
			public string deviceModel; // 0x38
			public string deviceName; // 0x40
			public string operatingSystem; // 0x48
			public string userName; // 0x50
			public string version; // 0x58
			public string guid; // 0x60
			public string errorCode; // 0x68
			public bool isRelease; // 0x70
			public string serverName; // 0x78
			public string projectNick; // 0x80
			public string userNick; // 0x88
			public string logType; // 0x90
			public string subErrorCode; // 0x98
			public string cpuInfo; // 0xA0
			public string gpuInfo; // 0xA8
			public string memoryInfo; // 0xB0
			public string clientIp; // 0xB8
			public string errorLevel; // 0xC0
			public string errorCategory; // 0xC8
			public string notifyUser; // 0xD0
		}
	
		// Constructors
		private LogRecorder() {} // 0x0000000183A3E100-0x0000000183A3E2A0
		static LogRecorder() {} // 0x0000000183A3E0A0-0x0000000183A3E100
	
		// Methods
		// [XID] // 0x00000001899B1E10-0x00000001899B1E30
		public override void Start() {} // 0x0000000183A3D3A0-0x0000000183A3D790
		// [XID] // 0x00000001899B9190-0x00000001899B91B0
		public void ReadLastUid() {} // 0x0000000183A3AFC0-0x0000000183A3B200
		// [XID] // 0x00000001899C0A30-0x00000001899C0A50
		public void SaveLastUid() {} // 0x0000000183A3B7B0-0x0000000183A3BA40
		// [XID] // 0x0000000189848B80-0x0000000189848BA0
		public void SaveInfo() {} // 0x0000000183A3B200-0x0000000183A3B7B0
		[Preserve] // 0x00000001899CFC20-0x00000001899CFC60
		// [XID] // 0x00000001899CFC20-0x00000001899CFC60
		public void SendFileByPath(string filePath, string savedFileName = "" /* Metadata: 0x00B0D61A */) {} // 0x0000000183A3C580-0x0000000183A3C880
		// [XID] // 0x00000001899DA070-0x00000001899DA090
		private void SendCrashByFilePath(string title, string userName, string filePath) {} // 0x0000000183A3BA40-0x0000000183A3BFA0
		// [XID] // 0x00000001899E1A30-0x00000001899E1A50
		public void SendCrash() {} // 0x0000000183A3C270-0x0000000183A3C580
		// [XID] // 0x00000001899E8F00-0x00000001899E8F20
		public override void Stop() {} // 0x0000000183A3D790-0x0000000183A3D8D0
		// [XID] // 0x0000000189841720-0x0000000189841740
		private bool checkTypeSetting(LogType type) => default; // 0x0000000183A3E3C0-0x0000000183A3E520
		// [XID] // 0x00000001899F7EA0-0x00000001899F7EC0
		public void SetVersion(string gameCL, string engineCL, string resourceCL, string silenceCL, string dataCL, string clientCL) {} // 0x0000000183A3CA70-0x0000000183A3D0D0
		// [XID] // 0x00000001899FF550-0x00000001899FF570
		private void ShowErrDialog(string condition, string stacktrace, LogType type) {} // 0x0000000183A3D0D0-0x0000000183A3D3A0
		// [XID] // 0x0000000189A06E10-0x0000000189A06E30
		private string GetPos() => default; // 0x0000000183A3A6C0-0x0000000183A3A8A0
		// [XID] // 0x0000000189A0E4A0-0x0000000189A0E4C0
		private string GetRealContent(string condition, out string guid, out string errorCode) {
			guid = default;
			errorCode = default;
			return default;
		} // 0x0000000183A3A8A0-0x0000000183A3AA90
		// [XID] // 0x0000000189A15A40-0x0000000189A15A60
		public void LogMultiThreadCallback(string title, string stackTrace, LogType type) {} // 0x0000000183A3AC10-0x0000000183A3AEB0
		// [XID] // 0x0000000189A1CF00-0x0000000189A1CF20
		public string GenerateGUID(string content) => default; // 0x0000000183A39CC0-0x0000000183A3A6C0
		// [XID] // 0x0000000189A244E0-0x0000000189A24500
		private string GetServerName() => default; // 0x0000000183A3AA90-0x0000000183A3AC10
		[DebuggerHidden] // 0x0000000189A2B900-0x0000000189A2B940
		// [XID] // 0x0000000189A2B900-0x0000000189A2B940
		private IEnumerator SendLogToPlatform(string message, string stackTrace, int errorCode, int subErrorCode, string logType, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00B0D61E */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00B0D622 */, string notifyUser = "" /* Metadata: 0x00B0D626 */) => default; // 0x0000000183A3C880-0x0000000183A3CA70
		// [XID] // 0x0000000189A36300-0x0000000189A36320
		public void StreamLogToServer(string title, string stackTrace, LogType type, bool deduplicate = true /* Metadata: 0x00B0D62A */, int errorCode = 0 /* Metadata: 0x00B0D62B */, int subErrorCode = 0 /* Metadata: 0x00B0D62F */, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00B0D633 */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00B0D637 */, string notifyUserName = "" /* Metadata: 0x00B0D63B */) {} // 0x0000000183A3D8D0-0x0000000183A3DF90
		[DebuggerHidden] // 0x0000000189A3D8E0-0x0000000189A3D920
		// [XID] // 0x0000000189A3D8E0-0x0000000189A3D920
		private IEnumerator LogSender() => default; // 0x0000000183A3AEB0-0x0000000183A3AFC0
		// [XID] // 0x0000000189A47FB0-0x0000000189A47FD0
		public void SendCrashRequestCallBack(IAsyncResult result) {} // 0x0000000183A3BFA0-0x0000000183A3C270
	}
}
