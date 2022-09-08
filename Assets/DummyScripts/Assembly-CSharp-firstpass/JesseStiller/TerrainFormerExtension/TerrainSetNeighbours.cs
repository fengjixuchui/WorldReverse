/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace JesseStiller.TerrainFormerExtension
{
	public class TerrainSetNeighbours : MonoBehaviour // TypeDefIndex: 10073
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain leftTerrain; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain topTerrain; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain rightTerrain; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain bottomTerrain; // 0x30
	
		// Constructors
		public TerrainSetNeighbours() {} // 0x0000000186D21510-0x0000000186D21570
	
		// Methods
		// [XID] // 0x0000000189618100-0x0000000189618120
		private void Awake() {} // 0x0000000186D21310-0x0000000186D21410
		// [XID] // 0x000000018961FC30-0x000000018961FC50
		public void SetNeighbours(Terrain leftTerrain, Terrain topTerrain, Terrain rightTerrain, Terrain bottomTerrain) {} // 0x0000000186D21410-0x0000000186D21510
	}
}
