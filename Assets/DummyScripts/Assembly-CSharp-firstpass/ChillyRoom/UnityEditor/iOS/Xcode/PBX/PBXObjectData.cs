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

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class PBXObjectData // TypeDefIndex: 10371
	{
		// Fields
		public string guid; // 0x10
		protected PBXElementDict m_Properties; // 0x18
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal virtual PropertyCommentChecker checker { /* [XID] */ /* 0x000000018981F770-0x000000018981F790 */ get => default; } // 0x0000000186D26860-0x0000000186D26930 
		internal virtual bool shouldCompact { /* [XID] */ /* 0x0000000189826D70-0x0000000189826D90 */ get => default; } // 0x0000000186D26930-0x0000000186D269D0 
	
		// Constructors
		public PBXObjectData() {} // 0x0000000186D267D0-0x0000000186D26860
		static PBXObjectData() {} // 0x0000000186D26750-0x0000000186D267D0
	
		// Methods
		// [XID] // 0x00000001897EAEA0-0x00000001897EAEC0
		internal void SetPropertiesWhenSerializing(PBXElementDict props) {} // 0x0000000186D26280-0x0000000186D26330
		// [XID] // 0x00000001897F2BB0-0x00000001897F2BD0
		internal PBXElementDict GetPropertiesWhenSerializing() => default; // 0x0000000186D25EE0-0x0000000186D25F80
		// [XID] // 0x00000001896E19E0-0x00000001896E1A00
		internal PBXElementDict GetPropertiesRaw() => default; // 0x0000000186D25E20-0x0000000186D25EE0
		// [XID] // 0x0000000189801A30-0x0000000189801A50
		protected string GetPropertyString(string name) => default; // 0x0000000186D261A0-0x0000000186D26280
		// [XID] // 0x0000000189808E90-0x0000000189808EB0
		protected void SetPropertyString(string name, string value) {} // 0x0000000186D26510-0x0000000186D26610
		// [XID] // 0x0000000189694760-0x0000000189694780
		protected List<string> GetPropertyList(string name) => default; // 0x0000000186D25F80-0x0000000186D261A0
		// [XID] // 0x00000001896FF4F0-0x00000001896FF510
		protected void SetPropertyList(string name, List<string> value) {} // 0x0000000186D26330-0x0000000186D26510
		// [XID] // 0x000000018982E420-0x000000018982E440
		public virtual void UpdateProps() {} // 0x0000000186D26610-0x0000000186D266B0
		// [XID] // 0x000000018970E190-0x000000018970E1B0
		public virtual void UpdateVars() {} // 0x0000000186D266B0-0x0000000186D26750
	}
}
