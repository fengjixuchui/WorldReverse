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
	public class MiniMapBaker : MonoBehaviour // TypeDefIndex: 26658
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Camera _bakerCamera; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MapScriptData _mapData; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _baseImageHeight; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _prefabImageWidth; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _savePath; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _prefabPath; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _mapBackTemplate; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RenderTexture _modeRT; // 0x48
		private float _aspectRatio; // 0x50
		private float _orthographicSize; // 0x54
		private float _cameraPovitX; // 0x58
		private float _cameraPovitZ; // 0x5C
		private Rect _editingLevelRect; // 0x60
		private RenderTexture _renderTexture; // 0x70
		private bool _bakeStarted; // 0x78
		private bool _bakeRenderFinished; // 0x79
		private List<Texture2D> _bakeList; // 0x80
	
		// Constructors
		public MiniMapBaker() {} // 0x000000018114E3D0-0x000000018114E4C0
	
		// Methods
		// [XID] // 0x0000000189664F80-0x0000000189664FA0
		private bool Init() => default; // 0x000000018114DBA0-0x000000018114E080
		// [XID] // 0x000000018966C5C0-0x000000018966C5E0
		private void BakeMap() {} // 0x000000018114E120-0x000000018114E200
		// [XID] // 0x00000001896744C0-0x00000001896744E0
		protected void BakeRender() {} // 0x000000018114D960-0x000000018114DA00
		// [XID] // 0x000000018967BCC0-0x000000018967BCE0
		protected void BakeWrite() {} // 0x000000018114D8B0-0x000000018114D960
		// [XID] // 0x0000000189683350-0x0000000189683370
		private void BakeClear() {} // 0x000000018114DA00-0x000000018114DBA0
		// [XID] // 0x000000018968AF20-0x000000018968AF40
		private void OnGUI() {} // 0x000000018114E200-0x000000018114E330
		// [XID] // 0x0000000189692C30-0x0000000189692C50
		private void Update() {} // 0x000000018114E330-0x000000018114E3D0
		// [XID] // 0x0000000189699EC0-0x0000000189699EE0
		private void LateUpdate() {} // 0x000000018114E080-0x000000018114E120
	}
}
