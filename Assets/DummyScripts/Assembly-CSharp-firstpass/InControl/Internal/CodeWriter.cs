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

namespace InControl.Internal
{
	internal class CodeWriter // TypeDefIndex: 7999
	{
		// Fields
		private const char NewLine = '\x000a'; // Metadata: 0x00ADF3B3
		private int indent; // 0x10
		private StringBuilder stringBuilder; // 0x18
	
		// Constructors
		public CodeWriter() {} // 0x00000001870BDF10-0x00000001870BDFB0
	
		// Methods
		// [XID] // 0x0000000189B3D7F0-0x0000000189B3D810
		public void IncreaseIndent() {} // 0x00000001870BDD40-0x00000001870BDDE0
		// [XID] // 0x00000001899D3170-0x00000001899D3190
		public void DecreaseIndent() {} // 0x00000001870BDCA0-0x00000001870BDD40
		// [IDTag] // 0x0000000189B4CCB0-0x0000000189B4CCF0
		// [XID] // 0x0000000189B4CCB0-0x0000000189B4CCF0
		public void Append(string code) {} // 0x00000001870BDBE0-0x00000001870BDCA0
		// [IDTag] // 0x0000000189B573A0-0x0000000189B573E0
		// [XID] // 0x0000000189B573A0-0x0000000189B573E0
		public void Append(bool trim, string code) {} // 0x00000001870BD980-0x00000001870BDBE0
		// [IDTag] // 0x0000000189B619E0-0x0000000189B61A20
		// [XID] // 0x0000000189B619E0-0x0000000189B61A20
		public void AppendLine(string code) {} // 0x00000001870BD7E0-0x00000001870BD8B0
		// [IDTag] // 0x0000000189B6C1F0-0x0000000189B6C230
		// [XID] // 0x0000000189B6C1F0-0x0000000189B6C230
		public void AppendLine(int count) {} // 0x00000001870BD8B0-0x00000001870BD980
		// [XID] // 0x0000000189B76820-0x0000000189B76840
		public void AppendFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001870BD5E0-0x00000001870BD6E0
		// [XID] // 0x0000000189B85A60-0x0000000189B85A80
		public void AppendLineFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001870BD6E0-0x00000001870BD7E0
		// [XID] // 0x0000000189A0E8D0-0x0000000189A0E8F0
		public override string ToString() => default; // 0x00000001870BDDE0-0x00000001870BDEA0
	}
}
