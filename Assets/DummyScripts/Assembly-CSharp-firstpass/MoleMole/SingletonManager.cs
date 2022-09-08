/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	[Skip] // 0x0000000189622900-0x0000000189622910
	public class SingletonManager // TypeDefIndex: 10614
	{
		// Fields
		private Dictionary<string, object> _singletons; // 0x10
		public static Func<string, string> NameObfuscateFun; // 0x00
		private static SingletonManager _instance; // 0x08
	
		// Properties
		public static SingletonManager Instance { /* [XID] */ /* 0x00000001899D7FB0-0x00000001899D7FD0 */ get => default; } // 0x00000001868A4A00-0x00000001868A4B40 
	
		// Constructors
		public SingletonManager() {} // 0x00000001868A4970-0x00000001868A4A00
		static SingletonManager() {} // 0x00000001868A4910-0x00000001868A4970
	
		// Methods
		// [XID] // 0x00000001899BA130-0x00000001899BA150
		public void AddSingletonInstance(object singleton) {} // 0x00000001868A44A0-0x00000001868A45D0
		// [IDTag] // 0x00000001898735F0-0x0000000189873630
		// [XID] // 0x00000001898735F0-0x0000000189873630
		public void RemoveSingletonInstance(string typeName) {} // 0x00000001868A4830-0x00000001868A4910
		// [IDTag] // 0x000000018987E250-0x000000018987E290
		// [XID] // 0x000000018987E250-0x000000018987E290
		public void RemoveSingletonInstance(object singleton) {} // 0x00000001868A4740-0x00000001868A4830
		// [XID] // 0x00000001898880E0-0x0000000189888100
		public object GetSingletonInstance(string typeName) => default; // 0x00000001868A45D0-0x00000001868A4740
	}
}
