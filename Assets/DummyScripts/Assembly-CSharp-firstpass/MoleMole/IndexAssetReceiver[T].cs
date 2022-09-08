/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class IndexAssetReceiver<T> : IJobProxy, IClosureComplexResourceReceiver<T> // TypeDefIndex: 7364
		where T : UnityEngine.Object
	{
		// Fields
		private CallbackStatHelper _csh;
		private IndexResultHandler _onFinishStub;
		private int _index;
		private bool _dropEarly;
	
		// Properties
		private IndexResultHandler _onFinish { get => default; set {} }
		public bool dropEarly { get => default; }
	
		// Nested types
		public delegate void IndexResultHandler(int index, ulong requestedPath, bool loadSucceeded, uint handle, T asset); // TypeDefIndex: 7365; 0x00000000-0x00000000
	
		public delegate void LuaPreloadHandler(int index, bool loadSucceeded); // TypeDefIndex: 7366; 0x00000000-0x00000000
	
		public class Spawner : ISpawner<IndexAssetReceiver<T>, IndexResultHandler, int> // TypeDefIndex: 7367
		{
			// Constructors
			public Spawner() {}
	
			// Methods
			public IndexAssetReceiver<T> Spawn(IndexResultHandler<T> param1, int param2) => default;
		}
	
		public class Polisher : IPolisher<IndexAssetReceiver<T>, IndexResultHandler, int> // TypeDefIndex: 7368
		{
			// Constructors
			public Polisher() {}
	
			// Methods
			public void Polish(IndexAssetReceiver<T> reused, IndexResultHandler<T> param1, int param2) {}
		}
	
		// Constructors
		public IndexAssetReceiver() {} // Dummy constructor
		private IndexAssetReceiver(IndexResultHandler onFinish, int index) {}
	
		// Methods
		public void Abort(bool byUser) {}
		public void BeforeRecycle() {}
		public void Fail(ulong requestedPath, ResourceLoadFailureReason reason) {}
		public void Receive(ulong requestedPath, uint handle, T obj) {}
		public void AddOnFinishHandler(IndexResultHandler onFinish) {}
		public void Recycle() {}
		public bool CheckVoucher(object callback) => default;
		public object GetVoucher() => default;
		public void Dismiss(object voucher) {}
		public AsyncJob GetAbortJob() => default;
	}
}
