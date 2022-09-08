/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal static class ThreadSafeUnityInput // TypeDefIndex: 3518
	{
		// Fields
		private static Mouse GuYbcURlyrkGmhVCtcsUHUPcMSc; // 0x00
		private static Keyboard jfGJhMvxRadYQPslYBxGvNWWKsd; // 0x08
	
		// Properties
		public static Mouse mouse { get; } // 0x0000000185574140-0x00000001855741E0 
		public static Keyboard keyboard { get; } // 0x00000001855740A0-0x0000000185574140 
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public sealed class Keyboard // TypeDefIndex: 3519
		{
			// Fields
			public static readonly int keyValueIndex_Escape; // 0x00
			public static readonly int keyValueIndex_Menu; // 0x04
			public static readonly int keyValueIndex_F2; // 0x08
			public static readonly int keyValueIndex_UpArrow; // 0x0C
			public static readonly int keyValueIndex_RightArrow; // 0x10
			public static readonly int keyValueIndex_DownArrow; // 0x14
			public static readonly int keyValueIndex_LeftArrow; // 0x18
			private static readonly int[] OlzszxbGukhNJiPARpFCWvZOzXm; // 0x20
			private readonly int ZhpCoNIbFrOEGERIBMIsWWnMrxBp; // 0x10
			private readonly int[] TvOEEWhWYopkmuOVyKYYItfBlCrH; // 0x18
			private readonly bool[] PczZmwlKZffAWXLQaVTRvCWjchW; // 0x20
			private bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x28
			private int JSOKBmvUpnAJPKktfkTtGyofmxm; // 0x2C
			private readonly bool BjfWKlABcPvhleltMQUKTCBPPhO; // 0x30
	
			// Properties
			public bool enabled { set {} } // 0x0000000185553BF0-0x0000000185553CC0
	
			// Constructors
			static Keyboard() {} // 0x00000001855535C0-0x00000001855538E0
			public Keyboard() {} // 0x00000001855538E0-0x0000000185553AB0
	
			// Methods
			public void PostInitialize() {} // 0x0000000185552F90-0x0000000185552FF0
			public void Update() {} // 0x0000000185552FF0-0x00000001855534A0
			public void Monitor(bool state) {} // 0x0000000185552DD0-0x0000000185552F90
			public bool GetKey(KeyCode keyCode) => default; // 0x0000000185552CB0-0x0000000185552DD0
			public void GetKeyValues(bool[] values) {} // 0x0000000185552B50-0x0000000185552CB0
			public void Clear() {} // 0x00000001855529C0-0x0000000185552B50
			private void bbBpdCFNUtLARgPYWgfbIajvpEs() {} // 0x0000000185553AB0-0x0000000185553B30
			private void biZSCzGNZSOIcWekqYfQgNGXSHT() {} // 0x0000000185553B30-0x0000000185553B80
			private void ZxydwIdmjSEINiGoVJNNowUobfJ() {} // 0x0000000185553510-0x00000001855535C0
			private void WDbACmColGboMlDwNGwQepcmeVhc() {} // 0x00000001855534A0-0x0000000185553510
			private void oRLWYqCIZqSkWRoIWDJZVWMUWBI() {} // 0x0000000185553B80-0x0000000185553BF0
		}
	
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public sealed class Mouse // TypeDefIndex: 3520
		{
			// Fields
			private readonly bool[] lgAkyeKCNYSjxkICDjzKgIcrtWEL; // 0x10
			private readonly float[] EteKXKVjofLKPeANfYKFAFNxxsR; // 0x18
			private int JSOKBmvUpnAJPKktfkTtGyofmxm; // 0x20
			private Vector3 NQYagDGTCeiDlLRmkNwtBxjbOsEo; // 0x24
			private bool WdiFBZqmaSeGNKlVLdCOjRHfHFG; // 0x30
	
			// Properties
			public Vector3 mousePosition { get => default; } // 0x00000001855568A0-0x0000000185556910 
	
			// Constructors
			public Mouse() {} // 0x0000000185556700-0x00000001855567C0
	
			// Methods
			public void PostInitialize() {} // 0x00000001855562E0-0x0000000185556340
			public void Update() {} // 0x0000000185556340-0x0000000185556630
			public void Monitor(bool state) {} // 0x0000000185556110-0x00000001855562E0
			public void GetButtonValues(bool[] buttons) {} // 0x0000000185555FF0-0x0000000185556110
			public void GetAxisRawValues(float[] axes) {} // 0x0000000185555EC0-0x0000000185555FF0
			private void bbBpdCFNUtLARgPYWgfbIajvpEs() {} // 0x00000001855567C0-0x0000000185556850
			private void CbNIcrvnFQKuUFKiCEsYAUrFeFbZ() {} // 0x0000000185555E20-0x0000000185555EC0
			private void biZSCzGNZSOIcWekqYfQgNGXSHT() {} // 0x0000000185556850-0x00000001855568A0
			private void ZxydwIdmjSEINiGoVJNNowUobfJ() {} // 0x00000001855566A0-0x0000000185556700
			private void YUPwMOEFcBFDiKJIXtefKNBgFpC() {} // 0x0000000185556630-0x00000001855566A0
			private void oRLWYqCIZqSkWRoIWDJZVWMUWBI() {} // 0x0000000185556910-0x0000000185556980
		}
	
		// Methods
		public static void Initialize() {} // 0x0000000185573D60-0x0000000185573DB0
		public static void PostInitialize() {} // 0x0000000185573E00-0x0000000185573F50
		public static void PostInitialize2() {} // 0x0000000185573DB0-0x0000000185573E00
		public static void Deinitialize() {} // 0x0000000185573C90-0x0000000185573D60
		public static void Update() {} // 0x0000000185573F50-0x00000001855740A0
	}
}
