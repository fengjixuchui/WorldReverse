/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class AtlasMatInfoProvider : ScriptableObject, IFaceMatInfoProvider // TypeDefIndex: 19806
	{
		// Fields
		public string basePath; // 0x18
		public AtlasItem[] items; // 0x20
		private Dictionary<int, FaceMatInfo> _faceMatCache; // 0x28
	
		// Properties
		public int capacity { /* [XID] */ /* 0x00000001896BA750-0x00000001896BA770 */ get => default; } // 0x0000000184E7D3C0-0x0000000184E7D470 
	
		// Constructors
		public AtlasMatInfoProvider() {} // 0x0000000184E7D330-0x0000000184E7D3C0
	
		// Methods
		// [XID] // 0x00000001896ABD70-0x00000001896ABD90
		public FaceMatInfo GetFaceMatInfo(int index) => default; // 0x0000000184E7CF40-0x0000000184E7D280
		// [XID] // 0x00000001896B2F30-0x00000001896B2F50
		public string[] GetMatInfoNames() => default; // 0x0000000184E7CD00-0x0000000184E7CEA0
		// [XID] // 0x00000001896C1820-0x00000001896C1840
		public void ClearTextureCache() {} // 0x0000000184E7D280-0x0000000184E7D330
		// [XID] // 0x0000000189702300-0x0000000189702320
		public void Clear() {} // 0x0000000184E7CEA0-0x0000000184E7CF40
	}
}
