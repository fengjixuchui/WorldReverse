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
	public class MiHoYoSDKGrantPhoneManager : MiHoYoSDKBaseClass // TypeDefIndex: 8722
	{
		// Fields
		public Action<MiHoYoSDKUserDataModel> OnGrantDeviceSuccess; // 0x10
		public Action<int, string> OnGrantDeviceFail; // 0x18
		public Action OnClose; // 0x20
		public Action OnBack; // 0x28
		private string ticket; // 0x30
		private MiHoYoSDKUserDataModel accountModel; // 0x38
		private static MiHoYoSDKGrantPhoneManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKGrantPhoneManager() {} // 0x0000000184DF9440-0x0000000184DF94A0
	
		// Methods
		// [XID] // 0x00000001898A4380-0x00000001898A43A0
		public static MiHoYoSDKGrantPhoneManager Instance() => default; // 0x0000000184DF8510-0x0000000184DF8610
		// [XID] // 0x00000001898AB5A0-0x00000001898AB5C0
		public void Init() {} // 0x0000000184DF8470-0x0000000184DF8510
		// [XID] // 0x00000001898D6F70-0x00000001898D6F90
		public bool CheckGrantDevice(JSONNode data) => default; // 0x0000000184DF7FD0-0x0000000184DF80D0
		// [XID] // 0x0000000189A128E0-0x0000000189A12900
		public void ShowGrantDevice(MiHoYoSDKUserDataModel account) {} // 0x0000000184DF92C0-0x0000000184DF9380
		// [XID] // 0x0000000189ADE340-0x0000000189ADE360
		public void Close() {} // 0x0000000184DF80D0-0x0000000184DF8180
		// [XID] // 0x00000001898C9900-0x00000001898C9920
		public void Back() {} // 0x0000000184DF7F20-0x0000000184DF7FD0
		// [XID] // 0x00000001898D10A0-0x00000001898D10C0
		public void GrantSafePhoneBack() {} // 0x0000000184DF8370-0x0000000184DF8470
		// [XID] // 0x0000000189A286A0-0x0000000189A286C0
		public void ShowGrantBindMobile() {} // 0x0000000184DF9200-0x0000000184DF92C0
		// [XID] // 0x0000000189B0BB50-0x0000000189B0BB70
		public void ShowGrantSafeMobile() {} // 0x0000000184DF9380-0x0000000184DF9440
		// [XID] // 0x00000001898E8120-0x00000001898E8140
		public void RequestGrantMessage(GrantType type) {} // 0x0000000184DF8DE0-0x0000000184DF8FB0
		// [XID] // 0x00000001899E3FE0-0x00000001899E4000
		private void OnGetPreGrantMessage(string responseString) {} // 0x0000000184DF8700-0x0000000184DF8A90
		// [XID] // 0x00000001898F7180-0x00000001898F71A0
		private void OnGetPreGrantMessageTimeOut() {} // 0x0000000184DF8610-0x0000000184DF8700
		// [XID] // 0x00000001898FE940-0x00000001898FE960
		public void RequestGrantMobile(string code) {} // 0x0000000184DF8FB0-0x0000000184DF9200
		// [XID] // 0x0000000189BCA630-0x0000000189BCA650
		private void OnGrantDevice(string responseString) {} // 0x0000000184DF8BC0-0x0000000184DF8DE0
		// [XID] // 0x000000018990D980-0x000000018990D9A0
		private void OnGrantDeviceTimeOut() {} // 0x0000000184DF8A90-0x0000000184DF8BC0
		// [XID] // 0x00000001897FF1F0-0x00000001897FF210
		private void GrantDeviceSuccess() {} // 0x0000000184DF8260-0x0000000184DF8370
		// [XID] // 0x0000000189B78960-0x0000000189B78980
		private void GrantDeviceFail(int ret, string msg) {} // 0x0000000184DF8180-0x0000000184DF8260
	}
}
