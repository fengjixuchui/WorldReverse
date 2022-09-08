/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class StatNodeCollector // TypeDefIndex: 10099
	{
		// Fields
		protected Queue<IStatNode> _rootStatStack; // 0x10
		protected Stack<IStatNode> _currentStatStack; // 0x18
		public Action<Queue<IStatNode>> onFrameEndCallback; // 0x20
	
		// Properties
		private IStatNode _currentNode { /* [XID] */ /* 0x000000018999ABF0-0x000000018999AC10 */ get => default; } // 0x00000001868AE660-0x00000001868AE720 
	
		// Constructors
		public StatNodeCollector() {} // 0x00000001868AE5F0-0x00000001868AE660
	
		// Methods
		// [XID] // 0x0000000189773700-0x0000000189773720
		public void OnFrameEnd() {} // 0x00000001868AE180-0x00000001868AE250
		// [XID] // 0x0000000189890D80-0x0000000189890DA0
		private void RequireNewBuffer() {} // 0x00000001868AE4E0-0x00000001868AE5F0
		// [XID] // 0x0000000189898360-0x0000000189898380
		public void PushStatNode(string inStatID) {} // 0x00000001868AE340-0x00000001868AE4E0
		// [XID] // 0x000000018989F580-0x000000018989F5A0
		public void PopStatNode(float deltaValue) {} // 0x00000001868AE250-0x00000001868AE340
		// [XID] // 0x00000001898A7100-0x00000001898A7120
		public void AddStatNode(string inStatID) {} // 0x00000001868ADFF0-0x00000001868AE180
	}
}
