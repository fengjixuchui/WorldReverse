/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using MoleMole;
using Newtonsoft.Json.Linq;
using UnityEngine;
using WebSocketSharp;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class TestCasePerfBase : TestCaseBase // TypeDefIndex: 28275
	{
		// Fields
		public const string UnionPerfServerAddress = "http://hk4e-uspider.mihoyo.com:9999/"; // Metadata: 0x00B0D5B5
		public string lastGeneratedFile; // 0x198
		public string lastGeneratedTotalFile; // 0x1A0
		public static string testName; // 0x00
		private static string platform; // 0x08
		private static string category; // 0x10
		private static JToken budget; // 0x18
		private static string remoteUrl; // 0x20
		private static string ip_cpu; // 0x28
		private static string port_cpu; // 0x30
		private static string ip_electricity; // 0x38
		private static string port_electricity; // 0x40
		private static bool isProfilerDumpMemory; // 0x48
		private static bool isProfilerDumpCPU; // 0x49
		private static bool isOnSmoke; // 0x4A
		private static string lastCategory; // 0x50
		private static string[] data_titles; // 0x58
		private static string requestJson; // 0x60
		public NetworkTrafficMonitor trafficMonitor; // 0x1A8
		private Coroutine CoroSnapshotStatUnit; // 0x1B0
		private Coroutine CoroIsBudgetExceeded; // 0x1B8
		private Coroutine CoroElectricityHeartBeat; // 0x1C0
		private StatUnitAsyncExecutor sae; // 0x1C8
		private int rowIndex; // 0x1D0
		private string dumpFilePath; // 0x1D8
		private float lastDumpTime; // 0x1E0
		private float lastDumpMemory; // 0x1E4
		private static float budget_memory; // 0x68
		private static float budget_frameTime; // 0x6C
		private static float budget_gameTime; // 0x70
		private static float budget_physicsTime; // 0x74
		private static float budget_renderTime; // 0x78
		private List<string> UploadFiles; // 0x1E8
		private string upload_address; // 0x1F0
		private byte[] file_data; // 0x1F8
		private GetScenePerformanceReq serverNumReq; // 0x200
		private GetScenePerformanceRsp serverNumRsp; // 0x208
		private uint GroupNum; // 0x210
		private uint EntityNum; // 0x214
		private uint DynamicGroupNum; // 0x218
		private uint MonsterNum; // 0x21C
		private uint GadgetNum; // 0x220
		private uint GatherNumInsight; // 0x224
		private uint GatherNum; // 0x228
		private Coroutine updateServerNum; // 0x230
		private bool needUpdateClientStatus; // 0x238
		private WebSocket WebSocketRecord; // 0x240
		private Coroutine CoroCheckNeedUpdateClientStatus; // 0x248
		public static string CPUSetPlayerPos; // 0x80
		private int profilerDataIndex; // 0x250
		private string remoteUrls; // 0x258
		private float dumpTimeStart; // 0x260
		private int rowIndex2; // 0x264
		private Socket _Socket; // 0x268
		private MiNetClient client; // 0x270
		public bool clientInited; // 0x278
		private WebSocket _WebSocket; // 0x280
		public const string profilerServerIP = "hk4e-uspider.mihoyo.com"; // Metadata: 0x00B0D5DD
		public const int profilerServerPort = 7484; // Metadata: 0x00B0D5F8
		public const int profilerNameTransTextServerPort = 7485; // Metadata: 0x00B0D5FC
		public static Socket profilerServer; // 0x88
		public static bool isBlacked; // 0x90
		public static int localProfilerPort; // 0x94
		public static bool isBeginProfiler; // 0x98
		public static int ProfilerStartFrameIndex; // 0x9C
		public static Coroutine HeartBeatCor; // 0xA0
	
		// Nested types
		private class FileWithRequest // TypeDefIndex: 28276
		{
			// Fields
			public HttpWebRequest httpWebRequest; // 0x10
			public string file; // 0x18
			public bool isUploadToStatDB; // 0x20
	
			// Constructors
			public FileWithRequest() {} // 0x000000018218E890-0x000000018218E8F0
		}
	
		private class DataWithRequest // TypeDefIndex: 28277
		{
			// Fields
			public HttpWebRequest httpWebRequest; // 0x10
			public byte[] data; // 0x18
	
			// Constructors
			public DataWithRequest() {} // 0x000000018218E830-0x000000018218E890
		}
	
		private struct StatUnitContext // TypeDefIndex: 28278
		{
			// Fields
			public string dofunc; // 0x00
			public string lastGeneratedFile; // 0x08
			public int rowIndex; // 0x10
			public string frameInfo; // 0x18
			public string memory; // 0x20
			public string gameInfo; // 0x28
			public string playerInfo; // 0x30
			public string memoryDetail; // 0x38
			public string overdraw; // 0x40
			public string renderTypeDetail; // 0x48
			public string physicsDetail; // 0x50
			public string entityAppearInfo; // 0x58
			public string gcInfo; // 0x60
			public string dumpMemoryTextures; // 0x68
			public string dumpMemoryRenderTextures; // 0x70
			public string dumpMemoryMeshes; // 0x78
			public string dumpMemorySkinnedMeshRenderer; // 0x80
			public string dumpMemoryAnimationClips; // 0x88
			public string dumpMemoryAnimatorController; // 0x90
			public string dumpMemoryMaterials; // 0x98
			public string dumpMemoryParticleSystem; // 0xA0
			public string dumpMemoryNavMeshData; // 0xA8
			public string dumpMemoryTerrainData; // 0xB0
			public string dumpEntity; // 0xB8
			public uint groupNum; // 0xC0
			public uint entityNum; // 0xC4
			public uint dynamicGroupNum; // 0xC8
			public uint monsterNum; // 0xCC
			public uint gadgetNum; // 0xD0
			public uint gatherNumInsight; // 0xD4
			public uint gatherNum; // 0xD8
			public long memory_cutscene; // 0xE0
			public string dumpMemoryCutsceneData; // 0xE8
			public int ui_batch; // 0xF0
		}
	
		private class StatUnitAsyncExecutor : AsyncExecutor<StatUnitContext> // TypeDefIndex: 28279
		{
			// Constructors
			public StatUnitAsyncExecutor() {} // 0x000000018218F1C0-0x000000018218F7C0
	
			// Methods
			public override void Execute() {} // 0x000000018218E960-0x000000018218F1C0
			public override void Dispose() {} // 0x000000018218E8F0-0x000000018218E960
		}
	
		// Constructors
		public TestCasePerfBase() {} // 0x0000000181CDA8E0-0x0000000181CDAA50
		static TestCasePerfBase() {} // 0x0000000181CDA7D0-0x0000000181CDA8E0
	
		// Methods
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public override IEnumerator RunGM(string cmd, bool addAvatarAfterClear = false /* Metadata: 0x00B0D576 */, bool local = false /* Metadata: 0x00B0D577 */, bool skipWait = false /* Metadata: 0x00B0D578 */, bool isBoy = true /* Metadata: 0x00B0D579 */, bool skipSDK = false /* Metadata: 0x00B0D57A */) => default; // 0x0000000181CD7E70-0x0000000181CD7F40
		private string[] ParseTitle(List<string> _titles, out string filename_ext) {
			filename_ext = default;
			return default;
		} // 0x0000000181CD7060-0x0000000181CD7610
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartStatUnit(string cmd) => default; // 0x0000000181CD95D0-0x0000000181CD9670
		public static string GetTimeStamp() => default; // 0x0000000181CD4DB0-0x0000000181CD4F30
		public void AddPerfUrl(string remoteUrl) {} // 0x0000000181CCC2A0-0x0000000181CCC470
		public void UpdateClientStatus(string fileUrl, bool isForce = false /* Metadata: 0x00B0D57B */) {} // 0x0000000181CD9BF0-0x0000000181CD9FD0
		public void StartSmokeStatUnit(string casename) {} // 0x0000000181CD9350-0x0000000181CD95D0
		public void StopSmokeStatUnit() {} // 0x0000000181CD9790-0x0000000181CD9910
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SnapshotStatUnit(string[] titles = null, string cmd = "" /* Metadata: 0x00B0D57C */) => default; // 0x0000000181CD9030-0x0000000181CD90E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckBattleState(BaseEntity monster, string filename, float battleTimeOut = 300f /* Metadata: 0x00B0D580 */, float posTimeOut = 30f /* Metadata: 0x00B0D584 */, float hpTimeOut = 60f /* Metadata: 0x00B0D588 */) => default; // 0x0000000181CD1630-0x0000000181CD1760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator InitRealtimeRecord() => default; // 0x0000000181CD59F0-0x0000000181CD5A80
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator QuitRealtimeRecord() => default; // 0x0000000181CD76D0-0x0000000181CD7760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SnapshotStatUnitContinuous(float interval, string[] titles = null) => default; // 0x0000000181CD8F80-0x0000000181CD9030
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckBudget(float interval) => default; // 0x0000000181CD1760-0x0000000181CD1840
		public void IsBudgetExceeded() {} // 0x0000000181CD5A80-0x0000000181CD5E00
		public string GetStatFileName() => default; // 0x0000000181CD4D10-0x0000000181CD4DB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator GetBudget(string platform, string category, string config = "default" /* Metadata: 0x00B0D58C */) => default; // 0x0000000181CD4950-0x0000000181CD4A40
		public void SetBudgetCallback(string text) {} // 0x0000000181CD8E50-0x0000000181CD8F80
		private void ParseBudget() {} // 0x0000000181CD6770-0x0000000181CD6F10
		public string UploadStatFile(string fileName = "" /* Metadata: 0x00B0D597 */, string dirName = "" /* Metadata: 0x00B0D59B */, bool isUpdateClientStatus = false /* Metadata: 0x00B0D59F */, bool isUploadToStatDB = false /* Metadata: 0x00B0D5A0 */) => default; // 0x0000000181CDA060-0x0000000181CDA740
		private void RequestFileStreamCallBack(IAsyncResult result) {} // 0x0000000181CD7760-0x0000000181CD7C30
		private void RequestStreamCallBack(IAsyncResult result) {} // 0x0000000181CD7C30-0x0000000181CD7E70
		public void UploadToStatDB() {} // 0x0000000181CDA740-0x0000000181CDA7D0
		public string GeneratePerfRequestJson(string fileUrl) => default; // 0x0000000181CD3C80-0x0000000181CD4950
		public static string GetP4Stream() => default; // 0x0000000181CD4C80-0x0000000181CD4D10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TakeStatSnap(Action<string> savedFileName = null, string fileNamePrefix = "SnapShot" /* Metadata: 0x00B0D5A1 */) => default; // 0x0000000181CD9990-0x0000000181CD9A40
		public void CreateProfileFile(string filename, string[] titles = null) {} // 0x0000000181CD29D0-0x0000000181CD3590
		public void AppendFrameInfo() {} // 0x0000000181CCCDA0-0x0000000181CCD6D0
		public void AppendMemory() {} // 0x0000000181CCE980-0x0000000181CCEAC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AppendGameInfo() => default; // 0x0000000181CCD8F0-0x0000000181CCD9C0
		public void AppendPlayerInfo(string setPlayerPos, string setCamRotSpherial, string setDescription, string setOverBudget) {} // 0x0000000181CCEEC0-0x0000000181CCFD40
		public void MarkDumpStart() {} // 0x0000000181CD5E00-0x0000000181CD5E70
		public string ParseJson2Csv(string json_str) => default; // 0x0000000181CD6F10-0x0000000181CD7060
		public void AppendMemoryDetail() {} // 0x0000000181CCE760-0x0000000181CCE980
		public void AppendOverdraw() {} // 0x0000000181CCEAC0-0x0000000181CCECC0
		public void AppendRenderTypeDetail() {} // 0x0000000181CCFD40-0x0000000181CCFF40
		public void AppendPhysicsDetail() {} // 0x0000000181CCECC0-0x0000000181CCEEC0
		public void AppendEntityAppearInfo() {} // 0x0000000181CCCB80-0x0000000181CCCDA0
		public void AppendGCInfo() {} // 0x0000000181CCD6D0-0x0000000181CCD8F0
		public void AppendDumpInfoUrl() {} // 0x0000000181CCC6F0-0x0000000181CCC9C0
		public string CollectDumpInfo(string filename, MemoryUtil.E_AssetType type) => default; // 0x0000000181CD20E0-0x0000000181CD26F0
		public string CollectDumpInfo(string filename, string content) => default; // 0x0000000181CD1B00-0x0000000181CD20E0
		public string SaveFile(string filename, string content) => default; // 0x0000000181CD7F40-0x0000000181CD8120
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator UpdateServerNum() => default; // 0x0000000181CD9FD0-0x0000000181CDA060
		public void StartUpdateServerNum() {} // 0x0000000181CD9670-0x0000000181CD9700
		public void StopUpdateServerNum() {} // 0x0000000181CD9910-0x0000000181CD9990
		public void OnRecvGetScenePerformanceRsp(IMessage rsp) {} // 0x0000000181CD6270-0x0000000181CD6770
		public void AppendDumpEntityInfoUrl() {} // 0x0000000181CCC5F0-0x0000000181CCC6F0
		public void AppendDumpServerNum() {} // 0x0000000181CCC9C0-0x0000000181CCCB80
		public string CollectDumpEntityInfo() => default; // 0x0000000181CD1A20-0x0000000181CD1B00
		public void AppendCutsceneDetail() {} // 0x0000000181CCC470-0x0000000181CCC5F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AppendUIBatch() => default; // 0x0000000181CCFF40-0x0000000181CD0010
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckNeedUpdateClientStatus() => default; // 0x0000000181CD1840-0x0000000181CD1910
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartRealtimeRecord() => default; // 0x0000000181CD92C0-0x0000000181CD9350
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StopRealtimeRecord() => default; // 0x0000000181CD9700-0x0000000181CD9790
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator NotifyElectricityRecord(string url) => default; // 0x0000000181CD5FC0-0x0000000181CD6060
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveByAngleForSometime(float angle, float seconds) => default; // 0x0000000181CD5F10-0x0000000181CD5FC0
		public void InitCPUTest(string name, string ip, string port, int statLOD) {} // 0x0000000181CD5390-0x0000000181CD58A0
		public void CreateCPUProfileFile(string filename) {} // 0x0000000181CD27C0-0x0000000181CD29D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveAndCheck(Vector3[] poses) => default; // 0x0000000181CD5E70-0x0000000181CD5F10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckPostion2Dump(Vector3 pos, Vector3 nextPos) => default; // 0x0000000181CD1910-0x0000000181CD1A20
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator DumpMultiContinousProfilerData(int seconds) => default; // 0x0000000181CD3710-0x0000000181CD37F0
		public void CPUDataDump(string filePath) {} // 0x0000000181CD01F0-0x0000000181CD0790
		public void CPUUploadToStatDB() {} // 0x0000000181CD0790-0x0000000181CD1630
		public void AppendInfo(string setPlayerPos, string setCamRotSpherial) {} // 0x0000000181CCD9C0-0x0000000181CCE760
		public bool SendContentBySocket(string serverIP, string serverPort, string content) => default; // 0x0000000181CD8120-0x0000000181CD8360
		public Coroutine StartHeartBeat(string serverIP, string serverPort, string content) => default; // 0x0000000181CD90E0-0x0000000181CD92C0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator HeartBeat(Socket _Socket, string content, float seconds = 10f /* Metadata: 0x00B0D5AD */) => default; // 0x0000000181CD51D0-0x0000000181CD52C0
		public static string GetLocalIPAddress() => default; // 0x0000000181CD4A40-0x0000000181CD4C80
		public override void InitENetClient() {} // 0x0000000181CD58A0-0x0000000181CD59F0
		public void QuitENetClient() {} // 0x0000000181CD7610-0x0000000181CD76D0
		public override void SendMessage(MessageBase req) {} // 0x0000000181CD8940-0x0000000181CD8C00
		public override bool OnPacketCallback(Packet udpPacket) => default; // 0x0000000181CD6060-0x0000000181CD6270
		public static string Get(string url) => default; // 0x0000000181CD4F30-0x0000000181CD51D0
		public bool SendContentByWebSocket(string serverIP, string serverPort, string content) => default; // 0x0000000181CD8360-0x0000000181CD86A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ConnectProfilerServer() => default; // 0x0000000181CD26F0-0x0000000181CD27C0
		public void DisconnectProfilerServer() {} // 0x0000000181CD3590-0x0000000181CD3710
		public void SendNameTransText() {} // 0x0000000181CD8C00-0x0000000181CD8E50
		public void DumpServerCPU(int reason, string timeStr = "" /* Metadata: 0x00B0D5B1 */) {} // 0x0000000181CD37F0-0x0000000181CD3AC0
		public void DumpServerMemory(string filePath) {} // 0x0000000181CD3AC0-0x0000000181CD3BA0
		public void BeginServerSample(string fileName) {} // 0x0000000181CD0010-0x0000000181CD01F0
		public void EndServerSample() {} // 0x0000000181CD3BA0-0x0000000181CD3C80
		private bool SendContentToProfilerServer(string content) => default; // 0x0000000181CD86A0-0x0000000181CD8940
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator HeartBeat() => default; // 0x0000000181CD52C0-0x0000000181CD5390
	}
}
