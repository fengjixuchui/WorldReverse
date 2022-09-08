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
using MoleMole;
using UnityEngine;
using UnityEngine.Networking;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NetworkManager : GlobalManager, INotifyInterface // TypeDefIndex: 21200
{
	// Fields
	private const float DISPATCH_CONNECT_TIMEOUT_SECOND = 7f; // Metadata: 0x00AFF10D
	private const float GET_DNS_REGION_ADDRESS_TIMEOUT_SECOND = 3f; // Metadata: 0x00AFF111
	private const float PING_REGION_ADDRESS_TIMEOUT_SECOND = 3f; // Metadata: 0x00AFF115
	private const int DISPATCH_REPEAT_TIME = 3; // Metadata: 0x00AFF119
	private const float DISPATCH_REPEAT_DELAY = 0.5f; // Metadata: 0x00AFF11D
	private MiNetClient _client; // 0x10
	private bool useJobThread; // 0x18
	public ConfigChannel channelConfig; // 0x20
	public List<ServerConfigPattern> serverPatterns; // 0x30
	public ServerConfigAddress currentServerConfig; // 0x38
	public bool ServerStop; // 0x41
	public bool HasServerList; // 0x42
	public IPAddress lastDispatchIP; // 0x50
	private string lastIP; // 0x58
	private ushort lastPort; // 0x60
	public bool isConnect; // 0x62
	public bool isValidToSend; // 0x63
	private DateTime _nextPingTime; // 0x68
	private DateTime _nextCheckConnectTime; // 0x78
	private int _watch; // 0x88
	private uint _clientSequenceId; // 0x8C
	public NetworkTrafficMonitor trafficMonitor; // 0x90
	private Dictionary<int, int> reason2Reconnect; // 0x98
	private Dictionary<ENetReason, Action<ENetReason>> reason2Callback; // 0xA0
	private bool hasDisconnectCB; // 0xA8
	private uint resultData; // 0xAC
	private Queue<Packet> _packetQueue; // 0xB0
	private DateTime _nextPrintTime; // 0xB8
	public static float printIntervalTime; // 0x00
	private List<string> _regionBlackList; // 0xC8
	private Coroutine _pingAllRegionAddressCoroutine; // 0xD0
	private List<Coroutine> _allAddressPingCoroutines; // 0xD8
	public bool isPingAllRegionAddressDone; // 0xE0
	private int _runningPingCount; // 0xE4
	public bool isReconnect; // 0xE8
	public int timeoutCount; // 0xEC
	private Coroutine _reconnectCorotine; // 0xF0
	private Dictionary<Packet, uint> _packetCount; // 0xF8
	private Dictionary<ushort, AfterDeserializeHandler> _specialPacketDeserializedCallback; // 0x100

	// Properties
	public DispatchServerDataItem DispatchSeverData { get; set; } // 0x0000000181E41FC0-0x0000000181E42020 0x0000000181E4C350-0x0000000181E4C3B0
	public bool isGlobalDispatch { get; /* [XID] */ /* 0x00000001896E7F40-0x00000001896E7F80 */ set; } // 0x0000000181E48B00-0x0000000181E48B60 0x0000000181E41E40-0x0000000181E41EA0
	public string lastConnectIP { /* [XID] */ /* 0x00000001896F2310-0x00000001896F2330 */ get => default; } // 0x0000000181E49300-0x0000000181E493A0 
	public IPAddress lastIPAddress { /* [XID] */ /* 0x00000001896F9C70-0x00000001896F9CB0 */ get; /* [XID] */ /* 0x00000001897043A0-0x00000001897043E0 */ private set; } // 0x0000000181E41DE0-0x0000000181E41E40 0x0000000181E48C70-0x0000000181E48CD0

	// Nested types
	public class DispatchResult // TypeDefIndex: 21201
	{
		// Fields
		public string retBinaryString; // 0x10
		public string error; // 0x18
		public HttpStatusCode statusCode; // 0x20
		public long contentLength; // 0x28
		public string contentType; // 0x30

		// Constructors
		public DispatchResult() {} // 0x0000000184C18330-0x0000000184C18390
	}

	// Constructors
	public NetworkManager() {} // 0x0000000181E58190-0x0000000181E58490
	static NetworkManager() {} // 0x0000000181E58130-0x0000000181E58190

	// Methods
	// [XID] // 0x0000000189AD6D50-0x0000000189AD6D70
	public uint GetNextClientSequenceId() => default; // 0x0000000181E4F2B0-0x0000000181E4F370
	// [XID] // 0x0000000189716160-0x0000000189716180
	private void SetUseJobThread(bool bUseJob) {} // 0x0000000181E41EA0-0x0000000181E41FC0
	// [XID] // 0x000000018971DBE0-0x000000018971DC00
	public override void Init() {} // 0x0000000181E49110-0x0000000181E49300
	// [XID] // 0x00000001897250C0-0x00000001897250E0
	private bool InitClient() => default; // 0x0000000181E49510-0x0000000181E49750
	// [XID] // 0x000000018972C7A0-0x000000018972C7C0
	public void SetClientNull() {} // 0x0000000181E48EF0-0x0000000181E48FC0
	// [XID] // 0x0000000189733EB0-0x0000000189733ED0
	public MiNetClient GetClient() => default; // 0x0000000181E57410-0x0000000181E574B0
	// [XID] // 0x000000018973B650-0x000000018973B670
	public uint GetClientRTT() => default; // 0x0000000181E538E0-0x0000000181E53990
	// [XID] // 0x0000000189743100-0x0000000189743120
	public float GetClientPacketLossPercent() => default; // 0x0000000181E42A10-0x0000000181E42AD0
	// [XID] // 0x000000018974AC60-0x000000018974AC80
	public float GetAvgAppRTT() => default; // 0x0000000181E4D4D0-0x0000000181E4D590
	// [XID] // 0x0000000189751D10-0x0000000189751D30
	public ulong GetMaxAppRTT() => default; // 0x0000000181E56870-0x0000000181E56920
	// [XID] // 0x00000001897593C0-0x00000001897593E0
	public float GetTXBandWidth() => default; // 0x0000000181E53820-0x0000000181E538E0
	// [XID] // 0x0000000189760F90-0x0000000189760FB0
	public float GetRXBandWidth() => default; // 0x0000000181E43540-0x0000000181E43600
	// [XID] // 0x0000000189768320-0x0000000189768340
	public void RegistSpecialPacketDeserializeCallback(ushort cmdId, AfterDeserializeHandler callback) {} // 0x0000000181E4FE40-0x0000000181E4FFE0
	// [XID] // 0x000000018976F990-0x000000018976F9B0
	public void UnregistSpecialPacketDeserializeCallback(ushort cmdId) {} // 0x0000000181E407B0-0x0000000181E40880
	// [XID] // 0x0000000189777230-0x0000000189777250
	public void OnConnectedCallback() {} // 0x0000000181E55730-0x0000000181E55BE0
	// [XID] // 0x000000018977E980-0x000000018977E9A0
	public void AddDisconnectedCallback(ENetReason reason, Action<ENetReason> callback) {} // 0x0000000181E42AD0-0x0000000181E42C70
	// [XID] // 0x0000000189786100-0x0000000189786120
	public void RemoveDisconnectedCallback(ENetReason reason, Action<ENetReason> callback) {} // 0x0000000181E421D0-0x0000000181E42330
	// [XID] // 0x00000001899F7850-0x00000001899F7870
	public void OnDisconnectedCallback(uint data) {} // 0x0000000181E531C0-0x0000000181E53820
	// [XID] // 0x0000000189794C40-0x0000000189794C60
	public override void ReloadRes() {} // 0x0000000181E57A80-0x0000000181E57B20
	// [XID] // 0x000000018979D1B0-0x000000018979D1D0
	private void HandleEnetLoginUnfinished() {} // 0x0000000181E4BCF0-0x0000000181E4BDF0
	// [XID] // 0x00000001897A4470-0x00000001897A4490
	private void HandleEnetDisconnectGoBackHome(bool isOK) {} // 0x0000000181E508B0-0x0000000181E509A0
	// [XID] // 0x00000001897AB9E0-0x00000001897ABA00
	public void DelayDisconnectedCallback() {} // 0x0000000181E540C0-0x0000000181E553D0
	// [XID] // 0x00000001897B3920-0x00000001897B3940
	public bool OnPacketCallback(Packet udpPacket) => default; // 0x0000000181E3FC20-0x0000000181E3FF20
	// [XID] // 0x00000001897BB730-0x00000001897BB750
	public bool LoginRegionServer(ServerConfigAddress address, Action<RegionInfo> callback) => default; // 0x0000000181E42460-0x0000000181E42590
	// [XID] // 0x00000001897C2F90-0x00000001897C2FB0
	public bool ReloginGameServer(ENetReason reason) => default; // 0x0000000181E45010-0x0000000181E454D0
	// [XID] // 0x00000001897CA830-0x00000001897CA850
	private bool ConnectGameServer(string host, ushort port, int timeout_ms = 3000 /* Metadata: 0x00AFF0BB */) => default; // 0x0000000181E4AAF0-0x0000000181E4B070
	// [XID] // 0x00000001897D1DB0-0x00000001897D1DD0
	public void LogoutGameServer() {} // 0x0000000181E49750-0x0000000181E49800
	// [XID] // 0x00000001897D9C10-0x00000001897D9C30
	public void Disconnect(ENetReason reason) {} // 0x0000000181E55BE0-0x0000000181E55F80
	// [XID] // 0x00000001897E0F40-0x00000001897E0F60
	public override void Tick() {} // 0x0000000181E57B20-0x0000000181E58130
	// [XID] // 0x00000001897E8610-0x00000001897E8630
	private void PrintNetworkStats() {} // 0x0000000181E49FD0-0x0000000181E4A590
	// [XID] // 0x00000001897F0320-0x00000001897F0340
	public override void Destroy() {} // 0x0000000181E42D40-0x0000000181E42E30
	// [XID] // 0x00000001897F7A90-0x00000001897F7AB0
	public void HandleAllCachedEvent() {} // 0x0000000181E3FF20-0x0000000181E400A0
	// [XID] // 0x00000001897FF0F0-0x00000001897FF110
	public override void ClearOnLevelDestroy() {} // 0x0000000181E42130-0x0000000181E421D0
	// [XID] // 0x0000000189806870-0x0000000189806890
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF0BF */) {} // 0x0000000181E42020-0x0000000181E42130
	// [XID] // 0x000000018980E050-0x000000018980E070
	private void DestroyInternal() {} // 0x0000000181E570E0-0x0000000181E57410
	// [XID] // 0x0000000189815730-0x0000000189815750
	private void Clear() {} // 0x0000000181E442F0-0x0000000181E44420
	// [XID] // 0x0000000189ADE6C0-0x0000000189ADE6E0
	public void SendPacketData(SendPacketData sendData) {} // 0x0000000181E4C4D0-0x0000000181E4C590
	public void SendPacket<T>(T req, bool flush = false /* Metadata: 0x00AFF0C0 */)
		where T : MessageBase {}
	// [XID] // 0x0000000189824580-0x00000001898245A0
	public void SendCustomPacket(SendPacketData sendData, bool flush = false /* Metadata: 0x00AFF0C1 */) {} // 0x0000000181E574B0-0x0000000181E578D0
	public void ForceSendPacket<T>(T req)
		where T : MessageBase {}
	public void SendFakePacket<T>(T data)
		where T : MessageBase {}
	// [IDTag] // 0x000000018982C030-0x000000018982C070
	// [XID] // 0x000000018982C030-0x000000018982C070
	public static string GetRetcodeName(int retcode) => default; // 0x0000000181E4A660-0x0000000181E4A730
	// [IDTag] // 0x0000000189836530-0x0000000189836570
	// [XID] // 0x0000000189836530-0x0000000189836570
	public static string GetRetcodeName(Retcode retcode) => default; // 0x0000000181E4A590-0x0000000181E4A660
	// [XID] // 0x0000000189840870-0x0000000189840890
	public static string GetENetReason(uint data) => default; // 0x0000000181E4D590-0x0000000181E4D660
	public static string GetStrNameByType<T>(T data) => default;
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator DoSendFakePacket<T>(T data)
		where T : MessageBase => default;
	// [XID] // 0x000000018984F540-0x000000018984F560
	private bool IsRegionInBlackList(ServerConfigAddress region) => default; // 0x0000000181E43E00-0x0000000181E43FF0
	[DebuggerHidden] // 0x00000001898566E0-0x0000000189856720
	// [XID] // 0x00000001898566E0-0x0000000189856720
	public IEnumerator ConnectGlobalDispatchServer(ConfigDispatchUrl channelConfig, Action successCallback) => default; // 0x0000000181E42F50-0x0000000181E43050
	// [XID] // 0x0000000189860C50-0x0000000189860C70
	private void OnConnectGlobalDispatch(string retBinaryString, Action successCallback) {} // 0x0000000181E4E630-0x0000000181E4F2B0
	// [XID] // 0x0000000189868400-0x0000000189868420
	public void GetLocalDockerServer() {} // 0x0000000181E40880-0x0000000181E40D20
	// [XID] // 0x000000018986F880-0x000000018986F8A0
	public string HttpGet(string Url, string contentType = "application/json" /* Metadata: 0x00AFF0C2 */) => default; // 0x0000000181E415C0-0x0000000181E41840
	[DebuggerHidden] // 0x0000000189876E30-0x0000000189876E70
	// [XID] // 0x0000000189876E30-0x0000000189876E70
	public IEnumerator ConnectRegionDispatchServer(ServerConfigAddress region, Action<RegionInfo> callback) => default; // 0x0000000181E4B1D0-0x0000000181E4B2D0
	// [XID] // 0x0000000189881560-0x0000000189881580
	private void OnConnectRegionDispatch(string retBinaryString, Action<RegionInfo> callback) {} // 0x0000000181E51730-0x0000000181E52F90
	// [XID] // 0x0000000189888AC0-0x0000000189888AE0
	private void OpenForceUpdateUrl(string url) {} // 0x0000000181E432B0-0x0000000181E43360
	// [XID] // 0x000000018988FEA0-0x000000018988FEC0
	private void CheckDownloadOnServerStop(QueryCurrRegionHttpRsp message) {} // 0x0000000181E4C590-0x0000000181E4C700
	// [XID] // 0x0000000189897400-0x0000000189897420
	private void ShowStopServerDialog(QueryCurrRegionHttpRsp message, bool needToQuitApp = false /* Metadata: 0x00AFF0D6 */) {} // 0x0000000181E44420-0x0000000181E448C0
	// [XID] // 0x000000018989E920-0x000000018989E940
	private bool SetServerDispatchConfig(byte[] buf, byte[] key, bool isGlobal = false /* Metadata: 0x00AFF0D7 */) => default; // 0x0000000181E454D0-0x0000000181E484D0
	// [XID] // 0x00000001898A6420-0x00000001898A6440
	public List<ServerConfigAddress> GetAllServerConfigAddresses() => default; // 0x0000000181E56920-0x0000000181E56CC0
	// [XID] // 0x00000001898ADA90-0x00000001898ADAB0
	public bool LoginGameServer(string ip, ushort port) => default; // 0x0000000181E484D0-0x0000000181E489F0
	// [XID] // 0x00000001898B4F20-0x00000001898B4F40
	private void StartAllPingDispatchAddress() {} // 0x0000000181E51510-0x0000000181E51620
	// [XID] // 0x00000001898BCA30-0x00000001898BCA50
	private void StopAllPingDispatchAddress() {} // 0x0000000181E56F00-0x0000000181E570E0
	[DebuggerHidden] // 0x00000001898C4150-0x00000001898C4190
	// [XID] // 0x00000001898C4150-0x00000001898C4190
	private IEnumerator PingAllDispatchAddress() => default; // 0x0000000181E42C70-0x0000000181E42D40
	[DebuggerHidden] // 0x00000001898CE650-0x00000001898CE690
	// [XID] // 0x00000001898CE650-0x00000001898CE690
	private IEnumerator PingRegionAddress(ServerConfigAddress address) => default; // 0x0000000181E4B0F0-0x0000000181E4B1D0
	// [XID] // 0x00000001898D90D0-0x00000001898D90F0
	public static string GetPersistentUUID() => default; // 0x0000000181E44F30-0x0000000181E45010
	// [XID] // 0x00000001898E0DB0-0x00000001898E0DD0
	public static string GetDeviceUUID() => default; // 0x0000000181E56CC0-0x0000000181E56F00
	// [XID] // 0x00000001898E88A0-0x00000001898E88C0
	private static bool CheckDeviceUniqueIdentifier(string deviceUniqueIdentifier) => default; // 0x0000000181E441C0-0x0000000181E442F0
	// [XID] // 0x00000001898EFFC0-0x00000001898EFFE0
	public void DelayReconnect(float delayTime = 0f /* Metadata: 0x00AFF0D8 */, ENetReason reason = ENetReason.EnetPingTimeout /* Metadata: 0x00AFF0DC */) {} // 0x0000000181E49920-0x0000000181E49F30
	// [XID] // 0x00000001898F7890-0x00000001898F78B0
	private void SendPingReq() {} // 0x0000000181E56340-0x0000000181E56870
	// [XID] // 0x00000001898FEF30-0x00000001898FEF50
	private bool IsUnityEditor() => default; // 0x0000000181E4B2D0-0x0000000181E4B370
	// [XID] // 0x0000000189906710-0x0000000189906730
	public void RefreshCheckConnectTime() {} // 0x0000000181E43A80-0x0000000181E43BB0
	// [XID] // 0x000000018990E1B0-0x000000018990E1D0
	public void CheckConnectFromBack(ulong backTime) {} // 0x0000000181E42590-0x0000000181E42A10
	// [XID] // 0x0000000189915960-0x0000000189915980
	public void OnPingRsp(PingRsp rsp) {} // 0x0000000181E53990-0x0000000181E53CC0
	// [XID] // 0x0000000189807880-0x00000001898078A0
	private void DoReconnect(ENetReason reason) {} // 0x0000000181E53CC0-0x0000000181E540C0
	// [XID] // 0x0000000189924C60-0x0000000189924C80
	private void StopReconnectCoroutine() {} // 0x0000000181E42330-0x0000000181E42460
	// [XID] // 0x000000018992C160-0x000000018992C180
	public static void HwrGetDispatch(string url, float timeout, Dictionary<string, string> headerDict, DispatchResult result) {} // 0x0000000181E4CEB0-0x0000000181E4D4D0
	[DebuggerHidden] // 0x00000001899335C0-0x0000000189933600
	// [XID] // 0x00000001899335C0-0x0000000189933600
	private IEnumerator UwrGetDispatch(string url, float timeout, Dictionary<string, string> headerDict, DispatchResult result) => default; // 0x0000000181E4C3B0-0x0000000181E4C4D0
	[DebuggerHidden] // 0x000000018993E050-0x000000018993E090
	// [XID] // 0x000000018993E050-0x000000018993E090
	private IEnumerator WWWGetDispatch(string url, float timeout, Dictionary<string, string> headerDict, DispatchResult result) => default; // 0x0000000181E400A0-0x0000000181E401C0
	// [XID] // 0x00000001899485C0-0x00000001899485E0
	public void ListenToPSNState() {} // 0x0000000181E489F0-0x0000000181E48B00
	// [XID] // 0x000000018994FD30-0x000000018994FD50
	public bool OnNotify(Notify ntf) => default; // 0x0000000181E55F80-0x0000000181E56090
	// [XID] // 0x00000001899572E0-0x0000000189957300
	private void HandlePSNStateChange(int state) {} // 0x0000000181E41840-0x0000000181E418F0
	// [XID] // 0x000000018995EDB0-0x000000018995EDD0
	private void HandlePSNLogoutGoBackHome(bool isOK) {} // 0x0000000181E4FFE0-0x0000000181E50180
	// [XID] // 0x0000000189966610-0x0000000189966630
	public void NetworkStateLogToServer() {} // 0x0000000181E4D660-0x0000000181E4E630
	// [XID] // 0x000000018996D9F0-0x000000018996DA10
	public void CachePacket(Packet pkt) {} // 0x0000000181E44A90-0x0000000181E44BD0
	// [XID] // 0x0000000189975590-0x00000001899755B0
	public void ReleasePacket(Packet pkt) {} // 0x0000000181E43130-0x0000000181E432B0
	// [XID] // 0x000000018997C730-0x000000018997C750
	private MessageBase onAfterPacketDeserializeInWorkThread(MessageBase message, CodedInputStream inputHelper) => default; // 0x0000000181E411F0-0x0000000181E41330
	// [XID] // 0x0000000189984470-0x0000000189984490
	public void RequestPlayerToken() {} // 0x0000000181E41330-0x0000000181E413D0
	// [XID] // 0x00000001897DEC00-0x00000001897DEC20
	public void RequestToken() {} // 0x0000000181E509A0-0x0000000181E51510
	// [XID] // 0x000000018987F4F0-0x000000018987F510
	public void RequestLogin(string token, uint targetUID = 0 /* Metadata: 0x00AFF0E0 */) {} // 0x0000000181E4B370-0x0000000181E4BBE0
	// [XID] // 0x000000018999B480-0x000000018999B4A0
	public void RequestLogout() {} // 0x0000000181E3FB40-0x0000000181E3FC20
	// [XID] // 0x00000001899A2BF0-0x00000001899A2C10
	public void RequestLeaveScene() {} // 0x0000000181E41110-0x0000000181E411F0
	// [XID] // 0x00000001899AA600-0x00000001899AA620
	public void NotifyAvatarNearPlatformNotify(uint platformRuntimeID, uint avatarRuntimeID, uint routeId, int routeIndex) {} // 0x0000000181E403F0-0x0000000181E405E0
	// [XID] // 0x00000001899B1FA0-0x00000001899B1FC0
	public void NotifyForceDragBackTransferNotify() {} // 0x0000000181E43050-0x0000000181E43130
	// [XID] // 0x0000000189892380-0x00000001898923A0
	public void RequestMovingPlatformStartMove(uint platformRuntimeID) {} // 0x0000000181E43360-0x0000000181E43480
	// [XID] // 0x00000001899C0DF0-0x00000001899C0E10
	public void RequestMovingPlatformReset(uint platformRuntimeID) {} // 0x0000000181E49800-0x0000000181E49920
	// [XID] // 0x00000001899C83D0-0x00000001899C83F0
	public void RequestSceneEntityMoveReq(uint entityId, MotionInfo motion, bool isReliable, uint reliableSeq) {} // 0x0000000181E4BDF0-0x0000000181E4C350
	// [XID] // 0x00000001899CFE50-0x00000001899CFE70
	public void RequesetSceneEntitiesMovesReq(List<EntityMoveInfo> moveInfos, bool isReliable) {} // 0x0000000181E4C700-0x0000000181E4CEB0
	// [XID] // 0x00000001899D72A0-0x00000001899D72C0
	public void NotifyLandVelocity(uint entityId, MotionInfo motionInfo) {} // 0x0000000181E52F90-0x0000000181E530E0
	// [XID] // 0x00000001899DE6F0-0x00000001899DE710
	public void RequestSceneCharacterStaminaReq(Vector3 euler) {} // 0x0000000181E50180-0x0000000181E50330
	// [XID] // 0x00000001899E6410-0x00000001899E6430
	public void RequestSceneRegionEnterNotify(uint regionId, uint entityId) {} // 0x0000000181E43480-0x0000000181E43540
	// [XID] // 0x00000001899ED8A0-0x00000001899ED8C0
	public void RequestChangeGameTimeReq(uint detaTime, bool force) {} // 0x0000000181E48DB0-0x0000000181E48EF0
	// [IDTag] // 0x00000001899F5330-0x00000001899F5370
	// [XID] // 0x00000001899F5330-0x00000001899F5370
	public void RequestChangeAvatarReq(ulong guid = 0 /* Metadata: 0x00AFF0E4 */, uint skillID = 0 /* Metadata: 0x00AFF0EC */) {} // 0x0000000181E44BD0-0x0000000181E44D00
	// [IDTag] // 0x00000001899FF740-0x00000001899FF780
	// [XID] // 0x00000001899FF740-0x00000001899FF780
	public void RequestChangeAvatarReq(Vector3 position, ulong guid = 0 /* Metadata: 0x00AFF0F0 */, uint skillID = 0 /* Metadata: 0x00AFF0F8 */) {} // 0x0000000181E44D00-0x0000000181E44F30
	// [XID] // 0x0000000189A09E20-0x0000000189A09E40
	public void RequestAvatarDieEndReq(uint entityRuntimeId = 0 /* Metadata: 0x00AFF0FC */, uint skillID = 0 /* Metadata: 0x00AFF100 */) {} // 0x0000000181E4F370-0x0000000181E4F910
	// [XID] // 0x0000000189A11680-0x0000000189A116A0
	public void RequestSetUpAvatarTeamReq(uint teamId, List<ulong> avatarIdList, ulong curAvatarGuid) {} // 0x0000000181E553D0-0x0000000181E55620
	// [XID] // 0x0000000189A18A10-0x0000000189A18A30
	public void RequestChooseCurAvatarTeamReq(uint teamId) {} // 0x0000000181E55620-0x0000000181E55730
	// [XID] // 0x0000000189B87110-0x0000000189B87130
	public void RequestChangeEntityPropReq(uint targetEntityId, uint sourceEntityId, List<PropValue> values) {} // 0x0000000181E413D0-0x0000000181E414A0
	// [XID] // 0x0000000189A27420-0x0000000189A27440
	public void RequestGmTalk(string msg) {} // 0x0000000181E43C90-0x0000000181E43DA0
	// [XID] // 0x0000000189A2EC80-0x0000000189A2ECA0
	public void RequestGadgetInteract(uint entityID, uint configID, InterOpType opType = InterOpType.InterOpFinish /* Metadata: 0x00AFF104 */, ResinCostType resinCostType = ResinCostType.None /* Metadata: 0x00AFF108 */) {} // 0x0000000181E493A0-0x0000000181E49510
	// [XID] // 0x0000000189A36550-0x0000000189A36570
	public void RequestDropSubField(uint entityID, string subfieldName) {} // 0x0000000181E48FC0-0x0000000181E49110
	// [XID] // 0x00000001897A8250-0x00000001897A8270
	public void RequestSceneEntityDrown(uint entityID) {} // 0x0000000181E48B60-0x0000000181E48C70
	// [XID] // 0x0000000189A452F0-0x0000000189A45310
	public void RequestPingReq(uint seqID, ulong clientTime) {} // 0x0000000181E4F9B0-0x0000000181E4FE40
	// [XID] // 0x0000000189A4C9C0-0x0000000189A4C9E0
	public void RequestLoadActivityTerrainNotify(uint activityId) {} // 0x0000000181E41A00-0x0000000181E41B10
	// [XID] // 0x0000000189A541F0-0x0000000189A54210
	public void RequestUnlockAvatarTalent(ulong guid, uint talentID) {} // 0x0000000181E40FE0-0x0000000181E41110
	// [XID] // 0x0000000189A5BC00-0x0000000189A5BC20
	public void RequestSetPlayerBornDataReq(uint id, string name) {} // 0x0000000181E401C0-0x0000000181E403F0
	// [XID] // 0x0000000189A63370-0x0000000189A63390
	public void RequestExecuteGroupTrigger(uint id, string sourceName, uint targetID, int param1, int param2, int param3) {} // 0x0000000181E578D0-0x0000000181E57A80
	// [XID] // 0x0000000189A6AEB0-0x0000000189A6AED0
	public void RequestSetPlayerName(string name) {} // 0x0000000181E51620-0x0000000181E51730
	// [XID] // 0x0000000189A72560-0x0000000189A72580
	public void RequestHitClientTrivialNotify(Vector3 position, uint ownerId) {} // 0x0000000181E43FF0-0x0000000181E441C0
	// [XID] // 0x0000000189A7A190-0x0000000189A7A1B0
	public void RequestHitTreeDropNotify(Vector3 position, Vector3 hitPostion, TreeType treeType) {} // 0x0000000181E50330-0x0000000181E50540
	// [XID] // 0x0000000189A81630-0x0000000189A81650
	public void RequestDungeonQuit(bool isQuitImmediately = false /* Metadata: 0x00AFF10C */) {} // 0x0000000181E414A0-0x0000000181E415C0
	// [XID] // 0x0000000189A89070-0x0000000189A89090
	public void RequestDungeonRevive() {} // 0x0000000181E41CE0-0x0000000181E41DE0
	// [XID] // 0x0000000189A90850-0x0000000189A90870
	public void RequestWorldPlayerRevive() {} // 0x0000000181E530E0-0x0000000181E531C0
	// [XID] // 0x0000000189A98090-0x0000000189A980B0
	public void RequestPlayerSetPause(bool paused) {} // 0x0000000181E4BBE0-0x0000000181E4BCF0
	// [XID] // 0x0000000189A9F470-0x0000000189A9F490
	public void RequestSeeMonster(uint monsterId) {} // 0x0000000181E418F0-0x0000000181E41A00
	// [XID] // 0x0000000189AA6C80-0x0000000189AA6CA0
	public void RequestEnterSceneReady(uint token) {} // 0x0000000181E41B10-0x0000000181E41CE0
	// [XID] // 0x0000000189AAE3F0-0x0000000189AAE410
	public void RequestSceneInitFinish(uint token, bool isReconnecting) {} // 0x0000000181E43830-0x0000000181E43A80
	// [XID] // 0x0000000189AB5C60-0x0000000189AB5C80
	public void RequestEnterSceneDone(uint token) {} // 0x0000000181E506E0-0x0000000181E508B0
	// [XID] // 0x0000000189ABD6B0-0x0000000189ABD6D0
	public void RequesetPostEnterSceneReq(uint token) {} // 0x0000000181E405E0-0x0000000181E407B0
	// [XID] // 0x0000000189AC5150-0x0000000189AC5170
	public void RequestBackMyWorld() {} // 0x0000000181E56090-0x0000000181E56230
	// [XID] // 0x0000000189ACC6C0-0x0000000189ACC6E0
	public void RequestGetGachaInfoReq() {} // 0x0000000181E50540-0x0000000181E506E0
	// [XID] // 0x0000000189AD43B0-0x0000000189AD43D0
	public void RequestDoGachaReq(uint rand, uint times, uint sid, uint type) {} // 0x0000000181E43600-0x0000000181E43830
	// [XID] // 0x0000000189ADBD80-0x0000000189ADBDA0
	public void SyncWindmill(uint entityID, WindmillPack entityClientData) {} // 0x0000000181E448C0-0x0000000181E44A90
	// [XID] // 0x0000000189968AD0-0x0000000189968AF0
	public void RequestGetShopmallDataReq() {} // 0x0000000181E43BB0-0x0000000181E43C90
	// [IDTag] // 0x0000000189AEAFF0-0x0000000189AEB030
	// [XID] // 0x0000000189AEAFF0-0x0000000189AEB030
	public void RequestRechargeReq(uint scheduleId, string productId, string priceTier) {} // 0x0000000181E4A8D0-0x0000000181E4AAF0
	// [IDTag] // 0x0000000189AF5890-0x0000000189AF58D0
	// [XID] // 0x0000000189AF5890-0x0000000189AF58D0
	public void RequestRechargeReq(ShopItem shopItem) {} // 0x0000000181E4A730-0x0000000181E4A8D0
	// [XID] // 0x0000000189AFFF70-0x0000000189AFFF90
	public void RequestPlayerForceExitReq() {} // 0x0000000181E48CD0-0x0000000181E48DB0
	// [XID] // 0x0000000189B074D0-0x0000000189B074F0
	public void RequestOrderDisplyNotify(uint orderId) {} // 0x0000000181E56230-0x0000000181E56340
	// [XID] // 0x0000000189B0ECF0-0x0000000189B0ED10
	public void RequestSceneAudioPostMIDIEvent(uint sourceUID, int instrument, int note) {} // 0x0000000181E40E40-0x0000000181E40FE0
}

