/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Serialization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	// [XmlRoot] // 0x0000000189784A70-0x0000000189784AA0
	public class TestRun // TypeDefIndex: 27982
	{
		// Fields
		// [XmlElement] // 0x00000001898D8E80-0x00000001898D8EB0
		public TestSuite totalTestSuite; // 0x10
		// [XmlAttribute] // 0x0000000189833390-0x00000001898333C0
		public string id; // 0x18
		// [XmlAttribute] // 0x000000018983A880-0x000000018983A8B0
		public string name; // 0x20
		// [XmlAttribute] // 0x0000000189841EC0-0x0000000189841EF0
		public string fullname; // 0x28
		// [XmlAttribute] // 0x00000001897AED00-0x00000001897AED30
		public int testcasecount; // 0x30
		// [XmlAttribute] // 0x00000001897B8110-0x00000001897B8140
		public string result; // 0x38
		// [XmlAttribute] // 0x00000001897C1520-0x00000001897C1550
		public float time; // 0x40
		// [XmlAttribute] // 0x00000001897CA550-0x00000001897CA580
		public int total; // 0x44
		// [XmlAttribute] // 0x00000001898667B0-0x00000001898667E0
		public int passed; // 0x48
		// [XmlAttribute] // 0x000000018986E0F0-0x000000018986E120
		public int failed; // 0x4C
		// [XmlAttribute] // 0x0000000189875500-0x0000000189875530
		public int inconclusive; // 0x50
		// [XmlAttribute] // 0x000000018987D070-0x000000018987D0A0
		public int skipped; // 0x54
		// [XmlAttribute] // 0x0000000189884010-0x0000000189884040
		public int asserts; // 0x58
		// [XmlAttribute] // 0x00000001898008D0-0x0000000189800900
		public string runDate; // 0x60
		// [XmlAttribute] // 0x000000018988B730-0x000000018988B760
		public string startTime; // 0x68
		// [XmlAttribute] // 0x0000000189812410-0x0000000189812440
		public string platform; // 0x70
		// [XmlAttribute] // 0x000000018981B730-0x000000018981B760
		public string weixinUrl; // 0x78
	
		// Constructors
		public TestRun() {} // 0x0000000182194180-0x0000000182194210
	
		// Methods
		public void SaveToXml(string path, bool append = true /* Metadata: 0x00B0D23B */) {} // 0x0000000182193F10-0x0000000182194180
	}
}
