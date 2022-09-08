/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class StandaloneWebResources : WebResources // TypeDefIndex: 6149
	{
		// Fields
		private const string FileHeader = "zfbRes_v1"; // Metadata: 0x00ADBC7A
		protected Dictionary<string, IndexEntry> toc; // 0x10
		protected string dataFile; // 0x18
		public const string DefaultPath = "Resources/browser_assets"; // Metadata: 0x00ADBC87
	
		// Nested types
		public struct IndexEntry // TypeDefIndex: 6150
		{
			// Fields
			public string name; // 0x00
			public long offset; // 0x08
			public int length; // 0x10
		}
	
		// Constructors
		public StandaloneWebResources() {} // Dummy constructor
		public StandaloneWebResources(string dataFile) {} // 0x00000001856BDD70-0x00000001856BDE60
	
		// Methods
		public void LoadIndex() {} // 0x00000001856BD390-0x00000001856BD5F0
		public override void HandleRequest(int id, string url) {} // 0x00000001856BD1B0-0x00000001856BD390
		public void WriteData(Dictionary<string, byte[]> files) {} // 0x00000001856BD5F0-0x00000001856BDD70
	}
}
