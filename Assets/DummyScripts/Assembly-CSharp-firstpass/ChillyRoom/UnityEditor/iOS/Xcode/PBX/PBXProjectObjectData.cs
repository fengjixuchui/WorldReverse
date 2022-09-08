/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ChillyRoom.UnityEditor.iOS.Xcode;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class PBXProjectObjectData : PBXObjectData // TypeDefIndex: 10393
	{
		// Fields
		private static PropertyCommentChecker checkerData; // 0x00
		public List<ProjectReference> projectReferences; // 0x20
		public List<string> targets; // 0x28
		public List<string> knownAssetTags; // 0x30
		public string buildConfigList; // 0x38
		public string entitlementsFile; // 0x40
		public List<PBXCapabilityType.TargetCapabilityPair> capabilities; // 0x48
		public Dictionary<string, string> teamIDs; // 0x50
	
		// Properties
		internal override PropertyCommentChecker checker { /* [XID] */ /* 0x0000000189A9BC20-0x0000000189A9BC40 */ get => default; } // 0x0000000186D32400-0x0000000186D324D0 
		public string mainGroup { /* [XID] */ /* 0x0000000189AA3180-0x0000000189AA31A0 */ get => default; } // 0x0000000186D324D0-0x0000000186D32580 
	
		// Constructors
		public PBXProjectObjectData() {} // 0x0000000186D322C0-0x0000000186D32400
		static PBXProjectObjectData() {} // 0x0000000186D32070-0x0000000186D322C0
	
		// Methods
		// [XID] // 0x0000000189AAA670-0x0000000189AAA690
		public void AddReference(string productGroup, string projectRef) {} // 0x0000000186D309E0-0x0000000186D30AD0
		// [XID] // 0x0000000189AB24F0-0x0000000189AB2510
		public override void UpdateProps() {} // 0x0000000186D30C00-0x0000000186D315F0
		// [XID] // 0x0000000189AB9980-0x0000000189AB99A0
		public override void UpdateVars() {} // 0x0000000186D315F0-0x0000000186D32070
	}
}
