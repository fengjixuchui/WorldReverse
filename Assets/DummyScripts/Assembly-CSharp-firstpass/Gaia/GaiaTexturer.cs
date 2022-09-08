/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class GaiaTexturer : MonoBehaviour // TypeDefIndex: 9163
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_liveUpdate; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_location; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Bounds m_boundsWU; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Bounds m_boundsScaledWU; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GaiaTextureCriteria> m_textureCriteria; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_textureMask; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaTexturerExtension m_texturerExtension; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_seaLevel; // 0x70
		private ComputeShader m_textureComputeShader; // 0x78
		private TexturerWorkItem[,] m_workItems; // 0x80
		private int m_jobsToCompute; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_useCompute; // 0x8C
		public string m_textureID; // 0x90
	
		// Properties
		public bool LiveUpdate { /* [XID] */ /* 0x0000000189689100-0x0000000189689120 */ get => default; /* [XID] */ /* 0x0000000189690C80-0x0000000189690CA0 */ set {} } // 0x0000000185ECEED0-0x0000000185ECEF70 0x0000000185ECF5E0-0x0000000185ECF690
		public Vector3 Location { /* [XID] */ /* 0x0000000189976130-0x0000000189976150 */ get => default; /* [XID] */ /* 0x000000018969F930-0x000000018969F950 */ set {} } // 0x0000000185ECEF70-0x0000000185ECF050 0x0000000185ECF690-0x0000000185ECF7C0
		public Bounds BoundsWU { /* [XID] */ /* 0x000000018961D4B0-0x000000018961D4D0 */ get => default; } // 0x0000000185ECEDE0-0x0000000185ECEED0 
		public Bounds ScaledBoundsWU { /* [XID] */ /* 0x0000000189A4A6F0-0x0000000189A4A710 */ get => default; } // 0x0000000185ECF1B0-0x0000000185ECF2A0 
		public List<GaiaTextureCriteria> TextureCriteria { /* [XID] */ /* 0x00000001899F1530-0x00000001899F1550 */ get => default; /* [XID] */ /* 0x0000000189615C60-0x0000000189615C80 */ set {} } // 0x0000000185ECF350-0x0000000185ECF3F0 0x0000000185ECF870-0x0000000185ECF920
		public Texture2D TextureMask { /* [XID] */ /* 0x00000001896C40E0-0x00000001896C4100 */ get => default; /* [XID] */ /* 0x00000001896CB540-0x00000001896CB560 */ set {} } // 0x0000000185ECF3F0-0x0000000185ECF490 0x0000000185ECF920-0x0000000185ECF9D0
		public GaiaTexturerExtension TexturerExtension { /* [XID] */ /* 0x00000001896D2AD0-0x00000001896D2AF0 */ get => default; /* [XID] */ /* 0x00000001896DA4F0-0x00000001896DA510 */ set {} } // 0x0000000185ECF490-0x0000000185ECF530 0x0000000185ECF9D0-0x0000000185ECFA80
		public float SeaLevel { /* [XID] */ /* 0x00000001896E1CD0-0x00000001896E1CF0 */ get => default; /* [XID] */ /* 0x0000000189B90500-0x0000000189B90520 */ set {} } // 0x0000000185ECF2A0-0x0000000185ECF350 0x0000000185ECF7C0-0x0000000185ECF870
		public float Progress { /* [XID] */ /* 0x0000000189BD6D20-0x0000000189BD6D40 */ get => default; } // 0x0000000185ECF050-0x0000000185ECF1B0 
		public bool UseCompute { /* [XID] */ /* 0x00000001896F7CF0-0x00000001896F7D10 */ get => default; /* [XID] */ /* 0x00000001896FF6F0-0x00000001896FF710 */ set {} } // 0x0000000185ECF530-0x0000000185ECF5E0 0x0000000185ECFA80-0x0000000185ECFB30
	
		// Constructors
		public GaiaTexturer() {} // 0x0000000185ECEB50-0x0000000185ECEDE0
	
		// Methods
		// [XID] // 0x0000000189706A40-0x0000000189706A60
		public void Initialise(bool forceFromWorld = true /* Metadata: 0x00AE548A */) {} // 0x0000000185ECE300-0x0000000185ECE550
		// [XID] // 0x000000018978D930-0x000000018978D950
		public void InitialiseFromTerrain(ComputeShader computeShader) {} // 0x0000000185ECDB50-0x0000000185ECE300
		// [IDTag] // 0x00000001897157D0-0x0000000189715810
		// [XID] // 0x00000001897157D0-0x0000000189715810
		public void InitiateTexturer() {} // 0x0000000185ECE830-0x0000000185ECEAB0
		// [IDTag] // 0x0000000189720220-0x0000000189720260
		// [XID] // 0x0000000189720220-0x0000000189720260
		public void InitiateTexturer(int tileX, int tileZ, UnityHeightMap hmOverride) {} // 0x0000000185ECE550-0x0000000185ECE830
		// [XID] // 0x000000018972A6E0-0x000000018972A700
		private void CalculateBounds() {} // 0x0000000185ECDA70-0x0000000185ECDB50
		// [XID] // 0x0000000189731E80-0x0000000189731EA0
		public void AddToSession(GaiaOperation.OperationType opType, string opName) {} // 0x0000000185ECD7A0-0x0000000185ECDA70
		// [ContextMenu] // 0x0000000189739510-0x0000000189739560
		// [XID] // 0x0000000189739510-0x0000000189739560
		public void OnRefresh() {} // 0x0000000185ECEAB0-0x0000000185ECEB50
	}
}
