/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml;
using System.Xml.Serialization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	// [XmlRoot] // 0x0000000189978810-0x0000000189978840
	public class Failure // TypeDefIndex: 27987
	{
		// Fields
		[XmlIgnore] // 0x0000000189A32AD0-0x0000000189A32AE0
		public string stackTrace; // 0x10
		[XmlIgnore] // 0x0000000189A32AD0-0x0000000189A32AE0
		public string message; // 0x18
	
		// Properties
		// [XmlElement] // 0x0000000189990640-0x0000000189990670
		public XmlCDataSection messageCData { get => default; set {} } // 0x000000018105FC10-0x000000018105FD00 0x000000018105FDF0-0x000000018105FE80
		// [XmlElement] // 0x0000000189999C50-0x0000000189999C80
		public XmlCDataSection stackTraceCData { get => default; set {} } // 0x000000018105FD00-0x000000018105FDF0 0x000000018105FE80-0x000000018105FF10
	
		// Constructors
		public Failure(string _message, string _stackTrace) {} // 0x000000018105FB10-0x000000018105FBA0
		public Failure(string _message) {} // 0x000000018105FBA0-0x000000018105FC10
		public Failure() {} // 0x000000018105FAB0-0x000000018105FB10
	}
}
