/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class QAManager : GlobalManager // TypeDefIndex: 21267
	{
		// Fields
		private List<BaseQAModule> QAModuleList; // 0x10
		private const string CustomArgStarter = "-mihoyo-"; // Metadata: 0x00AFF38A
		public const string GAME_SCENE_PATH = "Assets/Scenes/BuildSettings/Game.unity"; // Metadata: 0x00AFF396
		public static List<string> categories; // 0x00
		public static List<string> suites; // 0x08
		public static string remoteLuaString; // 0x10
		public static List<string> uErrorKeys; // 0x18
		public static Dictionary<string, string> userDefinedParas; // 0x20
		public static bool uAutoTest; // 0x28
		public static bool uAutoNetworkMode; // 0x29
		public static bool uAutoSkipReport; // 0x2A
		public static bool uAutoSkipVideo; // 0x2B
		public static bool uAutoSkipPerf; // 0x2C
		public static string uAutoReport; // 0x30
		public static string uAutoReportSuite; // 0x38
		public static string uAutoReportDescription; // 0x40
		public static string uWeiXinUrl; // 0x48
		public static string uPackageName; // 0x50
		public static string uVideoServer; // 0x58
		public static string uVideoServerFull; // 0x60
		public static string uVideoServerPort; // 0x68
		public static bool uSkipError; // 0x70
		public static bool uSkipSnapShot; // 0x71
		public static bool uAutoQuit; // 0x72
		public static bool uDeleteOldReport; // 0x73
		public static bool uFatalQuit; // 0x74
		public static bool uQuitOnFailed; // 0x75
		public static bool moveTestCase; // 0x76
		public static string dataPath; // 0x78
		public static string compileErrorMessage; // 0x80
		public static string utestType; // 0x88
		public static string userveripstr; // 0x90
		public static string breakafterfailed; // 0x98
		public static DailySmokeState smokeState; // 0xA0
		private AsyncCallback acceptCallback; // 0x18
		private AsyncCallback receiveDataCallback; // 0x20
		private bool recved; // 0x28
		private bool accepting; // 0x29
		private static Socket serverSocket; // 0xA8
		private static Socket clientSocket; // 0xB0
		private static int Buff_Size; // 0xB8
		private byte[] recvBuff; // 0x30
		private string parameterRecvStr; // 0x38
	
		// Properties
		public LogRecorder logRecorderModule { /* [XID] */ /* 0x00000001896EDED0-0x00000001896EDEF0 */ get => default; } // 0x0000000183BB5460-0x0000000183BB5530 
	
		// Nested types
		public enum DailySmokeState // TypeDefIndex: 21268
		{
			Exception = -17,
			Error = -15,
			Assertion = -13,
			Failure = -7,
			TimeOut = -5,
			Warning = -3,
			Stopted = 0,
			Running = 2,
			Success = 4,
			Finished = 16
		}
	
		// Constructors
		public QAManager() {} // 0x0000000183BB52B0-0x0000000183BB5460
		static QAManager() {} // 0x0000000183BB4F40-0x0000000183BB52B0
	
		// Methods
		// [XID] // 0x00000001896F5710-0x00000001896F5730
		public override void ReloadRes() {} // 0x0000000183BB29A0-0x0000000183BB2A40
		// [XID] // 0x00000001896FCF30-0x00000001896FCF50
		public override void Destroy() {} // 0x0000000183BAE9A0-0x0000000183BAEEA0
		// [XID] // 0x0000000189704380-0x00000001897043A0
		public override void Init() {} // 0x0000000183BB17F0-0x0000000183BB1DB0
		// [XID] // 0x000000018970BC10-0x000000018970BC30
		public void SendLog(string title, string content, LogType type, bool deduplicate = true /* Metadata: 0x00AFF36A */, int errCode = 0 /* Metadata: 0x00AFF36B */, int subErrCode = 0 /* Metadata: 0x00AFF36F */, ErrorLevel errorLevel = ErrorLevel.Low /* Metadata: 0x00AFF373 */, ErrorCategory errorCategory = ErrorCategory.None /* Metadata: 0x00AFF377 */, string notifyUserName = "" /* Metadata: 0x00AFF37B */) {} // 0x0000000183BB2E20-0x0000000183BB30A0
		// [XID] // 0x0000000189713480-0x00000001897134A0
		public void StartModules() {} // 0x0000000183BB3150-0x0000000183BB3330
		// [XID] // 0x000000018971AD20-0x000000018971AD40
		public void StopModules() {} // 0x0000000183BB36E0-0x0000000183BB38C0
		// [XID] // 0x0000000189722020-0x0000000189722040
		public void TickModules() {} // 0x0000000183BB38C0-0x0000000183BB3AA0
		// [XID] // 0x0000000189729750-0x0000000189729770
		public void LateTickModules() {} // 0x0000000183BB1DB0-0x0000000183BB1F90
		// [XID] // 0x0000000189730F40-0x0000000189730F60
		public override void Tick() {} // 0x0000000183BB3AA0-0x0000000183BB3B50
		// [XID] // 0x00000001897387F0-0x0000000189738810
		public override void LateTick() {} // 0x0000000183BB1F90-0x0000000183BB2040
		// [XID] // 0x0000000189740530-0x0000000189740550
		public static void SendFinishMessage(bool hasFailed = false /* Metadata: 0x00AFF37F */) {} // 0x0000000183BB2A40-0x0000000183BB2E20
		// [XID] // 0x00000001897478D0-0x00000001897478F0
		public static void UAutoRun(bool autoQuit = true /* Metadata: 0x00AFF380 */, bool runByRemote = false /* Metadata: 0x00AFF381 */) {} // 0x0000000183BB3C10-0x0000000183BB4E20
		// [XID] // 0x000000018974F070-0x000000018974F090
		public static void UAutoStart() {} // 0x0000000183BB4E20-0x0000000183BB4F40
		// [XID] // 0x00000001897567A0-0x00000001897567C0
		private static void CheckCompileCallBack(string title, string stackTrace, LogType type) {} // 0x0000000183BAE840-0x0000000183BAE900
		// [XID] // 0x000000018975DB90-0x000000018975DBB0
		private static void InitCommandlineParameters(string[] args) {} // 0x0000000183BAF5F0-0x0000000183BB17F0
		// [XID] // 0x00000001897651E0-0x0000000189765200
		private static void OpenConsoleProLog() {} // 0x0000000183BB2890-0x0000000183BB29A0
		// [XID] // 0x000000018976CC80-0x000000018976CCA0
		private static void StopAll() {} // 0x0000000183BB3540-0x0000000183BB36E0
		// [XID] // 0x0000000189774080-0x00000001897740A0
		private static void GetCommandlineParameters() {} // 0x0000000183BAF520-0x0000000183BAF5F0
		// [XID] // 0x000000018977B800-0x000000018977B820
		private void SetSmokeState(LogType type) {} // 0x0000000183BB30A0-0x0000000183BB3150
		// [XID] // 0x0000000189783250-0x0000000189783270
		public void StartTest(string name = "" /* Metadata: 0x00AFF382 */, string category = "" /* Metadata: 0x00AFF386 */) {} // 0x0000000183BB3330-0x0000000183BB3540
		[DebuggerHidden] // 0x000000018978A860-0x000000018978A8A0
		// [XID] // 0x000000018978A860-0x000000018978A8A0
		private IEnumerator ListenConnect() => default; // 0x0000000183BB2040-0x0000000183BB2150
		// [XID] // 0x0000000189794C20-0x0000000189794C40
		private void GetCommandlineParameterByNetwork() {} // 0x0000000183BAEEA0-0x0000000183BAF520
		// [XID] // 0x000000018979D190-0x000000018979D1B0
		private void AcceptCallBack(IAsyncResult result) {} // 0x0000000183BAE4F0-0x0000000183BAE840
		// [XID] // 0x00000001897A4450-0x00000001897A4470
		private void OnReceiveData(IAsyncResult result) {} // 0x0000000183BB2150-0x0000000183BB2890
		// [XID] // 0x00000001897AB9C0-0x00000001897AB9E0
		public override void ClearOnLevelDestroy() {} // 0x0000000183BAE900-0x0000000183BAE9A0
	}
}
