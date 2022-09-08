/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	internal interface IHardwareControllerTemplateMap_Internal // TypeDefIndex: 3927
	{
		// Properties
		string name { get; }
		Guid typeGuid { get; }
	
		// Methods
		int GetElementIdentifierCount();
		IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);
		IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);
		IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);
		qFwngCMEUbVOUWUBpxMUVdPUzPt GetAxisTarget(Controller controller, int elementIdentifierId);
		qFwngCMEUbVOUWUBpxMUVdPUzPt GetButtonTarget(Controller controller, int elementIdentifierId);
	}
}
