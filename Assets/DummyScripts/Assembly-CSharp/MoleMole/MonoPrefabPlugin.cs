/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoPrefabPlugin : MonoBehaviour // TypeDefIndex: 30862
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private PrefabPlugin[] _prefabPlugins; // 0x18
	
		// Properties
		public int count { /* [XID] */ /* 0x00000001898F14E0-0x00000001898F1500 */ get => default; } // 0x0000000183724240-0x00000001837242F0 
	
		// Nested types
		[Serializable]
		public struct PrefabPlugin : ISerializationCallbackReceiver // TypeDefIndex: 30863
		{
			// Fields
			public string name; // 0x00
			public GameObject prefab; // 0x08
			public string prefabPath; // 0x10
			public RectTransform mountPoint; // 0x18
			public Transform instance; // 0x20
			public bool cacheOne; // 0x28
			[NonSerialized]
			public uint resourceHandle; // 0x2C
			[NonSerialized]
			public AsyncJob jobProxy; // 0x30
	
			// Methods
			// [XID] // 0x000000018990F510-0x000000018990F530
			public void OnBeforeSerialize() {} // 0x000000018372E990-0x000000018372E9C0
			// [XID] // 0x0000000189916F90-0x0000000189916FB0
			public void OnAfterDeserialize() {} // 0x000000018372E8E0-0x000000018372E990
		}
	
		// Constructors
		public MonoPrefabPlugin() {} // 0x00000001837241E0-0x0000000183724240
	
		// Methods
		// [IDTag] // 0x000000018989B800-0x000000018989B840
		// [XID] // 0x000000018989B800-0x000000018989B840
		public void GetInstanceAsync(int index, UnityAction<Transform> callback) {} // 0x0000000183722BC0-0x0000000183722F50
		// [IDTag] // 0x00000001898A5FE0-0x00000001898A6020
		// [XID] // 0x00000001898A5FE0-0x00000001898A6020
		public void GetInstanceAsync(string name, UnityAction<Transform> callback) {} // 0x0000000183722F50-0x0000000183723140
		// [XID] // 0x00000001898B0580-0x00000001898B05A0
		public GameObject SpawnInstanceFromIndex(int index, Transform mountPoint) => default; // 0x0000000183723F90-0x00000001837240E0
		// [IDTag] // 0x00000001898B7B50-0x00000001898B7B90
		// [XID] // 0x00000001898B7B50-0x00000001898B7B90
		public Transform GetInstance(int index) => default; // 0x0000000183723140-0x0000000183723580
		// [IDTag] // 0x00000001898C22A0-0x00000001898C22E0
		// [XID] // 0x00000001898C22A0-0x00000001898C22E0
		public Transform GetInstance(string name) => default; // 0x0000000183723580-0x00000001837236D0
		public T GetInstance<T>(int index)
			where T : Component => default;
		public T GetInstance<T>(string name)
			where T : Component => default;
		// [IDTag] // 0x00000001898CC870-0x00000001898CC8B0
		// [XID] // 0x00000001898CC870-0x00000001898CC8B0
		public void DestroyInstance(int index) {} // 0x0000000183722490-0x00000001837226C0
		// [IDTag] // 0x00000001898D7530-0x00000001898D7570
		// [XID] // 0x00000001898D7530-0x00000001898D7570
		public void DestroyInstance(string name) {} // 0x00000001837226C0-0x0000000183722960
		// [XID] // 0x00000001898E21D0-0x00000001898E21F0
		public void DestroyPlugion(string name) {} // 0x0000000183722960-0x0000000183722BC0
		// [XID] // 0x00000001898E9DB0-0x00000001898E9DD0
		private PrefabPlugin DestroyPluginContent(PrefabPlugin plugin, int index) => default; // 0x00000001837236D0-0x0000000183723AF0
		// [XID] // 0x00000001898F8C80-0x00000001898F8CA0
		public Transform TryGetInstance(int index) => default; // 0x00000001837240E0-0x00000001837241E0
		// [XID] // 0x0000000189900640-0x0000000189900660
		public void SetActiveExcept(bool active, string except) {} // 0x0000000183723D20-0x0000000183723F90
		// [XID] // 0x0000000189907DB0-0x0000000189907DD0
		private void OnDestroy() {} // 0x0000000183723AF0-0x0000000183723D20
	}
}
