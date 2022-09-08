/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKCanvasManager // TypeDefIndex: 8881
	{
		// Fields
		private const string CanvasPrefabPath = "UI/SDKUICanvas.Prefab"; // Metadata: 0x00AE417F
		private const string CanvasName = "SDKUICanvas"; // Metadata: 0x00AE4198
		private GameObject canvas; // 0x10
		private static MiHoYoSDKCanvasManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKCanvasManager() {} // 0x00000001864138F0-0x0000000186413950
	
		// Methods
		// [XID] // 0x00000001896B6F70-0x00000001896B6F90
		public static MiHoYoSDKCanvasManager Instance() => default; // 0x00000001864136E0-0x00000001864137E0
		// [XID] // 0x00000001896BE060-0x00000001896BE080
		private void Init() {} // 0x00000001864135F0-0x00000001864136E0
		// [XID] // 0x00000001896C5950-0x00000001896C5970
		public GameObject GetCanvas() => default; // 0x0000000186413390-0x0000000186413480
		// [XID] // 0x0000000189849350-0x0000000189849370
		public float GetScale() => default; // 0x0000000186413480-0x00000001864135F0
		// [XID] // 0x000000018990F820-0x000000018990F840
		public void DestroyCanvas() {} // 0x0000000186413270-0x0000000186413390
		// [XID] // 0x00000001896DBCA0-0x00000001896DBCC0
		public void TryDestroyCanvas() {} // 0x00000001864137E0-0x00000001864138F0
	}
}
