/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public interface IHierarchyRootContent // TypeDefIndex: 9970
	{
		// Properties
		bool IsValid { get; }
		int ChildCount { get; }
		string Name { get; }
		List<GameObject> Children { get; set; }
	
		// Methods
		void Refresh();
	}
}
