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
	// [RequireComponent] // 0x00000001896B45D0-0x00000001896B4620
	public class MonoBaseCanvas : MonoBehaviour // TypeDefIndex: 30700
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Canvas _canvas; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _overflowMountPoint; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private List<Layer> _layers; // 0x28
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool _enableNotchBlock; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Texture2D _cursorTexture; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D _homeCursorTexture; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _uiWaterMask; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GraphicCast _blockInputMask; // 0x50
		private GameObject _guideLayoutSafeAreasAndMarginsGo; // 0x58
		private uint toolHandler; // 0x60
		private string GUID_TOOL_PATH; // 0x68
	
		// Properties
		public bool blockInputMaskEnable { /* [XID] */ /* 0x0000000189736CA0-0x0000000189736CC0 */ get => default; } // 0x00000001848F6C60-0x00000001848F6D60 
		public Texture2D cursorTexture { /* [XID] */ /* 0x0000000189874DB0-0x0000000189874DD0 */ get => default; } // 0x00000001848F6D60-0x00000001848F6E00 
		public Texture2D homeCursorTexture { /* [XID] */ /* 0x0000000189745B60-0x0000000189745B80 */ get => default; } // 0x00000001848F6E00-0x00000001848F6EA0 
		public bool ShowUIWaterMask { /* [XID] */ /* 0x000000018974D650-0x000000018974D670 */ set {} } // 0x00000001848F6EA0-0x00000001848F6F90
	
		// Nested types
		[Serializable]
		private struct Layer // TypeDefIndex: 30701
		{
			// Fields
			public int maxLayerOrder; // 0x00
			public RectTransform mountPoint; // 0x08
		}
	
		// Constructors
		public MonoBaseCanvas() {} // 0x00000001848F6BD0-0x00000001848F6C60
	
		// Methods
		// [XID] // 0x000000018970A050-0x000000018970A070
		public virtual void Reset() {} // 0x00000001848F6580-0x00000001848F69D0
		// [XID] // 0x0000000189711B10-0x0000000189711B30
		public virtual void OnDestroy() {} // 0x00000001848F6430-0x00000001848F6580
		// [XID] // 0x0000000189718FF0-0x0000000189719010
		public RectTransform GetLayerMountPoint(int layerOrder) => default; // 0x00000001848F62A0-0x00000001848F6430
		// [XID] // 0x00000001897206B0-0x00000001897206D0
		public bool AnyMounted() => default; // 0x00000001848F6140-0x00000001848F62A0
		// [XID] // 0x0000000189727C60-0x0000000189727C80
		public void SetCanvasEnable(bool enable) {} // 0x00000001848F6AF0-0x00000001848F6BD0
		// [XID] // 0x000000018972F2C0-0x000000018972F2E0
		public void SetBlockInputMaskEnable(bool enable) {} // 0x00000001848F69D0-0x00000001848F6AF0
	}
}
