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
	public class ScreenShotter : MonoBehaviour // TypeDefIndex: 9349
	{
		// Fields
		public KeyCode m_screenShotKey; // 0x18
		public GaiaConstants.StorageFormat m_imageFormat; // 0x1C
		public string m_targetDirectory; // 0x20
		public int m_targetWidth; // 0x28
		public int m_targetHeight; // 0x2C
		public bool m_useScreenSize; // 0x30
		public Camera m_mainCamera; // 0x38
		private bool m_takeShot; // 0x40
		private bool m_refreshAssetDB; // 0x41
		public Texture2D m_watermark; // 0x48
	
		// Constructors
		public ScreenShotter() {} // 0x0000000185A0CAA0-0x0000000185A0CB40
	
		// Methods
		// [XID] // 0x0000000189867A50-0x0000000189867A70
		private void OnEnable() {} // 0x0000000185A0BDD0-0x0000000185A0BF40
		// [XID] // 0x0000000189BAE240-0x0000000189BAE260
		private void OnDisable() {} // 0x0000000185A0BD30-0x0000000185A0BDD0
		// [XID] // 0x0000000189876610-0x0000000189876630
		private string ScreenShotName(int width, int height) => default; // 0x0000000185A0BF40-0x0000000185A0CA00
		// [XID] // 0x0000000189BC4D80-0x0000000189BC4DA0
		public void TakeHiResShot() {} // 0x0000000185A0CA00-0x0000000185A0CAA0
		// [XID] // 0x0000000189BD3F30-0x0000000189BD3F50
		private void LateUpdate() {} // 0x0000000185A0B9E0-0x0000000185A0BD30
		// [XID] // 0x000000018988C920-0x000000018988C940
		public Texture2D AddWatermark(Texture2D background, Texture2D watermark) => default; // 0x0000000185A0B780-0x0000000185A0B9E0
	}
}
