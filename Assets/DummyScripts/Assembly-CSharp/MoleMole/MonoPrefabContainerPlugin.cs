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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoPrefabContainerPlugin : MonoBehaviour // TypeDefIndex: 30858
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _prefabPath; // 0x18
		private Dictionary<string, instanceContainer> _prefabInstanceDict; // 0x20
	
		// Nested types
		private struct instanceContainer // TypeDefIndex: 30859
		{
			// Fields
			public Transform instance; // 0x00
			public uint handler; // 0x08
			public bool cacheOne; // 0x0C
			public AsyncJob jobProxy; // 0x10
		}
	
		// Constructors
		public MonoPrefabContainerPlugin() {} // 0x00000001837215D0-0x0000000183721660
	
		// Methods
		// [XID] // 0x00000001898479F0-0x0000000189847A10
		public Transform GetInstance(string name) => default; // 0x0000000183720D50-0x0000000183721080
		// [XID] // 0x000000018984F160-0x000000018984F180
		public void GetInstanceAsync(string name, UnityAction<Transform> callback, bool cacheOne = false /* Metadata: 0x00B11683 */) {} // 0x0000000183720A80-0x0000000183720D50
		// [XID] // 0x00000001898562A0-0x00000001898562C0
		private string GetFullPath(string name) => default; // 0x0000000183720960-0x0000000183720A80
		// [XID] // 0x000000018985D610-0x000000018985D630
		private void DestroyInstance() {} // 0x0000000183721080-0x0000000183721530
		// [XID] // 0x0000000189864FB0-0x0000000189864FD0
		private void OnDestroy() {} // 0x0000000183721530-0x00000001837215D0
	}
}
