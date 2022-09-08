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
	public class Scanner : MonoBehaviour // TypeDefIndex: 9299
	{
		// Fields
		// [Tooltip] // 0x0000000189B40C50-0x0000000189B40C80
		public string m_featureName; // 0x18
		// [Range] // 0x0000000189B49E10-0x0000000189B49E60
		// [Tooltip] // 0x0000000189B49E10-0x0000000189B49E60
		public float m_baseLevel; // 0x20
		[HideInInspector] // 0x0000000189B55A40-0x0000000189B55AA0
		// [Range] // 0x0000000189B55A40-0x0000000189B55AA0
		// [Tooltip] // 0x0000000189B55A40-0x0000000189B55AA0
		public float m_scanResolution; // 0x24
		// [Tooltip] // 0x0000000189B64C70-0x0000000189B64CA0
		public UnityEngine.Material m_previewMaterial; // 0x28
		private HeightMap m_scanMap; // 0x30
		private Bounds m_scanBounds; // 0x38
		private int m_scanWidth; // 0x50
		private int m_scanDepth; // 0x54
		private int m_scanHeight; // 0x58
		private Vector3 m_groundOffset; // 0x5C
		private Vector3 m_groundSize; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_featureFolderName; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string[] m_folderNames; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_folderIndex; // 0x88
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private bool m_needFetchFolders; // 0x8C
	
		// Constructors
		public Scanner() {} // 0x0000000185A0B610-0x0000000185A0B780
	
		// Methods
		// [XID] // 0x00000001899B2550-0x00000001899B2570
		private void OnEnable() {} // 0x0000000185A0AAD0-0x0000000185A0AC90
		// [XID] // 0x0000000189B927C0-0x0000000189B927E0
		private void Awake() {} // 0x0000000185A08800-0x0000000185A088C0
		// [XID] // 0x0000000189B99CC0-0x0000000189B99CE0
		public void Reset() {} // 0x0000000185A0AEE0-0x0000000185A0B130
		// [XID] // 0x0000000189A3E170-0x0000000189A3E190
		public void LoadRawFile(string path) {} // 0x0000000185A097C0-0x0000000185A09CE0
		// [XID] // 0x0000000189BA8960-0x0000000189BA8980
		public void LoadTextureFile(Texture2D texture) {} // 0x0000000185A0A220-0x0000000185A0A710
		// [XID] // 0x0000000189AE9A70-0x0000000189AE9A90
		public void LoadTerain(Terrain terrain) {} // 0x0000000185A09CE0-0x0000000185A0A220
		// [XID] // 0x0000000189BB74B0-0x0000000189BB74D0
		public void LoadGameObject(GameObject go) {} // 0x0000000185A08C10-0x0000000185A097C0
		// [XID] // 0x0000000189BBEBD0-0x0000000189BBEBF0
		public string SaveScan() => default; // 0x0000000185A0B130-0x0000000185A0B450
		// [XID] // 0x0000000189BC6780-0x0000000189BC67A0
		private void UpdateScanner() {} // 0x0000000185A0B450-0x0000000185A0B610
		// [XID] // 0x0000000189BCE480-0x0000000189BCE4A0
		private void OnDrawGizmosSelected() {} // 0x0000000185A0A880-0x0000000185A0AAD0
		// [XID] // 0x0000000189BD5780-0x0000000189BD57A0
		public void OnChangedAssetInProjectTab(string createdAssetpath) {} // 0x0000000185A0A710-0x0000000185A0A880
		// [ContextMenu] // 0x0000000189BDD350-0x0000000189BDD3A0
		// [XID] // 0x0000000189BDD350-0x0000000189BDD3A0
		public void RefreshFolderNames() {} // 0x0000000185A0AC90-0x0000000185A0AEE0
		// [XID] // 0x00000001895EE690-0x00000001895EE6B0
		private string GetGaiaAssetPath(string folderName, string featureName) => default; // 0x0000000185A088C0-0x0000000185A08A40
		// [XID] // 0x00000001896963B0-0x00000001896963D0
		private string GetGaiaStampAssetPath(string folderName, string featureName) => default; // 0x0000000185A08A40-0x0000000185A08C10
	}
}
