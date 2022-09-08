/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class Adjust : MonoBehaviour // TypeDefIndex: 6721
	{
		// Fields
		private static Adjust _instance; // 0x00
		private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor."; // Metadata: 0x00ADDBE1
		private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the \'start\' method."; // Metadata: 0x00ADDC0D
		private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps."; // Metadata: 0x00ADDC57
		public bool startManually; // 0x18
		public bool eventBuffering; // 0x19
		public bool sendInBackground; // 0x1A
		public bool launchDeferredDeeplink; // 0x1B
		public string appToken; // 0x20
		public AdjustLogLevel logLevel; // 0x28
		public AdjustEnvironment environment; // 0x2C
	
		// Properties
		public static Adjust Instance { /* [XID] */ /* 0x000000018964CBA0-0x000000018964CBC0 */ get => default; } // 0x00000001866940D0-0x00000001866943B0 
	
		// Constructors
		public Adjust() {} // 0x0000000186693410-0x0000000186693490
		static Adjust() {} // 0x00000001866933B0-0x0000000186693410
	
		// Methods
		// [XID] // 0x0000000189653FF0-0x0000000189654010
		private void Awake() {} // 0x0000000186692E60-0x0000000186693050
		// [XID] // 0x0000000189B158A0-0x0000000189B158C0
		private void OnApplicationPause(bool pauseStatus) {} // 0x00000001866931C0-0x00000001866932C0
		// [XID] // 0x00000001897CFE30-0x00000001897CFE50
		public void Init() {} // 0x0000000186693050-0x0000000186693120
		// [XID] // 0x0000000189B24830-0x0000000189B24850
		public static void start(AdjustConfig adjustConfig) {} // 0x0000000186694E00-0x0000000186694F30
		// [XID] // 0x0000000189B2BD60-0x0000000189B2BD80
		public static void trackEvent(AdjustEvent adjustEvent) {} // 0x0000000186695120-0x0000000186695250
		// [XID] // 0x0000000189B33240-0x0000000189B33260
		public static void setEnabled(bool enabled) {} // 0x0000000186694B30-0x0000000186694C20
		// [XID] // 0x0000000189B3AD70-0x0000000189B3AD90
		public static bool isEnabled() => default; // 0x00000001866943B0-0x00000001866944A0
		// [XID] // 0x0000000189A92D40-0x0000000189A92D60
		public static void setOfflineMode(bool enabled) {} // 0x0000000186694C20-0x0000000186694D10
		// [XID] // 0x0000000189B49F40-0x0000000189B49F60
		public static void setDeviceToken(string deviceToken) {} // 0x0000000186694A40-0x0000000186694B30
		// [XID] // 0x0000000189AA17E0-0x0000000189AA1800
		public static void gdprForgetMe() {} // 0x0000000186693840-0x0000000186693900
		// [XID] // 0x0000000189B59040-0x0000000189B59060
		public static void disableThirdPartySharing() {} // 0x0000000186693780-0x0000000186693840
		// [XID] // 0x0000000189AB0AB0-0x0000000189AB0AD0
		public static void appWillOpenUrl(string url) {} // 0x0000000186693690-0x0000000186693780
		// [XID] // 0x0000000189B67E50-0x0000000189B67E70
		public static void sendFirstPackages() {} // 0x0000000186694950-0x0000000186694A40
		// [XID] // 0x000000018970FC30-0x000000018970FC50
		public static void addSessionPartnerParameter(string key, string value) {} // 0x0000000186693590-0x0000000186693690
		// [XID] // 0x00000001896D40C0-0x00000001896D40E0
		public static void addSessionCallbackParameter(string key, string value) {} // 0x0000000186693490-0x0000000186693590
		// [XID] // 0x000000018964E120-0x000000018964E140
		public static void removeSessionPartnerParameter(string key) {} // 0x0000000186694590-0x0000000186694680
		// [XID] // 0x0000000189B85AC0-0x0000000189B85AE0
		public static void removeSessionCallbackParameter(string key) {} // 0x00000001866944A0-0x0000000186694590
		// [XID] // 0x00000001896B6D20-0x00000001896B6D40
		public static void resetSessionPartnerParameters() {} // 0x0000000186694860-0x0000000186694950
		// [XID] // 0x0000000189B94320-0x0000000189B94340
		public static void resetSessionCallbackParameters() {} // 0x0000000186694770-0x0000000186694860
		// [XID] // 0x0000000189944CD0-0x0000000189944CF0
		public static void trackAdRevenue(string source, string payload) {} // 0x0000000186694F30-0x0000000186695030
		// [XID] // 0x0000000189BA3170-0x0000000189BA3190
		public static void trackAppStoreSubscription(AdjustAppStoreSubscription subscription) {} // 0x0000000186695030-0x0000000186695120
		// [XID] // 0x0000000189BAA3C0-0x0000000189BAA3E0
		public static void trackPlayStoreSubscription(AdjustPlayStoreSubscription subscription) {} // 0x0000000186695250-0x0000000186695340
		// [XID] // 0x0000000189BB1B60-0x0000000189BB1B80
		public static void requestTrackingAuthorizationWithCompletionHandler(Action<int> statusCallback) {} // 0x0000000186694680-0x0000000186694770
		// [XID] // 0x0000000189BB8CB0-0x0000000189BB8CD0
		public static string getAdid() => default; // 0x0000000186693900-0x0000000186693A30
		// [XID] // 0x0000000189831160-0x0000000189831180
		public static AdjustAttribution getAttribution() => default; // 0x0000000186693B60-0x0000000186693C50
		// [XID] // 0x00000001896450C0-0x00000001896450E0
		public static string getWinAdid() => default; // 0x0000000186693FA0-0x00000001866940D0
		// [XID] // 0x0000000189BCFC10-0x0000000189BCFC30
		public static string getIdfa() => default; // 0x0000000186693D40-0x0000000186693E70
		// [XID] // 0x0000000189BD7090-0x0000000189BD70B0
		public static string getSdkVersion() => default; // 0x0000000186693E70-0x0000000186693FA0
		[Obsolete] // 0x0000000189BDED50-0x0000000189BDEDA0
		// [XID] // 0x0000000189BDED50-0x0000000189BDEDA0
		public static void setReferrer(string referrer) {} // 0x0000000186694D10-0x0000000186694E00
		// [XID] // 0x00000001895EFF40-0x00000001895EFF60
		public static void getGoogleAdId(Action<string> onDeviceIdsRead) {} // 0x0000000186693C50-0x0000000186693D40
		// [XID] // 0x00000001899F4B00-0x00000001899F4B20
		public static string getAmazonAdId() => default; // 0x0000000186693A30-0x0000000186693B60
		// [XID] // 0x00000001895FEBF0-0x00000001895FEC10
		private static bool IsEditor() => default; // 0x0000000186693120-0x00000001866931C0
		// [XID] // 0x0000000189BD10F0-0x0000000189BD1110
		public static void SetTestOptions(Dictionary<string, string> testOptions) {} // 0x00000001866932C0-0x00000001866933B0
	}
}
