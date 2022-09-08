/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	[CustomObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	internal interface IHardwareControllerMap_Internal // TypeDefIndex: 3774
	{
		// Properties
		IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers { get; }
	
		// Methods
		IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
	}
}
