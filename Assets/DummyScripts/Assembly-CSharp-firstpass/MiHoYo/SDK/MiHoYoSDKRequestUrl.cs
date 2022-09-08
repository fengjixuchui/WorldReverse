/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public static class MiHoYoSDKRequestUrl // TypeDefIndex: 8646
	{
		// Fields
		public static string AccountRSAKey; // 0x00
		public static string DEFAULT_PREFIX; // 0x08
		public static string game_biz_path; // 0x10
		public static string domainPrefix; // 0x18
		private static string apiSdkDomain; // 0x20
		private static string gameApiDomain; // 0x28
		private static string userDomain; // 0x30
		private static string logUploadDomain; // 0x38
		private static string multiLanguageDomain; // 0x40
		private static string activityDomain; // 0x48
		private static string facebookDomain; // 0x50
		private static string twitterDomain; // 0x58
		private static string newLogUploadDomain; // 0x60
		private static string paypalDomain; // 0x68
		private static string sdkCDNDomain; // 0x70
		private static string preloadWebDomain; // 0x78
		private static string configDomain; // 0x80
		private static string accountDomain; // 0x88
		private static RequestUrl _requestType; // 0x90
	
		// Constructors
		static MiHoYoSDKRequestUrl() {} // 0x00000001859650C0-0x00000001859652D0
	
		// Methods
		// [XID] // 0x0000000189A31120-0x0000000189A31140
		public static RequestUrl GetUrl(EnvType envType) => default; // 0x0000000185963000-0x00000001859632E0
		// [XID] // 0x0000000189A38DF0-0x0000000189A38E10
		private static RequestUrl Init(EnvType envType) => default; // 0x00000001859632E0-0x0000000185964F20
		// [XID] // 0x00000001898FA860-0x00000001898FA880
		private static string GetGameRelativeURL(string path) => default; // 0x00000001859629C0-0x0000000185962BF0
		// [XID] // 0x00000001896D7FF0-0x00000001896D8010
		public static void GetGameBiz(string game_biz) {} // 0x0000000185962880-0x00000001859629C0
		// [XID] // 0x0000000189A4F250-0x0000000189A4F270
		public static void GetDomainPrefix(string domain_prefix) {} // 0x0000000185962700-0x0000000185962880
		// [XID] // 0x0000000189A56860-0x0000000189A56880
		public static void PreProcess(EnvType env) {} // 0x0000000185964F20-0x00000001859650C0
		// [XID] // 0x000000018974C5A0-0x000000018974C5C0
		private static void CreateUrl() {} // 0x00000001859611B0-0x0000000185962440
		// [XID] // 0x0000000189A65CC0-0x0000000189A65CE0
		private static string GetLuckycatDomain(string game_biz) => default; // 0x0000000185962D50-0x0000000185963000
		// [XID] // 0x0000000189A6D2D0-0x0000000189A6D2F0
		public static string GetCreateOrderUrl() => default; // 0x00000001859625A0-0x0000000185962700
		// [XID] // 0x00000001898DB500-0x00000001898DB520
		public static string GetCheckOrderUrl() => default; // 0x0000000185962440-0x00000001859625A0
		// [XID] // 0x0000000189A7C610-0x0000000189A7C630
		public static string GetListPayPlatUrl() => default; // 0x0000000185962BF0-0x0000000185962D50
	}
}
