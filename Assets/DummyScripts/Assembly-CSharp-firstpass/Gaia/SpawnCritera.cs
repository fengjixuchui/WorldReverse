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

namespace Gaia
{
	[Serializable]
	public class SpawnCritera // TypeDefIndex: 9307
	{
		// Fields
		// [Tooltip] // 0x000000018988C940-0x000000018988C970
		public string m_name; // 0x10
		// [Tooltip] // 0x0000000189895410-0x0000000189895440
		public GaiaConstants.SpawnerLocationCheckType m_checkType; // 0x18
		// [Tooltip] // 0x000000018989E140-0x000000018989E170
		public bool m_virginTerrain; // 0x1C
		// [Tooltip] // 0x00000001898A7150-0x00000001898A7180
		public bool m_checkHeight; // 0x1D
		// [Tooltip] // 0x00000001898B0230-0x00000001898B0260
		public float m_minHeight; // 0x20
		// [Tooltip] // 0x00000001898B93F0-0x00000001898B9420
		public float m_maxHeight; // 0x24
		// [Tooltip] // 0x00000001898C1F30-0x00000001898C1F60
		public AnimationCurve m_heightFitness; // 0x28
		// [Tooltip] // 0x00000001898CB070-0x00000001898CB0A0
		public bool m_checkSlope; // 0x30
		// [Tooltip] // 0x00000001898D3F50-0x00000001898D3F80
		public float m_minSlope; // 0x34
		// [Tooltip] // 0x00000001898DD170-0x00000001898DD1A0
		public float m_maxSlope; // 0x38
		// [Tooltip] // 0x00000001898E64D0-0x00000001898E6500
		public AnimationCurve m_slopeFitness; // 0x40
		// [Tooltip] // 0x00000001898EF790-0x00000001898EF7C0
		public bool m_checkProximity; // 0x48
		// [Tooltip] // 0x00000001898F88E0-0x00000001898F8910
		public string m_proximityTag; // 0x50
		// [Tooltip] // 0x0000000189901920-0x0000000189901950
		public float m_minProximity; // 0x58
		// [Tooltip] // 0x000000018990A690-0x000000018990A6C0
		public float m_maxProximity; // 0x5C
		// [Tooltip] // 0x00000001899139A0-0x00000001899139D0
		public AnimationCurve m_proximityFitness; // 0x60
		// [Tooltip] // 0x000000018991CC20-0x000000018991CC50
		public bool m_checkTexture; // 0x68
		// [Tooltip] // 0x0000000189925AE0-0x0000000189925B10
		public string m_matchingTextures; // 0x70
		// [Tooltip] // 0x000000018992E9B0-0x000000018992E9E0
		public bool m_isActive; // 0x78
		private bool m_isInitialised; // 0x79
	
		// Constructors
		public SpawnCritera() {} // 0x0000000185A0FC30-0x0000000185A0FFB0
	
		// Methods
		// [XID] // 0x00000001897567E0-0x0000000189756800
		public void Initialise(Spawner spawner) {} // 0x0000000185A0F980-0x0000000185A0FC30
		// [XID] // 0x00000001898D35D0-0x00000001898D35F0
		public float GetSlopeFitness(float slope) => default; // 0x0000000185A0F5E0-0x0000000185A0F6F0
		// [XID] // 0x00000001899465A0-0x00000001899465C0
		public float GetHeightFitness(float height, float sealLevel) => default; // 0x0000000185A0F390-0x0000000185A0F4D0
		// [XID] // 0x00000001899BF7B0-0x00000001899BF7D0
		public float GetProximityFitness(float proximity) => default; // 0x0000000185A0F4D0-0x0000000185A0F5E0
		// [XID] // 0x000000018995D7E0-0x000000018995D800
		public float GetTextureFitness(float[] textures) => default; // 0x0000000185A0F6F0-0x0000000185A0F980
		// [XID] // 0x000000018995CBA0-0x000000018995CBC0
		public float GetFitness(ref SpawnInfo spawnInfo) => default; // 0x0000000185A0EE30-0x0000000185A0F390
		// [XID] // 0x00000001899643D0-0x00000001899643F0
		private float GetFitnessOnStone(ref SpawnInfo spawnInfo) => default; // 0x0000000185A0E650-0x0000000185A0EE30
	}
}
