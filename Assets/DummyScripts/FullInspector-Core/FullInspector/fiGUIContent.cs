/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public class fiGUIContent // TypeDefIndex: 4808
	{
		// Fields
		public static fiGUIContent Empty; // 0x00
		private string _text; // 0x10
		private string _tooltip; // 0x18
		private Texture _image; // 0x20
	
		// Properties
		public GUIContent AsGUIContent { get => default; } // 0x0000000185CFC920-0x0000000185CFC9C0 
		public bool IsEmpty { get => default; } // 0x0000000185CFC9C0-0x0000000185CFCAD0 
	
		// Constructors
		public fiGUIContent() {} // 0x0000000185CFC5C0-0x0000000185CFC680
		public fiGUIContent(string text) {} // 0x0000000185CFC710-0x0000000185CFC7D0
		public fiGUIContent(string text, string tooltip) {} // 0x0000000185CFC7D0-0x0000000185CFC890
		public fiGUIContent(string text, string tooltip, Texture image) {} // 0x0000000185CFC530-0x0000000185CFC5C0
		public fiGUIContent(Texture image) {} // 0x0000000185CFC890-0x0000000185CFC920
		public fiGUIContent(Texture image, string tooltip) {} // 0x0000000185CFC680-0x0000000185CFC710
		static fiGUIContent() {} // 0x0000000185CFC4B0-0x0000000185CFC530
	
		// Methods
		public static implicit operator GUIContent(fiGUIContent label) => default; // 0x0000000185CFCB90-0x0000000185CFCC30
		public static implicit operator fiGUIContent(string text) => default; // 0x0000000185CFCC30-0x0000000185CFCCC0
		public static implicit operator fiGUIContent(GUIContent label) => default; // 0x0000000185CFCAD0-0x0000000185CFCB90
	}
}
