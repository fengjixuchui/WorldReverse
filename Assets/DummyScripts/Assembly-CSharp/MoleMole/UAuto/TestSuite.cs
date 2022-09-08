/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Serialization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	// [XmlRoot] // 0x0000000189824330-0x0000000189824360
	public class TestSuite // TypeDefIndex: 27983
	{
		// Fields
		// [XmlAttribute] // 0x0000000189B216C0-0x0000000189B216F0
		public string type; // 0x10
		// [XmlAttribute] // 0x0000000189833390-0x00000001898333C0
		public int id; // 0x18
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
		// [XmlAttribute] // 0x000000018988B730-0x000000018988B760
		public string startTime; // 0x60
		// [XmlAttribute] // 0x0000000189892E30-0x0000000189892E60
		public string endTime; // 0x68
		// [XmlAttribute] // 0x000000018989BBC0-0x000000018989BBF0
		public float duration; // 0x70
		// [XmlAttribute] // 0x000000018993DDD0-0x000000018993DE00
		public string runstate; // 0x78
		// [XmlAttribute] // 0x00000001898AD890-0x00000001898AD8C0
		public string site; // 0x80
		// [XmlAttribute] // 0x00000001898B6570-0x00000001898B65A0
		public string video_url; // 0x88
		// [XmlArray] // 0x00000001898BF620-0x00000001898BF680
		// [XmlArrayItem] // 0x00000001898BF620-0x00000001898BF680
		public List<Property> properties; // 0x90
		// [XmlArray] // 0x00000001898CCC60-0x00000001898CCCC0
		// [XmlArrayItem] // 0x00000001898CCC60-0x00000001898CCCC0
		public List<Property> perf_urls; // 0x98
		public Failure failure; // 0xA0
		// [XmlElement] // 0x00000001898D8E80-0x00000001898D8EB0
		public List<TestSuite> testSuites; // 0xA8
		// [XmlElement] // 0x00000001898E0B90-0x00000001898E0BC0
		public List<TestCase> testCases; // 0xB0
	
		// Constructors
		public TestSuite() {} // 0x0000000182194210-0x0000000182194310
	}
}
