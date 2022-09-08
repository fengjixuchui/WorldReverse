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
	public class MiHoYoSDKBaseClass // TypeDefIndex: 8891
	{
		// Constructors
		public MiHoYoSDKBaseClass() {} // 0x00000001859ECD50-0x00000001859ECDB0
	
		// Methods
		// [XID] // 0x0000000189A3B6F0-0x0000000189A3B710
		public void ShowLoading() {} // 0x00000001859ECA50-0x00000001859ECB10
		// [XID] // 0x00000001896609F0-0x0000000189660A10
		public void HideLoading() {} // 0x00000001859EC7A0-0x00000001859EC860
		// [XID] // 0x0000000189A51FA0-0x0000000189A51FC0
		public void ShowTips(string message) {} // 0x00000001859ECC50-0x00000001859ECD50
		// [XID] // 0x00000001895FBAE0-0x00000001895FBB00
		public void ShowLoadingDialog(string message) {} // 0x00000001859EC980-0x00000001859ECA50
		// [XID] // 0x0000000189B57220-0x0000000189B57240
		public void HideLoadingDialog() {} // 0x00000001859EC6E0-0x00000001859EC7A0
		// [XID] // 0x0000000189A69080-0x0000000189A690A0
		public void ShowTipsBar(string message, string responseString = null, Action<string> endCallback = null, bool showImage = true /* Metadata: 0x00AE48DC */, LOGIN_TYPE type = LOGIN_TYPE.ACCOUNT_PASSWORD /* Metadata: 0x00AE48DD */) {} // 0x00000001859ECB10-0x00000001859ECC50
		// [XID] // 0x0000000189A70180-0x0000000189A701A0
		public void ShowAlert(string content, string buttonTitle = null, Action callback = null, Action closeCallback = null) {} // 0x00000001859EC860-0x00000001859EC980
	}
}
