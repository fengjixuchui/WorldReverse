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

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	internal abstract class AssetCatalogItem // TypeDefIndex: 10340
	{
		// Fields
		public readonly string name; // 0x10
		public readonly string authorId; // 0x18
		protected Dictionary<string, string> m_Properties; // 0x20
		protected string m_Path; // 0x28
	
		// Properties
		public string path { /* [XID] */ /* 0x0000000189ACEC30-0x0000000189ACEC50 */ get; } // 0x00000001864C92B0-0x00000001864C9350 
	
		// Constructors
		protected AssetCatalogItem() {} // Dummy constructor
		public AssetCatalogItem(string name, string authorId) {} // 0x00000001864C91C0-0x00000001864C92B0
	
		// Methods
		// [XID] // 0x0000000189AED2F0-0x0000000189AED310
		protected JsonElementDict WriteInfoToJson(JsonDocument doc) => default; // 0x00000001864C90B0-0x00000001864C91C0
		public abstract void Write(List<string> warnings);
	}
}
