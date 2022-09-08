/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class ObjectInstanceTracker : IDisposable // TypeDefIndex: 4394
	{
		// Fields
		private static ObjectInstanceTracker LDwDTzcqSaJaAJzktFPjtpIxftC; // 0x00
		private readonly Dictionary<uint, object> JZbhNpypmeAwwhiixsUFliEFruTP; // 0x10
		private readonly object ApoGIkESPluZZXxnlCUFKEbYmQw; // 0x18
		private uint PMlTXERnECEKPoKLZlfFpvvYIbu; // 0x20
		private int pbQDaYJgPflojVjuHQmFyxQcOKp; // 0x24
		private bool ynRCLoOeYzBpdwIeiDhWlnvtGGrB; // 0x28
	
		// Properties
		public static ObjectInstanceTracker Default { get => default; } // 0x00000001862EFBA0-0x00000001862EFC30 
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public class Wrapper<T> : IDisposable // TypeDefIndex: 4395
			where T : class
		{
			// Fields
			public readonly T instance;
			public readonly uint instanceId;
			private readonly ObjectInstanceTracker MDOELICkCliFJZMtIDaTaPKgdHuH;
			private bool vsurYtRlepcrpAzAENwjqjJEZPT;
	
			// Constructors
			public Wrapper() {} // Dummy constructor
			public Wrapper(T instance) {}
			public Wrapper(T instance, ObjectInstanceTracker tracker) {}
	
			// Methods
			public void Dispose() {}
			~Wrapper() {}
			protected virtual void Dispose(bool disposing) {}
		}
	
		// Constructors
		public ObjectInstanceTracker() {} // 0x00000001862EFAF0-0x00000001862EFBA0
	
		// Methods
		public uint Register(object instance) => default; // 0x00000001862EF8D0-0x00000001862EF9D0
		public void Unregister(uint instanceId) {} // 0x00000001862EF9D0-0x00000001862EFAF0
		public bool TryGetInstance<T>(uint instanceId, out T instance)
			where T : class {
			instance = default;
			return default;
		}
		public void Dispose() {} // 0x00000001862EF780-0x00000001862EF820
		private void DJeUzQoMEVOxbEpwDFXbTBWdIKu(bool param_000092c3) {} // 0x00000001862EF6C0-0x00000001862EF780
		~ObjectInstanceTracker() {} // 0x00000001862EF820-0x00000001862EF8D0
	}
}
