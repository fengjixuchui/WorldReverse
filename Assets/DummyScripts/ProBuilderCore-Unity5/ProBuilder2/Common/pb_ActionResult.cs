/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_ActionResult // TypeDefIndex: 3363
	{
		// Fields
		public Status status; // 0x10
		public string notification; // 0x18
	
		// Properties
		public static pb_ActionResult Success { get => default; } // 0x000000018770B6C0-0x000000018770B780 
		public static pb_ActionResult NoSelection { get => default; } // 0x000000018770B640-0x000000018770B6C0 
		public static pb_ActionResult UserCanceled { get => default; } // 0x000000018770B780-0x000000018770B800 
	
		// Constructors
		public pb_ActionResult() {} // Dummy constructor
		public pb_ActionResult(Status status, string notification) {} // 0x000000018770B580-0x000000018770B640
	
		// Methods
		public static implicit operator bool(pb_ActionResult res) => default; // 0x000000018770B800-0x000000018770B870
	}
}
