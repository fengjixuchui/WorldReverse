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
	internal class MiHoYoSDKLogoutManager // TypeDefIndex: 8728
	{
		// Fields
		public static readonly MiHoYoSDKLogoutManager Instance; // 0x00
	
		// Constructors
		public MiHoYoSDKLogoutManager() {} // 0x0000000185F38740-0x0000000185F387A0
		static MiHoYoSDKLogoutManager() {} // 0x0000000185F38680-0x0000000185F38740
	
		// Methods
		// [XID] // 0x0000000189874100-0x0000000189874120
		public bool CheckLogoutStatus(JSONNode data) => default; // 0x0000000185F381A0-0x0000000185F382A0
		// [XID] // 0x000000018966BFC0-0x000000018966BFE0
		public void RequestReactivateAccount(MiHoYoSDKUserDataModel userData, string reactivateTicket, Action<MiHoYoSDKResponseModel<string>> callback) {} // 0x0000000185F383F0-0x0000000185F38680
		[DebuggerHidden] // 0x0000000189673DA0-0x0000000189673DE0
		// [XID] // 0x0000000189673DA0-0x0000000189673DE0
		private IEnumerator ReactivateAccount(string reactivateTicket, Action<string> callback, Action OnTimeOut = null) => default; // 0x0000000185F382A0-0x0000000185F383F0
	}
}
