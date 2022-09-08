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
	public interface IActionPointData // TypeDefIndex: 21103
	{
		// Properties
		int actionType { get; set; }
		List<int> freeStyleList { get; set; }
		int lookAtType { get; set; }
		bool reactOnCollide { get; set; }
		bool reactOnBodyLang { get; set; }
	}
}
