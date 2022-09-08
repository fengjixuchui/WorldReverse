/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class KnownSectionBase<T> : SectionBase // TypeDefIndex: 10401
		where T : PBXObjectData, new()
	{
		// Fields
		private Dictionary<string, T> m_Entries;
		private string m_Name;
	
		// Properties
		public T this[string guid] { get => default; }
	
		// Constructors
		public KnownSectionBase() {} // Dummy constructor
		public KnownSectionBase(string sectionName) {}
	
		// Methods
		public IEnumerable<KeyValuePair<string, T>> GetEntries() => default;
		public IEnumerable<string> GetGuids() => default;
		public IEnumerable<T> GetObjects() => default;
		public override void AddObject(string key, PBXElementDict value) {}
		public override void WriteSection(StringBuilder sb, GUIDToCommentMap comments) {}
		public bool HasEntry(string guid) => default;
		public void AddEntry(T obj) {}
		public void RemoveEntry(string guid) {}
	}
}
