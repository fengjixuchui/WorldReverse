/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data;
using Rewired.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal abstract class PlatformInitializer // TypeDefIndex: 3497
	{
		// Constructors
		protected PlatformInitializer() {} // 0x0000000185306F20-0x0000000185306F80
	
		// Methods
		public abstract object Initialize(ConfigVars configVars);
		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
