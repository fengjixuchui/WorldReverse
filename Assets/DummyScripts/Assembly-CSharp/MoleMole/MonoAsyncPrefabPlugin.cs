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
	public class MonoAsyncPrefabPlugin : MonoBehaviour // TypeDefIndex: 30687
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private PrefabPlugin[] _prefabPlugins; // 0x18
	
		// Nested types
		public enum AsyncPluginState // TypeDefIndex: 30688
		{
			NotInited = 0,
			FullActive = 1,
			LightDeactive = 2,
			Recycled = 3
		}
	
		[Serializable]
		public class PrefabPlugin : ISerializationCallbackReceiver // TypeDefIndex: 30689
		{
			// Fields
			public string name; // 0x10
			public string prefabPath; // 0x18
			public RectTransform mountPoint; // 0x20
			public bool cacheOne; // 0x28
			public bool lightRecycle; // 0x29
			[NonSerialized]
			public AsyncJob jobProxy; // 0x30
			[NonSerialized]
			public AsyncPluginState state; // 0x40
			[NonSerialized]
			public UnityAction<RectTransform> pluginCallBack; // 0x48
			[NonSerialized]
			private RectTransform instance; // 0x50
	
			// Constructors
			public PrefabPlugin() {} // 0x0000000184C9E9D0-0x0000000184C9EA50
	
			// Methods
			// [XID] // 0x000000018997DC30-0x000000018997DC50
			public void OnBeforeSerialize() {} // 0x0000000184C9E930-0x0000000184C9E9D0
			// [XID] // 0x00000001899855E0-0x0000000189985600
			public void OnAfterDeserialize() {} // 0x0000000184C9E850-0x0000000184C9E930
			// [XID] // 0x000000018998D3D0-0x000000018998D3F0
			public void SetStates(AsyncPluginState toState, UnityAction<RectTransform> callback) {} // 0x0000000184C9E650-0x0000000184C9E850
			// [XID] // 0x00000001895FA400-0x00000001895FA420
			private void GetInstanceAsync() {} // 0x0000000184C9E070-0x0000000184C9E210
			// [XID] // 0x000000018999C6F0-0x000000018999C710
			private void Recycle() {} // 0x0000000184C9E210-0x0000000184C9E440
		}
	
		// Constructors
		public MonoAsyncPrefabPlugin() {} // 0x0000000184C989E0-0x0000000184C98A40
	
		// Methods
		// [XID] // 0x00000001895EB730-0x00000001895EB750
		public void SetState(string name, AsyncPluginState state, UnityAction<RectTransform> callback = null) {} // 0x0000000184C988A0-0x0000000184C989E0
		// [IDTag] // 0x0000000189952AC0-0x0000000189952B00
		// [XID] // 0x0000000189952AC0-0x0000000189952B00
		private PrefabPlugin GetPrefabPlugin(string name) => default; // 0x0000000184C98460-0x0000000184C985E0
		// [IDTag] // 0x000000018995D160-0x000000018995D1A0
		// [XID] // 0x000000018995D160-0x000000018995D1A0
		private PrefabPlugin GetPrefabPlugin(int index) => default; // 0x0000000184C98370-0x0000000184C98460
		// [XID] // 0x0000000189967A70-0x0000000189967A90
		public void HideAll() {} // 0x0000000184C985E0-0x0000000184C986F0
		// [XID] // 0x000000018996EBF0-0x000000018996EC10
		public void RecycleAll() {} // 0x0000000184C98790-0x0000000184C988A0
		// [XID] // 0x00000001899767D0-0x00000001899767F0
		private void OnDestroy() {} // 0x0000000184C986F0-0x0000000184C98790
	}
}
