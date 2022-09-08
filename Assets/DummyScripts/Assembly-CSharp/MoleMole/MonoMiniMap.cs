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
	public class MonoMiniMap : MonoBehaviour // TypeDefIndex: 31253
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpMap; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpMapBack; // 0x28
		// [Header] // 0x00000001899D1270-0x00000001899D12B0
		[SerializeField] // 0x00000001899D1270-0x00000001899D12B0
		private RectTransform _markContainer; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _unusedMarkContainer; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _maskedMarkLayer; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform[] _markContainerLayers; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _localAvatarMark; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _sightFanMark; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _directionMark; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpMiniBackRotate; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgMiniBack; // 0x70
		// [Range] // 0x000000018998D230-0x000000018998D2B0
		[SerializeField] // 0x000000018998D230-0x000000018998D2B0
		[Space] // 0x000000018998D230-0x000000018998D2B0
		// [Tooltip] // 0x000000018998D230-0x000000018998D2B0
		private float _areaMinDistance; // 0x78
		private Queue<MonoMapMark> _unusedMarkPool; // 0x80
		private MonoMapMark _markPrefab; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _hazardousArea; // 0x90
		private float _warningCooldown; // 0x98
		private float _warningTime; // 0x9C
		private bool _isWarning; // 0xA0
		private InLevelMainPageContext context; // 0xA8
	
		// Properties
		public bool IsWarning { /* [XID] */ /* 0x00000001899A70D0-0x00000001899A70F0 */ get => default; /* [XID] */ /* 0x00000001899AEA00-0x00000001899AEA20 */ set {} } // 0x0000000184944F70-0x0000000184945020 0x0000000184945670-0x0000000184945760
		public MonoMapMark markPrefab { /* [XID] */ /* 0x00000001899C51C0-0x00000001899C51E0 */ set {} } // 0x0000000184945760-0x0000000184945810
		public RectTransform grpMiniBackRotate { /* [XID] */ /* 0x00000001899CC890-0x00000001899CC8B0 */ get => default; } // 0x0000000184945210-0x00000001849452B0 
		public Image imgMiniBack { /* [XID] */ /* 0x00000001899D3FB0-0x00000001899D3FD0 */ get => default; } // 0x00000001849452B0-0x0000000184945350 
		public Button actionButton { /* [XID] */ /* 0x00000001899DB520-0x00000001899DB540 */ get => default; } // 0x0000000184945020-0x00000001849450C0 
		public RectTransform[] markContainerLayers { /* [XID] */ /* 0x00000001899E2C00-0x00000001899E2C20 */ get => default; } // 0x00000001849453F0-0x0000000184945490 
		public RectTransform localAvatarMark { /* [XID] */ /* 0x0000000189A16BC0-0x0000000189A16BE0 */ get => default; } // 0x0000000184945350-0x00000001849453F0 
		public RectTransform sightFanMark { /* [XID] */ /* 0x0000000189A1E220-0x0000000189A1E240 */ get => default; } // 0x0000000184945530-0x00000001849455D0 
		public RectTransform directionMark { /* [XID] */ /* 0x0000000189A25920-0x0000000189A25940 */ get => default; } // 0x0000000184945170-0x0000000184945210 
		public RectTransform markContainer { /* [XID] */ /* 0x0000000189A2CD40-0x0000000189A2CD60 */ get => default; } // 0x0000000184945490-0x0000000184945530 
		public RectTransform unusedMarkContainer { /* [XID] */ /* 0x0000000189A346D0-0x0000000189A346F0 */ get => default; } // 0x00000001849455D0-0x0000000184945670 
		public RectTransform GrpMap { /* [XID] */ /* 0x0000000189A3BB50-0x0000000189A3BB70 */ get => default; } // 0x0000000184944ED0-0x0000000184944F70 
		public GameObject GrpBackMap { /* [XID] */ /* 0x0000000189A437A0-0x0000000189A437C0 */ get => default; } // 0x0000000184944E20-0x0000000184944ED0 
		public float areaMinDistance { /* [XID] */ /* 0x0000000189A522F0-0x0000000189A52310 */ get => default; } // 0x00000001849450C0-0x0000000184945170 
	
		// Constructors
		public MonoMiniMap() {} // 0x0000000184944D50-0x0000000184944E20
	
		// Methods
		// [XID] // 0x00000001899B5D60-0x00000001899B5D80
		private void Update() {} // 0x0000000184944B80-0x0000000184944D50
		// [XID] // 0x00000001899BDAC0-0x00000001899BDAE0
		private void Start() {} // 0x0000000184944990-0x0000000184944B80
		// [XID] // 0x00000001899EA2F0-0x00000001899EA310
		public void SetMapBack(Image levelMapBack) {} // 0x0000000184944670-0x0000000184944850
		// [XID] // 0x00000001899F1D00-0x00000001899F1D20
		public void SetMapFog(MonoMapFogAreaGrp mapFogGrp) {} // 0x0000000184944850-0x0000000184944990
		// [XID] // 0x00000001899F9520-0x00000001899F9540
		public void AttachMapMark(RectTransform mapIcon, bool isOther = true /* Metadata: 0x00B12121 */, ConfigVMapMark cfg = null) {} // 0x0000000184944160-0x00000001849442F0
		// [XID] // 0x0000000189A00800-0x0000000189A00820
		public void DettachMapMark(RectTransform mapIcon) {} // 0x00000001849442F0-0x00000001849443E0
		// [XID] // 0x0000000189A08120-0x0000000189A08140
		public MonoMapMark AddMark(ConfigMarkIcon iconConfig) => default; // 0x0000000184943C60-0x0000000184944160
		// [XID] // 0x0000000189A0F4F0-0x0000000189A0F510
		public void ReuseMark(MonoMapMark mark) {} // 0x0000000184944530-0x0000000184944670
		// [XID] // 0x0000000189A4AC30-0x0000000189A4AC50
		public void MoveToMaskedLayer(MonoMapMark mark) {} // 0x00000001849443E0-0x0000000184944530
	}
}
