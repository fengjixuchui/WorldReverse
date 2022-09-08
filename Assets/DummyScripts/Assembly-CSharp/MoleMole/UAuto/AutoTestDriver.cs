/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class AutoTestDriver : MonoBehaviour // TypeDefIndex: 27933
	{
		// Fields
		public List<string> SuiteFilterList; // 0x18
		public List<string> CategoryFilterList; // 0x20
		public List<string> ErrorKeysList; // 0x28
		public List<string> ErrorCaseIgnoreList; // 0x30
		public bool fatalQuit; // 0x38
		public bool hasCaseFailed; // 0x39
		public UAutoObserverManager ObserverManager; // 0x40
		public bool AutoQuit; // 0x48
		public bool skipVideo; // 0x49
		public bool skipPerf; // 0x4A
		public bool skipError; // 0x4B
		public bool deleteOldReport; // 0x4C
		public bool skipSnapShot; // 0x4D
		public string ServerName; // 0x50
		public string customReportPath; // 0x58
		public string customReportSuite; // 0x60
		public string customReportDescription; // 0x68
		public string customWeiXinUrl; // 0x70
		public string runningCaseName; // 0x78
		public string packageName; // 0x80
		public List<string> userDefinedParas; // 0x88
		public float videoStartUnityTime; // 0x90
		public string videoServer; // 0x98
		public string videoServerFull; // 0xA0
		public string videoServerPort; // 0xA8
		public Socket triggerSocket; // 0xB0
		public string testId; // 0xB8
		public string testIdPerf; // 0xC0
		public string caseId; // 0xC8
		public bool isRequestFail; // 0xD0
		public string testType; // 0xD8
		public string[] testTypeLst; // 0xE0
		public string[] testTypeLstPerf; // 0xE8
		public int lastRelatedId; // 0xF0
		public bool needSnap; // 0xF4
		public bool RunByNetwork; // 0xF5
		public bool RunByWindow; // 0xF6
		public string HostUserId; // 0xF8
		public List<string> serverIpStr; // 0x100
		public bool breakAfterFailed; // 0x108
		public int networkCaseRunning; // 0x10C
		public int clientIdx; // 0x110
		public int recordPositionIdx; // 0x114
		private bool caseRunning; // 0x118
		private float updateTimeout; // 0x11C
		private bool manualControl; // 0x120
		private bool _isMale; // 0x121
		private string _avatarName; // 0x128
		private bool _isMaleInite; // 0x130
		[NonSerialized]
		public LuaFunction coroutineCallback; // 0x138
		[NonSerialized]
		public AutoTestReporter reporter; // 0x140
		[NonSerialized]
		public bool DriverInitalized; // 0x148
		[NonSerialized]
		public bool luaMonoTestFinished; // 0x149
		[NonSerialized]
		public bool NetworkModeInited; // 0x14A
		[NonSerialized]
		public List<TestCase> testCaseList; // 0x160
		[NonSerialized]
		public bool forceRunCaseRunning; // 0x168
		[NonSerialized]
		public string dataPath; // 0x170
		private const int maxOrder = 1000; // Metadata: 0x00B0D1C7
		private System.Type[] testcaseTypes; // 0x178
		private int testcaseIndex; // 0x180
		private int monoTestMethodIndex; // 0x184
		private MethodType currentType; // 0x188
		private HashSet<string> recordedContent; // 0x190
		[NonSerialized]
		public TestSuite currentSuite; // 0x198
		[NonSerialized]
		public TestCase currentTestCase; // 0x1A0
		private bool started; // 0x1A8
		private int runByWindowSuiteResult; // 0x1AC
		private int runByWindowCaseResult; // 0x1B0
		private const int serverListenPort = 5557; // Metadata: 0x00B0D1CB
		[NonSerialized]
		public Socket serverSocket; // 0x1B8
		[NonSerialized]
		public List<SocketWithIdx> clientSockets; // 0x1C0
		[NonSerialized]
		public SocketWithIdx hostSocketOnClient; // 0x1C8
		private const int Buff_Size = 1048576; // Metadata: 0x00B0D1CF
		private List<TestProto> msgList; // 0x1E0
		private TestProto currentProto; // 0x1E8
		private bool packageRecved; // 0x228
		private Socket videoSocket; // 0x230
		private string relatedTestFile; // 0x238
		private TestCase monoTestcase; // 0x240
		private TestCaseMethod monoTestMethod; // 0x248
		private int cachedRecvLength; // 0x258
	
		// Properties
		public bool isMale { get => default; } // 0x0000000182B118D0-0x0000000182B11940 
		public string avatarName { get => default; } // 0x0000000182B11860-0x0000000182B118D0 
		public LuaManager luaEnv { get => default; set {} } // 0x0000000182B11940-0x0000000182B119D0 0x0000000182B11E40-0x0000000182B120F0
		public TestCase _monoTestcase { get => default; } // 0x0000000182B11800-0x0000000182B11860 
	
		// Events
		public event MethodFinish MethodFinishEvent;
		public event CaseFinish CaseFinishEvent;
		public event OnDataSyncHandler OnDataSyncEvent;
	
		// Nested types
		public enum MethodType // TypeDefIndex: 27934
		{
			Begin = -1,
			Test = 1,
			MonoTest = 2,
			SetUp = 3,
			TearDown = 4,
			Update = 5,
			End = 999
		}
	
		public enum TestCaseLanguage // TypeDefIndex: 27935
		{
			CSharp = 1,
			Lua = 2
		}
	
		public enum RunMode // TypeDefIndex: 27936
		{
			Host = 1,
			Client = 2,
			Local = 3
		}
	
		public class TestCase // TypeDefIndex: 27937
		{
			// Fields
			public System.Type type; // 0x10
			public string FixtureName; // 0x18
			public TestCaseBase TestCaseObj; // 0x20
			public LuaTable luaTestCaseObj; // 0x28
			public string luaFile; // 0x30
			private bool _isLuaActionLoaded; // 0x38
			public Dictionary<MethodType, List<TestCaseMethod>> methods; // 0x40
			public List<string> category; // 0x48
			public List<string> description; // 0x50
			public double order; // 0x58
			public RunMode runMode; // 0x60
			public bool isSync; // 0x64
			public bool isSkip; // 0x65
			public TestCaseLanguage language; // 0x68
			public Action<TestCase> luaLoadedAction; // 0x70
	
			// Constructors
			public TestCase() {} // 0x0000000181074010-0x0000000181074070
	
			// Methods
			public void LoadLuaFile() {} // 0x0000000181073620-0x0000000181073D30
			public void ClearLuaFile() {} // 0x0000000181072FF0-0x0000000181073170
			private bool TypeValid(int type) => default; // 0x0000000181073D30-0x0000000181073D90
			private void InsertActionToTestCase(object key, object v) {} // 0x0000000181073170-0x0000000181073620
		}
	
		public delegate void Action(); // TypeDefIndex: 27938; 0x0000000181050790-0x00000001810508F0
	
		public class TestCaseMethod // TypeDefIndex: 27939
		{
			// Fields
			public MethodInfo method; // 0x10
			public MethodInfo updateMethod; // 0x18
			public Action action; // 0x20
			public LuaFunction monoAction; // 0x28
			public string name; // 0x30
			public int failureCount; // 0x38
			public MethodType type; // 0x3C
			public List<string> category; // 0x40
			public List<string> description; // 0x48
			public RunMode runMode; // 0x50
			public bool isSync; // 0x54
			public double order; // 0x58
			public float timeout; // 0x60
			public bool isSkiped; // 0x64
	
			// Constructors
			public TestCaseMethod() {} // 0x0000000181072F70-0x0000000181072FF0
		}
	
		public delegate void MethodFinish(TestCaseMethod method, int result); // TypeDefIndex: 27940; 0x0000000181060030-0x00000001810602E0
	
		public delegate void CaseFinish(TestCase testcase, int result); // TypeDefIndex: 27941; 0x0000000181055770-0x0000000181055A20
	
		public struct SocketWithIdx // TypeDefIndex: 27942
		{
			// Fields
			public Socket socket; // 0x00
			public int idx; // 0x08
			public byte[] recvBuff; // 0x10
	
			// Constructors
			public SocketWithIdx(Socket _socket, int _idx) {
				socket = default;
				idx = default;
				recvBuff = default;
			} // 0x00000001810620F0-0x0000000181062120
		}
	
		public delegate void OnDataSyncHandler(List<SyncData> syncDataList, List<SyncData> remoteSyncDataList, bool skip); // TypeDefIndex: 27943; 0x00000001810618F0-0x0000000181061BF0
	
		public struct TestProto // TypeDefIndex: 27944
		{
			// Fields
			public bool isForceRun; // 0x00
			public bool isRunMethod; // 0x01
			public bool isSyncDataRequest; // 0x02
			public bool isSyncDataTooLarge; // 0x03
			public bool isFinish; // 0x04
			public string fixureName; // 0x08
			public string methodName; // 0x10
			public string hostUserId; // 0x18
			public int clientIdx; // 0x20
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public List<string> forceRunParameters; // 0x28
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public List<SyncData> sync; // 0x30
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public List<SyncData> remoteSync; // 0x38
		}
	
		[Serializable]
		public struct SyncData // TypeDefIndex: 27945
		{
			// Fields
			public string syncType; // 0x00
			public string keyName; // 0x08
			public string time; // 0x10
			public Vector3 position; // 0x18
			public string runtimeID; // 0x28
			public int count; // 0x30
		}
	
		// Constructors
		public AutoTestDriver() {} // 0x0000000182B10DA0-0x0000000182B11300
	
		// Methods
		private void InitMale() {} // 0x0000000182B080E0-0x0000000182B081C0
		public void ReInitReport() {} // 0x0000000182B0CC70-0x0000000182B0D020
		public void Start() {} // 0x0000000182B10000-0x0000000182B101E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CloseErrorDialog() => default; // 0x0000000182B04A30-0x0000000182B04AE0
		public void StopAllCorountine() {} // 0x0000000182B101E0-0x0000000182B10410
		private void FixedUpdate() {} // 0x0000000182B04E40-0x0000000182B05820
		private bool errorInFilter(string error) => default; // 0x0000000182B11570-0x0000000182B11720
		private bool errorInKeys(string error) => default; // 0x0000000182B11720-0x0000000182B11800
		public void LogMultiThreadCallback(string condition, string stackTrace, LogType type) {} // 0x0000000182B0A450-0x0000000182B0A6D0
		public void HandleErrors(Exception e, string customStackTrace = "" /* Metadata: 0x00B0D1A7 */, LogType type = LogType.Exception /* Metadata: 0x00B0D1AB */) {} // 0x0000000182B06020-0x0000000182B06E80
		private string GetRunningCaseVideoUrl() => default; // 0x0000000182B05DD0-0x0000000182B05E70
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator HeartBeat() => default; // 0x0000000182B06F70-0x0000000182B07000
		public string GetUserPara(string key) => default; // 0x0000000182B05E70-0x0000000182B06020
		private string AddPacketHead(string msg) => default; // 0x0000000182B03B70-0x0000000182B03C40
		private void StartRecord(string caseName) {} // 0x0000000182B0EDC0-0x0000000182B0F310
		private void StopRecord() {} // 0x0000000182B10410-0x0000000182B106E0
		private void SetCurrentSuiteByCase(TestCase testcase, string name = "" /* Metadata: 0x00B0D1AF */) {} // 0x0000000182B0E500-0x0000000182B0EAD0
		private void SetCurrentCaseByCase(TestCase testcase, TestCaseMethod method) {} // 0x0000000182B0DFE0-0x0000000182B0E500
		private string HttpRequest(string url, string body) => default; // 0x0000000182B07000-0x0000000182B075C0
		private string Map2Str(Dictionary<string, string> map) => default; // 0x0000000182B0A970-0x0000000182B0AD80
		private string Lst2Str(List<string> lst) => default; // 0x0000000182B0A6D0-0x0000000182B0A890
		private bool IfTestTypeIllegal() => default; // 0x0000000182B076B0-0x0000000182B077C0
		private bool IfTestTypeIllegalPerf() => default; // 0x0000000182B075C0-0x0000000182B076B0
		private void GetLastRelated() {} // 0x0000000182B05A40-0x0000000182B05DD0
		private void StartTestPerf() {} // 0x0000000182B0F310-0x0000000182B0FC00
		private void StartTest() {} // 0x0000000182B0FC00-0x0000000182B10000
		private void StartCase(TestCase testcase) {} // 0x0000000182B0EAD0-0x0000000182B0EDC0
		public void RecordPic(string picUrl, string pos = "" /* Metadata: 0x00B0D1B3 */) {} // 0x0000000182B0D020-0x0000000182B0D1D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator Run() => default; // 0x0000000182B0DB90-0x0000000182B0DC20
		private bool CheckCategoryFilters(TestCase testcase) => default; // 0x0000000182B03C40-0x0000000182B04180
		private bool CheckSuiteFilters(TestCase testcase) => default; // 0x0000000182B04690-0x0000000182B04880
		private bool CheckCategoryFilters(TestCaseMethod testcase) => default; // 0x0000000182B04180-0x0000000182B04690
		public void YieldAndCallback(object to_yield, Action callback) {} // 0x0000000182B10D10-0x0000000182B10DA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator CoBody(object to_yield, Action callback) => default; // 0x0000000182B04AE0-0x0000000182B04B80
		private bool TypeValid(int type) => default; // 0x0000000182B106E0-0x0000000182B10740
		private void InitLuaTestCase(object key, object v, ref TestCase testcase) {} // 0x0000000182B07B40-0x0000000182B080E0
		public static bool HasFixture(object[] attributes) => default; // 0x0000000182B06E80-0x0000000182B06F70
		private void InitializeLuaTypes() {} // 0x0000000182B088A0-0x0000000182B08A90
		public void InitializeTypes() {} // 0x0000000182B08A90-0x0000000182B0A230
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator runCurrentTestCaseFunction(MethodType type, int methodIndex = -1 /* Metadata: 0x00B0D1B7 */) => default; // 0x0000000182B11C40-0x0000000182B11CF0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator runMonoTestCases(int MethodIndex = 0 /* Metadata: 0x00B0D1BB */, bool runOneMethod = false /* Metadata: 0x00B0D1BF */) => default; // 0x0000000182B11D90-0x0000000182B11E40
		public void RunCaseFromWindow(TestCase testCase) {} // 0x0000000182B0D3D0-0x0000000182B0D620
		private void SendRemoteFinish(bool hasFailed = false /* Metadata: 0x00B0D1C0 */) {} // 0x0000000182B0DF50-0x0000000182B0DFE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RunCaseFromCommandLine(List<string> suitenameList, List<string> catagorieList) => default; // 0x0000000182B0D320-0x0000000182B0D3D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator RunByManual(TestCase testcase, MethodType type, int methodIndex) => default; // 0x0000000182B0D1D0-0x0000000182B0D280
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator RunByManual(TestCase testcase) => default; // 0x0000000182B0D280-0x0000000182B0D320
		public static GameObject FindGameObject(string path) => default; // 0x0000000182B04B80-0x0000000182B04E40
		public void InitRemoteMode() {} // 0x0000000182B08570-0x0000000182B088A0
		private void AcceptCallBack(IAsyncResult result) {} // 0x0000000182B039F0-0x0000000182B03B70
		private void InitRecv() {} // 0x0000000182B083F0-0x0000000182B08570
		private void InitRecvOnHost() {} // 0x0000000182B081C0-0x0000000182B083F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator ForceRunRoutine(MethodInfo method, List<string> paras) => default; // 0x0000000182B05820-0x0000000182B058D0
		private void OnReceiveData(IAsyncResult result) {} // 0x0000000182B0AD80-0x0000000182B0CC70
		private void RunSuiteFromNetwork(TestProto proto) {} // 0x0000000182B0D830-0x0000000182B0DB90
		public void SendData(TestProto proto, bool hostMode = true /* Metadata: 0x00B0D1C1 */, bool needAddCase = true /* Metadata: 0x00B0D1C2 */) {} // 0x0000000182B0DC20-0x0000000182B0DF50
		public void InitHostMode() {} // 0x0000000182B077C0-0x0000000182B07B40
		public static System.Type[] GetChildTypes(System.Type parentType) => default; // 0x0000000182B058D0-0x0000000182B05A40
		public void ManualStartTest(float timeout = 60f /* Metadata: 0x00B0D1C3 */) {} // 0x0000000182B0A890-0x0000000182B0A910
		public void ManualStopTest() {} // 0x0000000182B0A910-0x0000000182B0A970
		public static object[] LoadLuaFile(string luaFile) => default; // 0x0000000182B0A230-0x0000000182B0A450
		public static void ClearLoaded(string luaFile) {} // 0x0000000182B04880-0x0000000182B04A30
		public void RunCommonLATestCase(string luaFile, string strParam) {} // 0x0000000182B0D620-0x0000000182B0D780
		public void UnloadUAutoLuaFiles() {} // 0x0000000182B10C60-0x0000000182B10D10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RunLuaTestCase(string luaFile, string strParam) => default; // 0x0000000182B0D780-0x0000000182B0D830
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator runLuaTestCases(Action[] actions) => default; // 0x0000000182B11CF0-0x0000000182B11D90
	}
}
