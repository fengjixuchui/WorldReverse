/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector.Internal;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public abstract class fiValueNullSerializer<T> : fiValueProxyEditor, fiIValueProxyAPI // TypeDefIndex: 4859
	{
		// Fields
		public T Value;
	
		// Properties
		object fiIValueProxyAPI.Value { get; set; }
	
		// Constructors
		protected fiValueNullSerializer() {}
	
		// Methods
		void fiIValueProxyAPI.SaveState() {}
		void fiIValueProxyAPI.LoadState() {}
	}
}
