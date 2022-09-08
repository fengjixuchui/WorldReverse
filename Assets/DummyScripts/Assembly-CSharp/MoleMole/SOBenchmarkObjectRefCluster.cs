/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189727F20-0x0000000189727F60
	public class SOBenchmarkObjectRefCluster : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 27692
	{
		// Fields
		public const string UONPrefix_Material = "MAT"; // Metadata: 0x00B0CABE
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public NameObjectPair[] materials; // 0x18
		private Dictionary<string, UnityEngine.Object> _materialNameObjectMap; // 0x20
		public const string UONPrefix_Mesh = "MES"; // Metadata: 0x00B0CAC5
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public NameObjectPair[] meshes; // 0x28
		private Dictionary<string, UnityEngine.Object> _meshNameObjectMap; // 0x30
	
		// Nested types
		[Serializable]
		public class NameObjectPair // TypeDefIndex: 27693
		{
			// Fields
			public string name; // 0x10
			public UnityEngine.Object resourceObj; // 0x18
	
			// Constructors
			public NameObjectPair() {} // 0x0000000182B14F40-0x0000000182B14FA0
		}
	
		// Constructors
		public SOBenchmarkObjectRefCluster() {} // 0x0000000184EEFC30-0x0000000184EEFC90
	
		// Methods
		// [XID] // 0x00000001897403D0-0x00000001897403F0
		public void OnBeforeSerialize() {} // 0x0000000184EEFB90-0x0000000184EEFC30
		// [XID] // 0x0000000189747740-0x0000000189747760
		public void OnAfterDeserialize() {} // 0x0000000184EEF9C0-0x0000000184EEFB90
		// [XID] // 0x000000018974EEF0-0x000000018974EF10
		private Dictionary<string, UnityEngine.Object> GetUOBjectCacheByName(string inUOName) => default; // 0x0000000184EEF660-0x0000000184EEF7C0
		// [XID] // 0x0000000189756580-0x00000001897565A0
		public UnityEngine.Object GetUObjectByName(string inUOName) => default; // 0x0000000184EEF7C0-0x0000000184EEF9C0
	}
}
