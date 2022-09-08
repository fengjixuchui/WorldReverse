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
	public class GaiaCompatiblePublisher // TypeDefIndex: 9183
	{
		// Fields
		public string m_publisherName; // 0x10
		public bool m_installedFoldedOut; // 0x18
		public bool m_compatibleFoldedOut; // 0x19
		private Dictionary<string, GaiaCompatiblePackage> m_packages; // 0x20
	
		// Constructors
		public GaiaCompatiblePublisher() {} // 0x000000018658AD60-0x000000018658ADF0
	
		// Methods
		// [XID] // 0x00000001896FEA20-0x00000001896FEA40
		public GaiaCompatiblePackage GetPackage(string packageName) => default; // 0x000000018658A880-0x000000018658A970
		// [XID] // 0x00000001896D4380-0x00000001896D43A0
		public List<GaiaCompatiblePackage> GetPackages() => default; // 0x000000018658A970-0x000000018658AAE0
		// [XID] // 0x0000000189A4B260-0x0000000189A4B280
		public int InstalledPackages() => default; // 0x000000018658AAE0-0x000000018658ACC0
		// [XID] // 0x00000001896E3360-0x00000001896E3380
		public int CompatiblePackages() => default; // 0x000000018658A6A0-0x000000018658A880
		// [XID] // 0x00000001896EA880-0x00000001896EA8A0
		public void AddPackage(GaiaCompatiblePackage package) {} // 0x000000018658A5C0-0x000000018658A6A0
	}
}
