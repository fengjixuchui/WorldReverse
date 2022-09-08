/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public static class FileLocations // TypeDefIndex: 6091
	{
		// Fields
		public const string SlaveExecutable = "ZFGameBrowser"; // Metadata: 0x00ADBC06
		private static CEFDirs _dirs; // 0x00
	
		// Properties
		public static CEFDirs Dirs { get; } // 0x00000001856ADD60-0x00000001856ADDF0 
	
		// Nested types
		public class CEFDirs // TypeDefIndex: 6092
		{
			// Fields
			public string resourcesPath; // 0x10
			public string binariesPath; // 0x18
			public string localesPath; // 0x20
			public string subprocessFile; // 0x28
			public string logFile; // 0x30
			public string cachePath; // 0x38
	
			// Constructors
			public CEFDirs() {} // 0x00000001856A3F80-0x00000001856A3FE0
		}
	
		// Methods
		private static CEFDirs GetCEFDirs() => default; // 0x00000001856AD990-0x00000001856ADD60
	}
}
