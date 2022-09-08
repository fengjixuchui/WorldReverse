/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKTipsBar : MiHoYoSDKBaseDialog // TypeDefIndex: 8850
	{
		// Fields
		private const string ToastPrefabPath = "UI/TipsBar.Prefab"; // Metadata: 0x00AE2D1E
		private const string TipsTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE2D33
		private const string TipsImagePath = "Dialog/Content/Image"; // Metadata: 0x00AE2D4A
		private const string MiHoYoIconPath = "Dialog/Content/Image/MiHoYo"; // Metadata: 0x00AE2D62
		private UnityEngine.UI.Text tipsText; // 0x20
		private GameObject imageObject; // 0x28
		private GameObject miHoYoIconObject; // 0x30
		private Action<string> callback; // 0x38
		private string responseString; // 0x40
		private int showCount; // 0x48
		private static MiHoYoSDKTipsBar _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKTipsBar() {} // 0x0000000185969690-0x0000000185969700
	
		// Methods
		// [XID] // 0x00000001898F8F60-0x00000001898F8F80
		public static MiHoYoSDKTipsBar Instance() => default; // 0x0000000185968F90-0x00000001859690A0
		// [XID] // 0x000000018988A040-0x000000018988A060
		public static bool IsExist() => default; // 0x00000001859690A0-0x00000001859691A0
		// [XID] // 0x00000001897B1370-0x00000001897B1390
		public void Init() {} // 0x0000000185968D30-0x0000000185968F90
		// [XID] // 0x00000001897B8F60-0x00000001897B8F80
		public void ShowTips(string message, string callbackString, Action<string> endCallback = null, bool showImage = true /* Metadata: 0x00AE2D15 */, LOGIN_TYPE type = LOGIN_TYPE.ACCOUNT_PASSWORD /* Metadata: 0x00AE2D16 */, float showTime = 3f /* Metadata: 0x00AE2D1A */) {} // 0x00000001859691A0-0x0000000185969630
		// [XID] // 0x0000000189734BF0-0x0000000189734C10
		public void HideTips() {} // 0x0000000185968C00-0x0000000185968D30
		// [XID] // 0x00000001897C89E0-0x00000001897C8A00
		public override void Dealloc() {} // 0x0000000185968B40-0x0000000185968C00
	}
}
