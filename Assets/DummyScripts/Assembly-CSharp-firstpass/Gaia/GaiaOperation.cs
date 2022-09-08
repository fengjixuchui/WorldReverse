/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class GaiaOperation // TypeDefIndex: 9300
	{
		// Fields
		public string m_description; // 0x10
		public OperationType m_operationType; // 0x18
		public bool m_isActive; // 0x1C
		public string m_generatedByName; // 0x20
		public string m_generatedByID; // 0x28
		public string m_generatedByType; // 0x30
		public string m_operationDateTime; // 0x38
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] m_operationDataJson; // 0x40
		public bool m_isFoldedOut; // 0x48
	
		// Nested types
		public enum OperationType // TypeDefIndex: 9301
		{
			CreateTerrain = 0,
			FlattenTerrain = 1,
			SmoothTerrain = 2,
			ClearDetails = 3,
			ClearTrees = 4,
			Stamp = 5,
			StampUndo = 6,
			StampRedo = 7,
			Spawn = 8,
			SpawnReset = 9,
			Stamp2 = 10,
			Texture2 = 11
		}
	
		// Constructors
		public GaiaOperation() {} // 0x000000018658E390-0x000000018658E470
	}
}
