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
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor // TypeDefIndex: 4113
	{
		// Fields
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _scriptingName; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _alternateScriptingName; // 0x40
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _excludeFromExport; // 0x48
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _useEditorElementTypeOverride; // 0x49
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ControllerElementType _editorElementTypeOverride; // 0x4C
	
		// Properties
		internal string scriptingName { get => default; } // 0x0000000185D60AF0-0x0000000185D60B50 
		internal string alternateScriptingName { get => default; } // 0x0000000185D609E0-0x0000000185D60A40 
		internal ControllerTemplateElementType effectiveElementType { get => default; } // 0x0000000185D60A40-0x0000000185D60AF0 
		string IControllerTemplateElementIdentifier_Editor.scriptingName { get => default; } // 0x0000000185D608E0-0x0000000185D60940 
		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName { get => default; } // 0x0000000185D60880-0x0000000185D608E0 
	
		// Constructors
		public ControllerTemplateElementIdentifier_Editor() {} // 0x0000000185D60940-0x0000000185D609E0
	}
}
