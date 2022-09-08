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
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKDll : MonoBehaviour // TypeDefIndex: 8796
	{
		// Fields
		private static MiHoYoSDKHTTPServer server; // 0x00
		private static object[] parameters2; // 0x08
		private static object[] parameters1; // 0x10
		private static object[] parameters0; // 0x18
		private static System.Type miHoYoDll; // 0x20
		private const string ServerResourcesPath = "MiHoYoSDKRes/HttpServerResources/"; // Metadata: 0x00AE2272
		private static bool isInit; // 0x28
		private static bool isSetEnv; // 0x29
		private static MiHoYoSDKDll _instance; // 0x30
	
		// Events
		public event Action OnClickTab;
		public event Action OnClickReturn;
		public event Action OnClickEsc;
		public event Action OnUpdate;
		public event OnDestroyDelegate DLLDestroyHandler;
		public event Action<string> MiHoYoSDKNotification;
		public event Action<string> MiHoYoSDKDownloadNotification;
		public event Action<InputField> MiHoYoSDKAddInputField;
	
		// Nested types
		public delegate void OnDestroyDelegate(); // TypeDefIndex: 8797; 0x0000000184E0E810-0x0000000184E0E970
	
		// Constructors
		public MiHoYoSDKDll() {} // 0x0000000184DEE3D0-0x0000000184DEE430
		static MiHoYoSDKDll() {} // 0x0000000184DEE280-0x0000000184DEE3D0
	
		// Methods
		// [XID] // 0x0000000189BC7F10-0x0000000189BC7F30
		public static MiHoYoSDKDll Instance() => default; // 0x0000000184DED250-0x0000000184DED440
		// [XID] // 0x0000000189BDEC20-0x0000000189BDEC40
		private void Awake() {} // 0x0000000184DECB20-0x0000000184DECD70
		// [XID] // 0x00000001895EB770-0x00000001895EB790
		private void Start() {} // 0x0000000184DEDEF0-0x0000000184DEE0F0
		// [XID] // 0x00000001899A9300-0x00000001899A9320
		private void OnDestroy() {} // 0x0000000184DEDB60-0x0000000184DEDD70
		// [XID] // 0x00000001896095E0-0x0000000189609600
		public void OnNotificationCallback(string message) {} // 0x0000000184DEDE30-0x0000000184DEDEF0
		// [XID] // 0x000000018961FD70-0x000000018961FD90
		public void OnDownloadNotification(string message) {} // 0x0000000184DEDD70-0x0000000184DEDE30
		[DebuggerHidden] // 0x00000001896270D0-0x0000000189627110
		// [XID] // 0x00000001896270D0-0x0000000189627110
		public IEnumerator AddTime(float seconds, Action action) => default; // 0x0000000184DEC9E0-0x0000000184DECB20
		// [XID] // 0x0000000189A79330-0x0000000189A79350
		private void Update() {} // 0x0000000184DEE0F0-0x0000000184DEE280
		// [XID] // 0x00000001896394B0-0x00000001896394D0
		public static void AddNotDestroyGameObject(GameObject obj) {} // 0x0000000184DEC8E0-0x0000000184DEC9E0
		// [XID] // 0x0000000189640A90-0x0000000189640AB0
		public static string Invoke(string funcName, string args = null, Action<string> callback = null) => default; // 0x0000000184DED440-0x0000000184DEDAC0
		// [XID] // 0x0000000189648380-0x00000001896483A0
		public static void Init(Action<string> callback = null) {} // 0x0000000184DECEA0-0x0000000184DED250
		// [XID] // 0x000000018964F970-0x000000018964F990
		private static bool CheckInit() => default; // 0x0000000184DECD70-0x0000000184DECEA0
		// [XID] // 0x0000000189657300-0x0000000189657320
		public static string login_login(Action<string> callback) => default; // 0x0000000184DF2020-0x0000000184DF2110
		// [XID] // 0x0000000189A62660-0x0000000189A62680
		public static string login_logout(Action<string> callback) => default; // 0x0000000184DF2110-0x0000000184DF21D0
		// [XID] // 0x0000000189666040-0x0000000189666060
		public static string login_logout_without_confirm(Action<string> callback) => default; // 0x0000000184DF21D0-0x0000000184DF2290
		// [XID] // 0x0000000189A8FE30-0x0000000189A8FE50
		public static string login_switch_role(Action<string> callback = null) => default; // 0x0000000184DF2870-0x0000000184DF2930
		// [XID] // 0x0000000189A97470-0x0000000189A97490
		public static string info_set_combo_config(string jsonString) => default; // 0x0000000184DEFF60-0x0000000184DF02B0
		// [XID] // 0x000000018967CE20-0x000000018967CE40
		public static string info_set_channel_config(string jsonString) => default; // 0x0000000184DEFC60-0x0000000184DEFF60
		// [XID] // 0x000000018980BBD0-0x000000018980BBF0
		public static string login_exit(Action<string> callback) => default; // 0x0000000184DF12F0-0x0000000184DF13B0
		// [XID] // 0x000000018968C080-0x000000018968C0A0
		public static string login_bind(Action<string> callback) => default; // 0x0000000184DF0A90-0x0000000184DF0C50
		// [XID] // 0x0000000189693B30-0x0000000189693B50
		public static string login_set_server_id(string server_id) => default; // 0x0000000184DF26B0-0x0000000184DF2790
		// [XID] // 0x0000000189B1E520-0x0000000189B1E540
		public static string login_will_enter_game(string jsonString, Action<string> callback = null) => default; // 0x0000000184DF29F0-0x0000000184DF2D40
		// [XID] // 0x0000000189B34690-0x0000000189B346B0
		public static string login_enter_game(string jsonString) => default; // 0x0000000184DF1090-0x0000000184DF12F0
		// [XID] // 0x0000000189B3BED0-0x0000000189B3BEF0
		public static string login_create_role(string jsonString) => default; // 0x0000000184DF0FF0-0x0000000184DF1090
		// [XID] // 0x0000000189A809A0-0x0000000189A809C0
		public static string login_level_up(string jsonString) => default; // 0x0000000184DF1F40-0x0000000184DF2020
		// [XID] // 0x00000001896B8750-0x00000001896B8770
		public static string login_has_forum() => default; // 0x0000000184DF1B20-0x0000000184DF1BE0
		// [XID] // 0x00000001896BF830-0x00000001896BF850
		public static string login_open_forum() => default; // 0x0000000184DF2290-0x0000000184DF2350
		// [XID] // 0x00000001896C72D0-0x00000001896C72F0
		public static string login_has_user_center() => default; // 0x0000000184DF1CA0-0x0000000184DF1D80
		// [XID] // 0x00000001896CE8A0-0x00000001896CE8C0
		public static string login_open_user_center() => default; // 0x0000000184DF2350-0x0000000184DF2410
		// [XID] // 0x00000001896D5CA0-0x00000001896D5CC0
		public static string login_close_user_center() => default; // 0x0000000184DF0F30-0x0000000184DF0FF0
		// [XID] // 0x00000001896DD1F0-0x00000001896DD210
		public static string login_has_customer_service() => default; // 0x0000000184DF1A60-0x0000000184DF1B20
		// [XID] // 0x00000001896E4A70-0x00000001896E4A90
		public static string all_set_device_id(string deviceID) => default; // 0x0000000184DEED30-0x0000000184DEEE10
		// [XID] // 0x0000000189AA6220-0x0000000189AA6240
		public static string info_get_device_id() => default; // 0x0000000184DEFAB0-0x0000000184DEFB80
		// [XID] // 0x00000001896F3740-0x00000001896F3760
		public static string all_set_env(string env) => default; // 0x0000000184DEEE10-0x0000000184DEEF20
		// [XID] // 0x000000018984BD70-0x000000018984BD90
		public static string login_get_account_name() => default; // 0x0000000184DF13B0-0x0000000184DF1460
		// [XID] // 0x00000001897024B0-0x00000001897024D0
		public static string all_set_language(string language) => default; // 0x0000000184DEEF20-0x0000000184DEF030
		// [XID] // 0x000000018985A880-0x000000018985A8A0
		public static string login_set_guest_func(string flag) => default; // 0x0000000184DF25D0-0x0000000184DF26B0
		// [XID] // 0x00000001898704F0-0x0000000189870510
		public static string web_load_url(string url) => default; // 0x0000000184DF3D20-0x0000000184DF3DE0
		// [XID] // 0x0000000189718BB0-0x0000000189718BD0
		public static string web_set_useragent(string content) => default; // 0x0000000184DF4230-0x0000000184DF42F0
		// [XID] // 0x0000000189A88460-0x0000000189A88480
		public static string login_set_show_close_btn(string content) => default; // 0x0000000184DF2790-0x0000000184DF2870
		// [XID] // 0x0000000189727A00-0x0000000189727A20
		public static string info_get_channel_id() => default; // 0x0000000184DEF900-0x0000000184DEF9E0
		// [XID] // 0x000000018989B390-0x000000018989B3B0
		public static string login_pay(string jsonString, Action<string> callback) => default; // 0x0000000184DF2410-0x0000000184DF2510
		// [XID] // 0x00000001897366F0-0x0000000189736710
		public static string login_close_pay() => default; // 0x0000000184DF0DD0-0x0000000184DF0F30
		// [XID] // 0x000000018973E4C0-0x000000018973E4E0
		public static string login_has_scan_func() => default; // 0x0000000184DF1BE0-0x0000000184DF1CA0
		// [XID] // 0x0000000189745850-0x0000000189745870
		public static string notice_get_pop_notice() => default; // 0x0000000184DF2E40-0x0000000184DF2F00
		// [XID] // 0x00000001898E63D0-0x00000001898E63F0
		public static string notice_show_notice() => default; // 0x0000000184DF3010-0x0000000184DF30F0
		// [XID] // 0x00000001897548D0-0x00000001897548F0
		public static string notice_close_notice() => default; // 0x0000000184DF2D40-0x0000000184DF2E40
		// [XID] // 0x000000018975BBF0-0x000000018975BC10
		public static string notice_show_pop_notice() => default; // 0x0000000184DF3200-0x0000000184DF3340
		// [XID] // 0x0000000189763610-0x0000000189763630
		public static string login_get_price_tier(string currency, Action<string> callback = null) => default; // 0x0000000184DF18C0-0x0000000184DF1990
		// [XID] // 0x000000018976AD50-0x000000018976AD70
		public static string login_get_product_list(string jsonString, Action<string> callback = null) => default; // 0x0000000184DF1990-0x0000000184DF1A60
		// [XID] // 0x00000001898F5670-0x00000001898F5690
		public static string info_set_game_parameters(string jsonString) => default; // 0x0000000184DF03B0-0x0000000184DF0590
		// [XID] // 0x000000018991B220-0x000000018991B240
		public static string login_is_account_bind_mobile() => default; // 0x0000000184DF1D80-0x0000000184DF1E60
		// [XID] // 0x00000001899227F0-0x0000000189922810
		public static string login_is_account_real_name() => default; // 0x0000000184DF1E60-0x0000000184DF1F40
		// [XID] // 0x00000001897888E0-0x0000000189788900
		public static string login_get_bind_state() => default; // 0x0000000184DF1510-0x0000000184DF18C0
		// [XID] // 0x000000018991FBC0-0x000000018991FBE0
		public static void login_bind_email(Action<string> callback = null) {} // 0x0000000184DF09D0-0x0000000184DF0A90
		// [XID] // 0x00000001897978C0-0x00000001897978E0
		public static void login_bind_mobile(Action<string> callback = null) {} // 0x0000000184DF0C50-0x0000000184DF0D10
		// [XID] // 0x000000018979F7D0-0x000000018979F7F0
		public static void login_bind_real_name(Action<string> callback = null) {} // 0x0000000184DF0D10-0x0000000184DF0DD0
		// [XID] // 0x00000001897A6CA0-0x00000001897A6CC0
		public static void login_verify_email(Action<string> callback = null) {} // 0x0000000184DF2930-0x0000000184DF29F0
		// [XID] // 0x00000001897BE320-0x00000001897BE340
		public void AddInputField(InputField inputField) {} // 0x0000000184DEC820-0x0000000184DEC8E0
		// [XID] // 0x00000001897CF050-0x00000001897CF070
		public static string login_set_account(string jsonString) => default; // 0x0000000184DF2510-0x0000000184DF25D0
		// [XID] // 0x00000001897CD130-0x00000001897CD150
		public static string login_get_asterisk_name() => default; // 0x0000000184DF1460-0x0000000184DF1510
		// [XID] // 0x0000000189BDC5A0-0x0000000189BDC5C0
		public static string web_set_linear(string linear) => default; // 0x0000000184DF4120-0x0000000184DF4230
		// [XID] // 0x00000001897DBE20-0x00000001897DBE40
		public static string launch_get_disk_free_space() => default; // 0x0000000184DF0690-0x0000000184DF0760
		// [XID] // 0x00000001896594B0-0x00000001896594D0
		public static string launch_open_url(string url) => default; // 0x0000000184DF0760-0x0000000184DF0840
		// [XID] // 0x00000001897EB010-0x00000001897EB030
		public static string notice_show_pop_image() => default; // 0x0000000184DF30F0-0x0000000184DF3200
		// [XID] // 0x00000001897F2CB0-0x00000001897F2CD0
		public static string notice_set_notice_url(string url) => default; // 0x0000000184DF2F00-0x0000000184DF3010
		// [XID] // 0x0000000189AFE850-0x0000000189AFE870
		public static string download_create_download_tasks(string tasks) => default; // 0x0000000184DEF170-0x0000000184DEF250
		// [XID] // 0x00000001899C7210-0x00000001899C7230
		public static string download_pause_all_download_task() => default; // 0x0000000184DEF400-0x0000000184DEF4E0
		// [XID] // 0x0000000189808FF0-0x0000000189809010
		public static string download_restart_all_download_task() => default; // 0x0000000184DEF5C0-0x0000000184DEF6A0
		// [XID] // 0x0000000189810870-0x0000000189810890
		public static string download_pause_download_tasks(string tasks) => default; // 0x0000000184DEF4E0-0x0000000184DEF5C0
		// [XID] // 0x0000000189817FE0-0x0000000189818000
		public static string download_restart_download_tasks(string tasks) => default; // 0x0000000184DEF6A0-0x0000000184DEF780
		// [XID] // 0x000000018964AD00-0x000000018964AD20
		public static string download_delete_download_tasks(string tasks) => default; // 0x0000000184DEF250-0x0000000184DEF330
		// [XID] // 0x0000000189826FA0-0x0000000189826FC0
		public static string download_get_unfinished_download_tasks() => default; // 0x0000000184DEF330-0x0000000184DEF400
		// [XID] // 0x0000000189A10050-0x0000000189A10070
		public static string download_set_max_concurrent_count(string count) => default; // 0x0000000184DEF780-0x0000000184DEF860
		// [XID] // 0x0000000189835D30-0x0000000189835D50
		public static string download_allow_cellular_download(string tasks) => default; // 0x0000000184DEF030-0x0000000184DEF0D0
		// [XID] // 0x000000018983D290-0x000000018983D2B0
		public static string download_allow_notification(string tasks) => default; // 0x0000000184DEF0D0-0x0000000184DEF170
		// [XID] // 0x0000000189B449D0-0x0000000189B449F0
		public static string download_set_notification_content(string tasks) => default; // 0x0000000184DEF860-0x0000000184DEF900
		// [XID] // 0x000000018984BE90-0x000000018984BEB0
		public static string info_set_game_version(string version) => default; // 0x0000000184DF0590-0x0000000184DF0690
		// [XID] // 0x0000000189852DD0-0x0000000189852DF0
		public static string report_set_info(string jsonString) => default; // 0x0000000184DF3C40-0x0000000184DF3D20
		// [XID] // 0x000000018985AA30-0x000000018985AA50
		public static string info_get_sub_channel_id() => default; // 0x0000000184DEFB80-0x0000000184DEFC60
		// [XID] // 0x0000000189602890-0x00000001896028B0
		public static string web_set_joypad_enable(string enable = null) => default; // 0x0000000184DF3DE0-0x0000000184DF3F20
		// [XID] // 0x0000000189688660-0x0000000189688680
		public static string web_set_joypad_type(string joyPadType) => default; // 0x0000000184DF4020-0x0000000184DF4120
		// [XID] // 0x000000018968FF60-0x000000018968FF80
		public static string web_set_joypad_exchange(string joyPadExchange) => default; // 0x0000000184DF3F20-0x0000000184DF4020
		// [XID] // 0x0000000189877E70-0x0000000189877E90
		public static string info_get_cps() => default; // 0x0000000184DEF9E0-0x0000000184DEFAB0
		// [XID] // 0x000000018987F650-0x000000018987F670
		public static string launch_show_user_agreement(Action<string> callback = null) => default; // 0x0000000184DF0840-0x0000000184DF0900
		// [XID] // 0x0000000189886D00-0x0000000189886D20
		public static string launch_show_user_agreement_with_parameters(string jsonString, Action<string> callback = null) => default; // 0x0000000184DF0900-0x0000000184DF09D0
		// [XID] // 0x000000018988DCF0-0x000000018988DD10
		public static string info_set_domain_prefix(string domain_prefix) => default; // 0x0000000184DF02B0-0x0000000184DF03B0
		// [XID] // 0x00000001899B8070-0x00000001899B8090
		private bool IsUsingHttpServer() => default; // 0x0000000184DEDAC0-0x0000000184DEDB60
	}
}
