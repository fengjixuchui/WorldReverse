/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public interface IListViewAdapter // TypeDefIndex: 10029
	{
		// Properties
		int Count { get; }
		float ItemHeight { get; }
	
		// Methods
		RecycledListItem CreateItem(Transform parent);
		void SetItemContent(RecycledListItem item);
		void OnItemClicked(RecycledListItem item);
	}
}
