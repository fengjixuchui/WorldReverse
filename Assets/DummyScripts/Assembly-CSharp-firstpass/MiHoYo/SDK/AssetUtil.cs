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
	public static class AssetUtil // TypeDefIndex: 8890
	{
		// Fields
		public const string ASB_ROOT_PATH = "Assets/Plugins/MiHoYoSDK/AsbRes/"; // Metadata: 0x00AE48B8
		public static readonly string MiHoYoSDKAsbPath; // 0x00
		private static AssetBundle _assetBundle; // 0x08
	
		// Constructors
		static AssetUtil() {} // 0x00000001859D6220-0x00000001859D6290
	
		// Methods
		// [XID] // 0x0000000189A25530-0x0000000189A25550
		public static GameObject CreateGameObject(string path, string name = "" /* Metadata: 0x00AE48B0 */) => default; // 0x00000001859D5E90-0x00000001859D5FF0
		// [XID] // 0x0000000189A2CAC0-0x0000000189A2CAE0
		public static void DestroyGameObject(GameObject go) {} // 0x00000001859D5FF0-0x00000001859D60F0
		public static T LoadResource<T>(string path)
			where T : UnityEngine.Object => default;
		public static string GetAssetAsbFullPath<T>(string path)
			where T : UnityEngine.Object => default;
		private static T LoadFromAsb<T>(string path, string ext = "" /* Metadata: 0x00AE48B4 */)
			where T : UnityEngine.Object => default;
		// [XID] // 0x0000000189A34210-0x0000000189A34230
		public static void AsbUnload() {} // 0x00000001859D5DB0-0x00000001859D5E90
		// [XID] // 0x0000000189A3B920-0x0000000189A3B940
		public static string LoadJsonFile(string fileName) => default; // 0x00000001859D60F0-0x00000001859D6220
	}
}
