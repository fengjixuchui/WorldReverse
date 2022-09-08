/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYoSDKJSON
{
	public class JSONNumber : JSONNode // TypeDefIndex: 8909
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { /* [XID] */ /* 0x0000000189A01C20-0x0000000189A01C40 */ get => default; } // 0x0000000187264710-0x00000001872647B0 
		public override bool IsNumber { /* [XID] */ /* 0x0000000189A095C0-0x0000000189A095E0 */ get => default; } // 0x0000000187264670-0x0000000187264710 
		public override string Value { /* [XID] */ /* 0x0000000189A18170-0x0000000189A18190 */ get => default; /* [XID] */ /* 0x0000000189A1F810-0x0000000189A1F830 */ set {} } // 0x00000001872647B0-0x0000000187264880 0x00000001872649F0-0x0000000187264B00
		public override double AsDouble { /* [XID] */ /* 0x0000000189A26C20-0x0000000189A26C40 */ get => default; /* [XID] */ /* 0x0000000189A2E330-0x0000000189A2E350 */ set {} } // 0x0000000187264520-0x00000001872645D0 0x0000000187264880-0x0000000187264930
		public override long AsLong { /* [XID] */ /* 0x0000000189A35BE0-0x0000000189A35C00 */ get => default; /* [XID] */ /* 0x0000000189A3D210-0x0000000189A3D230 */ set {} } // 0x00000001872645D0-0x0000000187264670 0x0000000187264930-0x00000001872649F0
	
		// Constructors
		public JSONNumber() {} // Dummy constructor
		public JSONNumber(double aData) {} // 0x0000000187264370-0x0000000187264440
		public JSONNumber(string aData) {} // 0x0000000187264440-0x0000000187264520
	
		// Methods
		// [XID] // 0x0000000189A10BF0-0x0000000189A10C10
		public override Enumerator GetEnumerator() => default; // 0x0000000187263A80-0x0000000187263BF0
		// [XID] // 0x0000000189A44AC0-0x0000000189A44AE0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x0000000187264260-0x0000000187264370
		// [XID] // 0x0000000189A4C1E0-0x0000000189A4C200
		private static bool IsNumeric(object value) => default; // 0x0000000187263CA0-0x0000000187263E30
		// [XID] // 0x0000000189A539B0-0x0000000189A539D0
		public override bool Equals(object obj) => default; // 0x00000001872638F0-0x0000000187263A80
		// [XID] // 0x0000000189A5B0A0-0x0000000189A5B0C0
		public override int GetHashCode() => default; // 0x0000000187263BF0-0x0000000187263CA0
	}
}
