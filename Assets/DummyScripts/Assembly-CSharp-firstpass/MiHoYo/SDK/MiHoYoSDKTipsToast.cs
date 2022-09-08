/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKTipsToast : MiHoYoSDKBaseDialog // TypeDefIndex: 8851
	{
		// Fields
		private const string ToastPrefabPath = "UI/TipsToast.Prefab"; // Metadata: 0x00AE2D85
		private const string TipsTextPath = "Text"; // Metadata: 0x00AE2D9C
		private UnityEngine.UI.Text tipsText; // 0x20
		private int showCount; // 0x28
		private static MiHoYoSDKTipsToast _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKTipsToast() {} // 0x0000000185969EF0-0x0000000185969F60
	
		// Methods
		// [XID] // 0x00000001897D0070-0x00000001897D0090
		public static MiHoYoSDKTipsToast Instance() => default; // 0x0000000185969A80-0x0000000185969B90
		// [XID] // 0x00000001897D7970-0x00000001897D7990
		public static bool IsExist() => default; // 0x0000000185969B90-0x0000000185969C90
		// [XID] // 0x00000001897DEE30-0x00000001897DEE50
		public void Init() {} // 0x00000001859698D0-0x0000000185969A80
		// [XID] // 0x00000001897E68E0-0x00000001897E6900
		public void ShowTips(string message, float showTime = 3f /* Metadata: 0x00AE2D81 */) {} // 0x0000000185969C90-0x0000000185969E90
		// [XID] // 0x00000001897B0900-0x00000001897B0920
		public void HideTips() {} // 0x00000001859697C0-0x00000001859698D0
		// [XID] // 0x00000001898B5650-0x00000001898B5670
		public override void Dealloc() {} // 0x0000000185969700-0x00000001859697C0
	}
}
