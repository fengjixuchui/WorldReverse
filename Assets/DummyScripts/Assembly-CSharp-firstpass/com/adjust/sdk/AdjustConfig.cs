/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class AdjustConfig // TypeDefIndex: 6724
	{
		// Fields
		public const string AdjustAdRevenueSourceMopub = "mopub"; // Metadata: 0x00ADDD02
		public const string AdjustUrlStrategyChina = "china"; // Metadata: 0x00ADDD0B
		public const string AdjustUrlStrategyIndia = "india"; // Metadata: 0x00ADDD14
		internal string appToken; // 0x10
		internal string sceneName; // 0x18
		internal string userAgent; // 0x20
		internal string defaultTracker; // 0x28
		internal string externalDeviceId; // 0x30
		internal string urlStrategy; // 0x38
		internal long? info1; // 0x40
		internal long? info2; // 0x50
		internal long? info3; // 0x60
		internal long? info4; // 0x70
		internal long? secretId; // 0x80
		internal double? delayStart; // 0x90
		internal bool? isDeviceKnown; // 0xA0
		internal bool? sendInBackground; // 0xA2
		internal bool? eventBufferingEnabled; // 0xA4
		internal bool? allowSuppressLogLevel; // 0xA6
		internal bool? skAdNetworkHandling; // 0xA8
		internal bool launchDeferredDeeplink; // 0xAA
		internal AdjustLogLevel? logLevel; // 0xAC
		internal AdjustEnvironment environment; // 0xB4
		internal Action<string> deferredDeeplinkDelegate; // 0xB8
		internal Action<AdjustEventSuccess> eventSuccessDelegate; // 0xC0
		internal Action<AdjustEventFailure> eventFailureDelegate; // 0xC8
		internal Action<AdjustSessionSuccess> sessionSuccessDelegate; // 0xD0
		internal Action<AdjustSessionFailure> sessionFailureDelegate; // 0xD8
		internal Action<AdjustAttribution> attributionChangedDelegate; // 0xE0
		internal bool? readImei; // 0xE8
		internal string processName; // 0xF0
		internal bool? allowiAdInfoReading; // 0xF8
		internal bool? allowIdfaReading; // 0xFA
		internal Action<string> logDelegate; // 0x100
	
		// Constructors
		public AdjustConfig() {} // Dummy constructor
		public AdjustConfig(string appToken, AdjustEnvironment environment) {} // 0x000000018668BC70-0x000000018668BD10
		public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel) {} // 0x000000018668BD10-0x000000018668BDE0
	
		// Methods
		// [XID] // 0x00000001896F6950-0x00000001896F6970
		public void setLogLevel(AdjustLogLevel logLevel) {} // 0x000000018668CE90-0x000000018668CF60
		// [XID] // 0x00000001896FE060-0x00000001896FE080
		public void setDefaultTracker(string defaultTracker) {} // 0x000000018668C6E0-0x000000018668C790
		// [XID] // 0x00000001897053B0-0x00000001897053D0
		public void setExternalDeviceId(string externalDeviceId) {} // 0x000000018668CBB0-0x000000018668CC60
		// [XID] // 0x000000018970CB10-0x000000018970CB30
		public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink) {} // 0x000000018668CD30-0x000000018668CDE0
		// [XID] // 0x0000000189714340-0x0000000189714360
		public void setSendInBackground(bool sendInBackground) {} // 0x000000018668D0C0-0x000000018668D190
		// [XID] // 0x000000018971BDA0-0x000000018971BDC0
		public void setEventBufferingEnabled(bool eventBufferingEnabled) {} // 0x000000018668C940-0x000000018668CA10
		// [XID] // 0x0000000189723110-0x0000000189723130
		public void setDelayStart(double delayStart) {} // 0x000000018668C860-0x000000018668C940
		// [XID] // 0x0000000189AE5F40-0x0000000189AE5F60
		public void setUserAgent(string userAgent) {} // 0x000000018668D3E0-0x000000018668D490
		// [XID] // 0x0000000189AF4E20-0x0000000189AF4E40
		public void setIsDeviceKnown(bool isDeviceKnown) {} // 0x000000018668CC60-0x000000018668CD30
		// [XID] // 0x0000000189739700-0x0000000189739720
		public void setUrlStrategy(string urlStrategy) {} // 0x000000018668D330-0x000000018668D3E0
		// [XID] // 0x00000001897412B0-0x00000001897412D0
		public void deactivateSKAdNetworkHandling() {} // 0x000000018668BDE0-0x000000018668BEA0
		// [XID] // 0x0000000189ACED10-0x0000000189ACED30
		public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCC6 */) {} // 0x000000018668C790-0x000000018668C860
		// [XID] // 0x0000000189B30150-0x0000000189B30170
		public Action<string> getDeferredDeeplinkDelegate() => default; // 0x000000018668BF50-0x000000018668C000
		// [XID] // 0x00000001898F2660-0x00000001898F2680
		public void setAttributionChangedDelegate(Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCD0 */) {} // 0x000000018668C610-0x000000018668C6E0
		// [XID] // 0x000000018975F070-0x000000018975F090
		public Action<AdjustAttribution> getAttributionChangedDelegate() => default; // 0x000000018668BEA0-0x000000018668BF50
		// [XID] // 0x0000000189766400-0x0000000189766420
		public void setEventSuccessDelegate(Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCDA */) {} // 0x000000018668CAE0-0x000000018668CBB0
		// [XID] // 0x0000000189682B60-0x0000000189682B80
		public Action<AdjustEventSuccess> getEventSuccessDelegate() => default; // 0x000000018668C0B0-0x000000018668C160
		// [XID] // 0x00000001897751B0-0x00000001897751D0
		public void setEventFailureDelegate(Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCE4 */) {} // 0x000000018668CA10-0x000000018668CAE0
		// [XID] // 0x000000018977CAC0-0x000000018977CAE0
		public Action<AdjustEventFailure> getEventFailureDelegate() => default; // 0x000000018668C000-0x000000018668C0B0
		// [XID] // 0x0000000189784410-0x0000000189784430
		public void setSessionSuccessDelegate(Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCEE */) {} // 0x000000018668D260-0x000000018668D330
		// [XID] // 0x0000000189AAE800-0x0000000189AAE820
		public Action<AdjustSessionSuccess> getSessionSuccessDelegate() => default; // 0x000000018668C210-0x000000018668C2C0
		// [XID] // 0x0000000189ACCB00-0x0000000189ACCB20
		public void setSessionFailureDelegate(Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust" /* Metadata: 0x00ADDCF8 */) {} // 0x000000018668D190-0x000000018668D260
		// [XID] // 0x000000018979A660-0x000000018979A680
		public Action<AdjustSessionFailure> getSessionFailureDelegate() => default; // 0x000000018668C160-0x000000018668C210
		// [XID] // 0x00000001897A2600-0x00000001897A2620
		public void setAppSecret(long secretId, long info1, long info2, long info3, long info4) {} // 0x000000018668C460-0x000000018668C610
		// [XID] // 0x00000001897A9C70-0x00000001897A9C90
		public void setAllowiAdInfoReading(bool allowiAdInfoReading) {} // 0x000000018668C390-0x000000018668C460
		// [XID] // 0x00000001897B1480-0x00000001897B14A0
		public void setAllowIdfaReading(bool allowIdfaReading) {} // 0x000000018668C2C0-0x000000018668C390
		// [XID] // 0x00000001897B9000-0x00000001897B9020
		public void setProcessName(string processName) {} // 0x000000018668CF60-0x000000018668D010
		[Obsolete] // 0x00000001897C1190-0x00000001897C11E0
		// [XID] // 0x00000001897C1190-0x00000001897C11E0
		public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity) {} // 0x000000018668D010-0x000000018668D0C0
		// [XID] // 0x00000001897CD220-0x00000001897CD240
		public void setLogDelegate(Action<string> logDelegate) {} // 0x000000018668CDE0-0x000000018668CE90
	}
}
