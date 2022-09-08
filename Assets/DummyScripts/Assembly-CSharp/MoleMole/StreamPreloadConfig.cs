/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class StreamPreloadConfig : ScriptableObject // TypeDefIndex: 31982
	{
		// Fields
		public List<StreamInfo> preloadList; // 0x18
	
		// Nested types
		[Serializable]
		public class StreamInfo // TypeDefIndex: 31983
		{
			// Fields
			public string path; // 0x10
			public string name; // 0x18
	
			// Constructors
			public StreamInfo() {} // 0x0000000182B1B750-0x0000000182B1B7B0
		}
	
		// Constructors
		public StreamPreloadConfig() {} // 0x0000000182B1B7B0-0x0000000182B1B840
	}
}
