/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class LuaLogic : IScriptableLogic // TypeDefIndex: 21129
	{
		// Events
		public event Action OnInit;
		public event Action OnTick;
		public event Action OnDestroy;
	
		// Constructors
		public LuaLogic() {} // 0x0000000184F07820-0x0000000184F07890
	
		// Methods
		// [XID] // 0x0000000189AEB030-0x0000000189AEB050
		public virtual bool Init(string scriptPath = null) => default; // 0x0000000184F076B0-0x0000000184F07770
		// [XID] // 0x0000000189AF2900-0x0000000189AF2920
		public virtual void Tick() {} // 0x0000000184F07770-0x0000000184F07820
		// [XID] // 0x00000001898F7100-0x00000001898F7120
		public virtual void Destroy() {} // 0x0000000184F075F0-0x0000000184F076B0
	}
}
