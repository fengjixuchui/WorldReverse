/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ChillyRoom.UnityEditor.iOS.Xcode;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class PBXFileReferenceData : PBXObjectData // TypeDefIndex: 10373
	{
		// Fields
		private string m_Path; // 0x20
		private string m_ExplicitFileType; // 0x28
		private string m_LastKnownFileType; // 0x30
		public string name; // 0x38
		public PBXSourceTree tree; // 0x40
	
		// Properties
		public string path { /* [XID] */ /* 0x0000000189873670-0x0000000189873690 */ get => default; /* [XID] */ /* 0x000000018987B0C0-0x000000018987B0E0 */ set {} } // 0x00000001864E2520-0x00000001864E25C0 0x00000001864E2660-0x00000001864E2720
		public bool isFolderReference { /* [XID] */ /* 0x00000001897769E0-0x0000000189776A00 */ get => default; } // 0x00000001864E2430-0x00000001864E2520 
		internal override bool shouldCompact { /* [XID] */ /* 0x00000001898897F0-0x0000000189889810 */ get => default; } // 0x00000001864E25C0-0x00000001864E2660 
	
		// Constructors
		public PBXFileReferenceData() {} // 0x00000001864E23A0-0x00000001864E2430
	
		// Methods
		// [XID] // 0x0000000189794160-0x0000000189794180
		public static PBXFileReferenceData CreateFromFile(string path, string projectFileName, PBXSourceTree tree) => default; // 0x00000001864E1C50-0x00000001864E1DB0
		// [XID] // 0x0000000189898300-0x0000000189898320
		public static PBXFileReferenceData CreateFromFolderReference(string path, string projectFileName, PBXSourceTree tree) => default; // 0x00000001864E1DB0-0x00000001864E1EA0
		// [XID] // 0x00000001897AAE00-0x00000001897AAE20
		public override void UpdateProps() {} // 0x00000001864E1FD0-0x00000001864E2240
		// [XID] // 0x00000001897D1270-0x00000001897D1290
		public override void UpdateVars() {} // 0x00000001864E2240-0x00000001864E23A0
	}
}
