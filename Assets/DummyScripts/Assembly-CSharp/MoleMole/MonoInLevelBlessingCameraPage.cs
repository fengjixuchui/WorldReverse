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
	public class MonoInLevelBlessingCameraPage : MonoUIProxy // TypeDefIndex: 29732
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoInputEasyTouch_H4 _easyTouch; // 0x48
		// [Range] // 0x00000001899B8FE0-0x00000001899B9030
		[SerializeField] // 0x00000001899B8FE0-0x00000001899B9030
		[Space] // 0x00000001899B8FE0-0x00000001899B9030
		private float _cameraFadeInDuration; // 0x50
		// [Range] // 0x0000000189609680-0x00000001896096C0
		[SerializeField] // 0x0000000189609680-0x00000001896096C0
		private float _scanRangeX; // 0x54
		// [Range] // 0x0000000189B51A30-0x0000000189B51A70
		[SerializeField] // 0x0000000189B51A30-0x0000000189B51A70
		private float _scanRangeY; // 0x58
		// [Range] // 0x0000000189BDBC60-0x0000000189BDBCA0
		[SerializeField] // 0x0000000189BDBC60-0x0000000189BDBCA0
		private float _scanRangeNearZ; // 0x5C
		// [Range] // 0x0000000189B15710-0x0000000189B15750
		[SerializeField] // 0x0000000189B15710-0x0000000189B15750
		private float _scanRangeFarZ; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _scanEnableRayCast; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _scanForceEnabled; // 0x65
		// [Range] // 0x00000001899FF430-0x00000001899FF470
		[SerializeField] // 0x00000001899FF430-0x00000001899FF470
		private float _scanTime; // 0x68
		// [Range] // 0x00000001899FF430-0x00000001899FF470
		[SerializeField] // 0x00000001899FF430-0x00000001899FF470
		private float _focusTime; // 0x6C
		// [Range] // 0x0000000189609680-0x00000001896096C0
		[SerializeField] // 0x0000000189609680-0x00000001896096C0
		private float _scanWeightZ; // 0x70
		// [Range] // 0x0000000189A1E420-0x0000000189A1E460
		[SerializeField] // 0x0000000189A1E420-0x0000000189A1E460
		private float _ignoreAvatarDistance; // 0x74
		// [Range] // 0x0000000189A288B0-0x0000000189A28900
		[SerializeField] // 0x0000000189A288B0-0x0000000189A28900
		[Space] // 0x0000000189A288B0-0x0000000189A28900
		private float _brokenCameraPostEffectDurantion; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fixedCameraPostEffectMinFrequency; // 0x7C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fixedCameraPostEffectMaxFrequency; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _scanTargetText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _scanNumText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnReturn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnTakePhoto; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnOpenAlbum; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnCloseAlbum; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpAlbum; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _albumScroller; // 0xC0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _targetIndicator; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _targetIndicatorAnimator; // 0xD0
	
		// Properties
		public MonoInputEasyTouch_H4 easyTouch { /* [XID] */ /* 0x0000000189A962B0-0x0000000189A962D0 */ get => default; } // 0x0000000184700770-0x0000000184700810 
		public float cameraFadeInDuration { /* [XID] */ /* 0x0000000189A9D7E0-0x0000000189A9D800 */ get => default; } // 0x00000001847006C0-0x0000000184700770 
		public float scanRangeX { /* [XID] */ /* 0x0000000189AA50B0-0x0000000189AA50D0 */ get => default; } // 0x0000000184700ED0-0x0000000184700F80 
		public float scanRangeY { /* [XID] */ /* 0x0000000189AAC890-0x0000000189AAC8B0 */ get => default; } // 0x0000000184700F80-0x0000000184701030 
		public float scanRangeNearZ { /* [XID] */ /* 0x0000000189AB4130-0x0000000189AB4150 */ get => default; } // 0x0000000184700E20-0x0000000184700ED0 
		public float scanRangeFarZ { /* [XID] */ /* 0x0000000189ABBE70-0x0000000189ABBE90 */ get => default; } // 0x0000000184700D70-0x0000000184700E20 
		public bool scanEnableRayCast { /* [XID] */ /* 0x0000000189AC3600-0x0000000189AC3620 */ get => default; } // 0x0000000184700B80-0x0000000184700C20 
		public bool scanForceEnabled { /* [XID] */ /* 0x0000000189ACAC90-0x0000000189ACACB0 */ get => default; } // 0x0000000184700C20-0x0000000184700CC0 
		public float scanTime { /* [XID] */ /* 0x0000000189AD2700-0x0000000189AD2720 */ get => default; } // 0x00000001847010E0-0x0000000184701190 
		public float focusTime { /* [XID] */ /* 0x0000000189ADA190-0x0000000189ADA1B0 */ get => default; } // 0x0000000184700970-0x0000000184700A20 
		public float scanWeightZ { /* [XID] */ /* 0x0000000189AE1A50-0x0000000189AE1A70 */ get => default; } // 0x0000000184701190-0x0000000184701240 
		public float ignoreAvatarDistance { /* [XID] */ /* 0x0000000189AE9200-0x0000000189AE9220 */ get => default; } // 0x0000000184700AD0-0x0000000184700B80 
		public float brokenCameraPostEffectDurantion { /* [XID] */ /* 0x0000000189AF1010-0x0000000189AF1030 */ get => default; } // 0x0000000184700350-0x0000000184700400 
		public float fixedCameraPostEffectMinFrequency { /* [XID] */ /* 0x0000000189AF84B0-0x0000000189AF84D0 */ get => default; } // 0x00000001847008C0-0x0000000184700970 
		public float fixedCameraPostEffectMaxFrequency { /* [XID] */ /* 0x0000000189AFFBC0-0x0000000189AFFBE0 */ get => default; } // 0x0000000184700810-0x00000001847008C0 
		public string scanTargetText { /* [XID] */ /* 0x0000000189B07170-0x0000000189B07190 */ set {} } // 0x0000000184701470-0x0000000184701540
		public UnityEngine.UI.Text scanTarget { /* [XID] */ /* 0x0000000189B0E930-0x0000000189B0E950 */ get => default; } // 0x0000000184701030-0x00000001847010E0 
		public string scanNumText { /* [XID] */ /* 0x0000000189B15D20-0x0000000189B15D40 */ set {} } // 0x00000001847013A0-0x0000000184701470
		public UnityEngine.UI.Text scanNum { /* [XID] */ /* 0x0000000189B1D430-0x0000000189B1D450 */ get => default; } // 0x0000000184700CC0-0x0000000184700D70 
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x0000000189B24CB0-0x0000000189B24CD0 */ get => default; } // 0x0000000184700120-0x00000001847001E0 
		public MonoUIContainer BtnShoot { /* [XID] */ /* 0x0000000189B2C120-0x0000000189B2C140 */ get => default; } // 0x00000001847001E0-0x00000001847002A0 
		public MonoUIContainer BtnOpenAlbum { /* [XID] */ /* 0x0000000189B33710-0x0000000189B33730 */ get => default; } // 0x0000000184700060-0x0000000184700120 
		public MonoUIContainer BtnCloseAlbum { /* [XID] */ /* 0x0000000189B3B010-0x0000000189B3B030 */ get => default; } // 0x00000001846FFFA0-0x0000000184700060 
		public Button btnReturn { /* [XID] */ /* 0x0000000189B42810-0x0000000189B42830 */ get => default; } // 0x0000000184700560-0x0000000184700610 
		public Button btnTakePhoto { /* [XID] */ /* 0x0000000189B4A330-0x0000000189B4A350 */ get => default; } // 0x0000000184700610-0x00000001847006C0 
		public Button btnOpenAlbum { /* [XID] */ /* 0x0000000189B51AD0-0x0000000189B51AF0 */ get => default; } // 0x00000001847004B0-0x0000000184700560 
		public Button btnCloseAlbum { /* [XID] */ /* 0x0000000189B59250-0x0000000189B59270 */ get => default; } // 0x0000000184700400-0x00000001847004B0 
		public GameObject grpAlbum { /* [XID] */ /* 0x0000000189B60B20-0x0000000189B60B40 */ get => default; } // 0x0000000184700A20-0x0000000184700AD0 
		public MonoGridScroller albumScroller { /* [XID] */ /* 0x0000000189B681D0-0x0000000189B681F0 */ get => default; } // 0x00000001847002A0-0x0000000184700350 
		public RectTransform targetIndicator { /* [XID] */ /* 0x0000000189B6F570-0x0000000189B6F590 */ get => default; } // 0x00000001847012F0-0x00000001847013A0 
		public Animator targetIndicatorAnimator { /* [XID] */ /* 0x0000000189B76BF0-0x0000000189B76C10 */ get => default; } // 0x0000000184701240-0x00000001847012F0 
	
		// Constructors
		public MonoInLevelBlessingCameraPage() {} // 0x00000001846FFEA0-0x00000001846FFFA0
	}
}
