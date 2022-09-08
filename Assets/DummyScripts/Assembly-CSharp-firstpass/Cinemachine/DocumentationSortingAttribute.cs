/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [DocumentationSorting] // 0x0000000189BA89E0-0x0000000189BA8A00
	public sealed class DocumentationSortingAttribute : Attribute // TypeDefIndex: 6845
	{
		// Properties
		public float SortOrder { get; private set; } // 0x000000018669B0A0-0x000000018669B110 0x000000018669B170-0x000000018669B1E0
		public Level Category { get; private set; } // 0x000000018669B040-0x000000018669B0A0 0x000000018669B110-0x000000018669B170
	
		// Nested types
		public enum Level // TypeDefIndex: 6846
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}
	
		// Constructors
		public DocumentationSortingAttribute() {} // Dummy constructor
		public DocumentationSortingAttribute(float sortOrder, Level category) {} // 0x000000018669AF50-0x000000018669B040
	}
}
