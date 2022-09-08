/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.AsyncNetwork;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DebugMonitorRecorder : BaseQAModule // TypeDefIndex: 27701
{
	// Fields
	private const string memoryType = "memory"; // Metadata: 0x00B0CAEC
	private const string memoryDetailType = "memory_detail"; // Metadata: 0x00B0CAF6
	private const string gameInfoType = "game_info"; // Metadata: 0x00B0CB07
	private const string frameInfoType = "frame_info"; // Metadata: 0x00B0CB14
	private const string cpuInfoType = "cpu_info"; // Metadata: 0x00B0CB22
	private const string systemMemoryType = "system_memory"; // Metadata: 0x00B0CB2E
	private const string energyInfoType = "energy_info"; // Metadata: 0x00B0CB3F
	private const string networkInfoType = "network_info"; // Metadata: 0x00B0CB4E
	private const string overviewType = "overview"; // Metadata: 0x00B0CB5E
	private const string overviewFullType = "overview_full"; // Metadata: 0x00B0CB6A
	private const int version = 1; // Metadata: 0x00B0CB7B
	private NormalTimer _timer; // 0x10
	private bool _reportRecordFinish; // 0x18
	private FPSIndicator _fpsIndicator; // 0x20
	private const string recordAddress = "https://agentr.yuanshen.com:19100"; // Metadata: 0x00B0CB7F
	private const int maxTimeoutTime = 5; // Metadata: 0x00B0CBA4
	private const int maxRetryCount = 5; // Metadata: 0x00B0CBA8
	private const string configApi = "/config"; // Metadata: 0x00B0CBAC
	private const string recordApi = "/record"; // Metadata: 0x00B0CBB7
	private const bool isEncode = false; // Metadata: 0x00B0CBC2
	private int _retryCount; // 0x28
	private ResponseConfigInfo _config; // 0x30
	private List<string> _startResourceSet; // 0x38
	private Encoder _encoder; // 0x40
	private const int defaultReportRecordInfoInterval = 5; // Metadata: 0x00B0CBC3
	private const int recordInfoCacheCount = 12; // Metadata: 0x00B0CBC7
	private const string md5Key = "CONTENT-MD5"; // Metadata: 0x00B0CBCB
	private const string authorizationKey = "Authorization"; // Metadata: 0x00B0CBDA
	private const string signatureKey = "cms-signature"; // Metadata: 0x00B0CBEB
	private readonly string[] recordSetDefault; // 0x48
	private int _reportMagic; // 0x50
	private string _reportDeviceId; // 0x58
	private int _platformRecordInfoCacheCounter; // 0x60
	private int _reportRecordInfoInterval; // 0x64
	private string _reportSession; // 0x68
	private readonly Dictionary<string, string> _platformReportHeader; // 0x70
	private readonly List<PlatformReportInfo> _platformReportRecordInfoCache; // 0x78
	public bool stopRecord; // 0x80

	// Properties
	public float fps { /* [XID] */ /* 0x00000001898EE750-0x00000001898EE770 */ get => default; } // 0x00000001820BA1C0-0x00000001820BA280 
	public bool isReportEnable { /* [XID] */ /* 0x00000001898F5F00-0x00000001898F5F20 */ get => default; } // 0x00000001820BE0F0-0x00000001820BE1E0 

	// Nested types
	private enum MacroType // TypeDefIndex: 27702
	{
		None = 0,
		Debug = 1,
		Stat = 2,
		NoLog = 4
	}

	private class ReportInfo // TypeDefIndex: 27703
	{
		// Fields
		public string type; // 0x10
		public string session; // 0x18
		public string name; // 0x20
		public string deviceID; // 0x28

		// Constructors
		public ReportInfo() {} // 0x00000001820C2340-0x00000001820C23A0
	}

	private class ConfigInfo : ReportInfo // TypeDefIndex: 27704
	{
		// Fields
		public string deviceMode; // 0x30
		public string deviceType; // 0x38
		public string graphicsName; // 0x40
		public int graphicsID; // 0x48
		public string graphicsVendor; // 0x50
		public int graphicsVendorID; // 0x58
		public string graphicsVersion; // 0x60
		public int graphicsMemory; // 0x68
		public int systemMemory; // 0x6C
		public string processorType; // 0x70
		public string os; // 0x78
		public string identifier; // 0x80
		public int installMode; // 0x88
		public bool isEditor; // 0x8C
		public int platform; // 0x90
		public string buildBranch; // 0x98
		public string engineBranch; // 0xA0
		public string p4Version; // 0xA8
		public int macro; // 0xB0
		public int version; // 0xB4

		// Constructors
		public ConfigInfo() {} // 0x00000001820A1960-0x00000001820A1A10
	}

	private class RecordInfo : ReportInfo // TypeDefIndex: 27705
	{
		// Fields
		public int magic; // 0x30
		public string[] recordSet; // 0x38
		public string[] data; // 0x40

		// Constructors
		public RecordInfo() {} // 0x00000001820C2290-0x00000001820C2340
	}

	private class PlatformReportInfo // TypeDefIndex: 27706
	{
		// Fields
		public readonly int applicationId; // 0x10
		public readonly string applicationName; // 0x18
		public readonly int eventId; // 0x20
		public readonly string eventName; // 0x28
		public string msgID; // 0x30
		public string eventTime; // 0x38
		public object uploadContent; // 0x40

		// Constructors
		public PlatformReportInfo() {} // 0x00000001820C2200-0x00000001820C2290
	}

	private class ResponseConfigInfo // TypeDefIndex: 27707
	{
		// Fields
		public int result; // 0x10
		public string error; // 0x18
		public string session; // 0x20
		public int magic; // 0x28
		public bool recordAuto; // 0x2C
		public int recordInterval; // 0x30
		public string recordAddress; // 0x38
		public string[] recordSet; // 0x40

		// Constructors
		public ResponseConfigInfo() {} // 0x00000001820C23A0-0x00000001820C2470
	}

	// Constructors
	public DebugMonitorRecorder() {} // 0x00000001820BEE40-0x00000001820BF0C0

	// Methods
	// [XID] // 0x00000001898FD740-0x00000001898FD760
	public override void Start() {} // 0x00000001820BE9C0-0x00000001820BEB30
	// [XID] // 0x0000000189904FE0-0x0000000189905000
	public override void Stop() {} // 0x00000001820BEB30-0x00000001820BEBE0
	// [XID] // 0x000000018990C840-0x000000018990C860
	public override void Tick() {} // 0x00000001820BEBE0-0x00000001820BEE40
	// [XID] // 0x00000001899140D0-0x00000001899140F0
	public List<string> GetStartResourceSet() => default; // 0x00000001820BBEA0-0x00000001820BBF40
	// [XID] // 0x000000018991BB20-0x000000018991BB40
	private bool InitializeReport() => default; // 0x00000001820BBC80-0x00000001820BBEA0
	// [XID] // 0x00000001899230E0-0x0000000189923100
	private void TerminateReport() {} // 0x00000001820B9E90-0x00000001820B9F70
	// [XID] // 0x000000018992A870-0x000000018992A890
	private bool CheckReportPercent() => default; // 0x00000001820BD7A0-0x00000001820BD920
	// [XID] // 0x0000000189931EF0-0x0000000189931F10
	private bool CheckReportPlatformWhitelist() => default; // 0x00000001820BCBF0-0x00000001820BCD20
	// [XID] // 0x0000000189939860-0x0000000189939880
	private bool CheckReportPlatformBlacklist() => default; // 0x00000001820BD400-0x00000001820BD530
	// [XID] // 0x0000000189940B50-0x0000000189940B70
	private bool CheckReportPlatform() => default; // 0x00000001820BCEA0-0x00000001820BCF60
	// [XID] // 0x0000000189948450-0x0000000189948470
	private int CheckReportAccountWhitelist() => default; // 0x00000001820BD920-0x00000001820BDAF0
	// [XID] // 0x000000018994FB50-0x000000018994FB70
	private bool CheckReportAccountBlacklist() => default; // 0x00000001820B9A30-0x00000001820B9BF0
	// [XID] // 0x00000001899571B0-0x00000001899571D0
	private bool CheckReportCondition() => default; // 0x00000001820BE8D0-0x00000001820BE9C0
	// [XID] // 0x000000018995ECA0-0x000000018995ECC0
	private void CheckReport() {} // 0x00000001820BDAF0-0x00000001820BDD20
	// [XID] // 0x00000001899663E0-0x0000000189966400
	private PlatformReportInfo GetPlatformReportInfo(object content) => default; // 0x00000001820BC960-0x00000001820BCAE0
	// [XID] // 0x000000018996D800-0x000000018996D820
	private string ToJson(object value) => default; // 0x00000001820BA0F0-0x00000001820BA1C0
	// [XID] // 0x00000001899753A0-0x00000001899753C0
	private string ToJsonReportInfo(PlatformReportInfo value) => default; // 0x00000001820BCF60-0x00000001820BD400
	// [XID] // 0x000000018997C5A0-0x000000018997C5C0
	private string ToJsonReportInfoList(List<PlatformReportInfo> list) => default; // 0x00000001820BAF30-0x00000001820BB130
	// [XID] // 0x0000000189984300-0x0000000189984320
	private string GetPlatformReportInfoString(object content) => default; // 0x00000001820BE800-0x00000001820BE8D0
	// [XID] // 0x000000018998BDF0-0x000000018998BE10
	private void PlatformReportGet(string url, Action<int, string> callback) {} // 0x00000001820BAC40-0x00000001820BAED0
	// [XID] // 0x00000001899939E0-0x0000000189993A00
	private void PlatformReportPost(string body, string url, Action<int, string> callback) {} // 0x00000001820BBF40-0x00000001820BC3F0
	// [XID] // 0x000000018999B2E0-0x000000018999B300
	private void OnResponse(string result, Action<int, string> callback) {} // 0x00000001820BC700-0x00000001820BC960
	// [XID] // 0x00000001899A2B00-0x00000001899A2B20
	private void OnTimeout(Action<int, string> callback) {} // 0x00000001820B9F70-0x00000001820BA040
	// [XID] // 0x00000001899AA490-0x00000001899AA4B0
	private void PlatformReportConfigCheck(string url) {} // 0x00000001820BB8A0-0x00000001820BBA60
	// [XID] // 0x00000001899B1E90-0x00000001899B1EB0
	private void OnPlatformReportConfigCheckResponse(int code, string message) {} // 0x00000001820BB650-0x00000001820BB8A0
	// [XID] // 0x00000001899B91D0-0x00000001899B91F0
	private void PlatformReportConfigInfo(string url) {} // 0x00000001820B9860-0x00000001820B9A30
	// [XID] // 0x00000001899C0B60-0x00000001899C0B80
	private void OnPlatformReportConfigInfoResponse(int code, string message) {} // 0x00000001820BC3F0-0x00000001820BC6A0
	// [XID] // 0x00000001899C8260-0x00000001899C8280
	private bool PlatformReportRecordInfo(string url) => default; // 0x00000001820BA340-0x00000001820BA4B0
	// [XID] // 0x00000001899CFCC0-0x00000001899CFCE0
	private void OnPlatformReportRecordInfoResponse(int code, string message) {} // 0x00000001820BBA60-0x00000001820BBC80
	// [XID] // 0x00000001899D7030-0x00000001899D7050
	private void PlatformReportRecordInfoAction() {} // 0x00000001820BA6C0-0x00000001820BA990
	// [XID] // 0x00000001899DE560-0x00000001899DE580
	private ConfigInfo GetConfigInfo() => default; // 0x00000001820BA990-0x00000001820BAC40
	// [XID] // 0x00000001899E6260-0x00000001899E6280
	private string GetPlatformConfigInfo() => default; // 0x00000001820BE1E0-0x00000001820BE2A0
	// [XID] // 0x00000001899ED630-0x00000001899ED650
	private string GetDebugInfo(string type) => default; // 0x00000001820BB130-0x00000001820BB650
	// [XID] // 0x00000001899F51C0-0x00000001899F51E0
	private RecordInfo GetRecordInfo(string[] recordSet) => default; // 0x00000001820BA4B0-0x00000001820BA6C0
	// [XID] // 0x00000001899FC790-0x00000001899FC7B0
	private PlatformReportInfo GetPlatformRecordInfo() => default; // 0x00000001820BA280-0x00000001820BA340
	// [XID] // 0x0000000189A03D40-0x0000000189A03D60
	private string GetConfigInfoString() => default; // 0x00000001820B9BF0-0x00000001820B9CB0
	// [XID] // 0x0000000189A0B250-0x0000000189A0B270
	private string GetRecordInfoString(string[] recordSet) => default; // 0x00000001820BE2A0-0x00000001820BE370
	// [XID] // 0x0000000189A12BA0-0x0000000189A12BC0
	private void LoadAssetCallback(List<string> assetSet) {} // 0x00000001820BA040-0x00000001820BA0F0
	// [XID] // 0x0000000189A19E90-0x0000000189A19EB0
	private void RequestConfig() {} // 0x00000001820BD530-0x00000001820BD7A0
	// [XID] // 0x0000000189A21440-0x0000000189A21460
	private void RequestConfigCallback(string result) {} // 0x00000001820B9CB0-0x00000001820B9E90
	// [XID] // 0x0000000189A28A40-0x0000000189A28A60
	private void RequestConfigTimeoutCallback() {} // 0x00000001820BCD20-0x00000001820BCDF0
	// [XID] // 0x0000000189A30110-0x0000000189A30130
	private void InitializeRecord() {} // 0x00000001820BE370-0x00000001820BE7A0
	// [XID] // 0x0000000189A37B60-0x0000000189A37B80
	private void RecordAction() {} // 0x00000001820BDD20-0x00000001820BE0F0
	// [XID] // 0x0000000189A3F290-0x0000000189A3F2B0
	private void RequestRecordCallback(string result) {} // 0x00000001820BCDF0-0x00000001820BCEA0
	// [XID] // 0x0000000189A46850-0x0000000189A46870
	private void RequestRecordTimeoutCallback() {} // 0x00000001820BCAE0-0x00000001820BCBF0
}

