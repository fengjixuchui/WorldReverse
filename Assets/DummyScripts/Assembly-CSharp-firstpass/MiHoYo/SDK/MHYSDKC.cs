/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MHYSDKC // TypeDefIndex: 8583
	{
		// Nested types
		public static class Code // TypeDefIndex: 8584
		{
			// Fields
			public const int SUCCESS = 0; // Metadata: 0x00ADFBD6
			public const int FAIL = -1; // Metadata: 0x00ADFBDA
			public const int CANCEL = -2; // Metadata: 0x00ADFBDE
			public const int NO_SUCH_METHOD = -10; // Metadata: 0x00ADFBE2
			public const int LOGIN_BASE = -100; // Metadata: 0x00ADFBE6
			public const int LOGIN_FAILED = -101; // Metadata: 0x00ADFBEA
			public const int LOGIN_CANCEL = -102; // Metadata: 0x00ADFBEE
			public const int LOGIN_ERROR = -103; // Metadata: 0x00ADFBF2
			public const int LOGOUT_FAILED = -104; // Metadata: 0x00ADFBF6
			public const int LOGOUT_CANCEL = -105; // Metadata: 0x00ADFBFA
			public const int LOGOUT_ERROR = -106; // Metadata: 0x00ADFBFE
			public const int PAY_FAILED = -107; // Metadata: 0x00ADFC02
			public const int PAY_CANCEL = -108; // Metadata: 0x00ADFC06
			public const int PAY_ERROR = -109; // Metadata: 0x00ADFC0A
			public const int PAY_LAUNCH = -120; // Metadata: 0x00ADFC0E
			public const int PAY_UNKONWEN = -116; // Metadata: 0x00ADFC12
			public const int EXIT_FAILED = -110; // Metadata: 0x00ADFC16
			public const int EXIT_NO_DIALOG = -111; // Metadata: 0x00ADFC1A
			public const int EXIT_CANCEL = -112; // Metadata: 0x00ADFC1E
			public const int EXIT_ERROR = -113; // Metadata: 0x00ADFC22
			public const int INIT_FAILED = -114; // Metadata: 0x00ADFC26
			public const int INIT_ERROR = -115; // Metadata: 0x00ADFC2A
			public const int LOGIN_FORBIDDEN = -117; // Metadata: 0x00ADFC2E
			public const int NEED_REALNAME = -118; // Metadata: 0x00ADFC32
			public const int NEED_GUARDIAN = -119; // Metadata: 0x00ADFC36
		}
	
		public static class Login // TypeDefIndex: 8585
		{
			// Fields
			public const string LOGIN = "login_login"; // Metadata: 0x00ADFC3A
			public const string LOGOUT = "login_logout"; // Metadata: 0x00ADFC49
			public const string BIND = "login_bind"; // Metadata: 0x00ADFC59
			public const string SET_GUEST_FUNC = "login_set_guest_func"; // Metadata: 0x00ADFC67
			public const string SET_SHOW_CLOSE_BTN = "login_set_show_close_btn"; // Metadata: 0x00ADFC7F
			public const string LOGIN_QRCODE = "login_login_qrcode"; // Metadata: 0x00ADFC9B
			public const string LOGOUT_WITHOUT_CONFIRM = "login_logout_without_confirm"; // Metadata: 0x00ADFCB1
			public const string SET_ACCOUNT = "login_set_account"; // Metadata: 0x00ADFCD1
			public const string PAY = "login_pay"; // Metadata: 0x00ADFCE6
			public const string EXIT = "login_exit"; // Metadata: 0x00ADFCF3
			public const string PAY_RECOMMEND = "login_pay_reccomend_product"; // Metadata: 0x00ADFD01
			public const string GET_RECOMMEND_PRODUCT = "login_get_recommend_product"; // Metadata: 0x00ADFD20
			public const string DELETE_RECOMMEND_PRODUCT = "login_delete_recommend_product"; // Metadata: 0x00ADFD3F
			public const string GET_PRICE_TIER = "login_get_price_tier"; // Metadata: 0x00ADFD61
			public const string CLOSE_PAY = "login_close_pay"; // Metadata: 0x00ADFD79
			public const string SWITCH_ROLE = "login_switch_role"; // Metadata: 0x00ADFD8C
			public const string WILL_ENTER_GAME = "login_will_enter_game"; // Metadata: 0x00ADFDA1
			public const string ENTER_GAME = "login_enter_game"; // Metadata: 0x00ADFDBA
			public const string CREATE_ROLE = "login_create_role"; // Metadata: 0x00ADFDCE
			public const string LEVEL_UP = "login_level_up"; // Metadata: 0x00ADFDE3
			public const string SET_SERVER_ID = "login_set_server_id"; // Metadata: 0x00ADFDF5
			public const string HAS_FORUM = "login_has_forum"; // Metadata: 0x00ADFE0C
			public const string OPEN_FORUM = "login_open_forum"; // Metadata: 0x00ADFE1F
			public const string HAS_USER_CENTER = "login_has_user_center"; // Metadata: 0x00ADFE33
			public const string OPEN_USER_CENTER = "login_open_user_center"; // Metadata: 0x00ADFE4C
			public const string CLOSE_USER_CENTER = "login_close_user_center"; // Metadata: 0x00ADFE66
			public const string HAS_CUSTOMER_SERVICE = "login_has_customer_service"; // Metadata: 0x00ADFE81
			public const string OPEN_CUSTOMER_SERVICE = "login_open_customer_service"; // Metadata: 0x00ADFE9F
			public const string HAS_SCAN_FUNC = "login_has_scan_func"; // Metadata: 0x00ADFEBE
			public const string SCAN_CODE = "login_scan_code"; // Metadata: 0x00ADFED5
			public const string IS_ACCOUNT_BIND_MOBILE = "login_is_account_bind_mobile"; // Metadata: 0x00ADFEE8
			public const string IS_ACCOUNT_REAL_NAME = "login_is_account_real_name"; // Metadata: 0x00ADFF08
			public const string GET_BIND_STATE = "login_get_bind_state"; // Metadata: 0x00ADFF26
			public const string BIND_EMAIL = "login_bind_email"; // Metadata: 0x00ADFF3E
			public const string BIND_MOBILE = "login_bind_mobile"; // Metadata: 0x00ADFF52
			public const string BIND_REAL_NAME = "login_bind_real_name"; // Metadata: 0x00ADFF67
			public const string VERIFY_EMAIL = "login_verify_email"; // Metadata: 0x00ADFF7F
			public const string SHOW_USER_AGREEMENT = "login_show_user_agreement"; // Metadata: 0x00ADFF95
			public const string SHOW_PRIVACY_PROTOCOL = "login_show_privacy_protocol"; // Metadata: 0x00ADFFB2
		}
	
		public static class Info // TypeDefIndex: 8586
		{
			// Fields
			public const string SET_DEVICE_ID = "all_set_device_id"; // Metadata: 0x00ADFFD1
			public const string GET_DEVICE_ID = "info_get_device_id"; // Metadata: 0x00ADFFE6
			public const string GET_CHANNEL_ID = "info_get_channel_id"; // Metadata: 0x00ADFFFC
			public const string GET_ACCOUNT_NAME = "login_get_account_name"; // Metadata: 0x00AE0013
			public const string GET_ASTERISK_NAME = "login_get_asterisk_name"; // Metadata: 0x00AE002D
			public const string SET_ENV = "all_set_env"; // Metadata: 0x00AE0048
			public const string SET_LANGUAGE = "all_set_language"; // Metadata: 0x00AE0057
			public const string SET_PRODUCTS = "login_set_products"; // Metadata: 0x00AE006B
			public const string GET_PRODUCT_LIST = "login_get_product_list"; // Metadata: 0x00AE0081
			public const string SET_COMBO_CONFIG = "info_set_combo_config"; // Metadata: 0x00AE009B
			public const string SET_CHANNEL_CONFIG = "info_set_channel_config"; // Metadata: 0x00AE00B4
			public const string SET_GAME_PARAMETERS = "info_set_game_parameters"; // Metadata: 0x00AE00CF
			public const string SET_PS_CLIENT_ID = "set_ps_client_id"; // Metadata: 0x00AE00EB
			public const string GET_PS_USER_ID = "get_ps_user_id"; // Metadata: 0x00AE00FF
			public const string GET_PS_ACCOUNT_ID = "get_ps_account_id"; // Metadata: 0x00AE0111
			public const string GET_PS_ONLINE_ID = "get_ps_online_id"; // Metadata: 0x00AE0126
			public const string GET_PS_AUTH_CODE = "get_ps_auth_code"; // Metadata: 0x00AE013A
			public const string GET_SUB_CHANNEL_ID = "info_get_sub_channel_id"; // Metadata: 0x00AE014E
			public const string SET_GAME_VERSION = "info_set_game_version"; // Metadata: 0x00AE0169
			public const string SET_FULL_GAME_VERSION = "info_set_full_game_version"; // Metadata: 0x00AE0182
			public const string GET_CPS = "info_get_cps"; // Metadata: 0x00AE01A0
			public const string SET_DOMAIN_PREFIX = "info_set_domain_prefix"; // Metadata: 0x00AE01B0
		}
	
		public static class PS // TypeDefIndex: 8587
		{
			// Fields
			public const string INIT_PS_TROPHY = "init_ps_trophy"; // Metadata: 0x00AE01CA
			public const string SHOW_PS_STORE_ICON = "show_ps_store_icon"; // Metadata: 0x00AE01DC
			public const string HIDE_PS_STORE_ICON = "hide_ps_store_icon"; // Metadata: 0x00AE01F2
			public const string SET_PS_TROPHY = "set_ps_trophy"; // Metadata: 0x00AE0208
			public const string SHOW_EMPTY_STORE_DIALOG = "show_empty_store_dialog"; // Metadata: 0x00AE0219
			public const string GET_FRIEND_LIST = "get_ps_friend_list"; // Metadata: 0x00AE0234
			public const string GET_BLOCK_LIST = "get_ps_block_list"; // Metadata: 0x00AE024A
			public const string REGISTER_FRIEND_UPDATE = "register_ps_friend_update"; // Metadata: 0x00AE025F
			public const string REGISTER_BLOCK_UPDATE = "register_ps_block_update"; // Metadata: 0x00AE027C
			public const string UNREGISTER_FRIEND_UPDATE = "unregister_ps_friend_update"; // Metadata: 0x00AE0298
			public const string UNREGISTER_BLOCK_UPDATE = "unregister_ps_block_update"; // Metadata: 0x00AE02B7
			public const string GET_ACCOUNT_ID_BY_ONLINE_ID = "get_online_id_by_account_id"; // Metadata: 0x00AE02D5
		}
	
		public static class Web // TypeDefIndex: 8588
		{
			// Fields
			public const string LOAD_URL = "web_load_url"; // Metadata: 0x00AE02F4
			public const string SET_USERAGENT = "web_set_useragent"; // Metadata: 0x00AE0304
			public const string CLOSE = "web_close"; // Metadata: 0x00AE0319
			public const string SHOULD_CLOSE = "web_should_close"; // Metadata: 0x00AE0326
			public const string MESSAGE_RECEIVED = "web_message_received"; // Metadata: 0x00AE033A
			public const string PAGE_FINISHED = "web_page_finished"; // Metadata: 0x00AE0352
			public const string PAGE_ERROR_RECEIVED = "web_page_error_received"; // Metadata: 0x00AE0367
			public const string HAS_POP_NOTICE = "notice_get_pop_notice"; // Metadata: 0x00AE0382
			public const string SHOW_NOTICE = "notice_show_notice"; // Metadata: 0x00AE039B
			public const string CLOSE_NOTICE = "notice_close_notice"; // Metadata: 0x00AE03B1
			public const string SHOW_POP_NOTICE = "notice_show_pop_notice"; // Metadata: 0x00AE03C8
			public const string SHOW_POP_IMAGE = "notice_show_pop_image"; // Metadata: 0x00AE03E2
			public const string SET_NOTICE_URL = "notice_set_notice_url"; // Metadata: 0x00AE03FB
			public const string SET_WEB_LINEAR = "web_set_linear"; // Metadata: 0x00AE0414
			public const string SET_JOYPAD_ENABLE = "web_set_joypad_enable"; // Metadata: 0x00AE0426
			public const string SET_JOYPAD_TYPE = "web_set_joypad_type"; // Metadata: 0x00AE043F
			public const string SET_JOYPAD_EXCHANGE = "web_set_joypad_exchange"; // Metadata: 0x00AE0456
		}
	
		public static class Cloud // TypeDefIndex: 8589
		{
			// Fields
			public const string SET_LAUNCH_PARAMETERS = "cloud_set_launch_parameters"; // Metadata: 0x00AE0471
			public const string GET_LOCAL_DATA = "cloud_get_data"; // Metadata: 0x00AE0490
			public const string SET_LOCAL_DATA = "cloud_set_data"; // Metadata: 0x00AE04A2
			public const string SAVE_IMAGE = "cloud_save_image"; // Metadata: 0x00AE04B4
			public const string TRANSMIT_DATA = "cloud_transmit_data"; // Metadata: 0x00AE04C8
		}
	
		public static class Push // TypeDefIndex: 8590
		{
			// Fields
			public const string SET_ALIAS = "push_set_alias"; // Metadata: 0x00AE04DF
			public const string DELETE_ALIAS = "push_delete_alias"; // Metadata: 0x00AE04F1
			public const string SET_TAGS = "push_set_tags"; // Metadata: 0x00AE0506
			public const string ADD_TAGS = "push_add_tags"; // Metadata: 0x00AE0517
			public const string DELETE_TAGS = "push_delete_tags"; // Metadata: 0x00AE0528
			public const string CLEAN_TAGS = "push_clean_tags"; // Metadata: 0x00AE053C
			public const string GET_ALL_TAGS = "push_get_all_tags"; // Metadata: 0x00AE054F
			public const string CHECK_TAG_BIND_STATE = "push_check_tag_bind_state"; // Metadata: 0x00AE0564
			public const string ADD_LOCAL_NOTIFICATION = "push_add_local_notification"; // Metadata: 0x00AE0581
			public const string REMOVE_LOCAL_NOTIFICATION = "push_remove_local_notification"; // Metadata: 0x00AE05A0
			public const string CLEAR_LOCAL_NOTIFICATION = "push_clear_local_notification"; // Metadata: 0x00AE05C2
		}
	
		public static class Download // TypeDefIndex: 8591
		{
			// Fields
			public const string CREATE_DOWNLOAD_TASKS = "download_create_download_tasks"; // Metadata: 0x00AE05E3
			public const string PAUSE_ALL_DOWNLOAD_TASK = "download_pause_all_download_task"; // Metadata: 0x00AE0605
			public const string RESTART_ALL_DOWNLOAD_TASK = "download_restart_all_download_task"; // Metadata: 0x00AE0629
			public const string PAUSE_DOWNLOAD_TASKS = "download_pause_download_tasks"; // Metadata: 0x00AE064F
			public const string RESTART_DOWNLOAD_TASKS = "download_restart_download_tasks"; // Metadata: 0x00AE0670
			public const string DELETE_DOWNLOAD_TASKS = "download_delete_download_tasks"; // Metadata: 0x00AE0693
			public const string GET_UNFINISHED_DOWNLOAD_TASKS = "download_get_unfinished_download_tasks"; // Metadata: 0x00AE06B5
			public const string SET_MAX_CONCURRENT_COUNT = "download_set_max_concurrent_count"; // Metadata: 0x00AE06DF
			public const string ALLOW_CELLULAR_DOWNLOAD = "download_allow_cellular_download"; // Metadata: 0x00AE0704
			public const string ALLOW_NOTIFICATION = "download_allow_notification"; // Metadata: 0x00AE0728
			public const string SET_NOTIFICATION_CONTENT = "download_set_notification_content"; // Metadata: 0x00AE0747
			public const string SET_ANDROID_DOWNLOAD_CONTENT = "download_set_notification_download_content"; // Metadata: 0x00AE076C
			public const string START_LIVE = "download_start_live"; // Metadata: 0x00AE079A
			public const string STOP_LIVE = "download_stop_live"; // Metadata: 0x00AE07B1
			public const string UPDATE_PROGRESS = "download_update_progress"; // Metadata: 0x00AE07C7
			public const string SHOW_START_DOWNLOAD_NOTICE = "download_show_start_download_notice"; // Metadata: 0x00AE07E3
			public const string SHOW_DOWNLOAD_FINISH_NOTICE = "download_show_download_finish_notice"; // Metadata: 0x00AE080A
			public const string ALLOW_BACKGROUND_MUSIC = "download_allow_background_music"; // Metadata: 0x00AE0832
		}
	
		public static class Share // TypeDefIndex: 8592
		{
			// Fields
			public const string SHARE = "share_share"; // Metadata: 0x00AE0855
		}
	
		public static class Launch // TypeDefIndex: 8593
		{
			// Fields
			private const string BASE = "launch_"; // Metadata: 0x00AE0864
			public const string OPEN_URL = "launch_open_url"; // Metadata: 0x00AE086F
			public const string IS_NOTIFICATION_OPEN = "launch_is_notification_open"; // Metadata: 0x00AE0882
			public const string OPEN_NOTIFICATION_SETTING = "launch_open_notification_setting"; // Metadata: 0x00AE08A1
			public const string SHOW_NOTIFICATION = "launch_show_notification"; // Metadata: 0x00AE08C5
			public const string DEL_NOTIFICATION = "launch_del_notification"; // Metadata: 0x00AE08E1
			public const string GET_DISK_FREE_SPACE = "launch_get_disk_free_space"; // Metadata: 0x00AE08FC
			public const string IS_PERMISSION_OPEN = "launch_is_permission_open"; // Metadata: 0x00AE091A
			public const string REQUEST_PERMISSION = "launch_request_permission"; // Metadata: 0x00AE0937
			public const string SHOW_USER_AGREEMENT = "launch_show_user_agreement"; // Metadata: 0x00AE0954
			public const string SHOW_USER_AGREEMENT_WITH_PARAMETERS = "launch_show_user_agreement_with_parameters"; // Metadata: 0x00AE0972
			public const string CHECK_PHOTO_PERMISSION = "launch_check_photo_permission"; // Metadata: 0x00AE09A0
			public const string REQUEST_PHOTO_PERMISSION = "launch_request_photo_permission"; // Metadata: 0x00AE09C1
			public const string CHECK_CAMERA_PERMISSION = "launch_check_camera_permission"; // Metadata: 0x00AE09E4
			public const string REQUEST_CAMERA_PERMISSION = "launch_request_camera_permission"; // Metadata: 0x00AE0A06
			public const string CHECK_MICROPHONE_PERMISSION = "launch_check_microphone_permission"; // Metadata: 0x00AE0A2A
			public const string REQUEST_MICROPHONE_PERMISSION = "launch_request_microphone_permission"; // Metadata: 0x00AE0A50
			public const string CHECK_LOCATION_PERMISSION = "launch_check_location_permission"; // Metadata: 0x00AE0A78
			public const string REQUEST_LOCATION_PERMISSION = "launch_request_location_permission"; // Metadata: 0x00AE0A9C
			public const string CHECK_TRACKING_PERMISSION = "launch_check_tracking_permission"; // Metadata: 0x00AE0AC2
			public const string REQUEST_TRACKING_PERMISSION = "launch_request_tracking_permission"; // Metadata: 0x00AE0AE6
		}
	
		public static class LaunchInfo // TypeDefIndex: 8594
		{
			// Fields
			public const string ID = "id"; // Metadata: 0x00AE0B0C
			public const string TITLE = "title"; // Metadata: 0x00AE0B12
			public const string CONTENT = "content"; // Metadata: 0x00AE0B1B
		}
	
		public static class Special // TypeDefIndex: 8595
		{
			// Fields
			public const string IS_SUPPORT_APPLE_LOGIN = "special_support_apple_login"; // Metadata: 0x00AE0B26
			public const string CHECK_APPLE_ACCOUNT_AUTHORIZED_STATE = "special_check_apple_account_authorized_state"; // Metadata: 0x00AE0B45
			public const string APPLE_LOGIN = "special_apple_login"; // Metadata: 0x00AE0B75
		}
	
		public static class Adjust // TypeDefIndex: 8596
		{
			// Fields
			public const string INIT_ADJUST = "adjust_init_adjust"; // Metadata: 0x00AE0B8C
			public const string TRACK_EVENT = "adjust_track_event"; // Metadata: 0x00AE0BA2
			public const string ADD_SESSION_CALLBACK_PARAMETER = "adjust_add_session_callback_parameter"; // Metadata: 0x00AE0BB8
			public const string REMOVE_SESSION_CALLBACK_PARAMETER = "adjust_remove_session_callback_parameter"; // Metadata: 0x00AE0BE1
			public const string RESET_SESSION_CALLBACK_PARAMETER = "adjust_reset_session_callback_parameter"; // Metadata: 0x00AE0C0D
			public const string ADD_SESSION_PARTNER_PARAMETER = "adjust_add_session_partner_parameter"; // Metadata: 0x00AE0C38
			public const string REMOVE_SESSION_PARTNER_PARAMETER = "adjust_remove_session_partner_parameter"; // Metadata: 0x00AE0C60
			public const string RESET_SESSION_PARTNER_PARAMETER = "adjust_reset_session_partner_parameter"; // Metadata: 0x00AE0C8B
			public const string SET_ENABLED = "adjust_set_enabled"; // Metadata: 0x00AE0CB5
			public const string SET_OFFLINE_MODE = "adjust_set_offline_mode"; // Metadata: 0x00AE0CCB
			public const string GDPR_FORGET_ME = "adjust_gdpr_forget_me"; // Metadata: 0x00AE0CE6
			public const string ADJUST_IDFA = "adjust_idfa"; // Metadata: 0x00AE0CFF
			public const string ADJUST_DEVICEID = "adjust_adid"; // Metadata: 0x00AE0D0E
			public const string ADJUST_GOOGLE_ADID = "adjust_get_google_adId"; // Metadata: 0x00AE0D1D
			public const string ADJUST_AMAZON_ADID = "adjust_get_amazon_adId"; // Metadata: 0x00AE0D37
			public const string ADJUST_GET_ATTRIBUTION = "adjust_get_attribution"; // Metadata: 0x00AE0D51
			public const string ADJUST_SET_PUSH_TOKEN = "adjust_set_push_token"; // Metadata: 0x00AE0D6B
		}
	
		public static class Report // TypeDefIndex: 8597
		{
			// Fields
			public const string SET_INFO = "report_set_info"; // Metadata: 0x00AE0D84
		}
	
		public static class Ad // TypeDefIndex: 8598
		{
			// Fields
			public const string TRACK_EVENT = "ad_track_event"; // Metadata: 0x00AE0D97
			public const string SET_DEFAULT_EVENT_PARAMETERS = "ad_set_default_event_parameters"; // Metadata: 0x00AE0DA9
			public const string SET_USER_PROPERTY = "ad_set_user_property"; // Metadata: 0x00AE0DCC
			public const string SET_USER_ID = "ad_set_user_id"; // Metadata: 0x00AE0DE4
			public const string SET_ANALYTICS_COLLECTION_ENABLED = "ad_set_analytics_collection_enabled"; // Metadata: 0x00AE0DF6
		}
	
		public static class Crash // TypeDefIndex: 8599
		{
			// Fields
			public const string SET_CUSTEOM_KEY = "crash_set_custom_key"; // Metadata: 0x00AE0E1D
			public const string SET_USER_ID = "crash_set_user_id"; // Metadata: 0x00AE0E35
			public const string APPEND_LOG = "crash_append_log"; // Metadata: 0x00AE0E4A
			public const string ENABLE_REPORT = "crash_set_enable"; // Metadata: 0x00AE0E5E
			public const string DELETE_UNSENT_EVENT = "crash_delete_unsent_event"; // Metadata: 0x00AE0E72
		}
	
		public static class EnvType // TypeDefIndex: 8600
		{
			// Fields
			public const string PROD_CN = "0"; // Metadata: 0x00AE0E8F
			public const string TEST_CN = "1"; // Metadata: 0x00AE0E94
			public const string PROD_OVERSEA = "2"; // Metadata: 0x00AE0E99
			public const string TEST_OVERSEA = "3"; // Metadata: 0x00AE0E9E
			public const string PROD_CN_PRE = "4"; // Metadata: 0x00AE0EA3
			public const string PROD_OVERSEA_PRE = "5"; // Metadata: 0x00AE0EA8
			public const string PET_CN = "8"; // Metadata: 0x00AE0EAD
			public const string BETA_CN = "9"; // Metadata: 0x00AE0EB2
			public const string BETA_PRE_CN = "10"; // Metadata: 0x00AE0EB7
			public const string BETA_OVERSEA = "11"; // Metadata: 0x00AE0EBD
			public const string HOTFIX_CN = "19"; // Metadata: 0x00AE0EC3
			public const string HOTFIX_OVERSEA = "20"; // Metadata: 0x00AE0EC9
		}
	
		public static class Bool // TypeDefIndex: 8601
		{
			// Fields
			public const string FALSE = "0"; // Metadata: 0x00AE0ECF
			public const string TRUE = "1"; // Metadata: 0x00AE0ED4
		}
	
		public static class LoginType // TypeDefIndex: 8602
		{
			// Fields
			public const string ACCOUNT = "0"; // Metadata: 0x00AE0ED9
			public const string QRCODE = "1"; // Metadata: 0x00AE0EDE
		}
	
		public static class ComboConfig // TypeDefIndex: 8603
		{
			// Fields
			public const string APP_ID = "app_id"; // Metadata: 0x00AE0EE3
			public const string APP_KEY = "app_key"; // Metadata: 0x00AE0EED
		}
	
		public static class ChannelConfig // TypeDefIndex: 8604
		{
			// Fields
			public const string APP_ID = "cp_app_id"; // Metadata: 0x00AE0EF8
			public const string APP_KEY = "cp_app_key"; // Metadata: 0x00AE0F05
		}
	
		public static class GameParameters // TypeDefIndex: 8605
		{
			// Fields
			public const string GAME_BIZ = "game_biz"; // Metadata: 0x00AE0F13
			public const string GAME = "game"; // Metadata: 0x00AE0F1F
		}
	
		public static class AntiAddictionMessage // TypeDefIndex: 8606
		{
			// Fields
			public const string MESSAGE_TYPE = "msg_type"; // Metadata: 0x00AE0F27
			public const string MESSAGE = "msg"; // Metadata: 0x00AE0F33
			public const string LEVEL = "level"; // Metadata: 0x00AE0F3A
		}
	
		public static class RoleInfo // TypeDefIndex: 8607
		{
			// Fields
			public const string SERVER_ID = "server_id"; // Metadata: 0x00AE0F43
			public const string SERVER_NAME = "server_name"; // Metadata: 0x00AE0F50
			public const string ROLE_ID = "role_id"; // Metadata: 0x00AE0F5F
			public const string ROLE_NAME = "role_name"; // Metadata: 0x00AE0F6A
			public const string ROLE_LEVEL = "role_level"; // Metadata: 0x00AE0F77
			public const string VIP_LEVEL = "vip_level"; // Metadata: 0x00AE0F85
			public const string ROLE_CREATE_TIME = "role_create_time"; // Metadata: 0x00AE0F92
			public const string PROFESSION_ID = "profession_id"; // Metadata: 0x00AE0FA6
			public const string PROFESSION = "profession"; // Metadata: 0x00AE0FB7
			public const string GENDER = "gender"; // Metadata: 0x00AE0FC5
			public const string POWER = "power"; // Metadata: 0x00AE0FCF
			public const string BALANCE = "balance"; // Metadata: 0x00AE0FD8
			public const string PARTY_ID = "party_id"; // Metadata: 0x00AE0FE3
			public const string PARTY_NAME = "party_name"; // Metadata: 0x00AE0FEF
			public const string PARTY_ROLE_ID = "party_role_id"; // Metadata: 0x00AE0FFD
			public const string PARTY_ROLE_NAME = "party_role_name"; // Metadata: 0x00AE100E
		}
	
		public static class PayInfo // TypeDefIndex: 8608
		{
			// Fields
			public const string AMOUNT = "amount"; // Metadata: 0x00AE1021
			public const string ORDER_ID = "order_id"; // Metadata: 0x00AE102B
			public const string PRODUCT_NAME = "product_name"; // Metadata: 0x00AE1037
			public const string PRODUCT_ID = "product_id"; // Metadata: 0x00AE1047
			public const string PRODUCT_DESC = "product_desc"; // Metadata: 0x00AE1055
			public const string NOTIFY_URL = "notify_url"; // Metadata: 0x00AE1065
			public const string CURRENCY = "currency"; // Metadata: 0x00AE1073
			public const string COUNTRY = "country"; // Metadata: 0x00AE107F
			public const string EXPEND = "expend"; // Metadata: 0x00AE108A
			public const string NUM = "num"; // Metadata: 0x00AE1094
			public const string PRICE_TIER = "price_tier"; // Metadata: 0x00AE109B
			public const string ACCOUNT = "account"; // Metadata: 0x00AE10A9
			public const string TOKEN = "token"; // Metadata: 0x00AE10B4
			public const string SERVER_ID = "server_id"; // Metadata: 0x00AE10BD
			public const string ROLE_ID = "role_id"; // Metadata: 0x00AE10CA
			public const string PRICE_SYMBOL = "price_symbol"; // Metadata: 0x00AE10D5
			public const string DATA = "data"; // Metadata: 0x00AE10E5
		}
	
		public static class ProductInfo // TypeDefIndex: 8609
		{
			// Fields
			public const string COUNTRY_CODE = "countryCode"; // Metadata: 0x00AE10ED
			public const string CURRENCY_CODE = "currencyCode"; // Metadata: 0x00AE10FC
			public const string CURRENCY_SYMBOL = "currencySymbol"; // Metadata: 0x00AE110C
			public const string PRODUCT_DESC = "localizedDescription"; // Metadata: 0x00AE111E
			public const string PRODUCT_NAME = "localizedTitle"; // Metadata: 0x00AE1136
			public const string PRICE = "price"; // Metadata: 0x00AE1148
			public const string PRICE_TIER = "priceTier"; // Metadata: 0x00AE1151
			public const string PRODUCT_ID = "productIdentifier"; // Metadata: 0x00AE115E
			public const string SHOW_PRICE = "showPrice"; // Metadata: 0x00AE1173
		}
	
		public static class AccountInfo // TypeDefIndex: 8610
		{
			// Fields
			public const string UID = "uid"; // Metadata: 0x00AE1180
			public const string TOKEN = "token"; // Metadata: 0x00AE1187
			public const string ACCOUNT = "account"; // Metadata: 0x00AE1190
			public const string PASSWORD = "password"; // Metadata: 0x00AE119B
		}
	
		public static class PushInfo // TypeDefIndex: 8611
		{
			// Fields
			public const string NOTIFICATION_ID = "notification_id"; // Metadata: 0x00AE11A7
			public const string TITLE = "title"; // Metadata: 0x00AE11BA
			public const string CONTENT = "content"; // Metadata: 0x00AE11C3
			public const string TIME = "time"; // Metadata: 0x00AE11CE
			public const string EXT = "ext"; // Metadata: 0x00AE11D6
		}
	
		public static class DownloadInfo // TypeDefIndex: 8612
		{
			// Fields
			public const string URL = "url"; // Metadata: 0x00AE11DD
			public const string PATH = "path"; // Metadata: 0x00AE11E4
			public const string IDENTIFIER = "identifier"; // Metadata: 0x00AE11EC
			public const string TOTAL_FILE_SIZE = "totalFileSize"; // Metadata: 0x00AE11FA
			public const string TMP_FILE_SIZE = "tmpFileSize"; // Metadata: 0x00AE120B
			public const string DOWNLOAD_TIME = "downloadTime"; // Metadata: 0x00AE121A
			public const string EXPECTED_TIME = "expectedTime"; // Metadata: 0x00AE122A
			public const string PROGRESS = "progress"; // Metadata: 0x00AE123A
			public const string SPEED = "speed"; // Metadata: 0x00AE1246
			public const string STATE = "state"; // Metadata: 0x00AE124F
			public const string ERROR_CODE = "errorCode"; // Metadata: 0x00AE1258
			public const string ERROR_MESSAGE = "errorMessage"; // Metadata: 0x00AE1265
			public const string NOTIFICATION_TITLE = "title"; // Metadata: 0x00AE1275
			public const string NOTIFICATION_CONTENT = "content"; // Metadata: 0x00AE127E
			public const string ID = "id"; // Metadata: 0x00AE1289
			public const string TITLE = "title"; // Metadata: 0x00AE128F
			public const string CONTENT = "content"; // Metadata: 0x00AE1298
			public const string WIFI = "wifi"; // Metadata: 0x00AE12A3
			public const string CELLULAR = "cellular"; // Metadata: 0x00AE12AB
			public const string NONE = "none"; // Metadata: 0x00AE12B7
		}
	
		public static class ShareInfo // TypeDefIndex: 8613
		{
			// Fields
			public const string PLATFORM = "platform"; // Metadata: 0x00AE12BF
			public const string TYPE = "type"; // Metadata: 0x00AE12CB
			public const string TITLE = "title"; // Metadata: 0x00AE12D3
			public const string CONTENT = "content"; // Metadata: 0x00AE12DC
			public const string IMAGES = "images"; // Metadata: 0x00AE12E7
			public const string URL = "url"; // Metadata: 0x00AE12F1
			public const string SHARE_BY_NATIVE = "share_by_native"; // Metadata: 0x00AE12F8
			public const string URL_TITLE = "url_title"; // Metadata: 0x00AE130B
			public const string POST = "post"; // Metadata: 0x00AE1318
			public const string FORUM = "forum"; // Metadata: 0x00AE1320
			public const string TOPICS = "topics"; // Metadata: 0x00AE1329
		}
	
		public static class SharePlatform // TypeDefIndex: 8614
		{
			// Fields
			public const string SINA_WEIBO = "1"; // Metadata: 0x00AE1333
			public const string QQ_FRIENDS = "2"; // Metadata: 0x00AE1338
			public const string WECHAT_FRIENDS = "3"; // Metadata: 0x00AE133D
			public const string TWITTER = "4"; // Metadata: 0x00AE1342
			public const string KAKAO_STORY = "5"; // Metadata: 0x00AE1347
			public const string QQ_ZONE = "6"; // Metadata: 0x00AE134C
			public const string WECHAT_TIMELINE = "7"; // Metadata: 0x00AE1351
			public const string FACEBOOK = "8"; // Metadata: 0x00AE1356
			public const string INSTAGRAM = "9"; // Metadata: 0x00AE135B
			public const string WHATSAPP = "10"; // Metadata: 0x00AE1360
			public const string MESSENGER = "11"; // Metadata: 0x00AE1366
			public const string HYPERION_POST = "12"; // Metadata: 0x00AE136C
			public const string HYPERION_IMAGE = "13"; // Metadata: 0x00AE1372
			public const string HYPERION_COMMENT = "14"; // Metadata: 0x00AE1378
		}
	
		public static class ShareType // TypeDefIndex: 8615
		{
			// Fields
			public const string TEXT = "1"; // Metadata: 0x00AE137E
			public const string IMAGE = "2"; // Metadata: 0x00AE1383
			public const string WEB_PAGE = "3"; // Metadata: 0x00AE1388
		}
	
		public static class ShareCode // TypeDefIndex: 8616
		{
			// Fields
			public const int NOT_INSTALLED = -3; // Metadata: 0x00AE138D
		}
	
		public static class PsStoreIconPosition // TypeDefIndex: 8617
		{
			// Fields
			public const string CENTER = "0"; // Metadata: 0x00AE1391
			public const string LEFT = "1"; // Metadata: 0x00AE1396
			public const string RIGHT = "2"; // Metadata: 0x00AE139B
		}
	
		public static class JoyPadType // TypeDefIndex: 8618
		{
			// Fields
			public const string DEFAULT = "0"; // Metadata: 0x00AE13A0
			public const string SONY = "1"; // Metadata: 0x00AE13A5
			public const string XBOX = "2"; // Metadata: 0x00AE13AA
		}
	
		public static class AdjustConfigInfo // TypeDefIndex: 8619
		{
			// Fields
			public const string IS_PRODUCT = "is_product"; // Metadata: 0x00AE13AF
			public const string START_DELAY = "start_delay"; // Metadata: 0x00AE13BD
			public const string ENABLE_BUFFER = "enable_buffer"; // Metadata: 0x00AE13CC
			public const string SIGN = "sign"; // Metadata: 0x00AE13DD
			public const string ENABLE_BACKGROUND = "enable_background"; // Metadata: 0x00AE13E5
			public const string DEFAULT_TRACKER = "default_tracker"; // Metadata: 0x00AE13FA
			public const string ENABLE_LOG = "enable_log"; // Metadata: 0x00AE140D
		}
	
		public static class AdjustEventInfo // TypeDefIndex: 8620
		{
			// Fields
			public const string EVENT_TOKEN = "event_token"; // Metadata: 0x00AE141B
			public const string REVENUE = "revenue"; // Metadata: 0x00AE142A
			public const string CURRENCY = "currency"; // Metadata: 0x00AE1435
			public const string ORDER_ID = "order_id"; // Metadata: 0x00AE1441
			public const string ADJ_CALLBACK = "adj_callback"; // Metadata: 0x00AE144D
			public const string PARTNER_PARAMETER = "partner_parameter"; // Metadata: 0x00AE145D
			public const string CALLBACK_ID = "callback_id"; // Metadata: 0x00AE1472
		}
	
		public static class AdjustAttributionInfo // TypeDefIndex: 8621
		{
			// Fields
			public const string TRACKER_TOKEN = "tracker_token"; // Metadata: 0x00AE1481
			public const string TRACKER_NAME = "tracker_name"; // Metadata: 0x00AE1492
			public const string NETWORK = "network"; // Metadata: 0x00AE14A2
			public const string CAMPAIGN = "campaign"; // Metadata: 0x00AE14AD
			public const string ADGROUP = "adgroup"; // Metadata: 0x00AE14B9
			public const string CREATIVE = "creative"; // Metadata: 0x00AE14C4
			public const string CLICK_LABEL = "click_label"; // Metadata: 0x00AE14D0
			public const string DEVICEID = "adid"; // Metadata: 0x00AE14DF
		}
	
		public static class AdjustEventResultInfo // TypeDefIndex: 8622
		{
			// Fields
			public const string SUCCEED = "succeed"; // Metadata: 0x00AE14E7
			public const string DEVICEID = "adid"; // Metadata: 0x00AE14F2
			public const string MESSAGE = "message"; // Metadata: 0x00AE14FA
			public const string TIMESTAMP = "timestamp"; // Metadata: 0x00AE1505
			public const string EVENT_TOKEN = "event_token"; // Metadata: 0x00AE1512
			public const string CALLBACK_ID = "callback_id"; // Metadata: 0x00AE1521
			public const string JSON_RESPONSE = "json_response"; // Metadata: 0x00AE1530
			public const string WILL_RETRY = "will_retry"; // Metadata: 0x00AE1541
		}
	
		public static class AdjustSessionResultInfo // TypeDefIndex: 8623
		{
			// Fields
			public const string SUCCEED = "succeed"; // Metadata: 0x00AE154F
			public const string DEVICEID = "adid"; // Metadata: 0x00AE155A
			public const string MESSAGE = "message"; // Metadata: 0x00AE1562
			public const string TIMESTAMP = "timestamp"; // Metadata: 0x00AE156D
			public const string JSON_RESPONSE = "json_response"; // Metadata: 0x00AE157A
			public const string WILL_RETRY = "will_retry"; // Metadata: 0x00AE158B
		}
	
		public static class AdjustDeepLinkResultInfo // TypeDefIndex: 8624
		{
			// Fields
			public const string DEEP_LINK_DATA = "deep_link_data"; // Metadata: 0x00AE1599
		}
	
		public static class Notification // TypeDefIndex: 8625
		{
			// Fields
			public const string SHOW_DIALOG = "show"; // Metadata: 0x00AE15AB
			public const string HIDE_DIALOG = "hide"; // Metadata: 0x00AE15B3
			public const string LOGOUT = "logout"; // Metadata: 0x00AE15BB
			public const string UNIWEBVIEW = "uniwebview"; // Metadata: 0x00AE15C5
			public const string SHOW_POP_NOTICE = "show_pop_notice"; // Metadata: 0x00AE15D3
			public const string BIND_MOBILE_ACCOUNT = "bind_mobile_account"; // Metadata: 0x00AE15E6
			public const string REAL_NAME_ACCOUNT = "real_name_account"; // Metadata: 0x00AE15FD
			public const string RECEIVE_REMOTE_PUSH = "receive_remote_push"; // Metadata: 0x00AE1612
			public const string RECEIVE_LOCAL_PUSH = "receive_local_push"; // Metadata: 0x00AE1629
			public const string DOWNLOAD_ALL_PROGRESS = "download_all_progress"; // Metadata: 0x00AE163F
			public const string DOWNLOAD_STATE_CHANGE = "download_state_change"; // Metadata: 0x00AE1658
			public const string DOWNLOAD_OVER = "download_over"; // Metadata: 0x00AE1671
			public const string GUEST_BIND_UID = "guest_bind_uid"; // Metadata: 0x00AE1682
			public const string DEEP_LINK = "deep_link"; // Metadata: 0x00AE1694
			public const string ATTRIBUTION_CHANGED = "attribution_changed"; // Metadata: 0x00AE16A1
			public const string TRACK_EVENT_RESULT = "track_event_result"; // Metadata: 0x00AE16B8
			public const string TRACK_SESSION_RESULT = "track_session_result"; // Metadata: 0x00AE16CE
			public const string NOTICE_RED_POINT = "notice_red_point"; // Metadata: 0x00AE16E6
			public const string ANTI_ADDICTION = "anti_addiction"; // Metadata: 0x00AE16FA
			public const string PS_FRIEND_UPDATE = "ps_friend_update"; // Metadata: 0x00AE170C
			public const string PS_BLOCK_UPDATE = "ps_block_update"; // Metadata: 0x00AE1720
		}
	
		public static class Model // TypeDefIndex: 8626
		{
			// Fields
			public const string LOGIN = "login"; // Metadata: 0x00AE1733
			public const string BIND = "bind"; // Metadata: 0x00AE173C
			public const string PAY = "pay"; // Metadata: 0x00AE1744
		}
	
		public static class ReportInfo // TypeDefIndex: 8627
		{
			// Fields
			public const string APP_ID = "applicationId"; // Metadata: 0x00AE174B
			public const string APP_NAME = "applicationName"; // Metadata: 0x00AE175C
			public const string CLIENT_IP = "ip"; // Metadata: 0x00AE176F
			public const string CLIENT_VERSION = "client_version"; // Metadata: 0x00AE1775
			public const string REGION = "region"; // Metadata: 0x00AE1787
			public const string REGISTER_CPS = "register_cps"; // Metadata: 0x00AE1791
			public const string CURRENT_CPS = "current_cps"; // Metadata: 0x00AE17A1
			public const string UID = "uid"; // Metadata: 0x00AE17B0
			public const string TAG = "tag"; // Metadata: 0x00AE17B7
		}
	
		public static class AdInfo // TypeDefIndex: 8628
		{
			// Fields
			public const string EVENT = "event"; // Metadata: 0x00AE17BE
			public const string EXT = "ext"; // Metadata: 0x00AE17C7
			public const string NAME = "name"; // Metadata: 0x00AE17CE
			public const string PROPERTY = "property"; // Metadata: 0x00AE17D6
		}
	
		public static class CrashInfo // TypeDefIndex: 8629
		{
			// Fields
			public const string KEY = "key"; // Metadata: 0x00AE17E2
			public const string VALUE = "value"; // Metadata: 0x00AE17E9
		}
	
		public static class UserAgreementParameters // TypeDefIndex: 8630
		{
			// Fields
			public const string ENV = "env"; // Metadata: 0x00AE17F2
			public const string LANGUAGE = "language"; // Metadata: 0x00AE17F9
		}
	
		// Constructors
		public MHYSDKC() {} // 0x00000001859E10B0-0x00000001859E1110
	}
}
