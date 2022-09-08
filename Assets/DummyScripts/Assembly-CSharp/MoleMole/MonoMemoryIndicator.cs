/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMemoryIndicator : MonoBehaviour // TypeDefIndex: 31328
	{
		// Fields
		private EMode __mode; // 0x18
		private Transform _totalBtn; // 0x20
		private Transform _overviewPanel; // 0x28
		private Transform _detailPanel; // 0x30
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private float _refreshInterval; // 0x38
		private float _elapse; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _assetItemUIPrefab; // 0x40
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private int _assetItemUINum; // 0x48
		private uint _totalMemory; // 0x4C
		private Dictionary<MemoryUtil.E_AssetType, MemoryAssetDetailInfo> _detailInfoDict; // 0x50
		private MemoryUtil.E_AssetType _selectetAssetType; // 0x58
		private ScrollRect _scroller; // 0x60
		private UnityEngine.UI.Text _totalBtnText; // 0x68
		private UnityEngine.UI.Text _textureText; // 0x70
		private UnityEngine.UI.Text _renderTextureText; // 0x78
		private UnityEngine.UI.Text _meshText; // 0x80
		private UnityEngine.UI.Text _animClipText; // 0x88
		private UnityEngine.UI.Text _materialText; // 0x90
		private UnityEngine.UI.Text _monoHeapText; // 0x98
		private UnityEngine.UI.Text _monoUsedText; // 0xA0
		private UnityEngine.UI.Text _gameObjectText; // 0xA8
		private UnityEngine.UI.Text _audioText; // 0xB0
		private UnityEngine.UI.Text _luaText; // 0xB8
		private UnityEngine.UI.Text _skinnedMeshRendererText; // 0xC0
		private UnityEngine.UI.Text _overheadText; // 0xC8
		private Dictionary<MemoryUtil.E_AssetType, UnityEngine.UI.Text> _assetTexts; // 0xD0
	
		// Properties
		private EMode _mode { /* [XID] */ /* 0x000000018994AFB0-0x000000018994AFD0 */ get => default; /* [XID] */ /* 0x0000000189952950-0x0000000189952970 */ set {} } // 0x0000000184940890-0x0000000184940930 0x0000000184940930-0x00000001849409F0
	
		// Nested types
		public enum EMode // TypeDefIndex: 31329
		{
			Total = 0,
			Overview = 1,
			Detail = 2
		}
	
		// Constructors
		public MonoMemoryIndicator() {} // 0x00000001849425D0-0x0000000184942700
	
		// Methods
		// [XID] // 0x0000000189959EF0-0x0000000189959F10
		private void RegisterAssetTexture(MemoryUtil.E_AssetType inAssetType, string WidgetName, Transform rootTransform) {} // 0x0000000184941A10-0x0000000184941CB0
		// [XID] // 0x0000000189961920-0x0000000189961940
		private UnityEngine.UI.Text CloneNewTextByTemplate(string newGOName, UnityEngine.UI.Text inText) => default; // 0x0000000184942240-0x00000001849423F0
		// [XID] // 0x0000000189968FD0-0x0000000189968FF0
		private void Awake() {} // 0x000000018493FFB0-0x0000000184940680
		// [XID] // 0x0000000189970A10-0x0000000189970A30
		private void Start() {} // 0x00000001849423F0-0x00000001849424B0
		// [XID] // 0x0000000189978410-0x0000000189978430
		private void Update() {} // 0x00000001849424B0-0x00000001849425D0
		// [XID] // 0x000000018997F4E0-0x000000018997F500
		public void OnTotalBtnClick() {} // 0x0000000184942150-0x0000000184942240
		// [XID] // 0x0000000189986E80-0x0000000189986EA0
		private void OnDetailBtnClick(MemoryUtil.E_AssetType assetType) {} // 0x00000001849416A0-0x0000000184941760
		// [XID] // 0x000000018998E910-0x000000018998E930
		public void OnTextureBtnClick() {} // 0x0000000184942090-0x0000000184942150
		// [XID] // 0x0000000189996550-0x0000000189996570
		public void OnRenderTextureBtnClick() {} // 0x0000000184941FD0-0x0000000184942090
		// [XID] // 0x000000018999DFF0-0x000000018999E010
		public void OnMeshBtnClick() {} // 0x0000000184941F10-0x0000000184941FD0
		// [XID] // 0x00000001899A5A50-0x00000001899A5A70
		public void OnAnimationClipBtnClick() {} // 0x0000000184941D90-0x0000000184941E50
		// [XID] // 0x00000001899AD0D0-0x00000001899AD0F0
		public void OnMaterialBtnClick() {} // 0x0000000184941E50-0x0000000184941F10
		// [XID] // 0x00000001899B4910-0x00000001899B4930
		private void RefreshView() {} // 0x00000001849409F0-0x0000000184940AD0
		// [XID] // 0x00000001899BBFA0-0x00000001899BBFC0
		private void RefreshView_Total() {} // 0x0000000184941760-0x0000000184941850
		// [XID] // 0x00000001899C3AD0-0x00000001899C3AF0
		private void RefreshView_Overview() {} // 0x0000000184941850-0x0000000184941920
		// [XID] // 0x00000001899CB0F0-0x00000001899CB110
		private void RefreshView_Detail() {} // 0x00000001849407D0-0x0000000184940890
		// [XID] // 0x00000001899D2600-0x00000001899D2620
		private void ResetScrollerPos() {} // 0x0000000184941CB0-0x0000000184941D90
		// [XID] // 0x00000001899D9D10-0x00000001899D9D30
		private void CheapSetActive(GameObject obj, bool enable) {} // 0x0000000184941920-0x0000000184941A10
		// [XID] // 0x00000001899E15F0-0x00000001899E1610
		private void SetText_Total() {} // 0x0000000184940680-0x00000001849407D0
		// [XID] // 0x00000001899E8CC0-0x00000001899E8CE0
		private void SetText_Overview() {} // 0x0000000184940AD0-0x00000001849416A0
		// [XID] // 0x00000001899F0640-0x00000001899F0660
		private void SetText_Detail() {} // 0x000000018493FC80-0x000000018493FFB0
	}
}
