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
	public class DualHandlerAssetReceiver<T> : ILoadedResourceReceiver<T>, IReusable // TypeDefIndex: 7377
		where T : UnityEngine.Object
	{
		// Fields
		private CallbackStatHelper _csh;
		private SuccessHandler _onFinishStub;
		private FailureHandler _onFailure;
	
		// Properties
		private SuccessHandler _onSuccess { get => default; set {} }
		public bool dropEarly { get => default; }
	
		// Nested types
		public delegate void FailureHandler(ulong pathHash, ResourceLoadFailureReason reason); // TypeDefIndex: 7378; 0x00000000-0x00000000
	
		public delegate void SuccessHandler(ulong pathHash, uint handle, T asset); // TypeDefIndex: 7379; 0x00000000-0x00000000
	
		public class Spawner : ISpawner<DualHandlerAssetReceiver<T>, FailureHandler, SuccessHandler> // TypeDefIndex: 7380
		{
			// Constructors
			public Spawner() {}
	
			// Methods
			public DualHandlerAssetReceiver<T> Spawn(FailureHandler<T> param1, SuccessHandler<T> param2) => default;
		}
	
		public class Polisher : IPolisher<DualHandlerAssetReceiver<T>, FailureHandler, SuccessHandler> // TypeDefIndex: 7381
		{
			// Constructors
			public Polisher() {}
	
			// Methods
			public void Polish(DualHandlerAssetReceiver<T> reused, FailureHandler<T> param1, SuccessHandler<T> param2) {}
		}
	
		// Constructors
		public DualHandlerAssetReceiver() {} // Dummy constructor
		private DualHandlerAssetReceiver(FailureHandler onFailure, SuccessHandler onSuccess) {}
	
		// Methods
		public void BeforeRecycle() {}
		public void Fail(ulong pathHash, ResourceLoadFailureReason reason) {}
		public void Receive(ulong pathHash, uint handle, T obj) {}
		public void AddOnFailureHandler(FailureHandler onFailure) {}
		public void AddOnSuccessHandler(SuccessHandler onSuccess) {}
		private void ClearHandlers() {}
		public void Recycle() {}
	}
}
