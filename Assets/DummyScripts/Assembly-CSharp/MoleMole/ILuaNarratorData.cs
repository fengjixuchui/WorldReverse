/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public interface ILuaNarratorData // TypeDefIndex: 21071
	{
		// Properties
		List<uint> dialogList { get; set; }
		uint narratorId { get; set; }
		uint pauseLen { get; set; }
		uint resumeLen { get; set; }
		string tag { get; set; }
		bool startCheckPause { get; set; }
	}
}
