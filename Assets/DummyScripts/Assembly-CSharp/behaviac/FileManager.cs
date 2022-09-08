/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class FileManager // TypeDefIndex: 27209
	{
		// Fields
		private static FileManager ms_instance; // 0x00
	
		// Properties
		public static FileManager Instance { get => default; } // 0x0000000186DEAF50-0x0000000186DEB050 
	
		// Constructors
		public FileManager() {} // 0x0000000186DEAEB0-0x0000000186DEAF50
		static FileManager() {} // 0x0000000186DEAE50-0x0000000186DEAEB0
	
		// Methods
		public virtual byte[] FileOpen(string filePath, string ext) => default; // 0x0000000186DEAAD0-0x0000000186DEAE50
		public virtual void FileClose(string filePath, string ext, byte[] pBuffer) {} // 0x0000000186DEA9D0-0x0000000186DEAA20
		public virtual List<byte[]> DirOpen(string szDir, string ext) => default; // 0x0000000186DEA620-0x0000000186DEA9D0
		public virtual bool FileExist(string filePath, string ext) => default; // 0x0000000186DEAA20-0x0000000186DEAAD0
	}
}
