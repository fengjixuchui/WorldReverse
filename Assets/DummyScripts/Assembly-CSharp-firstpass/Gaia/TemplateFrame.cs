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

namespace Gaia
{
	public class TemplateFrame // TypeDefIndex: 9189
	{
		// Fields
		public Dictionary<string, TemplateFrameVariable> Variables; // 0x10
		public string FilePath; // 0x18
		public string Text; // 0x20
		private const char BeginChar = '{'; // Metadata: 0x00AE548C
		private const char EndChar = '}'; // Metadata: 0x00AE548E
		private int VariableCount; // 0x28
	
		// Constructors
		public TemplateFrame() {} // Dummy constructor
		public TemplateFrame(string filePath, bool debug) {} // 0x000000018645B160-0x000000018645B270
	
		// Methods
		// [XID] // 0x0000000189751520-0x0000000189751540
		public string Build(string filePath) => default; // 0x000000018645AE20-0x000000018645B160
		// [XID] // 0x0000000189758910-0x0000000189758930
		private char[] shiftCharArryLeft(char[] arry, int startIndex, int endIndex) => default; // 0x000000018645B490-0x000000018645B660
		// [XID] // 0x0000000189760650-0x0000000189760670
		private string getVarName(char[] text, ref int pos) => default; // 0x000000018645B270-0x000000018645B490
		// [XID] // 0x00000001897679F0-0x0000000189767A10
		private static int skipSpaces(char[] text, int pos) => default; // 0x000000018645B660-0x000000018645B740
	}
}
