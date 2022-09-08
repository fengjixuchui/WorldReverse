/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIWaterMask : MonoBehaviour // TypeDefIndex: 31319
	{
		// Fields
		public int _originalWatermarkWidth; // 0x18
		public int _originalWatermarkHeight; // 0x1C
		public double _gainFactor; // 0x20
		public int _randomSeed; // 0x28
		public int _scaleFactor; // 0x2C
		public Camera _camera; // 0x30
		public UnityEngine.UI.Text _uidText; // 0x38
		public MonoCanvasScalerEx _canvasScalerEx; // 0x40
		private Texture2D _tex; // 0x48
	
		// Constructors
		public MonoUIWaterMask() {} // 0x000000018489BD60-0x000000018489BE00
	
		// Methods
		// [XID] // 0x00000001896C5BD0-0x00000001896C5BF0
		public void SetUID(uint userId) {} // 0x000000018489BBA0-0x000000018489BD60
		// [XID] // 0x00000001896CD340-0x00000001896CD360
		public Texture2D AddWatermark(uint userId) => default; // 0x000000018489B4A0-0x000000018489B8F0
		// [XID] // 0x00000001896D4770-0x00000001896D4790
		private static string MapCharacter(string s) => default; // 0x000000018489B8F0-0x000000018489BBA0
		// [XID] // 0x00000001896CE940-0x00000001896CE960
		private Texture2D GetTexture2D(string watermaskStr) => default; // 0x000000018489AF30-0x000000018489B4A0
	}
}
