/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 9823
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x00AE6870
		public const int elementId_rightPedal = 1; // Metadata: 0x00AE6874
		public const int elementId_slide = 2; // Metadata: 0x00AE6878
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { /* [XID] */ /* 0x0000000189B00D00-0x0000000189B00D20 */ get => default; } // 0x000000018654E630-0x000000018654E6E0 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { /* [XID] */ /* 0x0000000189B083E0-0x0000000189B08400 */ get => default; } // 0x000000018654E6E0-0x000000018654E790 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { /* [XID] */ /* 0x0000000189B0FCF0-0x0000000189B0FD10 */ get => default; } // 0x000000018654E790-0x000000018654E840 
	
		// Constructors
		public FlightPedalsTemplate() {} // Dummy constructor
		public FlightPedalsTemplate(object payload) {} // 0x000000018654E8D0-0x000000018654E950
		static FlightPedalsTemplate() {} // 0x000000018654E840-0x000000018654E8D0
	}
}
