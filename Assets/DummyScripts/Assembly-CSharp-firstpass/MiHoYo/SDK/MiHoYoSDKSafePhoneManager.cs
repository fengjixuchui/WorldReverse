/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKSafePhoneManager : MiHoYoSDKBaseClass // TypeDefIndex: 8781
	{
		// Fields
		public Action<MiHoYoSDKUserDataModel> OnBindSafePhoneSuccess; // 0x10
		public Action<int, string> OnBindSafePhoneFail; // 0x18
		public Action OnClose; // 0x20
		public Action OnBack; // 0x28
		private MiHoYoSDKUserDataModel accountModel; // 0x30
		private string phoneNumber; // 0x38
		private string ticket; // 0x40
		private static MiHoYoSDKSafePhoneManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKSafePhoneManager() {} // 0x00000001859686F0-0x0000000185968750
	
		// Methods
		// [XID] // 0x0000000189752B90-0x0000000189752BB0
		public static MiHoYoSDKSafePhoneManager Instance() => default; // 0x00000001859674B0-0x00000001859675B0
		// [XID] // 0x000000018981C5E0-0x000000018981C600
		public void Init() {} // 0x0000000185967410-0x00000001859674B0
		// [XID] // 0x00000001897C26C0-0x00000001897C26E0
		public bool CheckSafeMobile(JSONNode data) => default; // 0x0000000185967260-0x0000000185967360
		// [XID] // 0x0000000189BCA610-0x0000000189BCA630
		public void ShowSafeMobile(MiHoYoSDKUserDataModel account) {} // 0x0000000185968620-0x00000001859686F0
		// [XID] // 0x0000000189681F90-0x0000000189681FB0
		public void Close() {} // 0x0000000185967360-0x0000000185967410
		// [XID] // 0x0000000189875530-0x0000000189875550
		public void Back() {} // 0x0000000185966FF0-0x00000001859670A0
		// [XID] // 0x00000001897E0790-0x00000001897E07B0
		public void RequestVerification(string mobile) {} // 0x0000000185968400-0x0000000185968620
		// [XID] // 0x0000000189A884A0-0x0000000189A884C0
		public void RequestBindSafeMobile(string captcha) {} // 0x0000000185968010-0x0000000185968240
		// [XID] // 0x00000001899B1AE0-0x00000001899B1B00
		private void OnBindSafeMobile(string responseString) {} // 0x00000001859676A0-0x00000001859678C0
		// [XID] // 0x00000001897F71C0-0x00000001897F71E0
		private void OnBindSafeMobileTimeOut() {} // 0x00000001859675B0-0x00000001859676A0
		// [XID] // 0x000000018968BA50-0x000000018968BA70
		private void OnGetTicket(string responseString) {} // 0x0000000185967D00-0x0000000185968010
		// [XID] // 0x000000018966F0C0-0x000000018966F0E0
		private void OnGetTicketTimeOut() {} // 0x0000000185967C10-0x0000000185967D00
		// [XID] // 0x00000001896BF1F0-0x00000001896BF210
		private void RequestMobileCaptcha(string ticket) {} // 0x0000000185968240-0x0000000185968400
		// [XID] // 0x00000001896A2420-0x00000001896A2440
		private void OnGetCaptcha(string responseString) {} // 0x00000001859679B0-0x0000000185967C10
		// [XID] // 0x00000001897C12A0-0x00000001897C12C0
		private void OnGetCaptchaTimeOut() {} // 0x00000001859678C0-0x00000001859679B0
		// [XID] // 0x0000000189823D00-0x0000000189823D20
		private void BindSafePhoneSuccess() {} // 0x0000000185967180-0x0000000185967260
		// [XID] // 0x00000001898EB2C0-0x00000001898EB2E0
		private void BindSafePhoneFail(int ret, string msg) {} // 0x00000001859670A0-0x0000000185967180
	}
}
