/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class BundleDownloadGlobalSetting // TypeDefIndex: 11602
{
	// Fields
	internal const string DOWNLOAD_KEY = "enable_download"; // Metadata: 0x00AE9AE3
	internal const string BRANCH_KEY = "variance"; // Metadata: 0x00AE9AF6
	internal const string RES_URL_KEY = "res_url"; // Metadata: 0x00AE9B02
	internal const string DATA_URL_KEY = "data_url"; // Metadata: 0x00AE9B0D
	internal const string SILENCE_URL_KEY = "silence_url"; // Metadata: 0x00AE9B19
	internal const string BASE_AUDIO_LANG_KEY = "base_audio_lang"; // Metadata: 0x00AE9B28
	internal const string BASE_TEXT_LANG_KEY = "base_text_lang"; // Metadata: 0x00AE9B3B
	internal const string PKG_TYPE_KEY = "package_type"; // Metadata: 0x00AE9B4D
	internal const string BUNDLE_SETTINGS_FILE = "asb_settings.json"; // Metadata: 0x00AE9B5D
	internal const string BUNDLE_EXTENSION = ".asb"; // Metadata: 0x00AE9B72
	internal const string TEST_WRITABLE_FILE = "test_file"; // Metadata: 0x00AE9B7A
	internal const string EXTERNAL_DOWNLOAD_OVER = "external_download_over"; // Metadata: 0x00AE9B87
	internal const string ASSET_INDEX_FILE_NAME = "asset_index"; // Metadata: 0x00AE9BA1
	internal const string RELEASE_ASSET_INDEX_FILE_NAME = "release_asset_index"; // Metadata: 0x00AE9BB0
	internal const string MEDIUM_ASSET_INDEX_FILE_NAME = "medium_asset_index"; // Metadata: 0x00AE9BC7
	internal const string RELEASE_MEDIUM_ASSET_INDEX_FILE_NAME = "release_medium_asset_index"; // Metadata: 0x00AE9BDD
	internal const string RES_REVISION_FILE_NAME = "res_revision"; // Metadata: 0x00AE9BFB
	internal const string DATA_REVISION_FILE_NAME = "data_revision"; // Metadata: 0x00AE9C0B
	internal const string SILENCE_REVISION_FILE_NAME = "silence_revision"; // Metadata: 0x00AE9C1C
	internal const string MEDIUM_DOWNLOADING_MARK = "medium_downloading_mark"; // Metadata: 0x00AE9C30
	internal const string BASE_REVISION_FILE_NAME = "base_revision"; // Metadata: 0x00AE9C4B
	internal const string ENGINE_REVISION_FILE_NAME = "EngineRevision.txt"; // Metadata: 0x00AE9C5C
	internal const string BASE_RES_VERSION_HASH_FILE_NAME = "base_res_version_hash"; // Metadata: 0x00AE9C72
	internal const string SCRIPT_VERSION_FILE_NAME_IN_PERSIST_DIR = "ScriptVersion"; // Metadata: 0x00AE9C8B
	internal const string CHANNEL_NAME_FILE_NAME_IN_PERSIST_DIR = "ChannelName"; // Metadata: 0x00AE9C9C
	internal const string TEXT_LANG_FILE_NAME = "text_lang"; // Metadata: 0x00AE9CAB
	internal const string AUDIO_LANG_FILE_NAME = "audio_lang_14"; // Metadata: 0x00AE9CB8
	internal const string ORIGIN_REVISION_FILE_NAME = "origin_revision"; // Metadata: 0x00AE9CC9
	internal const string DATA_VERSION_FILE_NAME = "data_versions"; // Metadata: 0x00AE9CDC
	internal const string REMOTE_AUDIO_VERSION_FILE_NAME = "audio_versions"; // Metadata: 0x00AE9CED
	internal const string REMOTE_VIDEO_VERSION_FILE_NAME = "video_versions"; // Metadata: 0x00AE9CFF
	internal const string PERSIST_AUDIO_VERSION_FILE_NAME = "audio_versions"; // Metadata: 0x00AE9D11
	internal const string PERSIST_VIDEO_VERSION_FILE_NAME = "video_versions"; // Metadata: 0x00AE9D23
	internal const string STREAMING_AUDIO_VERSION_FILE_NAME = "audio_versions_streaming"; // Metadata: 0x00AE9D35
	internal const string STREAMING_VIDEO_VERSION_FILE_NAME = "video_versions_streaming"; // Metadata: 0x00AE9D51
	internal const string LOCAL_RES_VERSION_FILE_NAME_IN_STREAMING_DIR = "res_versions_streaming"; // Metadata: 0x00AE9D6D
	internal const string LOCAL_DATA_VERSION_FILE_NAME_IN_STREAMING_DIR = "data_versions_streaming"; // Metadata: 0x00AE9D87
	internal const string LOCAL_SLIENCE_DATA_VERSION_FILE_NAME_IN_STREAMING_DIR = "silence_versions_streaming"; // Metadata: 0x00AE9DA2
	internal const string LOCAL_RES_VERSION_FILE_NAME_IN_PERSIST_DIR = "res_versions_persist"; // Metadata: 0x00AE9DC0
	internal const string LOCAL_DATA_VERSION_FILE_NAME_IN_PERSIST_DIR = "data_versions_persist"; // Metadata: 0x00AE9DD8
	internal const string LOCAL_SILENCE_DATA_VERSION_FILE_NAME_IN_PERSIST_DIR = "silence_data_versions_persist"; // Metadata: 0x00AE9DF1
	internal const string REMOTE_STREAMING_RES_VERSION_FILE_NAME_ON_NETDISK = "res_versions_streaming"; // Metadata: 0x00AE9E12
	internal const string REMOTE_MEDIUM_RES_VERSION_FILE_NAME_ON_NETDISK = "res_versions_medium"; // Metadata: 0x00AE9E2C
	internal const string REMOTE_EXTERNAL_RES_VERSION_FILE_NAME_ON_NETDISK = "res_versions_external"; // Metadata: 0x00AE9E43
	internal const string REMOTE_RELEASE_STREAMING_RES_VERSION_FILE_NAME_ON_NETDISK = "release_res_versions_streaming"; // Metadata: 0x00AE9E5C
	internal const string REMOTE_RELEASE_MEDIUM_RES_VERSION_FILE_NAME_ON_NETDISK = "release_res_versions_medium"; // Metadata: 0x00AE9E7E
	internal const string REMOTE_RELEASE_EXTERNAL_RES_VERSION_FILE_NAME_ON_NETDISK = "release_res_versions_external"; // Metadata: 0x00AE9E9D
	internal const string REMOTE_RES_VERSION_FILE_NAME_IN_PERSIST_DIR = "res_versions_remote"; // Metadata: 0x00AE9EBE
	internal const string REMOTE_DATA_VERSION_FILE_NAME_IN_PERSIST_DIR = "data_versions_remote"; // Metadata: 0x00AE9ED5
	internal const string REMOTE_SILENCE_DATA_VERSION_FILE_NAME_IN_PERSIST_DIR = "silence_data_versions_remote"; // Metadata: 0x00AE9EED
	internal const string SVC_CATALOG_FILE_NAME = "svc_catalog"; // Metadata: 0x00AE9F0D
	internal const string CTABLE_FILE_NAME = "ctable.dat"; // Metadata: 0x00AE9F1C
	internal const string CTABLE_STREAMING_FILE_NAME = "ctable_streaming.dat"; // Metadata: 0x00AE9F2A
	internal const string BAD_BUNDLE_FILE_NAME = "bad_bundle"; // Metadata: 0x00AE9F42
	internal const string DATA_GENERAL_PLATFORM = "General"; // Metadata: 0x00AE9F50
	internal const string BUNDLE_DIR_NAME = "AssetBundles"; // Metadata: 0x00AE9F5B
	internal const string BLOCK_DIR_NAME = "blocks"; // Metadata: 0x00AE9F6B
	internal const string PERSIST_AUDIO_DIR_NAME = "AudioAssets"; // Metadata: 0x00AE9F75
	internal const string REMOTE_MEDIUM_AUDIO_DIR_NAME = "MediumAudioAssets"; // Metadata: 0x00AE9F84
	internal const string PERSIST_VIDEO_DIR_NAME = "VideoAssets"; // Metadata: 0x00AE9F99
	internal const string STREAMING_AUDIO_DIR_NAME = "Audio"; // Metadata: 0x00AE9FA8
	internal const string STREAMING_VIDEO_DIR_NAME = "VideoAssets"; // Metadata: 0x00AE9FB1
	internal const string REMOTE_ASSET_DIRECTORY = "/output_{0}/client/{1}/"; // Metadata: 0x00AE9FC0
	internal const string REMOTE_ASSET_SUFFIX_DIRECTORY = "/output_{0}_{1}/client/{2}/"; // Metadata: 0x00AE9FDB
	internal const string REMOTE_SILENCE_DATA_DIRECTORY = "/output_{0}/client_silence/{1}/"; // Metadata: 0x00AE9FFA
	internal const string REMOTE_SILENCE_DATA_SUFFIX_DIRECTORY = "/output_{0}_{1}/client_silence/{2}/"; // Metadata: 0x00AEA01D
	internal const string CACHE_FILE_NAME = "cache_versions"; // Metadata: 0x00AEA044
	internal const string TEMP_ASSET_INDEX_FILE_NAME = "temp_asset_index"; // Metadata: 0x00AEA056
	internal const string TEMP_SVC_CATALOG_FILE_NAME = "temp_svc_catalog"; // Metadata: 0x00AEA06A
	internal const string HTTPS_FORMAT = "https://{0}/{1}"; // Metadata: 0x00AEA07E
	public const string HTTPS_HEAD = "https://"; // Metadata: 0x00AEA091
	internal const string QUIT = "QUIT"; // Metadata: 0x00AEA09D
	internal const string RETRY = "RETRY"; // Metadata: 0x00AEA0A5
	internal const string YES = "YES"; // Metadata: 0x00AEA0AE
	internal const string NO = "NO"; // Metadata: 0x00AEA0B5
	internal const string VERSION = "VERSION"; // Metadata: 0x00AEA0BB
	internal const string TIP_TITLE = "TIP_TITLE"; // Metadata: 0x00AEA0C6
	internal const string CANNOT_REACH_NETWORK = "CANNOT_REACH_NETWORK"; // Metadata: 0x00AEA0D3
	internal const string CANNOT_REAL_REACH_NETWORK = "CANNOT_REAL_REACH_NETWORK"; // Metadata: 0x00AEA0EB
	internal const string WEAK_SIGNAL = "WEAK_SIGNAL"; // Metadata: 0x00AEA108
	internal const string WRITE_FAILED = "WRITE_FAILED"; // Metadata: 0x00AEA117
	internal const string NOT_ENOUGH_SPACE = "NOT_ENOUGH_SPACE"; // Metadata: 0x00AEA127
	internal const string UI_CHOOSE_UPDATE_RES = "UI_CHOOSE_UPDATE_RES"; // Metadata: 0x00AEA13B
	internal const string UI_DOWNLOAD_ERROR = "UI_DOWNLOAD_ERROR"; // Metadata: 0x00AEA153
	internal const string UI_DOWNLOAD_CANCELLED_CARRIER = "UI_DOWNLOAD_CANCELLED_CARRIER"; // Metadata: 0x00AEA168
	internal const string UI_RESET_GAME = "UI_RESET_GAME"; // Metadata: 0x00AEA189
	internal const string UI_4G_NETWORK = "UI_4G_NETWORK"; // Metadata: 0x00AEA19A
	internal const string DOWNLOAD_FINISH_NOTIFCATION_TITLE = "DOWNLOAD_FINISH_NOTIFCATION_TITLE"; // Metadata: 0x00AEA1AB
	internal const string DOWNLOAD_FINISH_NOTIFCATION_CONTENT = "DOWNLOAD_FINISH_NOTIFCATION_CONTENT"; // Metadata: 0x00AEA1D0
	internal const string DOWNLOAD_NOTIFICATION_TITLE = "TITLE_PC_GAMENAME"; // Metadata: 0x00AEA1F7
	internal const string DOWNLOADING_ASSETS = "DOWNLOADING_ASSETS"; // Metadata: 0x00AEA20C
	internal const string UI_CONFIRM_UPDATE_DATA_TITLE = "\u66F4\uFFFD"; // Metadata: 0x00AEA222
	internal const string UI_CONFIRM_UPDATE_DATA = "\u7F51\u76D8\u4E0A\u7684\u6570\u503C\u7248\u672C({0})\u4E0E"; // Metadata: 0x00AEA232
	internal const string UI_CONFIRM_UPDATE_SILENCE_DATA_TITLE = "\u66F4\u65B0"; // Metadata: 0x00AEA282
	internal const string UI_CONFIRM_UPDATE_SILENCE_DATA = "\u7F51\u76D8\u4E0A\u7684\u9759\u9ED8\u6570\u503C\u7248\u672C({0}"; // Metadata: 0x00AEA298
	internal const string AUDIO_LANG_CHINESE = "Chinese"; // Metadata: 0x00AEA2EE
	internal const string AUDIO_LANG_ENGLISH = "English(US)"; // Metadata: 0x00AEA2F9
	internal const string AUDIO_LANG_JAPANESE = "Japanese"; // Metadata: 0x00AEA308
	internal const string AUDIO_LANG_KOREAN = "Korean"; // Metadata: 0x00AEA314

	// Nested types
	public enum Phase // TypeDefIndex: 11603
	{
		Queueing = 0,
		CheckMobileEnvironment = 1,
		CheckUpdate = 2,
		PickDownloads = 3,
		DownloadingFiles = 4,
		Md5Verify = 5,
		LoadingFiles = 6,
		Finish = 7
	}
}

