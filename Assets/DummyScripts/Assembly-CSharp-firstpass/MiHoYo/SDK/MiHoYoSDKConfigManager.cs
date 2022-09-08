/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKConfigManager // TypeDefIndex: 8642
	{
		// Fields
		private const string DEVICE_ID = "MIHOYOSDK_DEVICE_ID"; // Metadata: 0x00AE187B
		private const string REGISTRY_KEY_NAME = "miHoYoSDK"; // Metadata: 0x00AE1892
		private const string SOFTWARE = "Software"; // Metadata: 0x00AE189F
		private const string ANNOUNCE_URL = "MIHOYOSDK_ANNOUNCE_URL"; // Metadata: 0x00AE18AB
		public const string PROTOCOL_KEY = "MIHOYOSDK_PROTOCOL"; // Metadata: 0x00AE18C5
		public const string PROTOCOL_SHOW_FLAG = "MIHOYOSDK_PROTOCOL_SHOW_FLAG"; // Metadata: 0x00AE18DB
		public const string CONFIG_MODEL_NAME = "MIHOYOSDK_CONFIG_MODEL_NAME"; // Metadata: 0x00AE18FB
		public const string LANGUAGE_KEY = "MIHOYOSDK_CURRENT_LANGUAGE"; // Metadata: 0x00AE191A
		public const string NOTICE_LANGUAGE_KEY = "MIHOYOSDK_NOTICE_LANGUAGE"; // Metadata: 0x00AE1938
		private const string CLIENT_CONFIG = "MIHOYOSDK_CLIENT_BOX"; // Metadata: 0x00AE1955
		public EnvType _env; // 0x10
		public RequestUrl _requestUrl; // 0x18
		public string _language; // 0x250
		public MiHoYoSDKConfigModel config; // 0x258
		public MiHoYoSDKClientConfigModel clientConfig; // 0x260
		public bool localGuest; // 0x268
		public bool showLoginCloseButton; // 0x269
		public bool protocol; // 0x26A
		public static MiHoYoSDKLanguageModel languageModel; // 0x00
		public static MiHoYoSDKGameRoleModel gameRole; // 0x08
		public static string gameVersion; // 0x10
		public bool qrEnabled; // 0x26B
		public bool heartbeat; // 0x26C
		private static bool joypadEnable; // 0x18
		private static string joypadType; // 0x20
		private static string joypadExchange; // 0x28
		public JSONNode gameParameters; // 0x270
		private string cps; // 0x278
		private string _announce_url; // 0x280
		private Action<string> configCallback; // 0x288
		private string deviceID; // 0x290
		public string ps4ClientId; // 0x298
		public static ClientType clientType; // 0x30
		private static MiHoYoSDKConfigManager _instance; // 0x38
	
		// Properties
		public string announce_url { /* [XID] */ /* 0x00000001898660B0-0x00000001898660D0 */ get => default; /* [XID] */ /* 0x000000018986D8E0-0x000000018986D900 */ set {} } // 0x0000000184DE8EA0-0x0000000184DE8FA0 0x0000000184DE8FA0-0x0000000184DE90A0
	
		// Nested types
		public class ConfigIni // TypeDefIndex: 8643
		{
			// Fields
			public string path; // 0x10
			public Dictionary<string, string> keyVal; // 0x18
	
			// Constructors
			public ConfigIni() {} // Dummy constructor
			public ConfigIni(string path) {} // 0x0000000184DE4710-0x0000000184DE49E0
		}
	
		// Constructors
		public MiHoYoSDKConfigManager() {} // 0x0000000184DE8D20-0x0000000184DE8EA0
		static MiHoYoSDKConfigManager() {} // 0x0000000184DE8C20-0x0000000184DE8D20
	
		// Methods
		// [XID] // 0x0000000189874D70-0x0000000189874D90
		public static MiHoYoSDKConfigManager Instance() => default; // 0x0000000184DE6670-0x0000000184DE6800
		// [XID] // 0x000000018987C840-0x000000018987C860
		public void SetEnv(string env) {} // 0x0000000184DE7AA0-0x0000000184DE7C10
		// [XID] // 0x0000000189883930-0x0000000189883950
		public void InitConfig() {} // 0x0000000184DE6410-0x0000000184DE6670
		// [XID] // 0x000000018988B100-0x000000018988B120
		public void Config() {} // 0x0000000184DE5240-0x0000000184DE53B0
		// [XID] // 0x00000001897D3AC0-0x00000001897D3AE0
		public void GetDefaultLanguage() {} // 0x0000000184DE5AD0-0x0000000184DE5C00
		// [XID] // 0x0000000189A244E0-0x0000000189A24500
		public void SetLocale(string language) {} // 0x0000000184DE8340-0x0000000184DE8460
		// [XID] // 0x00000001898A11C0-0x00000001898A11E0
		public string GetNoticeLanguage() => default; // 0x0000000184DE6190-0x0000000184DE6290
		// [XID] // 0x00000001898A8620-0x00000001898A8640
		public void SetTapTapClientId(string client_id) {} // 0x0000000184DE88F0-0x0000000184DE89B0
		// [XID] // 0x00000001898B02A0-0x00000001898B02C0
		public void SetGameKey(string game_key) {} // 0x0000000184DE7C10-0x0000000184DE7CE0
		// [XID] // 0x0000000189A149C0-0x0000000189A149E0
		public void SetAppKey(string app_key) {} // 0x0000000184DE76B0-0x0000000184DE7770
		// [XID] // 0x00000001898BEEA0-0x00000001898BEEC0
		public void SetAppID(string app_id) {} // 0x0000000184DE75F0-0x0000000184DE76B0
		// [XID] // 0x00000001898C67D0-0x00000001898C67F0
		public void SetChannelID(string channel_id) {} // 0x0000000184DE7770-0x0000000184DE7830
		// [XID] // 0x0000000189B136D0-0x0000000189B136F0
		public void LoadLanguageFile() {} // 0x0000000184DE6AF0-0x0000000184DE6BB0
		// [XID] // 0x00000001898D5810-0x00000001898D5830
		public void SetServerID(string server_id) {} // 0x0000000184DE8690-0x0000000184DE8830
		// [XID] // 0x00000001898DD240-0x00000001898DD260
		public void SetGameRole(string jsonString) {} // 0x0000000184DE7E90-0x0000000184DE7FB0
		// [XID] // 0x00000001898E4C50-0x00000001898E4C70
		public void SetGameRoleLevel(string jsonString) {} // 0x0000000184DE7CE0-0x0000000184DE7E90
		// [XID] // 0x00000001898EC6C0-0x00000001898EC6E0
		public void ClearGameRole() {} // 0x0000000184DE5100-0x0000000184DE5240
		// [XID] // 0x00000001897DB530-0x00000001897DB550
		public bool IsOverSea() => default; // 0x0000000184DE6800-0x0000000184DE68F0
		// [XID] // 0x00000001897DBBB0-0x00000001897DBBD0
		public bool IsTest() => default; // 0x0000000184DE68F0-0x0000000184DE69D0
		// [XID] // 0x0000000189903130-0x0000000189903150
		public void SetDeviceID(string setID) {} // 0x0000000184DE79B0-0x0000000184DE7AA0
		// [XID] // 0x000000018990A780-0x000000018990A7A0
		public string GetDeviceID() => default; // 0x0000000184DE5C00-0x0000000184DE5F20
		// [XID] // 0x00000001898B5310-0x00000001898B5330
		private void SetRegistryKey(string key, string value) {} // 0x0000000184DE8540-0x0000000184DE8690
		// [XID] // 0x0000000189919C10-0x0000000189919C30
		private string GetRegistryKey(string key) => default; // 0x0000000184DE6290-0x0000000184DE6410
		// [XID] // 0x0000000189921170-0x0000000189921190
		public void SetLocalGuestStatus(string flag) {} // 0x0000000184DE8280-0x0000000184DE8340
		// [XID] // 0x0000000189928B50-0x0000000189928B70
		public void SetShowLoginCloseButton(string flag) {} // 0x0000000184DE8830-0x0000000184DE88F0
		// [XID] // 0x000000018992FFD0-0x000000018992FFF0
		public void SetComboAppId(string combo_app_id) {} // 0x0000000184DE7830-0x0000000184DE78F0
		// [XID] // 0x0000000189937530-0x0000000189937550
		public void SetComboAppKey(string combo_app_key) {} // 0x0000000184DE78F0-0x0000000184DE79B0
		// [XID] // 0x0000000189B326C0-0x0000000189B326E0
		private void UpdateConfig(MiHoYoSDKConfigModel model) {} // 0x0000000184DE89B0-0x0000000184DE8C20
		// [XID] // 0x0000000189946640-0x0000000189946660
		public SceneType CheckSceneType() => default; // 0x0000000184DE49E0-0x0000000184DE4D20
		[DebuggerHidden] // 0x000000018994DD20-0x000000018994DD60
		// [XID] // 0x000000018994DD20-0x000000018994DD60
		public IEnumerator LoadConfig(Action<string> callback) => default; // 0x0000000184DE69D0-0x0000000184DE6AF0
		// [XID] // 0x00000001899586C0-0x00000001899586E0
		public void SetPS4ClientId(string clientId) {} // 0x0000000184DE8460-0x0000000184DE8540
		// [XID] // 0x00000001898019B0-0x00000001898019D0
		public static void SetJoyPadEnable(bool enable) {} // 0x0000000184DE7FB0-0x0000000184DE8080
		// [XID] // 0x0000000189B4BE60-0x0000000189B4BE80
		public static bool GetJoyPadEnable() => default; // 0x0000000184DE5F20-0x0000000184DE5FF0
		// [XID] // 0x00000001898A70A0-0x00000001898A70C0
		public static void SetJoyPadType(string padType) {} // 0x0000000184DE8180-0x0000000184DE8280
		// [XID] // 0x0000000189976490-0x00000001899764B0
		public static string GetJoyPadType() => default; // 0x0000000184DE60C0-0x0000000184DE6190
		// [XID] // 0x00000001898AE980-0x00000001898AE9A0
		public static void SetJoyPadExchange(string enable) {} // 0x0000000184DE8080-0x0000000184DE8180
		// [XID] // 0x0000000189985350-0x0000000189985370
		public static string GetJoyPadExchange() => default; // 0x0000000184DE5FF0-0x0000000184DE60C0
		// [XID] // 0x0000000189B23D60-0x0000000189B23D80
		private void OnGetConfig(string responseString) {} // 0x0000000184DE6ED0-0x0000000184DE7030
		// [XID] // 0x0000000189994B60-0x0000000189994B80
		private void OnTimeOut() {} // 0x0000000184DE7030-0x0000000184DE7110
		// [XID] // 0x0000000189822FB0-0x0000000189822FD0
		private void OnComboCallback() {} // 0x0000000184DE6BB0-0x0000000184DE6D40
		// [XID] // 0x00000001899A3CC0-0x00000001899A3CE0
		private void GetConfig() {} // 0x0000000184DE5530-0x0000000184DE5670
		// [XID] // 0x00000001899AB8F0-0x00000001899AB910
		private MiHoYoSDKConfigModel GetDefaultConfig() => default; // 0x0000000184DE59F0-0x0000000184DE5AD0
		// [XID] // 0x00000001899B31D0-0x00000001899B31F0
		public string GetCPS() => default; // 0x0000000184DE53B0-0x0000000184DE5460
		// [XID] // 0x00000001899BA480-0x00000001899BA4A0
		private void GetDefaultCPS() {} // 0x0000000184DE5670-0x0000000184DE59F0
		// [XID] // 0x00000001899C1F30-0x00000001899C1F50
		public void RequestClientConfig() {} // 0x0000000184DE7110-0x0000000184DE72F0
		// [XID] // 0x00000001897FF610-0x00000001897FF630
		private void OnGetClientConfig(string responseString) {} // 0x0000000184DE6DE0-0x0000000184DE6ED0
		// [XID] // 0x00000001899D0E70-0x00000001899D0E90
		private void OnGetClientConfigTimeOut() {} // 0x0000000184DE6D40-0x0000000184DE6DE0
		// [XID] // 0x00000001899D82F0-0x00000001899D8310
		public bool CheckShowMailBind(MiHoYoSDKUserDataModel userDataModel) => default; // 0x0000000184DE4D20-0x0000000184DE5100
		// [XID] // 0x00000001899DF900-0x00000001899DF920
		public string GetClientConfig() => default; // 0x0000000184DE5460-0x0000000184DE5530
		// [XID] // 0x00000001899E7410-0x00000001899E7430
		public void SaveClientConfig(string key) {} // 0x0000000184DE72F0-0x0000000184DE75F0
	}
}
