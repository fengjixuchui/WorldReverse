/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public interface tkIControl // TypeDefIndex: 4941
	{
		// Properties
		System.Type ContextType { get; }
	
		// Methods
		object Edit(Rect rect, object obj, object context, fiGraphMetadata metadata);
		float GetHeight(object obj, object context, fiGraphMetadata metadata);
		void InitializeId(ref int nextId);
	}
}
