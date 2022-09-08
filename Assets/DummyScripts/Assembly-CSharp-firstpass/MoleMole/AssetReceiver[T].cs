/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AssetReceiver<T> : ILoadedResourceReceiver<T>, IEnumerator // TypeDefIndex: 10462
		where T : UnityEngine.Object
	{
		// Fields
		private bool _finished;
	
		// Properties
		public bool dropEarly { get => default; }
		public uint resourceHandle { get; private set; }
		public ulong assetPath { get; private set; }
		public T asset { get; private set; }
		public object Current { get => default; }
	
		// Constructors
		public AssetReceiver() {}
	
		// Methods
		public void Fail(ulong requestedPath, ResourceLoadFailureReason reason) {}
		public void Receive(ulong requestedPath, uint handle, T obj) {}
		public bool MoveNext() => default;
		public void Reset() {}
		public void Recycle() {}
	}
}
