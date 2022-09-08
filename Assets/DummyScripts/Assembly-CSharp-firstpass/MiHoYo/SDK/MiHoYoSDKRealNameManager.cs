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
	public class MiHoYoSDKRealNameManager : MiHoYoSDKBaseClass // TypeDefIndex: 8751
	{
		// Fields
		private Action<string, string> realNameCallback; // 0x10
		private static MiHoYoSDKRealNameManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKRealNameManager() {} // 0x000000018595ACD0-0x000000018595AD30
	
		// Methods
		// [XID] // 0x0000000189934240-0x0000000189934260
		public static MiHoYoSDKRealNameManager Instance() => default; // 0x000000018595A180-0x000000018595A280
		// [XID] // 0x0000000189BD4350-0x0000000189BD4370
		public void Init() {} // 0x000000018595A0E0-0x000000018595A180
		// [XID] // 0x0000000189BDBD40-0x0000000189BDBD60
		public static IdentityType CheckRealNameAuth() => default; // 0x0000000185959E90-0x000000018595A0E0
		// [XID] // 0x0000000189B1B870-0x0000000189B1B890
		public static bool IsRealNameAccount(MiHoYoSDKUserDataModel account) => default; // 0x000000018595A280-0x000000018595A360
		// [XID] // 0x00000001895EFE90-0x00000001895EFEB0
		public void RequestRealNameAuth(MiHoYoSDKUserDataModel account, Action<string, string> callback) {} // 0x000000018595AAB0-0x000000018595ACD0
		// [XID] // 0x00000001895F0720-0x00000001895F0740
		private void OnGetTicketByToken(string responseString) {} // 0x000000018595A600-0x000000018595A9B0
		// [XID] // 0x00000001899F2D40-0x00000001899F2D60
		private void OnBindRealName(string responseString) {} // 0x000000018595A360-0x000000018595A600
		// [XID] // 0x0000000189606570-0x0000000189606590
		private void OnTimeOut() {} // 0x000000018595A9B0-0x000000018595AAB0
	}
}
