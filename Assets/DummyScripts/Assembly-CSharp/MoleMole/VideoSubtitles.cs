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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class VideoSubtitles : MonoBehaviour // TypeDefIndex: 32011
	{
		// Fields
		private string _subtitleData; // 0x18
		private List<Subtitle> _subtitles; // 0x20
		private Subtitle _currentSubtitle; // 0x28
		private float _currentTimeMs; // 0x30
		public UnityEngine.UI.Text _text; // 0x38
	
		// Properties
		public float currentTimeMs { /* [XID] */ /* 0x0000000189758CC0-0x0000000189758CE0 */ get => default; /* [XID] */ /* 0x0000000189760990-0x00000001897609B0 */ set {} } // 0x0000000181D8AB40-0x0000000181D8ABF0 0x0000000181D8ABF0-0x0000000181D8ACA0
	
		// Constructors
		public VideoSubtitles() {} // 0x0000000181D8AAE0-0x0000000181D8AB40
	
		// Methods
		// [XID] // 0x0000000189767C40-0x0000000189767C60
		private void Start() {} // 0x0000000181D8A790-0x0000000181D8A900
		// [XID] // 0x000000018976F240-0x000000018976F260
		private void Update() {} // 0x0000000181D8A900-0x0000000181D8AAE0
		// [XID] // 0x0000000189776C40-0x0000000189776C60
		public void InitWithSubtitlePath(string subtitlePath) {} // 0x0000000181D8A1E0-0x0000000181D8A2A0
		// [XID] // 0x000000018977E350-0x000000018977E370
		private void UpdateCurrentSubtitle() {} // 0x0000000181D89BD0-0x0000000181D89D90
		// [XID] // 0x0000000189785A60-0x0000000189785A80
		private int ParseTimeToMs(string text) => default; // 0x0000000181D89D90-0x0000000181D89F90
		// [XID] // 0x000000018978D120-0x000000018978D140
		private void InitSubtitles(string filePath) {} // 0x0000000181D89F90-0x0000000181D8A1E0
		// [XID] // 0x00000001897944D0-0x00000001897944F0
		private List<Subtitle> LoadSubtitlesSrt(string data) => default; // 0x0000000181D8A2A0-0x0000000181D8A790
	}
}
