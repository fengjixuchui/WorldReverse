/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKCloudDataStorage // TypeDefIndex: 8567
	{
		// Fields
		private int PartSize; // 0x10
		private static MiHoYoSDKCloudDataStorage _instance; // 0x00
		private SaveImageModel currentImageModel; // 0x18
		private List<SaveImageModel> saveImageList; // 0x20
		private bool isTransmittingImage; // 0x28
	
		// Properties
		public static MiHoYoSDKCloudDataStorage Instance { /* [XID] */ /* 0x0000000189B96F70-0x0000000189B96F90 */ get => default; } // 0x0000000186414ED0-0x0000000186414FB0 
	
		// Nested types
		private class SaveImageModel // TypeDefIndex: 8568
		{
			// Fields
			public string imageData; // 0x10
			public string imageName; // 0x18
			public int imageSize; // 0x20
			public int totalPart; // 0x24
			public int callbackIndex; // 0x28
	
			// Constructors
			public SaveImageModel() {} // 0x000000018641C450-0x000000018641C4B0
		}
	
		// Constructors
		public MiHoYoSDKCloudDataStorage() {} // 0x0000000186414E20-0x0000000186414ED0
	
		// Methods
		// [XID] // 0x0000000189B9E480-0x0000000189B9E4A0
		public void GetLocalData(string key, int index) {} // 0x00000001864143E0-0x00000001864144D0
		// [XID] // 0x0000000189BA5E40-0x0000000189BA5E60
		public void SetLocalData(string saveData, int index = -1 /* Metadata: 0x00ADFB67 */) {} // 0x0000000186414950-0x0000000186414A40
		// [XID] // 0x0000000189BAD200-0x0000000189BAD220
		public void SaveImage(string jsonString, int index) {} // 0x00000001864145F0-0x0000000186414950
		// [XID] // 0x0000000189BB49E0-0x0000000189BB4A00
		private void OnTransmitCallback(string part = "0" /* Metadata: 0x00ADFB6B */) {} // 0x00000001864144D0-0x00000001864145F0
		// [XID] // 0x0000000189BBBED0-0x0000000189BBBEF0
		private void TransmitPartData(int part, Action<string> callback) {} // 0x0000000186414A40-0x0000000186414E20
	}
}
