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
	public class ComplexUniHandlerAssetReceiver<T> : IClosureComplexResourceReceiver<T>, IJobProxy // TypeDefIndex: 7373
		where T : UnityEngine.Object
	{
		// Fields
		private CallbackStatHelper _csh;
		private ResultHandler _onFinishStub;
		private bool _dropEarly;
	
		// Properties
		private ResultHandler _onFinish { get => default; set {} }
		public bool dropEarly { get => default; }
	
		// Nested types
		public delegate void ResultHandler(ulong pathHash, bool loadSucceeded, uint handle, T asset); // TypeDefIndex: 7374; 0x00000000-0x00000000
	
		public class Spawner : ISpawner<ComplexUniHandlerAssetReceiver<T>, ResultHandler> // TypeDefIndex: 7375
		{
			// Constructors
			public Spawner() {}
	
			// Methods
			public ComplexUniHandlerAssetReceiver<T> Spawn(ResultHandler<T> param1) => default;
		}
	
		public class Polisher : IPolisher<ComplexUniHandlerAssetReceiver<T>, ResultHandler> // TypeDefIndex: 7376
		{
			// Constructors
			public Polisher() {}
	
			// Methods
			public void Polish(ComplexUniHandlerAssetReceiver<T> reused, ResultHandler<T> param1) {}
		}
	
		// Constructors
		public ComplexUniHandlerAssetReceiver() {} // Dummy constructor
		private ComplexUniHandlerAssetReceiver(ResultHandler onFinish) {}
	
		// Methods
		public object GetVoucher() => default;
		public bool CheckVoucher(object callback) => default;
		public void Abort(bool byUser) {}
		public void Dismiss(object voucher) {}
		public AsyncJob GetAbortJob() => default;
		public void BeforeRecycle() {}
		public void Fail(ulong pathHash, ResourceLoadFailureReason reason) {}
		public void Receive(ulong pathHash, uint handle, T obj) {}
		public void AddOnFinishHandler(ResultHandler onFinish) {}
		public void Recycle() {}
	}
}
