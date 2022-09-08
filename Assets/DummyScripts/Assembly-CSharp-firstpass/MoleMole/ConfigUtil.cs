/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class ConfigUtil // TypeDefIndex: 10534
	{
		// Fields
		private static JsonSerializerSettings _jsonSerializerSettings; // 0x00
	
		// Constructors
		static ConfigUtil() {} // 0x00000001858F5800-0x00000001858F58A0
	
		// Methods
		public static T LoadJSONConfig<T>(string jsonPath, bool useJsonUtility = false /* Metadata: 0x00AE77B1 */)
			where T : class => default;
		public static T LoadJSONStrConfig<T>(string jsonText, bool useJsonUtility = false /* Metadata: 0x00AE77B2 */)
			where T : class => default;
		public static string SaveJSONStrConfig<T>(T obj, bool useJsonUtility = false /* Metadata: 0x00AE77B3 */)
			where T : class => default;
		public static T LoadConfig<T>(string filePath, out uint handle)
			where T : ScriptableObject {
			handle = default;
			return default;
		}
		public static T LoadConfig<T>(ulong filePathHash, out uint handle)
			where T : ScriptableObject {
			handle = default;
			return default;
		}
		public static T LoadConfigEditor<T>(string filePath)
			where T : ScriptableObject => default;
	}
}
