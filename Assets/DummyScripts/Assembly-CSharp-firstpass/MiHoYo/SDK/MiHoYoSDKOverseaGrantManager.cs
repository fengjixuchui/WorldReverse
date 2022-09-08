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
	public class MiHoYoSDKOverseaGrantManager : MiHoYoSDKBaseClass // TypeDefIndex: 8737
	{
		// Fields
		public Action<MiHoYoSDKUserDataModel> OnGrantDeviceSuccess; // 0x10
		public Action<int, string> OnGrantDeviceFail; // 0x18
		public Action OnBack; // 0x20
		private string grantTicket; // 0x28
		private string ticket; // 0x30
		private MiHoYoSDKUserDataModel accountModel; // 0x38
		public static readonly MiHoYoSDKOverseaGrantManager Instance; // 0x00
	
		// Constructors
		public MiHoYoSDKOverseaGrantManager() {} // 0x0000000185F4F3C0-0x0000000185F4F420
		static MiHoYoSDKOverseaGrantManager() {} // 0x0000000185F4F300-0x0000000185F4F3C0
	
		// Methods
		// [XID] // 0x000000018979C850-0x000000018979C870
		public bool CheckGrantDevice(JSONNode data) => default; // 0x0000000185F4DE00-0x0000000185F4DF10
		// [XID] // 0x00000001898A84A0-0x00000001898A84C0
		private void GetGrantTicket(JSONNode data) {} // 0x0000000185F4DF10-0x0000000185F4E070
		// [XID] // 0x00000001898B0070-0x00000001898B0090
		public void ShowGrantDevice(MiHoYoSDKUserDataModel account) {} // 0x0000000185F4EF70-0x0000000185F4F0C0
		// [XID] // 0x00000001897B2E80-0x00000001897B2EA0
		public void Back() {} // 0x0000000185F4DD50-0x0000000185F4DE00
		// [XID] // 0x00000001897BAA50-0x00000001897BAA70
		public void ShowGrantMail() {} // 0x0000000185F4F0C0-0x0000000185F4F1E0
		// [XID] // 0x00000001897C26E0-0x00000001897C2700
		public void ShowGrantPhone() {} // 0x0000000185F4F1E0-0x0000000185F4F300
		// [XID] // 0x0000000189902EA0-0x0000000189902EC0
		public void RequestGrantMessage(GrantType type) {} // 0x0000000185F4EAD0-0x0000000185F4EC80
		// [XID] // 0x00000001897D1520-0x00000001897D1540
		private void OnGetPreGrantMessage(string responseString) {} // 0x0000000185F4E360-0x0000000185F4E6F0
		// [XID] // 0x00000001897D93E0-0x00000001897D9400
		private void OnGetPreGrantMessageTimeOut() {} // 0x0000000185F4E270-0x0000000185F4E360
		// [XID] // 0x0000000189786200-0x0000000189786220
		public void RequestGrant(string code) {} // 0x0000000185F4EC80-0x0000000185F4EED0
		// [XID] // 0x0000000189726AC0-0x0000000189726AE0
		private void OnGrantDevice(string responseString) {} // 0x0000000185F4E820-0x0000000185F4EAD0
		// [XID] // 0x00000001897EFAE0-0x00000001897EFB00
		private void OnGrantDeviceTimeOut() {} // 0x0000000185F4E6F0-0x0000000185F4E820
		// [XID] // 0x00000001897F71E0-0x00000001897F7200
		private void GrantDeviceSuccess() {} // 0x0000000185F4E150-0x0000000185F4E270
		// [XID] // 0x00000001897FE830-0x00000001897FE850
		private void GrantDeviceFail(int ret, string msg) {} // 0x0000000185F4E070-0x0000000185F4E150
		// [XID] // 0x00000001898BED00-0x00000001898BED20
		private void ResetTicket() {} // 0x0000000185F4EED0-0x0000000185F4EF70
	}
}
