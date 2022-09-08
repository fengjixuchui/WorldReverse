/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class CrowdSpawnInfo // TypeDefIndex: 20375
	{
		// Fields
		public int crowdTypeID; // 0x10
		public int animConfigID; // 0x14
		public Vector3 spawnPosition; // 0x18
		public Quaternion spawnRotation; // 0x24
		public Color hairColor; // 0x34
		public Color[] bodyColors; // 0x48
		public bool sitOnChair; // 0x50
	
		// Constructors
		public CrowdSpawnInfo() {} // 0x0000000184D78B70-0x0000000184D78C10
	
		// Methods
		// [XID] // 0x000000018969BA30-0x000000018969BA50
		public void ResetSpawnInfo() {} // 0x0000000184D78410-0x0000000184D785A0
		// [XID] // 0x00000001896A30E0-0x00000001896A3100
		public void UpdateByConfig(ConfigCrowdSpawnInfo configInfo) {} // 0x0000000184D785A0-0x0000000184D78B70
	}
}
